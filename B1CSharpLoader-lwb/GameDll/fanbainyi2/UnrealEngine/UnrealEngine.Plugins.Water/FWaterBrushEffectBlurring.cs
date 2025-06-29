using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBrushEffectBlurring", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBrushEffectBlurring
{
	private static bool BlurShape_IsValid;

	private static FFieldAddress BlurShape_PropertyAddress;

	private static int BlurShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectBlurring:bBlurShape")]
	public bool BlurShape;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBrushEffectBlurring:Radius")]
	public int Radius;

	private static bool FWaterBrushEffectBlurring_IsValid;

	private static int FWaterBrushEffectBlurring_StructSize;

	public FWaterBrushEffectBlurring Copy()
	{
		return this;
	}

	public static FWaterBrushEffectBlurring FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBrushEffectBlurring(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBrushEffectBlurring value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBrushEffectBlurring FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBrushEffectBlurring(nativeBuffer + arrayIndex * FWaterBrushEffectBlurring_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBrushEffectBlurring value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBrushEffectBlurring_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectBlurring_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectBlurring");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BlurShape_Offset), 0, BlurShape_PropertyAddress.Address, BlurShape);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
	}

	public FWaterBrushEffectBlurring(IntPtr nativeStruct)
	{
		if (!FWaterBrushEffectBlurring_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBrushEffectBlurring");
			BlurShape = false;
			Radius = 0;
		}
		else
		{
			BlurShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BlurShape_Offset), 0, BlurShape_PropertyAddress.Address);
			Radius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
		}
	}

	static FWaterBrushEffectBlurring()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBrushEffectBlurring)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBrushEffectBlurring));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBrushEffectBlurring");
		FWaterBrushEffectBlurring_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BlurShape_PropertyAddress, intPtr, "bBlurShape");
		BlurShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlurShape");
		BlurShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlurShape", Classes.FBoolProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FIntProperty);
		FWaterBrushEffectBlurring_IsValid = intPtr != IntPtr.Zero && BlurShape_IsValid && Radius_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBrushEffectBlurring", FWaterBrushEffectBlurring_IsValid);
	}
}
