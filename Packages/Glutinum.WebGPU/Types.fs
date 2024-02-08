module rec Glutinum.WebGPU

open Fable.Core
open Browser.Types
open System

open System
open Fable.Core
open Fable.Core.JsInterop

type Iterable<'T> = System.Collections.Generic.IEnumerable<'T>

type Uint32Array = ResizeArray<uint32>

type Navigator with

    /// <summary>A global singleton providing top-level entry points like <see cref="GPU.requestAdapter" />.</summary>
    [<Emit("$0.gpu")>]
    member __.gpu: GPU = jsNative

type GPUOrigin2DStrict =
    U2<Iterable<GPUIntegerCoordinate>, GPUOrigin2DDictStrict>

[<AllowNullLiteral>]
type GPUOrigin2DDictStrict =
    inherit GPUOrigin2DDict

    [<Obsolete("Does not exist for GPUOrigin2D.")>]
    abstract z: obj option with get, set

type GPUExtent3DStrict =
    U2<Iterable<GPUIntegerCoordinate>, GPUExtent3DDictStrict>

[<AllowNullLiteral>]
type GPUExtent3DDictStrict =
    inherit GPUExtent3DDict

    [<Obsolete("The correct name is `depthOrArrayLayers`.")>]
    abstract depth: obj option with get, set

type GPUBindingResource =
    U4<GPUSampler, GPUTextureView, GPUBufferBinding, GPUExternalTexture>

type GPUBufferDynamicOffset = float

type GPUBufferUsageFlags = int

type GPUColor = U2<Iterable<float>, GPUColorDict>

type GPUColorWriteFlags = int

type GPUDepthBias = float

type GPUExtent3D = U2<Iterable<GPUIntegerCoordinate>, GPUExtent3DDict>

type GPUFlagsConstant = int

type GPUImageCopyExternalImageSource =
    U7<
        ImageBitmap,
        ImageData,
        HTMLImageElement,
        HTMLVideoElement,
        VideoFrame,
        HTMLCanvasElement,
        OffscreenCanvas
     >

type GPUIndex32 = float

type GPUIntegerCoordinate = float

type GPUIntegerCoordinateOut = float

type GPUMapModeFlags = float

type GPUOrigin2D = U2<Iterable<GPUIntegerCoordinate>, GPUOrigin2DDict>

type GPUOrigin3D = U2<Iterable<GPUIntegerCoordinate>, GPUOrigin3DDict>

type GPUPipelineConstantValue = float

type GPUSampleMask = float

type GPUShaderStageFlags = float

type GPUSignedOffset32 = float

type GPUSize32 = int32

type GPUSize32Out = int32

// Should probably be int64 but this gave me an error:
// Cannot convert a BigInt value to a number
type GPUSize64 = int32

// Should probably be int64  but this gave me an error:
// Cannot convert a BigInt value to a number
type GPUSize64Out = int32

type GPUStencilValue = float

type GPUTextureUsageFlags = float

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUAddressMode =
    | ``clamp-to-edge``
    | repeat
    | ``mirror-repeat``


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUAutoLayoutMode = | auto

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUBlendFactor =
    | zero
    | one
    | src
    | ``one-minus-src``
    | ``src-alpha``
    | ``one-minus-src-alpha``
    | dst
    | ``one-minus-dst``
    | ``dst-alpha``
    | ``one-minus-dst-alpha``
    | ``src-alpha-saturated``
    | constant
    | ``one-minus-constant``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUBlendOperation =
    | add
    | subtract
    | ``reverse-subtract``
    | min
    | max

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUBufferBindingType =
    | uniform
    | storage
    | ``read-only-storage``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUBufferMapState =
    | unmapped
    | pending
    | mapped

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUCanvasAlphaMode =
    | opaque
    | premultiplied

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUCompareFunction =
    | never
    | less
    | equal
    | ``less-equal``
    | greater
    | ``not-equal``
    | ``greater-equal``
    | always

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUCompilationMessageType =
    | error
    | warning
    | info

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUCullMode =
    | none
    | front
    | back

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUDeviceLostReason =
    | unknown
    | destroyed

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUErrorFilter =
    | validation
    | ``out-of-memory``
    | ``internal``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUFeatureName =
    | ``depth-clip-control``
    | ``depth32float-stencil8``
    | ``texture-compression-bc``
    | ``texture-compression-etc2``
    | ``texture-compression-astc``
    | ``timestamp-query``
    | ``indirect-first-instance``
    | ``shader-f16``
    | ``rg11b10ufloat-renderable``
    | ``bgra8unorm-storage``
    | ``float32-filterable``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUFilterMode =
    | nearest
    | linear

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUFrontFace =
    | ccw
    | cw

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUIndexFormat =
    | uint16
    | uint32

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPULoadOp =
    | load
    | clear

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUMipmapFilterMode =
    | nearest
    | linear

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUPipelineErrorReason =
    | validation
    | ``internal``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUPowerPreference =
    | ``low-power``
    | ``high-performance``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUPrimitiveTopology =
    | ``point-list``
    | ``line-list``
    | ``line-strip``
    | ``triangle-list``
    | ``triangle-strip``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUQueryType =
    | occlusion
    | timestamp

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUSamplerBindingType =
    | filtering
    | ``non-filtering``
    | comparison

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUStencilOperation =
    | keep
    | zero
    | replace
    | invert
    | ``increment-clamp``
    | ``decrement-clamp``
    | ``increment-wrap``
    | ``decrement-wrap``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUStorageTextureAccess =
    | ``read-only``
    | ``write-only``
    | ``read-write``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUStoreOp =
    | store
    | discard

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUTextureAspect =
    | all
    | ``stencil-only``
    | ``depth-only``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUTextureDimension =
    | ``1d``
    | ``2d``
    | ``3d``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUTextureFormat =
    | r8unorm
    | r8snorm
    | r8uint
    | r8sint
    | r16uint
    | r16sint
    | r16float
    | rg8unorm
    | rg8snorm
    | rg8uint
    | rg8sint
    | r32uint
    | r32sint
    | r32float
    | rg16uint
    | rg16sint
    | rg16float
    | rgba8unorm
    | ``rgba8unorm-srgb``
    | rgba8snorm
    | rgba8uint
    | rgba8sint
    | bgra8unorm
    | ``bgra8unorm-srgb``
    | rgb9e5ufloat
    | rgb10a2uint
    | rgb10a2unorm
    | rg11b10ufloat
    | rg32uint
    | rg32sint
    | rg32float
    | rgba16uint
    | rgba16sint
    | rgba16float
    | rgba32uint
    | rgba32sint
    | rgba32float
    | stencil8
    | depth16unorm
    | depth24plus
    | ``depth24plus-stencil8``
    | depth32float
    | ``depth32float-stencil8``
    | ``bc1-rgba-unorm``
    | ``bc1-rgba-unorm-srgb``
    | ``bc2-rgba-unorm``
    | ``bc2-rgba-unorm-srgb``
    | ``bc3-rgba-unorm``
    | ``bc3-rgba-unorm-srgb``
    | ``bc4-r-unorm``
    | ``bc4-r-snorm``
    | ``bc5-rg-unorm``
    | ``bc5-rg-snorm``
    | ``bc6h-rgb-ufloat``
    | ``bc6h-rgb-float``
    | ``bc7-rgba-unorm``
    | ``bc7-rgba-unorm-srgb``
    | ``etc2-rgb8unorm``
    | ``etc2-rgb8unorm-srgb``
    | ``etc2-rgb8a1unorm``
    | ``etc2-rgb8a1unorm-srgb``
    | ``etc2-rgba8unorm``
    | ``etc2-rgba8unorm-srgb``
    | ``eac-r11unorm``
    | ``eac-r11snorm``
    | ``eac-rg11unorm``
    | ``eac-rg11snorm``
    | ``astc-4x4-unorm``
    | ``astc-4x4-unorm-srgb``
    | ``astc-5x4-unorm``
    | ``astc-5x4-unorm-srgb``
    | ``astc-5x5-unorm``
    | ``astc-5x5-unorm-srgb``
    | ``astc-6x5-unorm``
    | ``astc-6x5-unorm-srgb``
    | ``astc-6x6-unorm``
    | ``astc-6x6-unorm-srgb``
    | ``astc-8x5-unorm``
    | ``astc-8x5-unorm-srgb``
    | ``astc-8x6-unorm``
    | ``astc-8x6-unorm-srgb``
    | ``astc-8x8-unorm``
    | ``astc-8x8-unorm-srgb``
    | ``astc-10x5-unorm``
    | ``astc-10x5-unorm-srgb``
    | ``astc-10x6-unorm``
    | ``astc-10x6-unorm-srgb``
    | ``astc-10x8-unorm``
    | ``astc-10x8-unorm-srgb``
    | ``astc-10x10-unorm``
    | ``astc-10x10-unorm-srgb``
    | ``astc-12x10-unorm``
    | ``astc-12x10-unorm-srgb``
    | ``astc-12x12-unorm``
    | ``astc-12x12-unorm-srgb``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUTextureSampleType =
    | float
    | ``unfilterable-float``
    | depth
    | sint
    | uint

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUTextureViewDimension =
    | ``1d``
    | ``2d``
    | ``2d-array``
    | cube
    | ``cube-array``
    | ``3d``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUVertexFormat =
    | uint8x2
    | uint8x4
    | sint8x2
    | sint8x4
    | unorm8x2
    | unorm8x4
    | snorm8x2
    | snorm8x4
    | uint16x2
    | uint16x4
    | sint16x2
    | sint16x4
    | unorm16x2
    | unorm16x4
    | snorm16x2
    | snorm16x4
    | float16x2
    | float16x4
    | float32
    | float32x2
    | float32x3
    | float32x4
    | uint32
    | uint32x2
    | uint32x3
    | uint32x4
    | sint32
    | sint32x2
    | sint32x3
    | sint32x4
    | [<CompiledName("unorm10-10-10-2")>] ``unorm10-10-10-2``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type GPUVertexStepMode =
    | vertex
    | instance


[<Global; AllowNullLiteralAttribute>]
type GPUBindGroupDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            layout: GPUBindGroupLayout,
            entries: Iterable<GPUBindGroupEntry>,
            ?label: string
        )
        =
        GPUBindGroupDescriptor()

    /// <summary>The <see cref="GPUBindGroupLayout" /> the entries of this bind group will conform to.</summary>
    member val layout: GPUBindGroupLayout = jsNative with get, set
    /// <summary>
    /// A list of entries describing the resources to expose to the shader for each binding
    /// described by the <see cref="GPUBindGroupDescriptor.layout" />.
    /// </summary>
    member val entries: Iterable<GPUBindGroupEntry> = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBindGroupEntry private () =

    [<ParamObject; Emit("$0")>]
    new(binding: GPUIndex32, resource: GPUSampler) = GPUBindGroupEntry()

    [<ParamObject; Emit("$0")>]
    new(binding: GPUIndex32, resource: GPUTextureView) = GPUBindGroupEntry()

    [<ParamObject; Emit("$0")>]
    new(binding: GPUIndex32, resource: GPUBufferBinding) = GPUBindGroupEntry()

    [<ParamObject; Emit("$0")>]
    new(binding: GPUIndex32, resource: GPUExternalTexture) = GPUBindGroupEntry()

    /// <summary>
    /// A unique identifier for a resource binding within the <see cref="GPUBindGroup" />, corresponding to a
    /// <see cref="GPUBindGroupLayoutEntry.binding">GPUBindGroupLayoutEntry.binding</see> and a
    /// </summary>
    member val binding: GPUIndex32 = jsNative with get, set
    /// <summary>
    /// The resource to bind, which may be a <see cref="GPUSampler" />, <see cref="GPUTextureView" />,
    /// <see cref="GPUExternalTexture" />, or <see cref="GPUBufferBinding" />.
    /// </summary>
    member val resource: GPUBindingResource = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBindGroupLayoutDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new(entries: Iterable<GPUBindGroupLayoutEntry>, ?label: string)
        =
        GPUBindGroupLayoutDescriptor()

    member val entries: Iterable<GPUBindGroupLayoutEntry> =
        jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBindGroupLayoutEntry
    [<ParamObject; Emit("$0")>]
    (
        binding: GPUIndex32,
        visibility: GPUShaderStageFlags,
        ?buffer: GPUBufferBindingLayout,
        ?sampler: GPUSamplerBindingLayout,
        ?texture: GPUTextureBindingLayout,
        ?storageTexture: GPUStorageTextureBindingLayout,
        ?externalTexture: GPUExternalTextureBindingLayout
    )
    =

    /// <summary>
    /// A unique identifier for a resource binding within the <see cref="GPUBindGroupLayout" />, corresponding
    /// to a <see cref="GPUBindGroupEntry.binding">GPUBindGroupEntry.binding</see> and a
    /// </summary>
    member val binding: GPUIndex32 = jsNative with get, set
    /// <summary>
    /// A bitset of the members of <see cref="GPUShaderStage" />.
    /// Each set bit indicates that a <see cref="GPUBindGroupLayoutEntry" />'s resource
    /// will be accessible from the associated shader stage.
    /// </summary>
    member val visibility: GPUShaderStageFlags = jsNative with get, set
    /// <summary>
    /// When map/exist|provided, indicates the binding resource type for this <see cref="GPUBindGroupLayoutEntry" />
    /// is <see cref="GPUBufferBinding" />.
    /// </summary>
    member val buffer: GPUBufferBindingLayout option = jsNative with get, set
    /// <summary>
    /// When map/exist|provided, indicates the binding resource type for this <see cref="GPUBindGroupLayoutEntry" />
    /// is <see cref="GPUSampler" />.
    /// </summary>
    member val sampler: GPUSamplerBindingLayout option = jsNative with get, set
    /// <summary>
    /// When map/exist|provided, indicates the binding resource type for this <see cref="GPUBindGroupLayoutEntry" />
    /// is <see cref="GPUTextureView" />.
    /// </summary>
    member val texture: GPUTextureBindingLayout option = jsNative with get, set

    /// <summary>
    /// When map/exist|provided, indicates the binding resource type for this <see cref="GPUBindGroupLayoutEntry" />
    /// is <see cref="GPUTextureView" />.
    /// </summary>
    member val storageTexture: GPUStorageTextureBindingLayout option =
        jsNative with get, set

    /// <summary>
    /// When map/exist|provided, indicates the binding resource type for this <see cref="GPUBindGroupLayoutEntry" />
    /// is <see cref="GPUExternalTexture" />.
    /// </summary>
    member val externalTexture: GPUExternalTextureBindingLayout option =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUBlendComponent =
    /// <summary>
    /// Defines the <see cref="GPUBlendOperation" /> used to calculate the values written to the target
    /// attachment components.
    /// </summary>
    abstract operation: GPUBlendOperation option with get, set
    /// <summary>Defines the <see cref="GPUBlendFactor" /> operation to be performed on values from the fragment shader.</summary>
    abstract srcFactor: GPUBlendFactor option with get, set
    /// <summary>Defines the <see cref="GPUBlendFactor" /> operation to be performed on values from the target attachment.</summary>
    abstract dstFactor: GPUBlendFactor option with get, set

[<AllowNullLiteral>]
type GPUBlendState =
    /// Defines the blending behavior of the corresponding render target for color channels.
    abstract color: GPUBlendComponent with get, set
    /// Defines the blending behavior of the corresponding render target for the alpha channel.
    abstract alpha: GPUBlendComponent with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBufferBinding
    [<ParamObject; Emit("$0")>]
    (buffer: GPUBuffer, ?offset: GPUSize64, ?size: GPUSize64)
    =

    /// <summary>The <see cref="GPUBuffer" /> to bind.</summary>
    member val buffer: GPUBuffer = jsNative with get, set
    /// <summary>
    /// The offset, in bytes, from the beginning of <see cref="GPUBufferBinding.buffer" /> to the
    /// beginning of the range exposed to the shader by the buffer binding.
    /// </summary>
    member val offset: GPUSize64 option = jsNative with get, set
    /// <summary>
    /// The size, in bytes, of the buffer binding.
    /// If not map/exist|provided, specifies the range starting at
    /// <see cref="GPUBufferBinding.offset" /> and ending at the end of <see cref="GPUBufferBinding.buffer" />.
    /// </summary>
    member val size: GPUSize64 option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBufferBindingLayout
    [<ParamObject; Emit("$0")>]
    (
        ?type_: GPUBufferBindingType,
        ?hasDynamicOffset: bool,
        ?minBindingSize: GPUSize64
    )
    =

    /// Indicates the type required for buffers bound to this bindings.
    member val ``type``: GPUBufferBindingType option = jsNative with get, set
    /// Indicates whether this binding requires a dynamic offset.
    member val hasDynamicOffset: bool option = jsNative with get, set
    /// <summary>
    /// Indicates the minimum <see cref="GPUBufferBinding.size" /> of a buffer binding used with this bind point.
    /// Bindings are always validated against this size in <see cref="GPUDevice.createBindGroup" />.
    /// If this *is not* <c>0</c>, pipeline creation additionally [$validating shader binding|validates$]
    /// that this value &amp;ge; the minimum buffer binding size of the variable.
    /// If this *is* <c>0</c>, it is ignored by pipeline creation, and instead draw/dispatch commands
    /// [$Validate encoder bind groups|validate$] that each binding in the <see cref="GPUBindGroup" />
    /// satisfies the minimum buffer binding size of the variable.
    /// Note:
    /// Similar execution-time validation is theoretically possible for other
    /// binding-related fields specified for early validation, like
    /// <see cref="GPUTextureBindingLayout.sampleType" /> and <see cref="GPUStorageTextureBindingLayout.format" />,
    /// which currently can only be validated in pipeline creation.
    /// However, such execution-time validation could be costly or unnecessarily complex, so it is
    /// available only for <see cref="GPUBufferBindingLayout.minBindingSize" /> which is expected to have the
    /// most ergonomic impact.
    /// </summary>
    member val minBindingSize: GPUSize64 option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUBufferDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            size: GPUSize64,
            usage: GPUBufferUsageFlags,
            ?mappedAtCreation: bool,
            ?label: string
        )
        =
        GPUBufferDescriptor()

    /// The size of the buffer in bytes.
    member val size: GPUSize64 = jsNative with get, set
    /// The allowed usages for the buffer.
    member val usage: GPUBufferUsageFlags = jsNative with get, set
    /// <summary>
    /// If <c>true</c> creates the buffer in an already mapped state, allowing
    /// <see cref="GPUBuffer.getMappedRange" /> to be called immediately. It is valid to set
    /// <see cref="GPUBufferDescriptor.mappedAtCreation" /> to <c>true</c> even if <see cref="GPUBufferDescriptor.usage" />
    /// does not contain <see cref="GPUBufferUsage.MAP_READ" /> or <see cref="GPUBufferUsage.MAP_WRITE" />. This can be
    /// used to set the buffer's initial data.
    /// Guarantees that even if the buffer creation eventually fails, it will still appear as if the
    /// mapped range can be written/read to until it is unmapped.
    /// </summary>
    member val mappedAtCreation: bool option = jsNative with get, set

