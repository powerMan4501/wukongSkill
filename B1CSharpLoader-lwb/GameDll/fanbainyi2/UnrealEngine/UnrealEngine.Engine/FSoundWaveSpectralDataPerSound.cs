using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundWaveSpectralDataPerSound", "Engine", UnrealModuleType.Engine)]
public struct FSoundWaveSpectralDataPerSound
{
	private static bool SpectralData_IsValid;

	private static FFieldAddress SpectralData_PropertyAddress;

	private static int SpectralData_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralDataPerSound:SpectralData")]
	public List<FSoundWaveSpectralData> SpectralData;

	private static bool PlaybackTime_IsValid;

	private static int PlaybackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralDataPerSound:PlaybackTime")]
	public float PlaybackTime;

	private static bool SoundWave_IsValid;

	private static int SoundWave_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundWaveSpectralDataPerSound:SoundWave")]
	public USoundWave SoundWave;

	private static bool FSoundWaveSpectralDataPerSound_IsValid;

	private static int FSoundWaveSpectralDataPerSound_StructSize;

	public FSoundWaveSpectralDataPerSound Copy()
	{
		FSoundWaveSpectralDataPerSound result = this;
		if (SpectralData != null)
		{
			result.SpectralData = new List<FSoundWaveSpectralData>(SpectralData);
		}
		return result;
	}

	public static FSoundWaveSpectralDataPerSound FromNative(IntPtr nativeBuffer)
	{
		return new FSoundWaveSpectralDataPerSound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundWaveSpectralDataPerSound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundWaveSpectralDataPerSound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundWaveSpectralDataPerSound(nativeBuffer + arrayIndex * FSoundWaveSpectralDataPerSound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundWaveSpectralDataPerSound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundWaveSpectralDataPerSound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundWaveSpectralDataPerSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveSpectralDataPerSound");
			return;
		}
		new TArrayCopyMarshaler<FSoundWaveSpectralData>(1, SpectralData_PropertyAddress, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.FromNative, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpectralData_Offset), SpectralData);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlaybackTime_Offset), PlaybackTime);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(nativeStruct, SoundWave_Offset), SoundWave);
	}

	public FSoundWaveSpectralDataPerSound(IntPtr nativeStruct)
	{
		if (!FSoundWaveSpectralDataPerSound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundWaveSpectralDataPerSound");
			SpectralData = null;
			PlaybackTime = 0f;
			SoundWave = null;
		}
		else
		{
			SpectralData = new TArrayCopyMarshaler<FSoundWaveSpectralData>(1, SpectralData_PropertyAddress, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.FromNative, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpectralData_Offset));
			PlaybackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlaybackTime_Offset));
			SoundWave = UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(nativeStruct, SoundWave_Offset));
		}
	}

	static FSoundWaveSpectralDataPerSound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundWaveSpectralDataPerSound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundWaveSpectralDataPerSound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundWaveSpectralDataPerSound");
		FSoundWaveSpectralDataPerSound_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SpectralData_PropertyAddress, intPtr, "SpectralData");
		SpectralData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpectralData");
		SpectralData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpectralData", Classes.FArrayProperty);
		PlaybackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaybackTime");
		PlaybackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaybackTime", Classes.FFloatProperty);
		SoundWave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundWave");
		SoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundWave", Classes.FObjectProperty);
		FSoundWaveSpectralDataPerSound_IsValid = intPtr != IntPtr.Zero && SpectralData_IsValid && PlaybackTime_IsValid && SoundWave_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundWaveSpectralDataPerSound", FSoundWaveSpectralDataPerSound_IsValid);
	}
}
