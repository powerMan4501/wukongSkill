using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_GSGameSettingsFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetXeSSPercentage_IsValid;

	private static IntPtr SetXeSSPercentage_FunctionAddress;

	private static int SetXeSSPercentage_ParamsSize;

	private static bool SetXeSSPercentage_Percentage_IsValid;

	private static FFieldAddress SetXeSSPercentage_Percentage_PropertyAddress;

	private static int SetXeSSPercentage_Percentage_Offset;

	private static bool SetRayTracingQuality_IsValid;

	private static IntPtr SetRayTracingQuality_FunctionAddress;

	private static int SetRayTracingQuality_ParamsSize;

	private static bool SetRayTracingQuality_RTXLevel_IsValid;

	private static FFieldAddress SetRayTracingQuality_RTXLevel_PropertyAddress;

	private static int SetRayTracingQuality_RTXLevel_Offset;

	private static bool IsLowFeatureLevelGPU_IsValid;

	private static IntPtr IsLowFeatureLevelGPU_FunctionAddress;

	private static int IsLowFeatureLevelGPU_ParamsSize;

	private static bool IsLowFeatureLevelGPU_ReturnValue_IsValid;

	private static FFieldAddress IsLowFeatureLevelGPU_ReturnValue_PropertyAddress;

	private static int IsLowFeatureLevelGPU_ReturnValue_Offset;

	private static bool GetRHIAdapterName_IsValid;

	private static IntPtr GetRHIAdapterName_FunctionAddress;

	private static int GetRHIAdapterName_ParamsSize;

	private static bool GetRHIAdapterName_ReturnValue_IsValid;

	private static FFieldAddress GetRHIAdapterName_ReturnValue_PropertyAddress;

	private static int GetRHIAdapterName_ReturnValue_Offset;

	private static bool GetMainMonitorID_IsValid;

	private static IntPtr GetMainMonitorID_FunctionAddress;

	private static int GetMainMonitorID_ParamsSize;

	private static bool GetMainMonitorID_ReturnValue_IsValid;

	private static FFieldAddress GetMainMonitorID_ReturnValue_PropertyAddress;

	private static int GetMainMonitorID_ReturnValue_Offset;

	private static bool GetIsPS5Pro_IsValid;

	private static IntPtr GetIsPS5Pro_FunctionAddress;

	private static int GetIsPS5Pro_ParamsSize;

	private static bool GetIsPS5Pro_ReturnValue_IsValid;

	private static FFieldAddress GetIsPS5Pro_ReturnValue_PropertyAddress;

	private static int GetIsPS5Pro_ReturnValue_Offset;

	private static bool GetIsHDRViewport_IsValid;

	private static IntPtr GetIsHDRViewport_FunctionAddress;

	private static int GetIsHDRViewport_ParamsSize;

	private static bool GetIsHDRViewport_World_IsValid;

	private static FFieldAddress GetIsHDRViewport_World_PropertyAddress;

	private static int GetIsHDRViewport_World_Offset;

	private static bool GetIsHDRViewport_ReturnValue_IsValid;

	private static FFieldAddress GetIsHDRViewport_ReturnValue_PropertyAddress;

	private static int GetIsHDRViewport_ReturnValue_Offset;

	private static bool GetGRHISupportsRayTracing_IsValid;

	private static IntPtr GetGRHISupportsRayTracing_FunctionAddress;

	private static int GetGRHISupportsRayTracing_ParamsSize;

	private static bool GetGRHISupportsRayTracing_ReturnValue_IsValid;

	private static FFieldAddress GetGRHISupportsRayTracing_ReturnValue_PropertyAddress;

	private static int GetGRHISupportsRayTracing_ReturnValue_Offset;

	private static bool GetDefaultLanguage_IsValid;

	private static IntPtr GetDefaultLanguage_FunctionAddress;

	private static int GetDefaultLanguage_ParamsSize;

	private static bool GetDefaultLanguage_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultLanguage_ReturnValue_PropertyAddress;

	private static int GetDefaultLanguage_ReturnValue_Offset;

	private static bool GetCurGameMainScreen_IsValid;

	private static IntPtr GetCurGameMainScreen_FunctionAddress;

	private static int GetCurGameMainScreen_ParamsSize;

	private static bool GetCurGameMainScreen_ReturnValue_IsValid;

	private static FFieldAddress GetCurGameMainScreen_ReturnValue_PropertyAddress;

	private static int GetCurGameMainScreen_ReturnValue_Offset;

	private static bool ApplyGSGameSettings_IsValid;

	private static IntPtr ApplyGSGameSettings_FunctionAddress;

	private static int ApplyGSGameSettings_ParamsSize;

	private static bool ApplyGSGameSettings_bSaveSettings_IsValid;

	private static FFieldAddress ApplyGSGameSettings_bSaveSettings_PropertyAddress;

	private static int ApplyGSGameSettings_bSaveSettings_Offset;

	private static bool ApplyGSGameResolutionSettings_IsValid;

	private static IntPtr ApplyGSGameResolutionSettings_FunctionAddress;

	private static int ApplyGSGameResolutionSettings_ParamsSize;

	private static bool ApplyGSGameResolutionSettings_bSaveSettings_IsValid;

	private static FFieldAddress ApplyGSGameResolutionSettings_bSaveSettings_PropertyAddress;

	private static int ApplyGSGameResolutionSettings_bSaveSettings_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetXeSSPercentage")]
	public unsafe static void SetXeSSPercentage(float Percentage)
	{
		if (!SetXeSSPercentage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetXeSSPercentage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetXeSSPercentage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetXeSSPercentage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetXeSSPercentage_Percentage_Offset), 0, SetXeSSPercentage_Percentage_PropertyAddress.Address, Percentage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetXeSSPercentage_FunctionAddress, intPtr, SetXeSSPercentage_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetRayTracingQuality")]
	public unsafe static void SetRayTracingQuality(int RTXLevel)
	{
		if (!SetRayTracingQuality_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetRayTracingQuality");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRayTracingQuality_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRayTracingQuality_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetRayTracingQuality_RTXLevel_Offset), 0, SetRayTracingQuality_RTXLevel_PropertyAddress.Address, RTXLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetRayTracingQuality_FunctionAddress, intPtr, SetRayTracingQuality_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:IsLowFeatureLevelGPU")]
	public unsafe static bool IsLowFeatureLevelGPU()
	{
		if (!IsLowFeatureLevelGPU_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:IsLowFeatureLevelGPU");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLowFeatureLevelGPU_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLowFeatureLevelGPU_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsLowFeatureLevelGPU_FunctionAddress, intPtr, IsLowFeatureLevelGPU_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLowFeatureLevelGPU_ReturnValue_Offset), 0, IsLowFeatureLevelGPU_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetRHIAdapterName")]
	public unsafe static string GetRHIAdapterName()
	{
		if (!GetRHIAdapterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetRHIAdapterName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRHIAdapterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRHIAdapterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRHIAdapterName_FunctionAddress, intPtr, GetRHIAdapterName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetRHIAdapterName_ReturnValue_Offset), 0, GetRHIAdapterName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRHIAdapterName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetMainMonitorID")]
	public unsafe static string GetMainMonitorID()
	{
		if (!GetMainMonitorID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetMainMonitorID");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMainMonitorID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMainMonitorID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMainMonitorID_FunctionAddress, intPtr, GetMainMonitorID_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMainMonitorID_ReturnValue_Offset), 0, GetMainMonitorID_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMainMonitorID_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsPS5Pro")]
	public unsafe static bool GetIsPS5Pro()
	{
		if (!GetIsPS5Pro_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsPS5Pro");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsPS5Pro_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsPS5Pro_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsPS5Pro_FunctionAddress, intPtr, GetIsPS5Pro_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsPS5Pro_ReturnValue_Offset), 0, GetIsPS5Pro_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsHDRViewport")]
	public unsafe static bool GetIsHDRViewport(UWorld World)
	{
		if (!GetIsHDRViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsHDRViewport");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsHDRViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsHDRViewport_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetIsHDRViewport_World_Offset), 0, GetIsHDRViewport_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsHDRViewport_FunctionAddress, intPtr, GetIsHDRViewport_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsHDRViewport_ReturnValue_Offset), 0, GetIsHDRViewport_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetGRHISupportsRayTracing")]
	public unsafe static bool GetGRHISupportsRayTracing()
	{
		if (!GetGRHISupportsRayTracing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetGRHISupportsRayTracing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGRHISupportsRayTracing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGRHISupportsRayTracing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGRHISupportsRayTracing_FunctionAddress, intPtr, GetGRHISupportsRayTracing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGRHISupportsRayTracing_ReturnValue_Offset), 0, GetGRHISupportsRayTracing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetDefaultLanguage")]
	public unsafe static string GetDefaultLanguage()
	{
		if (!GetDefaultLanguage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetDefaultLanguage");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultLanguage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultLanguage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultLanguage_FunctionAddress, intPtr, GetDefaultLanguage_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDefaultLanguage_ReturnValue_Offset), 0, GetDefaultLanguage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDefaultLanguage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetCurGameMainScreen")]
	public unsafe static int GetCurGameMainScreen()
	{
		if (!GetCurGameMainScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetCurGameMainScreen");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurGameMainScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurGameMainScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurGameMainScreen_FunctionAddress, intPtr, GetCurGameMainScreen_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurGameMainScreen_ReturnValue_Offset), 0, GetCurGameMainScreen_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameSettings")]
	public unsafe static void ApplyGSGameSettings(bool bSaveSettings)
	{
		if (!ApplyGSGameSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyGSGameSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyGSGameSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyGSGameSettings_bSaveSettings_Offset), 0, ApplyGSGameSettings_bSaveSettings_PropertyAddress.Address, bSaveSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyGSGameSettings_FunctionAddress, intPtr, ApplyGSGameSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameResolutionSettings")]
	public unsafe static void ApplyGSGameResolutionSettings(bool bSaveSettings)
	{
		if (!ApplyGSGameResolutionSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameResolutionSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyGSGameResolutionSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyGSGameResolutionSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyGSGameResolutionSettings_bSaveSettings_Offset), 0, ApplyGSGameResolutionSettings_bSaveSettings_PropertyAddress.Address, bSaveSettings);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyGSGameResolutionSettings_FunctionAddress, intPtr, ApplyGSGameResolutionSettings_ParamsSize);
	}

	static UGSE_GSGameSettingsFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_GSGameSettingsFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_GSGameSettingsFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib");
		SetXeSSPercentage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetXeSSPercentage");
		SetXeSSPercentage_ParamsSize = NativeReflection.GetFunctionParamsSize(SetXeSSPercentage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetXeSSPercentage_Percentage_PropertyAddress, SetXeSSPercentage_FunctionAddress, "Percentage");
		SetXeSSPercentage_Percentage_Offset = NativeReflectionCached.GetPropertyOffset(SetXeSSPercentage_FunctionAddress, "Percentage");
		SetXeSSPercentage_Percentage_IsValid = NativeReflectionCached.ValidatePropertyClass(SetXeSSPercentage_FunctionAddress, "Percentage", Classes.FFloatProperty);
		SetXeSSPercentage_IsValid = SetXeSSPercentage_FunctionAddress != IntPtr.Zero && SetXeSSPercentage_Percentage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetXeSSPercentage", SetXeSSPercentage_IsValid);
		SetRayTracingQuality_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetRayTracingQuality");
		SetRayTracingQuality_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRayTracingQuality_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRayTracingQuality_RTXLevel_PropertyAddress, SetRayTracingQuality_FunctionAddress, "RTXLevel");
		SetRayTracingQuality_RTXLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetRayTracingQuality_FunctionAddress, "RTXLevel");
		SetRayTracingQuality_RTXLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRayTracingQuality_FunctionAddress, "RTXLevel", Classes.FIntProperty);
		SetRayTracingQuality_IsValid = SetRayTracingQuality_FunctionAddress != IntPtr.Zero && SetRayTracingQuality_RTXLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:SetRayTracingQuality", SetRayTracingQuality_IsValid);
		IsLowFeatureLevelGPU_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsLowFeatureLevelGPU");
		IsLowFeatureLevelGPU_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLowFeatureLevelGPU_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLowFeatureLevelGPU_ReturnValue_PropertyAddress, IsLowFeatureLevelGPU_FunctionAddress, "ReturnValue");
		IsLowFeatureLevelGPU_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLowFeatureLevelGPU_FunctionAddress, "ReturnValue");
		IsLowFeatureLevelGPU_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLowFeatureLevelGPU_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLowFeatureLevelGPU_IsValid = IsLowFeatureLevelGPU_FunctionAddress != IntPtr.Zero && IsLowFeatureLevelGPU_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:IsLowFeatureLevelGPU", IsLowFeatureLevelGPU_IsValid);
		GetRHIAdapterName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRHIAdapterName");
		GetRHIAdapterName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRHIAdapterName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRHIAdapterName_ReturnValue_PropertyAddress, GetRHIAdapterName_FunctionAddress, "ReturnValue");
		GetRHIAdapterName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRHIAdapterName_FunctionAddress, "ReturnValue");
		GetRHIAdapterName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRHIAdapterName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetRHIAdapterName_IsValid = GetRHIAdapterName_FunctionAddress != IntPtr.Zero && GetRHIAdapterName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetRHIAdapterName", GetRHIAdapterName_IsValid);
		GetMainMonitorID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMainMonitorID");
		GetMainMonitorID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMainMonitorID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMainMonitorID_ReturnValue_PropertyAddress, GetMainMonitorID_FunctionAddress, "ReturnValue");
		GetMainMonitorID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMainMonitorID_FunctionAddress, "ReturnValue");
		GetMainMonitorID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMainMonitorID_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMainMonitorID_IsValid = GetMainMonitorID_FunctionAddress != IntPtr.Zero && GetMainMonitorID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetMainMonitorID", GetMainMonitorID_IsValid);
		GetIsPS5Pro_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsPS5Pro");
		GetIsPS5Pro_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsPS5Pro_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsPS5Pro_ReturnValue_PropertyAddress, GetIsPS5Pro_FunctionAddress, "ReturnValue");
		GetIsPS5Pro_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsPS5Pro_FunctionAddress, "ReturnValue");
		GetIsPS5Pro_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsPS5Pro_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsPS5Pro_IsValid = GetIsPS5Pro_FunctionAddress != IntPtr.Zero && GetIsPS5Pro_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsPS5Pro", GetIsPS5Pro_IsValid);
		GetIsHDRViewport_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsHDRViewport");
		GetIsHDRViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsHDRViewport_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsHDRViewport_World_PropertyAddress, GetIsHDRViewport_FunctionAddress, "World");
		GetIsHDRViewport_World_Offset = NativeReflectionCached.GetPropertyOffset(GetIsHDRViewport_FunctionAddress, "World");
		GetIsHDRViewport_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsHDRViewport_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsHDRViewport_ReturnValue_PropertyAddress, GetIsHDRViewport_FunctionAddress, "ReturnValue");
		GetIsHDRViewport_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsHDRViewport_FunctionAddress, "ReturnValue");
		GetIsHDRViewport_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsHDRViewport_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsHDRViewport_IsValid = GetIsHDRViewport_FunctionAddress != IntPtr.Zero && GetIsHDRViewport_World_IsValid && GetIsHDRViewport_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetIsHDRViewport", GetIsHDRViewport_IsValid);
		GetGRHISupportsRayTracing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGRHISupportsRayTracing");
		GetGRHISupportsRayTracing_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGRHISupportsRayTracing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGRHISupportsRayTracing_ReturnValue_PropertyAddress, GetGRHISupportsRayTracing_FunctionAddress, "ReturnValue");
		GetGRHISupportsRayTracing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGRHISupportsRayTracing_FunctionAddress, "ReturnValue");
		GetGRHISupportsRayTracing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGRHISupportsRayTracing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGRHISupportsRayTracing_IsValid = GetGRHISupportsRayTracing_FunctionAddress != IntPtr.Zero && GetGRHISupportsRayTracing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetGRHISupportsRayTracing", GetGRHISupportsRayTracing_IsValid);
		GetDefaultLanguage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultLanguage");
		GetDefaultLanguage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultLanguage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultLanguage_ReturnValue_PropertyAddress, GetDefaultLanguage_FunctionAddress, "ReturnValue");
		GetDefaultLanguage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultLanguage_FunctionAddress, "ReturnValue");
		GetDefaultLanguage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultLanguage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDefaultLanguage_IsValid = GetDefaultLanguage_FunctionAddress != IntPtr.Zero && GetDefaultLanguage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetDefaultLanguage", GetDefaultLanguage_IsValid);
		GetCurGameMainScreen_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurGameMainScreen");
		GetCurGameMainScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurGameMainScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurGameMainScreen_ReturnValue_PropertyAddress, GetCurGameMainScreen_FunctionAddress, "ReturnValue");
		GetCurGameMainScreen_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurGameMainScreen_FunctionAddress, "ReturnValue");
		GetCurGameMainScreen_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurGameMainScreen_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurGameMainScreen_IsValid = GetCurGameMainScreen_FunctionAddress != IntPtr.Zero && GetCurGameMainScreen_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:GetCurGameMainScreen", GetCurGameMainScreen_IsValid);
		ApplyGSGameSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyGSGameSettings");
		ApplyGSGameSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyGSGameSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyGSGameSettings_bSaveSettings_PropertyAddress, ApplyGSGameSettings_FunctionAddress, "bSaveSettings");
		ApplyGSGameSettings_bSaveSettings_Offset = NativeReflectionCached.GetPropertyOffset(ApplyGSGameSettings_FunctionAddress, "bSaveSettings");
		ApplyGSGameSettings_bSaveSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyGSGameSettings_FunctionAddress, "bSaveSettings", Classes.FBoolProperty);
		ApplyGSGameSettings_IsValid = ApplyGSGameSettings_FunctionAddress != IntPtr.Zero && ApplyGSGameSettings_bSaveSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameSettings", ApplyGSGameSettings_IsValid);
		ApplyGSGameResolutionSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyGSGameResolutionSettings");
		ApplyGSGameResolutionSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyGSGameResolutionSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyGSGameResolutionSettings_bSaveSettings_PropertyAddress, ApplyGSGameResolutionSettings_FunctionAddress, "bSaveSettings");
		ApplyGSGameResolutionSettings_bSaveSettings_Offset = NativeReflectionCached.GetPropertyOffset(ApplyGSGameResolutionSettings_FunctionAddress, "bSaveSettings");
		ApplyGSGameResolutionSettings_bSaveSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyGSGameResolutionSettings_FunctionAddress, "bSaveSettings", Classes.FBoolProperty);
		ApplyGSGameResolutionSettings_IsValid = ApplyGSGameResolutionSettings_FunctionAddress != IntPtr.Zero && ApplyGSGameResolutionSettings_bSaveSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_GSGameSettingsFuncLib:ApplyGSGameResolutionSettings", ApplyGSGameResolutionSettings_IsValid);
	}
}