[<AllowNullLiteral>]
type GPUCanvasConfiguration
    [<ParamObject; Emit("$0")>]
    (
        device: GPUDevice,
        format: GPUTextureFormat,
        ?usage: GPUTextureUsageFlags,
        ?viewFormats: Iterable<GPUTextureFormat>,
        ?colorSpace: PredefinedColorSpace,
        ?alphaMode: GPUCanvasAlphaMode
    )
    =
    /// <summary>
    /// The <see cref="GPUDevice" /> that textures returned by <see cref="GPUCanvasContext.getCurrentTexture" /> will be
    /// compatible with.
    /// </summary>
    member val device: GPUDevice = jsNative with get, set
    /// <summary>
    /// The format that textures returned by <see cref="GPUCanvasContext.getCurrentTexture" /> will have.
    /// Must be one of the Supported context formats.
    /// </summary>
    member val format: GPUTextureFormat = jsNative with get, set
    /// <summary>
    /// The usage that textures returned by <see cref="GPUCanvasContext.getCurrentTexture" /> will have.
    /// <see cref="GPUTextureUsage.RENDER_ATTACHMENT" /> is the default, but is not automatically included
    /// if the usage is explicitly set. Be sure to include <see cref="GPUTextureUsage.RENDER_ATTACHMENT" />
    /// when setting a custom usage if you wish to use textures returned by
    /// <see cref="GPUCanvasContext.getCurrentTexture" /> as color targets for a render pass.
    /// </summary>
    member val usage: GPUTextureUsageFlags option = jsNative with get, set

    /// <summary>
    /// The formats that views created from textures returned by
    /// <see cref="GPUCanvasContext.getCurrentTexture" /> may use.
    /// </summary>
    member val viewFormats: Iterable<GPUTextureFormat> option =
        jsNative with get, set

    /// <summary>
    /// The color space that values written into textures returned by
    /// <see cref="GPUCanvasContext.getCurrentTexture" /> should be displayed with.
    /// </summary>
    member val colorSpace: PredefinedColorSpace option = jsNative with get, set
    /// <summary>
    /// Determines the effect that alpha values will have on the content of textures returned by
    /// <see cref="GPUCanvasContext.getCurrentTexture" /> when read, displayed, or used as an image source.
    /// </summary>
    member val alphaMode: GPUCanvasAlphaMode option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUColorDict
    [<ParamObject; Emit("$0")>]
    (r: float, g: float, b: float, a: float)
    =

    /// The red channel value.
    member val r: float = jsNative with get, set
    /// The green channel value.
    member val g: float = jsNative with get, set
    /// The blue channel value.
    member val b: float = jsNative with get, set
    /// The alpha channel value.
    member val a: float = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUColorTargetState
    [<ParamObject; Emit("$0")>]
    (
        format: GPUTextureFormat,
        ?blend: GPUBlendState,
        ?writeMask: GPUColorWriteFlags
    )
    =

    /// <summary>
    /// The <see cref="GPUTextureFormat" /> of this color target. The pipeline will only be compatible with
    /// <see cref="GPURenderPassEncoder" />s which use a <see cref="GPUTextureView" /> of this format in the
    /// corresponding color attachment.
    /// </summary>
    member val format: GPUTextureFormat = jsNative with get, set
    /// The blending behavior for this color target. If left undefined, disables blending for this
    /// color target.
    member val blend: GPUBlendState option = jsNative with get, set
    /// Bitmask controlling which channels are are written to when drawing to this color target.
    member val writeMask: GPUColorWriteFlags option = jsNative with get, set

type GPUCommandBufferDescriptor = GPUObjectDescriptorBase

type GPUCommandEncoderDescriptor = GPUObjectDescriptorBase

[<Global; AllowNullLiteralAttribute>]
type GPUComputePassDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new(timestampWrites: GPUComputePassTimestampWrites, ?label: string)
        =
        GPUComputePassDescriptor()

    /// Defines which timestamp values will be written for this pass, and where to write them to.
    member val timestampWrites: GPUComputePassTimestampWrites option =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUComputePassTimestampWrites =
    /// <summary>
    /// The <see cref="GPUQuerySet" />, of type <see cref="GPUQueryType.">"timestamp"</see>, that the query results will be
    /// written to.
    /// </summary>
    abstract querySet: GPUQuerySet with get, set
    /// <summary>
    /// If defined, indicates the query index in <see cref="GPURenderPassTimestampWrites.querySet" /> into
    /// which the timestamp at the beginning of the compute pass will be written.
    /// </summary>
    abstract beginningOfPassWriteIndex: GPUSize32 option with get, set
    /// <summary>
    /// If defined, indicates the query index in <see cref="GPURenderPassTimestampWrites.querySet" /> into
    /// which the timestamp at the end of the compute pass will be written.
    /// </summary>
    abstract endOfPassWriteIndex: GPUSize32 option with get, set

[<AllowNullLiteral>]
type GPUComputePipelineDescriptor
    [<ParamObject; Emit("$0")>]
    (compute: GPUProgrammableStage, layout: GPUPipelineLayout, ?label: string)
    =
    inherit GPUPipelineDescriptorBase(layout)

    [<ParamObject; Emit("$0")>]
    new
        (
            compute: GPUProgrammableStage,
            layout: GPUAutoLayoutMode,
            ?label: string
        )
        =
        GPUComputePipelineDescriptor(
            unbox<GPUProgrammableStage> compute,
            layout,
            ?label = label
        )

    /// Describes the compute shader entry point of the pipeline.
    member val compute: GPUProgrammableStage = jsNative with get, set

[<AllowNullLiteral>]
type GPUDepthStencilState =
    /// <summary>
    /// The <see cref="GPUTextureViewDescriptor.format" /> of <see cref="GPURenderPassDescriptor.depthStencilAttachment" />
    /// this <see cref="GPURenderPipeline" /> will be compatible with.
    /// </summary>
    abstract format: GPUTextureFormat with get, set
    /// <summary>
    /// Indicates if this <see cref="GPURenderPipeline" /> can modify
    /// <see cref="GPURenderPassDescriptor.depthStencilAttachment" /> depth values.
    /// </summary>
    abstract depthWriteEnabled: bool option with get, set
    /// <summary>
    /// The comparison operation used to test fragment depths against
    /// <see cref="GPURenderPassDescriptor.depthStencilAttachment" /> depth values.
    /// </summary>
    abstract depthCompare: GPUCompareFunction option with get, set
    /// Defines how stencil comparisons and operations are performed for front-facing primitives.
    abstract stencilFront: GPUStencilFaceState option with get, set
    /// Defines how stencil comparisons and operations are performed for back-facing primitives.
    abstract stencilBack: GPUStencilFaceState option with get, set
    /// <summary>
    /// Bitmask controlling which <see cref="GPURenderPassDescriptor.depthStencilAttachment" /> stencil value
    /// bits are read when performing stencil comparison tests.
    /// </summary>
    abstract stencilReadMask: GPUStencilValue option with get, set
    /// <summary>
    /// Bitmask controlling which <see cref="GPURenderPassDescriptor.depthStencilAttachment" /> stencil value
    /// bits are written to when performing stencil operations.
    /// </summary>
    abstract stencilWriteMask: GPUStencilValue option with get, set
    /// Constant depth bias added to each fragment. See [$biased fragment depth$] for details.
    abstract depthBias: GPUDepthBias option with get, set
    /// Depth bias that scales with the fragment’s slope. See [$biased fragment depth$] for details.
    abstract depthBiasSlopeScale: float option with get, set
    /// The maximum depth bias of a fragment. See [$biased fragment depth$] for details.
    abstract depthBiasClamp: float option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUDeviceDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            ?requiredFeatures: Iterable<GPUFeatureName>,
            ?requiredLimits: GPUDeviceDescriptor.RequiredLimits,
            ?defaultQueue: GPUQueueDescriptor,
            ?label: string
        )
        =
        GPUDeviceDescriptor()

    /// Specifies the features that are required by the device request.
    /// The request will fail if the adapter cannot provide these features.
    /// Exactly the specified set of features, and no more or less, will be allowed in validation
    /// of API calls on the resulting device.
    member val requiredFeatures: Iterable<GPUFeatureName> option =
        jsNative with get, set

    /// <summary>
    /// Specifies the limits that are required by the device request.
    /// The request will fail if the adapter cannot provide these limits.
    /// Each key must be the name of a member of supported limits.
    /// Exactly the specified limits, and no limit/better or worse,
    /// will be allowed in validation of API calls on the resulting device.
    /// &lt;!-- If we ever need limit types other than GPUSize32/GPUSize64, we can change the value
    /// type to <c>double</c> or <c>any</c> in the future and write out the type conversion explicitly (by
    /// reference to WebIDL spec). Or change the entire type to <c>any</c> and add back a `dictionary
    /// GPULimits` and define the conversion of the whole object by reference to WebIDL. --&gt;
    /// </summary>
    // member val requiredLimits: Record<string, GPUSize64> option = jsNative with get, set
    member val requiredLimits: GPUDeviceDescriptor.RequiredLimits option =
        jsNative with get, set

    /// <summary>The descriptor for the default <see cref="GPUQueue" />.</summary>
    member val defaultQueue: GPUQueueDescriptor option = jsNative with get, set

module GPUDeviceDescriptor =

    type RequiredLimits =
        abstract Name: string

        [<EmitIndexer>]
        abstract Item: index: string -> GPUSize64

[<AllowNullLiteral>]
type GPUExtent3DDict =
    /// The width of the extent.
    abstract width: GPUIntegerCoordinate with get, set
    /// The height of the extent.
    abstract height: GPUIntegerCoordinate option with get, set
    /// <summary>
    /// The depth of the extent or the number of array layers it contains.
    /// If used with a <see cref="GPUTexture" /> with a <see cref="GPUTextureDimension" /> of <see cref="GPUTextureDimension.">"3d"</see>
    /// defines the depth of the texture. If used with a <see cref="GPUTexture" /> with a <see cref="GPUTextureDimension" />
    /// of <see cref="GPUTextureDimension.">"2d"</see> defines the number of array layers in the texture.
    /// </summary>
    abstract depthOrArrayLayers: GPUIntegerCoordinate option with get, set

[<AllowNullLiteral>]
type GPUExternalTextureBindingLayout = interface end

[<Global; AllowNullLiteralAttribute>]
type GPUExternalTextureDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            source: HTMLVideoElement,
            ?colorSpace: PredefinedColorSpace,
            ?label: string
        )
        =
        GPUExternalTextureDescriptor()

    [<ParamObject; Emit("$0")>]
    new(source: VideoFrame, ?colorSpace: PredefinedColorSpace, ?label: string)
        =
        GPUExternalTextureDescriptor()

    member val source: U2<HTMLVideoElement, VideoFrame> = jsNative with get, set
    member val colorSpace: PredefinedColorSpace option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUFragmentState
    [<ParamObject; Emit("$0")>]
    (
        ``module``: GPUShaderModule,
        targets: Iterable<GPUColorTargetState option>,
        ?entryPoint: string,
        ?constants: GPUProgrammableStage.Constants
    )
    =
    inherit GPUProgrammableStage(``module``)

    /// <summary>
    /// A list of <see cref="GPUColorTargetState" /> defining the formats and behaviors of the color targets
    /// this pipeline writes to.
    /// </summary>
    member val targets: Iterable<GPUColorTargetState option> =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUImageCopyBuffer =
    inherit GPUImageDataLayout
    /// A buffer which either contains image data to be copied or will store the image data being
    /// copied, depending on the method it is being passed to.
    abstract buffer: GPUBuffer with get, set

[<AllowNullLiteral>]
type GPUImageCopyExternalImage =
    /// <summary>
    /// The source of the image copy. The copy source data is captured at the moment that
    /// <see cref="GPUQueue.copyExternalImageToTexture" /> is issued. Source size is defined by source
    /// type, given by this table:
    ///
    /// &lt;table class=data&gt;
    /// &lt;thead&gt;
    /// &lt;tr&gt;
    /// &lt;th&gt;Source type
    /// &lt;th&gt;Width
    /// &lt;th&gt;Height
    /// &lt;/thead&gt;
    /// &lt;tbody&gt;
    /// &lt;tr&gt;
    /// &lt;td&gt;<see cref="ImageBitmap" />
    /// &lt;td&gt;<see cref="ImageBitmap.width">ImageBitmap.width</see>
    /// &lt;td&gt;<see cref="ImageBitmap.height">ImageBitmap.height</see>
    /// &lt;tr&gt;
    /// &lt;td&gt;<see cref="HTMLVideoElement" />
    /// &lt;td&gt;video/intrinsic width|intrinsic width of the frame
    /// &lt;td&gt;video/intrinsic height|intrinsic height of the frame
    /// &lt;tr&gt;
    /// &lt;td&gt;<see cref="VideoFrame" />
    /// &lt;td&gt;<see cref="VideoFrame.codedWidth">VideoFrame.codedWidth</see>
    /// &lt;td&gt;<see cref="VideoFrame.codedHeight">VideoFrame.codedHeight</see>
    /// &lt;tr&gt;
    /// &lt;td&gt;<see cref="HTMLCanvasElement" />
    /// &lt;td&gt;<see cref="HTMLCanvasElement.width">HTMLCanvasElement.width</see>
    /// &lt;td&gt;<see cref="HTMLCanvasElement.height">HTMLCanvasElement.height</see>
    /// &lt;tr&gt;
    /// &lt;td&gt;<see cref="OffscreenCanvas" />
    /// &lt;td&gt;<see cref="OffscreenCanvas.width">OffscreenCanvas.width</see>
    /// &lt;td&gt;<see cref="OffscreenCanvas.height">OffscreenCanvas.height</see>
    /// &lt;/tbody&gt;
    /// &lt;/table&gt;
    /// </summary>
    abstract source: GPUImageCopyExternalImageSource with get, set
    /// <summary>
    /// Defines the origin of the copy - the minimum (top-left) corner of the source sub-region to copy from.
    /// Together with <c>copySize</c>, defines the full copy sub-region.
    /// </summary>
    abstract origin: GPUOrigin2DStrict option with get, set
    /// <summary>
    /// Describes whether the source image is vertically flipped, or not.
    /// If this option is set to <c>true</c>, the copy is flipped vertically: the bottom row of the source
    /// region is copied into the first row of the destination region, and so on.
    /// The <see cref="GPUImageCopyExternalImage.origin" /> option is still relative to the top-left corner
    /// of the source image, increasing downward.
    /// </summary>
    abstract flipY: bool option with get, set

[<AllowNullLiteral>]
type GPUImageCopyTexture =
    /// Texture to copy to/from.
    abstract texture: GPUTexture with get, set
    /// <summary>Mip-map level of the <see cref="GPUImageCopyTexture.texture" /> to copy to/from.</summary>
    abstract mipLevel: GPUIntegerCoordinate option with get, set
    /// <summary>
    /// Defines the origin of the copy - the minimum corner of the texture sub-region to copy to/from.
    /// Together with <c>copySize</c>, defines the full copy sub-region.
    /// </summary>
    abstract origin: GPUOrigin3D option with get, set
    /// <summary>Defines which aspects of the <see cref="GPUImageCopyTexture.texture" /> to copy to/from.</summary>
    abstract aspect: GPUTextureAspect option with get, set

