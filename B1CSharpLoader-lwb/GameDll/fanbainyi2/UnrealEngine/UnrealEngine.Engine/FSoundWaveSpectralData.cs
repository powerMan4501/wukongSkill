using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundWaveSpectralData", "Engine", UnrealModuleType.Engine)]
public struct FSoundWaveSpectralData
{
	private static bool FrequencyHz_IsValid;

	private static int FrequencyHz_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralData:FrequencyHz")]
	public float FrequencyHz;

	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralData:Magnitude")]
	public float Magnitude;

	private static bool NormalizedMagnitude_IsValid;

	private static int NormalizedMagnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralData:NormalizedMagnitude")]
	public float NormalizedMagnitude;

	private static bool FSoundWaveSpectralData_IsValid;

	private static int FSoundWaveSpectralData_StructSize;

	public FSoundWaveSpectralData Copy()
	{
		return this;
	}

	public static FSoundWaveSpectralData FromNative(IntPtr nativeBuffer)
	{
		return new FSoundWaveSpectralData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundWaveSpectralData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundWaveSpectralData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundWaveSpectralData(nativeBuffer + arrayIndex * FSoundWaveSpectralData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundWaveSpectralData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundWaveSpectralData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundWaveSpectralData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveSpectralData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FrequencyHz_Offset), FrequencyHz);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Magnitude_Offset), Magnitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalizedMagnitude_Offset), NormalizedMagnitude);
	}

	public FSoundWaveSpectralData(IntPtr nativeStruct)
	{
		if (!FSoundWaveSpectralData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveSpectralData");
			FrequencyHz = 0f;
			Magnitude = 0f;
			NormalizedMagnitude = 0f;
		}
		else
		{
			FrequencyHz = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FrequencyHz_Offset));
			Magnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Magnitude_Offset));
			NormalizedMagnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalizedMagnitude_Offset));
		}
	}

	static FSoundWaveSpectralData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundWaveSpectralData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundWaveSpectralData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundWaveSpectralData");
		FSoundWaveSpectralData_StructSize = NativeReflection.GetStructSize(intPtr);
		FrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrequencyHz");
		FrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrequencyHz", Classes.FFloatProperty);
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		NormalizedMagnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalizedMagnitude");
		NormalizedMagnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalizedMagnitude", Classes.FFloatProperty);
		FSoundWaveSpectralData_IsValid = intPtr != IntPtr.Zero && FrequencyHz_IsValid && Magnitude_IsValid && NormalizedMagnitude_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundWaveSpectralData", FSoundWaveSpectralData_IsValid);
	}
}
