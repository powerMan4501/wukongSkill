using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectFilterAudioBusModulationSettings
{
	private static bool AudioBus_IsValid;

	private static int AudioBus_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:AudioBus")]
	public UAudioBus AudioBus;

	private static bool EnvelopeFollowerAttackTimeMsec_IsValid;

	private static int EnvelopeFollowerAttackTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeFollowerAttackTimeMsec")]
	public int EnvelopeFollowerAttackTimeMsec;

	private static bool EnvelopeFollowerReleaseTimeMsec_IsValid;

	private static int EnvelopeFollowerReleaseTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeFollowerReleaseTimeMsec")]
	public int EnvelopeFollowerReleaseTimeMsec;

	private static bool EnvelopeGainMultiplier_IsValid;

	private static int EnvelopeGainMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:EnvelopeGainMultiplier")]
	public float EnvelopeGainMultiplier;

	private static bool MinFrequencyModulation_IsValid;

	private static int MinFrequencyModulation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MinFrequencyModulation")]
	public float MinFrequencyModulation;

	private static bool MaxFrequencyModulation_IsValid;

	private static int MaxFrequencyModulation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MaxFrequencyModulation")]
	public float MaxFrequencyModulation;

	private static bool MinResonanceModulation_IsValid;

	private static int MinResonanceModulation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MinResonanceModulation")]
	public float MinResonanceModulation;

	private static bool MaxResonanceModulation_IsValid;

	private static int MaxResonanceModulation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings:MaxResonanceModulation")]
	public float MaxResonanceModulation;

	private static bool FSourceEffectFilterAudioBusModulationSettings_IsValid;

	private static int FSourceEffectFilterAudioBusModulationSettings_StructSize;

	public FSourceEffectFilterAudioBusModulationSettings Copy()
	{
		return this;
	}

	public static FSourceEffectFilterAudioBusModulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectFilterAudioBusModulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectFilterAudioBusModulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectFilterAudioBusModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectFilterAudioBusModulationSettings(nativeBuffer + arrayIndex * FSourceEffectFilterAudioBusModulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectFilterAudioBusModulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectFilterAudioBusModulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectFilterAudioBusModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings");
			return;
		}
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(nativeStruct, AudioBus_Offset), AudioBus);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EnvelopeFollowerAttackTimeMsec_Offset), EnvelopeFollowerAttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EnvelopeFollowerReleaseTimeMsec_Offset), EnvelopeFollowerReleaseTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EnvelopeGainMultiplier_Offset), EnvelopeGainMultiplier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinFrequencyModulation_Offset), MinFrequencyModulation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxFrequencyModulation_Offset), MaxFrequencyModulation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinResonanceModulation_Offset), MinResonanceModulation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxResonanceModulation_Offset), MaxResonanceModulation);
	}

	public FSourceEffectFilterAudioBusModulationSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectFilterAudioBusModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings");
			AudioBus = null;
			EnvelopeFollowerAttackTimeMsec = 0;
			EnvelopeFollowerReleaseTimeMsec = 0;
			EnvelopeGainMultiplier = 0f;
			MinFrequencyModulation = 0f;
			MaxFrequencyModulation = 0f;
			MinResonanceModulation = 0f;
			MaxResonanceModulation = 0f;
		}
		else
		{
			AudioBus = UObjectMarshaler<UAudioBus>.FromNative(IntPtr.Add(nativeStruct, AudioBus_Offset));
			EnvelopeFollowerAttackTimeMsec = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EnvelopeFollowerAttackTimeMsec_Offset));
			EnvelopeFollowerReleaseTimeMsec = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EnvelopeFollowerReleaseTimeMsec_Offset));
			EnvelopeGainMultiplier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EnvelopeGainMultiplier_Offset));
			MinFrequencyModulation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinFrequencyModulation_Offset));
			MaxFrequencyModulation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxFrequencyModulation_Offset));
			MinResonanceModulation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinResonanceModulation_Offset));
			MaxResonanceModulation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxResonanceModulation_Offset));
		}
	}

	static FSourceEffectFilterAudioBusModulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectFilterAudioBusModulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectFilterAudioBusModulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings");
		FSourceEffectFilterAudioBusModulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AudioBus");
		AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AudioBus", Classes.FObjectProperty);
		EnvelopeFollowerAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerAttackTimeMsec");
		EnvelopeFollowerAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerAttackTimeMsec", Classes.FIntProperty);
		EnvelopeFollowerReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerReleaseTimeMsec");
		EnvelopeFollowerReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerReleaseTimeMsec", Classes.FIntProperty);
		EnvelopeGainMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeGainMultiplier");
		EnvelopeGainMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeGainMultiplier", Classes.FFloatProperty);
		MinFrequencyModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinFrequencyModulation");
		MinFrequencyModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinFrequencyModulation", Classes.FFloatProperty);
		MaxFrequencyModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxFrequencyModulation");
		MaxFrequencyModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxFrequencyModulation", Classes.FFloatProperty);
		MinResonanceModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinResonanceModulation");
		MinResonanceModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinResonanceModulation", Classes.FFloatProperty);
		MaxResonanceModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxResonanceModulation");
		MaxResonanceModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxResonanceModulation", Classes.FFloatProperty);
		FSourceEffectFilterAudioBusModulationSettings_IsValid = intPtr != IntPtr.Zero && AudioBus_IsValid && EnvelopeFollowerAttackTimeMsec_IsValid && EnvelopeFollowerReleaseTimeMsec_IsValid && EnvelopeGainMultiplier_IsValid && MinFrequencyModulation_IsValid && MaxFrequencyModulation_IsValid && MinResonanceModulation_IsValid && MaxResonanceModulation_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings", FSourceEffectFilterAudioBusModulationSettings_IsValid);
	}
}
