using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectTerracing", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectTerracing
{
	private static bool TerraceAlpha_IsValid;

	private static int TerraceAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectTerracing:TerraceAlpha")]
	public float TerraceAlpha;

	private static bool TerraceSpacing_IsValid;

	private static int TerraceSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectTerracing:TerraceSpacing")]
	public float TerraceSpacing;

	private static bool TerraceSmoothness_IsValid;

	private static int TerraceSmoothness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectTerracing:TerraceSmoothness")]
	public float TerraceSmoothness;

	private static bool MaskLength_IsValid;

	private static int MaskLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectTerracing:MaskLength")]
	public float MaskLength;

	private static bool MaskStartOffset_IsValid;

	private static int MaskStartOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectTerracing:MaskStartOffset")]
	public float MaskStartOffset;

	private static bool FBrushEffectTerracing_IsValid;

	private static int FBrushEffectTerracing_StructSize;

	public FBrushEffectTerracing Copy()
	{
		return this;
	}

	public static FBrushEffectTerracing FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectTerracing(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectTerracing value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectTerracing FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectTerracing(nativeBuffer + arrayIndex * FBrushEffectTerracing_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectTerracing value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectTerracing_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectTerracing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectTerracing");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceAlpha_Offset), TerraceAlpha);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceSpacing_Offset), TerraceSpacing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TerraceSmoothness_Offset), TerraceSmoothness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaskLength_Offset), MaskLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaskStartOffset_Offset), MaskStartOffset);
	}

	public FBrushEffectTerracing(IntPtr nativeStruct)
	{
		if (!FBrushEffectTerracing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectTerracing");
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

	static FBrushEffectTerracing()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectTerracing)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectTerracing));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectTerracing");
		FBrushEffectTerracing_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FBrushEffectTerracing_IsValid = intPtr != IntPtr.Zero && TerraceAlpha_IsValid && TerraceSpacing_IsValid && TerraceSmoothness_IsValid && MaskLength_IsValid && MaskStartOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectTerracing", FBrushEffectTerracing_IsValid);
	}
}
