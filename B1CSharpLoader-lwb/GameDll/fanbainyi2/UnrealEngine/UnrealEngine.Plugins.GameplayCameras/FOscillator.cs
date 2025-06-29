using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.FOscillator", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FOscillator
{
	private static bool Amplitude_IsValid;

	private static int Amplitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.FOscillator:Amplitude")]
	public float Amplitude;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.FOscillator:Frequency")]
	public float Frequency;

	private static bool Waveform_IsValid;

	private static FFieldAddress Waveform_PropertyAddress;

	private static int Waveform_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.FOscillator:Waveform")]
	public EOscillatorWaveform Waveform;

	private static bool FOscillator_IsValid;

	private static int FOscillator_StructSize;

	public FOscillator Copy()
	{
		return this;
	}

	public static FOscillator FromNative(IntPtr nativeBuffer)
	{
		return new FOscillator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOscillator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOscillator(nativeBuffer + arrayIndex * FOscillator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOscillator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOscillator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.FOscillator");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amplitude_Offset), Amplitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		EnumMarshaler<EOscillatorWaveform>.ToNative(IntPtr.Add(nativeStruct, Waveform_Offset), 0, Waveform_PropertyAddress.Address, Waveform);
	}

	public FOscillator(IntPtr nativeStruct)
	{
		if (!FOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.FOscillator");
			Amplitude = 0f;
			Frequency = 0f;
			Waveform = EOscillatorWaveform.SineWave;
		}
		else
		{
			Amplitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amplitude_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Waveform = EnumMarshaler<EOscillatorWaveform>.FromNative(IntPtr.Add(nativeStruct, Waveform_Offset), 0, Waveform_PropertyAddress.Address);
		}
	}

	static FOscillator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOscillator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOscillator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.FOscillator");
		FOscillator_StructSize = NativeReflection.GetStructSize(intPtr);
		Amplitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amplitude");
		Amplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amplitude", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Waveform_PropertyAddress, intPtr, "Waveform");
		Waveform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Waveform");
		Waveform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Waveform", Classes.FEnumProperty);
		FOscillator_IsValid = intPtr != IntPtr.Zero && Amplitude_IsValid && Frequency_IsValid && Waveform_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.FOscillator", FOscillator_IsValid);
	}
}
