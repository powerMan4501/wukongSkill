using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.PerlinNoiseShaker", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FPerlinNoiseShaker
{
	private static bool Amplitude_IsValid;

	private static int Amplitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.PerlinNoiseShaker:Amplitude")]
	public float Amplitude;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.PerlinNoiseShaker:Frequency")]
	public float Frequency;

	private static bool FPerlinNoiseShaker_IsValid;

	private static int FPerlinNoiseShaker_StructSize;

	public FPerlinNoiseShaker Copy()
	{
		return this;
	}

	public static FPerlinNoiseShaker FromNative(IntPtr nativeBuffer)
	{
		return new FPerlinNoiseShaker(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPerlinNoiseShaker value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPerlinNoiseShaker FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPerlinNoiseShaker(nativeBuffer + arrayIndex * FPerlinNoiseShaker_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPerlinNoiseShaker value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPerlinNoiseShaker_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPerlinNoiseShaker_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.PerlinNoiseShaker");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amplitude_Offset), Amplitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
	}

	public FPerlinNoiseShaker(IntPtr nativeStruct)
	{
		if (!FPerlinNoiseShaker_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.PerlinNoiseShaker");
			Amplitude = 0f;
			Frequency = 0f;
		}
		else
		{
			Amplitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amplitude_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
		}
	}

	static FPerlinNoiseShaker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPerlinNoiseShaker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPerlinNoiseShaker));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.PerlinNoiseShaker");
		FPerlinNoiseShaker_StructSize = NativeReflection.GetStructSize(intPtr);
		Amplitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amplitude");
		Amplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amplitude", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		FPerlinNoiseShaker_IsValid = intPtr != IntPtr.Zero && Amplitude_IsValid && Frequency_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.PerlinNoiseShaker", FPerlinNoiseShaker_IsValid);
	}
}
