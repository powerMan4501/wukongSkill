using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectDisplacement", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectDisplacement
{
	private static bool DisplacementHeight_IsValid;

	private static int DisplacementHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:DisplacementHeight")]
	public float DisplacementHeight;

	private static bool DisplacementTiling_IsValid;

	private static int DisplacementTiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:DisplacementTiling")]
	public float DisplacementTiling;

	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:Texture")]
	public UTexture2D Texture;

	private static bool Midpoint_IsValid;

	private static int Midpoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:Midpoint")]
	public float Midpoint;

	private static bool Channel_IsValid;

	private static int Channel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:Channel")]
	public FLinearColor Channel;

	private static bool WeightmapInfluence_IsValid;

	private static int WeightmapInfluence_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectDisplacement:WeightmapInfluence")]
	public float WeightmapInfluence;

	private static bool FBrushEffectDisplacement_IsValid;

	private static int FBrushEffectDisplacement_StructSize;

	public FBrushEffectDisplacement Copy()
	{
		return this;
	}

	public static FBrushEffectDisplacement FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectDisplacement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectDisplacement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectDisplacement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectDisplacement(nativeBuffer + arrayIndex * FBrushEffectDisplacement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectDisplacement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectDisplacement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectDisplacement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectDisplacement");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisplacementHeight_Offset), DisplacementHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DisplacementTiling_Offset), DisplacementTiling);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, Texture_Offset), Texture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Midpoint_Offset), Midpoint);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, Channel_Offset), Channel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WeightmapInfluence_Offset), WeightmapInfluence);
	}

	public FBrushEffectDisplacement(IntPtr nativeStruct)
	{
		if (!FBrushEffectDisplacement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectDisplacement");
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

	static FBrushEffectDisplacement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectDisplacement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectDisplacement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectDisplacement");
		FBrushEffectDisplacement_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FBrushEffectDisplacement_IsValid = intPtr != IntPtr.Zero && DisplacementHeight_IsValid && DisplacementTiling_IsValid && Texture_IsValid && Midpoint_IsValid && Channel_IsValid && WeightmapInfluence_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectDisplacement", FBrushEffectDisplacement_IsValid);
	}
}
