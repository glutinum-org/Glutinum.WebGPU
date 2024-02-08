module RotatingTriangle

open System
open Browser
open Glutinum.WebGPU
open Fable.Core
open Fable.Core.JsInterop

let canvas = document.getElementById ("canvas") :?> Types.HTMLCanvasElement
canvas.width <- 500
canvas.height <- 500

let vs =
    """
    struct Uniforms {
      modelMatrix : mat3x3<f32>
    };
    @group(0) @binding(0) var<uniform> uniforms : Uniforms;

    struct VertexOutput {
      @builtin(position) position : vec4<f32>
    };

    @vertex
    fn main(@location(0) a_position : vec2<f32>) -> VertexOutput {
      var output : VertexOutput;
      output.position = vec4<f32>(uniforms.modelMatrix * vec3<f32>(a_position, 0.0), 1.0);
      return output;
    }
"""

let fs =
    """
    @fragment
    fn main() -> @location(0) vec4<f32> {
      return vec4<f32>(0.9, 0.3, 0.6, 1.0);
    }
"""

promise {
    let! adapter = navigator.gpu.requestAdapter ()
    let! device = adapter.Value.requestDevice ()

    let context = canvas.getContext ("webgpu") :?> GPUCanvasContext

    let swapChainFormat = navigator.gpu.getPreferredCanvasFormat ()

    let swapChain =
        context.configure (
            GPUCanvasConfiguration(
                device = device,
                format = swapChainFormat,
                alphaMode = GPUCanvasAlphaMode.opaque
            )
        )

    let uniformBufferSize = 4 * 12

    let uniformBuffer =
        device.createBuffer (
            GPUBufferDescriptor(
                size = uniformBufferSize,
                usage = (GPUBufferUsage.UNIFORM ||| GPUBufferUsage.COPY_DST)
            )
        )

    let uniformBindGroupLayout =
        device.createBindGroupLayout (
            GPUBindGroupLayoutDescriptor(
                entries =
                    [| GPUBindGroupLayoutEntry(
                           binding = 0,
                           visibility = GPUShaderStage.VERTEX,
                           buffer = GPUBufferBindingLayout()
                       ) |]
            )
        )

    let x = GPUBufferBinding(buffer = uniformBuffer)

    let uniformBindGroup =
        device.createBindGroup (
            GPUBindGroupDescriptor(
                layout = uniformBindGroupLayout,
                entries =
                    [| GPUBindGroupEntry(
                           binding = 0,
                           resource = GPUBufferBinding(buffer = uniformBuffer)
                       ) |]
            )
        )

    let pipelineLayout =
        device.createPipelineLayout (
            GPUPipelineLayoutDescriptor(
                bindGroupLayouts = [| uniformBindGroupLayout |]
            )
        )

    // Fable should create a TypedArray for this but it doesn't
    // seems to do it. Perhaps we have a regression
    // let verticesData = [| 0.0, 0.0; -0.05, -0.65; 0.15, -0.8 |]

    let verticesData =
        JS.Constructors.Float32Array.Create
            [| 0.0
               0.0
               -0.05
               -0.65
               0.15
               -0.8 |]

    let verticesBuffer =
        device.createBuffer (
            GPUBufferDescriptor(
                size = verticesData.byteLength,
                usage = (GPUBufferUsage.VERTEX ||| GPUBufferUsage.COPY_DST),
                mappedAtCreation = true
            )
        )

    JS.Constructors.Float32Array
        .Create(verticesBuffer.getMappedRange ())
        .set (verticesData)

    verticesBuffer.unmap () |> ignore

    let pipeline =
        device.createRenderPipeline (
            GPURenderPipelineDescriptor(
                layout = pipelineLayout,
                vertex =
                    GPUVertexState(
                        ``module`` =
                            device.createShaderModule (
                                GPUShaderModuleDescriptor(code = vs)
                            ),
                        entryPoint = "main",
                        buffers =
                            [| GPUVertexBufferLayout(
                                   arrayStride = 2 * 4,
                                   stepMode = GPUVertexStepMode.vertex,
                                   attributes =
                                       [| GPUVertexAttribute(
                                              shaderLocation = 0,
                                              offset = 0,
                                              format = GPUVertexFormat.float32x2
                                          ) |]
                               )
                               |> Some |]
                    ),
                fragment =
                    GPUFragmentState(
                        ``module`` =
                            device.createShaderModule (
                                GPUShaderModuleDescriptor(code = fs)
                            ),
                        entryPoint = "main",
                        targets =
                            [| GPUColorTargetState(
                                   format = swapChainFormat
                            ) |> Some |]
                    ),
                primitive = GPUPrimitiveState(topology = GPUPrimitiveTopology.``triangle-list``)
            )
        )

    // The exemple that I used to port this Rotating Triangle
    // use an external library to calculate the model matrix
    let modelMatrix = emitJsExpr () "new Hilo3d.Matrix3()"
    let modelMatrixData = emitJsExpr () "new Float32Array(12)"
    let getModelMatrix (modelMatrix, modelMatrixData) =
        emitJsStatement (modelMatrix, modelMatrixData)
            """
$0.rotate(-30/180*Math.PI);
const elements = $0.elements;
$1.set(elements);
$1.copyWithin(8, 6, 9);
$1.copyWithin(4, 3, 6);
return $1
            """

    let render () =
        let commandEncoder = device.createCommandEncoder ()
        let textureView = context.getCurrentTexture().createView ()

        let renderPassDescriptor =
            GPURenderPassDescriptor(
                colorAttachments =
                    [| Some(
                           GPURenderPassColorAttachment(
                               view = textureView,
                               loadOp = GPULoadOp.clear,
                               storeOp = GPUStoreOp.store,
                               clearValue =
                                   GPUColorDict(
                                       r = 0,
                                       g = 0,
                                       b = 0,
                                       a = 1
                                   )
                           )
                       ) |]
            )

        device.queue.writeBuffer (
            uniformBuffer,
            0,
            getModelMatrix (modelMatrix, modelMatrixData)
        ) |> ignore

        let passEncoder = commandEncoder.beginRenderPass (renderPassDescriptor)
        passEncoder.setPipeline pipeline |> ignore
        passEncoder.setBindGroup(0, Some uniformBindGroup) |> ignore
        passEncoder.setVertexBuffer(0, Some verticesBuffer) |> ignore
        passEncoder.draw (3, 1, 0, 0) |> ignore
        passEncoder.``end`` () |> ignore

        device.queue.submit [| commandEncoder.finish () |] |> ignore

    let mutable oldTimestamp = 0.0

    let rec gameLoop (currentTimestamp: float) =
        if (currentTimestamp - oldTimestamp) >= 60.0 then
            render ()
            oldTimestamp <- currentTimestamp

        // Request the next frame
        window.requestAnimationFrame gameLoop |> ignore

    // Start the game loop
    window.requestAnimationFrame gameLoop |> ignore

    return ()
}
|> Promise.start
