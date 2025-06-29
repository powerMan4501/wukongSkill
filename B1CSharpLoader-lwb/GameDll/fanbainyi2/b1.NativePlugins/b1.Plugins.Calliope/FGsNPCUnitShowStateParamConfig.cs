using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitShowStateParamConfig
{
	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static FFieldAddress ActualParam_PropertyAddress;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig:ActualParam")]
	public EGsNPCShowState ActualParam;

	private static bool ModifyParam_IsValid;

	private static FFieldAddress ModifyParam_PropertyAddress;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig:ModifyParam")]
	public EGsNPCShowState ModifyParam;

	private static bool DefaultParam_IsValid;

	private static FFieldAddress DefaultParam_PropertyAddress;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig:DefaultParam")]
	public EGsNPCShowState DefaultParam;

	private static bool OutParam_IsValid;

	private static FFieldAddress OutParam_PropertyAddress;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitShowStateParamConfig:OutParam")]
	public EGsNPCShowState OutParam;

	private static bool FGsNPCUnitShowStateParamConfig_IsValid;

	private static int FGsNPCUnitShowStateParamConfig_StructSize;

	public FGsNPCUnitShowStateParamConfig Copy()
	{
		return this;
	}

	public static FGsNPCUnitShowStateParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitShowStateParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitShowStateParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitShowStateParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitShowStateParamConfig(nativeBuffer + arrayIndex * FGsNPCUnitShowStateParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitShowStateParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitShowStateParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitShowStateParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitShowStateParamConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), 0, ActualParam_PropertyAddress.Address, ActualParam);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), 0, ModifyParam_PropertyAddress.Address, ModifyParam);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), 0, DefaultParam_PropertyAddress.Address, DefaultParam);
		EnumMarshaler<EGsNPCShowState>.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), 0, OutParam_PropertyAddress.Address, OutParam);
	}

	public FGsNPCUnitShowStateParamConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitShowStateParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitShowStateParamConfig");
			CanModify = false;
			ActualParam = EGsNPCShowState.Show;
			ModifyParam = EGsNPCShowState.Show;
			DefaultParam = EGsNPCShowState.Show;
			OutParam = EGsNPCShowState.Show;
		}
		else
		{
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualParam = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, ActualParam_Offset), 0, ActualParam_PropertyAddress.Address);
			ModifyParam = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), 0, ModifyParam_PropertyAddress.Address);
			DefaultParam = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), 0, DefaultParam_PropertyAddress.Address);
			OutParam = EnumMarshaler<EGsNPCShowState>.FromNative(IntPtr.Add(nativeStruct, OutParam_Offset), 0, OutParam_PropertyAddress.Address);
		}
	}

	static FGsNPCUnitShowStateParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitShowStateParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitShowStateParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitShowStateParamConfig");
		FGsNPCUnitShowStateParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FGsNPCUnitShowStateParamConfig_IsValid = intPtr != IntPtr.Zero && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitShowStateParamConfig", FGsNPCUnitShowStateParamConfig_IsValid);
	}
}