[<AllowNullLiteral>]
type GPUImageCopyTextureTagged =
    inherit GPUImageCopyTexture
    /// <summary>
    /// Describes the color space and encoding used to encode data into the destination texture.
    /// This [[#color-space-conversions|may result]] in values outside of the range [0, 1]
    /// being written to the target texture, if its format can represent them.
    /// Otherwise, the results are clamped to the target texture format's range.
    /// Note:
    /// If <see cref="GPUImageCopyTextureTagged.colorSpace" /> matches the source image,
    /// conversion may not be necessary. See [[#color-space-conversion-elision]].
    /// </summary>
    abstract colorSpace: PredefinedColorSpace option with get, set
    /// <summary>
    /// Describes whether the data written into the texture should have its RGB channels
    /// premultiplied by the alpha channel, or not.
    /// If this option is set to <c>true</c> and the <see cref="GPUImageCopyExternalImage.source" /> is also
    /// premultiplied, the source RGB values must be preserved even if they exceed their
    /// corresponding alpha values.
    /// Note:
    /// If <see cref="GPUImageCopyTextureTagged.premultipliedAlpha" /> matches the source image,
    /// conversion may not be necessary. See [[#color-space-conversion-elision]].
    /// </summary>
    abstract premultipliedAlpha: bool option with get, set

[<AllowNullLiteral>]
type GPUImageDataLayout =
    /// <summary>
    /// The offset, in bytes, from the beginning of the image data source (such as a
    /// <see cref="GPUImageCopyBuffer.buffer">GPUImageCopyBuffer.buffer</see>) to the start of the image data
    /// within that source.
    /// </summary>
    abstract offset: GPUSize64 option with get, set
    /// The stride, in bytes, between the beginning of each block row and the subsequent block row.
    /// Required if there are multiple block rows (i.e. the copy height or depth is more than one block).
    abstract bytesPerRow: GPUSize32 option with get, set
    /// <summary>
    /// Number of block rows per single image of the texture.
    /// <see cref="GPUImageDataLayout.rowsPerImage" /> &amp;times;
    /// <see cref="GPUImageDataLayout.bytesPerRow" /> is the stride, in bytes, between the beginning of each image of data and the subsequent image.
    /// Required if there are multiple images (i.e. the copy depth is more than one).
    /// </summary>
    abstract rowsPerImage: GPUSize32 option with get, set

[<AllowNullLiteral>]
type GPUMultisampleState =
    /// <summary>
    /// Number of samples per pixel. This <see cref="GPURenderPipeline" /> will be compatible only
    /// with attachment textures (<see cref="GPURenderPassDescriptor.colorAttachments" />
    /// and <see cref="GPURenderPassDescriptor.depthStencilAttachment" />)
    /// with matching <see cref="GPUTextureDescriptor.sampleCount" />s.
    /// </summary>
    abstract count: GPUSize32 option with get, set
    /// Mask determining which samples are written to.
    abstract mask: GPUSampleMask option with get, set
    /// <summary>
    /// When <c>true</c> indicates that a fragment's alpha channel should be used to generate a sample
    /// coverage mask.
    /// </summary>
    abstract alphaToCoverageEnabled: bool option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUObjectDescriptorBase private () =

    [<ParamObject; Emit("$0")>]
    new(?label: string) = GPUObjectDescriptorBase()

    /// <summary>The initial value of <see cref="GPUObjectBase.label">GPUObjectBase.label</see>.</summary>
    member val label: string option = jsNative with get, set


[<AllowNullLiteral>]
type GPUOrigin2DDict =
    abstract x: GPUIntegerCoordinate option with get, set
    abstract y: GPUIntegerCoordinate option with get, set

[<AllowNullLiteral>]
type GPUOrigin3DDict =
    abstract x: GPUIntegerCoordinate option with get, set
    abstract y: GPUIntegerCoordinate option with get, set
    abstract z: GPUIntegerCoordinate option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUPipelineDescriptorBase
    [<ParamObject; Emit("$0")>]
    (layout: GPUPipelineLayout)
    =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new(layout: GPUPipelineLayout, ?label: string)
        =
        GPUPipelineDescriptorBase(layout)

    [<ParamObject; Emit("$0")>]
    new(layout: GPUAutoLayoutMode) = GPUPipelineDescriptorBase(layout)

    [<ParamObject; Emit("$0")>]
    new(layout: GPUAutoLayoutMode, ?label: string)
        =
        GPUPipelineDescriptorBase(layout)

    /// <summary>
    /// The <see cref="GPUPipelineLayout" /> for this pipeline, or <see cref="GPUAutoLayoutMode.">"auto"</see> to generate
    /// the pipeline layout automatically.
    /// Note: If <see cref="GPUAutoLayoutMode.">"auto"</see> is used the pipeline cannot share <see cref="GPUBindGroup" />s
    /// with any other pipelines.
    /// </summary>
    member val layout: U2<GPUPipelineLayout, GPUAutoLayoutMode> =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUPipelineErrorInit =
    abstract reason: GPUPipelineErrorReason with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUPipelineLayoutDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new(bindGroupLayouts: Iterable<GPUBindGroupLayout>, ?label: string)
        =
        GPUPipelineLayoutDescriptor()

    /// <summary>A list of <see cref="GPUBindGroupLayout" />s the pipeline will use. Each element corresponds to a</summary>
    member val bindGroupLayouts: Iterable<GPUBindGroupLayout> =
        jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUPrimitiveState
    [<ParamObject; Emit("$0")>]
    (
        topology: GPUPrimitiveTopology,
        ?stripIndexFormat: GPUIndexFormat,
        ?frontFace: GPUFrontFace,
        ?cullMode: GPUCullMode,
        ?unclippedDepth: bool
    ) =
    /// The type of primitive to be constructed from the vertex inputs.
    member val topology: GPUPrimitiveTopology option = jsNative with get, set
    /// <summary>
    /// For pipelines with strip topologies
    /// (<see cref="GPUPrimitiveTopology.">"line-strip"</see> or <see cref="GPUPrimitiveTopology.">"triangle-strip"</see>),
    /// this determines the index buffer format and primitive restart value
    /// (<see cref="GPUIndexFormat.">"uint16"</see>/<c>0xFFFF</c> or <see cref="GPUIndexFormat.">"uint32"</see>/<c>0xFFFFFFFF</c>).
    /// It is not allowed on pipelines with non-strip topologies.
    /// Note: Some implementations require knowledge of the primitive restart value to compile
    /// pipeline state objects.
    /// To use a strip-topology pipeline with an indexed draw call
    /// (<see cref="GPURenderCommandsMixin.drawIndexed()" /> or <see cref="GPURenderCommandsMixin.drawIndexedIndirect" />),
    /// this must be set, and it must match the index buffer format used with the draw call
    /// (set in <see cref="GPURenderCommandsMixin.setIndexBuffer" />).
    /// See [[#primitive-assembly]] for additional details.
    /// </summary>
    member val stripIndexFormat: GPUIndexFormat option = jsNative with get, set
    /// Defines which polygons are considered front-facing.
    member val frontFace: GPUFrontFace option = jsNative with get, set
    /// Defines which polygon orientation will be culled, if any.
    member val cullMode: GPUCullMode option = jsNative with get, set
    /// <summary>
    /// If true, indicates that depth clipping is disabled.
    /// Requires the <see cref="GPUFeatureName.">"depth-clip-control"</see> feature to be enabled.
    /// </summary>
    member val unclippedDepth: bool option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUProgrammableStage
    [<ParamObject; Emit("$0")>]
    (
        ``module``: GPUShaderModule,
        ?entryPoint: string,
        ?constants: GPUProgrammableStage.Constants
    )
    =

    /// <summary>The <see cref="GPUShaderModule" /> containing the code that this programmable stage will execute.</summary>
    member val ``module``: GPUShaderModule = jsNative with get, set
    /// <summary>
    /// The name of the function in <see cref="GPUProgrammableStage.module" /> that this stage will use to
    /// perform its work.
    /// </summary>
    member val entryPoint: string option = jsNative with get, set

    /// <summary>
    /// Specifies the values of pipeline-overridable constants in the shader module
    /// <see cref="GPUProgrammableStage.module" />.
    /// Each such pipeline-overridable constant is uniquely identified by a single
    /// pipeline-overridable constant identifier string (representing the numeric ID of the
    /// constant, if one is specified, and otherwise the constant's identifier name).
    /// WGSL names (identifiers) in source maps follow the rules defined in WGSL identifier comparison.
    /// The key of each key-value pair must equal the identifier string of one such constant.
    /// When the pipeline is executed, that constant will have the specified value.
    /// Values are specified as &lt;dfn typedef for=""&gt;GPUPipelineConstantValue&lt;/dfn&gt;, which is a <see cref="double" />.
    /// They are converted [$to WGSL type$] of the pipeline-overridable constant (<c>bool</c>/<c>i32</c>/<c>u32</c>/<c>f32</c>/<c>f16</c>).
    /// If conversion fails, a validation error is generated.
    /// </summary>
    // member val constants: Record<string, GPUPipelineConstantValue> option = jsNative with get, set
    member val constants: GPUProgrammableStage.Constants option =
        jsNative with get, set

module GPUProgrammableStage =

    type Constants =
        abstract Name: string

        [<EmitIndexer>]
        abstract Item: index: string -> GPUPipelineConstantValue

[<Global; AllowNullLiteralAttribute>]
type GPUQuerySetDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new(type_: GPUQueryType, count: GPUSize32, ?label: string)
        =
        GPUQuerySetDescriptor()

    /// <summary>The type of queries managed by <see cref="GPUQuerySet" />.</summary>
    member val ``type``: GPUQueryType = jsNative with get, set
    /// <summary>The number of queries managed by <see cref="GPUQuerySet" />.</summary>
    member val count: GPUSize32 = jsNative with get, set

type GPUQueueDescriptor = GPUObjectDescriptorBase

type GPURenderBundleDescriptor = GPUObjectDescriptorBase

[<Global; AllowNullLiteralAttribute>]
type GPURenderBundleEncoderDescriptor
    private (colorFormats: Iterable<GPUTextureFormat option>)
    =
    inherit GPURenderPassLayout(colorFormats)

    [<ParamObject; Emit("$0")>]
    new
        (
            colorFormats: Iterable<GPUTextureFormat option>,
            ?depthStencilFormat: GPUTextureFormat option,
            ?sampleCount: GPUSize32,
            ?depthReadOnly: bool,
            ?stencilReadOnly: bool,
            ?label: string
        )
        =
        GPURenderBundleEncoderDescriptor(colorFormats)

    /// <summary>
    /// If <c>true</c>, indicates that the render bundle does not modify the depth component of the
    /// <see cref="GPURenderPassDepthStencilAttachment" /> of any render pass the render bundle is executed
    /// in.
    /// </summary>
    member val depthReadOnly: bool option = jsNative with get, set
    /// <summary>
    /// If <c>true</c>, indicates that the render bundle does not modify the stencil component of the
    /// <see cref="GPURenderPassDepthStencilAttachment" /> of any render pass the render bundle is executed
    /// in.
    /// </summary>
    member val stencilReadOnly: bool option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPURenderPassColorAttachment private () =

    [<ParamObject; Emit("$0")>]
    new
        (
            view: GPUTextureView,
            ?depthSlice: GPUIntegerCoordinate,
            ?resolveTarget: GPUTextureView,
            ?clearValue: Iterable<float>,
            ?loadOp: GPULoadOp,
            ?storeOp: GPUStoreOp
        )
        =
        GPURenderPassColorAttachment()

    [<ParamObject; Emit("$0")>]
    new
        (
            view: GPUTextureView,
            ?depthSlice: GPUIntegerCoordinate,
            ?resolveTarget: GPUTextureView,
            ?clearValue: GPUColorDict,
            ?loadOp: GPULoadOp,
            ?storeOp: GPUStoreOp
        )
        =
        GPURenderPassColorAttachment()

    /// <summary>
    /// A <see cref="GPUTextureView" /> describing the texture subresource that will be output to for this
    /// color attachment.
    /// </summary>
    member val view: GPUTextureView = jsNative with get, set
    /// <summary>
    /// Indicates the depth slice index of <see cref="GPUTextureViewDimension.">"3d"</see> <see cref="GPURenderPassColorAttachment.view" />
    /// that will be output to for this color attachment.
    /// </summary>
    member val depthSlice: GPUIntegerCoordinate option = jsNative with get, set
    /// <summary>
    /// A <see cref="GPUTextureView" /> describing the texture subresource that will receive the resolved
    /// output for this color attachment if <see cref="GPURenderPassColorAttachment.view" /> is
    /// multisampled.
    /// </summary>
    member val resolveTarget: GPUTextureView option = jsNative with get, set
    /// <summary>
    /// Indicates the value to clear <see cref="GPURenderPassColorAttachment.view" /> to prior to executing the
    /// render pass. If not map/exist|provided, defaults to <c>{r: 0, g: 0, b: 0, a: 0}</c>. Ignored
    /// if <see cref="GPURenderPassColorAttachment.loadOp" /> is not <see cref="GPULoadOp.">"clear"</see>.
    /// The components of <see cref="GPURenderPassColorAttachment.clearValue" /> are all double values.
    /// They are converted [$to a texel value of texture format$] matching the render attachment.
    /// If conversion fails, a validation error is generated.
    /// </summary>
    member val clearValue: GPUColor option = jsNative with get, set
    /// <summary>
    /// Indicates the load operation to perform on <see cref="GPURenderPassColorAttachment.view" /> prior to
    /// executing the render pass.
    /// Note: It is recommended to prefer clearing; see <see cref="GPULoadOp.">"clear"</see> for details.
    /// </summary>
    member val loadOp: GPULoadOp = jsNative with get, set
    /// <summary>
    /// The store operation to perform on <see cref="GPURenderPassColorAttachment.view" />
    /// after executing the render pass.
    /// </summary>
    member val storeOp: GPUStoreOp = jsNative with get, set

[<AllowNullLiteral>]
type GPURenderPassDepthStencilAttachment =
    /// <summary>
    /// A <see cref="GPUTextureView" /> describing the texture subresource that will be output to
    /// and read from for this depth/stencil attachment.
    /// </summary>
    abstract view: GPUTextureView with get, set
    /// <summary>
    /// Indicates the value to clear <see cref="GPURenderPassDepthStencilAttachment.view" />'s depth component
    /// to prior to executing the render pass. Ignored if <see cref="GPURenderPassDepthStencilAttachment.depthLoadOp" />
    /// is not <see cref="GPULoadOp.">"clear"</see>. Must be between 0.0 and 1.0, inclusive.
    /// &lt;!-- POSTV1(unrestricted-depth): unless unrestricted depth is enabled --&gt;
    /// </summary>
    abstract depthClearValue: float option with get, set
    /// <summary>
    /// Indicates the load operation to perform on <see cref="GPURenderPassDepthStencilAttachment.view" />'s
    /// depth component prior to executing the render pass.
    /// Note: It is recommended to prefer clearing; see <see cref="GPULoadOp.">"clear"</see> for details.
    /// </summary>
    abstract depthLoadOp: GPULoadOp option with get, set
    /// <summary>
    /// The store operation to perform on <see cref="GPURenderPassDepthStencilAttachment.view" />'s
    /// depth component after executing the render pass.
    /// </summary>
    abstract depthStoreOp: GPUStoreOp option with get, set
    /// <summary>
    /// Indicates that the depth component of <see cref="GPURenderPassDepthStencilAttachment.view" />
    /// is read only.
    /// </summary>
    abstract depthReadOnly: bool option with get, set
    /// <summary>
    /// Indicates the value to clear <see cref="GPURenderPassDepthStencilAttachment.view" />'s stencil component
    /// to prior to executing the render pass. Ignored if <see cref="GPURenderPassDepthStencilAttachment.stencilLoadOp" />
    /// is not <see cref="GPULoadOp.">"clear"</see>.
    /// The value will be converted to the type of the stencil aspect of <c>view</c> by taking the same
    /// number of LSBs as the number of bits in the stencil aspect of one texel block of <c>view</c>.
    /// </summary>
    abstract stencilClearValue: GPUStencilValue option with get, set
    /// <summary>
    /// Indicates the load operation to perform on <see cref="GPURenderPassDepthStencilAttachment.view" />'s
    /// stencil component prior to executing the render pass.
    /// Note: It is recommended to prefer clearing; see <see cref="GPULoadOp.">"clear"</see> for details.
    /// </summary>
    abstract stencilLoadOp: GPULoadOp option with get, set
    /// <summary>
    /// The store operation to perform on <see cref="GPURenderPassDepthStencilAttachment.view" />'s
    /// stencil component after executing the render pass.
    /// </summary>
    abstract stencilStoreOp: GPUStoreOp option with get, set
    /// <summary>
    /// Indicates that the stencil component of <see cref="GPURenderPassDepthStencilAttachment.view" />
    /// is read only.
    /// </summary>
    abstract stencilReadOnly: bool option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPURenderPassDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            colorAttachments: Iterable<GPURenderPassColorAttachment option>,
            ?depthStencilAttachment: GPURenderPassDepthStencilAttachment option,
            ?occlusionQuerySet: GPUQuerySet option,
            ?timestampWrites: GPURenderPassTimestampWrites option,
            ?maxDrawCount: GPUSize64,
            ?label: string
        )
        =
        GPURenderPassDescriptor()

    /// <summary>
    /// The set of <see cref="GPURenderPassColorAttachment" /> values in this sequence defines which
    /// color attachments will be output to when executing this render pass.
    /// Due to compatible usage list|usage compatibility, no color attachment
    /// may alias another attachment or any resource used inside the render pass.
    /// </summary>
    member val colorAttachments: Iterable<GPURenderPassColorAttachment option> =
        jsNative with get, set

    /// <summary>
    /// The <see cref="GPURenderPassDepthStencilAttachment" /> value that defines the depth/stencil
    /// attachment that will be output to and tested against when executing this render pass.
    /// Due to compatible usage list|usage compatibility, no writable depth/stencil attachment
    /// may alias another attachment or any resource used inside the render pass.
    /// </summary>
    member val depthStencilAttachment: GPURenderPassDepthStencilAttachment option =
        jsNative with get, set

    /// <summary>The <see cref="GPUQuerySet" /> value defines where the occlusion query results will be stored for this pass.</summary>
    member val occlusionQuerySet: GPUQuerySet option = jsNative with get, set

    /// Defines which timestamp values will be written for this pass, and where to write them to.
    member val timestampWrites: GPURenderPassTimestampWrites option =
        jsNative with get, set

    /// The maximum number of draw calls that will be done in the render pass. Used by some
    /// implementations to size work injected before the render pass. Keeping the default value
    /// is a good default, unless it is known that more draw calls will be done.
    member val maxDrawCount: GPUSize64 option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPURenderPassLayout private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            colorFormats: Iterable<GPUTextureFormat option>,
            ?depthStencilFormat: GPUTextureFormat option,
            ?sampleCount: GPUSize32,
            ?label: string
        )
        =
        GPURenderPassLayout()

    /// <summary>A list of the <see cref="GPUTextureFormat" />s of the color attachments for this pass or bundle.</summary>
    member val colorFormats: Iterable<GPUTextureFormat option> =
        jsNative with get, set

    /// <summary>The <see cref="GPUTextureFormat" /> of the depth/stencil attachment for this pass or bundle.</summary>
    member val depthStencilFormat: GPUTextureFormat option =
        jsNative with get, set

    /// Number of samples per pixel in the attachments for this pass or bundle.
    member val sampleCount: GPUSize32 option = jsNative with get, set

