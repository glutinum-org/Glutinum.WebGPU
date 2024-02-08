# Glutinum.WebGPU

Binding for [WebGPU](https://www.npmjs.com/package/@webgpu/types) API.

## Running local demo

```bash
pnpm install
dotnet tool restore
dotnet fable Demo --watch --run http-server Demo
# Navigate to http://localhost:8080
```

## Usage

Open `Glutinum.WebGPU` at the top of your file in order to use the WebGPU API.

```fsharp
open Browser
open Glutinum.WebGPU

let canvas = document.getElementById ("canvas") :?> Types.HTMLCanvasElement
canvas.width <- 500
canvas.height <- 500

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
                               clearValue = GPUColorDict(
                                   r = Random().NextDouble(),
                                   g = Random().NextDouble(),
                                   b = Random().NextDouble(),
                                   a = 1.0
                               )
                           )
                       ) |]
            )

        let passEncoder = commandEncoder.beginRenderPass (renderPassDescriptor)
        passEncoder.``end`` () |> ignore

        device.queue.submit [| commandEncoder.finish () |] |> ignore

    let mutable oldTimestamp = 0.0

    let rec gameLoop (currentTimestamp: float) =
        // Re-render every 500ms
        if (currentTimestamp - oldTimestamp) >= 500.0 then
            render ()
            oldTimestamp <- currentTimestamp

        // Request the next frame
        window.requestAnimationFrame gameLoop |> ignore

    // Start the game loop
    window.requestAnimationFrame gameLoop |> ignore

    return ()
}
|> Promise.start
```
