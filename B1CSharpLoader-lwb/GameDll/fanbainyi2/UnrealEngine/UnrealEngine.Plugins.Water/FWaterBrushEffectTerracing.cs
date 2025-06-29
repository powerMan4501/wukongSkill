using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffectTerracing", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffectTerracing
{
	private static bool TerraceAlpha_IsValid;

	private static int TerraceAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectTerracing:TerraceAlpha")]
	public float TerraceAlpha;

	private static bool TerraceSpacing_IsValid;

	private static int TerraceSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectTerracing:TerraceSpacing")]
	public float TerraceSpacing;

	private static bool TerraceSmoothness_IsValid;

	private static int TerraceSmoothness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectTerracing:TerraceSmoothness")]
	public float TerraceSmoothness;

	private static bool MaskLength_IsValid;

	private static int MaskLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectTerracing:MaskLength")]
	public float MaskLength;

	private static bool MaskStartOffset_IsValid;

	private static int MaskStartOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectTerracing:MaskStartOffset")]
	public float MaskStartOffset;

	private static bool FWaterBrushEffectTerracing_IsValid;

	private static int FWaterBrushEffectTerracing_StructSize;

	public FWaterBrushEffectTerracing Copy()
	{
		return this;
	}

	public static FWaterBrushEffectTerracing FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffectTerracing(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffectTerracing value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffectTerracing FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffectTerracing(nativeBuffer + arrayIndex * FWaterBrushEffectTerracing_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffectTerracing value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffectTerracing_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectTerracing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectTerracing");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceAlpha_Offset), TerraceAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceSpacing_Offset), TerraceSpacing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceSmoothness_Offset), TerraceSmoothness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaskLength_Offset), MaskLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaskStartOffset_Offset), MaskStartOffset);
	}

	public FWaterBrushEffectTerracing(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectTerracing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectTerracing");
			TerraceAlpha = 0f;
			TerraceSpacing = 0f;
			TerraceSmoothness = 0f;
			MaskLength = 0f;
			MaskStartOffset = 0f;
		}
		else
		{
			TerraceAlpha = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TerraceAlpha_Offset));
			TerraceSpacing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TerraceSpacing_Offset));
			TerraceSmoothness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TerraceSmoothness_Offset));
			MaskLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaskLength_Offset));
			MaskStartOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaskStartOffset_Offset));
		}
	}

	static FWaterBrushEffectTerracing()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffectTerracing)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffectTerracing));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffectTerracing");
		FWaterBrushEffectTerracing_StructSize = NativeReflection.GetStructSize(intPtr);
		TerraceAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerraceAlpha");
		TerraceAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerraceAlpha", Classes.FFloatProperty);
		TerraceSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerraceSpacing");
		TerraceSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerraceSpacing", Classes.FFloatProperty);
		TerraceSmoothness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TerraceSmoothness");
		TerraceSmoothness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TerraceSmoothness", Classes.FFloatProperty);
		MaskLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaskLength");
		MaskLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaskLength", Classes.FFloatProperty);
		MaskStartOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaskStartOffset");
		MaskStartOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaskStartOffset", Classes.FFloatProperty);
		FWaterBrushEffectTerracing_IsValid = intPtr != IntPtr.Zero && TerraceAlpha_IsValid && TerraceSpacing_IsValid && TerraceSmoothness_IsValid && MaskLength_IsValid && MaskStartOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffectTerracing", FWaterBrushEffectTerracing_IsValid);
	}
}