[<AllowNullLiteral>]
type GPURenderPassTimestampWrites =
    /// <summary>
    /// The <see cref="GPUQuerySet" />, of type <see cref="GPUQueryType.">"timestamp"</see>, that the query results will be
    /// written to.
    /// </summary>
    abstract querySet: GPUQuerySet with get, set
    /// <summary>
    /// If defined, indicates the query index in <see cref="GPURenderPassTimestampWrites.querySet" /> into
    /// which the timestamp at the beginning of the render pass will be written.
    /// </summary>
    abstract beginningOfPassWriteIndex: GPUSize32 option with get, set
    /// <summary>
    /// If defined, indicates the query index in <see cref="GPURenderPassTimestampWrites.querySet" /> into
    /// which the timestamp at the end of the render pass will be written.
    /// </summary>
    abstract endOfPassWriteIndex: GPUSize32 option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPURenderPipelineDescriptor
    [<ParamObject; Emit("$0")>]
    (layout: GPUPipelineLayout, vertex: GPUVertexState)
    =
    inherit GPUPipelineDescriptorBase(layout)

    [<ParamObject; Emit("$0")>]
    new(layout: GPUAutoLayoutMode, vertex: GPUVertexState)
        =
        GPURenderPipelineDescriptor(layout, vertex)

    [<ParamObject; Emit("$0")>]
    new
        (
            layout: GPUAutoLayoutMode,
            vertex: GPUVertexState,
            ?primitive: GPUPrimitiveState,
            ?depthStencil: GPUDepthStencilState,
            ?multisample: GPUMultisampleState,
            ?fragment: GPUFragmentState,
            ?label: string
        )
        =
        GPURenderPipelineDescriptor(layout, vertex)

    [<ParamObject; Emit("$0")>]
    new
        (
            layout: GPUPipelineLayout,
            vertex: GPUVertexState,
            ?primitive: GPUPrimitiveState,
            ?depthStencil: GPUDepthStencilState,
            ?multisample: GPUMultisampleState,
            ?fragment: GPUFragmentState,
            ?label: string
        )
        =
        GPURenderPipelineDescriptor(layout, vertex)


    /// Describes the vertex shader entry point of the pipeline and its input buffer layouts.
    member val vertex: GPUVertexState = jsNative with get, set
    /// Describes the primitive-related properties of the pipeline.
    member val primitive: GPUPrimitiveState option = jsNative with get, set

    /// Describes the optional depth-stencil properties, including the testing, operations, and bias.
    member val depthStencil: GPUDepthStencilState option =
        jsNative with get, set

    /// Describes the multi-sampling properties of the pipeline.
    member val multisample: GPUMultisampleState option = jsNative with get, set
    /// Describes the fragment shader entry point of the pipeline and its output colors. If
    /// not map/exist|provided, the [[#no-color-output]] mode is enabled.
    member val fragment: GPUFragmentState option = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPURequestAdapterOptions
    [<ParamObject; Emit("$0")>]
    (?powerPreference: GPUPowerPreference, ?forceFallbackAdapter: bool)
    =
    /// <summary>
    /// Optionally provides a hint indicating what class of adapter should be selected from
    /// the system's available adapters.
    /// The value of this hint may influence which adapter is chosen, but it must not
    /// influence whether an adapter is returned or not.
    /// Note:
    /// The primary utility of this hint is to influence which GPU is used in a multi-GPU system.
    /// For instance, some laptops have a low-power integrated GPU and a high-performance
    /// discrete GPU. This hint may also affect the power configuration of the selected GPU to
    /// match the requested power preference.
    /// Note:
    /// Depending on the exact hardware configuration, such as battery status and attached displays
    /// or removable GPUs, the user agent may select different adapters given the same power
    /// preference.
    /// Typically, given the same hardware configuration and state and
    /// <c>powerPreference</c>, the user agent is likely to select the same adapter.
    /// </summary>
    member val powerPreference: GPUPowerPreference option =
        jsNative with get, set

    /// <summary>
    /// When set to <c>true</c> indicates that only a fallback adapter may be returned. If the user
    /// agent does not support a fallback adapter, will cause <see cref="GPU.requestAdapter" /> to
    /// resolve to <c>null</c>.
    /// Note:
    /// <see cref="GPU.requestAdapter" /> may still return a fallback adapter if
    /// <see cref="GPURequestAdapterOptions.forceFallbackAdapter" /> is set to <c>false</c> and either no
    /// other appropriate adapter is available or the user agent chooses to return a
    /// fallback adapter. Developers that wish to prevent their applications from running on
    /// fallback adapters should check the <see cref="GPUAdapter" />.<see cref="GPUAdapter.isFallbackAdapter" />
    /// attribute prior to requesting a <see cref="GPUDevice" />.
    /// </summary>
    member val forceFallbackAdapter: bool option = jsNative with get, set

[<AllowNullLiteral>]
type GPUSamplerBindingLayout =
    /// Indicates the required type of a sampler bound to this bindings.
    abstract ``type``: GPUSamplerBindingType option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUSamplerDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            ?addressModeU: GPUAddressMode,
            ?addressModeV: GPUAddressMode,
            ?addressModeW: GPUAddressMode,
            ?magFilter: GPUFilterMode,
            ?minFilter: GPUFilterMode,
            ?mipmapFilter: GPUMipmapFilterMode,
            ?lodMinClamp: float,
            ?lodMaxClamp: float,
            ?compare: GPUCompareFunction,
            ?maxAnisotropy: float,
            ?label: string
        )
        =
        GPUSamplerDescriptor()

    member val addressModeU: GPUAddressMode option = jsNative with get, set
    member val addressModeV: GPUAddressMode option = jsNative with get, set
    /// Specifies the {{GPUAddressMode|address modes}} for the texture width, height, and depth
    /// coordinates, respectively.
    member val addressModeW: GPUAddressMode option = jsNative with get, set
    /// Specifies the sampling behavior when the sample footprint is smaller than or equal to one
    /// texel.
    member val magFilter: GPUFilterMode option = jsNative with get, set
    /// Specifies the sampling behavior when the sample footprint is larger than one texel.
    member val minFilter: GPUFilterMode option = jsNative with get, set
    /// Specifies behavior for sampling between mipmap levels.
    member val mipmapFilter: GPUMipmapFilterMode option = jsNative with get, set
    member val lodMinClamp: float option = jsNative with get, set
    /// Specifies the minimum and maximum levels of detail, respectively, used internally when
    /// sampling a texture.
    member val lodMaxClamp: float option = jsNative with get, set
    /// <summary>
    /// When provided the sampler will be a comparison sampler with the specified
    /// <see cref="GPUCompareFunction" />.
    /// Note: Comparison samplers may use filtering, but the sampling results will be
    /// implementation-dependent and may differ from the normal filtering rules.
    /// </summary>
    member val compare: GPUCompareFunction option = jsNative with get, set
    /// <summary>
    /// Specifies the maximum anisotropy value clamp used by the sampler.
    /// Note: Most implementations support <see cref="GPUSamplerDescriptor.maxAnisotropy" /> values in range
    /// between 1 and 16, inclusive. The used value of <see cref="GPUSamplerDescriptor.maxAnisotropy" /> will
    /// be clamped to the maximum value that the platform supports.
    /// </summary>
    member val maxAnisotropy: float option = jsNative with get, set

[<AllowNullLiteral>]
type GPUShaderModuleCompilationHint =
    abstract entryPoint: string with get, set
    /// <summary>
    /// A <see cref="GPUPipelineLayout" /> that the <see cref="GPUShaderModule" /> may be used with in a future
    /// <see cref="GPUDevice.createComputePipeline()" /> or <see cref="GPUDevice.createRenderPipeline" /> call.
    /// If set to <see cref="GPUAutoLayoutMode.">"auto"</see> the layout will be the [$default pipeline layout$]
    /// for the entry point associated with this hint will be used.
    /// </summary>
    abstract layout: U2<GPUPipelineLayout, GPUAutoLayoutMode> option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUShaderModuleDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            code: string,
            ?sourceMap: obj,
            ?compilationHints: ResizeArray<GPUShaderModuleCompilationHint>,
            ?label: string
        )
        =
        GPUShaderModuleDescriptor()

    /// <summary>
    /// The &lt;a href="<see href="https://gpuweb.github.io/gpuweb/wgsl/"&gt;WGSL&lt;/a&gt;" /> source code for the shader
    /// module.
    /// </summary>
    member val code: string = jsNative with get, set
    /// If defined MAY be interpreted as a source-map-v3 format.
    /// Source maps are optional, but serve as a standardized way to support dev-tool
    /// integration such as source-language debugging [[SourceMap]].
    /// WGSL names (identifiers) in source maps follow the rules defined in WGSL identifier
    /// comparison.
    member val sourceMap: obj option = jsNative with get, set

    /// <summary>
    /// A list of <see cref="GPUShaderModuleCompilationHint" />s.
    /// Any hint provided by an application **should** contain information about one entry point of
    /// a pipeline that will eventually be created from the entry point.
    /// Implementations **should** use any information present in the <see cref="GPUShaderModuleCompilationHint" />
    /// to perform as much compilation as is possible within <see cref="GPUDevice.createShaderModule" />.
    /// Aside from type-checking, these hints are not validated in any way.
    /// &lt;div class=note heading&gt;
    /// Supplying information in <see cref="GPUShaderModuleDescriptor.compilationHints" /> does not have any
    /// observable effect, other than performance. It may be detrimental to performance to
    /// provide hints for pipelines that never end up being created.
    /// Because a single shader module can hold
    /// multiple entry points, and multiple pipelines can be created from a single shader
    /// module, it can be more performant for an implementation to do as much compilation as
    /// possible once in <see cref="GPUDevice.createShaderModule" /> rather than multiple times in
    /// the multiple calls to <see cref="GPUDevice.createComputePipeline" /> or
    /// <see cref="GPUDevice.createRenderPipeline" />.
    /// &lt;/div&gt;
    /// Note:
    /// Hints are not validated in an observable way, but user agents **may** surface identifiable
    /// errors (like unknown entry point names or incompatible pipeline layouts) to developers,
    /// for example in the browser developer console.
    /// </summary>
    member val compilationHints: ResizeArray<GPUShaderModuleCompilationHint> option =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUStencilFaceState =
    /// <summary>
    /// The <see cref="GPUCompareFunction" /> used when testing fragments against
    /// <see cref="GPURenderPassDescriptor.depthStencilAttachment" /> stencil values.
    /// </summary>
    abstract compare: GPUCompareFunction option with get, set
    /// <summary>
    /// The <see cref="GPUStencilOperation" /> performed if the fragment stencil comparison test described by
    /// <see cref="GPUStencilFaceState.compare" /> fails.
    /// </summary>
    abstract failOp: GPUStencilOperation option with get, set
    /// <summary>
    /// The <see cref="GPUStencilOperation" /> performed if the fragment depth comparison described by
    /// <see cref="GPUDepthStencilState.depthCompare" /> fails.
    /// </summary>
    abstract depthFailOp: GPUStencilOperation option with get, set
    /// <summary>
    /// The <see cref="GPUStencilOperation" /> performed if the fragment stencil comparison test described by
    /// <see cref="GPUStencilFaceState.compare" /> passes.
    /// </summary>
    abstract passOp: GPUStencilOperation option with get, set

[<AllowNullLiteral>]
type GPUStorageTextureBindingLayout =
    /// The access mode for this binding, indicating readability and writability.
    abstract access: GPUStorageTextureAccess option with get, set
    /// <summary>The required <see cref="GPUTextureViewDescriptor.format" /> of texture views bound to this binding.</summary>
    abstract format: GPUTextureFormat with get, set
    /// <summary>
    /// Indicates the required <see cref="GPUTextureViewDescriptor.dimension" /> for texture views bound to
    /// this binding.
    /// </summary>
    abstract viewDimension: GPUTextureViewDimension option with get, set

[<AllowNullLiteral>]
type GPUTextureBindingLayout =
    /// Indicates the type required for texture views bound to this binding.
    abstract sampleType: GPUTextureSampleType option with get, set
    /// <summary>
    /// Indicates the required <see cref="GPUTextureViewDescriptor.dimension" /> for texture views bound to
    /// this binding.
    /// </summary>
    abstract viewDimension: GPUTextureViewDimension option with get, set
    /// Indicates whether or not texture views bound to this binding must be multisampled.
    abstract multisampled: bool option with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUTextureDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            size: GPUExtent3DStrict,
            mipLevelCount: GPUIntegerCoordinate option,
            sampleCount: GPUSize32 option,
            dimension: GPUTextureDimension option,
            format: GPUTextureFormat,
            usage: GPUTextureUsageFlags,
            ?viewFormats: Iterable<GPUTextureFormat>,
            ?label: string
        )
        =
        GPUTextureDescriptor()

    /// The width, height, and depth or layer count of the texture.
    member val size: GPUExtent3DStrict = jsNative with get, set

    /// The number of mip levels the texture will contain.
    member val mipLevelCount: GPUIntegerCoordinate option =
        jsNative with get, set

    /// <summary>
    /// The sample count of the texture. A <see cref="GPUTextureDescriptor.sampleCount" /> &amp;gt; <c>1</c> indicates
    /// a multisampled texture.
    /// </summary>
    member val sampleCount: GPUSize32 option = jsNative with get, set
    /// Whether the texture is one-dimensional, an array of two-dimensional layers, or three-dimensional.
    member val dimension: GPUTextureDimension option = jsNative with get, set
    /// The format of the texture.
    member val format: GPUTextureFormat = jsNative with get, set
    /// The allowed usages for the texture.
    member val usage: GPUTextureUsageFlags = jsNative with get, set

    /// <summary>
    /// Specifies what view <see cref="GPUTextureViewDescriptor.format" /> values will be allowed when calling
    /// <see cref="GPUTexture.createView" /> on this texture (in addition to the texture's actual
    /// <see cref="GPUTextureDescriptor.format" />).
    /// &lt;div class=note heading&gt;
    /// Adding a format to this list may have a significant performance impact, so it is best
    /// to avoid adding formats unnecessarily.
    /// The actual performance impact is highly dependent on the target system; developers must
    /// test various systems to find out the impact on their particular application.
    /// For example, on some systems any texture with a <see cref="GPUTextureDescriptor.format" /> or
    /// <see cref="GPUTextureDescriptor.viewFormats" /> entry including
    /// <see cref="GPUTextureFormat.">"rgba8unorm-srgb"</see> will perform less optimally than a
    /// <see cref="GPUTextureFormat.">"rgba8unorm"</see> texture which does not.
    /// Similar caveats exist for other formats and pairs of formats on other systems.
    /// &lt;/div&gt;
    /// Formats in this list must be texture view format compatible with the texture format.
    /// &lt;div algorithm&gt;
    /// Two <see cref="GPUTextureFormat" />s <c>format</c> and <c>viewFormat</c> are &lt;dfn dfn for=""&gt;texture view format compatible&lt;/dfn&gt; if:
    /// - <c>format</c> equals <c>viewFormat</c>, or
    /// - <c>format</c> and <c>viewFormat</c> differ only in whether they are <c>srgb</c> formats (have the <c>-srgb</c> suffix).
    /// &lt;/div&gt;
    /// </summary>
    member val viewFormats: Iterable<GPUTextureFormat> option =
        jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUTextureViewDescriptor private () =
    inherit GPUObjectDescriptorBase()

    [<ParamObject; Emit("$0")>]
    new
        (
            format: GPUTextureFormat,
            dimension: GPUTextureViewDimension,
            aspect: GPUTextureAspect,
            ?baseMipLevel: GPUIntegerCoordinate,
            ?mipLevelCount: GPUIntegerCoordinate,
            ?baseArrayLayer: GPUIntegerCoordinate,
            ?arrayLayerCount: GPUIntegerCoordinate,
            ?label: string
        )
        =
        GPUTextureViewDescriptor()

    /// <summary>
    /// The format of the texture view. Must be either the <see cref="GPUTextureDescriptor.format" /> of the
    /// texture or one of the <see cref="GPUTextureDescriptor.viewFormats" /> specified during its creation.
    /// </summary>
    member val format: GPUTextureFormat option = jsNative with get, set

    /// The dimension to view the texture as.
    member val dimension: GPUTextureViewDimension option =
        jsNative with get, set

    /// <summary>Which <see cref="GPUTextureAspectaspect(s)" /> of the texture are accessible to the texture view.</summary>
    member val aspect: GPUTextureAspect option = jsNative with get, set

    /// The first (most detailed) mipmap level accessible to the texture view.
    member val baseMipLevel: GPUIntegerCoordinate option =
        jsNative with get, set

    /// <summary>
    /// How many mipmap levels, starting with <see cref="GPUTextureViewDescriptor.baseMipLevel" />, are accessible to
    /// the texture view.
    /// </summary>
    member val mipLevelCount: GPUIntegerCoordinate option =
        jsNative with get, set

    /// The index of the first array layer accessible to the texture view.
    member val baseArrayLayer: GPUIntegerCoordinate option =
        jsNative with get, set

    /// <summary>
    /// How many array layers, starting with <see cref="GPUTextureViewDescriptor.baseArrayLayer" />, are accessible
    /// to the texture view.
    /// </summary>
    member val arrayLayerCount: GPUIntegerCoordinate option =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUUncapturedErrorEventInit =
    inherit EventInit
    abstract error: GPUError with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUVertexAttribute
    [<ParamObject; Emit("$0")>]
    (shaderLocation: GPUIndex32, format: GPUVertexFormat, offset: GPUSize64)
    =
    /// <summary>The <see cref="GPUVertexFormat" /> of the attribute.</summary>
    member val format: GPUVertexFormat = jsNative with get, set
    /// The offset, in bytes, from the beginning of the element to the data for the attribute.
    member val offset: GPUSize64 = jsNative with get, set
    /// <summary>
    /// The numeric location associated with this attribute, which will correspond with a
    /// &lt;a href="<see href="https://gpuweb.github.io/gpuweb/wgsl/#input-output-locations"&gt;"@location"" /> attribute&lt;/a&gt;
    /// declared in the <see cref="GPURenderPipelineDescriptor.vertex" />.<see cref="GPUProgrammableStage.module">module</see>.
    /// </summary>
    member val shaderLocation: GPUIndex32 = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUVertexBufferLayout
    [<ParamObject; Emit("$0")>]
    (
        arrayStride: GPUSize64,
        stepMode: GPUVertexStepMode,
        attributes: Iterable<GPUVertexAttribute>
    )
    =
    /// The stride, in bytes, between elements of this array.
    member val arrayStride: GPUSize64 = jsNative with get, set
    /// Whether each element of this array represents per-vertex data or per-instance data
    member val stepMode: GPUVertexStepMode option = jsNative with get, set
    /// An array defining the layout of the vertex attributes within each element.
    member val attributes: Iterable<GPUVertexAttribute> = jsNative with get, set

