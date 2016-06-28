// Copyright (c) 2016 Jörg Wollenschläger
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace SharpVulkan
{
    public static partial class Vulkan
    {
        public static readonly Version ApiVersion = new Version(1, 0, 5);

        public const uint RemainingMipLevels = ~0U;

        public const uint RemainingArrayLayers = ~0U;

        public const ulong WholeSize = ~0UL;

        public const uint AttachmentUnused = ~0U;

        public const uint QueueFamilyIgnored = ~0U;

        public static unsafe LayerProperties[] InstanceLayerProperties
        {
            get
            {
                uint count = 0;
                EnumerateInstanceLayerProperties(ref count, null);

                var result = new LayerProperties[count];
                if (count > 0)
                {
                    fixed (LayerProperties* resultPointer = &result[0])
                        EnumerateInstanceLayerProperties(ref count, resultPointer);
                }

                return result;
            }
        }

        public static unsafe ExtensionProperties[] GetInstanceExtensionProperties(string layerName = null)
        {
            var nativeString = layerName != null ? Marshal.StringToHGlobalAnsi(layerName) : IntPtr.Zero;
            try
            {
                uint count = 0;
                EnumerateInstanceExtensionProperties((byte*)nativeString, ref count, null);

                var result = new ExtensionProperties[count];
                if (count > 0)
                {
                    fixed (ExtensionProperties* resultPointer = &result[0])
                        EnumerateInstanceExtensionProperties((byte*)nativeString, ref count, resultPointer);
                }

                return result;
            }
            finally
            {
                Marshal.FreeHGlobal(nativeString);
            }
        }
    }
}
