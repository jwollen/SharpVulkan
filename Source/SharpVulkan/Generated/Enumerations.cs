using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpVulkan
{
    public enum PipelineCacheHeaderVersion : int
    {
        One = 1,
    }

    public enum Result : int
    {
        Success = 0,

        NotReady = 1,

        Timeout = 2,

        EventSet = 3,

        EventReset = 4,

        Incomplete = 5,

        ErrorOutOfHostMemory = -1,

        ErrorOutOfDeviceMemory = -2,

        ErrorInitializationFailed = -3,

        ErrorDeviceLost = -4,

        ErrorMemoryMapFailed = -5,

        ErrorLayerNotPresent = -6,

        ErrorExtensionNotPresent = -7,

        ErrorFeatureNotPresent = -8,

        ErrorIncompatibleDriver = -9,

        ErrorTooManyObjects = -10,

        ErrorFormatNotSupported = -11,

        ErrorFragmentedPool = -12,

        ErrorSurfaceLost = -1000000000,

        ErrorNativeWindowInUse = -1000000001,

        Suboptimal = 1000001003,

        ErrorOutOfDate = -1000001004,

        ErrorIncompatibleDisplay = -1000003001,

        ErrorValidationFailed = -1000011001,

        ErrorInvalidShader = -1000012000,

        ErrorOutOfPoolMemory = -1000069000,
    }

    public enum StructureType : int
    {
        ApplicationInfo = 0,

        InstanceCreateInfo = 1,

        DeviceQueueCreateInfo = 2,

        DeviceCreateInfo = 3,

        SubmitInfo = 4,

        MemoryAllocateInfo = 5,

        MappedMemoryRange = 6,

        BindSparseInfo = 7,

        FenceCreateInfo = 8,

        SemaphoreCreateInfo = 9,

        EventCreateInfo = 10,

        QueryPoolCreateInfo = 11,

        BufferCreateInfo = 12,

        BufferViewCreateInfo = 13,

        ImageCreateInfo = 14,

        ImageViewCreateInfo = 15,

        ShaderModuleCreateInfo = 16,

        PipelineCacheCreateInfo = 17,

        PipelineShaderStageCreateInfo = 18,

        PipelineVertexInputStateCreateInfo = 19,

        PipelineInputAssemblyStateCreateInfo = 20,

        PipelineTessellationStateCreateInfo = 21,

        PipelineViewportStateCreateInfo = 22,

        PipelineRasterizationStateCreateInfo = 23,

        PipelineMultisampleStateCreateInfo = 24,

        PipelineDepthStencilStateCreateInfo = 25,

        PipelineColorBlendStateCreateInfo = 26,

        PipelineDynamicStateCreateInfo = 27,

        GraphicsPipelineCreateInfo = 28,

        ComputePipelineCreateInfo = 29,

        PipelineLayoutCreateInfo = 30,

        SamplerCreateInfo = 31,

        DescriptorSetLayoutCreateInfo = 32,

        DescriptorPoolCreateInfo = 33,

        DescriptorSetAllocateInfo = 34,

        WriteDescriptorSet = 35,

        CopyDescriptorSet = 36,

        FramebufferCreateInfo = 37,

        RenderPassCreateInfo = 38,

        CommandPoolCreateInfo = 39,

        CommandBufferAllocateInfo = 40,

        CommandBufferInheritanceInfo = 41,

        CommandBufferBeginInfo = 42,

        RenderPassBeginInfo = 43,

        BufferMemoryBarrier = 44,

        ImageMemoryBarrier = 45,

        MemoryBarrier = 46,

        LoaderInstanceCreateInfo = 47,

        LoaderDeviceCreateInfo = 48,

        SwapchainCreateInfo = 1000001000,

        PresentInfo = 1000001001,

        DisplayModeCreateInfo = 1000002000,

        DisplaySurfaceCreateInfo = 1000002001,

        DisplayPresentInfo = 1000003000,

        XlibSurfaceCreateInfo = 1000004000,

        XcbSurfaceCreateInfo = 1000005000,

        WaylandSurfaceCreateInfo = 1000006000,

        MirSurfaceCreateInfo = 1000007000,

        AndroidSurfaceCreateInfo = 1000008000,

        Win32SurfaceCreateInfo = 1000009000,

        DebugReportCallbackCreateInfo = 1000011000,

        PipelineRasterizationStateRasterizationOrder = 1000018000,

        DebugMarkerObjectNameInfo = 1000022000,

        DebugMarkerObjectTagInfo = 1000022001,

        DebugMarkerMarkerInfo = 1000022002,

        DedicatedAllocationImageCreateInfo = 1000026000,

        DedicatedAllocationBufferCreateInfo = 1000026001,

        DedicatedAllocationMemoryAllocateInfo = 1000026002,

        ExternalMemoryImageCreateInfo = 1000056000,

        ExportMemoryAllocateInfo = 1000056001,

        ImportMemoryWin32HandleInfo = 1000057000,

        ExportMemoryWin32HandleInfo = 1000057001,

        Win32KeyedMutexAcquireReleaseInfo = 1000058000,

        PhysicalDeviceFeatures2 = 1000059000,

        PhysicalDeviceProperties2 = 1000059001,

        FormatProperties2 = 1000059002,

        ImageFormatProperties2 = 1000059003,

        PhysicalDeviceImageFormatInfo2 = 1000059004,

        QueueFamilyProperties2 = 1000059005,

        PhysicalDeviceMemoryProperties2 = 1000059006,

        SparseImageFormatProperties2 = 1000059007,

        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,

        ValidationFlags = 1000061000,

        ViSurfaceCreateInfoNn = 1000062000,

        ObjectTableCreateInfo = 1000086000,

        IndirectCommandsLayoutCreateInfo = 1000086001,

        CommandProcessCommandsInfo = 1000086002,

        CommandReserveSpaceForCommandsInfo = 1000086003,

        DeviceGeneratedCommandsLimits = 1000086004,

        DeviceGeneratedCommandsFeatures = 1000086005,

        SurfaceCapabilities2 = 1000090000,

        DisplayPowerInfo = 1000091000,

        DeviceEventInfo = 1000091001,

        DisplayEventInfo = 1000091002,

        SwapchainCounterCreateInfo = 1000091003,
    }

    public enum SystemAllocationScope : int
    {
        Command = 0,

        Object = 1,

        Cache = 2,

        Device = 3,

        Instance = 4,
    }

    public enum InternalAllocationType : int
    {
        Executable = 0,
    }

    public enum Format : int
    {
        Undefined = 0,

        R4G4UNormPack8 = 1,

        R4G4B4A4UNormPack16 = 2,

        B4G4R4A4UNormPack16 = 3,

        R5G6B5UNormPack16 = 4,

        B5G6R5UNormPack16 = 5,

        R5G5B5A1UNormPack16 = 6,

        B5G5R5A1UNormPack16 = 7,

        A1R5G5B5UNormPack16 = 8,

        R8UNorm = 9,

        R8SNorm = 10,

        R8UScaled = 11,

        R8Sscaled = 12,

        R8UInt = 13,

        R8SInt = 14,

        R8SRgb = 15,

        R8G8UNorm = 16,

        R8G8SNorm = 17,

        R8G8UScaled = 18,

        R8G8Sscaled = 19,

        R8G8UInt = 20,

        R8G8SInt = 21,

        R8G8SRgb = 22,

        R8G8B8UNorm = 23,

        R8G8B8SNorm = 24,

        R8G8B8UScaled = 25,

        R8G8B8Sscaled = 26,

        R8G8B8UInt = 27,

        R8G8B8SInt = 28,

        R8G8B8SRgb = 29,

        B8G8R8UNorm = 30,

        B8G8R8SNorm = 31,

        B8G8R8UScaled = 32,

        B8G8R8Sscaled = 33,

        B8G8R8UInt = 34,

        B8G8R8SInt = 35,

        B8G8R8SRgb = 36,

        R8G8B8A8UNorm = 37,

        R8G8B8A8SNorm = 38,

        R8G8B8A8UScaled = 39,

        R8G8B8A8Sscaled = 40,

        R8G8B8A8UInt = 41,

        R8G8B8A8SInt = 42,

        R8G8B8A8SRgb = 43,

        B8G8R8A8UNorm = 44,

        B8G8R8A8SNorm = 45,

        B8G8R8A8UScaled = 46,

        B8G8R8A8Sscaled = 47,

        B8G8R8A8UInt = 48,

        B8G8R8A8SInt = 49,

        B8G8R8A8SRgb = 50,

        A8B8G8R8UNormPack32 = 51,

        A8B8G8R8SNormPack32 = 52,

        A8B8G8R8UScaledPack32 = 53,

        A8B8G8R8SscaledPack32 = 54,

        A8B8G8R8UIntPack32 = 55,

        A8B8G8R8SIntPack32 = 56,

        A8B8G8R8SRgbPack32 = 57,

        A2R10G10B10UNormPack32 = 58,

        A2R10G10B10SNormPack32 = 59,

        A2R10G10B10UScaledPack32 = 60,

        A2R10G10B10SscaledPack32 = 61,

        A2R10G10B10UIntPack32 = 62,

        A2R10G10B10SIntPack32 = 63,

        A2B10G10R10UNormPack32 = 64,

        A2B10G10R10SNormPack32 = 65,

        A2B10G10R10UScaledPack32 = 66,

        A2B10G10R10SscaledPack32 = 67,

        A2B10G10R10UIntPack32 = 68,

        A2B10G10R10SIntPack32 = 69,

        R16UNorm = 70,

        R16SNorm = 71,

        R16UScaled = 72,

        R16Sscaled = 73,

        R16UInt = 74,

        R16SInt = 75,

        R16SFloat = 76,

        R16G16UNorm = 77,

        R16G16SNorm = 78,

        R16G16UScaled = 79,

        R16G16Sscaled = 80,

        R16G16UInt = 81,

        R16G16SInt = 82,

        R16G16SFloat = 83,

        R16G16B16UNorm = 84,

        R16G16B16SNorm = 85,

        R16G16B16UScaled = 86,

        R16G16B16Sscaled = 87,

        R16G16B16UInt = 88,

        R16G16B16SInt = 89,

        R16G16B16SFloat = 90,

        R16G16B16A16UNorm = 91,

        R16G16B16A16SNorm = 92,

        R16G16B16A16UScaled = 93,

        R16G16B16A16Sscaled = 94,

        R16G16B16A16UInt = 95,

        R16G16B16A16SInt = 96,

        R16G16B16A16SFloat = 97,

        R32UInt = 98,

        R32SInt = 99,

        R32SFloat = 100,

        R32G32UInt = 101,

        R32G32SInt = 102,

        R32G32SFloat = 103,

        R32G32B32UInt = 104,

        R32G32B32SInt = 105,

        R32G32B32SFloat = 106,

        R32G32B32A32UInt = 107,

        R32G32B32A32SInt = 108,

        R32G32B32A32SFloat = 109,

        R64UInt = 110,

        R64SInt = 111,

        R64SFloat = 112,

        R64G64UInt = 113,

        R64G64SInt = 114,

        R64G64SFloat = 115,

        R64G64B64UInt = 116,

        R64G64B64SInt = 117,

        R64G64B64SFloat = 118,

        R64G64B64A64UInt = 119,

        R64G64B64A64SInt = 120,

        R64G64B64A64SFloat = 121,

        B10G11R11UFloatPack32 = 122,

        E5B9G9R9UFloatPack32 = 123,

        D16UNorm = 124,

        X8D24UNormPack32 = 125,

        D32SFloat = 126,

        S8UInt = 127,

        D16UNormS8UInt = 128,

        D24UNormS8UInt = 129,

        D32SFloatS8UInt = 130,

        Bc1RgbUNormBlock = 131,

        Bc1RgbSRgbBlock = 132,

        Bc1RgbaUNormBlock = 133,

        Bc1RgbaSRgbBlock = 134,

        Bc2UNormBlock = 135,

        Bc2SRgbBlock = 136,

        Bc3UNormBlock = 137,

        Bc3SRgbBlock = 138,

        Bc4UNormBlock = 139,

        Bc4SNormBlock = 140,

        Bc5UNormBlock = 141,

        Bc5SNormBlock = 142,

        Bc6HUFloatBlock = 143,

        Bc6HSFloatBlock = 144,

        Bc7UNormBlock = 145,

        Bc7SRgbBlock = 146,

        Etc2R8G8B8UNormBlock = 147,

        Etc2R8G8B8SRgbBlock = 148,

        Etc2R8G8B8A1UNormBlock = 149,

        Etc2R8G8B8A1SRgbBlock = 150,

        Etc2R8G8B8A8UNormBlock = 151,

        Etc2R8G8B8A8SRgbBlock = 152,

        EacR11UNormBlock = 153,

        EacR11SNormBlock = 154,

        EacR11G11UNormBlock = 155,

        EacR11G11SNormBlock = 156,

        Astc4X4UNormBlock = 157,

        Astc4X4SRgbBlock = 158,

        Astc5X4UNormBlock = 159,

        Astc5X4SRgbBlock = 160,

        Astc5X5UNormBlock = 161,

        Astc5X5SRgbBlock = 162,

        Astc6X5UNormBlock = 163,

        Astc6X5SRgbBlock = 164,

        Astc6X6UNormBlock = 165,

        Astc6X6SRgbBlock = 166,

        Astc8X5UNormBlock = 167,

        Astc8X5SRgbBlock = 168,

        Astc8X6UNormBlock = 169,

        Astc8X6SRgbBlock = 170,

        Astc8X8UNormBlock = 171,

        Astc8X8SRgbBlock = 172,

        Astc10X5UNormBlock = 173,

        Astc10X5SRgbBlock = 174,

        Astc10X6UNormBlock = 175,

        Astc10X6SRgbBlock = 176,

        Astc10X8UNormBlock = 177,

        Astc10X8SRgbBlock = 178,

        Astc10X10UNormBlock = 179,

        Astc10X10SRgbBlock = 180,

        Astc12X10UNormBlock = 181,

        Astc12X10SRgbBlock = 182,

        Astc12X12UNormBlock = 183,

        Astc12X12SRgbBlock = 184,

        Pvrtc12BppUNormBlock = 1000054000,

        Pvrtc14BppUNormBlock = 1000054001,

        Pvrtc22BppUNormBlock = 1000054002,

        Pvrtc24BppUNormBlock = 1000054003,

        Pvrtc12BppSRgbBlock = 1000054004,

        Pvrtc14BppSRgbBlock = 1000054005,

        Pvrtc22BppSRgbBlock = 1000054006,

        Pvrtc24BppSRgbBlock = 1000054007,
    }

    public enum ImageType : int
    {
        Image1D = 0,

        Image2D = 1,

        Image3D = 2,
    }

    public enum ImageTiling : int
    {
        Optimal = 0,

        Linear = 1,
    }

    public enum PhysicalDeviceType : int
    {
        Other = 0,

        IntegratedGpu = 1,

        DiscreteGpu = 2,

        VirtualGpu = 3,

        Cpu = 4,
    }

    public enum QueryType : int
    {
        Occlusion = 0,

        PipelineStatistics = 1,

        Timestamp = 2,
    }

    public enum SharingMode : int
    {
        Exclusive = 0,

        Concurrent = 1,
    }

    public enum ImageLayout : int
    {
        Undefined = 0,

        General = 1,

        ColorAttachmentOptimal = 2,

        DepthStencilAttachmentOptimal = 3,

        DepthStencilReadOnlyOptimal = 4,

        ShaderReadOnlyOptimal = 5,

        TransferSourceOptimal = 6,

        TransferDestinationOptimal = 7,

        Preinitialized = 8,

        PresentSource = 1000001002,
    }

    public enum ImageViewType : int
    {
        Image1D = 0,

        Image2D = 1,

        Image3D = 2,

        ImageCube = 3,

        Image1DArray = 4,

        Image2DArray = 5,

        ImageCubeArray = 6,
    }

    public enum ComponentSwizzle : int
    {
        Identity = 0,

        Zero = 1,

        One = 2,

        R = 3,

        G = 4,

        B = 5,

        A = 6,
    }

    public enum VertexInputRate : int
    {
        Vertex = 0,

        Instance = 1,
    }

    public enum PrimitiveTopology : int
    {
        PointList = 0,

        LineList = 1,

        LineStrip = 2,

        TriangleList = 3,

        TriangleStrip = 4,

        TriangleFan = 5,

        LineListWithAdjacency = 6,

        LineStripWithAdjacency = 7,

        TriangleListWithAdjacency = 8,

        TriangleStripWithAdjacency = 9,

        PatchList = 10,
    }

    public enum PolygonMode : int
    {
        Fill = 0,

        Line = 1,

        Point = 2,
    }

    public enum FrontFace : int
    {
        CounterClockwise = 0,

        Clockwise = 1,
    }

    public enum CompareOperation : int
    {
        Never = 0,

        Less = 1,

        Equal = 2,

        LessOrEqual = 3,

        Greater = 4,

        NotEqual = 5,

        GreaterOrEqual = 6,

        Always = 7,
    }

    public enum StencilOperation : int
    {
        Keep = 0,

        Zero = 1,

        Replace = 2,

        IncrementAndClamp = 3,

        DecrementAndClamp = 4,

        Invert = 5,

        IncrementAndWrap = 6,

        DecrementAndWrap = 7,
    }

    public enum LogicOperation : int
    {
        Clear = 0,

        And = 1,

        AndReverse = 2,

        Copy = 3,

        AndInverted = 4,

        NoOp = 5,

        Xor = 6,

        Or = 7,

        Nor = 8,

        Equivalent = 9,

        Invert = 10,

        OrReverse = 11,

        CopyInverted = 12,

        OrInverted = 13,

        Nand = 14,

        Set = 15,
    }

    public enum BlendFactor : int
    {
        Zero = 0,

        One = 1,

        SourceColor = 2,

        OneMinusSourceColor = 3,

        DestinationColor = 4,

        OneMinusDestinationColor = 5,

        SourceAlpha = 6,

        OneMinusSourceAlpha = 7,

        DestinationAlpha = 8,

        OneMinusDestinationAlpha = 9,

        ConstantColor = 10,

        OneMinusConstantColor = 11,

        ConstantAlpha = 12,

        OneMinusConstantAlpha = 13,

        SourceAlphaSaturate = 14,

        Source1Color = 15,

        OneMinusSource1Color = 16,

        Source1Alpha = 17,

        OneMinusSource1Alpha = 18,
    }

    public enum BlendOperation : int
    {
        Add = 0,

        Subtract = 1,

        ReverseSubtract = 2,

        Min = 3,

        Max = 4,
    }

    public enum DynamicState : int
    {
        Viewport = 0,

        Scissor = 1,

        LineWidth = 2,

        DepthBias = 3,

        BlendConstants = 4,

        DepthBounds = 5,

        StencilCompareMask = 6,

        StencilWriteMask = 7,

        StencilReference = 8,
    }

    public enum Filter : int
    {
        Nearest = 0,

        Linear = 1,

        Cubic = 1000015000,
    }

    public enum SamplerMipmapMode : int
    {
        Nearest = 0,

        Linear = 1,
    }

    public enum SamplerAddressMode : int
    {
        Repeat = 0,

        MirroredRepeat = 1,

        ClampToEdge = 2,

        ClampToBorder = 3,

        MirrorClampToEdge = 4,
    }

    public enum BorderColor : int
    {
        FloatTransparentBlack = 0,

        IntTransparentBlack = 1,

        FloatOpaqueBlack = 2,

        IntOpaqueBlack = 3,

        FloatOpaqueWhite = 4,

        IntOpaqueWhite = 5,
    }

    public enum DescriptorType : int
    {
        Sampler = 0,

        CombinedImageSampler = 1,

        SampledImage = 2,

        StorageImage = 3,

        UniformTexelBuffer = 4,

        StorageTexelBuffer = 5,

        UniformBuffer = 6,

        StorageBuffer = 7,

        UniformBufferDynamic = 8,

        StorageBufferDynamic = 9,

        InputAttachment = 10,
    }

    public enum AttachmentLoadOperation : int
    {
        Load = 0,

        Clear = 1,

        DontCare = 2,
    }

    public enum AttachmentStoreOperation : int
    {
        Store = 0,

        DontCare = 1,
    }

    public enum PipelineBindPoint : int
    {
        Graphics = 0,

        Compute = 1,
    }

    public enum CommandBufferLevel : int
    {
        Primary = 0,

        Secondary = 1,
    }

    public enum IndexType : int
    {
        UInt16 = 0,

        UInt32 = 1,
    }

    public enum SubpassContents : int
    {
        Inline = 0,

        SecondaryCommandBuffers = 1,
    }

    [Flags]
    public enum InstanceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum FormatFeatureFlags : int
    {
        None = 0,

        SampledImage = 1,

        StorageImage = 2,

        StorageImageAtomic = 4,

        UniformTexelBuffer = 8,

        StorageTexelBuffer = 16,

        StorageTexelBufferAtomic = 32,

        VertexBuffer = 64,

        ColorAttachment = 128,

        ColorAttachmentBlend = 256,

        DepthStencilAttachment = 512,

        BlitSource = 1024,

        BlitDestination = 2048,

        SampledImageFilterLinear = 4096,

        SampledImageFilterCubic = 8192,

        TransferSource = 16384,

        TransferDestination = 32768,
    }

    [Flags]
    public enum ImageUsageFlags : int
    {
        None = 0,

        TransferSource = 1,

        TransferDestination = 2,

        Sampled = 4,

        Storage = 8,

        ColorAttachment = 16,

        DepthStencilAttachment = 32,

        TransientAttachment = 64,

        InputAttachment = 128,
    }

    [Flags]
    public enum ImageCreateFlags : int
    {
        None = 0,

        SparseBinding = 1,

        SparseResidency = 2,

        SparseAliased = 4,

        MutableFormat = 8,

        CubeCompatible = 16,

        Image2DArrayCompatible = 32,
    }

    [Flags]
    public enum SampleCountFlags : int
    {
        None = 0,

        Sample1 = 1,

        Sample2 = 2,

        Sample4 = 4,

        Sample8 = 8,

        Sample16 = 16,

        Sample32 = 32,

        Sample64 = 64,
    }

    [Flags]
    public enum QueueFlags : int
    {
        None = 0,

        Graphics = 1,

        Compute = 2,

        Transfer = 4,

        SparseBinding = 8,
    }

    [Flags]
    public enum MemoryPropertyFlags : int
    {
        None = 0,

        DeviceLocal = 1,

        HostVisible = 2,

        HostCoherent = 4,

        HostCached = 8,

        LazilyAllocated = 16,
    }

    [Flags]
    public enum MemoryHeapFlags : int
    {
        None = 0,

        DeviceLocal = 1,
    }

    [Flags]
    public enum DeviceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum DeviceQueueCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineStageFlags : int
    {
        None = 0,

        TopOfPipe = 1,

        DrawIndirect = 2,

        VertexInput = 4,

        VertexShader = 8,

        TessellationControlShader = 16,

        TessellationEvaluationShader = 32,

        GeometryShader = 64,

        FragmentShader = 128,

        EarlyFragmentTests = 256,

        LateFragmentTests = 512,

        ColorAttachmentOutput = 1024,

        ComputeShader = 2048,

        Transfer = 4096,

        BottomOfPipe = 8192,

        Host = 16384,

        AllGraphics = 32768,

        AllCommands = 65536,

        CommandProcess = 131072,
    }

    [Flags]
    public enum MemoryMapFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum ImageAspectFlags : int
    {
        None = 0,

        Color = 1,

        Depth = 2,

        Stencil = 4,

        Metadata = 8,
    }

    [Flags]
    public enum SparseImageFormatFlags : int
    {
        None = 0,

        SingleMiptail = 1,

        AlignedMipSize = 2,

        NonstandardBlockSize = 4,
    }

    [Flags]
    public enum SparseMemoryBindFlags : int
    {
        None = 0,

        Metadata = 1,
    }

    [Flags]
    public enum FenceCreateFlags : int
    {
        None = 0,

        Signaled = 1,
    }

    [Flags]
    public enum SemaphoreCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum EventCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum QueryPoolCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum QueryPipelineStatisticFlags : int
    {
        None = 0,

        InputAssemblyVertices = 1,

        InputAssemblyPrimitives = 2,

        VertexShaderInvocations = 4,

        GeometryShaderInvocations = 8,

        GeometryShaderPrimitives = 16,

        ClippingInvocations = 32,

        ClippingPrimitives = 64,

        FragmentShaderInvocations = 128,

        TessellationControlShaderPatches = 256,

        TessellationEvaluationShaderInvocations = 512,

        ComputeShaderInvocations = 1024,
    }

    [Flags]
    public enum QueryResultFlags : int
    {
        None = 0,

        Is64Bits = 1,

        Wait = 2,

        WithAvailability = 4,

        Partial = 8,
    }

    [Flags]
    public enum BufferCreateFlags : int
    {
        None = 0,

        SparseBinding = 1,

        SparseResidency = 2,

        SparseAliased = 4,
    }

    [Flags]
    public enum BufferUsageFlags : int
    {
        None = 0,

        TransferSource = 1,

        TransferDestination = 2,

        UniformTexelBuffer = 4,

        StorageTexelBuffer = 8,

        UniformBuffer = 16,

        StorageBuffer = 32,

        IndexBuffer = 64,

        VertexBuffer = 128,

        IndirectBuffer = 256,
    }

    [Flags]
    public enum BufferViewCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum ImageViewCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum ShaderModuleCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineCacheCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineCreateFlags : int
    {
        None = 0,

        DisableOptimization = 1,

        AllowDerivatives = 2,

        Derivative = 4,
    }

    [Flags]
    public enum PipelineShaderStageCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum ShaderStageFlags : int
    {
        None = 0,

        Vertex = 1,

        TessellationControl = 2,

        TessellationEvaluation = 4,

        Geometry = 8,

        Fragment = 16,

        Compute = 32,

        AllGraphics = 31,

        All = 2147483647,
    }

    [Flags]
    public enum PipelineVertexInputStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineInputAssemblyStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineTessellationStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineViewportStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineRasterizationStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum CullModeFlags : int
    {
        None = 0,

        Front = 1,

        Back = 2,

        FrontAndBack = 3,
    }

    [Flags]
    public enum PipelineMultisampleStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineDepthStencilStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineColorBlendStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum ColorComponentFlags : int
    {
        None = 0,

        R = 1,

        G = 2,

        B = 4,

        A = 8,
    }

    [Flags]
    public enum PipelineDynamicStateCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum PipelineLayoutCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum SamplerCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum DescriptorSetLayoutCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum DescriptorPoolCreateFlags : int
    {
        None = 0,

        FreeDescriptorSet = 1,
    }

    [Flags]
    public enum DescriptorPoolResetFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum FramebufferCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum RenderPassCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum AttachmentDescriptionFlags : int
    {
        None = 0,

        MayAlias = 1,
    }

    [Flags]
    public enum SubpassDescriptionFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum AccessFlags : int
    {
        None = 0,

        IndirectCommandRead = 1,

        IndexRead = 2,

        VertexAttributeRead = 4,

        UniformRead = 8,

        InputAttachmentRead = 16,

        ShaderRead = 32,

        ShaderWrite = 64,

        ColorAttachmentRead = 128,

        ColorAttachmentWrite = 256,

        DepthStencilAttachmentRead = 512,

        DepthStencilAttachmentWrite = 1024,

        TransferRead = 2048,

        TransferWrite = 4096,

        HostRead = 8192,

        HostWrite = 16384,

        MemoryRead = 32768,

        MemoryWrite = 65536,

        CommandProcessRead = 131072,

        CommandProcessWrite = 262144,
    }

    [Flags]
    public enum DependencyFlags : int
    {
        None = 0,

        ByRegion = 1,
    }

    [Flags]
    public enum CommandPoolCreateFlags : int
    {
        None = 0,

        Transient = 1,

        ResetCommandBuffer = 2,
    }

    [Flags]
    public enum CommandPoolResetFlags : int
    {
        None = 0,

        ReleseResources = 1,
    }

    [Flags]
    public enum CommandBufferUsageFlags : int
    {
        None = 0,

        OneTimeSubmit = 1,

        RenderPassContinue = 2,

        SimultaneousUse = 4,
    }

    [Flags]
    public enum QueryControlFlags : int
    {
        None = 0,

        Precise = 1,
    }

    [Flags]
    public enum CommandBufferResetFlags : int
    {
        None = 0,

        ReleaseResources = 1,
    }

    [Flags]
    public enum StencilFaceFlags : int
    {
        None = 0,

        FaceFront = 1,

        FaceBack = 2,

        FrontAndBack = 3,
    }

    public enum ColorSpace : int
    {
        SRgbNonlinear = 0,

        DisplayP3Linear = 1000104001,

        DisplayP3Nonlinear = 1000104002,

        ScRgbLinear = 1000104003,

        ScRgbNonlinear = 1000104004,

        DciP3Linear = 1000104005,

        DciP3Nonlinear = 1000104006,

        Bt709Linear = 1000104007,

        Bt709Nonlinear = 1000104008,

        Bt2020Linear = 1000104009,

        Bt2020Nonlinear = 1000104010,

        AdobeRgbLinear = 1000104011,

        AdobeRgbNonlinear = 1000104012,
    }

    public enum PresentMode : int
    {
        Immediate = 0,

        Mailbox = 1,

        Fifo = 2,

        FifoRelaxed = 3,
    }

    [Flags]
    public enum SurfaceTransformFlags : int
    {
        None = 0,

        Identity = 1,

        Rotate90 = 2,

        Rotate180 = 4,

        Rotate270 = 8,

        HorizontalMirror = 16,

        HorizontalMirrorRotate90 = 32,

        HorizontalMirrorRotate180 = 64,

        HorizontalMirrorRotate270 = 128,

        Inherit = 256,
    }

    [Flags]
    public enum CompositeAlphaFlags : int
    {
        None = 0,

        Opaque = 1,

        PreMultiplied = 2,

        PostMultiplied = 4,

        Inherit = 8,
    }

    [Flags]
    public enum SwapchainCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum DisplayPlaneAlphaFlags : int
    {
        None = 0,

        Opaque = 1,

        Global = 2,

        PerPixel = 4,

        PerPixelPremultiplied = 8,
    }

    [Flags]
    public enum DisplayModeCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum DisplaySurfaceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum XlibSurfaceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum XcbSurfaceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum AndroidSurfaceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum Win32SurfaceCreateFlags : int
    {
        None = 0,
    }

    [Flags]
    public enum CommandPoolTrimFlags : int
    {
        None = 0,
    }

    public enum DebugReportObjectType : int
    {
        Unknown = 0,

        Instance = 1,

        PhysicalDevice = 2,

        Device = 3,

        Queue = 4,

        Semaphore = 5,

        CommandBuffer = 6,

        Fence = 7,

        DeviceMemory = 8,

        Buffer = 9,

        Image = 10,

        Event = 11,

        QueryPool = 12,

        BufferView = 13,

        ImageView = 14,

        ShaderModule = 15,

        PipelineCache = 16,

        PipelineLayout = 17,

        RenderPass = 18,

        Pipeline = 19,

        DescriptorSetLayout = 20,

        Sampler = 21,

        DescriptorPool = 22,

        DescriptorSet = 23,

        Framebuffer = 24,

        CommandPool = 25,

        Surface = 26,

        Swapchain = 27,

        DebugReport = 28,

        Display = 29,

        DisplayMode = 30,

        ObjectTable = 31,

        IndirectCommandsLayout = 32,
    }

    public enum DebugReportError : int
    {
        None = 0,

        CallbackRef = 1,
    }

    [Flags]
    public enum DebugReportFlags : int
    {
        None = 0,

        Information = 1,

        Warning = 2,

        PerformanceWarning = 4,

        Error = 8,

        Debug = 16,
    }

    public enum RasterizationOrder : int
    {
        Strict = 0,

        Relaxed = 1,
    }

    [Flags]
    public enum ExternalMemoryHandleTypeFlags : int
    {
        None = 0,

        OpaqueWin32 = 1,

        OpaqueWin32Kmt = 2,

        D3D11Image = 4,

        D3D11ImageKmt = 8,
    }

    [Flags]
    public enum ExternalMemoryFeatureFlags : int
    {
        None = 0,

        DedicatedOnly = 1,

        Exportable = 2,

        Importable = 4,
    }

    public enum ValidationCheck : int
    {
        All = 0,
    }

    public enum IndirectCommandsTokenType : int
    {
        Pipeline = 0,

        DescriptorSet = 1,

        IndexBuffer = 2,

        VertexBuffer = 3,

        PushConstant = 4,

        DrawIndexed = 5,

        Draw = 6,

        Dispatch = 7,
    }

    public enum ObjectEntryType : int
    {
        DescriptorSet = 0,

        Pipeline = 1,

        IndexBuffer = 2,

        VertexBuffer = 3,

        PushConstant = 4,
    }

    [Flags]
    public enum IndirectCommandsLayoutUsageFlags : int
    {
        None = 0,

        UnorderedSequences = 1,

        SparseSequences = 2,

        EmptyExecutions = 4,

        IndexedSequences = 8,
    }

    [Flags]
    public enum ObjectEntryUsageFlags : int
    {
        None = 0,

        Graphics = 1,

        Compute = 2,
    }

    [Flags]
    public enum SurfaceCounterFlags : int
    {
        None = 0,

        VerticalBlank = 1,
    }

    public enum DisplayPowerState : int
    {
        Off = 0,

        Suspend = 1,

        On = 2,
    }

    public enum DeviceEventType : int
    {
        DisplayHotplug = 0,
    }

    public enum DisplayEventType : int
    {
        FirstPixelOut = 0,
    }
}