[<Global; AllowNullLiteralAttribute>]
type GPUVertexState
    [<ParamObject; Emit("$0")>]
    (
        ``module``: GPUShaderModule,
        ?entryPoint: string,
        ?constants: GPUProgrammableStage.Constants,
        ?buffers: Iterable<GPUVertexBufferLayout option>
    )
    =

    inherit GPUProgrammableStage(``module``)

    /// <summary>
    /// A list of <see cref="GPUVertexBufferLayout" />s defining the layout of the vertex attribute data in the
    /// vertex buffers used by this pipeline.
    /// </summary>
    member val buffers: Iterable<GPUVertexBufferLayout option> option =
        jsNative with get, set

[<AllowNullLiteral>]
type GPUBindingCommandsMixin =
    /// <summary>Sets the current <see cref="GPUBindGroup" /> for the given index.</summary>
    /// <param name="index">The index to set the bind group at.</param>
    /// <param name="bindGroup">
    /// Bind group to use for subsequent render or compute commands.
    /// &lt;!--The overload appears to be confusing bikeshed, and it ends up expecting this to
    /// define the arguments for the 5-arg variant of the method, despite the "for"
    /// explicitly pointing at the 3-arg variant. See
    /// </param>
    /// <param name="https">//github.com/plinss/widlparser/issues/56 and</param>
    /// <param name="https">//github.com/tabatkins/bikeshed/issues/1740 --&gt;</param>
    /// <param name="dynamicOffsets">
    /// Array containing buffer offsets in bytes for each entry in
    /// <c>bindGroup</c> marked as <see cref="GPUBindGroupLayoutEntrybuffer" />.<see cref="GPUBufferBindingLayouthasDynamicOffset" />.--&gt;
    /// </param>
    abstract setBindGroup:
        index: GPUIndex32 *
        bindGroup: GPUBindGroup option *
        ?dynamicOffsets: Iterable<GPUBufferDynamicOffset> ->
            obj

    /// <summary>
    /// Sets the current <see cref="GPUBindGroup" /> for the given index, specifying dynamic offsets as a subset
    /// of a <see cref="Uint32Array" />.
    /// </summary>
    /// <param name="index">The index to set the bind group at.</param>
    /// <param name="bindGroup">Bind group to use for subsequent render or compute commands.</param>
    /// <param name="dynamicOffsetsData">
    /// Array containing buffer offsets in bytes for each entry in
    /// <c>bindGroup</c> marked as <see cref="GPUBindGroupLayoutEntrybuffer" />.<see cref="GPUBufferBindingLayouthasDynamicOffset" />.
    /// </param>
    /// <param name="dynamicOffsetsDataStart">
    /// Offset in elements into <c>dynamicOffsetsData</c> where the
    /// buffer offset data begins.
    /// </param>
    /// <param name="dynamicOffsetsDataLength">Number of buffer offsets to read from <c>dynamicOffsetsData</c>.</param>
    abstract setBindGroup:
        index: GPUIndex32 *
        bindGroup: GPUBindGroup option *
        dynamicOffsetsData: Uint32Array *
        dynamicOffsetsDataStart: GPUSize64 *
        dynamicOffsetsDataLength: GPUSize32 ->
            obj

[<AllowNullLiteral>]
type GPUCommandsMixin = interface end

[<AllowNullLiteral>]
type GPUDebugCommandsMixin =
    /// <summary>Begins a labeled debug group containing subsequent commands.</summary>
    /// <param name="groupLabel">The label for the command group.</param>
    abstract pushDebugGroup: groupLabel: string -> obj
    /// <summary>Ends the labeled debug group most recently started by <see cref="GPUDebugCommandsMixin.pushDebugGroup" />.</summary>
    abstract popDebugGroup: unit -> obj
    /// <summary>Marks a point in a stream of commands with a label.</summary>
    /// <param name="markerLabel">The label to insert.</param>
    abstract insertDebugMarker: markerLabel: string -> obj

[<AllowNullLiteral>]
type GPUObjectBase =
    abstract label: string with get, set

[<AllowNullLiteral>]
type GPUPipelineBase =
    /// <summary>
    /// Gets a <see cref="GPUBindGroupLayout" /> that is compatible with the <see cref="GPUPipelineBase" />'s
    /// <see cref="GPUBindGroupLayout" /> at <c>index</c>.
    /// </summary>
    /// <param name="index">Index into the pipeline layout's <see cref="GPUPipelineLayout">[[bindGroupLayouts]]</see>sequence.</param>
    abstract getBindGroupLayout: index: float -> GPUBindGroupLayout

[<AllowNullLiteral>]
type GPURenderCommandsMixin =
    /// <summary>Sets the current <see cref="GPURenderPipeline" />.</summary>
    /// <param name="pipeline">The render pipeline to use for subsequent drawing commands.</param>
    abstract setPipeline: pipeline: GPURenderPipeline -> obj

    /// <summary>Sets the current index buffer.</summary>
    /// <param name="buffer">Buffer containing index data to use for subsequent drawing commands.</param>
    /// <param name="indexFormat">Format of the index data contained in <c>buffer</c>.</param>
    /// <param name="offset">Offset in bytes into <c>buffer</c> where the index data begins. Defaults to <c>0</c>.</param>
    /// <param name="size">
    /// Size in bytes of the index data in <c>buffer</c>.
    /// Defaults to the size of the buffer minus the offset.
    /// </param>
    abstract setIndexBuffer:
        buffer: GPUBuffer *
        indexFormat: GPUIndexFormat *
        ?offset: GPUSize64 *
        ?size: GPUSize64 ->
            obj

    /// <summary>Sets the current vertex buffer for the given slot.</summary>
    /// <param name="slot">The vertex buffer slot to set the vertex buffer for.</param>
    /// <param name="buffer">Buffer containing vertex data to use for subsequent drawing commands.</param>
    /// <param name="offset">Offset in bytes into <c>buffer</c> where the vertex data begins. Defaults to <c>0</c>.</param>
    /// <param name="size">
    /// Size in bytes of the vertex data in <c>buffer</c>.
    /// Defaults to the size of the buffer minus the offset.
    /// </param>
    abstract setVertexBuffer:
        slot: GPUIndex32 *
        buffer: GPUBuffer option *
        ?offset: GPUSize64 *
        ?size: GPUSize64 ->
            obj

    /// <summary>
    /// Draws primitives.
    /// See [[#rendering-operations]] for the detailed specification.
    /// </summary>
    /// <param name="vertexCount">The number of vertices to draw.</param>
    /// <param name="instanceCount">The number of instances to draw.</param>
    /// <param name="firstVertex">Offset into the vertex buffers, in vertices, to begin drawing from.</param>
    /// <param name="firstInstance">First instance to draw.</param>
    abstract draw:
        vertexCount: GPUSize32 *
        ?instanceCount: GPUSize32 *
        ?firstVertex: GPUSize32 *
        ?firstInstance: GPUSize32 ->
            obj

    /// <summary>
    /// Draws indexed primitives.
    /// See [[#rendering-operations]] for the detailed specification.
    /// </summary>
    /// <param name="indexCount">The number of indices to draw.</param>
    /// <param name="instanceCount">The number of instances to draw.</param>
    /// <param name="firstIndex">Offset into the index buffer, in indices, begin drawing from.</param>
    /// <param name="baseVertex">Added to each index value before indexing into the vertex buffers.</param>
    /// <param name="firstInstance">First instance to draw.</param>
    abstract drawIndexed:
        indexCount: GPUSize32 *
        ?instanceCount: GPUSize32 *
        ?firstIndex: GPUSize32 *
        ?baseVertex: GPUSignedOffset32 *
        ?firstInstance: GPUSize32 ->
            obj

    /// <summary>
    /// Draws primitives using parameters read from a <see cref="GPUBuffer" />.
    /// See [[#rendering-operations]] for the detailed specification.
    /// packed block of **four 32-bit unsigned integer values (16 bytes total)**, given in the same
    /// order as the arguments for <see cref="GPURenderEncoderBase.draw" />. For example:
    /// </summary>
    /// <param name="indirectBuffer">Buffer containing the indirect draw parameters.</param>
    /// <param name="indirectOffset">Offset in bytes into <c>indirectBuffer</c> where the drawing data begins.</param>
    abstract drawIndirect:
        indirectBuffer: GPUBuffer * indirectOffset: GPUSize64 -> obj

    /// <summary>
    /// Draws indexed primitives using parameters read from a <see cref="GPUBuffer" />.
    /// See [[#rendering-operations]] for the detailed specification.
    /// tightly packed block of **five 32-bit unsigned integer values (20 bytes total)**, given in
    /// the same order as the arguments for <see cref="GPURenderEncoderBase.drawIndexed" />. For example:
    /// </summary>
    /// <param name="indirectBuffer">Buffer containing the indirect drawIndexed parameters.</param>
    /// <param name="indirectOffset">Offset in bytes into <c>indirectBuffer</c> where the drawing data begins.</param>
    abstract drawIndexedIndirect:
        indirectBuffer: GPUBuffer * indirectOffset: GPUSize64 -> obj

[<AllowNullLiteral>]
type NavigatorGPU =
    /// <summary>A global singleton providing top-level entry points like <see cref="GPU.requestAdapter" />.</summary>
    abstract gpu: GPU

[<AllowNullLiteral>]
type GPU =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

    /// <summary>
    /// Requests an adapter from the user agent.
    /// The user agent chooses whether to return an adapter, and, if so,
    /// chooses according to the provided options.
    /// </summary>
    /// <param name="options">Criteria used to select the adapter.</param>
    abstract requestAdapter:
        ?options: GPURequestAdapterOptions -> JS.Promise<GPUAdapter option>

    /// <summary>
    /// Returns an optimal <see cref="GPUTextureFormat" /> for displaying 8-bit depth, standard dynamic range
    /// content on this system. Must only return <see cref="GPUTextureFormat.">"rgba8unorm"</see> or
    /// <see cref="GPUTextureFormat.">"bgra8unorm"</see>.
    /// The returned value can be passed as the <see cref="GPUCanvasConfiguration.format" /> to
    /// <see cref="GPUCanvasContext.configure" /> calls on a <see cref="GPUCanvasContext" /> to ensure the associated
    /// canvas is able to display its contents efficiently.
    /// Note: Canvases which are not displayed to the screen may or may not benefit from using this
    /// format.
    /// </summary>
    abstract getPreferredCanvasFormat: unit -> GPUTextureFormat
    abstract wgslLanguageFeatures: WGSLLanguageFeatures

[<AllowNullLiteral>]
type GPUAdapter =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>The set of values in <c>this</c>.<see cref="GPUAdapter.">[[adapter]]</see>.<see cref="adapter.">[[features]]</see>.</summary>
    abstract features: GPUSupportedFeatures
    /// <summary>The limits in <c>this</c>.<see cref="GPUAdapter.">[[adapter]]</see>.<see cref="adapter.">[[limits]]</see>.</summary>
    abstract limits: GPUSupportedLimits
    /// <summary>Returns the value of <see cref="GPUAdapter.">[[adapter]]</see>.<see cref="adapter.">[[fallback]]</see>.</summary>
    abstract isFallbackAdapter: bool

    /// <summary>
    /// Requests a device from the adapter.
    /// This is a one-time action: if a device is returned successfully,
    /// the adapter becomes invalid.
    /// </summary>
    /// <param name="descriptor">Description of the <see cref="GPUDevice" /> to request.</param>
    abstract requestDevice:
        ?descriptor: GPUDeviceDescriptor -> JS.Promise<GPUDevice>

    /// <summary>
    /// Requests the <see cref="GPUAdapterInfo" /> for this <see cref="GPUAdapter" />.
    /// Note: Adapter info values are returned with a Promise to give user agents an
    /// opportunity to perform potentially long-running checks in the future.
    /// </summary>
    abstract requestAdapterInfo: unit -> JS.Promise<GPUAdapterInfo>

[<AllowNullLiteral>]
type GPUAdapterInfo =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// The name of the vendor of the adapter, if available. Empty string otherwise.
    abstract vendor: string
    /// The name of the family or class of GPUs the adapter belongs to, if available. Empty
    /// string otherwise.
    abstract architecture: string
    /// <summary>
    /// A vendor-specific identifier for the adapter, if available. Empty string otherwise.
    /// Note: This is a value that represents the type of adapter. For example, it may be a
    /// <see href="https://pcisig.com/">PCI device ID</see>. It does not uniquely identify a given piece of
    /// hardware like a serial number.
    /// </summary>
    abstract device: string
    /// <summary>
    /// A human readable string describing the adapter as reported by the driver, if available.
    /// Empty string otherwise.
    /// Note: Because no formatting is applied to <see cref="GPUAdapterInfo.description" /> attempting to parse
    /// this value is not recommended. Applications which change their behavior based on the
    /// <see cref="GPUAdapterInfo" />, such as applying workarounds for known driver issues, should rely on the
    /// other fields when possible.
    /// </summary>
    abstract description: string

