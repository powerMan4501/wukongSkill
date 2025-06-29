using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffectDisplacement", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffectDisplacement
{
	private static bool DisplacementHeight_IsValid;

	private static int DisplacementHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:DisplacementHeight")]
	public float DisplacementHeight;

	private static bool DisplacementTiling_IsValid;

	private static int DisplacementTiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:DisplacementTiling")]
	public float DisplacementTiling;

	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:Texture")]
	public UTexture2D Texture;

	private static bool Midpoint_IsValid;

	private static int Midpoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:Midpoint")]
	public float Midpoint;

	private static bool Channel_IsValid;

	private static int Channel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:Channel")]
	public FLinearColor Channel;

	private static bool WeightmapInfluence_IsValid;

	private static int WeightmapInfluence_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectDisplacement:WeightmapInfluence")]
	public float WeightmapInfluence;

	private static bool FWaterBrushEffectDisplacement_IsValid;

	private static int FWaterBrushEffectDisplacement_StructSize;

	public FWaterBrushEffectDisplacement Copy()
	{
		return this;
	}

	public static FWaterBrushEffectDisplacement FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffectDisplacement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffectDisplacement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffectDisplacement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffectDisplacement(nativeBuffer + arrayIndex * FWaterBrushEffectDisplacement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffectDisplacement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffectDisplacement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectDisplacement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectDisplacement");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisplacementHeight_Offset), DisplacementHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisplacementTiling_Offset), DisplacementTiling);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, Texture_Offset), Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Midpoint_Offset), Midpoint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Channel_Offset), Channel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WeightmapInfluence_Offset), WeightmapInfluence);
	}

	public FWaterBrushEffectDisplacement(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectDisplacement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectDisplacement");
			DisplacementHeight = 0f;
			DisplacementTiling = 0f;
			Texture = null;
			Midpoint = 0f;
			Channel = default(FLinearColor);
			WeightmapInfluence = 0f;
		}
		else
		{
			DisplacementHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DisplacementHeight_Offset));
			DisplacementTiling = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DisplacementTiling_Offset));
			Texture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, Texture_Offset));
			Midpoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Midpoint_Offset));
			Channel = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, Channel_Offset));
			WeightmapInfluence = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WeightmapInfluence_Offset));
		}
	}

	static FWaterBrushEffectDisplacement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffectDisplacement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffectDisplacement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffectDisplacement");
		FWaterBrushEffectDisplacement_StructSize = NativeReflection.GetStructSize(intPtr);
		DisplacementHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplacementHeight");
		DisplacementHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplacementHeight", Classes.FFloatProperty);
		DisplacementTiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisplacementTiling");
		DisplacementTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisplacementTiling", Classes.FFloatProperty);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FObjectProperty);
		Midpoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Midpoint");
		Midpoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Midpoint", Classes.FFloatProperty);
		Channel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Channel");
		Channel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Channel", Classes.FStructProperty);
		WeightmapInfluence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeightmapInfluence");
		WeightmapInfluence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeightmapInfluence", Classes.FFloatProperty);
		FWaterBrushEffectDisplacement_IsValid = intPtr != IntPtr.Zero && DisplacementHeight_IsValid && DisplacementTiling_IsValid && Texture_IsValid && Midpoint_IsValid && Channel_IsValid && WeightmapInfluence_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffectDisplacement", FWaterBrushEffectDisplacement_IsValid);
	}
}
