// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.ANDROID
{
    [Extension("VK_ANDROID_external_memory_android_hardware_buffer")]
    public unsafe partial class AndroidExternalMemoryAndroidHardwareBuffer : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_ANDROID_external_memory_android_hardware_buffer";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID")]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] IntPtr* buffer, [Count(Count = 0), Flow(FlowDirection.Out)] AndroidHardwareBufferPropertiesANDROID* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID")]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] IntPtr* buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out AndroidHardwareBufferPropertiesANDROID pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID")]
        public unsafe partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in IntPtr buffer, [Count(Count = 0), Flow(FlowDirection.Out)] AndroidHardwareBufferPropertiesANDROID* pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetAndroidHardwareBufferPropertiesANDROID")]
        public partial Result GetAndroidHardwareBufferProperties([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in IntPtr buffer, [Count(Count = 0), Flow(FlowDirection.Out)] out AndroidHardwareBufferPropertiesANDROID pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID")]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID")]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetAndroidHardwareBufferInfoANDROID* pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID")]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetAndroidHardwareBufferInfoANDROID pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryAndroidHardwareBufferANDROID")]
        public unsafe partial Result GetMemoryAndroidHardwareBuffer([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetAndroidHardwareBufferInfoANDROID pInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr* pBuffer);

        public AndroidExternalMemoryAndroidHardwareBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

