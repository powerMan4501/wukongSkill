using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitSmartParamConfig
{
	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346978309uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig:ActualParam")]
	public FGsSmartParam ActualParam;

	private static bool ModifyParam_IsValid;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig:ModifyParam")]
	public FGsSmartParam ModifyParam;

	private static bool DefaultParam_IsValid;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig:DefaultParam")]
	public FGsSmartParam DefaultParam;

	private static bool OutParam_IsValid;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitSmartParamConfig:OutParam")]
	public FGsSmartParam OutParam;

	private static bool FGsNPCUnitSmartParamConfig_IsValid;

	private static int FGsNPCUnitSmartParamConfig_StructSize;

	public FGsNPCUnitSmartParamConfig Copy()
	{
		return this;
	}

	public static FGsNPCUnitSmartParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitSmartParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitSmartParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitSmartParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitSmartParamConfig(nativeBuffer + arrayIndex * FGsNPCUnitSmartParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitSmartParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitSmartParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitSmartParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitSmartParamConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), ActualParam);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), ModifyParam);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), DefaultParam);
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), OutParam);
	}

	public FGsNPCUnitSmartParamConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitSmartParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitSmartParamConfig");
			CanModify = false;
			ActualParam = default(FGsSmartParam);
			ModifyParam = default(FGsSmartParam);
			DefaultParam = default(FGsSmartParam);
			OutParam = default(FGsSmartParam);
		}
		else
		{
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, ActualParam_Offset));
			ModifyParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, ModifyParam_Offset));
			DefaultParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, DefaultParam_Offset));
			OutParam = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, OutParam_Offset));
		}
	}

	static FGsNPCUnitSmartParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitSmartParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitSmartParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitSmartParamConfig");
		FGsNPCUnitSmartParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CanModify_PropertyAddress, intPtr, "bCanModify");
		CanModify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanModify");
		CanModify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanModify", Classes.FBoolProperty);
		ActualParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualParam");
		ActualParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualParam", Classes.FStructProperty);
		ModifyParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifyParam");
		ModifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifyParam", Classes.FStructProperty);
		DefaultParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultParam");
		DefaultParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultParam", Classes.FStructProperty);
		OutParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutParam");
		OutParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutParam", Classes.FStructProperty);
		FGsNPCUnitSmartParamConfig_IsValid = intPtr != IntPtr.Zero && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitSmartParamConfig", FGsNPCUnitSmartParamConfig_IsValid);
	}
}
