using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorLightLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorLightLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ModifyLightComponentShadowSettings_IsValid;

	private static IntPtr ModifyLightComponentShadowSettings_FunctionAddress;

	private static int ModifyLightComponentShadowSettings_ParamsSize;

	private static bool ModifyLightComponentShadowSettings_LightClassType_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_LightClassType_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_LightClassType_Offset;

	private static bool ModifyLightComponentShadowSettings_Filter_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_Filter_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_Filter_Offset;

	private static bool ModifyLightComponentShadowSettings_bCastShadow_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_bCastShadow_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_bCastShadow_Offset;

	private static bool ModifyLightComponentShadowSettings_bCastShadowMapShadow_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_bCastShadowMapShadow_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_bCastShadowMapShadow_Offset;

	private static bool ModifyLightComponentShadowSettings_bCastCapsuleShadow_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_bCastCapsuleShadow_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_bCastCapsuleShadow_Offset;

	private static bool ModifyLightComponentShadowSettings_bDistanceFieldShadow_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_bDistanceFieldShadow_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_bDistanceFieldShadow_Offset;

	private static bool ModifyLightComponentShadowSettings_ContactShadowLenth_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_ContactShadowLenth_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_ContactShadowLenth_Offset;

	private static bool ModifyLightComponentShadowSettings_ReturnValue_IsValid;

	private static FFieldAddress ModifyLightComponentShadowSettings_ReturnValue_PropertyAddress;

	private static int ModifyLightComponentShadowSettings_ReturnValue_Offset;

	private static bool GetColoredLightBrightness_IsValid;

	private static IntPtr GetColoredLightBrightness_FunctionAddress;

	private static int GetColoredLightBrightness_ParamsSize;

	private static bool GetColoredLightBrightness_PointLightCom_IsValid;

	private static FFieldAddress GetColoredLightBrightness_PointLightCom_PropertyAddress;

	private static int GetColoredLightBrightness_PointLightCom_Offset;

	private static bool GetColoredLightBrightness_ReturnValue_IsValid;

	private static FFieldAddress GetColoredLightBrightness_ReturnValue_PropertyAddress;

	private static int GetColoredLightBrightness_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLightLibrary:ModifyLightComponentShadowSettings")]
	public unsafe static int ModifyLightComponentShadowSettings(TSubclassOf<UObject> LightClassType, Dictionary<string, bool> Filter, bool bCastShadow, bool bCastShadowMapShadow, bool bCastCapsuleShadow, bool bDistanceFieldShadow, float ContactShadowLenth)
	{
		if (!ModifyLightComponentShadowSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLightLibrary:ModifyLightComponentShadowSettings");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyLightComponentShadowSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyLightComponentShadowSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_LightClassType_Offset), 0, ModifyLightComponentShadowSettings_LightClassType_PropertyAddress.Address, LightClassType);
		NativeReflection.InitializeValue_InContainer(ModifyLightComponentShadowSettings_Filter_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, bool>(1, ModifyLightComponentShadowSettings_Filter_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_Filter_Offset), Filter);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_bCastShadow_Offset), 0, ModifyLightComponentShadowSettings_bCastShadow_PropertyAddress.Address, bCastShadow);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_bCastShadowMapShadow_Offset), 0, ModifyLightComponentShadowSettings_bCastShadowMapShadow_PropertyAddress.Address, bCastShadowMapShadow);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_bCastCapsuleShadow_Offset), 0, ModifyLightComponentShadowSettings_bCastCapsuleShadow_PropertyAddress.Address, bCastCapsuleShadow);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_bDistanceFieldShadow_Offset), 0, ModifyLightComponentShadowSettings_bDistanceFieldShadow_PropertyAddress.Address, bDistanceFieldShadow);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_ContactShadowLenth_Offset), 0, ModifyLightComponentShadowSettings_ContactShadowLenth_PropertyAddress.Address, ContactShadowLenth);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyLightComponentShadowSettings_FunctionAddress, intPtr, ModifyLightComponentShadowSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyLightComponentShadowSettings_Filter_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ModifyLightComponentShadowSettings_ReturnValue_Offset), 0, ModifyLightComponentShadowSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLightLibrary:GetColoredLightBrightness")]
	public unsafe static FLinearColor GetColoredLightBrightness(UPointLightComponent PointLightCom)
	{
		if (!GetColoredLightBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLightLibrary:GetColoredLightBrightness");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColoredLightBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColoredLightBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPointLightComponent>.ToNative(IntPtr.Add(intPtr, GetColoredLightBrightness_PointLightCom_Offset), 0, GetColoredLightBrightness_PointLightCom_PropertyAddress.Address, PointLightCom);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColoredLightBrightness_FunctionAddress, intPtr, GetColoredLightBrightness_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetColoredLightBrightness_ReturnValue_Offset), 0, GetColoredLightBrightness_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorLightLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorLightLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorLightLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorLightLibrary");
		ModifyLightComponentShadowSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyLightComponentShadowSettings");
		ModifyLightComponentShadowSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyLightComponentShadowSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_LightClassType_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "LightClassType");
		ModifyLightComponentShadowSettings_LightClassType_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "LightClassType");
		ModifyLightComponentShadowSettings_LightClassType_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "LightClassType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_Filter_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "Filter");
		ModifyLightComponentShadowSettings_Filter_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "Filter");
		ModifyLightComponentShadowSettings_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "Filter", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_bCastShadow_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadow");
		ModifyLightComponentShadowSettings_bCastShadow_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadow");
		ModifyLightComponentShadowSettings_bCastShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_bCastShadowMapShadow_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadowMapShadow");
		ModifyLightComponentShadowSettings_bCastShadowMapShadow_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadowMapShadow");
		ModifyLightComponentShadowSettings_bCastShadowMapShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "bCastShadowMapShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_bCastCapsuleShadow_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "bCastCapsuleShadow");
		ModifyLightComponentShadowSettings_bCastCapsuleShadow_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "bCastCapsuleShadow");
		ModifyLightComponentShadowSettings_bCastCapsuleShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "bCastCapsuleShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_bDistanceFieldShadow_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "bDistanceFieldShadow");
		ModifyLightComponentShadowSettings_bDistanceFieldShadow_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "bDistanceFieldShadow");
		ModifyLightComponentShadowSettings_bDistanceFieldShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "bDistanceFieldShadow", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_ContactShadowLenth_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "ContactShadowLenth");
		ModifyLightComponentShadowSettings_ContactShadowLenth_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "ContactShadowLenth");
		ModifyLightComponentShadowSettings_ContactShadowLenth_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "ContactShadowLenth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyLightComponentShadowSettings_ReturnValue_PropertyAddress, ModifyLightComponentShadowSettings_FunctionAddress, "ReturnValue");
		ModifyLightComponentShadowSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ModifyLightComponentShadowSettings_FunctionAddress, "ReturnValue");
		ModifyLightComponentShadowSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyLightComponentShadowSettings_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ModifyLightComponentShadowSettings_IsValid = ModifyLightComponentShadowSettings_FunctionAddress != IntPtr.Zero && ModifyLightComponentShadowSettings_LightClassType_IsValid && ModifyLightComponentShadowSettings_Filter_IsValid && ModifyLightComponentShadowSettings_bCastShadow_IsValid && ModifyLightComponentShadowSettings_bCastShadowMapShadow_IsValid && ModifyLightComponentShadowSettings_bCastCapsuleShadow_IsValid && ModifyLightComponentShadowSettings_bDistanceFieldShadow_IsValid && ModifyLightComponentShadowSettings_ContactShadowLenth_IsValid && ModifyLightComponentShadowSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLightLibrary:ModifyLightComponentShadowSettings", ModifyLightComponentShadowSettings_IsValid);
		GetColoredLightBrightness_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColoredLightBrightness");
		GetColoredLightBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColoredLightBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColoredLightBrightness_PointLightCom_PropertyAddress, GetColoredLightBrightness_FunctionAddress, "PointLightCom");
		GetColoredLightBrightness_PointLightCom_Offset = NativeReflectionCached.GetPropertyOffset(GetColoredLightBrightness_FunctionAddress, "PointLightCom");
		GetColoredLightBrightness_PointLightCom_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColoredLightBrightness_FunctionAddress, "PointLightCom", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColoredLightBrightness_ReturnValue_PropertyAddress, GetColoredLightBrightness_FunctionAddress, "ReturnValue");
		GetColoredLightBrightness_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColoredLightBrightness_FunctionAddress, "ReturnValue");
		GetColoredLightBrightness_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColoredLightBrightness_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColoredLightBrightness_IsValid = GetColoredLightBrightness_FunctionAddress != IntPtr.Zero && GetColoredLightBrightness_PointLightCom_IsValid && GetColoredLightBrightness_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLightLibrary:GetColoredLightBrightness", GetColoredLightBrightness_IsValid);
	}
}
