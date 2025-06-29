using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public class UGSViewPortRatioUtil : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetForceRatioType_IsValid;

	private static IntPtr SetForceRatioType_FunctionAddress;

	private static int SetForceRatioType_ParamsSize;

	private static bool SetForceRatioType_NewType_IsValid;

	private static FFieldAddress SetForceRatioType_NewType_PropertyAddress;

	private static int SetForceRatioType_NewType_Offset;

	private static bool InitSetCfg_IsValid;

	private static IntPtr InitSetCfg_FunctionAddress;

	private static int InitSetCfg_ParamsSize;

	private static bool InitSetCfg_InCfgMaxRatioMin_IsValid;

	private static FFieldAddress InitSetCfg_InCfgMaxRatioMin_PropertyAddress;

	private static int InitSetCfg_InCfgMaxRatioMin_Offset;

	private static bool InitSetCfg_InCfgMaxRatioMax_IsValid;

	private static FFieldAddress InitSetCfg_InCfgMaxRatioMax_PropertyAddress;

	private static int InitSetCfg_InCfgMaxRatioMax_Offset;

	private static bool InitSetCfg_InCfgMinRatio_IsValid;

	private static FFieldAddress InitSetCfg_InCfgMinRatio_PropertyAddress;

	private static int InitSetCfg_InCfgMinRatio_Offset;

	private static bool InitSetCfg_InCfgRefHeightDPIScale_IsValid;

	private static FFieldAddress InitSetCfg_InCfgRefHeightDPIScale_PropertyAddress;

	private static int InitSetCfg_InCfgRefHeightDPIScale_Offset;

	private static bool GetForceRatioType_IsValid;

	private static IntPtr GetForceRatioType_FunctionAddress;

	private static int GetForceRatioType_ParamsSize;

	private static bool GetForceRatioType_ReturnValue_IsValid;

	private static FFieldAddress GetForceRatioType_ReturnValue_PropertyAddress;

	private static int GetForceRatioType_ReturnValue_Offset;

	private static bool CalcCameraRatioInnerWithRatioType_IsValid;

	private static IntPtr CalcCameraRatioInnerWithRatioType_FunctionAddress;

	private static int CalcCameraRatioInnerWithRatioType_ParamsSize;

	private static bool CalcCameraRatioInnerWithRatioType_RefViewPortWidth_IsValid;

	private static FFieldAddress CalcCameraRatioInnerWithRatioType_RefViewPortWidth_PropertyAddress;

	private static int CalcCameraRatioInnerWithRatioType_RefViewPortWidth_Offset;

	private static bool CalcCameraRatioInnerWithRatioType_RefViewPortHeight_IsValid;

	private static FFieldAddress CalcCameraRatioInnerWithRatioType_RefViewPortHeight_PropertyAddress;

	private static int CalcCameraRatioInnerWithRatioType_RefViewPortHeight_Offset;

	private static bool CalcCameraRatioInnerWithRatioType_InForceRatioType_IsValid;

	private static FFieldAddress CalcCameraRatioInnerWithRatioType_InForceRatioType_PropertyAddress;

	private static int CalcCameraRatioInnerWithRatioType_InForceRatioType_Offset;

	private static bool CalcCameraRatioInnerWithRatioType_TargetRatio_IsValid;

	private static FFieldAddress CalcCameraRatioInnerWithRatioType_TargetRatio_PropertyAddress;

	private static int CalcCameraRatioInnerWithRatioType_TargetRatio_Offset;

	private static bool CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_IsValid;

	private static FFieldAddress CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_PropertyAddress;

	private static int CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_Offset;

	private static bool CalcCameraRatioInner_IsValid;

	private static IntPtr CalcCameraRatioInner_FunctionAddress;

	private static int CalcCameraRatioInner_ParamsSize;

	private static bool CalcCameraRatioInner_RefViewPortWidth_IsValid;

	private static FFieldAddress CalcCameraRatioInner_RefViewPortWidth_PropertyAddress;

	private static int CalcCameraRatioInner_RefViewPortWidth_Offset;

	private static bool CalcCameraRatioInner_RefViewPortHeight_IsValid;

	private static FFieldAddress CalcCameraRatioInner_RefViewPortHeight_PropertyAddress;

	private static int CalcCameraRatioInner_RefViewPortHeight_Offset;

	private static bool CalcCameraRatioInner_TargetRatio_IsValid;

	private static FFieldAddress CalcCameraRatioInner_TargetRatio_PropertyAddress;

	private static int CalcCameraRatioInner_TargetRatio_Offset;

	private static bool CalcCameraRatioInner_ConstraintAspectRatioType_IsValid;

	private static FFieldAddress CalcCameraRatioInner_ConstraintAspectRatioType_PropertyAddress;

	private static int CalcCameraRatioInner_ConstraintAspectRatioType_Offset;

	private static bool CalcCachedData_IsValid;

	private static IntPtr CalcCachedData_FunctionAddress;

	private static int CalcCachedData_ParamsSize;

	private static bool CalcCachedData_WorldContext_IsValid;

	private static FFieldAddress CalcCachedData_WorldContext_PropertyAddress;

	private static int CalcCachedData_WorldContext_Offset;

	private static bool CalcCachedData_OutRefViewPortWidth_IsValid;

	private static FFieldAddress CalcCachedData_OutRefViewPortWidth_PropertyAddress;

	private static int CalcCachedData_OutRefViewPortWidth_Offset;

	private static bool CalcCachedData_OutRefViewPortHeight_IsValid;

	private static FFieldAddress CalcCachedData_OutRefViewPortHeight_PropertyAddress;

	private static int CalcCachedData_OutRefViewPortHeight_Offset;

	private static bool CalcCachedData_OutCfgMaxRatioMin_IsValid;

	private static FFieldAddress CalcCachedData_OutCfgMaxRatioMin_PropertyAddress;

	private static int CalcCachedData_OutCfgMaxRatioMin_Offset;

	private static bool CalcCachedData_OutCfgMaxRatioMax_IsValid;

	private static FFieldAddress CalcCachedData_OutCfgMaxRatioMax_PropertyAddress;

	private static int CalcCachedData_OutCfgMaxRatioMax_Offset;

	private static bool CalcCachedData_OutCfgMinRatio_IsValid;

	private static FFieldAddress CalcCachedData_OutCfgMinRatio_PropertyAddress;

	private static int CalcCachedData_OutCfgMinRatio_Offset;

	private static bool CalcCachedData_OutCfgRefHeightDPIScale_IsValid;

	private static FFieldAddress CalcCachedData_OutCfgRefHeightDPIScale_PropertyAddress;

	private static int CalcCachedData_OutCfgRefHeightDPIScale_Offset;

	private static bool CalcCachedData_OutForceRatioTye_IsValid;

	private static FFieldAddress CalcCachedData_OutForceRatioTye_PropertyAddress;

	private static int CalcCachedData_OutForceRatioTye_Offset;

	private static bool CalcCachedData_OutConstraintAspectRatioType_IsValid;

	private static FFieldAddress CalcCachedData_OutConstraintAspectRatioType_PropertyAddress;

	private static int CalcCachedData_OutConstraintAspectRatioType_Offset;

	private static bool CalcCachedData_OutRatio_IsValid;

	private static FFieldAddress CalcCachedData_OutRatio_PropertyAddress;

	private static int CalcCachedData_OutRatio_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:SetForceRatioType")]
	public unsafe static void SetForceRatioType(EGSForceRatioType NewType)
	{
		if (!SetForceRatioType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:SetForceRatioType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceRatioType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceRatioType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGSForceRatioType>.ToNative(IntPtr.Add(intPtr, SetForceRatioType_NewType_Offset), 0, SetForceRatioType_NewType_PropertyAddress.Address, NewType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetForceRatioType_FunctionAddress, intPtr, SetForceRatioType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:InitSetCfg")]
	public unsafe static void InitSetCfg(float InCfgMaxRatioMin, float InCfgMaxRatioMax, float InCfgMinRatio, float InCfgRefHeightDPIScale)
	{
		if (!InitSetCfg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:InitSetCfg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitSetCfg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitSetCfg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetCfg_InCfgMaxRatioMin_Offset), 0, InitSetCfg_InCfgMaxRatioMin_PropertyAddress.Address, InCfgMaxRatioMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetCfg_InCfgMaxRatioMax_Offset), 0, InitSetCfg_InCfgMaxRatioMax_PropertyAddress.Address, InCfgMaxRatioMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetCfg_InCfgMinRatio_Offset), 0, InitSetCfg_InCfgMinRatio_PropertyAddress.Address, InCfgMinRatio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InitSetCfg_InCfgRefHeightDPIScale_Offset), 0, InitSetCfg_InCfgRefHeightDPIScale_PropertyAddress.Address, InCfgRefHeightDPIScale);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InitSetCfg_FunctionAddress, intPtr, InitSetCfg_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:GetForceRatioType")]
	public unsafe static EGSForceRatioType GetForceRatioType()
	{
		if (!GetForceRatioType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:GetForceRatioType");
			return EGSForceRatioType.Auto;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForceRatioType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForceRatioType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetForceRatioType_FunctionAddress, intPtr, GetForceRatioType_ParamsSize);
		return EnumMarshaler<EGSForceRatioType>.FromNative(IntPtr.Add(intPtr, GetForceRatioType_ReturnValue_Offset), 0, GetForceRatioType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInnerWithRatioType")]
	public unsafe static void CalcCameraRatioInnerWithRatioType(int RefViewPortWidth, int RefViewPortHeight, EGSForceRatioType InForceRatioType, out float TargetRatio, out EGSConstraintAspectRatioType ConstraintAspectRatioType)
	{
		if (!CalcCameraRatioInnerWithRatioType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInnerWithRatioType");
			TargetRatio = 0f;
			ConstraintAspectRatioType = EGSConstraintAspectRatioType.None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcCameraRatioInnerWithRatioType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcCameraRatioInnerWithRatioType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalcCameraRatioInnerWithRatioType_RefViewPortWidth_Offset), 0, CalcCameraRatioInnerWithRatioType_RefViewPortWidth_PropertyAddress.Address, RefViewPortWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalcCameraRatioInnerWithRatioType_RefViewPortHeight_Offset), 0, CalcCameraRatioInnerWithRatioType_RefViewPortHeight_PropertyAddress.Address, RefViewPortHeight);
		EnumMarshaler<EGSForceRatioType>.ToNative(IntPtr.Add(intPtr, CalcCameraRatioInnerWithRatioType_InForceRatioType_Offset), 0, CalcCameraRatioInnerWithRatioType_InForceRatioType_PropertyAddress.Address, InForceRatioType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, intPtr, CalcCameraRatioInnerWithRatioType_ParamsSize);
		TargetRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCameraRatioInnerWithRatioType_TargetRatio_Offset), 0, CalcCameraRatioInnerWithRatioType_TargetRatio_PropertyAddress.Address);
		ConstraintAspectRatioType = EnumMarshaler<EGSConstraintAspectRatioType>.FromNative(IntPtr.Add(intPtr, CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_Offset), 0, CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInner")]
	public unsafe static void CalcCameraRatioInner(int RefViewPortWidth, int RefViewPortHeight, out float TargetRatio, out EGSConstraintAspectRatioType ConstraintAspectRatioType)
	{
		if (!CalcCameraRatioInner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInner");
			TargetRatio = 0f;
			ConstraintAspectRatioType = EGSConstraintAspectRatioType.None;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcCameraRatioInner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcCameraRatioInner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalcCameraRatioInner_RefViewPortWidth_Offset), 0, CalcCameraRatioInner_RefViewPortWidth_PropertyAddress.Address, RefViewPortWidth);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CalcCameraRatioInner_RefViewPortHeight_Offset), 0, CalcCameraRatioInner_RefViewPortHeight_PropertyAddress.Address, RefViewPortHeight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcCameraRatioInner_FunctionAddress, intPtr, CalcCameraRatioInner_ParamsSize);
		TargetRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCameraRatioInner_TargetRatio_Offset), 0, CalcCameraRatioInner_TargetRatio_PropertyAddress.Address);
		ConstraintAspectRatioType = EnumMarshaler<EGSConstraintAspectRatioType>.FromNative(IntPtr.Add(intPtr, CalcCameraRatioInner_ConstraintAspectRatioType_Offset), 0, CalcCameraRatioInner_ConstraintAspectRatioType_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCachedData")]
	public unsafe static void CalcCachedData(UObject WorldContext, out int OutRefViewPortWidth, out int OutRefViewPortHeight, out float OutCfgMaxRatioMin, out float OutCfgMaxRatioMax, out float OutCfgMinRatio, out float OutCfgRefHeightDPIScale, out EGSForceRatioType OutForceRatioTye, out EGSConstraintAspectRatioType OutConstraintAspectRatioType, out float OutRatio)
	{
		if (!CalcCachedData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCachedData");
			OutRefViewPortWidth = 0;
			OutRefViewPortHeight = 0;
			OutCfgMaxRatioMin = 0f;
			OutCfgMaxRatioMax = 0f;
			OutCfgMinRatio = 0f;
			OutCfgRefHeightDPIScale = 0f;
			OutForceRatioTye = EGSForceRatioType.Auto;
			OutConstraintAspectRatioType = EGSConstraintAspectRatioType.None;
			OutRatio = 0f;
		}
		else
		{
			byte* ptr = stackalloc byte[(int)(uint)(CalcCachedData_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcCachedData_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CalcCachedData_WorldContext_Offset), 0, CalcCachedData_WorldContext_PropertyAddress.Address, WorldContext);
			NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalcCachedData_FunctionAddress, intPtr, CalcCachedData_ParamsSize);
			OutRefViewPortWidth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutRefViewPortWidth_Offset), 0, CalcCachedData_OutRefViewPortWidth_PropertyAddress.Address);
			OutRefViewPortHeight = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutRefViewPortHeight_Offset), 0, CalcCachedData_OutRefViewPortHeight_PropertyAddress.Address);
			OutCfgMaxRatioMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutCfgMaxRatioMin_Offset), 0, CalcCachedData_OutCfgMaxRatioMin_PropertyAddress.Address);
			OutCfgMaxRatioMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutCfgMaxRatioMax_Offset), 0, CalcCachedData_OutCfgMaxRatioMax_PropertyAddress.Address);
			OutCfgMinRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutCfgMinRatio_Offset), 0, CalcCachedData_OutCfgMinRatio_PropertyAddress.Address);
			OutCfgRefHeightDPIScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutCfgRefHeightDPIScale_Offset), 0, CalcCachedData_OutCfgRefHeightDPIScale_PropertyAddress.Address);
			OutForceRatioTye = EnumMarshaler<EGSForceRatioType>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutForceRatioTye_Offset), 0, CalcCachedData_OutForceRatioTye_PropertyAddress.Address);
			OutConstraintAspectRatioType = EnumMarshaler<EGSConstraintAspectRatioType>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutConstraintAspectRatioType_Offset), 0, CalcCachedData_OutConstraintAspectRatioType_PropertyAddress.Address);
			OutRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcCachedData_OutRatio_Offset), 0, CalcCachedData_OutRatio_PropertyAddress.Address);
		}
	}

	static UGSViewPortRatioUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSViewPortRatioUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSViewPortRatioUtil));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSEngineExtent.GSViewPortRatioUtil");
		SetForceRatioType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetForceRatioType");
		SetForceRatioType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceRatioType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceRatioType_NewType_PropertyAddress, SetForceRatioType_FunctionAddress, "NewType");
		SetForceRatioType_NewType_Offset = NativeReflectionCached.GetPropertyOffset(SetForceRatioType_FunctionAddress, "NewType");
		SetForceRatioType_NewType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceRatioType_FunctionAddress, "NewType", Classes.FEnumProperty);
		SetForceRatioType_IsValid = SetForceRatioType_FunctionAddress != IntPtr.Zero && SetForceRatioType_NewType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:SetForceRatioType", SetForceRatioType_IsValid);
		InitSetCfg_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InitSetCfg");
		InitSetCfg_ParamsSize = NativeReflection.GetFunctionParamsSize(InitSetCfg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitSetCfg_InCfgMaxRatioMin_PropertyAddress, InitSetCfg_FunctionAddress, "InCfgMaxRatioMin");
		InitSetCfg_InCfgMaxRatioMin_Offset = NativeReflectionCached.GetPropertyOffset(InitSetCfg_FunctionAddress, "InCfgMaxRatioMin");
		InitSetCfg_InCfgMaxRatioMin_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetCfg_FunctionAddress, "InCfgMaxRatioMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetCfg_InCfgMaxRatioMax_PropertyAddress, InitSetCfg_FunctionAddress, "InCfgMaxRatioMax");
		InitSetCfg_InCfgMaxRatioMax_Offset = NativeReflectionCached.GetPropertyOffset(InitSetCfg_FunctionAddress, "InCfgMaxRatioMax");
		InitSetCfg_InCfgMaxRatioMax_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetCfg_FunctionAddress, "InCfgMaxRatioMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetCfg_InCfgMinRatio_PropertyAddress, InitSetCfg_FunctionAddress, "InCfgMinRatio");
		InitSetCfg_InCfgMinRatio_Offset = NativeReflectionCached.GetPropertyOffset(InitSetCfg_FunctionAddress, "InCfgMinRatio");
		InitSetCfg_InCfgMinRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetCfg_FunctionAddress, "InCfgMinRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitSetCfg_InCfgRefHeightDPIScale_PropertyAddress, InitSetCfg_FunctionAddress, "InCfgRefHeightDPIScale");
		InitSetCfg_InCfgRefHeightDPIScale_Offset = NativeReflectionCached.GetPropertyOffset(InitSetCfg_FunctionAddress, "InCfgRefHeightDPIScale");
		InitSetCfg_InCfgRefHeightDPIScale_IsValid = NativeReflectionCached.ValidatePropertyClass(InitSetCfg_FunctionAddress, "InCfgRefHeightDPIScale", Classes.FFloatProperty);
		InitSetCfg_IsValid = InitSetCfg_FunctionAddress != IntPtr.Zero && InitSetCfg_InCfgMaxRatioMin_IsValid && InitSetCfg_InCfgMaxRatioMax_IsValid && InitSetCfg_InCfgMinRatio_IsValid && InitSetCfg_InCfgRefHeightDPIScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:InitSetCfg", InitSetCfg_IsValid);
		GetForceRatioType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetForceRatioType");
		GetForceRatioType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForceRatioType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForceRatioType_ReturnValue_PropertyAddress, GetForceRatioType_FunctionAddress, "ReturnValue");
		GetForceRatioType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForceRatioType_FunctionAddress, "ReturnValue");
		GetForceRatioType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForceRatioType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetForceRatioType_IsValid = GetForceRatioType_FunctionAddress != IntPtr.Zero && GetForceRatioType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:GetForceRatioType", GetForceRatioType_IsValid);
		CalcCameraRatioInnerWithRatioType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcCameraRatioInnerWithRatioType");
		CalcCameraRatioInnerWithRatioType_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcCameraRatioInnerWithRatioType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInnerWithRatioType_RefViewPortWidth_PropertyAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortWidth");
		CalcCameraRatioInnerWithRatioType_RefViewPortWidth_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortWidth");
		CalcCameraRatioInnerWithRatioType_RefViewPortWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInnerWithRatioType_RefViewPortHeight_PropertyAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortHeight");
		CalcCameraRatioInnerWithRatioType_RefViewPortHeight_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortHeight");
		CalcCameraRatioInnerWithRatioType_RefViewPortHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInnerWithRatioType_FunctionAddress, "RefViewPortHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInnerWithRatioType_InForceRatioType_PropertyAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, "InForceRatioType");
		CalcCameraRatioInnerWithRatioType_InForceRatioType_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInnerWithRatioType_FunctionAddress, "InForceRatioType");
		CalcCameraRatioInnerWithRatioType_InForceRatioType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInnerWithRatioType_FunctionAddress, "InForceRatioType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInnerWithRatioType_TargetRatio_PropertyAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, "TargetRatio");
		CalcCameraRatioInnerWithRatioType_TargetRatio_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInnerWithRatioType_FunctionAddress, "TargetRatio");
		CalcCameraRatioInnerWithRatioType_TargetRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInnerWithRatioType_FunctionAddress, "TargetRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_PropertyAddress, CalcCameraRatioInnerWithRatioType_FunctionAddress, "ConstraintAspectRatioType");
		CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInnerWithRatioType_FunctionAddress, "ConstraintAspectRatioType");
		CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInnerWithRatioType_FunctionAddress, "ConstraintAspectRatioType", Classes.FEnumProperty);
		CalcCameraRatioInnerWithRatioType_IsValid = CalcCameraRatioInnerWithRatioType_FunctionAddress != IntPtr.Zero && CalcCameraRatioInnerWithRatioType_RefViewPortWidth_IsValid && CalcCameraRatioInnerWithRatioType_RefViewPortHeight_IsValid && CalcCameraRatioInnerWithRatioType_InForceRatioType_IsValid && CalcCameraRatioInnerWithRatioType_TargetRatio_IsValid && CalcCameraRatioInnerWithRatioType_ConstraintAspectRatioType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInnerWithRatioType", CalcCameraRatioInnerWithRatioType_IsValid);
		CalcCameraRatioInner_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcCameraRatioInner");
		CalcCameraRatioInner_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcCameraRatioInner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInner_RefViewPortWidth_PropertyAddress, CalcCameraRatioInner_FunctionAddress, "RefViewPortWidth");
		CalcCameraRatioInner_RefViewPortWidth_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInner_FunctionAddress, "RefViewPortWidth");
		CalcCameraRatioInner_RefViewPortWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInner_FunctionAddress, "RefViewPortWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInner_RefViewPortHeight_PropertyAddress, CalcCameraRatioInner_FunctionAddress, "RefViewPortHeight");
		CalcCameraRatioInner_RefViewPortHeight_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInner_FunctionAddress, "RefViewPortHeight");
		CalcCameraRatioInner_RefViewPortHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInner_FunctionAddress, "RefViewPortHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInner_TargetRatio_PropertyAddress, CalcCameraRatioInner_FunctionAddress, "TargetRatio");
		CalcCameraRatioInner_TargetRatio_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInner_FunctionAddress, "TargetRatio");
		CalcCameraRatioInner_TargetRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInner_FunctionAddress, "TargetRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCameraRatioInner_ConstraintAspectRatioType_PropertyAddress, CalcCameraRatioInner_FunctionAddress, "ConstraintAspectRatioType");
		CalcCameraRatioInner_ConstraintAspectRatioType_Offset = NativeReflectionCached.GetPropertyOffset(CalcCameraRatioInner_FunctionAddress, "ConstraintAspectRatioType");
		CalcCameraRatioInner_ConstraintAspectRatioType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCameraRatioInner_FunctionAddress, "ConstraintAspectRatioType", Classes.FEnumProperty);
		CalcCameraRatioInner_IsValid = CalcCameraRatioInner_FunctionAddress != IntPtr.Zero && CalcCameraRatioInner_RefViewPortWidth_IsValid && CalcCameraRatioInner_RefViewPortHeight_IsValid && CalcCameraRatioInner_TargetRatio_IsValid && CalcCameraRatioInner_ConstraintAspectRatioType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCameraRatioInner", CalcCameraRatioInner_IsValid);
		CalcCachedData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalcCachedData");
		CalcCachedData_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcCachedData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_WorldContext_PropertyAddress, CalcCachedData_FunctionAddress, "WorldContext");
		CalcCachedData_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "WorldContext");
		CalcCachedData_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutRefViewPortWidth_PropertyAddress, CalcCachedData_FunctionAddress, "OutRefViewPortWidth");
		CalcCachedData_OutRefViewPortWidth_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutRefViewPortWidth");
		CalcCachedData_OutRefViewPortWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutRefViewPortWidth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutRefViewPortHeight_PropertyAddress, CalcCachedData_FunctionAddress, "OutRefViewPortHeight");
		CalcCachedData_OutRefViewPortHeight_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutRefViewPortHeight");
		CalcCachedData_OutRefViewPortHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutRefViewPortHeight", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutCfgMaxRatioMin_PropertyAddress, CalcCachedData_FunctionAddress, "OutCfgMaxRatioMin");
		CalcCachedData_OutCfgMaxRatioMin_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutCfgMaxRatioMin");
		CalcCachedData_OutCfgMaxRatioMin_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutCfgMaxRatioMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutCfgMaxRatioMax_PropertyAddress, CalcCachedData_FunctionAddress, "OutCfgMaxRatioMax");
		CalcCachedData_OutCfgMaxRatioMax_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutCfgMaxRatioMax");
		CalcCachedData_OutCfgMaxRatioMax_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutCfgMaxRatioMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutCfgMinRatio_PropertyAddress, CalcCachedData_FunctionAddress, "OutCfgMinRatio");
		CalcCachedData_OutCfgMinRatio_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutCfgMinRatio");
		CalcCachedData_OutCfgMinRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutCfgMinRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutCfgRefHeightDPIScale_PropertyAddress, CalcCachedData_FunctionAddress, "OutCfgRefHeightDPIScale");
		CalcCachedData_OutCfgRefHeightDPIScale_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutCfgRefHeightDPIScale");
		CalcCachedData_OutCfgRefHeightDPIScale_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutCfgRefHeightDPIScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutForceRatioTye_PropertyAddress, CalcCachedData_FunctionAddress, "OutForceRatioTye");
		CalcCachedData_OutForceRatioTye_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutForceRatioTye");
		CalcCachedData_OutForceRatioTye_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutForceRatioTye", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutConstraintAspectRatioType_PropertyAddress, CalcCachedData_FunctionAddress, "OutConstraintAspectRatioType");
		CalcCachedData_OutConstraintAspectRatioType_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutConstraintAspectRatioType");
		CalcCachedData_OutConstraintAspectRatioType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutConstraintAspectRatioType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcCachedData_OutRatio_PropertyAddress, CalcCachedData_FunctionAddress, "OutRatio");
		CalcCachedData_OutRatio_Offset = NativeReflectionCached.GetPropertyOffset(CalcCachedData_FunctionAddress, "OutRatio");
		CalcCachedData_OutRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcCachedData_FunctionAddress, "OutRatio", Classes.FFloatProperty);
		CalcCachedData_IsValid = CalcCachedData_FunctionAddress != IntPtr.Zero && CalcCachedData_WorldContext_IsValid && CalcCachedData_OutRefViewPortWidth_IsValid && CalcCachedData_OutRefViewPortHeight_IsValid && CalcCachedData_OutCfgMaxRatioMin_IsValid && CalcCachedData_OutCfgMaxRatioMax_IsValid && CalcCachedData_OutCfgMinRatio_IsValid && CalcCachedData_OutCfgRefHeightDPIScale_IsValid && CalcCachedData_OutForceRatioTye_IsValid && CalcCachedData_OutConstraintAspectRatioType_IsValid && CalcCachedData_OutRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.GSViewPortRatioUtil:CalcCachedData", CalcCachedData_IsValid);
	}
}
