using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.PassiveSoundMixModifier", "Engine", UnrealModuleType.Engine)]
public struct FPassiveSoundMixModifier
{
	private static bool SoundMix_IsValid;

	private static int SoundMix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.PassiveSoundMixModifier:SoundMix")]
	public USoundMix SoundMix;

	private static bool MinVolumeThreshold_IsValid;

	private static int MinVolumeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PassiveSoundMixModifier:MinVolumeThreshold")]
	public float MinVolumeThreshold;

	private static bool MaxVolumeThreshold_IsValid;

	private static int MaxVolumeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PassiveSoundMixModifier:MaxVolumeThreshold")]
	public float MaxVolumeThreshold;

	private static bool FPassiveSoundMixModifier_IsValid;

	private static int FPassiveSoundMixModifier_StructSize;

	public FPassiveSoundMixModifier Copy()
	{
		return this;
	}

	public static FPassiveSoundMixModifier FromNative(IntPtr nativeBuffer)
	{
		return new FPassiveSoundMixModifier(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPassiveSoundMixModifier value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPassiveSoundMixModifier FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPassiveSoundMixModifier(nativeBuffer + arrayIndex * FPassiveSoundMixModifier_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPassiveSoundMixModifier value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPassiveSoundMixModifier_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPassiveSoundMixModifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PassiveSoundMixModifier");
			return;
		}
		UObjectMarshaler<USoundMix>.ToNative(IntPtr.Add(nativeStruct, SoundMix_Offset), SoundMix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinVolumeThreshold_Offset), MinVolumeThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxVolumeThreshold_Offset), MaxVolumeThreshold);
	}

	public FPassiveSoundMixModifier(IntPtr nativeStruct)
	{
		if (!FPassiveSoundMixModifier_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PassiveSoundMixModifier");
			SoundMix = null;
			MinVolumeThreshold = 0f;
			MaxVolumeThreshold = 0f;
		}
		else
		{
			SoundMix = UObjectMarshaler<USoundMix>.FromNative(IntPtr.Add(nativeStruct, SoundMix_Offset));
			MinVolumeThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinVolumeThreshold_Offset));
			MaxVolumeThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxVolumeThreshold_Offset));
		}
	}

	static FPassiveSoundMixModifier()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPassiveSoundMixModifier)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPassiveSoundMixModifier));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PassiveSoundMixModifier");
		FPassiveSoundMixModifier_StructSize = NativeReflection.GetStructSize(intPtr);
		SoundMix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundMix");
		SoundMix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundMix", Classes.FObjectProperty);
		MinVolumeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinVolumeThreshold");
		MinVolumeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinVolumeThreshold", Classes.FFloatProperty);
		MaxVolumeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxVolumeThreshold");
		MaxVolumeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxVolumeThreshold", Classes.FFloatProperty);
		FPassiveSoundMixModifier_IsValid = intPtr != IntPtr.Zero && SoundMix_IsValid && MinVolumeThreshold_IsValid && MaxVolumeThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PassiveSoundMixModifier", FPassiveSoundMixModifier_IsValid);
	}
}
