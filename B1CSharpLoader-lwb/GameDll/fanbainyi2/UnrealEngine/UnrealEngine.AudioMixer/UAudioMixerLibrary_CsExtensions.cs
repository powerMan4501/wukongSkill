using System.Collections.Generic;
using UnrealEngine.Engine;

namespace UnrealEngine.AudioMixer;

public static class UAudioMixerLibrary_CsExtensions
{
	public static void SwapAudioOutputDevice(this UWorld WorldContextObject, string NewDeviceId, FOnCompletedDeviceSwap OnCompletedDeviceSwap)
	{
		UAudioMixerLibrary.SwapAudioOutputDevice(WorldContextObject, NewDeviceId, OnCompletedDeviceSwap);
	}

	public static USoundWave StopRecordingOutput(this UWorld WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, USoundSubmix SubmixToRecord, USoundWave ExistingSoundWaveToOverwrite)
	{
		return UAudioMixerLibrary.StopRecordingOutput(WorldContextObject, ExportType, Name, Path, SubmixToRecord, ExistingSoundWaveToOverwrite);
	}

	public static void StopAudioBus(this UWorld WorldContextObject, UAudioBus AudioBus)
	{
		UAudioMixerLibrary.StopAudioBus(WorldContextObject, AudioBus);
	}

	public static void StopAnalyzingOutput(this UWorld WorldContextObject, USoundSubmix SubmixToStopAnalyzing)
	{
		UAudioMixerLibrary.StopAnalyzingOutput(WorldContextObject, SubmixToStopAnalyzing);
	}

	public static void StartRecordingOutput(this UWorld WorldContextObject, float ExpectedDuration, USoundSubmix SubmixToRecord)
	{
		UAudioMixerLibrary.StartRecordingOutput(WorldContextObject, ExpectedDuration, SubmixToRecord);
	}

	public static void StartAudioBus(this UWorld WorldContextObject, UAudioBus AudioBus)
	{
		UAudioMixerLibrary.StartAudioBus(WorldContextObject, AudioBus);
	}

	public static void StartAnalyzingOutput(this UWorld WorldContextObject, USoundSubmix SubmixToAnalyze, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType)
	{
		UAudioMixerLibrary.StartAnalyzingOutput(WorldContextObject, SubmixToAnalyze, FFTSize, InterpolationMethod, WindowType, HopSize, SpectrumType);
	}

	public static void SetSubmixEffectChainOverride(this UWorld WorldContextObject, USoundSubmix SoundSubmix, List<USoundEffectSubmixPreset> SubmixEffectPresetChain, float FadeTimeSec)
	{
		UAudioMixerLibrary.SetSubmixEffectChainOverride(WorldContextObject, SoundSubmix, SubmixEffectPresetChain, FadeTimeSec);
	}

	public static void SetBypassSourceEffectChainEntry(this UWorld WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed)
	{
		UAudioMixerLibrary.SetBypassSourceEffectChainEntry(WorldContextObject, PresetChain, EntryIndex, bBypassed);
	}

	public static void ResumeRecordingOutput(this UWorld WorldContextObject, USoundSubmix SubmixToPause)
	{
		UAudioMixerLibrary.ResumeRecordingOutput(WorldContextObject, SubmixToPause);
	}

	public static void ReplaceSubmixEffect(this UWorld WorldContextObject, USoundSubmix InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		UAudioMixerLibrary.ReplaceSubmixEffect(WorldContextObject, InSoundSubmix, SubmixChainIndex, SubmixEffectPreset);
	}

	public static void RemoveSubmixEffectAtIndex(this UWorld WorldContextObject, USoundSubmix SoundSubmix, int SubmixChainIndex)
	{
		UAudioMixerLibrary.RemoveSubmixEffectAtIndex(WorldContextObject, SoundSubmix, SubmixChainIndex);
	}

