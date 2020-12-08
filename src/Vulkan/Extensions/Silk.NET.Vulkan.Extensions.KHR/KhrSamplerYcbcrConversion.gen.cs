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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_sampler_ycbcr_conversion")]
    public unsafe partial class KhrSamplerYcbcrConversion : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_sampler_ycbcr_conversion";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public unsafe partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public partial Result CreateSamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SamplerYcbcrConversionCreateInfo pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out SamplerYcbcrConversion pYcbcrConversion);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        public unsafe partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        public partial void DestroySamplerYcbcrConversion([Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        public KhrSamplerYcbcrConversion(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

