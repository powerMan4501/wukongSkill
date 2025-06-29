using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsStreamingLevelStateConfigIntParamConfig
{
	private static bool CanModify_IsValid;

	private static FFieldAddress CanModify_PropertyAddress;

	private static int CanModify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig:bCanModify")]
	public bool CanModify;

	private static bool ActualParam_IsValid;

	private static int ActualParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig:ActualParam")]
	public int ActualParam;

	private static bool ModifyParam_IsValid;

	private static int ModifyParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig:ModifyParam")]
	public int ModifyParam;

	private static bool DefaultParam_IsValid;

	private static int DefaultParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig:DefaultParam")]
	public int DefaultParam;

	private static bool OutParam_IsValid;

	private static int OutParam_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig:OutParam")]
	public int OutParam;

	private static bool FGsStreamingLevelStateConfigIntParamConfig_IsValid;

	private static int FGsStreamingLevelStateConfigIntParamConfig_StructSize;

	public FGsStreamingLevelStateConfigIntParamConfig Copy()
	{
		return this;
	}

	public static FGsStreamingLevelStateConfigIntParamConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGsStreamingLevelStateConfigIntParamConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsStreamingLevelStateConfigIntParamConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsStreamingLevelStateConfigIntParamConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsStreamingLevelStateConfigIntParamConfig(nativeBuffer + arrayIndex * FGsStreamingLevelStateConfigIntParamConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsStreamingLevelStateConfigIntParamConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsStreamingLevelStateConfigIntParamConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsStreamingLevelStateConfigIntParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanModify_Offset), 0, CanModify_PropertyAddress.Address, CanModify);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ActualParam_Offset), ActualParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ModifyParam_Offset), ModifyParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DefaultParam_Offset), DefaultParam);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutParam_Offset), OutParam);
	}

	public FGsStreamingLevelStateConfigIntParamConfig(IntPtr nativeStruct)
	{
		if (!FGsStreamingLevelStateConfigIntParamConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig");
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

	static FGsStreamingLevelStateConfigIntParamConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsStreamingLevelStateConfigIntParamConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsStreamingLevelStateConfigIntParamConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig");
		FGsStreamingLevelStateConfigIntParamConfig_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FGsStreamingLevelStateConfigIntParamConfig_IsValid = intPtr != IntPtr.Zero && CanModify_IsValid && ActualParam_IsValid && ModifyParam_IsValid && DefaultParam_IsValid && OutParam_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsStreamingLevelStateConfigIntParamConfig", FGsStreamingLevelStateConfigIntParamConfig_IsValid);
	}
}
