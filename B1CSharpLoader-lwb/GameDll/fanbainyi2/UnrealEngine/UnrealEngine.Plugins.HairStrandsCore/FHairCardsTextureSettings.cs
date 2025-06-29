using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairCardsTextureSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairCardsTextureSettings
{
	private static bool AtlasMaxResolution_IsValid;

	private static int AtlasMaxResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsTextureSettings:AtlasMaxResolution")]
	public int AtlasMaxResolution;

	private static bool PixelPerCentimeters_IsValid;

	private static int PixelPerCentimeters_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsTextureSettings:PixelPerCentimeters")]
	public int PixelPerCentimeters;

	private static bool LengthTextureCount_IsValid;

	private static int LengthTextureCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsTextureSettings:LengthTextureCount")]
	public int LengthTextureCount;

	private static bool FHairCardsTextureSettings_IsValid;

	private static int FHairCardsTextureSettings_StructSize;

	public FHairCardsTextureSettings Copy()
	{
		return this;
	}

	public static FHairCardsTextureSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairCardsTextureSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairCardsTextureSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairCardsTextureSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairCardsTextureSettings(nativeBuffer + arrayIndex * FHairCardsTextureSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairCardsTextureSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairCardsTextureSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairCardsTextureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsTextureSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AtlasMaxResolution_Offset), AtlasMaxResolution);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PixelPerCentimeters_Offset), PixelPerCentimeters);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LengthTextureCount_Offset), LengthTextureCount);
	}

	public FHairCardsTextureSettings(IntPtr nativeStruct)
	{
		if (!FHairCardsTextureSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsTextureSettings");
			AtlasMaxResolution = 0;
			PixelPerCentimeters = 0;
			LengthTextureCount = 0;
		}
		else
		{
			AtlasMaxResolution = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AtlasMaxResolution_Offset));
			PixelPerCentimeters = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PixelPerCentimeters_Offset));
			LengthTextureCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LengthTextureCount_Offset));
		}
	}

	static FHairCardsTextureSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairCardsTextureSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairCardsTextureSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairCardsTextureSettings");
		FHairCardsTextureSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		AtlasMaxResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtlasMaxResolution");
		AtlasMaxResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtlasMaxResolution", Classes.FIntProperty);
		PixelPerCentimeters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PixelPerCentimeters");
		PixelPerCentimeters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PixelPerCentimeters", Classes.FIntProperty);
		LengthTextureCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LengthTextureCount");
		LengthTextureCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LengthTextureCount", Classes.FIntProperty);
		FHairCardsTextureSettings_IsValid = intPtr != IntPtr.Zero && AtlasMaxResolution_IsValid && PixelPerCentimeters_IsValid && LengthTextureCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairCardsTextureSettings", FHairCardsTextureSettings_IsValid);
	}
}
