using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBodyHeightmapSettings", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBodyHeightmapSettings
{
	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyHeightmapSettings:BlendMode")]
	public EWaterBrushBlendType BlendMode;

	private static bool InvertShape_IsValid;

	private static FFieldAddress InvertShape_PropertyAddress;

	private static int InvertShape_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Water.WaterBodyHeightmapSettings:bInvertShape")]
	public bool InvertShape;

	private static bool FalloffSettings_IsValid;

	private static int FalloffSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBodyHeightmapSettings:FalloffSettings")]
	public FWaterFalloffSettings FalloffSettings;

	private static bool Effects_IsValid;

	private static int Effects_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Water.WaterBodyHeightmapSettings:Effects")]
	public FWaterBrushEffects Effects;

	private static bool FWaterBodyHeightmapSettings_IsValid;

	private static int FWaterBodyHeightmapSettings_StructSize;

	public FWaterBodyHeightmapSettings Copy()
	{
		return this;
	}

	public static FWaterBodyHeightmapSettings FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBodyHeightmapSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBodyHeightmapSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBodyHeightmapSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBodyHeightmapSettings(nativeBuffer + arrayIndex * FWaterBodyHeightmapSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBodyHeightmapSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBodyHeightmapSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBodyHeightmapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBodyHeightmapSettings");
			return;
		}
		EnumMarshaler<EWaterBrushBlendType>.ToNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, BlendMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InvertShape_Offset), 0, InvertShape_PropertyAddress.Address, InvertShape);
		FWaterFalloffSettings.ToNative(IntPtr.Add(nativeStruct, FalloffSettings_Offset), FalloffSettings);
		FWaterBrushEffects.ToNative(IntPtr.Add(nativeStruct, Effects_Offset), Effects);
	}

	public FWaterBodyHeightmapSettings(IntPtr nativeStruct)
	{
		if (!FWaterBodyHeightmapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBodyHeightmapSettings");
			BlendMode = EWaterBrushBlendType.AlphaBlend;
			InvertShape = false;
			FalloffSettings = default(FWaterFalloffSettings);
			Effects = default(FWaterBrushEffects);
		}
		else
		{
			BlendMode = EnumMarshaler<EWaterBrushBlendType>.FromNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
			InvertShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InvertShape_Offset), 0, InvertShape_PropertyAddress.Address);
			FalloffSettings = FWaterFalloffSettings.FromNative(IntPtr.Add(nativeStruct, FalloffSettings_Offset));
			Effects = FWaterBrushEffects.FromNative(IntPtr.Add(nativeStruct, Effects_Offset));
		}
	}

	static FWaterBodyHeightmapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBodyHeightmapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBodyHeightmapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBodyHeightmapSettings");
		FWaterBodyHeightmapSettings_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FWaterBodyHeightmapSettings_IsValid = intPtr != IntPtr.Zero && BlendMode_IsValid && InvertShape_IsValid && FalloffSettings_IsValid && Effects_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBodyHeightmapSettings", FWaterBodyHeightmapSettings_IsValid);
	}
}
