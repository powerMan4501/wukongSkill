using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitGuidParamConfig
{
	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig:ActualParam")]
	public Guid ActualParam;

	private static bool ModifyParam_IsValid;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig:ModifyParam")]
	public Guid ModifyParam;

	private static bool DefaultParam_IsValid;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig:DefaultParam")]
	public Guid DefaultParam;

	private static bool OutParam_IsValid;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitGuidParamConfig:OutParam")]
	public Guid OutParam;

	private static bool FGsNPCUnitGuidParamConfig_IsValid;

	private static int FGsNPCUnitGuidParamConfig_StructSize;

	public FGsNPCUnitGuidParamConfig Copy()
	{
		return this;
	}

	public static FGsNPCUnitGuidParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitGuidParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitGuidParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitGuidParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitGuidParamConfig(nativeBuffer + arrayIndex * FGsNPCUnitGuidParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitGuidParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitGuidParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitGuidParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitGuidParamConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), ActualParam);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), ModifyParam);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), DefaultParam);
		BlittableTypeMarshaler<Guid>.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), OutParam);
	}

	public FGsNPCUnitGuidParamConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitGuidParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitGuidParamConfig");
			CanModify = false;
			ActualParam = default(Guid);
			ModifyParam = default(Guid);
			DefaultParam = default(Guid);
			OutParam = default(Guid);
		}
		else
		{
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualParam = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ActualParam_Offset));
			ModifyParam = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, ModifyParam_Offset));
			DefaultParam = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, DefaultParam_Offset));
			OutParam = BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(nativeStruct, OutParam_Offset));
		}
	}

	static FGsNPCUnitGuidParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitGuidParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitGuidParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitGuidParamConfig");
		FGsNPCUnitGuidParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FGsNPCUnitGuidParamConfig_IsValid = intPtr != IntPtr.Zero && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitGuidParamConfig", FGsNPCUnitGuidParamConfig_IsValid);
	}
}
