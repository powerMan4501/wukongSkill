using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsNPCUnitIntParamConfig
{
	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig:ActualParam")]
	public int ActualParam;

	private static bool ModifyParam_IsValid;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig:ModifyParam")]
	public int ModifyParam;

	private static bool DefaultParam_IsValid;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig:DefaultParam")]
	public int DefaultParam;

	private static bool OutParam_IsValid;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsNPCUnitIntParamConfig:OutParam")]
	public int OutParam;

	private static bool FGsNPCUnitIntParamConfig_IsValid;

	private static int FGsNPCUnitIntParamConfig_StructSize;

	public FGsNPCUnitIntParamConfig Copy()
	{
		return this;
	}

	public static FGsNPCUnitIntParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsNPCUnitIntParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsNPCUnitIntParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsNPCUnitIntParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsNPCUnitIntParamConfig(nativeBuffer + arrayIndex * FGsNPCUnitIntParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsNPCUnitIntParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsNPCUnitIntParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitIntParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitIntParamConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), ActualParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), ModifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), DefaultParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), OutParam);
	}

	public FGsNPCUnitIntParamConfig(IntPtr nativeStruct)
	{
		if (!FGsNPCUnitIntParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsNPCUnitIntParamConfig");
			CanModify = false;
			ActualParam = 0;
			ModifyParam = 0;
			DefaultParam = 0;
			OutParam = 0;
		}
		else
		{
			CanModify = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address);
			ActualParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ActualParam_Offset));
			ModifyParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ModifyParam_Offset));
			DefaultParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DefaultParam_Offset));
			OutParam = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutParam_Offset));
		}
	}

	static FGsNPCUnitIntParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsNPCUnitIntParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsNPCUnitIntParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsNPCUnitIntParamConfig");
		FGsNPCUnitIntParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CanModify_PropertyAddress, intPtr, "bCanModify");
		CanModify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanModify");
		CanModify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanModify", Classes.FBoolProperty);
		ActualParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActualParam");
		ActualParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActualParam", Classes.FIntProperty);
		ModifyParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModifyParam");
		ModifyParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModifyParam", Classes.FIntProperty);
		DefaultParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultParam");
		DefaultParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultParam", Classes.FIntProperty);
		OutParam_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutParam");
		OutParam_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutParam", Classes.FIntProperty);
		FGsNPCUnitIntParamConfig_IsValid = intPtr != IntPtr.Zero && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsNPCUnitIntParamConfig", FGsNPCUnitIntParamConfig_IsValid);
	}
}
