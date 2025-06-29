using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectBlurring", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectBlurring
{
	private static bool BlurShape_IsValid;

	private static FFieldAddress BlurShape_PropertyAddress;

	private static int BlurShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectBlurring:bBlurShape")]
	public bool BlurShape;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectBlurring:Radius")]
	public int Radius;

	private static bool FBrushEffectBlurring_IsValid;

	private static int FBrushEffectBlurring_StructSize;

	public FBrushEffectBlurring Copy()
	{
		return this;
	}

	public static FBrushEffectBlurring FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectBlurring(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectBlurring value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectBlurring FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectBlurring(nativeBuffer + arrayIndex * FBrushEffectBlurring_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectBlurring value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectBlurring_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectBlurring_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectBlurring");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BlurShape_Offset), 0, BlurShape_PropertyAddress.Address, BlurShape);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
	}

	public FBrushEffectBlurring(IntPtr nativeStruct)
	{
		if (!FBrushEffectBlurring_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectBlurring");
			BlurShape = false;
			Radius = 0;
		}
		else
		{
			BlurShape = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BlurShape_Offset), 0, BlurShape_PropertyAddress.Address);
			Radius = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
		}
	}

	static FBrushEffectBlurring()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectBlurring)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectBlurring));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectBlurring");
		FBrushEffectBlurring_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BlurShape_PropertyAddress, intPtr, "bBlurShape");
		BlurShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBlurShape");
		BlurShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBlurShape", Classes.FBoolProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FIntProperty);
		FBrushEffectBlurring_IsValid = intPtr != IntPtr.Zero && BlurShape_IsValid && Radius_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectBlurring", FBrushEffectBlurring_IsValid);
	}
}
