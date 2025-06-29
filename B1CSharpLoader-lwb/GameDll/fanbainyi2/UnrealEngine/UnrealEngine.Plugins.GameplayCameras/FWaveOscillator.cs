using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GameplayCameras;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GameplayCameras.WaveOscillator", "GameplayCameras", UnrealModuleType.EnginePlugin)]
public struct FWaveOscillator
{
	private static bool Amplitude_IsValid;

	private static int Amplitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.WaveOscillator:Amplitude")]
	public float Amplitude;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.WaveOscillator:Frequency")]
	public float Frequency;

	private static bool InitialOffsetType_IsValid;

	private static FFieldAddress InitialOffsetType_PropertyAddress;

	private static int InitialOffsetType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GameplayCameras.WaveOscillator:InitialOffsetType")]
	public EInitialWaveOscillatorOffsetType InitialOffsetType;

	private static bool FWaveOscillator_IsValid;

	private static int FWaveOscillator_StructSize;

	public FWaveOscillator Copy()
	{
		return this;
	}

	public static FWaveOscillator FromNative(IntPtr nativeBuffer)
	{
		return new FWaveOscillator(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaveOscillator value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaveOscillator FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaveOscillator(nativeBuffer + arrayIndex * FWaveOscillator_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaveOscillator value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaveOscillator_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaveOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.WaveOscillator");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amplitude_Offset), Amplitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		EnumMarshaler<EInitialWaveOscillatorOffsetType>.ToNative(IntPtr.Add(nativeStruct, InitialOffsetType_Offset), 0, InitialOffsetType_PropertyAddress.Address, InitialOffsetType);
	}

	public FWaveOscillator(IntPtr nativeStruct)
	{
		if (!FWaveOscillator_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GameplayCameras.WaveOscillator");
			Amplitude = 0f;
			Frequency = 0f;
			InitialOffsetType = EInitialWaveOscillatorOffsetType.Random;
		}
		else
		{
			Amplitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amplitude_Offset));
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			InitialOffsetType = EnumMarshaler<EInitialWaveOscillatorOffsetType>.FromNative(IntPtr.Add(nativeStruct, InitialOffsetType_Offset), 0, InitialOffsetType_PropertyAddress.Address);
		}
	}

	static FWaveOscillator()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaveOscillator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaveOscillator));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GameplayCameras.WaveOscillator");
		FWaveOscillator_StructSize = NativeReflection.GetStructSize(intPtr);
		Amplitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amplitude");
		Amplitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amplitude", Classes.FFloatProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InitialOffsetType_PropertyAddress, intPtr, "InitialOffsetType");
		InitialOffsetType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialOffsetType");
		InitialOffsetType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialOffsetType", Classes.FEnumProperty);
		FWaveOscillator_IsValid = intPtr != IntPtr.Zero && Amplitude_IsValid && Frequency_IsValid && InitialOffsetType_IsValid;
		NativeReflection.LogStructIsValid("/Script/GameplayCameras.WaveOscillator", FWaveOscillator_IsValid);
	}
}