[<AllowNullLiteral>]
type GPUBindGroup =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUBindGroupLayout =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUBuffer =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract size: GPUSize64Out
    abstract usage: GPUFlagsConstant
    abstract mapState: GPUBufferMapState

    /// <summary>
    /// Maps the given range of the <see cref="GPUBuffer" /> and resolves the returned <see cref="Promise" /> when the
    /// <see cref="GPUBuffer" />'s content is ready to be accessed with <see cref="GPUBuffer.getMappedRange" />.
    /// The resolution of the returned <see cref="Promise" /> **only** indicates that the buffer has been mapped.
    /// It does not guarantee the completion of any other operations visible to the content timeline,
    /// and in particular does not imply that any other <see cref="Promise" /> returned from
    /// <see cref="GPUQueue.onSubmittedWorkDone()" /> or <see cref="GPUBuffer.mapAsync" /> on other <see cref="GPUBuffer" />s
    /// have resolved.
    /// The resolution of the <see cref="Promise" /> returned from <see cref="GPUQueue.onSubmittedWorkDone" />
    /// **does** imply the completion of
    /// <see cref="GPUBuffer.mapAsync" /> calls made prior to that call,
    /// on <see cref="GPUBuffer" />s last used exclusively on that queue.
    /// </summary>
    /// <param name="mode">Whether the buffer should be mapped for reading or writing.</param>
    /// <param name="offset">Offset in bytes into the buffer to the start of the range to map.</param>
    /// <param name="size">Size in bytes of the range to map.</param>
    abstract mapAsync:
        mode: GPUMapModeFlags * ?offset: GPUSize64 * ?size: GPUSize64 ->
            JS.Promise<obj>

    /// <summary>Returns an <see cref="ArrayBuffer" /> with the contents of the <see cref="GPUBuffer" /> in the given mapped range.</summary>
    /// <param name="offset">Offset in bytes into the buffer to return buffer contents from.</param>
    /// <param name="size">Size in bytes of the <see cref="ArrayBuffer" /> to return.</param>
    abstract getMappedRange:
        ?offset: GPUSize64 * ?size: GPUSize64 -> JS.ArrayBuffer

    /// <summary>
    /// Unmaps the mapped range of the <see cref="GPUBuffer" /> and makes it's contents available for use by the
    /// GPU again.
    /// </summary>
    abstract unmap: unit -> obj
    /// <summary>
    /// Destroys the <see cref="GPUBuffer" />.
    /// Note: It is valid to destroy a buffer multiple times.
    /// Note: Since no further operations can be enqueued using this buffer, implementations can
    /// free resource allocations, including mapped memory that was just unmapped.
    /// </summary>
    abstract destroy: unit -> obj

[<AllowNullLiteral>]
type OffscreenCanvas =
    abstract getContext:
        contextId: OffscreenCanvasGetContext -> GPUCanvasContext option

[<StringEnum>]
[<RequireQualifiedAccess>]
type OffscreenCanvasGetContext = | Webgpu

[<AllowNullLiteral>]
type GPUCanvasContext =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// The canvas this context was created from.
    abstract canvas: U2<HTMLCanvasElement, OffscreenCanvas>
    /// <summary>
    /// Configures the context for this canvas.
    /// This clears the drawing buffer to transparent black (in [$Replace the drawing buffer$]).
    /// </summary>
    /// <param name="configuration">Desired configuration for the context.</param>
    abstract configure: configuration: GPUCanvasConfiguration -> obj
    /// Removes the context configuration. Destroys any textures produced while configured.
    abstract unconfigure: unit -> obj
    /// <summary>
    /// Get the <see cref="GPUTexture" /> that will be composited to the document by the <see cref="GPUCanvasContext" />
    /// next.
    /// Note: The same <see cref="GPUTexture" /> object will be returned by every
    /// call to <see cref="GPUCanvasContext.getCurrentTexture" /> until "[$Expire the current texture$]"
    /// runs, even if that <see cref="GPUTexture" /> is destroyed, failed validation, or failed to allocate.
    /// </summary>
    abstract getCurrentTexture: unit -> GPUTexture

[<AllowNullLiteral>]
type GPUCommandBuffer =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUCommandEncoder =
    inherit GPUObjectBase
    inherit GPUCommandsMixin
    inherit GPUDebugCommandsMixin
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

    /// <summary>Begins encoding a render pass described by <c>descriptor</c>.</summary>
    /// <param name="descriptor">Description of the <see cref="GPURenderPassEncoder" /> to create.</param>
    abstract beginRenderPass:
        descriptor: GPURenderPassDescriptor -> GPURenderPassEncoder

    /// <summary>
    /// Begins encoding a compute pass described by <c>descriptor</c>.
    /// 	descriptor:
    /// </summary>
    abstract beginComputePass:
        ?descriptor: GPUComputePassDescriptor -> GPUComputePassEncoder

    /// <summary>
    /// Encode a command into the <see cref="GPUCommandEncoder" /> that copies data from a sub-region of a
    /// <see cref="GPUBuffer" /> to a sub-region of another <see cref="GPUBuffer" />.
    /// </summary>
    /// <param name="source">The <see cref="GPUBuffer" /> to copy from.</param>
    /// <param name="sourceOffset">Offset in bytes into <c>source</c> to begin copying from.</param>
    /// <param name="destination">The <see cref="GPUBuffer" /> to copy to.</param>
    /// <param name="destinationOffset">Offset in bytes into <c>destination</c> to place the copied data.</param>
    /// <param name="size">Bytes to copy.</param>
    abstract copyBufferToBuffer:
        source: GPUBuffer *
        sourceOffset: GPUSize64 *
        destination: GPUBuffer *
        destinationOffset: GPUSize64 *
        size: GPUSize64 ->
            obj

    /// <summary>
    /// Encode a command into the <see cref="GPUCommandEncoder" /> that copies data from a sub-region of a
    /// <see cref="GPUBuffer" /> to a sub-region of one or multiple continuous texture subresources.
    /// </summary>
    /// <param name="source">Combined with <c>copySize</c>, defines the region of the source buffer.</param>
    /// <param name="destination">
    /// Combined with <c>copySize</c>, defines the region of the destination texture subresource.
    /// <c>copySize</c>:
    /// </param>
    abstract copyBufferToTexture:
        source: GPUImageCopyBuffer *
        destination: GPUImageCopyTexture *
        copySize: GPUExtent3DStrict ->
            obj

    /// <summary>
    /// Encode a command into the <see cref="GPUCommandEncoder" /> that copies data from a sub-region of one or
    /// multiple continuous texture subresources to a sub-region of a <see cref="GPUBuffer" />.
    /// </summary>
    /// <param name="source">Combined with <c>copySize</c>, defines the region of the source texture subresources.</param>
    /// <param name="destination">
    /// Combined with <c>copySize</c>, defines the region of the destination buffer.
    /// <c>copySize</c>:
    /// </param>
    abstract copyTextureToBuffer:
        source: GPUImageCopyTexture *
        destination: GPUImageCopyBuffer *
        copySize: GPUExtent3DStrict ->
            obj

    /// <summary>
    /// Encode a command into the <see cref="GPUCommandEncoder" /> that copies data from a sub-region of one
    /// or multiple contiguous texture subresources to another sub-region of one or
    /// multiple continuous texture subresources.
    /// </summary>
    /// <param name="source">Combined with <c>copySize</c>, defines the region of the source texture subresources.</param>
    /// <param name="destination">
    /// Combined with <c>copySize</c>, defines the region of the destination texture subresources.
    /// <c>copySize</c>:
    /// </param>
    abstract copyTextureToTexture:
        source: GPUImageCopyTexture *
        destination: GPUImageCopyTexture *
        copySize: GPUExtent3DStrict ->
            obj

    /// <summary>
    /// Encode a command into the <see cref="GPUCommandEncoder" /> that fills a sub-region of a
    /// <see cref="GPUBuffer" /> with zeros.
    /// </summary>
    /// <param name="buffer">The <see cref="GPUBuffer" /> to clear.</param>
    /// <param name="offset">Offset in bytes into <c>buffer</c> where the sub-region to clear begins.</param>
    /// <param name="size">Size in bytes of the sub-region to clear. Defaults to the size of the buffer minus <c>offset</c>.</param>
    abstract clearBuffer:
        buffer: GPUBuffer * ?offset: GPUSize64 * ?size: GPUSize64 -> obj

    /// <summary>
    /// Resolves query results from a <see cref="GPUQuerySet" /> out into a range of a <see cref="GPUBuffer" />.
    /// 	querySet:
    /// 	firstQuery:
    /// 	queryCount:
    /// 	destination:
    /// 	destinationOffset:
    /// </summary>
    abstract resolveQuerySet:
        querySet: GPUQuerySet *
        firstQuery: GPUSize32 *
        queryCount: GPUSize32 *
        destination: GPUBuffer *
        destinationOffset: GPUSize64 ->
            obj

    /// <summary>
    /// Completes recording of the commands sequence and returns a corresponding <see cref="GPUCommandBuffer" />.
    /// 	descriptor:
    /// </summary>
    abstract finish: ?descriptor: GPUCommandBufferDescriptor -> GPUCommandBuffer

[<AllowNullLiteral>]
type GPUCompilationInfo =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract messages: ReadonlyArray<GPUCompilationMessage>

[<AllowNullLiteral>]
type GPUCompilationMessage =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>
    /// The human-readable, localizable text for this compilation message.
    /// Note: The <see cref="GPUCompilationMessage.message" /> should follow the best practices for language
    /// and direction information. This includes making use of any future standards which may
    /// emerge regarding the reporting of string language and direction metadata.
    /// &lt;p class="note editorial"&gt;&lt;span class=marker&gt;Editorial note:&lt;/span&gt;
    /// At the time of this writing, no language/direction recommendation is available that provides
    /// compatibility and consistency with legacy APIs, but when there is, adopt it formally.
    /// </summary>
    abstract message: string
    /// <summary>
    /// The severity level of the message.
    /// If the <see cref="GPUCompilationMessage.type" /> is <see cref="GPUCompilationMessageType.">"error"</see>, it
    /// corresponds to a shader-creation error.
    /// </summary>
    abstract ``type``: GPUCompilationMessageType
    /// <summary>
    /// The line number in the shader <see cref="GPUShaderModuleDescriptor.code" /> the
    /// <see cref="GPUCompilationMessage.message" /> corresponds to. Value is one-based, such that a lineNum of
    /// <c>1</c> indicates the first line of the shader <see cref="GPUShaderModuleDescriptor.code" />. Lines are
    /// delimited by line breaks.
    /// If the <see cref="GPUCompilationMessage.message" /> corresponds to a substring this points to
    /// the line on which the substring begins. Must be <c>0</c> if the <see cref="GPUCompilationMessage.message" />
    /// does not correspond to any specific point in the shader <see cref="GPUShaderModuleDescriptor.code" />.
    /// </summary>
    abstract lineNum: float
    /// <summary>
    /// The offset, in UTF-16 code units, from the beginning of line <see cref="GPUCompilationMessage.lineNum" />
    /// of the shader <see cref="GPUShaderModuleDescriptor.code" /> to the point or beginning of the substring
    /// that the <see cref="GPUCompilationMessage.message" /> corresponds to. Value is one-based, such that a
    /// <see cref="GPUCompilationMessage.linePos" /> of <c>1</c> indicates the first code unit of the line.
    /// If <see cref="GPUCompilationMessage.message" /> corresponds to a substring this points to the
    /// first UTF-16 code unit of the substring. Must be <c>0</c> if the <see cref="GPUCompilationMessage.message" />
    /// does not correspond to any specific point in the shader <see cref="GPUShaderModuleDescriptor.code" />.
    /// </summary>
    abstract linePos: float
    /// <summary>
    /// The offset from the beginning of the shader <see cref="GPUShaderModuleDescriptor.code" /> in UTF-16
    /// code units to the point or beginning of the substring that <see cref="GPUCompilationMessage.message" />
    /// corresponds to. Must reference the same position as <see cref="GPUCompilationMessage.lineNum" /> and
    /// <see cref="GPUCompilationMessage.linePos" />. Must be <c>0</c> if the <see cref="GPUCompilationMessage.message" />
    /// does not correspond to any specific point in the shader <see cref="GPUShaderModuleDescriptor.code" />.
    /// </summary>
    abstract offset: float
    /// <summary>
    /// The number of UTF-16 code units in the substring that <see cref="GPUCompilationMessage.message" />
    /// corresponds to. If the message does not correspond with a substring then
    /// <see cref="GPUCompilationMessage.length" /> must be 0.
    /// </summary>
    abstract length: float

[<AllowNullLiteral>]
type GPUComputePassEncoder =
    inherit GPUObjectBase
    inherit GPUCommandsMixin
    inherit GPUDebugCommandsMixin
    inherit GPUBindingCommandsMixin
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>Sets the current <see cref="GPUComputePipeline" />.</summary>
    /// <param name="pipeline">The compute pipeline to use for subsequent dispatch commands.</param>
    abstract setPipeline: pipeline: GPUComputePipeline -> obj

    /// <summary>
    /// Dispatch work to be performed with the current <see cref="GPUComputePipeline" />.
    /// See [[#computing-operations]] for the detailed specification.
    /// </summary>
    /// <param name="workgroupCountX">X dimension of the grid of workgroups to dispatch.</param>
    /// <param name="workgroupCountY">Y dimension of the grid of workgroups to dispatch.</param>
    /// <param name="workgroupCountZ">Z dimension of the grid of workgroups to dispatch.</param>
    abstract dispatchWorkgroups:
        workgroupCountX: GPUSize32 *
        ?workgroupCountY: GPUSize32 *
        ?workgroupCountZ: GPUSize32 ->
            obj

    /// <summary>
    /// Dispatch work to be performed with the current <see cref="GPUComputePipeline" /> using parameters read
    /// from a <see cref="GPUBuffer" />.
    /// See [[#computing-operations]] for the detailed specification.
    /// packed block of **three 32-bit unsigned integer values (12 bytes total)**,
    /// given in the same order as the arguments for <see cref="GPUComputePassEncoder.dispatchWorkgroups" />.
    /// For example:
    /// </summary>
    /// <param name="indirectBuffer">Buffer containing the indirect dispatch parameters.</param>
    /// <param name="indirectOffset">Offset in bytes into <c>indirectBuffer</c> where the dispatch data begins.</param>
    abstract dispatchWorkgroupsIndirect:
        indirectBuffer: GPUBuffer * indirectOffset: GPUSize64 -> obj

    /// Completes recording of the compute pass commands sequence.
    abstract ``end``: unit -> obj

[<AllowNullLiteral>]
type GPUComputePipeline =
    inherit GPUObjectBase
    inherit GPUPipelineBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUDevice =
    inherit EventTarget
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>
    /// A set containing the <see cref="GPUFeatureName" /> values of the features
    /// supported by the device (i.e. the ones with which it was created).
    /// </summary>
    abstract features: GPUSupportedFeatures
    /// Exposes the limits supported by the device
    /// (which are exactly the ones with which it was created).
    abstract limits: GPUSupportedLimits
    /// <summary>The primary <see cref="GPUQueue" /> for this device.</summary>
    abstract queue: GPUQueue
    /// Destroys the device, preventing further operations on it.
    /// Outstanding asynchronous operations will fail.
    /// Note: It is valid to destroy a device multiple times.
    abstract destroy: unit -> obj
    /// <summary>Creates a <see cref="GPUBuffer" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUBuffer" /> to create.</param>
    abstract createBuffer: descriptor: GPUBufferDescriptor -> GPUBuffer
    /// <summary>Creates a <see cref="GPUTexture" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUTexture" /> to create.</param>
    abstract createTexture: descriptor: GPUTextureDescriptor -> GPUTexture
    /// <summary>Creates a <see cref="GPUSampler" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUSampler" /> to create.</param>
    abstract createSampler: ?descriptor: GPUSamplerDescriptor -> GPUSampler

    /// <summary>Creates a <see cref="GPUExternalTexture" /> wrapping the provided image source.</summary>
    /// <param name="descriptor">Provides the external image source object (and any creation options).</param>
    abstract importExternalTexture:
        descriptor: GPUExternalTextureDescriptor -> GPUExternalTexture

    /// <summary>Creates a <see cref="GPUBindGroupLayout" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUBindGroupLayout" /> to create.</param>
    abstract createBindGroupLayout:
        descriptor: GPUBindGroupLayoutDescriptor -> GPUBindGroupLayout

    /// <summary>Creates a <see cref="GPUPipelineLayout" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUPipelineLayout" /> to create.</param>
    abstract createPipelineLayout:
        descriptor: GPUPipelineLayoutDescriptor -> GPUPipelineLayout

    /// <summary>Creates a <see cref="GPUBindGroup" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUBindGroup" /> to create.</param>
    abstract createBindGroup: descriptor: GPUBindGroupDescriptor -> GPUBindGroup

    /// <summary>Creates a <see cref="GPUShaderModule" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUShaderModule" /> to create.</param>
    abstract createShaderModule:
        descriptor: GPUShaderModuleDescriptor -> GPUShaderModule

    /// <summary>Creates a <see cref="GPUComputePipeline" /> using immediate pipeline creation.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUComputePipeline" /> to create.</param>
    abstract createComputePipeline:
        descriptor: GPUComputePipelineDescriptor -> GPUComputePipeline

    /// <summary>Creates a <see cref="GPURenderPipeline" /> using immediate pipeline creation.</summary>
    /// <param name="descriptor">Description of the <see cref="GPURenderPipeline" /> to create.</param>
    abstract createRenderPipeline:
        descriptor: GPURenderPipelineDescriptor -> GPURenderPipeline

    /// <summary>
    /// Creates a <see cref="GPUComputePipeline" /> using async pipeline creation.
    /// The returned <see cref="Promise" /> resolves when the created pipeline
    /// is ready to be used without additional delay.
    /// If pipeline creation fails, the returned <see cref="Promise" /> rejects with an <see cref="GPUPipelineError" />.
    /// Note: Use of this method is preferred whenever possible, as it prevents blocking the
    /// queue timeline work on pipeline compilation.
    /// </summary>
    /// <param name="descriptor">Description of the <see cref="GPUComputePipeline" /> to create.</param>
    abstract createComputePipelineAsync:
        descriptor: GPUComputePipelineDescriptor ->
            JS.Promise<GPUComputePipeline>

    /// <summary>
    /// Creates a <see cref="GPURenderPipeline" /> using async pipeline creation.
    /// The returned <see cref="Promise" /> resolves when the created pipeline
    /// is ready to be used without additional delay.
    /// If pipeline creation fails, the returned <see cref="Promise" /> rejects with an <see cref="GPUPipelineError" />.
    /// Note: Use of this method is preferred whenever possible, as it prevents blocking the
    /// queue timeline work on pipeline compilation.
    /// </summary>
    /// <param name="descriptor">Description of the <see cref="GPURenderPipeline" /> to create.</param>
    abstract createRenderPipelineAsync:
        descriptor: GPURenderPipelineDescriptor -> JS.Promise<GPURenderPipeline>

    /// <summary>Creates a <see cref="GPUCommandEncoder" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUCommandEncoder" /> to create.</param>
    abstract createCommandEncoder:
        ?descriptor: GPUCommandEncoderDescriptor -> GPUCommandEncoder

    /// <summary>Creates a <see cref="GPURenderBundleEncoder" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPURenderBundleEncoder" /> to create.</param>
    abstract createRenderBundleEncoder:
        descriptor: GPURenderBundleEncoderDescriptor -> GPURenderBundleEncoder

    /// <summary>Creates a <see cref="GPUQuerySet" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUQuerySet" /> to create.</param>
    abstract createQuerySet: descriptor: GPUQuerySetDescriptor -> GPUQuerySet
    /// A slot-backed attribute holding a promise which is created with the device, remains
    /// pending for the lifetime of the device, then resolves when the device is lost.
    /// Upon initialization, it is set to a new promise.
    abstract lost: JS.Promise<GPUDeviceLostInfo>
    /// <summary>Pushes a new GPU error scope onto the <see cref="GPUDevice.">[[errorScopeStack]]</see> for <c>this</c>.</summary>
    /// <param name="filter">Which class of errors this error scope observes.</param>
    abstract pushErrorScope: filter: GPUErrorFilter -> obj
    /// <summary>
    /// Pops a GPU error scope off the <see cref="GPUDevice.">[[errorScopeStack]]</see> for <c>this</c>
    /// and resolves to **any** <see cref="GPUError" /> observed by the error scope, or <c>null</c> if none.
    /// There is no guarantee of the ordering of promise resolution.
    /// </summary>
    abstract popErrorScope: unit -> JS.Promise<GPUError option>

    /// <summary>An event handler IDL attribute for the <see cref="GPUDevice.uncapturederror" /> event type.</summary>
    abstract onuncapturederror:
        (GPUDevice -> GPUUncapturedErrorEvent -> obj option) option with get, set

