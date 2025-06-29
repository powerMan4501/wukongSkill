using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundWaveEnvelopeDataPerSound", "Engine", UnrealModuleType.Engine)]
public struct FSoundWaveEnvelopeDataPerSound
{
	private static bool Envelope_IsValid;

	private static int Envelope_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveEnvelopeDataPerSound:Envelope")]
	public float Envelope;

	private static bool PlaybackTime_IsValid;

	private static int PlaybackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveEnvelopeDataPerSound:PlaybackTime")]
	public float PlaybackTime;

	private static bool SoundWave_IsValid;

	private static int SoundWave_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundWaveEnvelopeDataPerSound:SoundWave")]
	public USoundWave SoundWave;

	private static bool FSoundWaveEnvelopeDataPerSound_IsValid;

	private static int FSoundWaveEnvelopeDataPerSound_StructSize;

	public FSoundWaveEnvelopeDataPerSound Copy()
	{
		return this;
	}

	public static FSoundWaveEnvelopeDataPerSound FromNative(IntPtr nativeBuffer)
	{
		return new FSoundWaveEnvelopeDataPerSound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundWaveEnvelopeDataPerSound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundWaveEnvelopeDataPerSound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundWaveEnvelopeDataPerSound(nativeBuffer + arrayIndex * FSoundWaveEnvelopeDataPerSound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundWaveEnvelopeDataPerSound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundWaveEnvelopeDataPerSound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundWaveEnvelopeDataPerSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveEnvelopeDataPerSound");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Envelope_Offset), Envelope);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlaybackTime_Offset), PlaybackTime);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(nativeStruct, SoundWave_Offset), SoundWave);
	}

	public FSoundWaveEnvelopeDataPerSound(IntPtr nativeStruct)
	{
		if (!FSoundWaveEnvelopeDataPerSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveEnvelopeDataPerSound");
			Envelope = 0f;
			PlaybackTime = 0f;
			SoundWave = null;
		}
		else
		{
			Envelope = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Envelope_Offset));
			PlaybackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlaybackTime_Offset));
			SoundWave = UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(nativeStruct, SoundWave_Offset));
		}
	}

	static FSoundWaveEnvelopeDataPerSound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundWaveEnvelopeDataPerSound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundWaveEnvelopeDataPerSound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundWaveEnvelopeDataPerSound");
		FSoundWaveEnvelopeDataPerSound_StructSize = NativeReflection.GetStructSize(intPtr);
		Envelope_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Envelope");
		Envelope_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Envelope", Classes.FFloatProperty);
		PlaybackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaybackTime");
		PlaybackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaybackTime", Classes.FFloatProperty);
		SoundWave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundWave");
		SoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundWave", Classes.FObjectProperty);
		FSoundWaveEnvelopeDataPerSound_IsValid = intPtr != IntPtr.Zero && Envelope_IsValid && PlaybackTime_IsValid && SoundWave_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundWaveEnvelopeDataPerSound", FSoundWaveEnvelopeDataPerSound_IsValid);
	}
}
