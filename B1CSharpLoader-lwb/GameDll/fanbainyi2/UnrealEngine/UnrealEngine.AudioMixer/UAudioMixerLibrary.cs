using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary", "AudioMixer", UnrealModuleType.Engine)]
public class UAudioMixerLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TrimAudioCache_IsValid;

	private static IntPtr TrimAudioCache_FunctionAddress;

	private static int TrimAudioCache_ParamsSize;

	private static bool TrimAudioCache_InMegabytesToFree_IsValid;

	private static FFieldAddress TrimAudioCache_InMegabytesToFree_PropertyAddress;

	private static int TrimAudioCache_InMegabytesToFree_Offset;

	private static bool TrimAudioCache_ReturnValue_IsValid;

	private static FFieldAddress TrimAudioCache_ReturnValue_PropertyAddress;

	private static int TrimAudioCache_ReturnValue_Offset;

	private static bool SwapAudioOutputDevice_IsValid;

	private static IntPtr SwapAudioOutputDevice_FunctionAddress;

	private static int SwapAudioOutputDevice_ParamsSize;

	private static bool SwapAudioOutputDevice_WorldContextObject_IsValid;

	private static FFieldAddress SwapAudioOutputDevice_WorldContextObject_PropertyAddress;

	private static int SwapAudioOutputDevice_WorldContextObject_Offset;

	private static bool SwapAudioOutputDevice_NewDeviceId_IsValid;

	private static FFieldAddress SwapAudioOutputDevice_NewDeviceId_PropertyAddress;

	private static int SwapAudioOutputDevice_NewDeviceId_Offset;

	private static bool SwapAudioOutputDevice_OnCompletedDeviceSwap_IsValid;

	private static FFieldAddress SwapAudioOutputDevice_OnCompletedDeviceSwap_PropertyAddress;

	private static int SwapAudioOutputDevice_OnCompletedDeviceSwap_Offset;

	private static bool StopRecordingOutput_IsValid;

	private static IntPtr StopRecordingOutput_FunctionAddress;

	private static int StopRecordingOutput_ParamsSize;

	private static bool StopRecordingOutput_WorldContextObject_IsValid;

	private static FFieldAddress StopRecordingOutput_WorldContextObject_PropertyAddress;

	private static int StopRecordingOutput_WorldContextObject_Offset;

	private static bool StopRecordingOutput_ExportType_IsValid;

	private static FFieldAddress StopRecordingOutput_ExportType_PropertyAddress;

	private static int StopRecordingOutput_ExportType_Offset;

	private static bool StopRecordingOutput_Name_IsValid;

	private static FFieldAddress StopRecordingOutput_Name_PropertyAddress;

	private static int StopRecordingOutput_Name_Offset;

	private static bool StopRecordingOutput_Path_IsValid;

	private static FFieldAddress StopRecordingOutput_Path_PropertyAddress;

	private static int StopRecordingOutput_Path_Offset;

	private static bool StopRecordingOutput_SubmixToRecord_IsValid;

	private static FFieldAddress StopRecordingOutput_SubmixToRecord_PropertyAddress;

	private static int StopRecordingOutput_SubmixToRecord_Offset;

	private static bool StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid;

	private static FFieldAddress StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress;

	private static int StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset;

	private static bool StopRecordingOutput_ReturnValue_IsValid;

	private static FFieldAddress StopRecordingOutput_ReturnValue_PropertyAddress;

	private static int StopRecordingOutput_ReturnValue_Offset;

	private static bool StopAudioBus_IsValid;

	private static IntPtr StopAudioBus_FunctionAddress;

	private static int StopAudioBus_ParamsSize;

	private static bool StopAudioBus_WorldContextObject_IsValid;

	private static FFieldAddress StopAudioBus_WorldContextObject_PropertyAddress;

	private static int StopAudioBus_WorldContextObject_Offset;

	private static bool StopAudioBus_AudioBus_IsValid;

	private static FFieldAddress StopAudioBus_AudioBus_PropertyAddress;

	private static int StopAudioBus_AudioBus_Offset;

	private static bool StopAnalyzingOutput_IsValid;

	private static IntPtr StopAnalyzingOutput_FunctionAddress;

	private static int StopAnalyzingOutput_ParamsSize;

	private static bool StopAnalyzingOutput_WorldContextObject_IsValid;

	private static FFieldAddress StopAnalyzingOutput_WorldContextObject_PropertyAddress;

	private static int StopAnalyzingOutput_WorldContextObject_Offset;

	private static bool StopAnalyzingOutput_SubmixToStopAnalyzing_IsValid;

	private static FFieldAddress StopAnalyzingOutput_SubmixToStopAnalyzing_PropertyAddress;

	private static int StopAnalyzingOutput_SubmixToStopAnalyzing_Offset;

	private static bool StartRecordingOutput_IsValid;

	private static IntPtr StartRecordingOutput_FunctionAddress;

	private static int StartRecordingOutput_ParamsSize;

	private static bool StartRecordingOutput_WorldContextObject_IsValid;

	private static FFieldAddress StartRecordingOutput_WorldContextObject_PropertyAddress;

	private static int StartRecordingOutput_WorldContextObject_Offset;

	private static bool StartRecordingOutput_ExpectedDuration_IsValid;

	private static FFieldAddress StartRecordingOutput_ExpectedDuration_PropertyAddress;

	private static int StartRecordingOutput_ExpectedDuration_Offset;

	private static bool StartRecordingOutput_SubmixToRecord_IsValid;

	private static FFieldAddress StartRecordingOutput_SubmixToRecord_PropertyAddress;

	private static int StartRecordingOutput_SubmixToRecord_Offset;

	private static bool StartAudioBus_IsValid;

	private static IntPtr StartAudioBus_FunctionAddress;

	private static int StartAudioBus_ParamsSize;

	private static bool StartAudioBus_WorldContextObject_IsValid;

	private static FFieldAddress StartAudioBus_WorldContextObject_PropertyAddress;

	private static int StartAudioBus_WorldContextObject_Offset;

	private static bool StartAudioBus_AudioBus_IsValid;

	private static FFieldAddress StartAudioBus_AudioBus_PropertyAddress;

	private static int StartAudioBus_AudioBus_Offset;

	private static bool StartAnalyzingOutput_IsValid;

	private static IntPtr StartAnalyzingOutput_FunctionAddress;

	private static int StartAnalyzingOutput_ParamsSize;

	private static bool StartAnalyzingOutput_WorldContextObject_IsValid;

	private static FFieldAddress StartAnalyzingOutput_WorldContextObject_PropertyAddress;

	private static int StartAnalyzingOutput_WorldContextObject_Offset;

	private static bool StartAnalyzingOutput_SubmixToAnalyze_IsValid;

	private static FFieldAddress StartAnalyzingOutput_SubmixToAnalyze_PropertyAddress;

	private static int StartAnalyzingOutput_SubmixToAnalyze_Offset;

	private static bool StartAnalyzingOutput_FFTSize_IsValid;

	private static FFieldAddress StartAnalyzingOutput_FFTSize_PropertyAddress;

	private static int StartAnalyzingOutput_FFTSize_Offset;

	private static bool StartAnalyzingOutput_InterpolationMethod_IsValid;

	private static FFieldAddress StartAnalyzingOutput_InterpolationMethod_PropertyAddress;

	private static int StartAnalyzingOutput_InterpolationMethod_Offset;

	private static bool StartAnalyzingOutput_WindowType_IsValid;

	private static FFieldAddress StartAnalyzingOutput_WindowType_PropertyAddress;

	private static int StartAnalyzingOutput_WindowType_Offset;

	private static bool StartAnalyzingOutput_HopSize_IsValid;

	private static FFieldAddress StartAnalyzingOutput_HopSize_PropertyAddress;

	private static int StartAnalyzingOutput_HopSize_Offset;

	private static bool StartAnalyzingOutput_SpectrumType_IsValid;

	private static FFieldAddress StartAnalyzingOutput_SpectrumType_PropertyAddress;

	private static int StartAnalyzingOutput_SpectrumType_Offset;

	private static bool SetSubmixEffectChainOverride_IsValid;

	private static IntPtr SetSubmixEffectChainOverride_FunctionAddress;

	private static int SetSubmixEffectChainOverride_ParamsSize;

	private static bool SetSubmixEffectChainOverride_WorldContextObject_IsValid;

	private static FFieldAddress SetSubmixEffectChainOverride_WorldContextObject_PropertyAddress;

	private static int SetSubmixEffectChainOverride_WorldContextObject_Offset;

	private static bool SetSubmixEffectChainOverride_SoundSubmix_IsValid;

	private static FFieldAddress SetSubmixEffectChainOverride_SoundSubmix_PropertyAddress;

	private static int SetSubmixEffectChainOverride_SoundSubmix_Offset;

	private static bool SetSubmixEffectChainOverride_SubmixEffectPresetChain_IsValid;

	private static FFieldAddress SetSubmixEffectChainOverride_SubmixEffectPresetChain_PropertyAddress;

	private static int SetSubmixEffectChainOverride_SubmixEffectPresetChain_Offset;

	private static bool SetSubmixEffectChainOverride_FadeTimeSec_IsValid;

	private static FFieldAddress SetSubmixEffectChainOverride_FadeTimeSec_PropertyAddress;

	private static int SetSubmixEffectChainOverride_FadeTimeSec_Offset;

	private static bool SetBypassSourceEffectChainEntry_IsValid;

	private static IntPtr SetBypassSourceEffectChainEntry_FunctionAddress;

	private static int SetBypassSourceEffectChainEntry_ParamsSize;

	private static bool SetBypassSourceEffectChainEntry_WorldContextObject_IsValid;

	private static FFieldAddress SetBypassSourceEffectChainEntry_WorldContextObject_PropertyAddress;

	private static int SetBypassSourceEffectChainEntry_WorldContextObject_Offset;

	private static bool SetBypassSourceEffectChainEntry_PresetChain_IsValid;

	private static FFieldAddress SetBypassSourceEffectChainEntry_PresetChain_PropertyAddress;

	private static int SetBypassSourceEffectChainEntry_PresetChain_Offset;

	private static bool SetBypassSourceEffectChainEntry_EntryIndex_IsValid;

	private static FFieldAddress SetBypassSourceEffectChainEntry_EntryIndex_PropertyAddress;

	private static int SetBypassSourceEffectChainEntry_EntryIndex_Offset;

	private static bool SetBypassSourceEffectChainEntry_bBypassed_IsValid;

	private static FFieldAddress SetBypassSourceEffectChainEntry_bBypassed_PropertyAddress;

	private static int SetBypassSourceEffectChainEntry_bBypassed_Offset;

	private static bool ResumeRecordingOutput_IsValid;

	private static IntPtr ResumeRecordingOutput_FunctionAddress;

	private static int ResumeRecordingOutput_ParamsSize;

	private static bool ResumeRecordingOutput_WorldContextObject_IsValid;

	private static FFieldAddress ResumeRecordingOutput_WorldContextObject_PropertyAddress;

	private static int ResumeRecordingOutput_WorldContextObject_Offset;

	private static bool ResumeRecordingOutput_SubmixToPause_IsValid;

	private static FFieldAddress ResumeRecordingOutput_SubmixToPause_PropertyAddress;

	private static int ResumeRecordingOutput_SubmixToPause_Offset;

	private static bool ReplaceSubmixEffect_IsValid;

	private static IntPtr ReplaceSubmixEffect_FunctionAddress;

	private static int ReplaceSubmixEffect_ParamsSize;

	private static bool ReplaceSubmixEffect_WorldContextObject_IsValid;

	private static FFieldAddress ReplaceSubmixEffect_WorldContextObject_PropertyAddress;

	private static int ReplaceSubmixEffect_WorldContextObject_Offset;

	private static bool ReplaceSubmixEffect_InSoundSubmix_IsValid;

	private static FFieldAddress ReplaceSubmixEffect_InSoundSubmix_PropertyAddress;

	private static int ReplaceSubmixEffect_InSoundSubmix_Offset;

	private static bool ReplaceSubmixEffect_SubmixChainIndex_IsValid;

	private static FFieldAddress ReplaceSubmixEffect_SubmixChainIndex_PropertyAddress;

	private static int ReplaceSubmixEffect_SubmixChainIndex_Offset;

	private static bool ReplaceSubmixEffect_SubmixEffectPreset_IsValid;

	private static FFieldAddress ReplaceSubmixEffect_SubmixEffectPreset_PropertyAddress;

	private static int ReplaceSubmixEffect_SubmixEffectPreset_Offset;

	private static bool RemoveSubmixEffectAtIndex_IsValid;

	private static IntPtr RemoveSubmixEffectAtIndex_FunctionAddress;

	private static int RemoveSubmixEffectAtIndex_ParamsSize;

	private static bool RemoveSubmixEffectAtIndex_WorldContextObject_IsValid;

	private static FFieldAddress RemoveSubmixEffectAtIndex_WorldContextObject_PropertyAddress;

	private static int RemoveSubmixEffectAtIndex_WorldContextObject_Offset;

	private static bool RemoveSubmixEffectAtIndex_SoundSubmix_IsValid;

	private static FFieldAddress RemoveSubmixEffectAtIndex_SoundSubmix_PropertyAddress;

	private static int RemoveSubmixEffectAtIndex_SoundSubmix_Offset;

	private static bool RemoveSubmixEffectAtIndex_SubmixChainIndex_IsValid;

	private static FFieldAddress RemoveSubmixEffectAtIndex_SubmixChainIndex_PropertyAddress;

	private static int RemoveSubmixEffectAtIndex_SubmixChainIndex_Offset;

	private static bool RemoveSubmixEffect_IsValid;

	private static IntPtr RemoveSubmixEffect_FunctionAddress;

	private static int RemoveSubmixEffect_ParamsSize;

	private static bool RemoveSubmixEffect_WorldContextObject_IsValid;

	private static FFieldAddress RemoveSubmixEffect_WorldContextObject_PropertyAddress;

	private static int RemoveSubmixEffect_WorldContextObject_Offset;

	private static bool RemoveSubmixEffect_SoundSubmix_IsValid;

	private static FFieldAddress RemoveSubmixEffect_SoundSubmix_PropertyAddress;

	private static int RemoveSubmixEffect_SoundSubmix_Offset;

	private static bool RemoveSubmixEffect_SubmixEffectPreset_IsValid;

	private static FFieldAddress RemoveSubmixEffect_SubmixEffectPreset_PropertyAddress;

	private static int RemoveSubmixEffect_SubmixEffectPreset_Offset;

	private static bool RemoveSourceEffectFromPresetChain_IsValid;

	private static IntPtr RemoveSourceEffectFromPresetChain_FunctionAddress;

	private static int RemoveSourceEffectFromPresetChain_ParamsSize;

	private static bool RemoveSourceEffectFromPresetChain_WorldContextObject_IsValid;

	private static FFieldAddress RemoveSourceEffectFromPresetChain_WorldContextObject_PropertyAddress;

	private static int RemoveSourceEffectFromPresetChain_WorldContextObject_Offset;

	private static bool RemoveSourceEffectFromPresetChain_PresetChain_IsValid;

	private static FFieldAddress RemoveSourceEffectFromPresetChain_PresetChain_PropertyAddress;

	private static int RemoveSourceEffectFromPresetChain_PresetChain_Offset;

	private static bool RemoveSourceEffectFromPresetChain_EntryIndex_IsValid;

	private static FFieldAddress RemoveSourceEffectFromPresetChain_EntryIndex_PropertyAddress;

	private static int RemoveSourceEffectFromPresetChain_EntryIndex_Offset;

	private static bool RemoveMasterSubmixEffect_IsValid;

	private static IntPtr RemoveMasterSubmixEffect_FunctionAddress;

	private static int RemoveMasterSubmixEffect_ParamsSize;

	private static bool RemoveMasterSubmixEffect_WorldContextObject_IsValid;

	private static FFieldAddress RemoveMasterSubmixEffect_WorldContextObject_PropertyAddress;

	private static int RemoveMasterSubmixEffect_WorldContextObject_Offset;

	private static bool RemoveMasterSubmixEffect_SubmixEffectPreset_IsValid;

	private static FFieldAddress RemoveMasterSubmixEffect_SubmixEffectPreset_PropertyAddress;

	private static int RemoveMasterSubmixEffect_SubmixEffectPreset_Offset;

	private static bool PrimeSoundForPlayback_IsValid;

	private static IntPtr PrimeSoundForPlayback_FunctionAddress;

	private static int PrimeSoundForPlayback_ParamsSize;

	private static bool PrimeSoundForPlayback_SoundWave_IsValid;

	private static FFieldAddress PrimeSoundForPlayback_SoundWave_PropertyAddress;

	private static int PrimeSoundForPlayback_SoundWave_Offset;

	private static bool PrimeSoundForPlayback_OnLoadCompletion_IsValid;

	private static FFieldAddress PrimeSoundForPlayback_OnLoadCompletion_PropertyAddress;

	private static int PrimeSoundForPlayback_OnLoadCompletion_Offset;

	private static bool PrimeSoundCueForPlayback_IsValid;

	private static IntPtr PrimeSoundCueForPlayback_FunctionAddress;

	private static int PrimeSoundCueForPlayback_ParamsSize;

	private static bool PrimeSoundCueForPlayback_SoundCue_IsValid;

	private static FFieldAddress PrimeSoundCueForPlayback_SoundCue_PropertyAddress;

	private static int PrimeSoundCueForPlayback_SoundCue_Offset;

	private static bool PauseRecordingOutput_IsValid;

	private static IntPtr PauseRecordingOutput_FunctionAddress;

	private static int PauseRecordingOutput_ParamsSize;

	private static bool PauseRecordingOutput_WorldContextObject_IsValid;

	private static FFieldAddress PauseRecordingOutput_WorldContextObject_PropertyAddress;

	private static int PauseRecordingOutput_WorldContextObject_Offset;

	private static bool PauseRecordingOutput_SubmixToPause_IsValid;

	private static FFieldAddress PauseRecordingOutput_SubmixToPause_PropertyAddress;

	private static int PauseRecordingOutput_SubmixToPause_Offset;

	private static bool MakePresetSpectralAnalysisBandSettings_IsValid;

	private static IntPtr MakePresetSpectralAnalysisBandSettings_FunctionAddress;

	private static int MakePresetSpectralAnalysisBandSettings_ParamsSize;

	private static bool MakePresetSpectralAnalysisBandSettings_InBandPresetType_IsValid;

	private static FFieldAddress MakePresetSpectralAnalysisBandSettings_InBandPresetType_PropertyAddress;

	private static int MakePresetSpectralAnalysisBandSettings_InBandPresetType_Offset;

	private static bool MakePresetSpectralAnalysisBandSettings_InNumBands_IsValid;

	private static FFieldAddress MakePresetSpectralAnalysisBandSettings_InNumBands_PropertyAddress;

	private static int MakePresetSpectralAnalysisBandSettings_InNumBands_Offset;

	private static bool MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid;

	private static FFieldAddress MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress;

	private static int MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_Offset;

	private static bool MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid;

	private static FFieldAddress MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress;

	private static int MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset;

	private static bool MakePresetSpectralAnalysisBandSettings_ReturnValue_IsValid;

	private static FFieldAddress MakePresetSpectralAnalysisBandSettings_ReturnValue_PropertyAddress;

	private static int MakePresetSpectralAnalysisBandSettings_ReturnValue_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_IsValid;

	private static IntPtr MakeMusicalSpectralAnalysisBandSettings_FunctionAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_ParamsSize;

	private static bool MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset;

	private static bool MakeMusicalSpectralAnalysisBandSettings_ReturnValue_IsValid;

	private static FFieldAddress MakeMusicalSpectralAnalysisBandSettings_ReturnValue_PropertyAddress;

	private static int MakeMusicalSpectralAnalysisBandSettings_ReturnValue_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_IsValid;

	private static IntPtr MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_ParamsSize;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset;

	private static bool MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_IsValid;

	private static FFieldAddress MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_PropertyAddress;

	private static int MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_Offset;

	private static bool IsAudioBusActive_IsValid;

	private static IntPtr IsAudioBusActive_FunctionAddress;

	private static int IsAudioBusActive_ParamsSize;

	private static bool IsAudioBusActive_WorldContextObject_IsValid;

	private static FFieldAddress IsAudioBusActive_WorldContextObject_PropertyAddress;

	private static int IsAudioBusActive_WorldContextObject_Offset;

	private static bool IsAudioBusActive_AudioBus_IsValid;

	private static FFieldAddress IsAudioBusActive_AudioBus_PropertyAddress;

	private static int IsAudioBusActive_AudioBus_Offset;

	private static bool IsAudioBusActive_ReturnValue_IsValid;

	private static FFieldAddress IsAudioBusActive_ReturnValue_PropertyAddress;

	private static int IsAudioBusActive_ReturnValue_Offset;

	private static bool GetPhaseForFrequencies_IsValid;

	private static IntPtr GetPhaseForFrequencies_FunctionAddress;

	private static int GetPhaseForFrequencies_ParamsSize;

	private static bool GetPhaseForFrequencies_WorldContextObject_IsValid;

	private static FFieldAddress GetPhaseForFrequencies_WorldContextObject_PropertyAddress;

	private static int GetPhaseForFrequencies_WorldContextObject_Offset;

	private static bool GetPhaseForFrequencies_Frequencies_IsValid;

	private static FFieldAddress GetPhaseForFrequencies_Frequencies_PropertyAddress;

	private static int GetPhaseForFrequencies_Frequencies_Offset;

	private static bool GetPhaseForFrequencies_Phases_IsValid;

	private static FFieldAddress GetPhaseForFrequencies_Phases_PropertyAddress;

	private static int GetPhaseForFrequencies_Phases_Offset;

	private static bool GetPhaseForFrequencies_SubmixToAnalyze_IsValid;

	private static FFieldAddress GetPhaseForFrequencies_SubmixToAnalyze_PropertyAddress;

	private static int GetPhaseForFrequencies_SubmixToAnalyze_Offset;

	private static bool GetNumberOfEntriesInSourceEffectChain_IsValid;

	private static IntPtr GetNumberOfEntriesInSourceEffectChain_FunctionAddress;

	private static int GetNumberOfEntriesInSourceEffectChain_ParamsSize;

	private static bool GetNumberOfEntriesInSourceEffectChain_WorldContextObject_IsValid;

	private static FFieldAddress GetNumberOfEntriesInSourceEffectChain_WorldContextObject_PropertyAddress;

	private static int GetNumberOfEntriesInSourceEffectChain_WorldContextObject_Offset;

	private static bool GetNumberOfEntriesInSourceEffectChain_PresetChain_IsValid;

	private static FFieldAddress GetNumberOfEntriesInSourceEffectChain_PresetChain_PropertyAddress;

	private static int GetNumberOfEntriesInSourceEffectChain_PresetChain_Offset;

	private static bool GetNumberOfEntriesInSourceEffectChain_ReturnValue_IsValid;

	private static FFieldAddress GetNumberOfEntriesInSourceEffectChain_ReturnValue_PropertyAddress;

	private static int GetNumberOfEntriesInSourceEffectChain_ReturnValue_Offset;

	private static bool GetMagnitudeForFrequencies_IsValid;

	private static IntPtr GetMagnitudeForFrequencies_FunctionAddress;

	private static int GetMagnitudeForFrequencies_ParamsSize;

	private static bool GetMagnitudeForFrequencies_WorldContextObject_IsValid;

	private static FFieldAddress GetMagnitudeForFrequencies_WorldContextObject_PropertyAddress;

	private static int GetMagnitudeForFrequencies_WorldContextObject_Offset;

	private static bool GetMagnitudeForFrequencies_Frequencies_IsValid;

	private static FFieldAddress GetMagnitudeForFrequencies_Frequencies_PropertyAddress;

	private static int GetMagnitudeForFrequencies_Frequencies_Offset;

	private static bool GetMagnitudeForFrequencies_Magnitudes_IsValid;

	private static FFieldAddress GetMagnitudeForFrequencies_Magnitudes_PropertyAddress;

	private static int GetMagnitudeForFrequencies_Magnitudes_Offset;

	private static bool GetMagnitudeForFrequencies_SubmixToAnalyze_IsValid;

	private static FFieldAddress GetMagnitudeForFrequencies_SubmixToAnalyze_PropertyAddress;

	private static int GetMagnitudeForFrequencies_SubmixToAnalyze_Offset;

	private static bool GetCurrentAudioOutputDeviceName_IsValid;

	private static IntPtr GetCurrentAudioOutputDeviceName_FunctionAddress;

	private static int GetCurrentAudioOutputDeviceName_ParamsSize;

	private static bool GetCurrentAudioOutputDeviceName_WorldContextObject_IsValid;

	private static FFieldAddress GetCurrentAudioOutputDeviceName_WorldContextObject_PropertyAddress;

	private static int GetCurrentAudioOutputDeviceName_WorldContextObject_Offset;

	private static bool GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_IsValid;

	private static FFieldAddress GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_PropertyAddress;

	private static int GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_Offset;

	private static bool GetAvailableAudioOutputDevices_IsValid;

	private static IntPtr GetAvailableAudioOutputDevices_FunctionAddress;

	private static int GetAvailableAudioOutputDevices_ParamsSize;

	private static bool GetAvailableAudioOutputDevices_WorldContextObject_IsValid;

	private static FFieldAddress GetAvailableAudioOutputDevices_WorldContextObject_PropertyAddress;

	private static int GetAvailableAudioOutputDevices_WorldContextObject_Offset;

	private static bool GetAvailableAudioOutputDevices_OnObtainDevicesEvent_IsValid;

	private static FFieldAddress GetAvailableAudioOutputDevices_OnObtainDevicesEvent_PropertyAddress;

	private static int GetAvailableAudioOutputDevices_OnObtainDevicesEvent_Offset;

	private static bool Conv_AudioOutputDeviceInfoToString_IsValid;

	private static IntPtr Conv_AudioOutputDeviceInfoToString_FunctionAddress;

	private static int Conv_AudioOutputDeviceInfoToString_ParamsSize;

	private static bool Conv_AudioOutputDeviceInfoToString_Info_IsValid;

	private static FFieldAddress Conv_AudioOutputDeviceInfoToString_Info_PropertyAddress;

	private static int Conv_AudioOutputDeviceInfoToString_Info_Offset;

	private static bool Conv_AudioOutputDeviceInfoToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_AudioOutputDeviceInfoToString_ReturnValue_PropertyAddress;

	private static int Conv_AudioOutputDeviceInfoToString_ReturnValue_Offset;

	private static bool ClearSubmixEffects_IsValid;

	private static IntPtr ClearSubmixEffects_FunctionAddress;

	private static int ClearSubmixEffects_ParamsSize;

	private static bool ClearSubmixEffects_WorldContextObject_IsValid;

	private static FFieldAddress ClearSubmixEffects_WorldContextObject_PropertyAddress;

	private static int ClearSubmixEffects_WorldContextObject_Offset;

	private static bool ClearSubmixEffects_SoundSubmix_IsValid;

	private static FFieldAddress ClearSubmixEffects_SoundSubmix_PropertyAddress;

	private static int ClearSubmixEffects_SoundSubmix_Offset;

	private static bool ClearSubmixEffectChainOverride_IsValid;

	private static IntPtr ClearSubmixEffectChainOverride_FunctionAddress;

	private static int ClearSubmixEffectChainOverride_ParamsSize;

	private static bool ClearSubmixEffectChainOverride_WorldContextObject_IsValid;

	private static FFieldAddress ClearSubmixEffectChainOverride_WorldContextObject_PropertyAddress;

	private static int ClearSubmixEffectChainOverride_WorldContextObject_Offset;

	private static bool ClearSubmixEffectChainOverride_SoundSubmix_IsValid;

	private static FFieldAddress ClearSubmixEffectChainOverride_SoundSubmix_PropertyAddress;

	private static int ClearSubmixEffectChainOverride_SoundSubmix_Offset;

	private static bool ClearSubmixEffectChainOverride_FadeTimeSec_IsValid;

	private static FFieldAddress ClearSubmixEffectChainOverride_FadeTimeSec_PropertyAddress;

	private static int ClearSubmixEffectChainOverride_FadeTimeSec_Offset;

	private static bool ClearMasterSubmixEffects_IsValid;

	private static IntPtr ClearMasterSubmixEffects_FunctionAddress;

	private static int ClearMasterSubmixEffects_ParamsSize;

	private static bool ClearMasterSubmixEffects_WorldContextObject_IsValid;

	private static FFieldAddress ClearMasterSubmixEffects_WorldContextObject_PropertyAddress;

	private static int ClearMasterSubmixEffects_WorldContextObject_Offset;

	private static bool AddSubmixEffect_IsValid;

	private static IntPtr AddSubmixEffect_FunctionAddress;

	private static int AddSubmixEffect_ParamsSize;

	private static bool AddSubmixEffect_WorldContextObject_IsValid;

	private static FFieldAddress AddSubmixEffect_WorldContextObject_PropertyAddress;

	private static int AddSubmixEffect_WorldContextObject_Offset;

	private static bool AddSubmixEffect_SoundSubmix_IsValid;

	private static FFieldAddress AddSubmixEffect_SoundSubmix_PropertyAddress;

	private static int AddSubmixEffect_SoundSubmix_Offset;

	private static bool AddSubmixEffect_SubmixEffectPreset_IsValid;

	private static FFieldAddress AddSubmixEffect_SubmixEffectPreset_PropertyAddress;

	private static int AddSubmixEffect_SubmixEffectPreset_Offset;

	private static bool AddSubmixEffect_ReturnValue_IsValid;

	private static FFieldAddress AddSubmixEffect_ReturnValue_PropertyAddress;

	private static int AddSubmixEffect_ReturnValue_Offset;

	private static bool AddSourceEffectToPresetChain_IsValid;

	private static IntPtr AddSourceEffectToPresetChain_FunctionAddress;

	private static int AddSourceEffectToPresetChain_ParamsSize;

	private static bool AddSourceEffectToPresetChain_WorldContextObject_IsValid;

	private static FFieldAddress AddSourceEffectToPresetChain_WorldContextObject_PropertyAddress;

	private static int AddSourceEffectToPresetChain_WorldContextObject_Offset;

	private static bool AddSourceEffectToPresetChain_PresetChain_IsValid;

	private static FFieldAddress AddSourceEffectToPresetChain_PresetChain_PropertyAddress;

	private static int AddSourceEffectToPresetChain_PresetChain_Offset;

	private static bool AddSourceEffectToPresetChain_Entry_IsValid;

	private static FFieldAddress AddSourceEffectToPresetChain_Entry_PropertyAddress;

	private static int AddSourceEffectToPresetChain_Entry_Offset;

	private static bool AddMasterSubmixEffect_IsValid;

	private static IntPtr AddMasterSubmixEffect_FunctionAddress;

	private static int AddMasterSubmixEffect_ParamsSize;

	private static bool AddMasterSubmixEffect_WorldContextObject_IsValid;

	private static FFieldAddress AddMasterSubmixEffect_WorldContextObject_PropertyAddress;

	private static int AddMasterSubmixEffect_WorldContextObject_Offset;

	private static bool AddMasterSubmixEffect_SubmixEffectPreset_IsValid;

	private static FFieldAddress AddMasterSubmixEffect_SubmixEffectPreset_PropertyAddress;

	private static int AddMasterSubmixEffect_SubmixEffectPreset_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:TrimAudioCache")]
	public unsafe static float TrimAudioCache(float InMegabytesToFree)
	{
		if (!TrimAudioCache_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:TrimAudioCache");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TrimAudioCache_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TrimAudioCache_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TrimAudioCache_InMegabytesToFree_Offset), 0, TrimAudioCache_InMegabytesToFree_PropertyAddress.Address, InMegabytesToFree);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TrimAudioCache_FunctionAddress, intPtr, TrimAudioCache_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, TrimAudioCache_ReturnValue_Offset), 0, TrimAudioCache_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:SwapAudioOutputDevice")]
	public unsafe static void SwapAudioOutputDevice(UObject WorldContextObject, string NewDeviceId, FOnCompletedDeviceSwap OnCompletedDeviceSwap)
	{
		if (!SwapAudioOutputDevice_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:SwapAudioOutputDevice");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwapAudioOutputDevice_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwapAudioOutputDevice_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SwapAudioOutputDevice_WorldContextObject_Offset), 0, SwapAudioOutputDevice_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SwapAudioOutputDevice_NewDeviceId_Offset), 0, SwapAudioOutputDevice_NewDeviceId_PropertyAddress.Address, NewDeviceId);
		FDelegateMarshaler<FOnCompletedDeviceSwap>.ToNative(IntPtr.Add(intPtr, SwapAudioOutputDevice_OnCompletedDeviceSwap_Offset), 0, SwapAudioOutputDevice_OnCompletedDeviceSwap_PropertyAddress.Address, OnCompletedDeviceSwap);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SwapAudioOutputDevice_FunctionAddress, intPtr, SwapAudioOutputDevice_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SwapAudioOutputDevice_NewDeviceId_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopRecordingOutput")]
	public unsafe static USoundWave StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, USoundSubmix SubmixToRecord, USoundWave ExistingSoundWaveToOverwrite)
	{
		if (!StopRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopRecordingOutput");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopRecordingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopRecordingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_WorldContextObject_Offset), 0, StopRecordingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EAudioRecordingExportType>.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_ExportType_Offset), 0, StopRecordingOutput_ExportType_PropertyAddress.Address, ExportType);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_Name_Offset), 0, StopRecordingOutput_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_Path_Offset), 0, StopRecordingOutput_Path_PropertyAddress.Address, Path);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_SubmixToRecord_Offset), 0, StopRecordingOutput_SubmixToRecord_PropertyAddress.Address, SubmixToRecord);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset), 0, StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress.Address, ExistingSoundWaveToOverwrite);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopRecordingOutput_FunctionAddress, intPtr, StopRecordingOutput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StopRecordingOutput_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StopRecordingOutput_Path_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(intPtr, StopRecordingOutput_ReturnValue_Offset), 0, StopRecordingOutput_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAudioBus")]
	public unsafe static void StopAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
	{
		if (!StopAudioBus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAudioBus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAudioBus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAudioBus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopAudioBus_WorldContextObject_Offset), 0, StopAudioBus_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, StopAudioBus_AudioBus_Offset), 0, StopAudioBus_AudioBus_PropertyAddress.Address, AudioBus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopAudioBus_FunctionAddress, intPtr, StopAudioBus_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAnalyzingOutput")]
	public unsafe static void StopAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToStopAnalyzing)
	{
		if (!StopAnalyzingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAnalyzingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnalyzingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnalyzingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopAnalyzingOutput_WorldContextObject_Offset), 0, StopAnalyzingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, StopAnalyzingOutput_SubmixToStopAnalyzing_Offset), 0, StopAnalyzingOutput_SubmixToStopAnalyzing_PropertyAddress.Address, SubmixToStopAnalyzing);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StopAnalyzingOutput_FunctionAddress, intPtr, StopAnalyzingOutput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartRecordingOutput")]
	public unsafe static void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration, USoundSubmix SubmixToRecord)
	{
		if (!StartRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartRecordingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartRecordingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartRecordingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartRecordingOutput_WorldContextObject_Offset), 0, StartRecordingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartRecordingOutput_ExpectedDuration_Offset), 0, StartRecordingOutput_ExpectedDuration_PropertyAddress.Address, ExpectedDuration);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, StartRecordingOutput_SubmixToRecord_Offset), 0, StartRecordingOutput_SubmixToRecord_PropertyAddress.Address, SubmixToRecord);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartRecordingOutput_FunctionAddress, intPtr, StartRecordingOutput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAudioBus")]
	public unsafe static void StartAudioBus(UObject WorldContextObject, UAudioBus AudioBus)
	{
		if (!StartAudioBus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAudioBus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAudioBus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAudioBus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartAudioBus_WorldContextObject_Offset), 0, StartAudioBus_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, StartAudioBus_AudioBus_Offset), 0, StartAudioBus_AudioBus_PropertyAddress.Address, AudioBus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartAudioBus_FunctionAddress, intPtr, StartAudioBus_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAnalyzingOutput")]
	public unsafe static void StartAnalyzingOutput(UObject WorldContextObject, USoundSubmix SubmixToAnalyze, EFFTSize FFTSize, EFFTPeakInterpolationMethod InterpolationMethod, EFFTWindowType WindowType, float HopSize, EAudioSpectrumType SpectrumType)
	{
		if (!StartAnalyzingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAnalyzingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAnalyzingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAnalyzingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_WorldContextObject_Offset), 0, StartAnalyzingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_SubmixToAnalyze_Offset), 0, StartAnalyzingOutput_SubmixToAnalyze_PropertyAddress.Address, SubmixToAnalyze);
		EnumMarshaler<EFFTSize>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_FFTSize_Offset), 0, StartAnalyzingOutput_FFTSize_PropertyAddress.Address, FFTSize);
		EnumMarshaler<EFFTPeakInterpolationMethod>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_InterpolationMethod_Offset), 0, StartAnalyzingOutput_InterpolationMethod_PropertyAddress.Address, InterpolationMethod);
		EnumMarshaler<EFFTWindowType>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_WindowType_Offset), 0, StartAnalyzingOutput_WindowType_PropertyAddress.Address, WindowType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_HopSize_Offset), 0, StartAnalyzingOutput_HopSize_PropertyAddress.Address, HopSize);
		EnumMarshaler<EAudioSpectrumType>.ToNative(IntPtr.Add(intPtr, StartAnalyzingOutput_SpectrumType_Offset), 0, StartAnalyzingOutput_SpectrumType_PropertyAddress.Address, SpectrumType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartAnalyzingOutput_FunctionAddress, intPtr, StartAnalyzingOutput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetSubmixEffectChainOverride")]
	public unsafe static void SetSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, List<USoundEffectSubmixPreset> SubmixEffectPresetChain, float FadeTimeSec)
	{
		if (!SetSubmixEffectChainOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetSubmixEffectChainOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixEffectChainOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixEffectChainOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSubmixEffectChainOverride_WorldContextObject_Offset), 0, SetSubmixEffectChainOverride_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, SetSubmixEffectChainOverride_SoundSubmix_Offset), 0, SetSubmixEffectChainOverride_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		new TArrayCopyMarshaler<USoundEffectSubmixPreset>(1, SetSubmixEffectChainOverride_SubmixEffectPresetChain_PropertyAddress, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.FromNative, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSubmixEffectChainOverride_SubmixEffectPresetChain_Offset), SubmixEffectPresetChain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSubmixEffectChainOverride_FadeTimeSec_Offset), 0, SetSubmixEffectChainOverride_FadeTimeSec_PropertyAddress.Address, FadeTimeSec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSubmixEffectChainOverride_FunctionAddress, intPtr, SetSubmixEffectChainOverride_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSubmixEffectChainOverride_SubmixEffectPresetChain_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetBypassSourceEffectChainEntry")]
	public unsafe static void SetBypassSourceEffectChainEntry(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex, bool bBypassed)
	{
		if (!SetBypassSourceEffectChainEntry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetBypassSourceEffectChainEntry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBypassSourceEffectChainEntry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBypassSourceEffectChainEntry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetBypassSourceEffectChainEntry_WorldContextObject_Offset), 0, SetBypassSourceEffectChainEntry_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(intPtr, SetBypassSourceEffectChainEntry_PresetChain_Offset), 0, SetBypassSourceEffectChainEntry_PresetChain_PropertyAddress.Address, PresetChain);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetBypassSourceEffectChainEntry_EntryIndex_Offset), 0, SetBypassSourceEffectChainEntry_EntryIndex_PropertyAddress.Address, EntryIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBypassSourceEffectChainEntry_bBypassed_Offset), 0, SetBypassSourceEffectChainEntry_bBypassed_PropertyAddress.Address, bBypassed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBypassSourceEffectChainEntry_FunctionAddress, intPtr, SetBypassSourceEffectChainEntry_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:ResumeRecordingOutput")]
	public unsafe static void ResumeRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause)
	{
		if (!ResumeRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:ResumeRecordingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResumeRecordingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResumeRecordingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ResumeRecordingOutput_WorldContextObject_Offset), 0, ResumeRecordingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, ResumeRecordingOutput_SubmixToPause_Offset), 0, ResumeRecordingOutput_SubmixToPause_PropertyAddress.Address, SubmixToPause);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResumeRecordingOutput_FunctionAddress, intPtr, ResumeRecordingOutput_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:ReplaceSubmixEffect")]
	public unsafe static void ReplaceSubmixEffect(UObject WorldContextObject, USoundSubmix InSoundSubmix, int SubmixChainIndex, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		if (!ReplaceSubmixEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:ReplaceSubmixEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceSubmixEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceSubmixEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReplaceSubmixEffect_WorldContextObject_Offset), 0, ReplaceSubmixEffect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, ReplaceSubmixEffect_InSoundSubmix_Offset), 0, ReplaceSubmixEffect_InSoundSubmix_PropertyAddress.Address, InSoundSubmix);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReplaceSubmixEffect_SubmixChainIndex_Offset), 0, ReplaceSubmixEffect_SubmixChainIndex_PropertyAddress.Address, SubmixChainIndex);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(intPtr, ReplaceSubmixEffect_SubmixEffectPreset_Offset), 0, ReplaceSubmixEffect_SubmixEffectPreset_PropertyAddress.Address, SubmixEffectPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceSubmixEffect_FunctionAddress, intPtr, ReplaceSubmixEffect_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffectAtIndex")]
	public unsafe static void RemoveSubmixEffectAtIndex(UObject WorldContextObject, USoundSubmix SoundSubmix, int SubmixChainIndex)
	{
		if (!RemoveSubmixEffectAtIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffectAtIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSubmixEffectAtIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSubmixEffectAtIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffectAtIndex_WorldContextObject_Offset), 0, RemoveSubmixEffectAtIndex_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffectAtIndex_SoundSubmix_Offset), 0, RemoveSubmixEffectAtIndex_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffectAtIndex_SubmixChainIndex_Offset), 0, RemoveSubmixEffectAtIndex_SubmixChainIndex_PropertyAddress.Address, SubmixChainIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSubmixEffectAtIndex_FunctionAddress, intPtr, RemoveSubmixEffectAtIndex_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffect")]
	public unsafe static void RemoveSubmixEffect(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		if (!RemoveSubmixEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSubmixEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSubmixEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffect_WorldContextObject_Offset), 0, RemoveSubmixEffect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffect_SoundSubmix_Offset), 0, RemoveSubmixEffect_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(intPtr, RemoveSubmixEffect_SubmixEffectPreset_Offset), 0, RemoveSubmixEffect_SubmixEffectPreset_PropertyAddress.Address, SubmixEffectPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSubmixEffect_FunctionAddress, intPtr, RemoveSubmixEffect_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSourceEffectFromPresetChain")]
	public unsafe static void RemoveSourceEffectFromPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, int EntryIndex)
	{
		if (!RemoveSourceEffectFromPresetChain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSourceEffectFromPresetChain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSourceEffectFromPresetChain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSourceEffectFromPresetChain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveSourceEffectFromPresetChain_WorldContextObject_Offset), 0, RemoveSourceEffectFromPresetChain_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(intPtr, RemoveSourceEffectFromPresetChain_PresetChain_Offset), 0, RemoveSourceEffectFromPresetChain_PresetChain_PropertyAddress.Address, PresetChain);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RemoveSourceEffectFromPresetChain_EntryIndex_Offset), 0, RemoveSourceEffectFromPresetChain_EntryIndex_PropertyAddress.Address, EntryIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSourceEffectFromPresetChain_FunctionAddress, intPtr, RemoveSourceEffectFromPresetChain_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveMasterSubmixEffect")]
	public unsafe static void RemoveMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		if (!RemoveMasterSubmixEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveMasterSubmixEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMasterSubmixEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMasterSubmixEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveMasterSubmixEffect_WorldContextObject_Offset), 0, RemoveMasterSubmixEffect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(intPtr, RemoveMasterSubmixEffect_SubmixEffectPreset_Offset), 0, RemoveMasterSubmixEffect_SubmixEffectPreset_PropertyAddress.Address, SubmixEffectPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveMasterSubmixEffect_FunctionAddress, intPtr, RemoveMasterSubmixEffect_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundForPlayback")]
	public unsafe static void PrimeSoundForPlayback(USoundWave SoundWave, FOnSoundLoadComplete OnLoadCompletion)
	{
		if (!PrimeSoundForPlayback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundForPlayback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrimeSoundForPlayback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrimeSoundForPlayback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, PrimeSoundForPlayback_SoundWave_Offset), 0, PrimeSoundForPlayback_SoundWave_PropertyAddress.Address, SoundWave);
		FDelegateMarshaler<FOnSoundLoadComplete>.ToNative(IntPtr.Add(intPtr, PrimeSoundForPlayback_OnLoadCompletion_Offset), 0, PrimeSoundForPlayback_OnLoadCompletion_PropertyAddress.Address, OnLoadCompletion);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrimeSoundForPlayback_FunctionAddress, intPtr, PrimeSoundForPlayback_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundCueForPlayback")]
	public unsafe static void PrimeSoundCueForPlayback(USoundCue SoundCue)
	{
		if (!PrimeSoundCueForPlayback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundCueForPlayback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrimeSoundCueForPlayback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrimeSoundCueForPlayback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundCue>.ToNative(IntPtr.Add(intPtr, PrimeSoundCueForPlayback_SoundCue_Offset), 0, PrimeSoundCueForPlayback_SoundCue_PropertyAddress.Address, SoundCue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrimeSoundCueForPlayback_FunctionAddress, intPtr, PrimeSoundCueForPlayback_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:PauseRecordingOutput")]
	public unsafe static void PauseRecordingOutput(UObject WorldContextObject, USoundSubmix SubmixToPause)
	{
		if (!PauseRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:PauseRecordingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PauseRecordingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PauseRecordingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PauseRecordingOutput_WorldContextObject_Offset), 0, PauseRecordingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, PauseRecordingOutput_SubmixToPause_Offset), 0, PauseRecordingOutput_SubmixToPause_PropertyAddress.Address, SubmixToPause);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PauseRecordingOutput_FunctionAddress, intPtr, PauseRecordingOutput_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakePresetSpectralAnalysisBandSettings")]
	public unsafe static List<FSoundSubmixSpectralAnalysisBandSettings> MakePresetSpectralAnalysisBandSettings(EAudioSpectrumBandPresetType InBandPresetType, int InNumBands = 10, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
	{
		if (!MakePresetSpectralAnalysisBandSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakePresetSpectralAnalysisBandSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakePresetSpectralAnalysisBandSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakePresetSpectralAnalysisBandSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EAudioSpectrumBandPresetType>.ToNative(IntPtr.Add(intPtr, MakePresetSpectralAnalysisBandSettings_InBandPresetType_Offset), 0, MakePresetSpectralAnalysisBandSettings_InBandPresetType_PropertyAddress.Address, InBandPresetType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakePresetSpectralAnalysisBandSettings_InNumBands_Offset), 0, MakePresetSpectralAnalysisBandSettings_InNumBands_PropertyAddress.Address, InNumBands);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_Offset), 0, MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset), 0, MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, intPtr, MakePresetSpectralAnalysisBandSettings_ParamsSize);
		List<FSoundSubmixSpectralAnalysisBandSettings> result = new TArrayCopyMarshaler<FSoundSubmixSpectralAnalysisBandSettings>(1, MakePresetSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.FromNative, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.ToNative).FromNative(IntPtr.Add(intPtr, MakePresetSpectralAnalysisBandSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(MakePresetSpectralAnalysisBandSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeMusicalSpectralAnalysisBandSettings")]
	public unsafe static List<FSoundSubmixSpectralAnalysisBandSettings> MakeMusicalSpectralAnalysisBandSettings(int InNumSemitones = 60, EMusicalNoteName InStartingMusicalNote = EMusicalNoteName.C, int InStartingOctave = 2, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
	{
		if (!MakeMusicalSpectralAnalysisBandSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeMusicalSpectralAnalysisBandSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeMusicalSpectralAnalysisBandSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeMusicalSpectralAnalysisBandSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_Offset), 0, MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_PropertyAddress.Address, InNumSemitones);
		EnumMarshaler<EMusicalNoteName>.ToNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_Offset), 0, MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_PropertyAddress.Address, InStartingMusicalNote);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_Offset), 0, MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_PropertyAddress.Address, InStartingOctave);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_Offset), 0, MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset), 0, MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, intPtr, MakeMusicalSpectralAnalysisBandSettings_ParamsSize);
		List<FSoundSubmixSpectralAnalysisBandSettings> result = new TArrayCopyMarshaler<FSoundSubmixSpectralAnalysisBandSettings>(1, MakeMusicalSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.FromNative, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.ToNative).FromNative(IntPtr.Add(intPtr, MakeMusicalSpectralAnalysisBandSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(MakeMusicalSpectralAnalysisBandSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeFullSpectrumSpectralAnalysisBandSettings")]
	public unsafe static List<FSoundSubmixSpectralAnalysisBandSettings> MakeFullSpectrumSpectralAnalysisBandSettings(int InNumBands = 30, float InMinimumFrequency = 40f, float InMaximumFrequency = 16000f, int InAttackTimeMsec = 10, int InReleaseTimeMsec = 10)
	{
		if (!MakeFullSpectrumSpectralAnalysisBandSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeFullSpectrumSpectralAnalysisBandSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeFullSpectrumSpectralAnalysisBandSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeFullSpectrumSpectralAnalysisBandSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_Offset), 0, MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_PropertyAddress.Address, InNumBands);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_Offset), 0, MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_PropertyAddress.Address, InMinimumFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_Offset), 0, MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_PropertyAddress.Address, InMaximumFrequency);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_Offset), 0, MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset), 0, MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_ParamsSize);
		List<FSoundSubmixSpectralAnalysisBandSettings> result = new TArrayCopyMarshaler<FSoundSubmixSpectralAnalysisBandSettings>(1, MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.FromNative, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.ToNative).FromNative(IntPtr.Add(intPtr, MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:IsAudioBusActive")]
	public unsafe static bool IsAudioBusActive(UObject WorldContextObject, UAudioBus AudioBus)
	{
		if (!IsAudioBusActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:IsAudioBusActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAudioBusActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAudioBusActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsAudioBusActive_WorldContextObject_Offset), 0, IsAudioBusActive_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, IsAudioBusActive_AudioBus_Offset), 0, IsAudioBusActive_AudioBus_PropertyAddress.Address, AudioBus);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAudioBusActive_FunctionAddress, intPtr, IsAudioBusActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAudioBusActive_ReturnValue_Offset), 0, IsAudioBusActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetPhaseForFrequencies")]
	public unsafe static void GetPhaseForFrequencies(UObject WorldContextObject, List<float> Frequencies, out List<float> Phases, USoundSubmix SubmixToAnalyze)
	{
		if (!GetPhaseForFrequencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetPhaseForFrequencies");
			Phases = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhaseForFrequencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhaseForFrequencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPhaseForFrequencies_WorldContextObject_Offset), 0, GetPhaseForFrequencies_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<float>(1, GetPhaseForFrequencies_Frequencies_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, GetPhaseForFrequencies_Frequencies_Offset), Frequencies);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, GetPhaseForFrequencies_SubmixToAnalyze_Offset), 0, GetPhaseForFrequencies_SubmixToAnalyze_PropertyAddress.Address, SubmixToAnalyze);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPhaseForFrequencies_FunctionAddress, intPtr, GetPhaseForFrequencies_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPhaseForFrequencies_Frequencies_PropertyAddress.Address, intPtr);
		Phases = new TArrayCopyMarshaler<float>(1, GetPhaseForFrequencies_Phases_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPhaseForFrequencies_Phases_Offset));
		NativeReflection.DestroyValue_InContainer(GetPhaseForFrequencies_Phases_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetNumberOfEntriesInSourceEffectChain")]
	public unsafe static int GetNumberOfEntriesInSourceEffectChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain)
	{
		if (!GetNumberOfEntriesInSourceEffectChain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetNumberOfEntriesInSourceEffectChain");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumberOfEntriesInSourceEffectChain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumberOfEntriesInSourceEffectChain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetNumberOfEntriesInSourceEffectChain_WorldContextObject_Offset), 0, GetNumberOfEntriesInSourceEffectChain_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(intPtr, GetNumberOfEntriesInSourceEffectChain_PresetChain_Offset), 0, GetNumberOfEntriesInSourceEffectChain_PresetChain_PropertyAddress.Address, PresetChain);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumberOfEntriesInSourceEffectChain_FunctionAddress, intPtr, GetNumberOfEntriesInSourceEffectChain_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumberOfEntriesInSourceEffectChain_ReturnValue_Offset), 0, GetNumberOfEntriesInSourceEffectChain_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetMagnitudeForFrequencies")]
	public unsafe static void GetMagnitudeForFrequencies(UObject WorldContextObject, List<float> Frequencies, out List<float> Magnitudes, USoundSubmix SubmixToAnalyze)
	{
		if (!GetMagnitudeForFrequencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetMagnitudeForFrequencies");
			Magnitudes = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMagnitudeForFrequencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMagnitudeForFrequencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMagnitudeForFrequencies_WorldContextObject_Offset), 0, GetMagnitudeForFrequencies_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<float>(1, GetMagnitudeForFrequencies_Frequencies_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, GetMagnitudeForFrequencies_Frequencies_Offset), Frequencies);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, GetMagnitudeForFrequencies_SubmixToAnalyze_Offset), 0, GetMagnitudeForFrequencies_SubmixToAnalyze_PropertyAddress.Address, SubmixToAnalyze);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMagnitudeForFrequencies_FunctionAddress, intPtr, GetMagnitudeForFrequencies_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMagnitudeForFrequencies_Frequencies_PropertyAddress.Address, intPtr);
		Magnitudes = new TArrayCopyMarshaler<float>(1, GetMagnitudeForFrequencies_Magnitudes_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetMagnitudeForFrequencies_Magnitudes_Offset));
		NativeReflection.DestroyValue_InContainer(GetMagnitudeForFrequencies_Magnitudes_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetCurrentAudioOutputDeviceName")]
	public unsafe static void GetCurrentAudioOutputDeviceName(UObject WorldContextObject, FOnMainAudioOutputDeviceObtained OnObtainCurrentDeviceEvent)
	{
		if (!GetCurrentAudioOutputDeviceName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetCurrentAudioOutputDeviceName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAudioOutputDeviceName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAudioOutputDeviceName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetCurrentAudioOutputDeviceName_WorldContextObject_Offset), 0, GetCurrentAudioOutputDeviceName_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnMainAudioOutputDeviceObtained>.ToNative(IntPtr.Add(intPtr, GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_Offset), 0, GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_PropertyAddress.Address, OnObtainCurrentDeviceEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentAudioOutputDeviceName_FunctionAddress, intPtr, GetCurrentAudioOutputDeviceName_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetAvailableAudioOutputDevices")]
	public unsafe static void GetAvailableAudioOutputDevices(UObject WorldContextObject, FOnAudioOutputDevicesObtained OnObtainDevicesEvent)
	{
		if (!GetAvailableAudioOutputDevices_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetAvailableAudioOutputDevices");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableAudioOutputDevices_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableAudioOutputDevices_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAvailableAudioOutputDevices_WorldContextObject_Offset), 0, GetAvailableAudioOutputDevices_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnAudioOutputDevicesObtained>.ToNative(IntPtr.Add(intPtr, GetAvailableAudioOutputDevices_OnObtainDevicesEvent_Offset), 0, GetAvailableAudioOutputDevices_OnObtainDevicesEvent_PropertyAddress.Address, OnObtainDevicesEvent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableAudioOutputDevices_FunctionAddress, intPtr, GetAvailableAudioOutputDevices_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:Conv_AudioOutputDeviceInfoToString")]
	public unsafe static string Conv_AudioOutputDeviceInfoToString(FAudioOutputDeviceInfo Info)
	{
		if (!Conv_AudioOutputDeviceInfoToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:Conv_AudioOutputDeviceInfoToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_AudioOutputDeviceInfoToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_AudioOutputDeviceInfoToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_AudioOutputDeviceInfoToString_Info_PropertyAddress.Address, intPtr);
		FAudioOutputDeviceInfo.ToNative(IntPtr.Add(intPtr, Conv_AudioOutputDeviceInfoToString_Info_Offset), 0, Conv_AudioOutputDeviceInfoToString_Info_PropertyAddress.Address, Info);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_AudioOutputDeviceInfoToString_FunctionAddress, intPtr, Conv_AudioOutputDeviceInfoToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_AudioOutputDeviceInfoToString_Info_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_AudioOutputDeviceInfoToString_ReturnValue_Offset), 0, Conv_AudioOutputDeviceInfoToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_AudioOutputDeviceInfoToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffects")]
	public unsafe static void ClearSubmixEffects(UObject WorldContextObject, USoundSubmix SoundSubmix)
	{
		if (!ClearSubmixEffects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSubmixEffects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSubmixEffects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ClearSubmixEffects_WorldContextObject_Offset), 0, ClearSubmixEffects_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, ClearSubmixEffects_SoundSubmix_Offset), 0, ClearSubmixEffects_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearSubmixEffects_FunctionAddress, intPtr, ClearSubmixEffects_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffectChainOverride")]
	public unsafe static void ClearSubmixEffectChainOverride(UObject WorldContextObject, USoundSubmix SoundSubmix, float FadeTimeSec)
	{
		if (!ClearSubmixEffectChainOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffectChainOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSubmixEffectChainOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSubmixEffectChainOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ClearSubmixEffectChainOverride_WorldContextObject_Offset), 0, ClearSubmixEffectChainOverride_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, ClearSubmixEffectChainOverride_SoundSubmix_Offset), 0, ClearSubmixEffectChainOverride_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ClearSubmixEffectChainOverride_FadeTimeSec_Offset), 0, ClearSubmixEffectChainOverride_FadeTimeSec_PropertyAddress.Address, FadeTimeSec);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearSubmixEffectChainOverride_FunctionAddress, intPtr, ClearSubmixEffectChainOverride_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearMasterSubmixEffects")]
	public unsafe static void ClearMasterSubmixEffects(UObject WorldContextObject)
	{
		if (!ClearMasterSubmixEffects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearMasterSubmixEffects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMasterSubmixEffects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMasterSubmixEffects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ClearMasterSubmixEffects_WorldContextObject_Offset), 0, ClearMasterSubmixEffects_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearMasterSubmixEffects_FunctionAddress, intPtr, ClearMasterSubmixEffects_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSubmixEffect")]
	public unsafe static int AddSubmixEffect(UObject WorldContextObject, USoundSubmix SoundSubmix, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		if (!AddSubmixEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSubmixEffect");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSubmixEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSubmixEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddSubmixEffect_WorldContextObject_Offset), 0, AddSubmixEffect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(intPtr, AddSubmixEffect_SoundSubmix_Offset), 0, AddSubmixEffect_SoundSubmix_PropertyAddress.Address, SoundSubmix);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(intPtr, AddSubmixEffect_SubmixEffectPreset_Offset), 0, AddSubmixEffect_SubmixEffectPreset_PropertyAddress.Address, SubmixEffectPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSubmixEffect_FunctionAddress, intPtr, AddSubmixEffect_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, AddSubmixEffect_ReturnValue_Offset), 0, AddSubmixEffect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSourceEffectToPresetChain")]
	public unsafe static void AddSourceEffectToPresetChain(UObject WorldContextObject, USoundEffectSourcePresetChain PresetChain, FSourceEffectChainEntry Entry)
	{
		if (!AddSourceEffectToPresetChain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSourceEffectToPresetChain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSourceEffectToPresetChain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSourceEffectToPresetChain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddSourceEffectToPresetChain_WorldContextObject_Offset), 0, AddSourceEffectToPresetChain_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(intPtr, AddSourceEffectToPresetChain_PresetChain_Offset), 0, AddSourceEffectToPresetChain_PresetChain_PropertyAddress.Address, PresetChain);
		NativeReflection.InitializeValue_InContainer(AddSourceEffectToPresetChain_Entry_PropertyAddress.Address, intPtr);
		FSourceEffectChainEntry.ToNative(IntPtr.Add(intPtr, AddSourceEffectToPresetChain_Entry_Offset), 0, AddSourceEffectToPresetChain_Entry_PropertyAddress.Address, Entry);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSourceEffectToPresetChain_FunctionAddress, intPtr, AddSourceEffectToPresetChain_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddMasterSubmixEffect")]
	public unsafe static void AddMasterSubmixEffect(UObject WorldContextObject, USoundEffectSubmixPreset SubmixEffectPreset)
	{
		if (!AddMasterSubmixEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddMasterSubmixEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMasterSubmixEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMasterSubmixEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddMasterSubmixEffect_WorldContextObject_Offset), 0, AddMasterSubmixEffect_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<USoundEffectSubmixPreset>.ToNative(IntPtr.Add(intPtr, AddMasterSubmixEffect_SubmixEffectPreset_Offset), 0, AddMasterSubmixEffect_SubmixEffectPreset_PropertyAddress.Address, SubmixEffectPreset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMasterSubmixEffect_FunctionAddress, intPtr, AddMasterSubmixEffect_ParamsSize);
	}

	static UAudioMixerLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioMixerLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioMixerLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AudioMixer.AudioMixerBlueprintLibrary");
		TrimAudioCache_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TrimAudioCache");
		TrimAudioCache_ParamsSize = NativeReflection.GetFunctionParamsSize(TrimAudioCache_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TrimAudioCache_InMegabytesToFree_PropertyAddress, TrimAudioCache_FunctionAddress, "InMegabytesToFree");
		TrimAudioCache_InMegabytesToFree_Offset = NativeReflectionCached.GetPropertyOffset(TrimAudioCache_FunctionAddress, "InMegabytesToFree");
		TrimAudioCache_InMegabytesToFree_IsValid = NativeReflectionCached.ValidatePropertyClass(TrimAudioCache_FunctionAddress, "InMegabytesToFree", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TrimAudioCache_ReturnValue_PropertyAddress, TrimAudioCache_FunctionAddress, "ReturnValue");
		TrimAudioCache_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TrimAudioCache_FunctionAddress, "ReturnValue");
		TrimAudioCache_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TrimAudioCache_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		TrimAudioCache_IsValid = TrimAudioCache_FunctionAddress != IntPtr.Zero && TrimAudioCache_InMegabytesToFree_IsValid && TrimAudioCache_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:TrimAudioCache", TrimAudioCache_IsValid);
		SwapAudioOutputDevice_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SwapAudioOutputDevice");
		SwapAudioOutputDevice_ParamsSize = NativeReflection.GetFunctionParamsSize(SwapAudioOutputDevice_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwapAudioOutputDevice_WorldContextObject_PropertyAddress, SwapAudioOutputDevice_FunctionAddress, "WorldContextObject");
		SwapAudioOutputDevice_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SwapAudioOutputDevice_FunctionAddress, "WorldContextObject");
		SwapAudioOutputDevice_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapAudioOutputDevice_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapAudioOutputDevice_NewDeviceId_PropertyAddress, SwapAudioOutputDevice_FunctionAddress, "NewDeviceId");
		SwapAudioOutputDevice_NewDeviceId_Offset = NativeReflectionCached.GetPropertyOffset(SwapAudioOutputDevice_FunctionAddress, "NewDeviceId");
		SwapAudioOutputDevice_NewDeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapAudioOutputDevice_FunctionAddress, "NewDeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SwapAudioOutputDevice_OnCompletedDeviceSwap_PropertyAddress, SwapAudioOutputDevice_FunctionAddress, "OnCompletedDeviceSwap");
		SwapAudioOutputDevice_OnCompletedDeviceSwap_Offset = NativeReflectionCached.GetPropertyOffset(SwapAudioOutputDevice_FunctionAddress, "OnCompletedDeviceSwap");
		SwapAudioOutputDevice_OnCompletedDeviceSwap_IsValid = NativeReflectionCached.ValidatePropertyClass(SwapAudioOutputDevice_FunctionAddress, "OnCompletedDeviceSwap", Classes.FDelegateProperty);
		SwapAudioOutputDevice_IsValid = SwapAudioOutputDevice_FunctionAddress != IntPtr.Zero && SwapAudioOutputDevice_WorldContextObject_IsValid && SwapAudioOutputDevice_NewDeviceId_IsValid && SwapAudioOutputDevice_OnCompletedDeviceSwap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:SwapAudioOutputDevice", SwapAudioOutputDevice_IsValid);
		StopRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopRecordingOutput");
		StopRecordingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(StopRecordingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_WorldContextObject_PropertyAddress, StopRecordingOutput_FunctionAddress, "WorldContextObject");
		StopRecordingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "WorldContextObject");
		StopRecordingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_ExportType_PropertyAddress, StopRecordingOutput_FunctionAddress, "ExportType");
		StopRecordingOutput_ExportType_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "ExportType");
		StopRecordingOutput_ExportType_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "ExportType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_Name_PropertyAddress, StopRecordingOutput_FunctionAddress, "Name");
		StopRecordingOutput_Name_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "Name");
		StopRecordingOutput_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_Path_PropertyAddress, StopRecordingOutput_FunctionAddress, "Path");
		StopRecordingOutput_Path_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "Path");
		StopRecordingOutput_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_SubmixToRecord_PropertyAddress, StopRecordingOutput_FunctionAddress, "SubmixToRecord");
		StopRecordingOutput_SubmixToRecord_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "SubmixToRecord");
		StopRecordingOutput_SubmixToRecord_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "SubmixToRecord", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress, StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite");
		StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite");
		StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_ReturnValue_PropertyAddress, StopRecordingOutput_FunctionAddress, "ReturnValue");
		StopRecordingOutput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "ReturnValue");
		StopRecordingOutput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		StopRecordingOutput_IsValid = StopRecordingOutput_FunctionAddress != IntPtr.Zero && StopRecordingOutput_WorldContextObject_IsValid && StopRecordingOutput_ExportType_IsValid && StopRecordingOutput_Name_IsValid && StopRecordingOutput_Path_IsValid && StopRecordingOutput_SubmixToRecord_IsValid && StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid && StopRecordingOutput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopRecordingOutput", StopRecordingOutput_IsValid);
		StopAudioBus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAudioBus");
		StopAudioBus_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAudioBus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAudioBus_WorldContextObject_PropertyAddress, StopAudioBus_FunctionAddress, "WorldContextObject");
		StopAudioBus_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopAudioBus_FunctionAddress, "WorldContextObject");
		StopAudioBus_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAudioBus_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAudioBus_AudioBus_PropertyAddress, StopAudioBus_FunctionAddress, "AudioBus");
		StopAudioBus_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(StopAudioBus_FunctionAddress, "AudioBus");
		StopAudioBus_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAudioBus_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		StopAudioBus_IsValid = StopAudioBus_FunctionAddress != IntPtr.Zero && StopAudioBus_WorldContextObject_IsValid && StopAudioBus_AudioBus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAudioBus", StopAudioBus_IsValid);
		StopAnalyzingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StopAnalyzingOutput");
		StopAnalyzingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnalyzingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAnalyzingOutput_WorldContextObject_PropertyAddress, StopAnalyzingOutput_FunctionAddress, "WorldContextObject");
		StopAnalyzingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopAnalyzingOutput_FunctionAddress, "WorldContextObject");
		StopAnalyzingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAnalyzingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StopAnalyzingOutput_SubmixToStopAnalyzing_PropertyAddress, StopAnalyzingOutput_FunctionAddress, "SubmixToStopAnalyzing");
		StopAnalyzingOutput_SubmixToStopAnalyzing_Offset = NativeReflectionCached.GetPropertyOffset(StopAnalyzingOutput_FunctionAddress, "SubmixToStopAnalyzing");
		StopAnalyzingOutput_SubmixToStopAnalyzing_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAnalyzingOutput_FunctionAddress, "SubmixToStopAnalyzing", Classes.FObjectProperty);
		StopAnalyzingOutput_IsValid = StopAnalyzingOutput_FunctionAddress != IntPtr.Zero && StopAnalyzingOutput_WorldContextObject_IsValid && StopAnalyzingOutput_SubmixToStopAnalyzing_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StopAnalyzingOutput", StopAnalyzingOutput_IsValid);
		StartRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartRecordingOutput");
		StartRecordingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(StartRecordingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingOutput_WorldContextObject_PropertyAddress, StartRecordingOutput_FunctionAddress, "WorldContextObject");
		StartRecordingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingOutput_FunctionAddress, "WorldContextObject");
		StartRecordingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingOutput_ExpectedDuration_PropertyAddress, StartRecordingOutput_FunctionAddress, "ExpectedDuration");
		StartRecordingOutput_ExpectedDuration_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingOutput_FunctionAddress, "ExpectedDuration");
		StartRecordingOutput_ExpectedDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingOutput_FunctionAddress, "ExpectedDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingOutput_SubmixToRecord_PropertyAddress, StartRecordingOutput_FunctionAddress, "SubmixToRecord");
		StartRecordingOutput_SubmixToRecord_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingOutput_FunctionAddress, "SubmixToRecord");
		StartRecordingOutput_SubmixToRecord_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingOutput_FunctionAddress, "SubmixToRecord", Classes.FObjectProperty);
		StartRecordingOutput_IsValid = StartRecordingOutput_FunctionAddress != IntPtr.Zero && StartRecordingOutput_WorldContextObject_IsValid && StartRecordingOutput_ExpectedDuration_IsValid && StartRecordingOutput_SubmixToRecord_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartRecordingOutput", StartRecordingOutput_IsValid);
		StartAudioBus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartAudioBus");
		StartAudioBus_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAudioBus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAudioBus_WorldContextObject_PropertyAddress, StartAudioBus_FunctionAddress, "WorldContextObject");
		StartAudioBus_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartAudioBus_FunctionAddress, "WorldContextObject");
		StartAudioBus_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAudioBus_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAudioBus_AudioBus_PropertyAddress, StartAudioBus_FunctionAddress, "AudioBus");
		StartAudioBus_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(StartAudioBus_FunctionAddress, "AudioBus");
		StartAudioBus_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAudioBus_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		StartAudioBus_IsValid = StartAudioBus_FunctionAddress != IntPtr.Zero && StartAudioBus_WorldContextObject_IsValid && StartAudioBus_AudioBus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAudioBus", StartAudioBus_IsValid);
		StartAnalyzingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartAnalyzingOutput");
		StartAnalyzingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAnalyzingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_WorldContextObject_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "WorldContextObject");
		StartAnalyzingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "WorldContextObject");
		StartAnalyzingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_SubmixToAnalyze_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "SubmixToAnalyze");
		StartAnalyzingOutput_SubmixToAnalyze_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "SubmixToAnalyze");
		StartAnalyzingOutput_SubmixToAnalyze_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "SubmixToAnalyze", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_FFTSize_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "FFTSize");
		StartAnalyzingOutput_FFTSize_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "FFTSize");
		StartAnalyzingOutput_FFTSize_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "FFTSize", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_InterpolationMethod_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "InterpolationMethod");
		StartAnalyzingOutput_InterpolationMethod_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "InterpolationMethod");
		StartAnalyzingOutput_InterpolationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "InterpolationMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_WindowType_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "WindowType");
		StartAnalyzingOutput_WindowType_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "WindowType");
		StartAnalyzingOutput_WindowType_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "WindowType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_HopSize_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "HopSize");
		StartAnalyzingOutput_HopSize_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "HopSize");
		StartAnalyzingOutput_HopSize_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "HopSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzingOutput_SpectrumType_PropertyAddress, StartAnalyzingOutput_FunctionAddress, "SpectrumType");
		StartAnalyzingOutput_SpectrumType_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzingOutput_FunctionAddress, "SpectrumType");
		StartAnalyzingOutput_SpectrumType_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzingOutput_FunctionAddress, "SpectrumType", Classes.FEnumProperty);
		StartAnalyzingOutput_IsValid = StartAnalyzingOutput_FunctionAddress != IntPtr.Zero && StartAnalyzingOutput_WorldContextObject_IsValid && StartAnalyzingOutput_SubmixToAnalyze_IsValid && StartAnalyzingOutput_FFTSize_IsValid && StartAnalyzingOutput_InterpolationMethod_IsValid && StartAnalyzingOutput_WindowType_IsValid && StartAnalyzingOutput_HopSize_IsValid && StartAnalyzingOutput_SpectrumType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:StartAnalyzingOutput", StartAnalyzingOutput_IsValid);
		SetSubmixEffectChainOverride_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSubmixEffectChainOverride");
		SetSubmixEffectChainOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixEffectChainOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixEffectChainOverride_WorldContextObject_PropertyAddress, SetSubmixEffectChainOverride_FunctionAddress, "WorldContextObject");
		SetSubmixEffectChainOverride_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixEffectChainOverride_FunctionAddress, "WorldContextObject");
		SetSubmixEffectChainOverride_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixEffectChainOverride_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixEffectChainOverride_SoundSubmix_PropertyAddress, SetSubmixEffectChainOverride_FunctionAddress, "SoundSubmix");
		SetSubmixEffectChainOverride_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixEffectChainOverride_FunctionAddress, "SoundSubmix");
		SetSubmixEffectChainOverride_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixEffectChainOverride_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixEffectChainOverride_SubmixEffectPresetChain_PropertyAddress, SetSubmixEffectChainOverride_FunctionAddress, "SubmixEffectPresetChain");
		SetSubmixEffectChainOverride_SubmixEffectPresetChain_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixEffectChainOverride_FunctionAddress, "SubmixEffectPresetChain");
		SetSubmixEffectChainOverride_SubmixEffectPresetChain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixEffectChainOverride_FunctionAddress, "SubmixEffectPresetChain", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixEffectChainOverride_FadeTimeSec_PropertyAddress, SetSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec");
		SetSubmixEffectChainOverride_FadeTimeSec_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec");
		SetSubmixEffectChainOverride_FadeTimeSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec", Classes.FFloatProperty);
		SetSubmixEffectChainOverride_IsValid = SetSubmixEffectChainOverride_FunctionAddress != IntPtr.Zero && SetSubmixEffectChainOverride_WorldContextObject_IsValid && SetSubmixEffectChainOverride_SoundSubmix_IsValid && SetSubmixEffectChainOverride_SubmixEffectPresetChain_IsValid && SetSubmixEffectChainOverride_FadeTimeSec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetSubmixEffectChainOverride", SetSubmixEffectChainOverride_IsValid);
		SetBypassSourceEffectChainEntry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBypassSourceEffectChainEntry");
		SetBypassSourceEffectChainEntry_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBypassSourceEffectChainEntry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBypassSourceEffectChainEntry_WorldContextObject_PropertyAddress, SetBypassSourceEffectChainEntry_FunctionAddress, "WorldContextObject");
		SetBypassSourceEffectChainEntry_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetBypassSourceEffectChainEntry_FunctionAddress, "WorldContextObject");
		SetBypassSourceEffectChainEntry_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBypassSourceEffectChainEntry_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBypassSourceEffectChainEntry_PresetChain_PropertyAddress, SetBypassSourceEffectChainEntry_FunctionAddress, "PresetChain");
		SetBypassSourceEffectChainEntry_PresetChain_Offset = NativeReflectionCached.GetPropertyOffset(SetBypassSourceEffectChainEntry_FunctionAddress, "PresetChain");
		SetBypassSourceEffectChainEntry_PresetChain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBypassSourceEffectChainEntry_FunctionAddress, "PresetChain", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBypassSourceEffectChainEntry_EntryIndex_PropertyAddress, SetBypassSourceEffectChainEntry_FunctionAddress, "EntryIndex");
		SetBypassSourceEffectChainEntry_EntryIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetBypassSourceEffectChainEntry_FunctionAddress, "EntryIndex");
		SetBypassSourceEffectChainEntry_EntryIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBypassSourceEffectChainEntry_FunctionAddress, "EntryIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBypassSourceEffectChainEntry_bBypassed_PropertyAddress, SetBypassSourceEffectChainEntry_FunctionAddress, "bBypassed");
		SetBypassSourceEffectChainEntry_bBypassed_Offset = NativeReflectionCached.GetPropertyOffset(SetBypassSourceEffectChainEntry_FunctionAddress, "bBypassed");
		SetBypassSourceEffectChainEntry_bBypassed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBypassSourceEffectChainEntry_FunctionAddress, "bBypassed", Classes.FBoolProperty);
		SetBypassSourceEffectChainEntry_IsValid = SetBypassSourceEffectChainEntry_FunctionAddress != IntPtr.Zero && SetBypassSourceEffectChainEntry_WorldContextObject_IsValid && SetBypassSourceEffectChainEntry_PresetChain_IsValid && SetBypassSourceEffectChainEntry_EntryIndex_IsValid && SetBypassSourceEffectChainEntry_bBypassed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:SetBypassSourceEffectChainEntry", SetBypassSourceEffectChainEntry_IsValid);
		ResumeRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResumeRecordingOutput");
		ResumeRecordingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(ResumeRecordingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResumeRecordingOutput_WorldContextObject_PropertyAddress, ResumeRecordingOutput_FunctionAddress, "WorldContextObject");
		ResumeRecordingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ResumeRecordingOutput_FunctionAddress, "WorldContextObject");
		ResumeRecordingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeRecordingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResumeRecordingOutput_SubmixToPause_PropertyAddress, ResumeRecordingOutput_FunctionAddress, "SubmixToPause");
		ResumeRecordingOutput_SubmixToPause_Offset = NativeReflectionCached.GetPropertyOffset(ResumeRecordingOutput_FunctionAddress, "SubmixToPause");
		ResumeRecordingOutput_SubmixToPause_IsValid = NativeReflectionCached.ValidatePropertyClass(ResumeRecordingOutput_FunctionAddress, "SubmixToPause", Classes.FObjectProperty);
		ResumeRecordingOutput_IsValid = ResumeRecordingOutput_FunctionAddress != IntPtr.Zero && ResumeRecordingOutput_WorldContextObject_IsValid && ResumeRecordingOutput_SubmixToPause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:ResumeRecordingOutput", ResumeRecordingOutput_IsValid);
		ReplaceSubmixEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceSubmixEffect");
		ReplaceSubmixEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceSubmixEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSubmixEffect_WorldContextObject_PropertyAddress, ReplaceSubmixEffect_FunctionAddress, "WorldContextObject");
		ReplaceSubmixEffect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSubmixEffect_FunctionAddress, "WorldContextObject");
		ReplaceSubmixEffect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSubmixEffect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSubmixEffect_InSoundSubmix_PropertyAddress, ReplaceSubmixEffect_FunctionAddress, "InSoundSubmix");
		ReplaceSubmixEffect_InSoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSubmixEffect_FunctionAddress, "InSoundSubmix");
		ReplaceSubmixEffect_InSoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSubmixEffect_FunctionAddress, "InSoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSubmixEffect_SubmixChainIndex_PropertyAddress, ReplaceSubmixEffect_FunctionAddress, "SubmixChainIndex");
		ReplaceSubmixEffect_SubmixChainIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSubmixEffect_FunctionAddress, "SubmixChainIndex");
		ReplaceSubmixEffect_SubmixChainIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSubmixEffect_FunctionAddress, "SubmixChainIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceSubmixEffect_SubmixEffectPreset_PropertyAddress, ReplaceSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		ReplaceSubmixEffect_SubmixEffectPreset_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		ReplaceSubmixEffect_SubmixEffectPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceSubmixEffect_FunctionAddress, "SubmixEffectPreset", Classes.FObjectProperty);
		ReplaceSubmixEffect_IsValid = ReplaceSubmixEffect_FunctionAddress != IntPtr.Zero && ReplaceSubmixEffect_WorldContextObject_IsValid && ReplaceSubmixEffect_InSoundSubmix_IsValid && ReplaceSubmixEffect_SubmixChainIndex_IsValid && ReplaceSubmixEffect_SubmixEffectPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:ReplaceSubmixEffect", ReplaceSubmixEffect_IsValid);
		RemoveSubmixEffectAtIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSubmixEffectAtIndex");
		RemoveSubmixEffectAtIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSubmixEffectAtIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffectAtIndex_WorldContextObject_PropertyAddress, RemoveSubmixEffectAtIndex_FunctionAddress, "WorldContextObject");
		RemoveSubmixEffectAtIndex_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffectAtIndex_FunctionAddress, "WorldContextObject");
		RemoveSubmixEffectAtIndex_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffectAtIndex_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffectAtIndex_SoundSubmix_PropertyAddress, RemoveSubmixEffectAtIndex_FunctionAddress, "SoundSubmix");
		RemoveSubmixEffectAtIndex_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffectAtIndex_FunctionAddress, "SoundSubmix");
		RemoveSubmixEffectAtIndex_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffectAtIndex_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffectAtIndex_SubmixChainIndex_PropertyAddress, RemoveSubmixEffectAtIndex_FunctionAddress, "SubmixChainIndex");
		RemoveSubmixEffectAtIndex_SubmixChainIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffectAtIndex_FunctionAddress, "SubmixChainIndex");
		RemoveSubmixEffectAtIndex_SubmixChainIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffectAtIndex_FunctionAddress, "SubmixChainIndex", Classes.FIntProperty);
		RemoveSubmixEffectAtIndex_IsValid = RemoveSubmixEffectAtIndex_FunctionAddress != IntPtr.Zero && RemoveSubmixEffectAtIndex_WorldContextObject_IsValid && RemoveSubmixEffectAtIndex_SoundSubmix_IsValid && RemoveSubmixEffectAtIndex_SubmixChainIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffectAtIndex", RemoveSubmixEffectAtIndex_IsValid);
		RemoveSubmixEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSubmixEffect");
		RemoveSubmixEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSubmixEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffect_WorldContextObject_PropertyAddress, RemoveSubmixEffect_FunctionAddress, "WorldContextObject");
		RemoveSubmixEffect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffect_FunctionAddress, "WorldContextObject");
		RemoveSubmixEffect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffect_SoundSubmix_PropertyAddress, RemoveSubmixEffect_FunctionAddress, "SoundSubmix");
		RemoveSubmixEffect_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffect_FunctionAddress, "SoundSubmix");
		RemoveSubmixEffect_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffect_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSubmixEffect_SubmixEffectPreset_PropertyAddress, RemoveSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		RemoveSubmixEffect_SubmixEffectPreset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		RemoveSubmixEffect_SubmixEffectPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSubmixEffect_FunctionAddress, "SubmixEffectPreset", Classes.FObjectProperty);
		RemoveSubmixEffect_IsValid = RemoveSubmixEffect_FunctionAddress != IntPtr.Zero && RemoveSubmixEffect_WorldContextObject_IsValid && RemoveSubmixEffect_SoundSubmix_IsValid && RemoveSubmixEffect_SubmixEffectPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSubmixEffect", RemoveSubmixEffect_IsValid);
		RemoveSourceEffectFromPresetChain_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSourceEffectFromPresetChain");
		RemoveSourceEffectFromPresetChain_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSourceEffectFromPresetChain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSourceEffectFromPresetChain_WorldContextObject_PropertyAddress, RemoveSourceEffectFromPresetChain_FunctionAddress, "WorldContextObject");
		RemoveSourceEffectFromPresetChain_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSourceEffectFromPresetChain_FunctionAddress, "WorldContextObject");
		RemoveSourceEffectFromPresetChain_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSourceEffectFromPresetChain_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSourceEffectFromPresetChain_PresetChain_PropertyAddress, RemoveSourceEffectFromPresetChain_FunctionAddress, "PresetChain");
		RemoveSourceEffectFromPresetChain_PresetChain_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSourceEffectFromPresetChain_FunctionAddress, "PresetChain");
		RemoveSourceEffectFromPresetChain_PresetChain_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSourceEffectFromPresetChain_FunctionAddress, "PresetChain", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSourceEffectFromPresetChain_EntryIndex_PropertyAddress, RemoveSourceEffectFromPresetChain_FunctionAddress, "EntryIndex");
		RemoveSourceEffectFromPresetChain_EntryIndex_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSourceEffectFromPresetChain_FunctionAddress, "EntryIndex");
		RemoveSourceEffectFromPresetChain_EntryIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSourceEffectFromPresetChain_FunctionAddress, "EntryIndex", Classes.FIntProperty);
		RemoveSourceEffectFromPresetChain_IsValid = RemoveSourceEffectFromPresetChain_FunctionAddress != IntPtr.Zero && RemoveSourceEffectFromPresetChain_WorldContextObject_IsValid && RemoveSourceEffectFromPresetChain_PresetChain_IsValid && RemoveSourceEffectFromPresetChain_EntryIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveSourceEffectFromPresetChain", RemoveSourceEffectFromPresetChain_IsValid);
		RemoveMasterSubmixEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMasterSubmixEffect");
		RemoveMasterSubmixEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMasterSubmixEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMasterSubmixEffect_WorldContextObject_PropertyAddress, RemoveMasterSubmixEffect_FunctionAddress, "WorldContextObject");
		RemoveMasterSubmixEffect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMasterSubmixEffect_FunctionAddress, "WorldContextObject");
		RemoveMasterSubmixEffect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMasterSubmixEffect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMasterSubmixEffect_SubmixEffectPreset_PropertyAddress, RemoveMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		RemoveMasterSubmixEffect_SubmixEffectPreset_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		RemoveMasterSubmixEffect_SubmixEffectPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset", Classes.FObjectProperty);
		RemoveMasterSubmixEffect_IsValid = RemoveMasterSubmixEffect_FunctionAddress != IntPtr.Zero && RemoveMasterSubmixEffect_WorldContextObject_IsValid && RemoveMasterSubmixEffect_SubmixEffectPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:RemoveMasterSubmixEffect", RemoveMasterSubmixEffect_IsValid);
		PrimeSoundForPlayback_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrimeSoundForPlayback");
		PrimeSoundForPlayback_ParamsSize = NativeReflection.GetFunctionParamsSize(PrimeSoundForPlayback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrimeSoundForPlayback_SoundWave_PropertyAddress, PrimeSoundForPlayback_FunctionAddress, "SoundWave");
		PrimeSoundForPlayback_SoundWave_Offset = NativeReflectionCached.GetPropertyOffset(PrimeSoundForPlayback_FunctionAddress, "SoundWave");
		PrimeSoundForPlayback_SoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimeSoundForPlayback_FunctionAddress, "SoundWave", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PrimeSoundForPlayback_OnLoadCompletion_PropertyAddress, PrimeSoundForPlayback_FunctionAddress, "OnLoadCompletion");
		PrimeSoundForPlayback_OnLoadCompletion_Offset = NativeReflectionCached.GetPropertyOffset(PrimeSoundForPlayback_FunctionAddress, "OnLoadCompletion");
		PrimeSoundForPlayback_OnLoadCompletion_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimeSoundForPlayback_FunctionAddress, "OnLoadCompletion", Classes.FDelegateProperty);
		PrimeSoundForPlayback_IsValid = PrimeSoundForPlayback_FunctionAddress != IntPtr.Zero && PrimeSoundForPlayback_SoundWave_IsValid && PrimeSoundForPlayback_OnLoadCompletion_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundForPlayback", PrimeSoundForPlayback_IsValid);
		PrimeSoundCueForPlayback_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrimeSoundCueForPlayback");
		PrimeSoundCueForPlayback_ParamsSize = NativeReflection.GetFunctionParamsSize(PrimeSoundCueForPlayback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrimeSoundCueForPlayback_SoundCue_PropertyAddress, PrimeSoundCueForPlayback_FunctionAddress, "SoundCue");
		PrimeSoundCueForPlayback_SoundCue_Offset = NativeReflectionCached.GetPropertyOffset(PrimeSoundCueForPlayback_FunctionAddress, "SoundCue");
		PrimeSoundCueForPlayback_SoundCue_IsValid = NativeReflectionCached.ValidatePropertyClass(PrimeSoundCueForPlayback_FunctionAddress, "SoundCue", Classes.FObjectProperty);
		PrimeSoundCueForPlayback_IsValid = PrimeSoundCueForPlayback_FunctionAddress != IntPtr.Zero && PrimeSoundCueForPlayback_SoundCue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:PrimeSoundCueForPlayback", PrimeSoundCueForPlayback_IsValid);
		PauseRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PauseRecordingOutput");
		PauseRecordingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseRecordingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PauseRecordingOutput_WorldContextObject_PropertyAddress, PauseRecordingOutput_FunctionAddress, "WorldContextObject");
		PauseRecordingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PauseRecordingOutput_FunctionAddress, "WorldContextObject");
		PauseRecordingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseRecordingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseRecordingOutput_SubmixToPause_PropertyAddress, PauseRecordingOutput_FunctionAddress, "SubmixToPause");
		PauseRecordingOutput_SubmixToPause_Offset = NativeReflectionCached.GetPropertyOffset(PauseRecordingOutput_FunctionAddress, "SubmixToPause");
		PauseRecordingOutput_SubmixToPause_IsValid = NativeReflectionCached.ValidatePropertyClass(PauseRecordingOutput_FunctionAddress, "SubmixToPause", Classes.FObjectProperty);
		PauseRecordingOutput_IsValid = PauseRecordingOutput_FunctionAddress != IntPtr.Zero && PauseRecordingOutput_WorldContextObject_IsValid && PauseRecordingOutput_SubmixToPause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:PauseRecordingOutput", PauseRecordingOutput_IsValid);
		MakePresetSpectralAnalysisBandSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakePresetSpectralAnalysisBandSettings");
		MakePresetSpectralAnalysisBandSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(MakePresetSpectralAnalysisBandSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakePresetSpectralAnalysisBandSettings_InBandPresetType_PropertyAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InBandPresetType");
		MakePresetSpectralAnalysisBandSettings_InBandPresetType_Offset = NativeReflectionCached.GetPropertyOffset(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InBandPresetType");
		MakePresetSpectralAnalysisBandSettings_InBandPresetType_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InBandPresetType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePresetSpectralAnalysisBandSettings_InNumBands_PropertyAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InNumBands");
		MakePresetSpectralAnalysisBandSettings_InNumBands_Offset = NativeReflectionCached.GetPropertyOffset(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InNumBands");
		MakePresetSpectralAnalysisBandSettings_InNumBands_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InNumBands", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakePresetSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, MakePresetSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakePresetSpectralAnalysisBandSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakePresetSpectralAnalysisBandSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakePresetSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		MakePresetSpectralAnalysisBandSettings_IsValid = MakePresetSpectralAnalysisBandSettings_FunctionAddress != IntPtr.Zero && MakePresetSpectralAnalysisBandSettings_InBandPresetType_IsValid && MakePresetSpectralAnalysisBandSettings_InNumBands_IsValid && MakePresetSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid && MakePresetSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid && MakePresetSpectralAnalysisBandSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakePresetSpectralAnalysisBandSettings", MakePresetSpectralAnalysisBandSettings_IsValid);
		MakeMusicalSpectralAnalysisBandSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeMusicalSpectralAnalysisBandSettings");
		MakeMusicalSpectralAnalysisBandSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InNumSemitones");
		MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InNumSemitones");
		MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InNumSemitones", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingMusicalNote");
		MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingMusicalNote");
		MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingMusicalNote", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingOctave");
		MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingOctave");
		MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InStartingOctave", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeMusicalSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakeMusicalSpectralAnalysisBandSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakeMusicalSpectralAnalysisBandSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeMusicalSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		MakeMusicalSpectralAnalysisBandSettings_IsValid = MakeMusicalSpectralAnalysisBandSettings_FunctionAddress != IntPtr.Zero && MakeMusicalSpectralAnalysisBandSettings_InNumSemitones_IsValid && MakeMusicalSpectralAnalysisBandSettings_InStartingMusicalNote_IsValid && MakeMusicalSpectralAnalysisBandSettings_InStartingOctave_IsValid && MakeMusicalSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid && MakeMusicalSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid && MakeMusicalSpectralAnalysisBandSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeMusicalSpectralAnalysisBandSettings", MakeMusicalSpectralAnalysisBandSettings_IsValid);
		MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeFullSpectrumSpectralAnalysisBandSettings");
		MakeFullSpectrumSpectralAnalysisBandSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InNumBands");
		MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InNumBands");
		MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InNumBands", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMinimumFrequency");
		MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMinimumFrequency");
		MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMinimumFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMaximumFrequency");
		MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMaximumFrequency");
		MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InMaximumFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec");
		MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InAttackTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec");
		MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "InReleaseTimeMsec", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_PropertyAddress, MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue");
		MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		MakeFullSpectrumSpectralAnalysisBandSettings_IsValid = MakeFullSpectrumSpectralAnalysisBandSettings_FunctionAddress != IntPtr.Zero && MakeFullSpectrumSpectralAnalysisBandSettings_InNumBands_IsValid && MakeFullSpectrumSpectralAnalysisBandSettings_InMinimumFrequency_IsValid && MakeFullSpectrumSpectralAnalysisBandSettings_InMaximumFrequency_IsValid && MakeFullSpectrumSpectralAnalysisBandSettings_InAttackTimeMsec_IsValid && MakeFullSpectrumSpectralAnalysisBandSettings_InReleaseTimeMsec_IsValid && MakeFullSpectrumSpectralAnalysisBandSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:MakeFullSpectrumSpectralAnalysisBandSettings", MakeFullSpectrumSpectralAnalysisBandSettings_IsValid);
		IsAudioBusActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAudioBusActive");
		IsAudioBusActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAudioBusActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAudioBusActive_WorldContextObject_PropertyAddress, IsAudioBusActive_FunctionAddress, "WorldContextObject");
		IsAudioBusActive_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(IsAudioBusActive_FunctionAddress, "WorldContextObject");
		IsAudioBusActive_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAudioBusActive_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAudioBusActive_AudioBus_PropertyAddress, IsAudioBusActive_FunctionAddress, "AudioBus");
		IsAudioBusActive_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(IsAudioBusActive_FunctionAddress, "AudioBus");
		IsAudioBusActive_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAudioBusActive_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAudioBusActive_ReturnValue_PropertyAddress, IsAudioBusActive_FunctionAddress, "ReturnValue");
		IsAudioBusActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAudioBusActive_FunctionAddress, "ReturnValue");
		IsAudioBusActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAudioBusActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAudioBusActive_IsValid = IsAudioBusActive_FunctionAddress != IntPtr.Zero && IsAudioBusActive_WorldContextObject_IsValid && IsAudioBusActive_AudioBus_IsValid && IsAudioBusActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:IsAudioBusActive", IsAudioBusActive_IsValid);
		GetPhaseForFrequencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPhaseForFrequencies");
		GetPhaseForFrequencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhaseForFrequencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhaseForFrequencies_WorldContextObject_PropertyAddress, GetPhaseForFrequencies_FunctionAddress, "WorldContextObject");
		GetPhaseForFrequencies_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetPhaseForFrequencies_FunctionAddress, "WorldContextObject");
		GetPhaseForFrequencies_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhaseForFrequencies_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhaseForFrequencies_Frequencies_PropertyAddress, GetPhaseForFrequencies_FunctionAddress, "Frequencies");
		GetPhaseForFrequencies_Frequencies_Offset = NativeReflectionCached.GetPropertyOffset(GetPhaseForFrequencies_FunctionAddress, "Frequencies");
		GetPhaseForFrequencies_Frequencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhaseForFrequencies_FunctionAddress, "Frequencies", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhaseForFrequencies_Phases_PropertyAddress, GetPhaseForFrequencies_FunctionAddress, "Phases");
		GetPhaseForFrequencies_Phases_Offset = NativeReflectionCached.GetPropertyOffset(GetPhaseForFrequencies_FunctionAddress, "Phases");
		GetPhaseForFrequencies_Phases_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhaseForFrequencies_FunctionAddress, "Phases", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPhaseForFrequencies_SubmixToAnalyze_PropertyAddress, GetPhaseForFrequencies_FunctionAddress, "SubmixToAnalyze");
		GetPhaseForFrequencies_SubmixToAnalyze_Offset = NativeReflectionCached.GetPropertyOffset(GetPhaseForFrequencies_FunctionAddress, "SubmixToAnalyze");
		GetPhaseForFrequencies_SubmixToAnalyze_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhaseForFrequencies_FunctionAddress, "SubmixToAnalyze", Classes.FObjectProperty);
		GetPhaseForFrequencies_IsValid = GetPhaseForFrequencies_FunctionAddress != IntPtr.Zero && GetPhaseForFrequencies_WorldContextObject_IsValid && GetPhaseForFrequencies_Frequencies_IsValid && GetPhaseForFrequencies_Phases_IsValid && GetPhaseForFrequencies_SubmixToAnalyze_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetPhaseForFrequencies", GetPhaseForFrequencies_IsValid);
		GetNumberOfEntriesInSourceEffectChain_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumberOfEntriesInSourceEffectChain");
		GetNumberOfEntriesInSourceEffectChain_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumberOfEntriesInSourceEffectChain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfEntriesInSourceEffectChain_WorldContextObject_PropertyAddress, GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "WorldContextObject");
		GetNumberOfEntriesInSourceEffectChain_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "WorldContextObject");
		GetNumberOfEntriesInSourceEffectChain_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfEntriesInSourceEffectChain_PresetChain_PropertyAddress, GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "PresetChain");
		GetNumberOfEntriesInSourceEffectChain_PresetChain_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "PresetChain");
		GetNumberOfEntriesInSourceEffectChain_PresetChain_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "PresetChain", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumberOfEntriesInSourceEffectChain_ReturnValue_PropertyAddress, GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "ReturnValue");
		GetNumberOfEntriesInSourceEffectChain_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "ReturnValue");
		GetNumberOfEntriesInSourceEffectChain_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumberOfEntriesInSourceEffectChain_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumberOfEntriesInSourceEffectChain_IsValid = GetNumberOfEntriesInSourceEffectChain_FunctionAddress != IntPtr.Zero && GetNumberOfEntriesInSourceEffectChain_WorldContextObject_IsValid && GetNumberOfEntriesInSourceEffectChain_PresetChain_IsValid && GetNumberOfEntriesInSourceEffectChain_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetNumberOfEntriesInSourceEffectChain", GetNumberOfEntriesInSourceEffectChain_IsValid);
		GetMagnitudeForFrequencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMagnitudeForFrequencies");
		GetMagnitudeForFrequencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMagnitudeForFrequencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMagnitudeForFrequencies_WorldContextObject_PropertyAddress, GetMagnitudeForFrequencies_FunctionAddress, "WorldContextObject");
		GetMagnitudeForFrequencies_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetMagnitudeForFrequencies_FunctionAddress, "WorldContextObject");
		GetMagnitudeForFrequencies_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMagnitudeForFrequencies_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMagnitudeForFrequencies_Frequencies_PropertyAddress, GetMagnitudeForFrequencies_FunctionAddress, "Frequencies");
		GetMagnitudeForFrequencies_Frequencies_Offset = NativeReflectionCached.GetPropertyOffset(GetMagnitudeForFrequencies_FunctionAddress, "Frequencies");
		GetMagnitudeForFrequencies_Frequencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMagnitudeForFrequencies_FunctionAddress, "Frequencies", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMagnitudeForFrequencies_Magnitudes_PropertyAddress, GetMagnitudeForFrequencies_FunctionAddress, "Magnitudes");
		GetMagnitudeForFrequencies_Magnitudes_Offset = NativeReflectionCached.GetPropertyOffset(GetMagnitudeForFrequencies_FunctionAddress, "Magnitudes");
		GetMagnitudeForFrequencies_Magnitudes_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMagnitudeForFrequencies_FunctionAddress, "Magnitudes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMagnitudeForFrequencies_SubmixToAnalyze_PropertyAddress, GetMagnitudeForFrequencies_FunctionAddress, "SubmixToAnalyze");
		GetMagnitudeForFrequencies_SubmixToAnalyze_Offset = NativeReflectionCached.GetPropertyOffset(GetMagnitudeForFrequencies_FunctionAddress, "SubmixToAnalyze");
		GetMagnitudeForFrequencies_SubmixToAnalyze_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMagnitudeForFrequencies_FunctionAddress, "SubmixToAnalyze", Classes.FObjectProperty);
		GetMagnitudeForFrequencies_IsValid = GetMagnitudeForFrequencies_FunctionAddress != IntPtr.Zero && GetMagnitudeForFrequencies_WorldContextObject_IsValid && GetMagnitudeForFrequencies_Frequencies_IsValid && GetMagnitudeForFrequencies_Magnitudes_IsValid && GetMagnitudeForFrequencies_SubmixToAnalyze_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetMagnitudeForFrequencies", GetMagnitudeForFrequencies_IsValid);
		GetCurrentAudioOutputDeviceName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentAudioOutputDeviceName");
		GetCurrentAudioOutputDeviceName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAudioOutputDeviceName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAudioOutputDeviceName_WorldContextObject_PropertyAddress, GetCurrentAudioOutputDeviceName_FunctionAddress, "WorldContextObject");
		GetCurrentAudioOutputDeviceName_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAudioOutputDeviceName_FunctionAddress, "WorldContextObject");
		GetCurrentAudioOutputDeviceName_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAudioOutputDeviceName_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_PropertyAddress, GetCurrentAudioOutputDeviceName_FunctionAddress, "OnObtainCurrentDeviceEvent");
		GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAudioOutputDeviceName_FunctionAddress, "OnObtainCurrentDeviceEvent");
		GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAudioOutputDeviceName_FunctionAddress, "OnObtainCurrentDeviceEvent", Classes.FDelegateProperty);
		GetCurrentAudioOutputDeviceName_IsValid = GetCurrentAudioOutputDeviceName_FunctionAddress != IntPtr.Zero && GetCurrentAudioOutputDeviceName_WorldContextObject_IsValid && GetCurrentAudioOutputDeviceName_OnObtainCurrentDeviceEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetCurrentAudioOutputDeviceName", GetCurrentAudioOutputDeviceName_IsValid);
		GetAvailableAudioOutputDevices_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableAudioOutputDevices");
		GetAvailableAudioOutputDevices_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableAudioOutputDevices_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableAudioOutputDevices_WorldContextObject_PropertyAddress, GetAvailableAudioOutputDevices_FunctionAddress, "WorldContextObject");
		GetAvailableAudioOutputDevices_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableAudioOutputDevices_FunctionAddress, "WorldContextObject");
		GetAvailableAudioOutputDevices_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableAudioOutputDevices_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableAudioOutputDevices_OnObtainDevicesEvent_PropertyAddress, GetAvailableAudioOutputDevices_FunctionAddress, "OnObtainDevicesEvent");
		GetAvailableAudioOutputDevices_OnObtainDevicesEvent_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableAudioOutputDevices_FunctionAddress, "OnObtainDevicesEvent");
		GetAvailableAudioOutputDevices_OnObtainDevicesEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableAudioOutputDevices_FunctionAddress, "OnObtainDevicesEvent", Classes.FDelegateProperty);
		GetAvailableAudioOutputDevices_IsValid = GetAvailableAudioOutputDevices_FunctionAddress != IntPtr.Zero && GetAvailableAudioOutputDevices_WorldContextObject_IsValid && GetAvailableAudioOutputDevices_OnObtainDevicesEvent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:GetAvailableAudioOutputDevices", GetAvailableAudioOutputDevices_IsValid);
		Conv_AudioOutputDeviceInfoToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_AudioOutputDeviceInfoToString");
		Conv_AudioOutputDeviceInfoToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_AudioOutputDeviceInfoToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_AudioOutputDeviceInfoToString_Info_PropertyAddress, Conv_AudioOutputDeviceInfoToString_FunctionAddress, "Info");
		Conv_AudioOutputDeviceInfoToString_Info_Offset = NativeReflectionCached.GetPropertyOffset(Conv_AudioOutputDeviceInfoToString_FunctionAddress, "Info");
		Conv_AudioOutputDeviceInfoToString_Info_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_AudioOutputDeviceInfoToString_FunctionAddress, "Info", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_AudioOutputDeviceInfoToString_ReturnValue_PropertyAddress, Conv_AudioOutputDeviceInfoToString_FunctionAddress, "ReturnValue");
		Conv_AudioOutputDeviceInfoToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_AudioOutputDeviceInfoToString_FunctionAddress, "ReturnValue");
		Conv_AudioOutputDeviceInfoToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_AudioOutputDeviceInfoToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_AudioOutputDeviceInfoToString_IsValid = Conv_AudioOutputDeviceInfoToString_FunctionAddress != IntPtr.Zero && Conv_AudioOutputDeviceInfoToString_Info_IsValid && Conv_AudioOutputDeviceInfoToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:Conv_AudioOutputDeviceInfoToString", Conv_AudioOutputDeviceInfoToString_IsValid);
		ClearSubmixEffects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearSubmixEffects");
		ClearSubmixEffects_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSubmixEffects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSubmixEffects_WorldContextObject_PropertyAddress, ClearSubmixEffects_FunctionAddress, "WorldContextObject");
		ClearSubmixEffects_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ClearSubmixEffects_FunctionAddress, "WorldContextObject");
		ClearSubmixEffects_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSubmixEffects_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearSubmixEffects_SoundSubmix_PropertyAddress, ClearSubmixEffects_FunctionAddress, "SoundSubmix");
		ClearSubmixEffects_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(ClearSubmixEffects_FunctionAddress, "SoundSubmix");
		ClearSubmixEffects_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSubmixEffects_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		ClearSubmixEffects_IsValid = ClearSubmixEffects_FunctionAddress != IntPtr.Zero && ClearSubmixEffects_WorldContextObject_IsValid && ClearSubmixEffects_SoundSubmix_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffects", ClearSubmixEffects_IsValid);
		ClearSubmixEffectChainOverride_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearSubmixEffectChainOverride");
		ClearSubmixEffectChainOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSubmixEffectChainOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearSubmixEffectChainOverride_WorldContextObject_PropertyAddress, ClearSubmixEffectChainOverride_FunctionAddress, "WorldContextObject");
		ClearSubmixEffectChainOverride_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ClearSubmixEffectChainOverride_FunctionAddress, "WorldContextObject");
		ClearSubmixEffectChainOverride_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSubmixEffectChainOverride_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearSubmixEffectChainOverride_SoundSubmix_PropertyAddress, ClearSubmixEffectChainOverride_FunctionAddress, "SoundSubmix");
		ClearSubmixEffectChainOverride_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(ClearSubmixEffectChainOverride_FunctionAddress, "SoundSubmix");
		ClearSubmixEffectChainOverride_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSubmixEffectChainOverride_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearSubmixEffectChainOverride_FadeTimeSec_PropertyAddress, ClearSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec");
		ClearSubmixEffectChainOverride_FadeTimeSec_Offset = NativeReflectionCached.GetPropertyOffset(ClearSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec");
		ClearSubmixEffectChainOverride_FadeTimeSec_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearSubmixEffectChainOverride_FunctionAddress, "FadeTimeSec", Classes.FFloatProperty);
		ClearSubmixEffectChainOverride_IsValid = ClearSubmixEffectChainOverride_FunctionAddress != IntPtr.Zero && ClearSubmixEffectChainOverride_WorldContextObject_IsValid && ClearSubmixEffectChainOverride_SoundSubmix_IsValid && ClearSubmixEffectChainOverride_FadeTimeSec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearSubmixEffectChainOverride", ClearSubmixEffectChainOverride_IsValid);
		ClearMasterSubmixEffects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearMasterSubmixEffects");
		ClearMasterSubmixEffects_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMasterSubmixEffects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearMasterSubmixEffects_WorldContextObject_PropertyAddress, ClearMasterSubmixEffects_FunctionAddress, "WorldContextObject");
		ClearMasterSubmixEffects_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ClearMasterSubmixEffects_FunctionAddress, "WorldContextObject");
		ClearMasterSubmixEffects_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMasterSubmixEffects_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		ClearMasterSubmixEffects_IsValid = ClearMasterSubmixEffects_FunctionAddress != IntPtr.Zero && ClearMasterSubmixEffects_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:ClearMasterSubmixEffects", ClearMasterSubmixEffects_IsValid);
		AddSubmixEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSubmixEffect");
		AddSubmixEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSubmixEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSubmixEffect_WorldContextObject_PropertyAddress, AddSubmixEffect_FunctionAddress, "WorldContextObject");
		AddSubmixEffect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddSubmixEffect_FunctionAddress, "WorldContextObject");
		AddSubmixEffect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubmixEffect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubmixEffect_SoundSubmix_PropertyAddress, AddSubmixEffect_FunctionAddress, "SoundSubmix");
		AddSubmixEffect_SoundSubmix_Offset = NativeReflectionCached.GetPropertyOffset(AddSubmixEffect_FunctionAddress, "SoundSubmix");
		AddSubmixEffect_SoundSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubmixEffect_FunctionAddress, "SoundSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubmixEffect_SubmixEffectPreset_PropertyAddress, AddSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		AddSubmixEffect_SubmixEffectPreset_Offset = NativeReflectionCached.GetPropertyOffset(AddSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		AddSubmixEffect_SubmixEffectPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubmixEffect_FunctionAddress, "SubmixEffectPreset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSubmixEffect_ReturnValue_PropertyAddress, AddSubmixEffect_FunctionAddress, "ReturnValue");
		AddSubmixEffect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSubmixEffect_FunctionAddress, "ReturnValue");
		AddSubmixEffect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSubmixEffect_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		AddSubmixEffect_IsValid = AddSubmixEffect_FunctionAddress != IntPtr.Zero && AddSubmixEffect_WorldContextObject_IsValid && AddSubmixEffect_SoundSubmix_IsValid && AddSubmixEffect_SubmixEffectPreset_IsValid && AddSubmixEffect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSubmixEffect", AddSubmixEffect_IsValid);
		AddSourceEffectToPresetChain_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSourceEffectToPresetChain");
		AddSourceEffectToPresetChain_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSourceEffectToPresetChain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSourceEffectToPresetChain_WorldContextObject_PropertyAddress, AddSourceEffectToPresetChain_FunctionAddress, "WorldContextObject");
		AddSourceEffectToPresetChain_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddSourceEffectToPresetChain_FunctionAddress, "WorldContextObject");
		AddSourceEffectToPresetChain_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSourceEffectToPresetChain_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSourceEffectToPresetChain_PresetChain_PropertyAddress, AddSourceEffectToPresetChain_FunctionAddress, "PresetChain");
		AddSourceEffectToPresetChain_PresetChain_Offset = NativeReflectionCached.GetPropertyOffset(AddSourceEffectToPresetChain_FunctionAddress, "PresetChain");
		AddSourceEffectToPresetChain_PresetChain_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSourceEffectToPresetChain_FunctionAddress, "PresetChain", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSourceEffectToPresetChain_Entry_PropertyAddress, AddSourceEffectToPresetChain_FunctionAddress, "Entry");
		AddSourceEffectToPresetChain_Entry_Offset = NativeReflectionCached.GetPropertyOffset(AddSourceEffectToPresetChain_FunctionAddress, "Entry");
		AddSourceEffectToPresetChain_Entry_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSourceEffectToPresetChain_FunctionAddress, "Entry", Classes.FStructProperty);
		AddSourceEffectToPresetChain_IsValid = AddSourceEffectToPresetChain_FunctionAddress != IntPtr.Zero && AddSourceEffectToPresetChain_WorldContextObject_IsValid && AddSourceEffectToPresetChain_PresetChain_IsValid && AddSourceEffectToPresetChain_Entry_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddSourceEffectToPresetChain", AddSourceEffectToPresetChain_IsValid);
		AddMasterSubmixEffect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMasterSubmixEffect");
		AddMasterSubmixEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMasterSubmixEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMasterSubmixEffect_WorldContextObject_PropertyAddress, AddMasterSubmixEffect_FunctionAddress, "WorldContextObject");
		AddMasterSubmixEffect_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddMasterSubmixEffect_FunctionAddress, "WorldContextObject");
		AddMasterSubmixEffect_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMasterSubmixEffect_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMasterSubmixEffect_SubmixEffectPreset_PropertyAddress, AddMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		AddMasterSubmixEffect_SubmixEffectPreset_Offset = NativeReflectionCached.GetPropertyOffset(AddMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset");
		AddMasterSubmixEffect_SubmixEffectPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMasterSubmixEffect_FunctionAddress, "SubmixEffectPreset", Classes.FObjectProperty);
		AddMasterSubmixEffect_IsValid = AddMasterSubmixEffect_FunctionAddress != IntPtr.Zero && AddMasterSubmixEffect_WorldContextObject_IsValid && AddMasterSubmixEffect_SubmixEffectPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.AudioMixerBlueprintLibrary:AddMasterSubmixEffect", AddMasterSubmixEffect_IsValid);
	}
}