[<AllowNullLiteral>]
type GPUDeviceLostInfo =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract reason: GPUDeviceLostReason
    abstract message: string

[<AllowNullLiteral>]
type GPUError =
    /// <summary>
    /// A human-readable, localizable text message providing information about the error that
    /// occurred.
    /// Note: This message is generally intended for application developers to debug their
    /// applications and capture information for debug reports, not to be surfaced to end-users.
    /// Note: User agents should not include potentially machine-parsable details in this message,
    /// such as free system memory on <see cref="GPUErrorFilter.">"out-of-memory"</see> or other details about the
    /// conditions under which memory was exhausted.
    /// Note: The <see cref="GPUError.message" /> should follow the best practices for language and
    /// direction information. This includes making use of any future standards which may emerge
    /// regarding the reporting of string language and direction metadata.
    /// &lt;p class="note editorial"&gt;&lt;span class=marker&gt;Editorial note:&lt;/span&gt;
    /// At the time of this writing, no language/direction recommendation is available that provides
    /// compatibility and consistency with legacy APIs, but when there is, adopt it formally.
    /// </summary>
    abstract message: string

[<AllowNullLiteral>]
type GPUExternalTexture =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUInternalError =
    inherit GPUError
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUOutOfMemoryError =
    inherit GPUError
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUPipelineError =
    inherit DOMException
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// A read-only slot-backed attribute exposing the type of error encountered in pipeline creation
    /// as a <dfn enum for="">GPUPipelineErrorReason</dfn>:
    /// <ul dfn-type=enum-value dfn-for=GPUPipelineErrorReason>
    /// - <dfn>"validation"</dfn>: A [$validation error$].
    /// - <dfn>"internal"</dfn>: An [$internal error$].
    /// </ul>
    abstract reason: GPUPipelineErrorReason

[<AllowNullLiteral>]
type GPUPipelineLayout =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUQuerySet =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>Destroys the <see cref="GPUQuerySet" />.</summary>
    abstract destroy: unit -> obj
    /// <summary>The type of the queries managed by this <see cref="GPUQuerySet" />.</summary>
    abstract ``type``: GPUQueryType
    /// <summary>The number of queries managed by this <see cref="GPUQuerySet" />.</summary>
    abstract count: GPUSize32Out

[<AllowNullLiteral>]
type GPUQueue =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>
    /// Schedules the execution of the command buffers by the GPU on this queue.
    /// Submitted command buffers cannot be used again.
    /// 	<c>commandBuffers</c>:
    /// </summary>
    abstract submit: commandBuffers: Iterable<GPUCommandBuffer> -> obj
    /// <summary>
    /// Returns a <see cref="Promise" /> that resolves once this queue finishes processing all the work submitted
    /// up to this moment.
    /// Resolution of this <see cref="Promise" /> implies the completion of
    /// <see cref="GPUBuffer.mapAsync" /> calls made prior to that call,
    /// on <see cref="GPUBuffer" />s last used exclusively on that queue.
    /// </summary>
    abstract onSubmittedWorkDone: unit -> JS.Promise<obj>

    /// <summary>Issues a write operation of the provided data into a <see cref="GPUBuffer" />.</summary>
    /// <param name="buffer">The buffer to write to.</param>
    /// <param name="bufferOffset">Offset in bytes into <c>buffer</c> to begin writing at.</param>
    /// <param name="data">Data to write into <c>buffer</c>.</param>
    /// <param name="dataOffset">
    /// Offset in into <c>data</c> to begin writing from. Given in elements if
    /// <c>data</c> is a <c>TypedArray</c> and bytes otherwise.
    /// </param>
    /// <param name="size">
    /// Size of content to write from <c>data</c> to <c>buffer</c>. Given in elements if
    /// <c>data</c> is a <c>TypedArray</c> and bytes otherwise.
    /// </param>
    abstract writeBuffer:
        buffer: GPUBuffer *
        bufferOffset: GPUSize64 *
        data: U2<BufferSource, SharedArrayBuffer> *
        ?dataOffset: GPUSize64 *
        ?size: GPUSize64 ->
            obj

    /// <summary>Issues a write operation of the provided data into a <see cref="GPUTexture" />.</summary>
    /// <param name="destination">The texture subresource and origin to write to.</param>
    /// <param name="data">Data to write into <c>destination</c>.</param>
    /// <param name="dataLayout">Layout of the content in <c>data</c>.</param>
    /// <param name="size">Extents of the content to write from <c>data</c> to <c>destination</c>.</param>
    abstract writeTexture:
        destination: GPUImageCopyTexture *
        data: U2<BufferSource, SharedArrayBuffer> *
        dataLayout: GPUImageDataLayout *
        size: GPUExtent3DStrict ->
            obj

    /// <summary>
    /// Issues a copy operation of the contents of a platform image/canvas
    /// into the destination texture.
    /// This operation performs [[#color-space-conversions|color encoding]] into the destination
    /// encoding according to the parameters of <see cref="GPUImageCopyTextureTagged" />.
    /// Copying into a <c>-srgb</c> texture results in the same texture bytes, not the same decoded
    /// values, as copying into the corresponding non-<c>-srgb</c> format.
    /// Thus, after a copy operation, sampling the destination texture has
    /// different results depending on whether its format is <c>-srgb</c>, all else unchanged.
    /// &lt;!-- POSTV1(srgb-linear): If added, explain here how it interacts. --&gt;
    /// </summary>
    /// <param name="source">source image and origin to copy to <c>destination</c>.</param>
    /// <param name="destination">The texture subresource and origin to write to, and its encoding metadata.</param>
    /// <param name="copySize">Extents of the content to write from <c>source</c> to <c>destination</c>.</param>
    abstract copyExternalImageToTexture:
        source: GPUImageCopyExternalImage *
        destination: GPUImageCopyTextureTagged *
        copySize: GPUExtent3DStrict ->
            obj

[<AllowNullLiteral>]
type GPURenderBundle =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPURenderBundleEncoder =
    inherit GPUObjectBase
    inherit GPUCommandsMixin
    inherit GPUDebugCommandsMixin
    inherit GPUBindingCommandsMixin
    inherit GPURenderCommandsMixin
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// Completes recording of the render bundle commands sequence.
    /// 	descriptor:
    abstract finish: ?descriptor: GPURenderBundleDescriptor -> GPURenderBundle

[<AllowNullLiteral>]
type GPURenderPassEncoder =
    inherit GPUObjectBase
    inherit GPUCommandsMixin
    inherit GPUDebugCommandsMixin
    inherit GPUBindingCommandsMixin
    inherit GPURenderCommandsMixin
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

    /// <summary>
    /// Sets the viewport used during the rasterization stage to linearly map from
    /// NDC|normalized device coordinates to viewport coordinates.
    /// </summary>
    /// <param name="x">Minimum X value of the viewport in pixels.</param>
    /// <param name="y">Minimum Y value of the viewport in pixels.</param>
    /// <param name="width">Width of the viewport in pixels.</param>
    /// <param name="height">Height of the viewport in pixels.</param>
    /// <param name="minDepth">Minimum depth value of the viewport.</param>
    /// <param name="maxDepth">Maximum depth value of the viewport.</param>
    abstract setViewport:
        x: float *
        y: float *
        width: float *
        height: float *
        minDepth: float *
        maxDepth: float ->
            obj

    /// <summary>
    /// Sets the scissor rectangle used during the rasterization stage.
    /// After transformation into viewport coordinates any fragments which fall outside the scissor
    /// rectangle will be discarded.
    /// </summary>
    /// <param name="x">Minimum X value of the scissor rectangle in pixels.</param>
    /// <param name="y">Minimum Y value of the scissor rectangle in pixels.</param>
    /// <param name="width">Width of the scissor rectangle in pixels.</param>
    /// <param name="height">Height of the scissor rectangle in pixels.</param>
    abstract setScissorRect:
        x: GPUIntegerCoordinate *
        y: GPUIntegerCoordinate *
        width: GPUIntegerCoordinate *
        height: GPUIntegerCoordinate ->
            obj

    /// <summary>
    /// Sets the constant blend color and alpha values used with <see cref="GPUBlendFactor.">"constant"</see>
    /// and <see cref="GPUBlendFactor.">"one-minus-constant"</see> <see cref="GPUBlendFactor" />s.
    /// </summary>
    /// <param name="color">The color to use when blending.</param>
    abstract setBlendConstant: color: Iterable<float> -> obj

    /// <summary>
    /// Sets the constant blend color and alpha values used with <see cref="GPUBlendFactor.">"constant"</see>
    /// and <see cref="GPUBlendFactor.">"one-minus-constant"</see> <see cref="GPUBlendFactor" />s.
    /// </summary>
    /// <param name="color">The color to use when blending.</param>
    abstract setBlendConstant: color: GPUColorDict -> obj

    /// <summary>
    /// Sets the <see cref="RenderState.">[[stencilReference]]</see> value used during stencil tests with
    /// the <see cref="GPUStencilOperation.">"replace"</see> <see cref="GPUStencilOperation" />.
    /// </summary>
    /// <param name="reference">The new stencil reference value.</param>
    abstract setStencilReference: reference: GPUStencilValue -> obj
    /// <param name="queryIndex">The index of the query in the query set.</param>
    abstract beginOcclusionQuery: queryIndex: GPUSize32 -> obj
    abstract endOcclusionQuery: unit -> obj
    /// <summary>
    /// Executes the commands previously recorded into the given <see cref="GPURenderBundle" />s as part of
    /// this render pass.
    /// When a <see cref="GPURenderBundle" /> is executed, it does not inherit the render pass's pipeline, bind
    /// groups, or vertex and index buffers. After a <see cref="GPURenderBundle" /> has executed, the render
    /// pass's pipeline, bind group, and vertex/index buffer state is cleared
    /// (to the initial, empty values).
    /// Note: The state is cleared, not restored to the previous state.
    /// This occurs even if zero <see cref="GPURenderBundleGPURenderBundles" /> are executed.
    /// </summary>
    /// <param name="bundles">List of render bundles to execute.</param>
    abstract executeBundles: bundles: Iterable<GPURenderBundle> -> obj
    /// Completes recording of the render pass commands sequence.
    abstract ``end``: unit -> obj

[<AllowNullLiteral>]
type GPURenderPipeline =
    inherit GPUObjectBase
    inherit GPUPipelineBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUSampler =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUShaderModule =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>
    /// Returns any messages generated during the <see cref="GPUShaderModule" />'s compilation.
    /// The locations, order, and contents of messages are implementation-defined.
    /// In particular, messages may not be ordered by <see cref="GPUCompilationMessage.lineNum" />.
    /// </summary>
    abstract getCompilationInfo: unit -> JS.Promise<GPUCompilationInfo>

type GPUSupportedFeatures =
    // ReadonlySet<string>
    string seq

[<AllowNullLiteral>]
type GPUSupportedLimits =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract maxTextureDimension1D: float
    abstract maxTextureDimension2D: float
    abstract maxTextureDimension3D: float
    abstract maxTextureArrayLayers: float
    abstract maxBindGroups: float
    abstract maxBindGroupsPlusVertexBuffers: float
    abstract maxBindingsPerBindGroup: float
    abstract maxDynamicUniformBuffersPerPipelineLayout: float
    abstract maxDynamicStorageBuffersPerPipelineLayout: float
    abstract maxSampledTexturesPerShaderStage: float
    abstract maxSamplersPerShaderStage: float
    abstract maxStorageBuffersPerShaderStage: float
    abstract maxStorageTexturesPerShaderStage: float
    abstract maxUniformBuffersPerShaderStage: float
    abstract maxUniformBufferBindingSize: float
    abstract maxStorageBufferBindingSize: float
    abstract minUniformBufferOffsetAlignment: float
    abstract minStorageBufferOffsetAlignment: float
    abstract maxVertexBuffers: float
    abstract maxBufferSize: float
    abstract maxVertexAttributes: float
    abstract maxVertexBufferArrayStride: float
    abstract maxInterStageShaderComponents: float
    abstract maxInterStageShaderVariables: float
    abstract maxColorAttachments: float
    abstract maxColorAttachmentBytesPerSample: float
    abstract maxComputeWorkgroupStorageSize: float
    abstract maxComputeInvocationsPerWorkgroup: float
    abstract maxComputeWorkgroupSizeX: float
    abstract maxComputeWorkgroupSizeY: float
    abstract maxComputeWorkgroupSizeZ: float
    abstract maxComputeWorkgroupsPerDimension: float

[<AllowNullLiteral>]
type GPUTexture =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>Creates a <see cref="GPUTextureView" />.</summary>
    /// <param name="descriptor">Description of the <see cref="GPUTextureView" /> to create.</param>
    abstract createView: ?descriptor: GPUTextureViewDescriptor -> GPUTextureView
    /// <summary>Destroys the <see cref="GPUTexture" />.</summary>
    abstract destroy: unit -> obj
    /// <summary>The width of this <see cref="GPUTexture" />.</summary>
    abstract width: GPUIntegerCoordinateOut
    /// <summary>The height of this <see cref="GPUTexture" />.</summary>
    abstract height: GPUIntegerCoordinateOut
    /// <summary>The depth or layer count of this <see cref="GPUTexture" />.</summary>
    abstract depthOrArrayLayers: GPUIntegerCoordinateOut
    /// <summary>The number of mip levels of this <see cref="GPUTexture" />.</summary>
    abstract mipLevelCount: GPUIntegerCoordinateOut
    /// <summary>The number of sample count of this <see cref="GPUTexture" />.</summary>
    abstract sampleCount: GPUSize32Out
    /// <summary>The dimension of the set of texel for each of this <see cref="GPUTexture" />'s subresources.</summary>
    abstract dimension: GPUTextureDimension
    /// <summary>The format of this <see cref="GPUTexture" />.</summary>
    abstract format: GPUTextureFormat
    /// <summary>The allowed usages for this <see cref="GPUTexture" />.</summary>
    abstract usage: GPUFlagsConstant

[<AllowNullLiteral>]
type GPUTextureView =
    inherit GPUObjectBase
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

[<AllowNullLiteral>]
type GPUUncapturedErrorEvent =
    inherit Event
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    /// <summary>
    /// A slot-backed attribute holding an object representing the error that was uncaptured.
    /// This has the same type as errors returned by <see cref="GPUDevice.popErrorScope" />.
    /// </summary>
    abstract error: GPUError

[<AllowNullLiteral>]
type GPUValidationError =
    inherit GPUError
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string

type WGSLLanguageFeatures =
    // ReadonlySet<string>
    string seq

[<AllowNullLiteral>]
type WorkerNavigator =
    inherit NavigatorGPU

