using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.StreamlineBlueprint;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibrary", "StreamlineBlueprint", UnrealModuleType.EnginePlugin)]
public class UStreamlineLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool QueryStreamlineFeatureSupport_IsValid;

	private static IntPtr QueryStreamlineFeatureSupport_FunctionAddress;

	private static int QueryStreamlineFeatureSupport_ParamsSize;

	private static bool QueryStreamlineFeatureSupport_Feature_IsValid;

	private static FFieldAddress QueryStreamlineFeatureSupport_Feature_PropertyAddress;

	private static int QueryStreamlineFeatureSupport_Feature_Offset;

	private static bool QueryStreamlineFeatureSupport_ReturnValue_IsValid;

	private static FFieldAddress QueryStreamlineFeatureSupport_ReturnValue_PropertyAddress;

	private static int QueryStreamlineFeatureSupport_ReturnValue_Offset;

	private static bool IsStreamlineFeatureSupported_IsValid;

	private static IntPtr IsStreamlineFeatureSupported_FunctionAddress;

	private static int IsStreamlineFeatureSupported_ParamsSize;

	private static bool IsStreamlineFeatureSupported_Feature_IsValid;

	private static FFieldAddress IsStreamlineFeatureSupported_Feature_PropertyAddress;

	private static int IsStreamlineFeatureSupported_Feature_Offset;

	private static bool IsStreamlineFeatureSupported_ReturnValue_IsValid;

	private static FFieldAddress IsStreamlineFeatureSupported_ReturnValue_PropertyAddress;

	private static int IsStreamlineFeatureSupported_ReturnValue_Offset;

	private static bool GetStreamlineFeatureInformation_IsValid;

	private static IntPtr GetStreamlineFeatureInformation_FunctionAddress;

	private static int GetStreamlineFeatureInformation_ParamsSize;

	private static bool GetStreamlineFeatureInformation_Feature_IsValid;

	private static FFieldAddress GetStreamlineFeatureInformation_Feature_PropertyAddress;

	private static int GetStreamlineFeatureInformation_Feature_Offset;

	private static bool GetStreamlineFeatureInformation_ReturnValue_IsValid;

	private static FFieldAddress GetStreamlineFeatureInformation_ReturnValue_PropertyAddress;

	private static int GetStreamlineFeatureInformation_ReturnValue_Offset;

	private static bool BreakStreamlineFeatureRequirements_IsValid;

	private static IntPtr BreakStreamlineFeatureRequirements_FunctionAddress;

	private static int BreakStreamlineFeatureRequirements_ParamsSize;

	private static bool BreakStreamlineFeatureRequirements_Requirements_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_Requirements_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_Requirements_Offset;

	private static bool BreakStreamlineFeatureRequirements_D3D11Supported_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_D3D11Supported_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_D3D11Supported_Offset;

	private static bool BreakStreamlineFeatureRequirements_D3D12Supported_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_D3D12Supported_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_D3D12Supported_Offset;

	private static bool BreakStreamlineFeatureRequirements_VulkanSupported_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_VulkanSupported_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_VulkanSupported_Offset;

	private static bool BreakStreamlineFeatureRequirements_VSyncOffRequired_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_VSyncOffRequired_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_VSyncOffRequired_Offset;

	private static bool BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_IsValid;

	private static FFieldAddress BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_PropertyAddress;

	private static int BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_Offset;

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibrary:QueryStreamlineFeatureSupport")]
	public unsafe static EUStreamlineFeatureSupport QueryStreamlineFeatureSupport(EUStreamlineFeature Feature)
	{
		if (!QueryStreamlineFeatureSupport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibrary:QueryStreamlineFeatureSupport");
			return EUStreamlineFeatureSupport.Supported;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryStreamlineFeatureSupport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryStreamlineFeatureSupport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineFeature>.ToNative(IntPtr.Add(intPtr, QueryStreamlineFeatureSupport_Feature_Offset), 0, QueryStreamlineFeatureSupport_Feature_PropertyAddress.Address, Feature);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryStreamlineFeatureSupport_FunctionAddress, intPtr, QueryStreamlineFeatureSupport_ParamsSize);
		return EnumMarshaler<EUStreamlineFeatureSupport>.FromNative(IntPtr.Add(intPtr, QueryStreamlineFeatureSupport_ReturnValue_Offset), 0, QueryStreamlineFeatureSupport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibrary:IsStreamlineFeatureSupported")]
	public unsafe static bool IsStreamlineFeatureSupported(EUStreamlineFeature Feature)
	{
		if (!IsStreamlineFeatureSupported_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibrary:IsStreamlineFeatureSupported");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStreamlineFeatureSupported_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStreamlineFeatureSupported_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineFeature>.ToNative(IntPtr.Add(intPtr, IsStreamlineFeatureSupported_Feature_Offset), 0, IsStreamlineFeatureSupported_Feature_PropertyAddress.Address, Feature);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStreamlineFeatureSupported_FunctionAddress, intPtr, IsStreamlineFeatureSupported_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStreamlineFeatureSupported_ReturnValue_Offset), 0, IsStreamlineFeatureSupported_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684611u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibrary:GetStreamlineFeatureInformation")]
	public unsafe static FStreamlineFeatureRequirements GetStreamlineFeatureInformation(EUStreamlineFeature Feature)
	{
		if (!GetStreamlineFeatureInformation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibrary:GetStreamlineFeatureInformation");
			return default(FStreamlineFeatureRequirements);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStreamlineFeatureInformation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStreamlineFeatureInformation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineFeature>.ToNative(IntPtr.Add(intPtr, GetStreamlineFeatureInformation_Feature_Offset), 0, GetStreamlineFeatureInformation_Feature_PropertyAddress.Address, Feature);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStreamlineFeatureInformation_FunctionAddress, intPtr, GetStreamlineFeatureInformation_ParamsSize);
		return FStreamlineFeatureRequirements.FromNative(IntPtr.Add(intPtr, GetStreamlineFeatureInformation_ReturnValue_Offset), 0, GetStreamlineFeatureInformation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878915u)]
	[UMetaPath("/Script/StreamlineBlueprint.StreamlineLibrary:BreakStreamlineFeatureRequirements")]
	public unsafe static void BreakStreamlineFeatureRequirements(EUStreamlineFeatureRequirementsFlags Requirements, out bool D3D11Supported, out bool D3D12Supported, out bool VulkanSupported, out bool VSyncOffRequired, out bool HardwareSchedulingRequired)
	{
		if (!BreakStreamlineFeatureRequirements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/StreamlineBlueprint.StreamlineLibrary:BreakStreamlineFeatureRequirements");
			D3D11Supported = false;
			D3D12Supported = false;
			VulkanSupported = false;
			VSyncOffRequired = false;
			HardwareSchedulingRequired = false;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakStreamlineFeatureRequirements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakStreamlineFeatureRequirements_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUStreamlineFeatureRequirementsFlags>.ToNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_Requirements_Offset), 0, BreakStreamlineFeatureRequirements_Requirements_PropertyAddress.Address, Requirements);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakStreamlineFeatureRequirements_FunctionAddress, intPtr, BreakStreamlineFeatureRequirements_ParamsSize);
		D3D11Supported = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_D3D11Supported_Offset), 0, BreakStreamlineFeatureRequirements_D3D11Supported_PropertyAddress.Address);
		D3D12Supported = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_D3D12Supported_Offset), 0, BreakStreamlineFeatureRequirements_D3D12Supported_PropertyAddress.Address);
		VulkanSupported = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_VulkanSupported_Offset), 0, BreakStreamlineFeatureRequirements_VulkanSupported_PropertyAddress.Address);
		VSyncOffRequired = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_VSyncOffRequired_Offset), 0, BreakStreamlineFeatureRequirements_VSyncOffRequired_PropertyAddress.Address);
		HardwareSchedulingRequired = BoolMarshaler.FromNative(IntPtr.Add(intPtr, BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_Offset), 0, BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_PropertyAddress.Address);
	}

	static UStreamlineLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamlineLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamlineLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/StreamlineBlueprint.StreamlineLibrary");
		QueryStreamlineFeatureSupport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryStreamlineFeatureSupport");
		QueryStreamlineFeatureSupport_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryStreamlineFeatureSupport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryStreamlineFeatureSupport_Feature_PropertyAddress, QueryStreamlineFeatureSupport_FunctionAddress, "Feature");
		QueryStreamlineFeatureSupport_Feature_Offset = NativeReflectionCached.GetPropertyOffset(QueryStreamlineFeatureSupport_FunctionAddress, "Feature");
		QueryStreamlineFeatureSupport_Feature_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryStreamlineFeatureSupport_FunctionAddress, "Feature", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryStreamlineFeatureSupport_ReturnValue_PropertyAddress, QueryStreamlineFeatureSupport_FunctionAddress, "ReturnValue");
		QueryStreamlineFeatureSupport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryStreamlineFeatureSupport_FunctionAddress, "ReturnValue");
		QueryStreamlineFeatureSupport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryStreamlineFeatureSupport_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		QueryStreamlineFeatureSupport_IsValid = QueryStreamlineFeatureSupport_FunctionAddress != IntPtr.Zero && QueryStreamlineFeatureSupport_Feature_IsValid && QueryStreamlineFeatureSupport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibrary:QueryStreamlineFeatureSupport", QueryStreamlineFeatureSupport_IsValid);
		IsStreamlineFeatureSupported_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStreamlineFeatureSupported");
		IsStreamlineFeatureSupported_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStreamlineFeatureSupported_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStreamlineFeatureSupported_Feature_PropertyAddress, IsStreamlineFeatureSupported_FunctionAddress, "Feature");
		IsStreamlineFeatureSupported_Feature_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamlineFeatureSupported_FunctionAddress, "Feature");
		IsStreamlineFeatureSupported_Feature_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamlineFeatureSupported_FunctionAddress, "Feature", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsStreamlineFeatureSupported_ReturnValue_PropertyAddress, IsStreamlineFeatureSupported_FunctionAddress, "ReturnValue");
		IsStreamlineFeatureSupported_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStreamlineFeatureSupported_FunctionAddress, "ReturnValue");
		IsStreamlineFeatureSupported_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStreamlineFeatureSupported_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStreamlineFeatureSupported_IsValid = IsStreamlineFeatureSupported_FunctionAddress != IntPtr.Zero && IsStreamlineFeatureSupported_Feature_IsValid && IsStreamlineFeatureSupported_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibrary:IsStreamlineFeatureSupported", IsStreamlineFeatureSupported_IsValid);
		GetStreamlineFeatureInformation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStreamlineFeatureInformation");
		GetStreamlineFeatureInformation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStreamlineFeatureInformation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStreamlineFeatureInformation_Feature_PropertyAddress, GetStreamlineFeatureInformation_FunctionAddress, "Feature");
		GetStreamlineFeatureInformation_Feature_Offset = NativeReflectionCached.GetPropertyOffset(GetStreamlineFeatureInformation_FunctionAddress, "Feature");
		GetStreamlineFeatureInformation_Feature_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStreamlineFeatureInformation_FunctionAddress, "Feature", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStreamlineFeatureInformation_ReturnValue_PropertyAddress, GetStreamlineFeatureInformation_FunctionAddress, "ReturnValue");
		GetStreamlineFeatureInformation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStreamlineFeatureInformation_FunctionAddress, "ReturnValue");
		GetStreamlineFeatureInformation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStreamlineFeatureInformation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStreamlineFeatureInformation_IsValid = GetStreamlineFeatureInformation_FunctionAddress != IntPtr.Zero && GetStreamlineFeatureInformation_Feature_IsValid && GetStreamlineFeatureInformation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibrary:GetStreamlineFeatureInformation", GetStreamlineFeatureInformation_IsValid);
		BreakStreamlineFeatureRequirements_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakStreamlineFeatureRequirements");
		BreakStreamlineFeatureRequirements_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakStreamlineFeatureRequirements_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_Requirements_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "Requirements");
		BreakStreamlineFeatureRequirements_Requirements_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "Requirements");
		BreakStreamlineFeatureRequirements_Requirements_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "Requirements", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_D3D11Supported_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "D3D11Supported");
		BreakStreamlineFeatureRequirements_D3D11Supported_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "D3D11Supported");
		BreakStreamlineFeatureRequirements_D3D11Supported_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "D3D11Supported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_D3D12Supported_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "D3D12Supported");
		BreakStreamlineFeatureRequirements_D3D12Supported_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "D3D12Supported");
		BreakStreamlineFeatureRequirements_D3D12Supported_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "D3D12Supported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_VulkanSupported_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "VulkanSupported");
		BreakStreamlineFeatureRequirements_VulkanSupported_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "VulkanSupported");
		BreakStreamlineFeatureRequirements_VulkanSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "VulkanSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_VSyncOffRequired_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "VSyncOffRequired");
		BreakStreamlineFeatureRequirements_VSyncOffRequired_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "VSyncOffRequired");
		BreakStreamlineFeatureRequirements_VSyncOffRequired_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "VSyncOffRequired", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_PropertyAddress, BreakStreamlineFeatureRequirements_FunctionAddress, "HardwareSchedulingRequired");
		BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_Offset = NativeReflectionCached.GetPropertyOffset(BreakStreamlineFeatureRequirements_FunctionAddress, "HardwareSchedulingRequired");
		BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakStreamlineFeatureRequirements_FunctionAddress, "HardwareSchedulingRequired", Classes.FBoolProperty);
		BreakStreamlineFeatureRequirements_IsValid = BreakStreamlineFeatureRequirements_FunctionAddress != IntPtr.Zero && BreakStreamlineFeatureRequirements_Requirements_IsValid && BreakStreamlineFeatureRequirements_D3D11Supported_IsValid && BreakStreamlineFeatureRequirements_D3D12Supported_IsValid && BreakStreamlineFeatureRequirements_VulkanSupported_IsValid && BreakStreamlineFeatureRequirements_VSyncOffRequired_IsValid && BreakStreamlineFeatureRequirements_HardwareSchedulingRequired_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/StreamlineBlueprint.StreamlineLibrary:BreakStreamlineFeatureRequirements", BreakStreamlineFeatureRequirements_IsValid);
	}
}
