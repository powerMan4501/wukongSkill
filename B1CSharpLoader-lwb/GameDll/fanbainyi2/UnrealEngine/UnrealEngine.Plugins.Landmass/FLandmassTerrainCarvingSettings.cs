using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FLandmassTerrainCarvingSettings
{
	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings:BlendMode")]
	public EBrushBlendType BlendMode;

	private static bool InvertShape_IsValid;

	private static FFieldAddress InvertShape_PropertyAddress;

	private static int InvertShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings:bInvertShape")]
	public bool InvertShape;

	private static bool FalloffSettings_IsValid;

	private static int FalloffSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings:FalloffSettings")]
	public FLandmassFalloffSettings FalloffSettings;

	private static bool Effects_IsValid;

	private static int Effects_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings:Effects")]
	public FLandmassBrushEffectsList Effects;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassTerrainCarvingSettings:Priority")]
	public int Priority;

	private static bool FLandmassTerrainCarvingSettings_IsValid;

	private static int FLandmassTerrainCarvingSettings_StructSize;

	public FLandmassTerrainCarvingSettings Copy()
	{
		return this;
	}

	public static FLandmassTerrainCarvingSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLandmassTerrainCarvingSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLandmassTerrainCarvingSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLandmassTerrainCarvingSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLandmassTerrainCarvingSettings(nativeBuffer + arrayIndex * FLandmassTerrainCarvingSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLandmassTerrainCarvingSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLandmassTerrainCarvingSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLandmassTerrainCarvingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassTerrainCarvingSettings");
			return;
		}
		EnumMarshaler<EBrushBlendType>.ToNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, BlendMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InvertShape_Offset), 0, InvertShape_PropertyAddress.Address, InvertShape);
		FLandmassFalloffSettings.ToNative(IntPtr.Add(nativeStruct, FalloffSettings_Offset), FalloffSettings);
		FLandmassBrushEffectsList.ToNative(IntPtr.Add(nativeStruct, Effects_Offset), Effects);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
	}

	public FLandmassTerrainCarvingSettings(IntPtr nativeStruct)
	{
		if (!FLandmassTerrainCarvingSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassTerrainCarvingSettings");
			BlendMode = EBrushBlendType.AlphaBlend;
			InvertShape = false;
			FalloffSettings = default(FLandmassFalloffSettings);
			Effects = default(FLandmassBrushEffectsList);
			Priority = 0;
		}
		else
		{
			BlendMode = EnumMarshaler<EBrushBlendType>.FromNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
			InvertShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InvertShape_Offset), 0, InvertShape_PropertyAddress.Address);
			FalloffSettings = FLandmassFalloffSettings.FromNative(IntPtr.Add(nativeStruct, FalloffSettings_Offset));
			Effects = FLandmassBrushEffectsList.FromNative(IntPtr.Add(nativeStruct, Effects_Offset));
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
		}
	}

	static FLandmassTerrainCarvingSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLandmassTerrainCarvingSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLandmassTerrainCarvingSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.LandmassTerrainCarvingSettings");
		FLandmassTerrainCarvingSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BlendMode_PropertyAddress, intPtr, "BlendMode");
		BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendMode");
		BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertShape_PropertyAddress, intPtr, "bInvertShape");
		InvertShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInvertShape");
		InvertShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInvertShape", Classes.FBoolProperty);
		FalloffSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffSettings");
		FalloffSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffSettings", Classes.FStructProperty);
		Effects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Effects");
		Effects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Effects", Classes.FStructProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		FLandmassTerrainCarvingSettings_IsValid = intPtr != IntPtr.Zero && BlendMode_IsValid && InvertShape_IsValid && FalloffSettings_IsValid && Effects_IsValid && Priority_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.LandmassTerrainCarvingSettings", FLandmassTerrainCarvingSettings_IsValid);
	}
}