[<AllowNullLiteral>]
type GPUBufferUsage =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract MAP_READ: GPUFlagsConstant
    abstract MAP_WRITE: GPUFlagsConstant
    abstract COPY_SRC: GPUFlagsConstant
    abstract COPY_DST: GPUFlagsConstant
    abstract INDEX: GPUFlagsConstant
    abstract VERTEX: GPUFlagsConstant
    abstract UNIFORM: GPUFlagsConstant
    abstract STORAGE: GPUFlagsConstant
    abstract INDIRECT: GPUFlagsConstant
    abstract QUERY_RESOLVE: GPUFlagsConstant

[<AllowNullLiteral>]
type GPUColorWrite =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract RED: GPUFlagsConstant
    abstract GREEN: GPUFlagsConstant
    abstract BLUE: GPUFlagsConstant
    abstract ALPHA: GPUFlagsConstant
    abstract ALL: GPUFlagsConstant

[<AllowNullLiteral>]
type GPUMapMode =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract READ: GPUFlagsConstant
    abstract WRITE: GPUFlagsConstant

[<AllowNullLiteral>]
type GPUShaderStage =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract VERTEX: GPUShaderStageFlags
    abstract FRAGMENT: GPUShaderStageFlags
    abstract COMPUTE: GPUShaderStageFlags

[<AllowNullLiteral>]
type GPUTextureUsage =
    /// <summary>
    /// Nominal type branding.
    /// <see href="https://github.com/microsoft/TypeScript/pull/33038" />
    /// </summary>
    abstract __brand: string
    abstract COPY_SRC: GPUTextureUsageFlags
    abstract COPY_DST: GPUTextureUsageFlags
    abstract TEXTURE_BINDING: GPUTextureUsageFlags
    abstract STORAGE_BINDING: GPUTextureUsageFlags
    abstract RENDER_ATTACHMENT: GPUTextureUsageFlags


[<Global>]
let GPUBufferUsage: GPUBufferUsage = jsNative

[<Global>]
let GPUColorWrite: GPUColorWrite = jsNative

[<Global>]
let GPUTextureUsage: GPUTextureUsage = jsNative

[<Global>]
let GPUMapMode: GPUMapMode = jsNative

[<Global>]
let GPUShaderStage: GPUShaderStage = jsNative


// type [<AllowNullLiteral>] GPUBufferUsage =
//     abstract prototype: GPUBufferUsage with get, set
//     abstract MAP_READ: GPUFlagsConstant
//     abstract MAP_WRITE: GPUFlagsConstant
//     abstract COPY_SRC: GPUFlagsConstant
//     abstract COPY_DST: GPUFlagsConstant
//     abstract INDEX: GPUFlagsConstant
//     abstract VERTEX: GPUFlagsConstant
//     abstract UNIFORM: GPUFlagsConstant
//     abstract STORAGE: GPUFlagsConstant
//     abstract INDIRECT: GPUFlagsConstant
//     abstract QUERY_RESOLVE: GPUFlagsConstant

// type [<AllowNullLiteral>] GPUColorWrite =
//     abstract prototype: GPUColorWrite with get, set
//     abstract RED: GPUFlagsConstant
//     abstract GREEN: GPUFlagsConstant
//     abstract BLUE: GPUFlagsConstant
//     abstract ALPHA: GPUFlagsConstant
//     abstract ALL: GPUFlagsConstant

// type [<AllowNullLiteral>] GPUTextureUsage =
//     abstract prototype: GPUTextureUsage with get, set
//     abstract COPY_SRC: GPUFlagsConstant
//     abstract COPY_DST: GPUFlagsConstant
//     abstract TEXTURE_BINDING: GPUFlagsConstant
//     abstract STORAGE_BINDING: GPUFlagsConstant
//     abstract RENDER_ATTACHMENT: GPUFlagsConstant

// Types that should be inside of another binding


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type PredefinedColorSpace =
    | ``display-p3``
    | Srgb

/// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly">MDN Reference</see></summary>
[<AllowNullLiteral>]
type DOMRectReadOnly =
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/bottom">MDN Reference</see></summary>
    abstract bottom: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/height">MDN Reference</see></summary>
    abstract height: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/left">MDN Reference</see></summary>
    abstract left: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/right">MDN Reference</see></summary>
    abstract right: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/top">MDN Reference</see></summary>
    abstract top: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/width">MDN Reference</see></summary>
    abstract width: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/x">MDN Reference</see></summary>
    abstract x: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/DOMRectReadOnly/y">MDN Reference</see></summary>
    abstract y: float
    abstract toJSON: unit -> obj option

/// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace">MDN Reference</see></summary>
[<AllowNullLiteral>]
type VideoColorSpace =
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace/fullRange">MDN Reference</see></summary>
    abstract fullRange: bool option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace/matrix">MDN Reference</see></summary>
    abstract matrix: VideoMatrixCoefficients option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace/primaries">MDN Reference</see></summary>
    abstract primaries: VideoColorPrimaries option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace/transfer">MDN Reference</see></summary>
    abstract transfer: VideoTransferCharacteristics option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoColorSpace/toJSON">MDN Reference</see></summary>
    abstract toJSON: unit -> VideoColorSpaceInit

[<AllowNullLiteral>]
type VideoColorSpaceInit =
    abstract fullRange: bool option with get, set
    abstract matrix: VideoMatrixCoefficients option with get, set
    abstract primaries: VideoColorPrimaries option with get, set
    abstract transfer: VideoTransferCharacteristics option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoPixelFormat =
    | BGRA
    | BGRX
    | I420
    | I420A
    | I422
    | I444
    | NV12
    | RGBA
    | RGBX


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoMatrixCoefficients =
    | bt470bg
    | bt709
    | rgb
    | smpte170m

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoColorPrimaries =
    | bt470bg
    | bt709
    | smpte170m

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type VideoTransferCharacteristics =
    | bt709
    | ``iec61966-2-1``
    | ``smpte170m``

[<AllowNullLiteral>]
type VideoFrameCopyToOptions =
    abstract layout: ResizeArray<PlaneLayout> option with get, set
    abstract rect: DOMRectInit option with get, set

[<AllowNullLiteral>]
type PlaneLayout =
    abstract offset: float with get, set
    abstract stride: float with get, set

[<AllowNullLiteral>]
type DOMRectInit =
    abstract height: float option with get, set
    abstract width: float option with get, set
    abstract x: float option with get, set
    abstract y: float option with get, set

/// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame">MDN Reference</see></summary>
[<AllowNullLiteral>]
type VideoFrame =
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/codedHeight">MDN Reference</see></summary>
    abstract codedHeight: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/codedRect">MDN Reference</see></summary>
    abstract codedRect: DOMRectReadOnly option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/codedWidth">MDN Reference</see></summary>
    abstract codedWidth: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/colorSpace">MDN Reference</see></summary>
    abstract colorSpace: VideoColorSpace
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/displayHeight">MDN Reference</see></summary>
    abstract displayHeight: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/displayWidth">MDN Reference</see></summary>
    abstract displayWidth: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/duration">MDN Reference</see></summary>
    abstract duration: float option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/format">MDN Reference</see></summary>
    abstract format: VideoPixelFormat option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/timestamp">MDN Reference</see></summary>
    abstract timestamp: float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/visibleRect">MDN Reference</see></summary>
    abstract visibleRect: DOMRectReadOnly option
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/allocationSize">MDN Reference</see></summary>
    abstract allocationSize: ?options: VideoFrameCopyToOptions -> float
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/clone">MDN Reference</see></summary>
    abstract clone: unit -> VideoFrame
    /// <summary><see href="https://developer.mozilla.org/docs/Web/API/VideoFrame/close">MDN Reference</see></summary>
    abstract close: unit -> unit

    abstract copyTo:
        destination: BufferSource * ?options: VideoFrameCopyToOptions ->
            JS.Promise<ResizeArray<PlaneLayout>>

type BufferSource = U2<JS.ArrayBufferView, JS.ArrayBuffer>

[<AllowNullLiteral>]
type ConcatArray<'T> =
    abstract length: float

    [<EmitIndexer>]
    abstract Item: n: float -> 'T

    abstract join: ?separator: string -> string
    abstract slice: ?start: float * ?``end``: float -> ResizeArray<'T>

[<AllowNullLiteral>]
type ReadonlyArray<'T> =
    /// Gets the length of the array. This is a number one higher than the highest element defined in an array.
    abstract length: float
    /// Returns a string representation of an array.
    abstract toString: unit -> string
    /// Returns a string representation of an array. The elements are converted to string using their toLocaleString methods.
    abstract toLocaleString: unit -> string
    /// <summary>Combines two or more arrays.</summary>
    /// <param name="items">Additional items to add to the end of array1.</param>
    abstract concat: [<ParamArray>] items: ConcatArray<'T>[] -> ResizeArray<'T>

    /// <summary>Combines two or more arrays.</summary>
    /// <param name="items">Additional items to add to the end of array1.</param>
    abstract concat:
        [<ParamArray>] items: U2<'T, ConcatArray<'T>>[] -> ResizeArray<'T>

    /// <summary>Adds all the elements of an array separated by the specified separator string.</summary>
    /// <param name="separator">A string used to separate one element of an array from the next in the resulting String. If omitted, the array elements are separated with a comma.</param>
    abstract join: ?separator: string -> string
    /// <summary>Returns a section of an array.</summary>
    /// <param name="start">The beginning of the specified portion of the array.</param>
    /// <param name="end">The end of the specified portion of the array. This is exclusive of the element at the index 'end'.</param>
    abstract slice: ?start: float * ?``end``: float -> ResizeArray<'T>
    /// <summary>Returns the index of the first occurrence of a value in an array.</summary>
    /// <param name="searchElement">The value to locate in the array.</param>
    /// <param name="fromIndex">The array index at which to begin the search. If fromIndex is omitted, the search starts at index 0.</param>
    abstract indexOf: searchElement: 'T * ?fromIndex: float -> float
    /// <summary>Returns the index of the last occurrence of a specified value in an array.</summary>
    /// <param name="searchElement">The value to locate in the array.</param>
    /// <param name="fromIndex">The array index at which to begin the search. If fromIndex is omitted, the search starts at the last index in the array.</param>
    abstract lastIndexOf: searchElement: 'T * ?fromIndex: float -> float

    /// <summary>Determines whether all the members of an array satisfy the specified test.</summary>
    /// <param name="predicate">
    /// A function that accepts up to three arguments. The every method calls
    /// the predicate function for each element in the array until the predicate returns a value
    /// which is coercible to the Boolean value false, or until the end of the array.
    /// </param>
    /// <param name="thisArg">
    /// An object to which the this keyword can refer in the predicate function.
    /// If thisArg is omitted, undefined is used as the this value.
    /// </param>
    abstract every:
        predicate: ('T -> float -> ResizeArray<'T> -> bool) * ?thisArg: obj ->
            bool
            when 'S :> 'T

    /// <summary>Determines whether all the members of an array satisfy the specified test.</summary>
    /// <param name="predicate">
    /// A function that accepts up to three arguments. The every method calls
    /// the predicate function for each element in the array until the predicate returns a value
    /// which is coercible to the Boolean value false, or until the end of the array.
    /// </param>
    /// <param name="thisArg">
    /// An object to which the this keyword can refer in the predicate function.
    /// If thisArg is omitted, undefined is used as the this value.
    /// </param>
    abstract every:
        predicate: ('T -> float -> ResizeArray<'T> -> obj) * ?thisArg: obj ->
            bool

    /// <summary>Determines whether the specified callback function returns true for any element of an array.</summary>
    /// <param name="predicate">
    /// A function that accepts up to three arguments. The some method calls
    /// the predicate function for each element in the array until the predicate returns a value
    /// which is coercible to the Boolean value true, or until the end of the array.
    /// </param>
    /// <param name="thisArg">
    /// An object to which the this keyword can refer in the predicate function.
    /// If thisArg is omitted, undefined is used as the this value.
    /// </param>
    abstract some:
        predicate: ('T -> float -> ResizeArray<'T> -> obj) * ?thisArg: obj ->
            bool

    /// <summary>Performs the specified action for each element in an array.</summary>
    /// <param name="callbackfn">A function that accepts up to three arguments. forEach calls the callbackfn function one time for each element in the array.</param>
    /// <param name="thisArg">An object to which the this keyword can refer in the callbackfn function. If thisArg is omitted, undefined is used as the this value.</param>
    abstract forEach:
        callbackfn: ('T -> float -> ResizeArray<'T> -> unit) * ?thisArg: obj ->
            unit

    /// <summary>Calls a defined callback function on each element of an array, and returns an array that contains the results.</summary>
    /// <param name="callbackfn">A function that accepts up to three arguments. The map method calls the callbackfn function one time for each element in the array.</param>
    /// <param name="thisArg">An object to which the this keyword can refer in the callbackfn function. If thisArg is omitted, undefined is used as the this value.</param>
    abstract map:
        callbackfn: ('T -> float -> ResizeArray<'T> -> 'U) * ?thisArg: obj ->
            ResizeArray<'U>

    /// <summary>Returns the elements of an array that meet the condition specified in a callback function.</summary>
    /// <param name="predicate">A function that accepts up to three arguments. The filter method calls the predicate function one time for each element in the array.</param>
    /// <param name="thisArg">An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value.</param>
    abstract filter:
        predicate: ('T -> float -> ResizeArray<'T> -> bool) * ?thisArg: obj ->
            ResizeArray<'S>
            when 'S :> 'T

    /// <summary>Returns the elements of an array that meet the condition specified in a callback function.</summary>
    /// <param name="predicate">A function that accepts up to three arguments. The filter method calls the predicate function one time for each element in the array.</param>
    /// <param name="thisArg">An object to which the this keyword can refer in the predicate function. If thisArg is omitted, undefined is used as the this value.</param>
    abstract filter:
        predicate: ('T -> float -> ResizeArray<'T> -> obj) * ?thisArg: obj ->
            ResizeArray<'T>

    /// <summary>Calls the specified callback function for all the elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.</summary>
    /// <param name="callbackfn">A function that accepts up to four arguments. The reduce method calls the callbackfn function one time for each element in the array.</param>
    /// <param name="initialValue">If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value.</param>
    abstract reduce:
        callbackfn: ('T -> 'T -> float -> ResizeArray<'T> -> 'T) -> 'T

    abstract reduce:
        callbackfn: ('T -> 'T -> float -> ResizeArray<'T> -> 'T) *
        initialValue: 'T ->
            'T

    /// <summary>Calls the specified callback function for all the elements in an array. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.</summary>
    /// <param name="callbackfn">A function that accepts up to four arguments. The reduce method calls the callbackfn function one time for each element in the array.</param>
    /// <param name="initialValue">If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value.</param>
    abstract reduce:
        callbackfn: ('U -> 'T -> float -> ResizeArray<'T> -> 'U) *
        initialValue: 'U ->
            'U

    /// <summary>Calls the specified callback function for all the elements in an array, in descending order. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.</summary>
    /// <param name="callbackfn">A function that accepts up to four arguments. The reduceRight method calls the callbackfn function one time for each element in the array.</param>
    /// <param name="initialValue">If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value.</param>
    abstract reduceRight:
        callbackfn: ('T -> 'T -> float -> ResizeArray<'T> -> 'T) -> 'T

    abstract reduceRight:
        callbackfn: ('T -> 'T -> float -> ResizeArray<'T> -> 'T) *
        initialValue: 'T ->
            'T

    /// <summary>Calls the specified callback function for all the elements in an array, in descending order. The return value of the callback function is the accumulated result, and is provided as an argument in the next call to the callback function.</summary>
    /// <param name="callbackfn">A function that accepts up to four arguments. The reduceRight method calls the callbackfn function one time for each element in the array.</param>
    /// <param name="initialValue">If initialValue is specified, it is used as the initial value to start the accumulation. The first call to the callbackfn function provides this value as an argument instead of an array value.</param>
    abstract reduceRight:
        callbackfn: ('U -> 'T -> float -> ResizeArray<'T> -> 'U) *
        initialValue: 'U ->
            'U

    [<EmitIndexer>]
    abstract Item: n: float -> 'T

[<AllowNullLiteral>]
type SharedArrayBuffer =
    /// Read-only. The length of the ArrayBuffer (in bytes).
    abstract byteLength: float
    /// Returns a section of an SharedArrayBuffer.
    abstract slice: ``begin``: float * ?``end``: float -> SharedArrayBuffer
    abstract ``[Symbol.species]``: SharedArrayBuffer
    abstract ``[Symbol.toStringTag]``: string

/// <summary><see href="https://developer.mozilla.org/docs/Web/API/ImageBitmap">MDN Reference</see></summary>
[<AllowNullLiteral>]
type ImageBitmap =
    /// <summary>
    /// Returns the intrinsic height of the image, in CSS pixels.
    ///
    /// <see href="https://developer.mozilla.org/docs/Web/API/ImageBitmap/height">MDN Reference</see>
    /// </summary>
    abstract height: float
    /// <summary>
    /// Returns the intrinsic width of the image, in CSS pixels.
    ///
    /// <see href="https://developer.mozilla.org/docs/Web/API/ImageBitmap/width">MDN Reference</see>
    /// </summary>
    abstract width: float
    /// <summary>
    /// Releases imageBitmap's underlying bitmap data.
    ///
    /// <see href="https://developer.mozilla.org/docs/Web/API/ImageBitmap/close">MDN Reference</see>
    /// </summary>
    abstract close: unit -> unit
