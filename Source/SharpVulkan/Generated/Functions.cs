using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpVulkan
{
    public static partial class Vulkan
    {
        internal const string LibraryName = "vulkan-1.dll";

        public static unsafe Instance CreateInstance(ref InstanceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Instance instance;
            fixed (InstanceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateInstance(__createInfo__, allocator, &instance).CheckError();
            }
            return instance;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateInstance(InstanceCreateInfo* createInfo, AllocationCallbacks* allocator, Instance* instance);

        internal static unsafe void EnumerateInstanceExtensionProperties(byte* layerName, ref uint propertyCount, ExtensionProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkEnumerateInstanceExtensionProperties(layerName, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEnumerateInstanceExtensionProperties(byte* layerName, uint* propertyCount, ExtensionProperties* properties);

        internal static unsafe void EnumerateInstanceLayerProperties(ref uint propertyCount, LayerProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkEnumerateInstanceLayerProperties(__propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEnumerateInstanceLayerProperties(uint* propertyCount, LayerProperties* properties);
    }

    public partial struct Instance
    {
        public unsafe void Destroy(AllocationCallbacks* allocator = null)
        {
            vkDestroyInstance(this, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyInstance(Instance instance, AllocationCallbacks* allocator);

        internal unsafe void EnumeratePhysicalDevices(ref uint physicalDeviceCount, PhysicalDevice* physicalDevices)
        {
            fixed (uint* __physicalDeviceCount__ = &physicalDeviceCount)
            {
                vkEnumeratePhysicalDevices(this, __physicalDeviceCount__, physicalDevices).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEnumeratePhysicalDevices(Instance instance, uint* physicalDeviceCount, PhysicalDevice* physicalDevices);

        public unsafe IntPtr GetProcAddress(byte* name)
        {
            IntPtr __result__;
            __result__ = vkGetInstanceProcAddr(this, name);
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe IntPtr vkGetInstanceProcAddr(Instance instance, byte* name);

        public unsafe void DestroySurface(Surface surface, AllocationCallbacks* allocator = null)
        {
            vkDestroySurfaceKHR(this, surface, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroySurfaceKHR(Instance instance, Surface surface, AllocationCallbacks* allocator);

        public unsafe Surface CreateDisplayPlaneSurface(ref DisplaySurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            fixed (DisplaySurfaceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDisplayPlaneSurfaceKHR(this, __createInfo__, allocator, &surface).CheckError();
            }
            return surface;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDisplayPlaneSurfaceKHR(Instance instance, DisplaySurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe Surface CreateXlibSurface(ref XlibSurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            fixed (XlibSurfaceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateXlibSurfaceKHR(this, __createInfo__, allocator, &surface).CheckError();
            }
            return surface;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateXlibSurfaceKHR(Instance instance, XlibSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe Surface CreateXcbSurface(ref XcbSurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            fixed (XcbSurfaceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateXcbSurfaceKHR(this, __createInfo__, allocator, &surface).CheckError();
            }
            return surface;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateXcbSurfaceKHR(Instance instance, XcbSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe Surface CreateAndroidSurface(ref AndroidSurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            fixed (AndroidSurfaceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateAndroidSurfaceKHR(this, __createInfo__, allocator, &surface).CheckError();
            }
            return surface;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateAndroidSurfaceKHR(Instance instance, AndroidSurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe Surface CreateWin32Surface(Win32SurfaceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Surface surface;
            vkCreateWin32SurfaceKHR(this, &createInfo, allocator, &surface).CheckError();
            return surface;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateWin32SurfaceKHR(Instance instance, Win32SurfaceCreateInfo* createInfo, AllocationCallbacks* allocator, Surface* surface);

        public unsafe DebugReportCallback CreateDebugReportCallback(ref DebugReportCallbackCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DebugReportCallback callback;
            fixed (DebugReportCallbackCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDebugReportCallbackEXT(this, __createInfo__, allocator, &callback).CheckError();
            }
            return callback;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDebugReportCallbackEXT(Instance instance, DebugReportCallbackCreateInfo* createInfo, AllocationCallbacks* allocator, DebugReportCallback* callback);

        public unsafe void DestroyDebugReportCallback(DebugReportCallback callback, AllocationCallbacks* allocator = null)
        {
            vkDestroyDebugReportCallbackEXT(this, callback, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyDebugReportCallbackEXT(Instance instance, DebugReportCallback callback, AllocationCallbacks* allocator);

        internal unsafe void DebugReportMessage(uint flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, ref byte layerPrefix, byte* message)
        {
            fixed (byte* __layerPrefix__ = &layerPrefix)
            {
                vkDebugReportMessageEXT(this, flags, objectType, @object, location, messageCode, __layerPrefix__, message);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDebugReportMessageEXT(Instance instance, uint flags, DebugReportObjectType objectType, ulong @object, PointerSize location, int messageCode, byte* layerPrefix, byte* message);
    }

    public partial struct PhysicalDevice
    {
        public unsafe void GetFeatures(out PhysicalDeviceFeatures features)
        {
            fixed (PhysicalDeviceFeatures* __features__ = &features)
            {
                vkGetPhysicalDeviceFeatures(this, __features__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceFeatures(PhysicalDevice physicalDevice, PhysicalDeviceFeatures* features);

        public unsafe void GetFormatProperties(Format format, out FormatProperties formatProperties)
        {
            fixed (FormatProperties* __formatProperties__ = &formatProperties)
            {
                vkGetPhysicalDeviceFormatProperties(this, format, __formatProperties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceFormatProperties(PhysicalDevice physicalDevice, Format format, FormatProperties* formatProperties);

        public unsafe void GetImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, out ImageFormatProperties imageFormatProperties)
        {
            fixed (ImageFormatProperties* __imageFormatProperties__ = &imageFormatProperties)
            {
                vkGetPhysicalDeviceImageFormatProperties(this, format, type, tiling, usage, flags, __imageFormatProperties__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, ImageFormatProperties* imageFormatProperties);

        public unsafe void GetProperties(out PhysicalDeviceProperties properties)
        {
            fixed (PhysicalDeviceProperties* __properties__ = &properties)
            {
                vkGetPhysicalDeviceProperties(this, __properties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceProperties(PhysicalDevice physicalDevice, PhysicalDeviceProperties* properties);

        internal unsafe void GetQueueFamilyProperties(ref uint queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties)
        {
            fixed (uint* __queueFamilyPropertyCount__ = &queueFamilyPropertyCount)
            {
                vkGetPhysicalDeviceQueueFamilyProperties(this, __queueFamilyPropertyCount__, queueFamilyProperties);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceQueueFamilyProperties(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties* queueFamilyProperties);

        public unsafe void GetMemoryProperties(out PhysicalDeviceMemoryProperties memoryProperties)
        {
            fixed (PhysicalDeviceMemoryProperties* __memoryProperties__ = &memoryProperties)
            {
                vkGetPhysicalDeviceMemoryProperties(this, __memoryProperties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceMemoryProperties(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties* memoryProperties);

        public unsafe Device CreateDevice(ref DeviceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Device device;
            fixed (DeviceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDevice(this, __createInfo__, allocator, &device).CheckError();
            }
            return device;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDevice(PhysicalDevice physicalDevice, DeviceCreateInfo* createInfo, AllocationCallbacks* allocator, Device* device);

        internal unsafe void EnumerateDeviceExtensionProperties(byte* layerName, ref uint propertyCount, ExtensionProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkEnumerateDeviceExtensionProperties(this, layerName, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEnumerateDeviceExtensionProperties(PhysicalDevice physicalDevice, byte* layerName, uint* propertyCount, ExtensionProperties* properties);

        internal unsafe void EnumerateDeviceLayerProperties(ref uint propertyCount, LayerProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkEnumerateDeviceLayerProperties(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEnumerateDeviceLayerProperties(PhysicalDevice physicalDevice, uint* propertyCount, LayerProperties* properties);

        internal unsafe void GetSparseImageFormatProperties(Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, ref uint propertyCount, SparseImageFormatProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkGetPhysicalDeviceSparseImageFormatProperties(this, format, type, samples, usage, tiling, __propertyCount__, properties);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceSparseImageFormatProperties(PhysicalDevice physicalDevice, Format format, ImageType type, SampleCountFlags samples, ImageUsageFlags usage, ImageTiling tiling, uint* propertyCount, SparseImageFormatProperties* properties);

        public unsafe RawBool GetSurfaceSupport(uint queueFamilyIndex, Surface surface)
        {
            RawBool supported;
            vkGetPhysicalDeviceSurfaceSupportKHR(this, queueFamilyIndex, surface, &supported).CheckError();
            return supported;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceSurfaceSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, Surface surface, RawBool* supported);

        public unsafe void GetSurfaceCapabilities(Surface surface, out SurfaceCapabilities surfaceCapabilities)
        {
            fixed (SurfaceCapabilities* __surfaceCapabilities__ = &surfaceCapabilities)
            {
                vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this, surface, __surfaceCapabilities__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceSurfaceCapabilitiesKHR(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities* surfaceCapabilities);

        internal unsafe void GetSurfaceFormats(Surface surface, ref uint surfaceFormatCount, SurfaceFormat* surfaceFormats)
        {
            fixed (uint* __surfaceFormatCount__ = &surfaceFormatCount)
            {
                vkGetPhysicalDeviceSurfaceFormatsKHR(this, surface, __surfaceFormatCount__, surfaceFormats).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceSurfaceFormatsKHR(PhysicalDevice physicalDevice, Surface surface, uint* surfaceFormatCount, SurfaceFormat* surfaceFormats);

        internal unsafe void GetSurfacePresentModes(Surface surface, ref uint presentModeCount, PresentMode* presentModes)
        {
            fixed (uint* __presentModeCount__ = &presentModeCount)
            {
                vkGetPhysicalDeviceSurfacePresentModesKHR(this, surface, __presentModeCount__, presentModes).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceSurfacePresentModesKHR(PhysicalDevice physicalDevice, Surface surface, uint* presentModeCount, PresentMode* presentModes);

        internal unsafe void GetDisplayProperties(ref uint propertyCount, DisplayProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkGetPhysicalDeviceDisplayPropertiesKHR(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceDisplayPropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayProperties* properties);

        internal unsafe void GetDisplayPlaneProperties(ref uint propertyCount, DisplayPlaneProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceDisplayPlanePropertiesKHR(PhysicalDevice physicalDevice, uint* propertyCount, DisplayPlaneProperties* properties);

        internal unsafe void GetDisplayPlaneSupportedDisplays(uint planeIndex, ref uint displayCount, Display* displays)
        {
            fixed (uint* __displayCount__ = &displayCount)
            {
                vkGetDisplayPlaneSupportedDisplaysKHR(this, planeIndex, __displayCount__, displays).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetDisplayPlaneSupportedDisplaysKHR(PhysicalDevice physicalDevice, uint planeIndex, uint* displayCount, Display* displays);

        internal unsafe void GetDisplayModeProperties(Display display, ref uint propertyCount, DisplayModeProperties* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkGetDisplayModePropertiesKHR(this, display, __propertyCount__, properties).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetDisplayModePropertiesKHR(PhysicalDevice physicalDevice, Display display, uint* propertyCount, DisplayModeProperties* properties);

        public unsafe DisplayMode CreateDisplayMode(Display display, ref DisplayModeCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DisplayMode mode;
            fixed (DisplayModeCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDisplayModeKHR(this, display, __createInfo__, allocator, &mode).CheckError();
            }
            return mode;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDisplayModeKHR(PhysicalDevice physicalDevice, Display display, DisplayModeCreateInfo* createInfo, AllocationCallbacks* allocator, DisplayMode* mode);

        public unsafe void GetDisplayPlaneCapabilities(DisplayMode mode, uint planeIndex, out DisplayPlaneCapabilities capabilities)
        {
            fixed (DisplayPlaneCapabilities* __capabilities__ = &capabilities)
            {
                vkGetDisplayPlaneCapabilitiesKHR(this, mode, planeIndex, __capabilities__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetDisplayPlaneCapabilitiesKHR(PhysicalDevice physicalDevice, DisplayMode mode, uint planeIndex, DisplayPlaneCapabilities* capabilities);

        public unsafe RawBool GetXlibPresentationSupport(uint queueFamilyIndex, IntPtr dpy, uint visualId)
        {
            RawBool __result__;
            __result__ = vkGetPhysicalDeviceXlibPresentationSupportKHR(this, queueFamilyIndex, dpy, visualId);
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe RawBool vkGetPhysicalDeviceXlibPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr dpy, uint visualId);

        public unsafe RawBool GetXcbPresentationSupport(uint queueFamilyIndex, IntPtr connection, uint visualid)
        {
            RawBool __result__;
            __result__ = vkGetPhysicalDeviceXcbPresentationSupportKHR(this, queueFamilyIndex, connection, visualid);
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe RawBool vkGetPhysicalDeviceXcbPresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex, IntPtr connection, uint visualid);

        public unsafe RawBool GetWin32PresentationSupport(uint queueFamilyIndex)
        {
            RawBool __result__;
            __result__ = vkGetPhysicalDeviceWin32PresentationSupportKHR(this, queueFamilyIndex);
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe RawBool vkGetPhysicalDeviceWin32PresentationSupportKHR(PhysicalDevice physicalDevice, uint queueFamilyIndex);

        public unsafe void GetFeatures2(out PhysicalDeviceFeatures2 features)
        {
            fixed (PhysicalDeviceFeatures2* __features__ = &features)
            {
                vkGetPhysicalDeviceFeatures2KHR(this, __features__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceFeatures2KHR(PhysicalDevice physicalDevice, PhysicalDeviceFeatures2* features);

        public unsafe void GetProperties2(out PhysicalDeviceProperties2 properties)
        {
            fixed (PhysicalDeviceProperties2* __properties__ = &properties)
            {
                vkGetPhysicalDeviceProperties2KHR(this, __properties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceProperties2* properties);

        public unsafe void GetFormatProperties2(Format format, out FormatProperties2 formatProperties)
        {
            fixed (FormatProperties2* __formatProperties__ = &formatProperties)
            {
                vkGetPhysicalDeviceFormatProperties2KHR(this, format, __formatProperties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceFormatProperties2KHR(PhysicalDevice physicalDevice, Format format, FormatProperties2* formatProperties);

        public unsafe void GetImageFormatProperties2(ref PhysicalDeviceImageFormatInfo2 imageFormatInfo, out ImageFormatProperties2 imageFormatProperties)
        {
            fixed (ImageFormatProperties2* __imageFormatProperties__ = &imageFormatProperties)
            fixed (PhysicalDeviceImageFormatInfo2* __imageFormatInfo__ = &imageFormatInfo)
            {
                vkGetPhysicalDeviceImageFormatProperties2KHR(this, __imageFormatInfo__, __imageFormatProperties__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceImageFormatProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceImageFormatInfo2* imageFormatInfo, ImageFormatProperties2* imageFormatProperties);

        internal unsafe void GetQueueFamilyProperties2(ref uint queueFamilyPropertyCount, QueueFamilyProperties2* queueFamilyProperties)
        {
            fixed (uint* __queueFamilyPropertyCount__ = &queueFamilyPropertyCount)
            {
                vkGetPhysicalDeviceQueueFamilyProperties2KHR(this, __queueFamilyPropertyCount__, queueFamilyProperties);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceQueueFamilyProperties2KHR(PhysicalDevice physicalDevice, uint* queueFamilyPropertyCount, QueueFamilyProperties2* queueFamilyProperties);

        public unsafe void GetMemoryProperties2(out PhysicalDeviceMemoryProperties2 memoryProperties)
        {
            fixed (PhysicalDeviceMemoryProperties2* __memoryProperties__ = &memoryProperties)
            {
                vkGetPhysicalDeviceMemoryProperties2KHR(this, __memoryProperties__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceMemoryProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceMemoryProperties2* memoryProperties);

        internal unsafe void GetSparseImageFormatProperties2(PhysicalDeviceSparseImageFormatInfo2* formatInfo, ref uint propertyCount, SparseImageFormatProperties2* properties)
        {
            fixed (uint* __propertyCount__ = &propertyCount)
            {
                vkGetPhysicalDeviceSparseImageFormatProperties2KHR(this, formatInfo, __propertyCount__, properties);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceSparseImageFormatProperties2KHR(PhysicalDevice physicalDevice, PhysicalDeviceSparseImageFormatInfo2* formatInfo, uint* propertyCount, SparseImageFormatProperties2* properties);

        public unsafe void GetExternalImageFormatProperties(Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, uint externalHandleType, out ExternalImageFormatProperties externalImageFormatProperties)
        {
            fixed (ExternalImageFormatProperties* __externalImageFormatProperties__ = &externalImageFormatProperties)
            {
                vkGetPhysicalDeviceExternalImageFormatPropertiesNV(this, format, type, tiling, usage, flags, externalHandleType, __externalImageFormatProperties__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceExternalImageFormatPropertiesNV(PhysicalDevice physicalDevice, Format format, ImageType type, ImageTiling tiling, ImageUsageFlags usage, ImageCreateFlags flags, uint externalHandleType, ExternalImageFormatProperties* externalImageFormatProperties);

        public unsafe void GetGeneratedCommandsProperties(ref DeviceGeneratedCommandsFeatures features, out DeviceGeneratedCommandsLimits limits)
        {
            fixed (DeviceGeneratedCommandsLimits* __limits__ = &limits)
            fixed (DeviceGeneratedCommandsFeatures* __features__ = &features)
            {
                vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(this, __features__, __limits__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetPhysicalDeviceGeneratedCommandsPropertiesNVX(PhysicalDevice physicalDevice, DeviceGeneratedCommandsFeatures* features, DeviceGeneratedCommandsLimits* limits);

        public unsafe void ReleaseDisplay(Display display)
        {
            vkReleaseDisplayEXT(this, display).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkReleaseDisplayEXT(PhysicalDevice physicalDevice, Display display);

        public unsafe void GetSurfaceCapabilities2(Surface surface, out SurfaceCapabilities2 surfaceCapabilities)
        {
            fixed (SurfaceCapabilities2* __surfaceCapabilities__ = &surfaceCapabilities)
            {
                vkGetPhysicalDeviceSurfaceCapabilities2EXT(this, surface, __surfaceCapabilities__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPhysicalDeviceSurfaceCapabilities2EXT(PhysicalDevice physicalDevice, Surface surface, SurfaceCapabilities2* surfaceCapabilities);
    }

    public partial struct Device
    {
        public unsafe IntPtr GetProcAddress(byte* name)
        {
            IntPtr __result__;
            __result__ = vkGetDeviceProcAddr(this, name);
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe IntPtr vkGetDeviceProcAddr(Device device, byte* name);

        public unsafe void Destroy(AllocationCallbacks* allocator = null)
        {
            vkDestroyDevice(this, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyDevice(Device device, AllocationCallbacks* allocator);

        public unsafe Queue GetQueue(uint queueFamilyIndex, uint queueIndex)
        {
            Queue queue;
            vkGetDeviceQueue(this, queueFamilyIndex, queueIndex, &queue);
            return queue;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetDeviceQueue(Device device, uint queueFamilyIndex, uint queueIndex, Queue* queue);

        public unsafe void WaitIdle()
        {
            vkDeviceWaitIdle(this).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkDeviceWaitIdle(Device device);

        public unsafe DeviceMemory AllocateMemory(ref MemoryAllocateInfo allocateInfo, AllocationCallbacks* allocator = null)
        {
            DeviceMemory memory;
            fixed (MemoryAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                vkAllocateMemory(this, __allocateInfo__, allocator, &memory).CheckError();
            }
            return memory;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkAllocateMemory(Device device, MemoryAllocateInfo* allocateInfo, AllocationCallbacks* allocator, DeviceMemory* memory);

        public unsafe void FreeMemory(DeviceMemory memory, AllocationCallbacks* allocator = null)
        {
            vkFreeMemory(this, memory, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkFreeMemory(Device device, DeviceMemory memory, AllocationCallbacks* allocator);

        public unsafe IntPtr MapMemory(DeviceMemory memory, ulong offset, ulong size, MemoryMapFlags flags)
        {
            IntPtr data;
            vkMapMemory(this, memory, offset, size, flags, &data).CheckError();
            return data;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkMapMemory(Device device, DeviceMemory memory, ulong offset, ulong size, MemoryMapFlags flags, IntPtr* data);

        public unsafe void UnmapMemory(DeviceMemory memory)
        {
            vkUnmapMemory(this, memory);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkUnmapMemory(Device device, DeviceMemory memory);

        public unsafe void FlushMappedMemoryRanges(uint memoryRangeCount, MappedMemoryRange* memoryRanges)
        {
            vkFlushMappedMemoryRanges(this, memoryRangeCount, memoryRanges).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkFlushMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe void InvalidateMappedMemoryRanges(uint memoryRangeCount, MappedMemoryRange* memoryRanges)
        {
            vkInvalidateMappedMemoryRanges(this, memoryRangeCount, memoryRanges).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkInvalidateMappedMemoryRanges(Device device, uint memoryRangeCount, MappedMemoryRange* memoryRanges);

        public unsafe ulong GetMemoryCommitment(DeviceMemory memory)
        {
            ulong committedMemoryInBytes;
            vkGetDeviceMemoryCommitment(this, memory, &committedMemoryInBytes);
            return committedMemoryInBytes;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetDeviceMemoryCommitment(Device device, DeviceMemory memory, ulong* committedMemoryInBytes);

        public unsafe void BindBufferMemory(Buffer buffer, DeviceMemory memory, ulong memoryOffset)
        {
            vkBindBufferMemory(this, buffer, memory, memoryOffset).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkBindBufferMemory(Device device, Buffer buffer, DeviceMemory memory, ulong memoryOffset);

        public unsafe void BindImageMemory(Image image, DeviceMemory memory, ulong memoryOffset)
        {
            vkBindImageMemory(this, image, memory, memoryOffset).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkBindImageMemory(Device device, Image image, DeviceMemory memory, ulong memoryOffset);

        public unsafe void GetBufferMemoryRequirements(Buffer buffer, out MemoryRequirements memoryRequirements)
        {
            fixed (MemoryRequirements* __memoryRequirements__ = &memoryRequirements)
            {
                vkGetBufferMemoryRequirements(this, buffer, __memoryRequirements__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetBufferMemoryRequirements(Device device, Buffer buffer, MemoryRequirements* memoryRequirements);

        public unsafe void GetImageMemoryRequirements(Image image, out MemoryRequirements memoryRequirements)
        {
            fixed (MemoryRequirements* __memoryRequirements__ = &memoryRequirements)
            {
                vkGetImageMemoryRequirements(this, image, __memoryRequirements__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetImageMemoryRequirements(Device device, Image image, MemoryRequirements* memoryRequirements);

        internal unsafe void GetImageSparseMemoryRequirements(Image image, ref uint sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements)
        {
            fixed (uint* __sparseMemoryRequirementCount__ = &sparseMemoryRequirementCount)
            {
                vkGetImageSparseMemoryRequirements(this, image, __sparseMemoryRequirementCount__, sparseMemoryRequirements);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetImageSparseMemoryRequirements(Device device, Image image, uint* sparseMemoryRequirementCount, SparseImageMemoryRequirements* sparseMemoryRequirements);

        public unsafe Fence CreateFence(ref FenceCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Fence fence;
            fixed (FenceCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateFence(this, __createInfo__, allocator, &fence).CheckError();
            }
            return fence;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateFence(Device device, FenceCreateInfo* createInfo, AllocationCallbacks* allocator, Fence* fence);

        public unsafe void DestroyFence(Fence fence, AllocationCallbacks* allocator = null)
        {
            vkDestroyFence(this, fence, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyFence(Device device, Fence fence, AllocationCallbacks* allocator);

        public unsafe void ResetFences(uint fenceCount, Fence* fences)
        {
            vkResetFences(this, fenceCount, fences).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkResetFences(Device device, uint fenceCount, Fence* fences);

        public unsafe Result GetFenceStatus(Fence fence)
        {
            Result __result__;
            __result__ = vkGetFenceStatus(this, fence);
            __result__.CheckError();
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetFenceStatus(Device device, Fence fence);

        public unsafe void WaitForFences(uint fenceCount, Fence* fences, RawBool waitAll, ulong timeout)
        {
            vkWaitForFences(this, fenceCount, fences, waitAll, timeout).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkWaitForFences(Device device, uint fenceCount, Fence* fences, RawBool waitAll, ulong timeout);

        public unsafe Semaphore CreateSemaphore(ref SemaphoreCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Semaphore semaphore;
            fixed (SemaphoreCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateSemaphore(this, __createInfo__, allocator, &semaphore).CheckError();
            }
            return semaphore;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateSemaphore(Device device, SemaphoreCreateInfo* createInfo, AllocationCallbacks* allocator, Semaphore* semaphore);

        public unsafe void DestroySemaphore(Semaphore semaphore, AllocationCallbacks* allocator = null)
        {
            vkDestroySemaphore(this, semaphore, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroySemaphore(Device device, Semaphore semaphore, AllocationCallbacks* allocator);

        public unsafe Event CreateEvent(ref EventCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Event @event;
            fixed (EventCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateEvent(this, __createInfo__, allocator, &@event).CheckError();
            }
            return @event;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateEvent(Device device, EventCreateInfo* createInfo, AllocationCallbacks* allocator, Event* @event);

        public unsafe void DestroyEvent(Event @event, AllocationCallbacks* allocator = null)
        {
            vkDestroyEvent(this, @event, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyEvent(Device device, Event @event, AllocationCallbacks* allocator);

        public unsafe Result GetEventStatus(Event @event)
        {
            Result __result__;
            __result__ = vkGetEventStatus(this, @event);
            __result__.CheckError();
            return __result__;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetEventStatus(Device device, Event @event);

        public unsafe void SetEvent(Event @event)
        {
            vkSetEvent(this, @event).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkSetEvent(Device device, Event @event);

        public unsafe void ResetEvent(Event @event)
        {
            vkResetEvent(this, @event).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkResetEvent(Device device, Event @event);

        public unsafe QueryPool CreateQueryPool(ref QueryPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            QueryPool queryPool;
            fixed (QueryPoolCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateQueryPool(this, __createInfo__, allocator, &queryPool).CheckError();
            }
            return queryPool;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateQueryPool(Device device, QueryPoolCreateInfo* createInfo, AllocationCallbacks* allocator, QueryPool* queryPool);

        public unsafe void DestroyQueryPool(QueryPool queryPool, AllocationCallbacks* allocator = null)
        {
            vkDestroyQueryPool(this, queryPool, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyQueryPool(Device device, QueryPool queryPool, AllocationCallbacks* allocator);

        public unsafe void GetQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, PointerSize dataSize, IntPtr data, ulong stride, QueryResultFlags flags)
        {
            vkGetQueryPoolResults(this, queryPool, firstQuery, queryCount, dataSize, data, stride, flags).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetQueryPoolResults(Device device, QueryPool queryPool, uint firstQuery, uint queryCount, PointerSize dataSize, IntPtr data, ulong stride, QueryResultFlags flags);

        public unsafe Buffer CreateBuffer(ref BufferCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Buffer buffer;
            fixed (BufferCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateBuffer(this, __createInfo__, allocator, &buffer).CheckError();
            }
            return buffer;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateBuffer(Device device, BufferCreateInfo* createInfo, AllocationCallbacks* allocator, Buffer* buffer);

        public unsafe void DestroyBuffer(Buffer buffer, AllocationCallbacks* allocator = null)
        {
            vkDestroyBuffer(this, buffer, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyBuffer(Device device, Buffer buffer, AllocationCallbacks* allocator);

        public unsafe BufferView CreateBufferView(ref BufferViewCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            BufferView view;
            fixed (BufferViewCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateBufferView(this, __createInfo__, allocator, &view).CheckError();
            }
            return view;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateBufferView(Device device, BufferViewCreateInfo* createInfo, AllocationCallbacks* allocator, BufferView* view);

        public unsafe void DestroyBufferView(BufferView bufferView, AllocationCallbacks* allocator = null)
        {
            vkDestroyBufferView(this, bufferView, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyBufferView(Device device, BufferView bufferView, AllocationCallbacks* allocator);

        public unsafe Image CreateImage(ref ImageCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Image image;
            fixed (ImageCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateImage(this, __createInfo__, allocator, &image).CheckError();
            }
            return image;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateImage(Device device, ImageCreateInfo* createInfo, AllocationCallbacks* allocator, Image* image);

        public unsafe void DestroyImage(Image image, AllocationCallbacks* allocator = null)
        {
            vkDestroyImage(this, image, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyImage(Device device, Image image, AllocationCallbacks* allocator);

        public unsafe void GetImageSubresourceLayout(Image image, ImageSubresource subresource, out SubresourceLayout layout)
        {
            fixed (SubresourceLayout* __layout__ = &layout)
            {
                vkGetImageSubresourceLayout(this, image, &subresource, __layout__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetImageSubresourceLayout(Device device, Image image, ImageSubresource* subresource, SubresourceLayout* layout);

        public unsafe ImageView CreateImageView(ref ImageViewCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            ImageView view;
            fixed (ImageViewCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateImageView(this, __createInfo__, allocator, &view).CheckError();
            }
            return view;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateImageView(Device device, ImageViewCreateInfo* createInfo, AllocationCallbacks* allocator, ImageView* view);

        public unsafe void DestroyImageView(ImageView imageView, AllocationCallbacks* allocator = null)
        {
            vkDestroyImageView(this, imageView, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyImageView(Device device, ImageView imageView, AllocationCallbacks* allocator);

        public unsafe ShaderModule CreateShaderModule(ref ShaderModuleCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            ShaderModule shaderModule;
            fixed (ShaderModuleCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateShaderModule(this, __createInfo__, allocator, &shaderModule).CheckError();
            }
            return shaderModule;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateShaderModule(Device device, ShaderModuleCreateInfo* createInfo, AllocationCallbacks* allocator, ShaderModule* shaderModule);

        public unsafe void DestroyShaderModule(ShaderModule shaderModule, AllocationCallbacks* allocator = null)
        {
            vkDestroyShaderModule(this, shaderModule, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyShaderModule(Device device, ShaderModule shaderModule, AllocationCallbacks* allocator);

        public unsafe PipelineCache CreatePipelineCache(ref PipelineCacheCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            PipelineCache pipelineCache;
            fixed (PipelineCacheCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreatePipelineCache(this, __createInfo__, allocator, &pipelineCache).CheckError();
            }
            return pipelineCache;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreatePipelineCache(Device device, PipelineCacheCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineCache* pipelineCache);

        public unsafe void DestroyPipelineCache(PipelineCache pipelineCache, AllocationCallbacks* allocator = null)
        {
            vkDestroyPipelineCache(this, pipelineCache, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyPipelineCache(Device device, PipelineCache pipelineCache, AllocationCallbacks* allocator);

        public unsafe void GetPipelineCacheData(PipelineCache pipelineCache, ref PointerSize dataSize, IntPtr data)
        {
            fixed (PointerSize* __dataSize__ = &dataSize)
            {
                vkGetPipelineCacheData(this, pipelineCache, __dataSize__, data).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetPipelineCacheData(Device device, PipelineCache pipelineCache, PointerSize* dataSize, IntPtr data);

        public unsafe void MergePipelineCaches(PipelineCache destinationCache, uint sourceCacheCount, PipelineCache srcCaches)
        {
            vkMergePipelineCaches(this, destinationCache, sourceCacheCount, &srcCaches).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkMergePipelineCaches(Device device, PipelineCache destinationCache, uint sourceCacheCount, PipelineCache* srcCaches);

        public unsafe Pipeline CreateGraphicsPipelines(PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator = null)
        {
            Pipeline pipelines;
            vkCreateGraphicsPipelines(this, pipelineCache, createInfoCount, createInfos, allocator, &pipelines).CheckError();
            return pipelines;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateGraphicsPipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, GraphicsPipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

        public unsafe Pipeline CreateComputePipelines(PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator = null)
        {
            Pipeline pipelines;
            vkCreateComputePipelines(this, pipelineCache, createInfoCount, createInfos, allocator, &pipelines).CheckError();
            return pipelines;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateComputePipelines(Device device, PipelineCache pipelineCache, uint createInfoCount, ComputePipelineCreateInfo* createInfos, AllocationCallbacks* allocator, Pipeline* pipelines);

        public unsafe void DestroyPipeline(Pipeline pipeline, AllocationCallbacks* allocator = null)
        {
            vkDestroyPipeline(this, pipeline, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyPipeline(Device device, Pipeline pipeline, AllocationCallbacks* allocator);

        public unsafe PipelineLayout CreatePipelineLayout(ref PipelineLayoutCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            PipelineLayout pipelineLayout;
            fixed (PipelineLayoutCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreatePipelineLayout(this, __createInfo__, allocator, &pipelineLayout).CheckError();
            }
            return pipelineLayout;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreatePipelineLayout(Device device, PipelineLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, PipelineLayout* pipelineLayout);

        public unsafe void DestroyPipelineLayout(PipelineLayout pipelineLayout, AllocationCallbacks* allocator = null)
        {
            vkDestroyPipelineLayout(this, pipelineLayout, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyPipelineLayout(Device device, PipelineLayout pipelineLayout, AllocationCallbacks* allocator);

        public unsafe Sampler CreateSampler(ref SamplerCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Sampler sampler;
            fixed (SamplerCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateSampler(this, __createInfo__, allocator, &sampler).CheckError();
            }
            return sampler;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateSampler(Device device, SamplerCreateInfo* createInfo, AllocationCallbacks* allocator, Sampler* sampler);

        public unsafe void DestroySampler(Sampler sampler, AllocationCallbacks* allocator = null)
        {
            vkDestroySampler(this, sampler, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroySampler(Device device, Sampler sampler, AllocationCallbacks* allocator);

        public unsafe DescriptorSetLayout CreateDescriptorSetLayout(ref DescriptorSetLayoutCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DescriptorSetLayout setLayout;
            fixed (DescriptorSetLayoutCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDescriptorSetLayout(this, __createInfo__, allocator, &setLayout).CheckError();
            }
            return setLayout;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDescriptorSetLayout(Device device, DescriptorSetLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorSetLayout* setLayout);

        public unsafe void DestroyDescriptorSetLayout(DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator = null)
        {
            vkDestroyDescriptorSetLayout(this, descriptorSetLayout, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyDescriptorSetLayout(Device device, DescriptorSetLayout descriptorSetLayout, AllocationCallbacks* allocator);

        public unsafe DescriptorPool CreateDescriptorPool(ref DescriptorPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            DescriptorPool descriptorPool;
            fixed (DescriptorPoolCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateDescriptorPool(this, __createInfo__, allocator, &descriptorPool).CheckError();
            }
            return descriptorPool;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateDescriptorPool(Device device, DescriptorPoolCreateInfo* createInfo, AllocationCallbacks* allocator, DescriptorPool* descriptorPool);

        public unsafe void DestroyDescriptorPool(DescriptorPool descriptorPool, AllocationCallbacks* allocator = null)
        {
            vkDestroyDescriptorPool(this, descriptorPool, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyDescriptorPool(Device device, DescriptorPool descriptorPool, AllocationCallbacks* allocator);

        public unsafe void ResetDescriptorPool(DescriptorPool descriptorPool, DescriptorPoolResetFlags flags)
        {
            vkResetDescriptorPool(this, descriptorPool, flags).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkResetDescriptorPool(Device device, DescriptorPool descriptorPool, DescriptorPoolResetFlags flags);

        public unsafe void AllocateDescriptorSets(ref DescriptorSetAllocateInfo allocateInfo, DescriptorSet* descriptorSets)
        {
            fixed (DescriptorSetAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                vkAllocateDescriptorSets(this, __allocateInfo__, descriptorSets).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkAllocateDescriptorSets(Device device, DescriptorSetAllocateInfo* allocateInfo, DescriptorSet* descriptorSets);

        public unsafe void FreeDescriptorSets(DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets)
        {
            vkFreeDescriptorSets(this, descriptorPool, descriptorSetCount, descriptorSets).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkFreeDescriptorSets(Device device, DescriptorPool descriptorPool, uint descriptorSetCount, DescriptorSet* descriptorSets);

        public unsafe void UpdateDescriptorSets(uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies)
        {
            vkUpdateDescriptorSets(this, descriptorWriteCount, descriptorWrites, descriptorCopyCount, descriptorCopies);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkUpdateDescriptorSets(Device device, uint descriptorWriteCount, WriteDescriptorSet* descriptorWrites, uint descriptorCopyCount, CopyDescriptorSet* descriptorCopies);

        public unsafe Framebuffer CreateFramebuffer(ref FramebufferCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Framebuffer framebuffer;
            fixed (FramebufferCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateFramebuffer(this, __createInfo__, allocator, &framebuffer).CheckError();
            }
            return framebuffer;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateFramebuffer(Device device, FramebufferCreateInfo* createInfo, AllocationCallbacks* allocator, Framebuffer* framebuffer);

        public unsafe void DestroyFramebuffer(Framebuffer framebuffer, AllocationCallbacks* allocator = null)
        {
            vkDestroyFramebuffer(this, framebuffer, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyFramebuffer(Device device, Framebuffer framebuffer, AllocationCallbacks* allocator);

        public unsafe RenderPass CreateRenderPass(ref RenderPassCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            RenderPass renderPass;
            fixed (RenderPassCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateRenderPass(this, __createInfo__, allocator, &renderPass).CheckError();
            }
            return renderPass;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateRenderPass(Device device, RenderPassCreateInfo* createInfo, AllocationCallbacks* allocator, RenderPass* renderPass);

        public unsafe void DestroyRenderPass(RenderPass renderPass, AllocationCallbacks* allocator = null)
        {
            vkDestroyRenderPass(this, renderPass, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyRenderPass(Device device, RenderPass renderPass, AllocationCallbacks* allocator);

        public unsafe Extent2D GetRenderAreaGranularity(RenderPass renderPass)
        {
            Extent2D granularity;
            vkGetRenderAreaGranularity(this, renderPass, &granularity);
            return granularity;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkGetRenderAreaGranularity(Device device, RenderPass renderPass, Extent2D* granularity);

        public unsafe CommandPool CreateCommandPool(ref CommandPoolCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            CommandPool commandPool;
            fixed (CommandPoolCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateCommandPool(this, __createInfo__, allocator, &commandPool).CheckError();
            }
            return commandPool;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateCommandPool(Device device, CommandPoolCreateInfo* createInfo, AllocationCallbacks* allocator, CommandPool* commandPool);

        public unsafe void DestroyCommandPool(CommandPool commandPool, AllocationCallbacks* allocator = null)
        {
            vkDestroyCommandPool(this, commandPool, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyCommandPool(Device device, CommandPool commandPool, AllocationCallbacks* allocator);

        public unsafe void ResetCommandPool(CommandPool commandPool, CommandPoolResetFlags flags)
        {
            vkResetCommandPool(this, commandPool, flags).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkResetCommandPool(Device device, CommandPool commandPool, CommandPoolResetFlags flags);

        public unsafe void AllocateCommandBuffers(ref CommandBufferAllocateInfo allocateInfo, CommandBuffer* commandBuffers)
        {
            fixed (CommandBufferAllocateInfo* __allocateInfo__ = &allocateInfo)
            {
                vkAllocateCommandBuffers(this, __allocateInfo__, commandBuffers).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkAllocateCommandBuffers(Device device, CommandBufferAllocateInfo* allocateInfo, CommandBuffer* commandBuffers);

        public unsafe void FreeCommandBuffers(CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers)
        {
            vkFreeCommandBuffers(this, commandPool, commandBufferCount, commandBuffers);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkFreeCommandBuffers(Device device, CommandPool commandPool, uint commandBufferCount, CommandBuffer* commandBuffers);

        public unsafe Swapchain CreateSwapchain(ref SwapchainCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            Swapchain swapchain;
            fixed (SwapchainCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateSwapchainKHR(this, __createInfo__, allocator, &swapchain).CheckError();
            }
            return swapchain;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateSwapchainKHR(Device device, SwapchainCreateInfo* createInfo, AllocationCallbacks* allocator, Swapchain* swapchain);

        public unsafe void DestroySwapchain(Swapchain swapchain, AllocationCallbacks* allocator = null)
        {
            vkDestroySwapchainKHR(this, swapchain, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroySwapchainKHR(Device device, Swapchain swapchain, AllocationCallbacks* allocator);

        internal unsafe void GetSwapchainImages(Swapchain swapchain, ref uint swapchainImageCount, Image* swapchainImages)
        {
            fixed (uint* __swapchainImageCount__ = &swapchainImageCount)
            {
                vkGetSwapchainImagesKHR(this, swapchain, __swapchainImageCount__, swapchainImages).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetSwapchainImagesKHR(Device device, Swapchain swapchain, uint* swapchainImageCount, Image* swapchainImages);

        public unsafe uint AcquireNextImage(Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence)
        {
            uint imageIndex;
            vkAcquireNextImageKHR(this, swapchain, timeout, semaphore, fence, &imageIndex).CheckError();
            return imageIndex;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkAcquireNextImageKHR(Device device, Swapchain swapchain, ulong timeout, Semaphore semaphore, Fence fence, uint* imageIndex);

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateSharedSwapchainsKHR(Device device, uint swapchainCount, SwapchainCreateInfo* createInfos, AllocationCallbacks* allocator, Swapchain* swapchains);

        public unsafe void TrimCommandPool(CommandPool commandPool, CommandPoolTrimFlags flags)
        {
            vkTrimCommandPoolKHR(this, commandPool, flags);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkTrimCommandPoolKHR(Device device, CommandPool commandPool, CommandPoolTrimFlags flags);

        public unsafe void DebugMarkerSetObjectTag(ref DebugMarkerObjectTagInfo tagInfo)
        {
            fixed (DebugMarkerObjectTagInfo* __tagInfo__ = &tagInfo)
            {
                vkDebugMarkerSetObjectTagEXT(this, __tagInfo__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkDebugMarkerSetObjectTagEXT(Device device, DebugMarkerObjectTagInfo* tagInfo);

        public unsafe void DebugMarkerSetObjectName(ref DebugMarkerObjectNameInfo nameInfo)
        {
            fixed (DebugMarkerObjectNameInfo* __nameInfo__ = &nameInfo)
            {
                vkDebugMarkerSetObjectNameEXT(this, __nameInfo__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkDebugMarkerSetObjectNameEXT(Device device, DebugMarkerObjectNameInfo* nameInfo);

        public unsafe int GetMemoryWin32Handle(DeviceMemory memory, uint handleType)
        {
            int handle;
            vkGetMemoryWin32HandleNV(this, memory, handleType, &handle).CheckError();
            return handle;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetMemoryWin32HandleNV(Device device, DeviceMemory memory, uint handleType, int* handle);

        public unsafe IndirectCommandsLayout CreateIndirectCommandsLayout(ref IndirectCommandsLayoutCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            IndirectCommandsLayout indirectCommandsLayout;
            fixed (IndirectCommandsLayoutCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateIndirectCommandsLayoutNVX(this, __createInfo__, allocator, &indirectCommandsLayout).CheckError();
            }
            return indirectCommandsLayout;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateIndirectCommandsLayoutNVX(Device device, IndirectCommandsLayoutCreateInfo* createInfo, AllocationCallbacks* allocator, IndirectCommandsLayout* indirectCommandsLayout);

        public unsafe void DestroyIndirectCommandsLayout(IndirectCommandsLayout indirectCommandsLayout, AllocationCallbacks* allocator = null)
        {
            vkDestroyIndirectCommandsLayoutNVX(this, indirectCommandsLayout, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyIndirectCommandsLayoutNVX(Device device, IndirectCommandsLayout indirectCommandsLayout, AllocationCallbacks* allocator);

        public unsafe ObjectTable CreateObjectTable(ref ObjectTableCreateInfo createInfo, AllocationCallbacks* allocator = null)
        {
            ObjectTable objectTable;
            fixed (ObjectTableCreateInfo* __createInfo__ = &createInfo)
            {
                vkCreateObjectTableNVX(this, __createInfo__, allocator, &objectTable).CheckError();
            }
            return objectTable;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkCreateObjectTableNVX(Device device, ObjectTableCreateInfo* createInfo, AllocationCallbacks* allocator, ObjectTable* objectTable);

        public unsafe void DestroyObjectTable(ObjectTable objectTable, AllocationCallbacks* allocator = null)
        {
            vkDestroyObjectTableNVX(this, objectTable, allocator);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkDestroyObjectTableNVX(Device device, ObjectTable objectTable, AllocationCallbacks* allocator);

        public unsafe void RegisterObjects(ObjectTable objectTable, uint objectCount, IntPtr objectTableEntries, uint objectIndices)
        {
            vkRegisterObjectsNVX(this, objectTable, objectCount, &objectTableEntries, &objectIndices).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkRegisterObjectsNVX(Device device, ObjectTable objectTable, uint objectCount, IntPtr* objectTableEntries, uint* objectIndices);

        public unsafe void UnregisterObjects(ObjectTable objectTable, uint objectCount, ObjectEntryType objectEntryTypes, uint objectIndices)
        {
            vkUnregisterObjectsNVX(this, objectTable, objectCount, &objectEntryTypes, &objectIndices).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkUnregisterObjectsNVX(Device device, ObjectTable objectTable, uint objectCount, ObjectEntryType* objectEntryTypes, uint* objectIndices);

        public unsafe void DisplayPowerControl(Display display, ref DisplayPowerInfo displayPowerInfo)
        {
            fixed (DisplayPowerInfo* __displayPowerInfo__ = &displayPowerInfo)
            {
                vkDisplayPowerControlEXT(this, display, __displayPowerInfo__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkDisplayPowerControlEXT(Device device, Display display, DisplayPowerInfo* displayPowerInfo);

        public unsafe Fence RegisterEvent(ref DeviceEventInfo deviceEventInfo, AllocationCallbacks* allocator = null)
        {
            Fence fence;
            fixed (DeviceEventInfo* __deviceEventInfo__ = &deviceEventInfo)
            {
                vkRegisterDeviceEventEXT(this, __deviceEventInfo__, allocator, &fence).CheckError();
            }
            return fence;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkRegisterDeviceEventEXT(Device device, DeviceEventInfo* deviceEventInfo, AllocationCallbacks* allocator, Fence* fence);

        public unsafe Fence RegisterDisplayEvent(Display display, ref DisplayEventInfo displayEventInfo, AllocationCallbacks* allocator = null)
        {
            Fence fence;
            fixed (DisplayEventInfo* __displayEventInfo__ = &displayEventInfo)
            {
                vkRegisterDisplayEventEXT(this, display, __displayEventInfo__, allocator, &fence).CheckError();
            }
            return fence;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkRegisterDisplayEventEXT(Device device, Display display, DisplayEventInfo* displayEventInfo, AllocationCallbacks* allocator, Fence* fence);

        public unsafe ulong GetSwapchainCounter(Swapchain swapchain, SurfaceCounterFlags counter)
        {
            ulong counterValue;
            vkGetSwapchainCounterEXT(this, swapchain, counter, &counterValue).CheckError();
            return counterValue;
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkGetSwapchainCounterEXT(Device device, Swapchain swapchain, SurfaceCounterFlags counter, ulong* counterValue);
    }

    public partial struct Queue
    {
        public unsafe void Submit(uint submitCount, SubmitInfo* submits, Fence fence)
        {
            vkQueueSubmit(this, submitCount, submits, fence).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkQueueSubmit(Queue queue, uint submitCount, SubmitInfo* submits, Fence fence);

        public unsafe void WaitIdle()
        {
            vkQueueWaitIdle(this).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkQueueWaitIdle(Queue queue);

        public unsafe void BindSparse(uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence)
        {
            vkQueueBindSparse(this, bindInfoCount, bindInfo, fence).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkQueueBindSparse(Queue queue, uint bindInfoCount, BindSparseInfo* bindInfo, Fence fence);

        public unsafe void Present(ref PresentInfo presentInfo)
        {
            fixed (PresentInfo* __presentInfo__ = &presentInfo)
            {
                vkQueuePresentKHR(this, __presentInfo__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkQueuePresentKHR(Queue queue, PresentInfo* presentInfo);
    }

    public partial struct CommandBuffer
    {
        public unsafe void Begin(ref CommandBufferBeginInfo beginInfo)
        {
            fixed (CommandBufferBeginInfo* __beginInfo__ = &beginInfo)
            {
                vkBeginCommandBuffer(this, __beginInfo__).CheckError();
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkBeginCommandBuffer(CommandBuffer commandBuffer, CommandBufferBeginInfo* beginInfo);

        public unsafe void End()
        {
            vkEndCommandBuffer(this).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkEndCommandBuffer(CommandBuffer commandBuffer);

        public unsafe void Reset(CommandBufferResetFlags flags)
        {
            vkResetCommandBuffer(this, flags).CheckError();
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe Result vkResetCommandBuffer(CommandBuffer commandBuffer, CommandBufferResetFlags flags);

        public unsafe void BindPipeline(PipelineBindPoint pipelineBindPoint, Pipeline pipeline)
        {
            vkCmdBindPipeline(this, pipelineBindPoint, pipeline);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBindPipeline(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, Pipeline pipeline);

        public unsafe void SetViewport(uint firstViewport, uint viewportCount, Viewport* viewports)
        {
            vkCmdSetViewport(this, firstViewport, viewportCount, viewports);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetViewport(CommandBuffer commandBuffer, uint firstViewport, uint viewportCount, Viewport* viewports);

        public unsafe void SetScissor(uint firstScissor, uint scissorCount, Rect2D* scissors)
        {
            vkCmdSetScissor(this, firstScissor, scissorCount, scissors);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetScissor(CommandBuffer commandBuffer, uint firstScissor, uint scissorCount, Rect2D* scissors);

        public unsafe void SetLineWidth(float lineWidth)
        {
            vkCmdSetLineWidth(this, lineWidth);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetLineWidth(CommandBuffer commandBuffer, float lineWidth);

        public unsafe void SetDepthBias(float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor)
        {
            vkCmdSetDepthBias(this, depthBiasConstantFactor, depthBiasClamp, depthBiasSlopeFactor);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetDepthBias(CommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);

        public unsafe void SetBlendConstants(float blendConstants)
        {
            vkCmdSetBlendConstants(this, blendConstants);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetBlendConstants(CommandBuffer commandBuffer, float blendConstants);

        public unsafe void SetDepthBounds(float minDepthBounds, float maxDepthBounds)
        {
            vkCmdSetDepthBounds(this, minDepthBounds, maxDepthBounds);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetDepthBounds(CommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);

        public unsafe void SetStencilCompareMask(StencilFaceFlags faceMask, uint compareMask)
        {
            vkCmdSetStencilCompareMask(this, faceMask, compareMask);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetStencilCompareMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint compareMask);

        public unsafe void SetStencilWriteMask(StencilFaceFlags faceMask, uint writeMask)
        {
            vkCmdSetStencilWriteMask(this, faceMask, writeMask);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetStencilWriteMask(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint writeMask);

        public unsafe void SetStencilReference(StencilFaceFlags faceMask, uint reference)
        {
            vkCmdSetStencilReference(this, faceMask, reference);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetStencilReference(CommandBuffer commandBuffer, StencilFaceFlags faceMask, uint reference);

        public unsafe void BindDescriptorSets(PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets)
        {
            vkCmdBindDescriptorSets(this, pipelineBindPoint, layout, firstSet, descriptorSetCount, descriptorSets, dynamicOffsetCount, dynamicOffsets);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBindDescriptorSets(CommandBuffer commandBuffer, PipelineBindPoint pipelineBindPoint, PipelineLayout layout, uint firstSet, uint descriptorSetCount, DescriptorSet* descriptorSets, uint dynamicOffsetCount, uint* dynamicOffsets);

        public unsafe void BindIndexBuffer(Buffer buffer, ulong offset, IndexType indexType)
        {
            vkCmdBindIndexBuffer(this, buffer, offset, indexType);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBindIndexBuffer(CommandBuffer commandBuffer, Buffer buffer, ulong offset, IndexType indexType);

        public unsafe void BindVertexBuffers(uint firstBinding, uint bindingCount, Buffer* buffers, ulong* offsets)
        {
            vkCmdBindVertexBuffers(this, firstBinding, bindingCount, buffers, offsets);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBindVertexBuffers(CommandBuffer commandBuffer, uint firstBinding, uint bindingCount, Buffer* buffers, ulong* offsets);

        public unsafe void Draw(uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance)
        {
            vkCmdDraw(this, vertexCount, instanceCount, firstVertex, firstInstance);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDraw(CommandBuffer commandBuffer, uint vertexCount, uint instanceCount, uint firstVertex, uint firstInstance);

        public unsafe void DrawIndexed(uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance)
        {
            vkCmdDrawIndexed(this, indexCount, instanceCount, firstIndex, vertexOffset, firstInstance);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDrawIndexed(CommandBuffer commandBuffer, uint indexCount, uint instanceCount, uint firstIndex, int vertexOffset, uint firstInstance);

        public unsafe void DrawIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            vkCmdDrawIndirect(this, buffer, offset, drawCount, stride);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDrawIndirect(CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);

        public unsafe void DrawIndexedIndirect(Buffer buffer, ulong offset, uint drawCount, uint stride)
        {
            vkCmdDrawIndexedIndirect(this, buffer, offset, drawCount, stride);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDrawIndexedIndirect(CommandBuffer commandBuffer, Buffer buffer, ulong offset, uint drawCount, uint stride);

        public unsafe void Dispatch(uint x, uint y, uint z)
        {
            vkCmdDispatch(this, x, y, z);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDispatch(CommandBuffer commandBuffer, uint x, uint y, uint z);

        public unsafe void DispatchIndirect(Buffer buffer, ulong offset)
        {
            vkCmdDispatchIndirect(this, buffer, offset);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDispatchIndirect(CommandBuffer commandBuffer, Buffer buffer, ulong offset);

        public unsafe void CopyBuffer(Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions)
        {
            vkCmdCopyBuffer(this, sourceBuffer, destinationBuffer, regionCount, regions);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdCopyBuffer(CommandBuffer commandBuffer, Buffer sourceBuffer, Buffer destinationBuffer, uint regionCount, BufferCopy* regions);

        public unsafe void CopyImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions)
        {
            vkCmdCopyImage(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdCopyImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageCopy* regions);

        public unsafe void BlitImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter)
        {
            vkCmdBlitImage(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions, filter);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBlitImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageBlit* regions, Filter filter);

        public unsafe void CopyBufferToImage(Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions)
        {
            vkCmdCopyBufferToImage(this, sourceBuffer, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdCopyBufferToImage(CommandBuffer commandBuffer, Buffer sourceBuffer, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, BufferImageCopy* regions);

        public unsafe void CopyImageToBuffer(Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions)
        {
            vkCmdCopyImageToBuffer(this, sourceImage, sourceImageLayout, destinationBuffer, regionCount, regions);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdCopyImageToBuffer(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Buffer destinationBuffer, uint regionCount, BufferImageCopy* regions);

        public unsafe void UpdateBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong dataSize, IntPtr data)
        {
            vkCmdUpdateBuffer(this, destinationBuffer, destinationOffset, dataSize, data);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdUpdateBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong dataSize, IntPtr data);

        public unsafe void FillBuffer(Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data)
        {
            vkCmdFillBuffer(this, destinationBuffer, destinationOffset, size, data);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdFillBuffer(CommandBuffer commandBuffer, Buffer destinationBuffer, ulong destinationOffset, ulong size, uint data);

        public unsafe void ClearColorImage(Image image, ImageLayout imageLayout, ClearColorValue color, uint rangeCount, ImageSubresourceRange* ranges)
        {
            vkCmdClearColorImage(this, image, imageLayout, &color, rangeCount, ranges);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdClearColorImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearColorValue* color, uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe void ClearDepthStencilImage(Image image, ImageLayout imageLayout, ClearDepthStencilValue depthStencil, uint rangeCount, ImageSubresourceRange* ranges)
        {
            vkCmdClearDepthStencilImage(this, image, imageLayout, &depthStencil, rangeCount, ranges);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdClearDepthStencilImage(CommandBuffer commandBuffer, Image image, ImageLayout imageLayout, ClearDepthStencilValue* depthStencil, uint rangeCount, ImageSubresourceRange* ranges);

        public unsafe void ClearAttachments(uint attachmentCount, ref ClearAttachment attachments, uint rectCount, ClearRect* rects)
        {
            fixed (ClearAttachment* __attachments__ = &attachments)
            {
                vkCmdClearAttachments(this, attachmentCount, __attachments__, rectCount, rects);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdClearAttachments(CommandBuffer commandBuffer, uint attachmentCount, ClearAttachment* attachments, uint rectCount, ClearRect* rects);

        public unsafe void ResolveImage(Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions)
        {
            vkCmdResolveImage(this, sourceImage, sourceImageLayout, destinationImage, destinationImageLayout, regionCount, regions);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdResolveImage(CommandBuffer commandBuffer, Image sourceImage, ImageLayout sourceImageLayout, Image destinationImage, ImageLayout destinationImageLayout, uint regionCount, ImageResolve* regions);

        public unsafe void SetEvent(Event @event, PipelineStageFlags stageMask)
        {
            vkCmdSetEvent(this, @event, stageMask);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdSetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe void ResetEvent(Event @event, PipelineStageFlags stageMask)
        {
            vkCmdResetEvent(this, @event, stageMask);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdResetEvent(CommandBuffer commandBuffer, Event @event, PipelineStageFlags stageMask);

        public unsafe void WaitEvents(uint eventCount, Event events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers)
        {
            vkCmdWaitEvents(this, eventCount, &events, sourceStageMask, destinationStageMask, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdWaitEvents(CommandBuffer commandBuffer, uint eventCount, Event* events, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe void PipelineBarrier(PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers)
        {
            vkCmdPipelineBarrier(this, sourceStageMask, destinationStageMask, dependencyFlags, memoryBarrierCount, memoryBarriers, bufferMemoryBarrierCount, bufferMemoryBarriers, imageMemoryBarrierCount, imageMemoryBarriers);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdPipelineBarrier(CommandBuffer commandBuffer, PipelineStageFlags sourceStageMask, PipelineStageFlags destinationStageMask, DependencyFlags dependencyFlags, uint memoryBarrierCount, MemoryBarrier* memoryBarriers, uint bufferMemoryBarrierCount, BufferMemoryBarrier* bufferMemoryBarriers, uint imageMemoryBarrierCount, ImageMemoryBarrier* imageMemoryBarriers);

        public unsafe void BeginQuery(QueryPool queryPool, uint query, QueryControlFlags flags)
        {
            vkCmdBeginQuery(this, queryPool, query, flags);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBeginQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query, QueryControlFlags flags);

        public unsafe void EndQuery(QueryPool queryPool, uint query)
        {
            vkCmdEndQuery(this, queryPool, query);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdEndQuery(CommandBuffer commandBuffer, QueryPool queryPool, uint query);

        public unsafe void ResetQueryPool(QueryPool queryPool, uint firstQuery, uint queryCount)
        {
            vkCmdResetQueryPool(this, queryPool, firstQuery, queryCount);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdResetQueryPool(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount);

        public unsafe void WriteTimestamp(PipelineStageFlags pipelineStage, QueryPool queryPool, uint query)
        {
            vkCmdWriteTimestamp(this, pipelineStage, queryPool, query);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdWriteTimestamp(CommandBuffer commandBuffer, PipelineStageFlags pipelineStage, QueryPool queryPool, uint query);

        public unsafe void CopyQueryPoolResults(QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags flags)
        {
            vkCmdCopyQueryPoolResults(this, queryPool, firstQuery, queryCount, destinationBuffer, destinationOffset, stride, flags);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdCopyQueryPoolResults(CommandBuffer commandBuffer, QueryPool queryPool, uint firstQuery, uint queryCount, Buffer destinationBuffer, ulong destinationOffset, ulong stride, QueryResultFlags flags);

        public unsafe void PushConstants(PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, IntPtr values)
        {
            vkCmdPushConstants(this, layout, stageFlags, offset, size, values);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdPushConstants(CommandBuffer commandBuffer, PipelineLayout layout, ShaderStageFlags stageFlags, uint offset, uint size, IntPtr values);

        public unsafe void BeginRenderPass(ref RenderPassBeginInfo renderPassBegin, SubpassContents contents)
        {
            fixed (RenderPassBeginInfo* __renderPassBegin__ = &renderPassBegin)
            {
                vkCmdBeginRenderPass(this, __renderPassBegin__, contents);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdBeginRenderPass(CommandBuffer commandBuffer, RenderPassBeginInfo* renderPassBegin, SubpassContents contents);

        public unsafe void NextSubpass(SubpassContents contents)
        {
            vkCmdNextSubpass(this, contents);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdNextSubpass(CommandBuffer commandBuffer, SubpassContents contents);

        public unsafe void EndRenderPass()
        {
            vkCmdEndRenderPass(this);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdEndRenderPass(CommandBuffer commandBuffer);

        public unsafe void ExecuteCommands(uint commandBufferCount, CommandBuffer* commandBuffers)
        {
            vkCmdExecuteCommands(this, commandBufferCount, commandBuffers);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdExecuteCommands(CommandBuffer commandBuffer, uint commandBufferCount, CommandBuffer* commandBuffers);

        public unsafe void DebugMarkerBegin(ref DebugMarkerMarkerInfo markerInfo)
        {
            fixed (DebugMarkerMarkerInfo* __markerInfo__ = &markerInfo)
            {
                vkCmdDebugMarkerBeginEXT(this, __markerInfo__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDebugMarkerBeginEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);

        public unsafe void DebugMarkerEnd()
        {
            vkCmdDebugMarkerEndEXT(this);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDebugMarkerEndEXT(CommandBuffer commandBuffer);

        public unsafe void DebugMarkerInsert(ref DebugMarkerMarkerInfo markerInfo)
        {
            fixed (DebugMarkerMarkerInfo* __markerInfo__ = &markerInfo)
            {
                vkCmdDebugMarkerInsertEXT(this, __markerInfo__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDebugMarkerInsertEXT(CommandBuffer commandBuffer, DebugMarkerMarkerInfo* markerInfo);

        public unsafe void DrawIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            vkCmdDrawIndirectCountAMD(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDrawIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);

        public unsafe void DrawIndexedIndirectCount(Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride)
        {
            vkCmdDrawIndexedIndirectCountAMD(this, buffer, offset, countBuffer, countBufferOffset, maxDrawCount, stride);
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdDrawIndexedIndirectCountAMD(CommandBuffer commandBuffer, Buffer buffer, ulong offset, Buffer countBuffer, ulong countBufferOffset, uint maxDrawCount, uint stride);

        public unsafe void ProcessCommands(ref CommandProcessCommandsInfo processCommandsInfo)
        {
            fixed (CommandProcessCommandsInfo* __processCommandsInfo__ = &processCommandsInfo)
            {
                vkCmdProcessCommandsNVX(this, __processCommandsInfo__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdProcessCommandsNVX(CommandBuffer commandBuffer, CommandProcessCommandsInfo* processCommandsInfo);

        public unsafe void ReserveSpaceForCommands(ref CommandReserveSpaceForCommandsInfo reserveSpaceInfo)
        {
            fixed (CommandReserveSpaceForCommandsInfo* __reserveSpaceInfo__ = &reserveSpaceInfo)
            {
                vkCmdReserveSpaceForCommandsNVX(this, __reserveSpaceInfo__);
            }
        }

        [DllImport(Vulkan.LibraryName, CallingConvention = CallingConvention.StdCall)]
        [SuppressUnmanagedCodeSecurity]
        internal static extern unsafe void vkCmdReserveSpaceForCommandsNVX(CommandBuffer commandBuffer, CommandReserveSpaceForCommandsInfo* reserveSpaceInfo);
    }
}