	public static void RemoveSubmixEffect(this UWorld WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		UAudioMixerLibrary.RemoveSubmixEffect(WorldContextObject, SoundSubmix, SubmixEffectPreset);
	}

	public static void RemoveSourceEffectFromPresetChain(this UWorld WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex)
	{
		UAudioMixerLibrary.RemoveSourceEffectFromPresetChain(WorldContextObject, PresetChain, EntryIndex);
	}

	public static void RemoveMasterSubmixEffect(this UWorld WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		UAudioMixerLibrary.RemoveMasterSubmixEffect(WorldContextObject, SubmixEffectPreset);
	}

	public static void PauseRecordingOutput(this UWorld WorldContextObject, USoundSubmix SubmixToPause)
	{
		UAudioMixerLibrary.PauseRecordingOutput(WorldContextObject, SubmixToPause);
	}

	public static bool IsAudioBusActive(this UWorld WorldContextObject, UAudioBus AudioBus)
	{
		return UAudioMixerLibrary.IsAudioBusActive(WorldContextObject, AudioBus);
	}

	public static void GetPhaseForFrequencies(this UWorld WorldContextObject, List<float> Frequencies, out List<float> Phases, USoundSubmix SubmixToAnalyze)
	{
		UAudioMixerLibrary.GetPhaseForFrequencies(WorldContextObject, Frequencies, out Phases, SubmixToAnalyze);
	}

	public static int GetNumberOfEntriesInSourceEffectChain(this UWorld WorldContextObject, USoundEffectSourcePresetChain PresetChain)
	{
		return UAudioMixerLibrary.GetNumberOfEntriesInSourceEffectChain(WorldContextObject, PresetChain);
	}

	public static void GetMagnitudeForFrequencies(this UWorld WorldContextObject, List<float> Frequencies, out List<float> Magnitudes, USoundSubmix SubmixToAnalyze)
	{
		UAudioMixerLibrary.GetMagnitudeForFrequencies(WorldContextObject, Frequencies, out Magnitudes, SubmixToAnalyze);
	}

	public static void GetCurrentAudioOutputDeviceName(this UWorld WorldContextObject, FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent)
	{
		UAudioMixerLibrary.GetCurrentAudioOutputDeviceName(WorldContextObject, OnObtainCurrentDeviceEvent);
	}

	public static void GetAvailableAudioOutputDevices(this UWorld WorldContextObject, FOnAudioOutputDevicesObtained OnObtainDevicesEvent)
	{
		UAudioMixerLibrary.GetAvailableAudioOutputDevices(WorldContextObject, OnObtainDevicesEvent);
	}

	public static void ClearSubmixEffects(this UWorld WorldContextObject, USoundSubmix SoundSubmix)
	{
		UAudioMixerLibrary.ClearSubmixEffects(WorldContextObject, SoundSubmix);
	}

	public static void ClearSubmixEffectChainOverride(this UWorld WorldContextObject, USoundSubmix SoundSubmix, float FadeTimeSec)
	{
		UAudioMixerLibrary.ClearSubmixEffectChainOverride(WorldContextObject, SoundSubmix, FadeTimeSec);
	}

	public static void ClearMasterSubmixEffects(this UWorld WorldContextObject)
	{
		UAudioMixerLibrary.ClearMasterSubmixEffects(WorldContextObject);
	}

	public static int AddSubmixEffect(this UWorld WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		return UAudioMixerLibrary.AddSubmixEffect(WorldContextObject, SoundSubmix, SubmixEffectPreset);
	}

	public static void AddSourceEffectToPresetChain(this UWorld WorldContextObject, USoundEffectSourcePresetChain PresetChain, FSourceEffectChainEntry Entry)
	{
		UAudioMixerLibrary.AddSourceEffectToPresetChain(WorldContextObject, PresetChain, Entry);
	}

	public static void AddMasterSubmixEffect(this UWorld WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		UAudioMixerLibrary.AddMasterSubmixEffect(WorldContextObject, SubmixEffectPreset);
	}
}
