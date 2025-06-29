using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitBuffParamConfig
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:ConfigGuid")]
	public Guid ConfigGuid;

	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static FFieldAddress ActualParam_PropertyAddress;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:ActualParam")]
	public EGsNPCBuffState ActualParam;

	private static bool ModifyParam_IsValid;

	private static FFieldAddress ModifyParam_PropertyAddress;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:ModifyParam")]
	public EGsNPCBuffState ModifyParam;

	private static bool DefaultParam_IsValid;

	private static FFieldAddress DefaultParam_PropertyAddress;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:DefaultParam")]
	public EGsNPCBuffState DefaultParam;

	private static bool OutParam_IsValid;

	private static FFieldAddress OutParam_PropertyAddress;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitBuffParamConfig:OutParam")]
	public EGsNPCBuffState OutParam;

	private static bool FGsNPCUnitBuffParamConfig_IsValid;

	private static int FGsNPCUnitBuffParamConfig_StructSize;

	public FGsNPCUnitBuffParamConfig Copy()
	{
		return this;
	}

	public static FGsNPCUnitBuffParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitBuffParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitBuffParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitBuffParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitBuffParamConfig(nativeBuffer + arrayIndex * FGsNPCUnitBuffParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitBuffParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitBuffParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitBuffParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitBuffParamConfig");
			return;
		}
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset), ConfigGuid);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		EnumMarshaler<EGsNPCBuffState>.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), 0, ActualParam_PropertyAddress.Address, ActualParam);
		EnumMarshaler<EGsNPCBuffState>.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), 0, ModifyParam_PropertyAddress.Address, ModifyParam);
		EnumMarshaler<EGsNPCBuffState>.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), 0, DefaultParam_PropertyAddress.Address, DefaultParam);
		EnumMarshaler<EGsNPCBuffState>.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), 0, OutParam_PropertyAddress.Address, OutParam);
	}

	public FGsNPCUnitBuffParamConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitBuffParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitBuffParamConfig");
			ConfigGuid = default(Guid);
			CanModify = false;
			ActualParam = EGsNPCBuffState.Add;
			ModifyParam = EGsNPCBuffState.Add;
			DefaultParam = EGsNPCBuffState.Add;
			OutParam = EGsNPCBuffState.Add;
		}
		else
		{
			ConfigGuid = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ConfigGuid_Offset));
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualParam = EnumMarshaler<EGsNPCBuffState>.FromNative(IntPtr.Add(nativeStruct, ActualParam_Offset), 0, ActualParam_PropertyAddress.Address);
			ModifyParam = EnumMarshaler<EGsNPCBuffState>.FromNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), 0, ModifyParam_PropertyAddress.Address);
			DefaultParam = EnumMarshaler<EGsNPCBuffState>.FromNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), 0, DefaultParam_PropertyAddress.Address);
			OutParam = EnumMarshaler<EGsNPCBuffState>.FromNative(IntPtr.Add(nativeStruct, OutParam_Offset), 0, OutParam_PropertyAddress.Address);
		}
	}

	static FGsNPCUnitBuffParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitBuffParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitBuffParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitBuffParamConfig");
		FGsNPCUnitBuffParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ConfigGuid_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanModify_PropertyAddress, intPtr, "bCanModify");
		CanModify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanModify");
		CanModify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanModify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ActualParam_PropertyAddress, intPtr, "ActualParam");
		ActualParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualParam");
		ActualParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualParam", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyParam_PropertyAddress, intPtr, "ModifyParam");
		ModifyParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifyParam");
		ModifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifyParam", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultParam_PropertyAddress, intPtr, "DefaultParam");
		DefaultParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultParam");
		DefaultParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultParam", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OutParam_PropertyAddress, intPtr, "OutParam");
		OutParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutParam");
		OutParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutParam", Classes.FEnumProperty);
		FGsNPCUnitBuffParamConfig_IsValid = intPtr != IntPtr.Zero && ConfigGuid_IsValid && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitBuffParamConfig", FGsNPCUnitBuffParamConfig_IsValid);
	}
}
