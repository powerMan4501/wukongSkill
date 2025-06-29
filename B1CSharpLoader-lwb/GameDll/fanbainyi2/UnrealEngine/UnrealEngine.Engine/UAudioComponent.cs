using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AudioComponent", "Engine", UnrealModuleType.Engine)]
public class UAudioComponent : USceneComponent
{
	private static bool Sound_IsValid;

	private static int Sound_Offset;

	private static bool DefaultParameters_IsValid;

	private static FFieldAddress DefaultParameters_PropertyAddress;

	private static int DefaultParameters_Offset;

	private TArrayReadWriteMarshaler<FAudioParameter> DefaultParameters_MarshalerCached;

	private static bool AllowSpatialization_IsValid;

	private static FFieldAddress AllowSpatialization_PropertyAddress;

	private static int AllowSpatialization_Offset;

	private static bool OverrideAttenuation_IsValid;

	private static FFieldAddress OverrideAttenuation_PropertyAddress;

	private static int OverrideAttenuation_Offset;

	private static bool OverrideSubtitlePriority_IsValid;

	private static FFieldAddress OverrideSubtitlePriority_PropertyAddress;

	private static int OverrideSubtitlePriority_Offset;

	private static bool IsUISound_IsValid;

	private static FFieldAddress IsUISound_PropertyAddress;

	private static int IsUISound_Offset;

	private static bool EnableLowPassFilter_IsValid;

	private static FFieldAddress EnableLowPassFilter_PropertyAddress;

	private static int EnableLowPassFilter_Offset;

	private static bool OverridePriority_IsValid;

	private static FFieldAddress OverridePriority_PropertyAddress;

	private static int OverridePriority_Offset;

	private static bool SuppressSubtitles_IsValid;

	private static FFieldAddress SuppressSubtitles_PropertyAddress;

	private static int SuppressSubtitles_Offset;

	private static bool CanPlayMultipleInstances_IsValid;

	private static FFieldAddress CanPlayMultipleInstances_PropertyAddress;

	private static int CanPlayMultipleInstances_Offset;

	private static bool DisableParameterUpdatesWhilePlaying_IsValid;

	private static FFieldAddress DisableParameterUpdatesWhilePlaying_PropertyAddress;

	private static int DisableParameterUpdatesWhilePlaying_Offset;

	private static bool AutoManageAttachment_IsValid;

	private static FFieldAddress AutoManageAttachment_PropertyAddress;

	private static int AutoManageAttachment_Offset;

	private static bool PitchModulationMin_IsValid;

	private static int PitchModulationMin_Offset;

	private static bool PitchModulationMax_IsValid;

	private static int PitchModulationMax_Offset;

	private static bool VolumeModulationMin_IsValid;

	private static int VolumeModulationMin_Offset;

	private static bool VolumeModulationMax_IsValid;

	private static int VolumeModulationMax_Offset;

	private static bool VolumeMultiplier_IsValid;

	private static int VolumeMultiplier_Offset;

	private static bool EnvelopeFollowerAttackTime_IsValid;

	private static int EnvelopeFollowerAttackTime_Offset;

	private static bool EnvelopeFollowerReleaseTime_IsValid;

	private static int EnvelopeFollowerReleaseTime_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool SubtitlePriority_IsValid;

	private static int SubtitlePriority_Offset;

	private static bool SourceEffectChain_IsValid;

	private static int SourceEffectChain_Offset;

	private static bool PitchMultiplier_IsValid;

	private static int PitchMultiplier_Offset;

	private static bool LowPassFilterFrequency_IsValid;

	private static int LowPassFilterFrequency_Offset;

	private static bool AttenuationSettings_IsValid;

	private static int AttenuationSettings_Offset;

	private static bool AttenuationOverrides_IsValid;

	private static int AttenuationOverrides_Offset;

	private static bool ConcurrencySet_IsValid;

	private static FFieldAddress ConcurrencySet_PropertyAddress;

	private static int ConcurrencySet_Offset;

	private TSetReadWriteMarshaler<USoundConcurrency> ConcurrencySet_MarshalerCached;

	private static bool AutoAttachLocationRule_IsValid;

	private static FFieldAddress AutoAttachLocationRule_PropertyAddress;

	private static int AutoAttachLocationRule_Offset;

	private static bool AutoAttachRotationRule_IsValid;

	private static FFieldAddress AutoAttachRotationRule_PropertyAddress;

	private static int AutoAttachRotationRule_Offset;

	private static bool AutoAttachScaleRule_IsValid;

	private static FFieldAddress AutoAttachScaleRule_PropertyAddress;

	private static int AutoAttachScaleRule_Offset;

	private static bool ModulationRouting_IsValid;

	private static int ModulationRouting_Offset;

	private static bool OnAudioPlayStateChanged_IsValid;

	private static int OnAudioPlayStateChanged_Offset;

	private FOnAudioPlayStateChanged OnAudioPlayStateChanged_DelegateCached;

	private static bool OnAudioVirtualizationChanged_IsValid;

	private static int OnAudioVirtualizationChanged_Offset;

	private FOnAudioVirtualizationChanged OnAudioVirtualizationChanged_DelegateCached;

	private static bool OnAudioFinished_IsValid;

	private static int OnAudioFinished_Offset;

	private FOnAudioFinished OnAudioFinished_DelegateCached;

	private static bool OnAudioPlaybackPercent_IsValid;

	private static int OnAudioPlaybackPercent_Offset;

	private FOnAudioPlaybackPercent OnAudioPlaybackPercent_DelegateCached;

	private static bool OnAudioSingleEnvelopeValue_IsValid;

	private static int OnAudioSingleEnvelopeValue_Offset;

	private FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue_DelegateCached;

	private static bool OnAudioMultiEnvelopeValue_IsValid;

	private static int OnAudioMultiEnvelopeValue_Offset;

	private FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue_DelegateCached;

	private static bool AutoAttachParent_IsValid;

	private static int AutoAttachParent_Offset;

	private static bool AutoAttachSocketName_IsValid;

	private static int AutoAttachSocketName_Offset;

	private static bool StopDelayed_IsValid;

	private static IntPtr StopDelayed_FunctionAddress;

	private static int StopDelayed_ParamsSize;

	private static bool StopDelayed_DelayTime_IsValid;

	private static FFieldAddress StopDelayed_DelayTime_PropertyAddress;

	private static int StopDelayed_DelayTime_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetWaveParameter_IsValid;

	private static IntPtr SetWaveParameter_FunctionAddress;

	private static int SetWaveParameter_ParamsSize;

	private static bool SetWaveParameter_InName_IsValid;

	private static FFieldAddress SetWaveParameter_InName_PropertyAddress;

	private static int SetWaveParameter_InName_Offset;

	private static bool SetWaveParameter_InWave_IsValid;

	private static FFieldAddress SetWaveParameter_InWave_PropertyAddress;

	private static int SetWaveParameter_InWave_Offset;

	private static bool SetVolumeMultiplier_IsValid;

	private static IntPtr SetVolumeMultiplier_FunctionAddress;

	private static int SetVolumeMultiplier_ParamsSize;

	private static bool SetVolumeMultiplier_NewVolumeMultiplier_IsValid;

	private static FFieldAddress SetVolumeMultiplier_NewVolumeMultiplier_PropertyAddress;

	private static int SetVolumeMultiplier_NewVolumeMultiplier_Offset;

	private static bool SetUISound_IsValid;

	private static IntPtr SetUISound_FunctionAddress;

	private static int SetUISound_ParamsSize;

	private static bool SetUISound_bInUISound_IsValid;

	private static FFieldAddress SetUISound_bInUISound_PropertyAddress;

	private static int SetUISound_bInUISound_Offset;

	private static bool SetSubmixSend_IsValid;

	private static IntPtr SetSubmixSend_FunctionAddress;

	private static int SetSubmixSend_ParamsSize;

	private static bool SetSubmixSend_Submix_IsValid;

	private static FFieldAddress SetSubmixSend_Submix_PropertyAddress;

	private static int SetSubmixSend_Submix_Offset;

	private static bool SetSubmixSend_SendLevel_IsValid;

	private static FFieldAddress SetSubmixSend_SendLevel_PropertyAddress;

	private static int SetSubmixSend_SendLevel_Offset;

	private static bool SetSourceBusSendPreEffect_IsValid;

	private static IntPtr SetSourceBusSendPreEffect_FunctionAddress;

	private static int SetSourceBusSendPreEffect_ParamsSize;

	private static bool SetSourceBusSendPreEffect_SoundSourceBus_IsValid;

	private static FFieldAddress SetSourceBusSendPreEffect_SoundSourceBus_PropertyAddress;

	private static int SetSourceBusSendPreEffect_SoundSourceBus_Offset;

	private static bool SetSourceBusSendPreEffect_SourceBusSendLevel_IsValid;

	private static FFieldAddress SetSourceBusSendPreEffect_SourceBusSendLevel_PropertyAddress;

	private static int SetSourceBusSendPreEffect_SourceBusSendLevel_Offset;

	private static bool SetSourceBusSendPostEffect_IsValid;

	private static IntPtr SetSourceBusSendPostEffect_FunctionAddress;

	private static int SetSourceBusSendPostEffect_ParamsSize;

	private static bool SetSourceBusSendPostEffect_SoundSourceBus_IsValid;

	private static FFieldAddress SetSourceBusSendPostEffect_SoundSourceBus_PropertyAddress;

	private static int SetSourceBusSendPostEffect_SoundSourceBus_Offset;

	private static bool SetSourceBusSendPostEffect_SourceBusSendLevel_IsValid;

	private static FFieldAddress SetSourceBusSendPostEffect_SourceBusSendLevel_PropertyAddress;

	private static int SetSourceBusSendPostEffect_SourceBusSendLevel_Offset;

	private static bool SetSound_IsValid;

	private static IntPtr SetSound_FunctionAddress;

	private static int SetSound_ParamsSize;

	private static bool SetSound_NewSound_IsValid;

	private static FFieldAddress SetSound_NewSound_PropertyAddress;

	private static int SetSound_NewSound_Offset;

	private static bool SetPitchMultiplier_IsValid;

	private static IntPtr SetPitchMultiplier_FunctionAddress;

	private static int SetPitchMultiplier_ParamsSize;

	private static bool SetPitchMultiplier_NewPitchMultiplier_IsValid;

	private static FFieldAddress SetPitchMultiplier_NewPitchMultiplier_PropertyAddress;

	private static int SetPitchMultiplier_NewPitchMultiplier_Offset;

	private static bool SetPaused_IsValid;

	private static IntPtr SetPaused_FunctionAddress;

	private static int SetPaused_ParamsSize;

	private static bool SetPaused_bPause_IsValid;

	private static FFieldAddress SetPaused_bPause_PropertyAddress;

	private static int SetPaused_bPause_Offset;

	private static bool SetOutputToBusOnly_IsValid;

	private static IntPtr SetOutputToBusOnly_FunctionAddress;

	private static int SetOutputToBusOnly_ParamsSize;

	private static bool SetOutputToBusOnly_bInOutputToBusOnly_IsValid;

	private static FFieldAddress SetOutputToBusOnly_bInOutputToBusOnly_PropertyAddress;

	private static int SetOutputToBusOnly_bInOutputToBusOnly_Offset;

	private static bool SetLowPassFilterFrequency_IsValid;

	private static IntPtr SetLowPassFilterFrequency_FunctionAddress;

	private static int SetLowPassFilterFrequency_ParamsSize;

	private static bool SetLowPassFilterFrequency_InLowPassFilterFrequency_IsValid;

	private static FFieldAddress SetLowPassFilterFrequency_InLowPassFilterFrequency_PropertyAddress;

	private static int SetLowPassFilterFrequency_InLowPassFilterFrequency_Offset;

	private static bool SetLowPassFilterEnabled_IsValid;

	private static IntPtr SetLowPassFilterEnabled_FunctionAddress;

	private static int SetLowPassFilterEnabled_ParamsSize;

	private static bool SetLowPassFilterEnabled_InLowPassFilterEnabled_IsValid;

	private static FFieldAddress SetLowPassFilterEnabled_InLowPassFilterEnabled_PropertyAddress;

	private static int SetLowPassFilterEnabled_InLowPassFilterEnabled_Offset;

	private static bool SetIntParameter_7B56EE80_IsValid;

	private static IntPtr SetIntParameter_7B56EE80_FunctionAddress;

	private static int SetIntParameter_7B56EE80_ParamsSize;

	private static bool SetIntParameter_7B56EE80_InName_IsValid;

	private static FFieldAddress SetIntParameter_7B56EE80_InName_PropertyAddress;

	private static int SetIntParameter_7B56EE80_InName_Offset;

	private static bool SetIntParameter_7B56EE80_InInt_IsValid;

	private static FFieldAddress SetIntParameter_7B56EE80_InInt_PropertyAddress;

	private static int SetIntParameter_7B56EE80_InInt_Offset;

	private static bool SetFloatParameter_A140E9DF_IsValid;

	private static IntPtr SetFloatParameter_A140E9DF_FunctionAddress;

	private static int SetFloatParameter_A140E9DF_ParamsSize;

	private static bool SetFloatParameter_A140E9DF_InName_IsValid;

	private static FFieldAddress SetFloatParameter_A140E9DF_InName_PropertyAddress;

	private static int SetFloatParameter_A140E9DF_InName_Offset;

	private static bool SetFloatParameter_A140E9DF_InFloat_IsValid;

	private static FFieldAddress SetFloatParameter_A140E9DF_InFloat_PropertyAddress;

	private static int SetFloatParameter_A140E9DF_InFloat_Offset;

	private static bool SetBoolParameter_2CA8F371_IsValid;

	private static IntPtr SetBoolParameter_2CA8F371_FunctionAddress;

	private static int SetBoolParameter_2CA8F371_ParamsSize;

	private static bool SetBoolParameter_2CA8F371_InName_IsValid;

	private static FFieldAddress SetBoolParameter_2CA8F371_InName_PropertyAddress;

	private static int SetBoolParameter_2CA8F371_InName_Offset;

	private static bool SetBoolParameter_2CA8F371_InBool_IsValid;

	private static FFieldAddress SetBoolParameter_2CA8F371_InBool_PropertyAddress;

	private static int SetBoolParameter_2CA8F371_InBool_Offset;

	private static bool SetAudioBusSendPreEffect_IsValid;

	private static IntPtr SetAudioBusSendPreEffect_FunctionAddress;

	private static int SetAudioBusSendPreEffect_ParamsSize;

	private static bool SetAudioBusSendPreEffect_AudioBus_IsValid;

	private static FFieldAddress SetAudioBusSendPreEffect_AudioBus_PropertyAddress;

	private static int SetAudioBusSendPreEffect_AudioBus_Offset;

	private static bool SetAudioBusSendPreEffect_AudioBusSendLevel_IsValid;

	private static FFieldAddress SetAudioBusSendPreEffect_AudioBusSendLevel_PropertyAddress;

	private static int SetAudioBusSendPreEffect_AudioBusSendLevel_Offset;

	private static bool SetAudioBusSendPostEffect_IsValid;

	private static IntPtr SetAudioBusSendPostEffect_FunctionAddress;

	private static int SetAudioBusSendPostEffect_ParamsSize;

	private static bool SetAudioBusSendPostEffect_AudioBus_IsValid;

	private static FFieldAddress SetAudioBusSendPostEffect_AudioBus_PropertyAddress;

	private static int SetAudioBusSendPostEffect_AudioBus_Offset;

	private static bool SetAudioBusSendPostEffect_AudioBusSendLevel_IsValid;

	private static FFieldAddress SetAudioBusSendPostEffect_AudioBusSendLevel_PropertyAddress;

	private static int SetAudioBusSendPostEffect_AudioBusSendLevel_Offset;

	private static bool PlayQuantized_IsValid;

	private static IntPtr PlayQuantized_FunctionAddress;

	private static int PlayQuantized_ParamsSize;

	private static bool PlayQuantized_WorldContextObject_IsValid;

	private static FFieldAddress PlayQuantized_WorldContextObject_PropertyAddress;

	private static int PlayQuantized_WorldContextObject_Offset;

	private static bool PlayQuantized_InClockHandle_IsValid;

	private static FFieldAddress PlayQuantized_InClockHandle_PropertyAddress;

	private static int PlayQuantized_InClockHandle_Offset;

	private static bool PlayQuantized_InQuantizationBoundary_IsValid;

	private static FFieldAddress PlayQuantized_InQuantizationBoundary_PropertyAddress;

	private static int PlayQuantized_InQuantizationBoundary_Offset;

	private static bool PlayQuantized_InDelegate_IsValid;

	private static FFieldAddress PlayQuantized_InDelegate_PropertyAddress;

	private static int PlayQuantized_InDelegate_Offset;

	private static bool PlayQuantized_InStartTime_IsValid;

	private static FFieldAddress PlayQuantized_InStartTime_PropertyAddress;

	private static int PlayQuantized_InStartTime_Offset;

	private static bool PlayQuantized_InFadeInDuration_IsValid;

	private static FFieldAddress PlayQuantized_InFadeInDuration_PropertyAddress;

	private static int PlayQuantized_InFadeInDuration_Offset;

	private static bool PlayQuantized_InFadeVolumeLevel_IsValid;

	private static FFieldAddress PlayQuantized_InFadeVolumeLevel_PropertyAddress;

	private static int PlayQuantized_InFadeVolumeLevel_Offset;

	private static bool PlayQuantized_InFadeCurve_IsValid;

	private static FFieldAddress PlayQuantized_InFadeCurve_PropertyAddress;

	private static int PlayQuantized_InFadeCurve_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Play_StartTime_IsValid;

	private static FFieldAddress Play_StartTime_PropertyAddress;

	private static int Play_StartTime_Offset;

	private static bool IsVirtualized_IsValid;

	private static IntPtr IsVirtualized_FunctionAddress;

	private static int IsVirtualized_ParamsSize;

	private static bool IsVirtualized_ReturnValue_IsValid;

	private static FFieldAddress IsVirtualized_ReturnValue_PropertyAddress;

	private static int IsVirtualized_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool HasCookedFFTData_IsValid;

	private static IntPtr HasCookedFFTData_FunctionAddress;

	private static int HasCookedFFTData_ParamsSize;

	private static bool HasCookedFFTData_ReturnValue_IsValid;

	private static FFieldAddress HasCookedFFTData_ReturnValue_PropertyAddress;

	private static int HasCookedFFTData_ReturnValue_Offset;

	private static bool HasCookedAmplitudeEnvelopeData_IsValid;

	private static IntPtr HasCookedAmplitudeEnvelopeData_FunctionAddress;

	private static int HasCookedAmplitudeEnvelopeData_ParamsSize;

	private static bool HasCookedAmplitudeEnvelopeData_ReturnValue_IsValid;

	private static FFieldAddress HasCookedAmplitudeEnvelopeData_ReturnValue_PropertyAddress;

	private static int HasCookedAmplitudeEnvelopeData_ReturnValue_Offset;

	private static bool GetPlayState_IsValid;

	private static IntPtr GetPlayState_FunctionAddress;

	private static int GetPlayState_ParamsSize;

	private static bool GetPlayState_ReturnValue_IsValid;

	private static FFieldAddress GetPlayState_ReturnValue_PropertyAddress;

	private static int GetPlayState_ReturnValue_Offset;

	private static bool GetCookedFFTDataForAllPlayingSounds_IsValid;

	private static IntPtr GetCookedFFTDataForAllPlayingSounds_FunctionAddress;

	private static int GetCookedFFTDataForAllPlayingSounds_ParamsSize;

	private static bool GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_IsValid;

	private static FFieldAddress GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_PropertyAddress;

	private static int GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_Offset;

	private static bool GetCookedFFTDataForAllPlayingSounds_ReturnValue_IsValid;

	private static FFieldAddress GetCookedFFTDataForAllPlayingSounds_ReturnValue_PropertyAddress;

	private static int GetCookedFFTDataForAllPlayingSounds_ReturnValue_Offset;

	private static bool GetCookedFFTData_IsValid;

	private static IntPtr GetCookedFFTData_FunctionAddress;

	private static int GetCookedFFTData_ParamsSize;

	private static bool GetCookedFFTData_FrequenciesToGet_IsValid;

	private static FFieldAddress GetCookedFFTData_FrequenciesToGet_PropertyAddress;

	private static int GetCookedFFTData_FrequenciesToGet_Offset;

	private static bool GetCookedFFTData_OutSoundWaveSpectralData_IsValid;

	private static FFieldAddress GetCookedFFTData_OutSoundWaveSpectralData_PropertyAddress;

	private static int GetCookedFFTData_OutSoundWaveSpectralData_Offset;

	private static bool GetCookedFFTData_ReturnValue_IsValid;

	private static FFieldAddress GetCookedFFTData_ReturnValue_PropertyAddress;

	private static int GetCookedFFTData_ReturnValue_Offset;

	private static bool GetCookedEnvelopeDataForAllPlayingSounds_IsValid;

	private static IntPtr GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress;

	private static int GetCookedEnvelopeDataForAllPlayingSounds_ParamsSize;

	private static bool GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_IsValid;

	private static FFieldAddress GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_PropertyAddress;

	private static int GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_Offset;

	private static bool GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_IsValid;

	private static FFieldAddress GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_PropertyAddress;

	private static int GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_Offset;

	private static bool GetCookedEnvelopeData_IsValid;

	private static IntPtr GetCookedEnvelopeData_FunctionAddress;

	private static int GetCookedEnvelopeData_ParamsSize;

	private static bool GetCookedEnvelopeData_OutEnvelopeData_IsValid;

	private static FFieldAddress GetCookedEnvelopeData_OutEnvelopeData_PropertyAddress;

	private static int GetCookedEnvelopeData_OutEnvelopeData_Offset;

	private static bool GetCookedEnvelopeData_ReturnValue_IsValid;

	private static FFieldAddress GetCookedEnvelopeData_ReturnValue_PropertyAddress;

	private static int GetCookedEnvelopeData_ReturnValue_Offset;

	private static bool FadeOut_IsValid;

	private static IntPtr FadeOut_FunctionAddress;

	private static int FadeOut_ParamsSize;

	private static bool FadeOut_FadeOutDuration_IsValid;

	private static FFieldAddress FadeOut_FadeOutDuration_PropertyAddress;

	private static int FadeOut_FadeOutDuration_Offset;

	private static bool FadeOut_FadeVolumeLevel_IsValid;

	private static FFieldAddress FadeOut_FadeVolumeLevel_PropertyAddress;

	private static int FadeOut_FadeVolumeLevel_Offset;

	private static bool FadeOut_FadeCurve_IsValid;

	private static FFieldAddress FadeOut_FadeCurve_PropertyAddress;

	private static int FadeOut_FadeCurve_Offset;

	private static bool FadeIn_IsValid;

	private static IntPtr FadeIn_FunctionAddress;

	private static int FadeIn_ParamsSize;

	private static bool FadeIn_FadeInDuration_IsValid;

	private static FFieldAddress FadeIn_FadeInDuration_PropertyAddress;

	private static int FadeIn_FadeInDuration_Offset;

	private static bool FadeIn_FadeVolumeLevel_IsValid;

	private static FFieldAddress FadeIn_FadeVolumeLevel_PropertyAddress;

	private static int FadeIn_FadeVolumeLevel_Offset;

	private static bool FadeIn_StartTime_IsValid;

	private static FFieldAddress FadeIn_StartTime_PropertyAddress;

	private static int FadeIn_StartTime_Offset;

	private static bool FadeIn_FadeCurve_IsValid;

	private static FFieldAddress FadeIn_FadeCurve_PropertyAddress;

	private static int FadeIn_FadeCurve_Offset;

	private static bool GetAttenuationSettingsToApply_IsValid;

	private static IntPtr GetAttenuationSettingsToApply_FunctionAddress;

	private static int GetAttenuationSettingsToApply_ParamsSize;

	private static bool GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress;

	private static int GetAttenuationSettingsToApply_OutAttenuationSettings_Offset;

	private static bool GetAttenuationSettingsToApply_ReturnValue_IsValid;

	private static FFieldAddress GetAttenuationSettingsToApply_ReturnValue_PropertyAddress;

	private static int GetAttenuationSettingsToApply_ReturnValue_Offset;

	private static bool AdjustVolume_IsValid;

	private static IntPtr AdjustVolume_FunctionAddress;

	private static int AdjustVolume_ParamsSize;

	private static bool AdjustVolume_AdjustVolumeDuration_IsValid;

	private static FFieldAddress AdjustVolume_AdjustVolumeDuration_PropertyAddress;

	private static int AdjustVolume_AdjustVolumeDuration_Offset;

	private static bool AdjustVolume_AdjustVolumeLevel_IsValid;

	private static FFieldAddress AdjustVolume_AdjustVolumeLevel_PropertyAddress;

	private static int AdjustVolume_AdjustVolumeLevel_Offset;

	private static bool AdjustVolume_FadeCurve_IsValid;

	private static FFieldAddress AdjustVolume_FadeCurve_PropertyAddress;

	private static int AdjustVolume_FadeCurve_Offset;

	private static bool AdjustAttenuation_IsValid;

	private static IntPtr AdjustAttenuation_FunctionAddress;

	private static int AdjustAttenuation_ParamsSize;

	private static bool AdjustAttenuation_InAttenuationSettings_IsValid;

	private static FFieldAddress AdjustAttenuation_InAttenuationSettings_PropertyAddress;

	private static int AdjustAttenuation_InAttenuationSettings_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AudioComponent:Sound")]
	public USoundBase Sound
	{
		get
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:Sound");
				return null;
			}
			return UObjectMarshaler<USoundBase>.FromNative(IntPtr.Add(base.Address, Sound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:Sound");
			}
			else
			{
				UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(base.Address, Sound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.AudioComponent:DefaultParameters")]
	public TArrayReadWrite<FAudioParameter> DefaultParameters
	{
		get
		{
			CheckDestroyed();
			if (!DefaultParameters_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:DefaultParameters");
				return null;
			}
			if (DefaultParameters_MarshalerCached == null)
			{
				DefaultParameters_MarshalerCached = new TArrayReadWriteMarshaler<FAudioParameter>(1, DefaultParameters_PropertyAddress, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.FromNative, CachedMarshalingDelegates<FAudioParameter, FAudioParameter>.ToNative);
			}
			return DefaultParameters_MarshalerCached.FromNative(IntPtr.Add(base.Address, DefaultParameters_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bAllowSpatialization")]
	public bool AllowSpatialization
	{
		get
		{
			CheckDestroyed();
			if (!AllowSpatialization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bAllowSpatialization");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowSpatialization_Offset), 0, AllowSpatialization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowSpatialization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bAllowSpatialization");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowSpatialization_Offset), 0, AllowSpatialization_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bOverrideAttenuation")]
	public bool OverrideAttenuation
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverrideAttenuation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverrideAttenuation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bOverrideSubtitlePriority")]
	public bool OverrideSubtitlePriority
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverrideSubtitlePriority");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideSubtitlePriority_Offset), 0, OverrideSubtitlePriority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverrideSubtitlePriority");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideSubtitlePriority_Offset), 0, OverrideSubtitlePriority_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bIsUISound")]
	public bool IsUISound
	{
		get
		{
			CheckDestroyed();
			if (!IsUISound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bIsUISound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUISound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bIsUISound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bEnableLowPassFilter")]
	public bool EnableLowPassFilter
	{
		get
		{
			CheckDestroyed();
			if (!EnableLowPassFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bEnableLowPassFilter");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLowPassFilter_Offset), 0, EnableLowPassFilter_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLowPassFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bEnableLowPassFilter");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLowPassFilter_Offset), 0, EnableLowPassFilter_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bOverridePriority")]
	public bool OverridePriority
	{
		get
		{
			CheckDestroyed();
			if (!OverridePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverridePriority");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverridePriority_Offset), 0, OverridePriority_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverridePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bOverridePriority");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverridePriority_Offset), 0, OverridePriority_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bSuppressSubtitles")]
	public bool SuppressSubtitles
	{
		get
		{
			CheckDestroyed();
			if (!SuppressSubtitles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bSuppressSubtitles");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SuppressSubtitles_Offset), 0, SuppressSubtitles_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SuppressSubtitles_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bSuppressSubtitles");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SuppressSubtitles_Offset), 0, SuppressSubtitles_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bCanPlayMultipleInstances")]
	public bool CanPlayMultipleInstances
	{
		get
		{
			CheckDestroyed();
			if (!CanPlayMultipleInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bCanPlayMultipleInstances");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanPlayMultipleInstances_Offset), 0, CanPlayMultipleInstances_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanPlayMultipleInstances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bCanPlayMultipleInstances");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanPlayMultipleInstances_Offset), 0, CanPlayMultipleInstances_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bDisableParameterUpdatesWhilePlaying")]
	public bool DisableParameterUpdatesWhilePlaying
	{
		get
		{
			CheckDestroyed();
			if (!DisableParameterUpdatesWhilePlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bDisableParameterUpdatesWhilePlaying");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableParameterUpdatesWhilePlaying_Offset), 0, DisableParameterUpdatesWhilePlaying_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableParameterUpdatesWhilePlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bDisableParameterUpdatesWhilePlaying");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableParameterUpdatesWhilePlaying_Offset), 0, DisableParameterUpdatesWhilePlaying_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.AudioComponent:bAutoManageAttachment")]
	public bool AutoManageAttachment
	{
		get
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bAutoManageAttachment");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoManageAttachment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:bAutoManageAttachment");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoManageAttachment_Offset), 0, AutoManageAttachment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:PitchModulationMin")]
	public float PitchModulationMin
	{
		get
		{
			CheckDestroyed();
			if (!PitchModulationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchModulationMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchModulationMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchModulationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchModulationMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchModulationMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:PitchModulationMax")]
	public float PitchModulationMax
	{
		get
		{
			CheckDestroyed();
			if (!PitchModulationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchModulationMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchModulationMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchModulationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchModulationMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchModulationMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:VolumeModulationMin")]
	public float VolumeModulationMin
	{
		get
		{
			CheckDestroyed();
			if (!VolumeModulationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeModulationMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumeModulationMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeModulationMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeModulationMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumeModulationMin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:VolumeModulationMax")]
	public float VolumeModulationMax
	{
		get
		{
			CheckDestroyed();
			if (!VolumeModulationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeModulationMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumeModulationMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeModulationMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeModulationMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumeModulationMax_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:VolumeMultiplier")]
	public float VolumeMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:VolumeMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:EnvelopeFollowerAttackTime")]
	public int EnvelopeFollowerAttackTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:EnvelopeFollowerAttackTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:EnvelopeFollowerAttackTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:EnvelopeFollowerReleaseTime")]
	public int EnvelopeFollowerReleaseTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:EnvelopeFollowerReleaseTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:EnvelopeFollowerReleaseTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:SubtitlePriority")]
	public float SubtitlePriority
	{
		get
		{
			CheckDestroyed();
			if (!SubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:SubtitlePriority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SubtitlePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubtitlePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:SubtitlePriority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SubtitlePriority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AudioComponent:SourceEffectChain")]
	public USoundEffectSourcePresetChain SourceEffectChain
	{
		get
		{
			CheckDestroyed();
			if (!SourceEffectChain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:SourceEffectChain");
				return null;
			}
			return UObjectMarshaler<USoundEffectSourcePresetChain>.FromNative(IntPtr.Add(base.Address, SourceEffectChain_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceEffectChain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:SourceEffectChain");
			}
			else
			{
				UObjectMarshaler<USoundEffectSourcePresetChain>.ToNative(IntPtr.Add(base.Address, SourceEffectChain_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:PitchMultiplier")]
	public float PitchMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:PitchMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:LowPassFilterFrequency")]
	public float LowPassFilterFrequency
	{
		get
		{
			CheckDestroyed();
			if (!LowPassFilterFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:LowPassFilterFrequency");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LowPassFilterFrequency_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowPassFilterFrequency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:LowPassFilterFrequency");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LowPassFilterFrequency_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AttenuationSettings")]
	public USoundAttenuation AttenuationSettings
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AttenuationSettings");
				return null;
			}
			return UObjectMarshaler<USoundAttenuation>.FromNative(IntPtr.Add(base.Address, AttenuationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AttenuationSettings");
			}
			else
			{
				UObjectMarshaler<USoundAttenuation>.ToNative(IntPtr.Add(base.Address, AttenuationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AttenuationOverrides")]
	public FSoundAttenuationSettings AttenuationOverrides
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AttenuationOverrides");
				return default(FSoundAttenuationSettings);
			}
			return FSoundAttenuationSettings.FromNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AttenuationOverrides");
			}
			else
			{
				FSoundAttenuationSettings.ToNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213125uL)]
	[UMetaPath("/Script/Engine.AudioComponent:ConcurrencySet")]
	public TSetReadWrite<USoundConcurrency> ConcurrencySet
	{
		get
		{
			CheckDestroyed();
			if (!ConcurrencySet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:ConcurrencySet");
				return null;
			}
			if (ConcurrencySet_MarshalerCached == null)
			{
				ConcurrencySet_MarshalerCached = new TSetReadWriteMarshaler<USoundConcurrency>(1, ConcurrencySet_PropertyAddress, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.FromNative, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.ToNative);
			}
			return ConcurrencySet_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConcurrencySet_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AutoAttachLocationRule")]
	public EAttachmentRule AutoAttachLocationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachLocationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachLocationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachLocationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachLocationRule_Offset), 0, AutoAttachLocationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AutoAttachRotationRule")]
	public EAttachmentRule AutoAttachRotationRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachRotationRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachRotationRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachRotationRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachRotationRule_Offset), 0, AutoAttachRotationRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AutoAttachScaleRule")]
	public EAttachmentRule AutoAttachScaleRule
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachScaleRule");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachScaleRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachScaleRule");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AutoAttachScaleRule_Offset), 0, AutoAttachScaleRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.AudioComponent:ModulationRouting")]
	public FSoundModulationDefaultRoutingSettings ModulationRouting
	{
		get
		{
			CheckDestroyed();
			if (!ModulationRouting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:ModulationRouting");
				return default(FSoundModulationDefaultRoutingSettings);
			}
			return FSoundModulationDefaultRoutingSettings.FromNative(IntPtr.Add(base.Address, ModulationRouting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModulationRouting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:ModulationRouting");
			}
			else
			{
				FSoundModulationDefaultRoutingSettings.ToNative(IntPtr.Add(base.Address, ModulationRouting_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioPlayStateChanged")]
	public FOnAudioPlayStateChanged OnAudioPlayStateChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioPlayStateChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioPlayStateChanged");
				return new FOnAudioPlayStateChanged();
			}
			if (OnAudioPlayStateChanged_DelegateCached == null)
			{
				OnAudioPlayStateChanged_DelegateCached = new FOnAudioPlayStateChanged();
				OnAudioPlayStateChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioPlayStateChanged_Offset));
			}
			return OnAudioPlayStateChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioVirtualizationChanged")]
	public FOnAudioVirtualizationChanged OnAudioVirtualizationChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioVirtualizationChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioVirtualizationChanged");
				return new FOnAudioVirtualizationChanged();
			}
			if (OnAudioVirtualizationChanged_DelegateCached == null)
			{
				OnAudioVirtualizationChanged_DelegateCached = new FOnAudioVirtualizationChanged();
				OnAudioVirtualizationChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioVirtualizationChanged_Offset));
			}
			return OnAudioVirtualizationChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioFinished")]
	public FOnAudioFinished OnAudioFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioFinished");
				return new FOnAudioFinished();
			}
			if (OnAudioFinished_DelegateCached == null)
			{
				OnAudioFinished_DelegateCached = new FOnAudioFinished();
				OnAudioFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioFinished_Offset));
			}
			return OnAudioFinished_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioPlaybackPercent")]
	public FOnAudioPlaybackPercent OnAudioPlaybackPercent
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioPlaybackPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioPlaybackPercent");
				return new FOnAudioPlaybackPercent();
			}
			if (OnAudioPlaybackPercent_DelegateCached == null)
			{
				OnAudioPlaybackPercent_DelegateCached = new FOnAudioPlaybackPercent();
				OnAudioPlaybackPercent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioPlaybackPercent_Offset));
			}
			return OnAudioPlaybackPercent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioSingleEnvelopeValue")]
	public FOnAudioSingleEnvelopeValue OnAudioSingleEnvelopeValue
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioSingleEnvelopeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioSingleEnvelopeValue");
				return new FOnAudioSingleEnvelopeValue();
			}
			if (OnAudioSingleEnvelopeValue_DelegateCached == null)
			{
				OnAudioSingleEnvelopeValue_DelegateCached = new FOnAudioSingleEnvelopeValue();
				OnAudioSingleEnvelopeValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioSingleEnvelopeValue_Offset));
			}
			return OnAudioSingleEnvelopeValue_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.AudioComponent:OnAudioMultiEnvelopeValue")]
	public FOnAudioMultiEnvelopeValue OnAudioMultiEnvelopeValue
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioMultiEnvelopeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:OnAudioMultiEnvelopeValue");
				return new FOnAudioMultiEnvelopeValue();
			}
			if (OnAudioMultiEnvelopeValue_DelegateCached == null)
			{
				OnAudioMultiEnvelopeValue_DelegateCached = new FOnAudioMultiEnvelopeValue();
				OnAudioMultiEnvelopeValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioMultiEnvelopeValue_Offset));
			}
			return OnAudioMultiEnvelopeValue_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)7881369141774861uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AutoAttachParent")]
	public TWeakObject<USceneComponent> AutoAttachParent
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachParent");
				return default(TWeakObject<USceneComponent>);
			}
			return TWeakObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, AutoAttachParent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachParent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachParent");
			}
			else
			{
				TWeakObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, AutoAttachParent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.AudioComponent:AutoAttachSocketName")]
	public FName AutoAttachSocketName
	{
		get
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoAttachSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AudioComponent:AutoAttachSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AutoAttachSocketName_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:StopDelayed")]
	public unsafe void StopDelayed(float DelayTime)
	{
		CheckDestroyed();
		if (!StopDelayed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:StopDelayed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopDelayed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopDelayed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StopDelayed_DelayTime_Offset), 0, StopDelayed_DelayTime_PropertyAddress.Address, DelayTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopDelayed_FunctionAddress, intPtr, StopDelayed_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetWaveParameter")]
	public unsafe void SetWaveParameter(FName InName, USoundWave InWave)
	{
		CheckDestroyed();
		if (!SetWaveParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetWaveParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaveParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaveParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetWaveParameter_InName_Offset), 0, SetWaveParameter_InName_PropertyAddress.Address, InName);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, SetWaveParameter_InWave_Offset), 0, SetWaveParameter_InWave_PropertyAddress.Address, InWave);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaveParameter_FunctionAddress, intPtr, SetWaveParameter_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetVolumeMultiplier")]
	public unsafe void SetVolumeMultiplier(float NewVolumeMultiplier)
	{
		CheckDestroyed();
		if (!SetVolumeMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetVolumeMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumeMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumeMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumeMultiplier_NewVolumeMultiplier_Offset), 0, SetVolumeMultiplier_NewVolumeMultiplier_PropertyAddress.Address, NewVolumeMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumeMultiplier_FunctionAddress, intPtr, SetVolumeMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetUISound")]
	public unsafe void SetUISound(bool bInUISound)
	{
		CheckDestroyed();
		if (!SetUISound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetUISound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUISound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUISound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUISound_bInUISound_Offset), 0, SetUISound_bInUISound_PropertyAddress.Address, bInUISound);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUISound_FunctionAddress, intPtr, SetUISound_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetSubmixSend")]
	public unsafe void SetSubmixSend(USoundSubmixBase Submix, float SendLevel)
	{
		CheckDestroyed();
		if (!SetSubmixSend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetSubmixSend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixSend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixSend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundSubmixBase>.ToNative(IntPtr.Add(intPtr, SetSubmixSend_Submix_Offset), 0, SetSubmixSend_Submix_PropertyAddress.Address, Submix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSubmixSend_SendLevel_Offset), 0, SetSubmixSend_SendLevel_PropertyAddress.Address, SendLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixSend_FunctionAddress, intPtr, SetSubmixSend_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetSourceBusSendPreEffect")]
	public unsafe void SetSourceBusSendPreEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
	{
		CheckDestroyed();
		if (!SetSourceBusSendPreEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetSourceBusSendPreEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceBusSendPreEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceBusSendPreEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundSourceBus>.ToNative(IntPtr.Add(intPtr, SetSourceBusSendPreEffect_SoundSourceBus_Offset), 0, SetSourceBusSendPreEffect_SoundSourceBus_PropertyAddress.Address, SoundSourceBus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceBusSendPreEffect_SourceBusSendLevel_Offset), 0, SetSourceBusSendPreEffect_SourceBusSendLevel_PropertyAddress.Address, SourceBusSendLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceBusSendPreEffect_FunctionAddress, intPtr, SetSourceBusSendPreEffect_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetSourceBusSendPostEffect")]
	public unsafe void SetSourceBusSendPostEffect(USoundSourceBus SoundSourceBus, float SourceBusSendLevel)
	{
		CheckDestroyed();
		if (!SetSourceBusSendPostEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetSourceBusSendPostEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceBusSendPostEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceBusSendPostEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundSourceBus>.ToNative(IntPtr.Add(intPtr, SetSourceBusSendPostEffect_SoundSourceBus_Offset), 0, SetSourceBusSendPostEffect_SoundSourceBus_PropertyAddress.Address, SoundSourceBus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSourceBusSendPostEffect_SourceBusSendLevel_Offset), 0, SetSourceBusSendPostEffect_SourceBusSendLevel_PropertyAddress.Address, SourceBusSendLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceBusSendPostEffect_FunctionAddress, intPtr, SetSourceBusSendPostEffect_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetSound")]
	public unsafe void SetSound(USoundBase NewSound)
	{
		CheckDestroyed();
		if (!SetSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetSound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(intPtr, SetSound_NewSound_Offset), 0, SetSound_NewSound_PropertyAddress.Address, NewSound);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSound_FunctionAddress, intPtr, SetSound_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetPitchMultiplier")]
	public unsafe void SetPitchMultiplier(float NewPitchMultiplier)
	{
		CheckDestroyed();
		if (!SetPitchMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetPitchMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPitchMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPitchMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPitchMultiplier_NewPitchMultiplier_Offset), 0, SetPitchMultiplier_NewPitchMultiplier_PropertyAddress.Address, NewPitchMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPitchMultiplier_FunctionAddress, intPtr, SetPitchMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetPaused")]
	public unsafe void SetPaused(bool bPause)
	{
		CheckDestroyed();
		if (!SetPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPaused_bPause_Offset), 0, SetPaused_bPause_PropertyAddress.Address, bPause);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPaused_FunctionAddress, intPtr, SetPaused_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetOutputToBusOnly")]
	public unsafe void SetOutputToBusOnly(bool bInOutputToBusOnly)
	{
		CheckDestroyed();
		if (!SetOutputToBusOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetOutputToBusOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOutputToBusOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOutputToBusOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOutputToBusOnly_bInOutputToBusOnly_Offset), 0, SetOutputToBusOnly_bInOutputToBusOnly_PropertyAddress.Address, bInOutputToBusOnly);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOutputToBusOnly_FunctionAddress, intPtr, SetOutputToBusOnly_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetLowPassFilterFrequency")]
	public unsafe void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
	{
		CheckDestroyed();
		if (!SetLowPassFilterFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetLowPassFilterFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLowPassFilterFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLowPassFilterFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLowPassFilterFrequency_InLowPassFilterFrequency_Offset), 0, SetLowPassFilterFrequency_InLowPassFilterFrequency_PropertyAddress.Address, InLowPassFilterFrequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLowPassFilterFrequency_FunctionAddress, intPtr, SetLowPassFilterFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetLowPassFilterEnabled")]
	public unsafe void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
	{
		CheckDestroyed();
		if (!SetLowPassFilterEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetLowPassFilterEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLowPassFilterEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLowPassFilterEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLowPassFilterEnabled_InLowPassFilterEnabled_Offset), 0, SetLowPassFilterEnabled_InLowPassFilterEnabled_PropertyAddress.Address, InLowPassFilterEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLowPassFilterEnabled_FunctionAddress, intPtr, SetLowPassFilterEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetIntParameter")]
	public unsafe void SetIntParameter_7B56EE80(FName InName, int InInt)
	{
		CheckDestroyed();
		if (!SetIntParameter_7B56EE80_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetIntParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntParameter_7B56EE80_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntParameter_7B56EE80_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetIntParameter_7B56EE80_InName_Offset), 0, SetIntParameter_7B56EE80_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetIntParameter_7B56EE80_InInt_Offset), 0, SetIntParameter_7B56EE80_InInt_PropertyAddress.Address, InInt);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntParameter_7B56EE80_FunctionAddress, intPtr, SetIntParameter_7B56EE80_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetFloatParameter")]
	public unsafe void SetFloatParameter_A140E9DF(FName InName, float InFloat)
	{
		CheckDestroyed();
		if (!SetFloatParameter_A140E9DF_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetFloatParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloatParameter_A140E9DF_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloatParameter_A140E9DF_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_A140E9DF_InName_Offset), 0, SetFloatParameter_A140E9DF_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloatParameter_A140E9DF_InFloat_Offset), 0, SetFloatParameter_A140E9DF_InFloat_PropertyAddress.Address, InFloat);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloatParameter_A140E9DF_FunctionAddress, intPtr, SetFloatParameter_A140E9DF_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetBoolParameter")]
	public unsafe void SetBoolParameter_2CA8F371(FName InName, bool InBool)
	{
		CheckDestroyed();
		if (!SetBoolParameter_2CA8F371_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetBoolParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoolParameter_2CA8F371_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoolParameter_2CA8F371_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBoolParameter_2CA8F371_InName_Offset), 0, SetBoolParameter_2CA8F371_InName_PropertyAddress.Address, InName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoolParameter_2CA8F371_InBool_Offset), 0, SetBoolParameter_2CA8F371_InBool_PropertyAddress.Address, InBool);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoolParameter_2CA8F371_FunctionAddress, intPtr, SetBoolParameter_2CA8F371_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetAudioBusSendPreEffect")]
	public unsafe void SetAudioBusSendPreEffect(UAudioBus AudioBus, float AudioBusSendLevel)
	{
		CheckDestroyed();
		if (!SetAudioBusSendPreEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetAudioBusSendPreEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioBusSendPreEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioBusSendPreEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, SetAudioBusSendPreEffect_AudioBus_Offset), 0, SetAudioBusSendPreEffect_AudioBus_PropertyAddress.Address, AudioBus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAudioBusSendPreEffect_AudioBusSendLevel_Offset), 0, SetAudioBusSendPreEffect_AudioBusSendLevel_PropertyAddress.Address, AudioBusSendLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioBusSendPreEffect_FunctionAddress, intPtr, SetAudioBusSendPreEffect_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:SetAudioBusSendPostEffect")]
	public unsafe void SetAudioBusSendPostEffect(UAudioBus AudioBus, float AudioBusSendLevel)
	{
		CheckDestroyed();
		if (!SetAudioBusSendPostEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:SetAudioBusSendPostEffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAudioBusSendPostEffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAudioBusSendPostEffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, SetAudioBusSendPostEffect_AudioBus_Offset), 0, SetAudioBusSendPostEffect_AudioBus_PropertyAddress.Address, AudioBus);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAudioBusSendPostEffect_AudioBusSendLevel_Offset), 0, SetAudioBusSendPostEffect_AudioBusSendLevel_PropertyAddress.Address, AudioBusSendLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAudioBusSendPostEffect_FunctionAddress, intPtr, SetAudioBusSendPostEffect_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.AudioComponent:PlayQuantized")]
	public unsafe void PlayQuantized(UObject WorldContextObject, ref UQuartzClockHandle InClockHandle, ref FQuartzQuantizationBoundary InQuantizationBoundary, FOnQuartzCommandEventBP InDelegate, float InStartTime = 0f, float InFadeInDuration = 0f, float InFadeVolumeLevel = 1f, EAudioFaderCurve InFadeCurve = EAudioFaderCurve.Linear)
	{
		CheckDestroyed();
		if (!PlayQuantized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:PlayQuantized");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayQuantized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayQuantized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PlayQuantized_WorldContextObject_Offset), 0, PlayQuantized_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UQuartzClockHandle>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InClockHandle_Offset), 0, PlayQuantized_InClockHandle_PropertyAddress.Address, InClockHandle);
		NativeReflection.InitializeValue_InContainer(PlayQuantized_InQuantizationBoundary_PropertyAddress.Address, intPtr);
		FQuartzQuantizationBoundary.ToNative(IntPtr.Add(intPtr, PlayQuantized_InQuantizationBoundary_Offset), 0, PlayQuantized_InQuantizationBoundary_PropertyAddress.Address, InQuantizationBoundary);
		FDelegateMarshaler<FOnQuartzCommandEventBP>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InDelegate_Offset), 0, PlayQuantized_InDelegate_PropertyAddress.Address, InDelegate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InStartTime_Offset), 0, PlayQuantized_InStartTime_PropertyAddress.Address, InStartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InFadeInDuration_Offset), 0, PlayQuantized_InFadeInDuration_PropertyAddress.Address, InFadeInDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InFadeVolumeLevel_Offset), 0, PlayQuantized_InFadeVolumeLevel_PropertyAddress.Address, InFadeVolumeLevel);
		EnumMarshaler<EAudioFaderCurve>.ToNative(IntPtr.Add(intPtr, PlayQuantized_InFadeCurve_Offset), 0, PlayQuantized_InFadeCurve_PropertyAddress.Address, InFadeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayQuantized_FunctionAddress, intPtr, PlayQuantized_ParamsSize);
		InClockHandle = UObjectMarshaler<UQuartzClockHandle>.FromNative(IntPtr.Add(intPtr, PlayQuantized_InClockHandle_Offset), 0, PlayQuantized_InClockHandle_PropertyAddress.Address);
		InQuantizationBoundary = FQuartzQuantizationBoundary.FromNative(IntPtr.Add(intPtr, PlayQuantized_InQuantizationBoundary_Offset), 0, PlayQuantized_InQuantizationBoundary_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PlayQuantized_InQuantizationBoundary_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:Play")]
	public unsafe void Play(float StartTime = 0f)
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Play_StartTime_Offset), 0, Play_StartTime_PropertyAddress.Address, StartTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Play_FunctionAddress, intPtr, Play_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AudioComponent:IsVirtualized")]
	public unsafe bool IsVirtualized()
	{
		CheckDestroyed();
		if (!IsVirtualized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:IsVirtualized");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVirtualized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVirtualized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVirtualized_FunctionAddress, intPtr, IsVirtualized_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVirtualized_ReturnValue_Offset), 0, IsVirtualized_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.AudioComponent:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:IsPlaying");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlaying_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlaying_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPlaying_FunctionAddress, intPtr, IsPlaying_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlaying_ReturnValue_Offset), 0, IsPlaying_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AudioComponent:HasCookedFFTData")]
	public unsafe bool HasCookedFFTData()
	{
		CheckDestroyed();
		if (!HasCookedFFTData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:HasCookedFFTData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCookedFFTData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCookedFFTData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasCookedFFTData_FunctionAddress, intPtr, HasCookedFFTData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCookedFFTData_ReturnValue_Offset), 0, HasCookedFFTData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AudioComponent:HasCookedAmplitudeEnvelopeData")]
	public unsafe bool HasCookedAmplitudeEnvelopeData()
	{
		CheckDestroyed();
		if (!HasCookedAmplitudeEnvelopeData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:HasCookedAmplitudeEnvelopeData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasCookedAmplitudeEnvelopeData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasCookedAmplitudeEnvelopeData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasCookedAmplitudeEnvelopeData_FunctionAddress, intPtr, HasCookedAmplitudeEnvelopeData_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasCookedAmplitudeEnvelopeData_ReturnValue_Offset), 0, HasCookedAmplitudeEnvelopeData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.AudioComponent:GetPlayState")]
	public unsafe EAudioComponentPlayState GetPlayState()
	{
		CheckDestroyed();
		if (!GetPlayState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:GetPlayState");
			return EAudioComponentPlayState.Playing;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayState_FunctionAddress, intPtr, GetPlayState_ParamsSize);
		return EnumMarshaler<EAudioComponentPlayState>.FromNative(IntPtr.Add(intPtr, GetPlayState_ReturnValue_Offset), 0, GetPlayState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioComponent:GetCookedFFTDataForAllPlayingSounds")]
	public unsafe bool GetCookedFFTDataForAllPlayingSounds(out List<FSoundWaveSpectralDataPerSound> OutSoundWaveSpectralData)
	{
		CheckDestroyed();
		if (!GetCookedFFTDataForAllPlayingSounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:GetCookedFFTDataForAllPlayingSounds");
			OutSoundWaveSpectralData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCookedFFTDataForAllPlayingSounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCookedFFTDataForAllPlayingSounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCookedFFTDataForAllPlayingSounds_FunctionAddress, intPtr, GetCookedFFTDataForAllPlayingSounds_ParamsSize);
		OutSoundWaveSpectralData = new TArrayCopyMarshaler<FSoundWaveSpectralDataPerSound>(1, GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_PropertyAddress, CachedMarshalingDelegates<FSoundWaveSpectralDataPerSound, FSoundWaveSpectralDataPerSound>.FromNative, CachedMarshalingDelegates<FSoundWaveSpectralDataPerSound, FSoundWaveSpectralDataPerSound>.ToNative).FromNative(IntPtr.Add(intPtr, GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_Offset));
		NativeReflection.DestroyValue_InContainer(GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCookedFFTDataForAllPlayingSounds_ReturnValue_Offset), 0, GetCookedFFTDataForAllPlayingSounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioComponent:GetCookedFFTData")]
	public unsafe bool GetCookedFFTData(List<float> FrequenciesToGet, out List<FSoundWaveSpectralData> OutSoundWaveSpectralData)
	{
		CheckDestroyed();
		if (!GetCookedFFTData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:GetCookedFFTData");
			OutSoundWaveSpectralData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCookedFFTData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCookedFFTData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<float>(1, GetCookedFFTData_FrequenciesToGet_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, GetCookedFFTData_FrequenciesToGet_Offset), FrequenciesToGet);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCookedFFTData_FunctionAddress, intPtr, GetCookedFFTData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetCookedFFTData_FrequenciesToGet_PropertyAddress.Address, intPtr);
		OutSoundWaveSpectralData = new TArrayCopyMarshaler<FSoundWaveSpectralData>(1, GetCookedFFTData_OutSoundWaveSpectralData_PropertyAddress, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.FromNative, CachedMarshalingDelegates<FSoundWaveSpectralData, FSoundWaveSpectralData>.ToNative).FromNative(IntPtr.Add(intPtr, GetCookedFFTData_OutSoundWaveSpectralData_Offset));
		NativeReflection.DestroyValue_InContainer(GetCookedFFTData_OutSoundWaveSpectralData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCookedFFTData_ReturnValue_Offset), 0, GetCookedFFTData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioComponent:GetCookedEnvelopeDataForAllPlayingSounds")]
	public unsafe bool GetCookedEnvelopeDataForAllPlayingSounds(out List<FSoundWaveEnvelopeDataPerSound> OutEnvelopeData)
	{
		CheckDestroyed();
		if (!GetCookedEnvelopeDataForAllPlayingSounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:GetCookedEnvelopeDataForAllPlayingSounds");
			OutEnvelopeData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCookedEnvelopeDataForAllPlayingSounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCookedEnvelopeDataForAllPlayingSounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, intPtr, GetCookedEnvelopeDataForAllPlayingSounds_ParamsSize);
		OutEnvelopeData = new TArrayCopyMarshaler<FSoundWaveEnvelopeDataPerSound>(1, GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_PropertyAddress, CachedMarshalingDelegates<FSoundWaveEnvelopeDataPerSound, FSoundWaveEnvelopeDataPerSound>.FromNative, CachedMarshalingDelegates<FSoundWaveEnvelopeDataPerSound, FSoundWaveEnvelopeDataPerSound>.ToNative).FromNative(IntPtr.Add(intPtr, GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_Offset));
		NativeReflection.DestroyValue_InContainer(GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_Offset), 0, GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioComponent:GetCookedEnvelopeData")]
	public unsafe bool GetCookedEnvelopeData(out float OutEnvelopeData)
	{
		CheckDestroyed();
		if (!GetCookedEnvelopeData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:GetCookedEnvelopeData");
			OutEnvelopeData = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCookedEnvelopeData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCookedEnvelopeData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCookedEnvelopeData_FunctionAddress, intPtr, GetCookedEnvelopeData_ParamsSize);
		OutEnvelopeData = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCookedEnvelopeData_OutEnvelopeData_Offset), 0, GetCookedEnvelopeData_OutEnvelopeData_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCookedEnvelopeData_ReturnValue_Offset), 0, GetCookedEnvelopeData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:FadeOut")]
	public unsafe void FadeOut(float FadeOutDuration, float FadeVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
	{
		CheckDestroyed();
		if (!FadeOut_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:FadeOut");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FadeOut_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FadeOut_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FadeOut_FadeOutDuration_Offset), 0, FadeOut_FadeOutDuration_PropertyAddress.Address, FadeOutDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FadeOut_FadeVolumeLevel_Offset), 0, FadeOut_FadeVolumeLevel_PropertyAddress.Address, FadeVolumeLevel);
		EnumMarshaler<EAudioFaderCurve>.ToNative(IntPtr.Add(intPtr, FadeOut_FadeCurve_Offset), 0, FadeOut_FadeCurve_PropertyAddress.Address, FadeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, FadeOut_FunctionAddress, intPtr, FadeOut_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.AudioComponent:FadeIn")]
	public unsafe void FadeIn(float FadeInDuration, float FadeVolumeLevel = 1f, float StartTime = 0f, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
	{
		CheckDestroyed();
		if (!FadeIn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:FadeIn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FadeIn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FadeIn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FadeIn_FadeInDuration_Offset), 0, FadeIn_FadeInDuration_PropertyAddress.Address, FadeInDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FadeIn_FadeVolumeLevel_Offset), 0, FadeIn_FadeVolumeLevel_PropertyAddress.Address, FadeVolumeLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FadeIn_StartTime_Offset), 0, FadeIn_StartTime_PropertyAddress.Address, StartTime);
		EnumMarshaler<EAudioFaderCurve>.ToNative(IntPtr.Add(intPtr, FadeIn_FadeCurve_Offset), 0, FadeIn_FadeCurve_PropertyAddress.Address, FadeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, FadeIn_FunctionAddress, intPtr, FadeIn_ParamsSize);
	}

	[UFunction(Flags = 71435265u, OriginalName = "BP_GetAttenuationSettingsToApply")]
	[UMetaPath("/Script/Engine.AudioComponent:BP_GetAttenuationSettingsToApply")]
	public unsafe bool GetAttenuationSettingsToApply(out FSoundAttenuationSettings OutAttenuationSettings)
	{
		CheckDestroyed();
		if (!GetAttenuationSettingsToApply_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:BP_GetAttenuationSettingsToApply");
			OutAttenuationSettings = default(FSoundAttenuationSettings);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAttenuationSettingsToApply_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAttenuationSettingsToApply_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAttenuationSettingsToApply_FunctionAddress, intPtr, GetAttenuationSettingsToApply_ParamsSize);
		OutAttenuationSettings = FSoundAttenuationSettings.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_OutAttenuationSettings_Offset), 0, GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAttenuationSettingsToApply_ReturnValue_Offset), 0, GetAttenuationSettingsToApply_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.AudioComponent:AdjustVolume")]
	public unsafe void AdjustVolume(float AdjustVolumeDuration, float AdjustVolumeLevel, EAudioFaderCurve FadeCurve = EAudioFaderCurve.Linear)
	{
		CheckDestroyed();
		if (!AdjustVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:AdjustVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdjustVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdjustVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdjustVolume_AdjustVolumeDuration_Offset), 0, AdjustVolume_AdjustVolumeDuration_PropertyAddress.Address, AdjustVolumeDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AdjustVolume_AdjustVolumeLevel_Offset), 0, AdjustVolume_AdjustVolumeLevel_PropertyAddress.Address, AdjustVolumeLevel);
		EnumMarshaler<EAudioFaderCurve>.ToNative(IntPtr.Add(intPtr, AdjustVolume_FadeCurve_Offset), 0, AdjustVolume_FadeCurve_PropertyAddress.Address, FadeCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, AdjustVolume_FunctionAddress, intPtr, AdjustVolume_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.AudioComponent:AdjustAttenuation")]
	public unsafe void AdjustAttenuation(FSoundAttenuationSettings InAttenuationSettings)
	{
		CheckDestroyed();
		if (!AdjustAttenuation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.AudioComponent:AdjustAttenuation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AdjustAttenuation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AdjustAttenuation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, intPtr);
		FSoundAttenuationSettings.ToNative(IntPtr.Add(intPtr, AdjustAttenuation_InAttenuationSettings_Offset), 0, AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, InAttenuationSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, AdjustAttenuation_FunctionAddress, intPtr, AdjustAttenuation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AdjustAttenuation_InAttenuationSettings_PropertyAddress.Address, intPtr);
	}

	static UAudioComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.AudioComponent");
		Sound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Sound");
		Sound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Sound", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DefaultParameters_PropertyAddress, intPtr, "DefaultParameters");
		DefaultParameters_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultParameters");
		DefaultParameters_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultParameters", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSpatialization_PropertyAddress, intPtr, "bAllowSpatialization");
		AllowSpatialization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSpatialization");
		AllowSpatialization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSpatialization", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideAttenuation_PropertyAddress, intPtr, "bOverrideAttenuation");
		OverrideAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideAttenuation");
		OverrideAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideAttenuation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideSubtitlePriority_PropertyAddress, intPtr, "bOverrideSubtitlePriority");
		OverrideSubtitlePriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideSubtitlePriority");
		OverrideSubtitlePriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideSubtitlePriority", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUISound_PropertyAddress, intPtr, "bIsUISound");
		IsUISound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsUISound");
		IsUISound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsUISound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLowPassFilter_PropertyAddress, intPtr, "bEnableLowPassFilter");
		EnableLowPassFilter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableLowPassFilter");
		EnableLowPassFilter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableLowPassFilter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePriority_PropertyAddress, intPtr, "bOverridePriority");
		OverridePriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverridePriority");
		OverridePriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverridePriority", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SuppressSubtitles_PropertyAddress, intPtr, "bSuppressSubtitles");
		SuppressSubtitles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSuppressSubtitles");
		SuppressSubtitles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSuppressSubtitles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanPlayMultipleInstances_PropertyAddress, intPtr, "bCanPlayMultipleInstances");
		CanPlayMultipleInstances_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanPlayMultipleInstances");
		CanPlayMultipleInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanPlayMultipleInstances", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableParameterUpdatesWhilePlaying_PropertyAddress, intPtr, "bDisableParameterUpdatesWhilePlaying");
		DisableParameterUpdatesWhilePlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableParameterUpdatesWhilePlaying");
		DisableParameterUpdatesWhilePlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableParameterUpdatesWhilePlaying", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoManageAttachment_PropertyAddress, intPtr, "bAutoManageAttachment");
		AutoManageAttachment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoManageAttachment");
		AutoManageAttachment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoManageAttachment", Classes.FBoolProperty);
		PitchModulationMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchModulationMin");
		PitchModulationMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchModulationMin", Classes.FFloatProperty);
		PitchModulationMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchModulationMax");
		PitchModulationMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchModulationMax", Classes.FFloatProperty);
		VolumeModulationMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeModulationMin");
		VolumeModulationMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeModulationMin", Classes.FFloatProperty);
		VolumeModulationMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeModulationMax");
		VolumeModulationMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeModulationMax", Classes.FFloatProperty);
		VolumeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumeMultiplier");
		VolumeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumeMultiplier", Classes.FFloatProperty);
		EnvelopeFollowerAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerAttackTime");
		EnvelopeFollowerAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerAttackTime", Classes.FIntProperty);
		EnvelopeFollowerReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerReleaseTime");
		EnvelopeFollowerReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerReleaseTime", Classes.FIntProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FFloatProperty);
		SubtitlePriority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubtitlePriority");
		SubtitlePriority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubtitlePriority", Classes.FFloatProperty);
		SourceEffectChain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceEffectChain");
		SourceEffectChain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceEffectChain", Classes.FObjectProperty);
		PitchMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PitchMultiplier");
		PitchMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PitchMultiplier", Classes.FFloatProperty);
		LowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowPassFilterFrequency");
		LowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowPassFilterFrequency", Classes.FFloatProperty);
		AttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationSettings");
		AttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationSettings", Classes.FObjectProperty);
		AttenuationOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationOverrides");
		AttenuationOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationOverrides", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConcurrencySet_PropertyAddress, intPtr, "ConcurrencySet");
		ConcurrencySet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConcurrencySet");
		ConcurrencySet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConcurrencySet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachLocationRule_PropertyAddress, intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachLocationRule");
		AutoAttachLocationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachLocationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachRotationRule_PropertyAddress, intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachRotationRule");
		AutoAttachRotationRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachRotationRule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoAttachScaleRule_PropertyAddress, intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachScaleRule");
		AutoAttachScaleRule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachScaleRule", Classes.FEnumProperty);
		ModulationRouting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationRouting");
		ModulationRouting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationRouting", Classes.FStructProperty);
		OnAudioPlayStateChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioPlayStateChanged");
		OnAudioPlayStateChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioPlayStateChanged", Classes.FMulticastDelegateProperty);
		OnAudioVirtualizationChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioVirtualizationChanged");
		OnAudioVirtualizationChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioVirtualizationChanged", Classes.FMulticastDelegateProperty);
		OnAudioFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioFinished");
		OnAudioFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioFinished", Classes.FMulticastDelegateProperty);
		OnAudioPlaybackPercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioPlaybackPercent");
		OnAudioPlaybackPercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioPlaybackPercent", Classes.FMulticastDelegateProperty);
		OnAudioSingleEnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioSingleEnvelopeValue");
		OnAudioSingleEnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioSingleEnvelopeValue", Classes.FMulticastDelegateProperty);
		OnAudioMultiEnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioMultiEnvelopeValue");
		OnAudioMultiEnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioMultiEnvelopeValue", Classes.FMulticastDelegateProperty);
		AutoAttachParent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachParent");
		AutoAttachParent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachParent", Classes.FWeakObjectProperty);
		AutoAttachSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoAttachSocketName");
		AutoAttachSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoAttachSocketName", Classes.FNameProperty);
		StopDelayed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopDelayed");
		StopDelayed_ParamsSize = NativeReflection.GetFunctionParamsSize(StopDelayed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopDelayed_DelayTime_PropertyAddress, StopDelayed_FunctionAddress, "DelayTime");
		StopDelayed_DelayTime_Offset = NativeReflectionCached.GetPropertyOffset(StopDelayed_FunctionAddress, "DelayTime");
		StopDelayed_DelayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(StopDelayed_FunctionAddress, "DelayTime", Classes.FFloatProperty);
		StopDelayed_IsValid = StopDelayed_FunctionAddress != IntPtr.Zero && StopDelayed_DelayTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:StopDelayed", StopDelayed_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:Stop", Stop_IsValid);
		SetWaveParameter_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaveParameter");
		SetWaveParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaveParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaveParameter_InName_PropertyAddress, SetWaveParameter_FunctionAddress, "InName");
		SetWaveParameter_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveParameter_FunctionAddress, "InName");
		SetWaveParameter_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveParameter_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaveParameter_InWave_PropertyAddress, SetWaveParameter_FunctionAddress, "InWave");
		SetWaveParameter_InWave_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveParameter_FunctionAddress, "InWave");
		SetWaveParameter_InWave_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveParameter_FunctionAddress, "InWave", Classes.FObjectProperty);
		SetWaveParameter_IsValid = SetWaveParameter_FunctionAddress != IntPtr.Zero && SetWaveParameter_InName_IsValid && SetWaveParameter_InWave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetWaveParameter", SetWaveParameter_IsValid);
		SetVolumeMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumeMultiplier");
		SetVolumeMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumeMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumeMultiplier_NewVolumeMultiplier_PropertyAddress, SetVolumeMultiplier_FunctionAddress, "NewVolumeMultiplier");
		SetVolumeMultiplier_NewVolumeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumeMultiplier_FunctionAddress, "NewVolumeMultiplier");
		SetVolumeMultiplier_NewVolumeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumeMultiplier_FunctionAddress, "NewVolumeMultiplier", Classes.FFloatProperty);
		SetVolumeMultiplier_IsValid = SetVolumeMultiplier_FunctionAddress != IntPtr.Zero && SetVolumeMultiplier_NewVolumeMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetVolumeMultiplier", SetVolumeMultiplier_IsValid);
		SetUISound_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUISound");
		SetUISound_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUISound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUISound_bInUISound_PropertyAddress, SetUISound_FunctionAddress, "bInUISound");
		SetUISound_bInUISound_Offset = NativeReflectionCached.GetPropertyOffset(SetUISound_FunctionAddress, "bInUISound");
		SetUISound_bInUISound_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUISound_FunctionAddress, "bInUISound", Classes.FBoolProperty);
		SetUISound_IsValid = SetUISound_FunctionAddress != IntPtr.Zero && SetUISound_bInUISound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetUISound", SetUISound_IsValid);
		SetSubmixSend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixSend");
		SetSubmixSend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixSend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixSend_Submix_PropertyAddress, SetSubmixSend_FunctionAddress, "Submix");
		SetSubmixSend_Submix_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixSend_FunctionAddress, "Submix");
		SetSubmixSend_Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixSend_FunctionAddress, "Submix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixSend_SendLevel_PropertyAddress, SetSubmixSend_FunctionAddress, "SendLevel");
		SetSubmixSend_SendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixSend_FunctionAddress, "SendLevel");
		SetSubmixSend_SendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixSend_FunctionAddress, "SendLevel", Classes.FFloatProperty);
		SetSubmixSend_IsValid = SetSubmixSend_FunctionAddress != IntPtr.Zero && SetSubmixSend_Submix_IsValid && SetSubmixSend_SendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetSubmixSend", SetSubmixSend_IsValid);
		SetSourceBusSendPreEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceBusSendPreEffect");
		SetSourceBusSendPreEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceBusSendPreEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBusSendPreEffect_SoundSourceBus_PropertyAddress, SetSourceBusSendPreEffect_FunctionAddress, "SoundSourceBus");
		SetSourceBusSendPreEffect_SoundSourceBus_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBusSendPreEffect_FunctionAddress, "SoundSourceBus");
		SetSourceBusSendPreEffect_SoundSourceBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBusSendPreEffect_FunctionAddress, "SoundSourceBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBusSendPreEffect_SourceBusSendLevel_PropertyAddress, SetSourceBusSendPreEffect_FunctionAddress, "SourceBusSendLevel");
		SetSourceBusSendPreEffect_SourceBusSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBusSendPreEffect_FunctionAddress, "SourceBusSendLevel");
		SetSourceBusSendPreEffect_SourceBusSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBusSendPreEffect_FunctionAddress, "SourceBusSendLevel", Classes.FFloatProperty);
		SetSourceBusSendPreEffect_IsValid = SetSourceBusSendPreEffect_FunctionAddress != IntPtr.Zero && SetSourceBusSendPreEffect_SoundSourceBus_IsValid && SetSourceBusSendPreEffect_SourceBusSendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetSourceBusSendPreEffect", SetSourceBusSendPreEffect_IsValid);
		SetSourceBusSendPostEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceBusSendPostEffect");
		SetSourceBusSendPostEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceBusSendPostEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBusSendPostEffect_SoundSourceBus_PropertyAddress, SetSourceBusSendPostEffect_FunctionAddress, "SoundSourceBus");
		SetSourceBusSendPostEffect_SoundSourceBus_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBusSendPostEffect_FunctionAddress, "SoundSourceBus");
		SetSourceBusSendPostEffect_SoundSourceBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBusSendPostEffect_FunctionAddress, "SoundSourceBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBusSendPostEffect_SourceBusSendLevel_PropertyAddress, SetSourceBusSendPostEffect_FunctionAddress, "SourceBusSendLevel");
		SetSourceBusSendPostEffect_SourceBusSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBusSendPostEffect_FunctionAddress, "SourceBusSendLevel");
		SetSourceBusSendPostEffect_SourceBusSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBusSendPostEffect_FunctionAddress, "SourceBusSendLevel", Classes.FFloatProperty);
		SetSourceBusSendPostEffect_IsValid = SetSourceBusSendPostEffect_FunctionAddress != IntPtr.Zero && SetSourceBusSendPostEffect_SoundSourceBus_IsValid && SetSourceBusSendPostEffect_SourceBusSendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetSourceBusSendPostEffect", SetSourceBusSendPostEffect_IsValid);
		SetSound_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSound");
		SetSound_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSound_NewSound_PropertyAddress, SetSound_FunctionAddress, "NewSound");
		SetSound_NewSound_Offset = NativeReflectionCached.GetPropertyOffset(SetSound_FunctionAddress, "NewSound");
		SetSound_NewSound_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSound_FunctionAddress, "NewSound", Classes.FObjectProperty);
		SetSound_IsValid = SetSound_FunctionAddress != IntPtr.Zero && SetSound_NewSound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetSound", SetSound_IsValid);
		SetPitchMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPitchMultiplier");
		SetPitchMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPitchMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPitchMultiplier_NewPitchMultiplier_PropertyAddress, SetPitchMultiplier_FunctionAddress, "NewPitchMultiplier");
		SetPitchMultiplier_NewPitchMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetPitchMultiplier_FunctionAddress, "NewPitchMultiplier");
		SetPitchMultiplier_NewPitchMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPitchMultiplier_FunctionAddress, "NewPitchMultiplier", Classes.FFloatProperty);
		SetPitchMultiplier_IsValid = SetPitchMultiplier_FunctionAddress != IntPtr.Zero && SetPitchMultiplier_NewPitchMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetPitchMultiplier", SetPitchMultiplier_IsValid);
		SetPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPaused");
		SetPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPaused_bPause_PropertyAddress, SetPaused_FunctionAddress, "bPause");
		SetPaused_bPause_Offset = NativeReflectionCached.GetPropertyOffset(SetPaused_FunctionAddress, "bPause");
		SetPaused_bPause_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPaused_FunctionAddress, "bPause", Classes.FBoolProperty);
		SetPaused_IsValid = SetPaused_FunctionAddress != IntPtr.Zero && SetPaused_bPause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetPaused", SetPaused_IsValid);
		SetOutputToBusOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOutputToBusOnly");
		SetOutputToBusOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputToBusOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputToBusOnly_bInOutputToBusOnly_PropertyAddress, SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly");
		SetOutputToBusOnly_bInOutputToBusOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly");
		SetOutputToBusOnly_bInOutputToBusOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly", Classes.FBoolProperty);
		SetOutputToBusOnly_IsValid = SetOutputToBusOnly_FunctionAddress != IntPtr.Zero && SetOutputToBusOnly_bInOutputToBusOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetOutputToBusOnly", SetOutputToBusOnly_IsValid);
		SetLowPassFilterFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowPassFilterFrequency");
		SetLowPassFilterFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowPassFilterFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowPassFilterFrequency_InLowPassFilterFrequency_PropertyAddress, SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency");
		SetLowPassFilterFrequency_InLowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency");
		SetLowPassFilterFrequency_InLowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency", Classes.FFloatProperty);
		SetLowPassFilterFrequency_IsValid = SetLowPassFilterFrequency_FunctionAddress != IntPtr.Zero && SetLowPassFilterFrequency_InLowPassFilterFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetLowPassFilterFrequency", SetLowPassFilterFrequency_IsValid);
		SetLowPassFilterEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowPassFilterEnabled");
		SetLowPassFilterEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowPassFilterEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowPassFilterEnabled_InLowPassFilterEnabled_PropertyAddress, SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled");
		SetLowPassFilterEnabled_InLowPassFilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled");
		SetLowPassFilterEnabled_InLowPassFilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled", Classes.FBoolProperty);
		SetLowPassFilterEnabled_IsValid = SetLowPassFilterEnabled_FunctionAddress != IntPtr.Zero && SetLowPassFilterEnabled_InLowPassFilterEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetLowPassFilterEnabled", SetLowPassFilterEnabled_IsValid);
		SetIntParameter_7B56EE80_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntParameter");
		SetIntParameter_7B56EE80_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntParameter_7B56EE80_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_7B56EE80_InName_PropertyAddress, SetIntParameter_7B56EE80_FunctionAddress, "InName");
		SetIntParameter_7B56EE80_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_7B56EE80_FunctionAddress, "InName");
		SetIntParameter_7B56EE80_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_7B56EE80_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIntParameter_7B56EE80_InInt_PropertyAddress, SetIntParameter_7B56EE80_FunctionAddress, "InInt");
		SetIntParameter_7B56EE80_InInt_Offset = NativeReflectionCached.GetPropertyOffset(SetIntParameter_7B56EE80_FunctionAddress, "InInt");
		SetIntParameter_7B56EE80_InInt_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntParameter_7B56EE80_FunctionAddress, "InInt", Classes.FIntProperty);
		SetIntParameter_7B56EE80_IsValid = SetIntParameter_7B56EE80_FunctionAddress != IntPtr.Zero && SetIntParameter_7B56EE80_InName_IsValid && SetIntParameter_7B56EE80_InInt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetIntParameter", SetIntParameter_7B56EE80_IsValid);
		SetFloatParameter_A140E9DF_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFloatParameter");
		SetFloatParameter_A140E9DF_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloatParameter_A140E9DF_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_A140E9DF_InName_PropertyAddress, SetFloatParameter_A140E9DF_FunctionAddress, "InName");
		SetFloatParameter_A140E9DF_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_A140E9DF_FunctionAddress, "InName");
		SetFloatParameter_A140E9DF_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_A140E9DF_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFloatParameter_A140E9DF_InFloat_PropertyAddress, SetFloatParameter_A140E9DF_FunctionAddress, "InFloat");
		SetFloatParameter_A140E9DF_InFloat_Offset = NativeReflectionCached.GetPropertyOffset(SetFloatParameter_A140E9DF_FunctionAddress, "InFloat");
		SetFloatParameter_A140E9DF_InFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloatParameter_A140E9DF_FunctionAddress, "InFloat", Classes.FFloatProperty);
		SetFloatParameter_A140E9DF_IsValid = SetFloatParameter_A140E9DF_FunctionAddress != IntPtr.Zero && SetFloatParameter_A140E9DF_InName_IsValid && SetFloatParameter_A140E9DF_InFloat_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetFloatParameter", SetFloatParameter_A140E9DF_IsValid);
		SetBoolParameter_2CA8F371_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBoolParameter");
		SetBoolParameter_2CA8F371_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoolParameter_2CA8F371_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_2CA8F371_InName_PropertyAddress, SetBoolParameter_2CA8F371_FunctionAddress, "InName");
		SetBoolParameter_2CA8F371_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_2CA8F371_FunctionAddress, "InName");
		SetBoolParameter_2CA8F371_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_2CA8F371_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoolParameter_2CA8F371_InBool_PropertyAddress, SetBoolParameter_2CA8F371_FunctionAddress, "InBool");
		SetBoolParameter_2CA8F371_InBool_Offset = NativeReflectionCached.GetPropertyOffset(SetBoolParameter_2CA8F371_FunctionAddress, "InBool");
		SetBoolParameter_2CA8F371_InBool_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoolParameter_2CA8F371_FunctionAddress, "InBool", Classes.FBoolProperty);
		SetBoolParameter_2CA8F371_IsValid = SetBoolParameter_2CA8F371_FunctionAddress != IntPtr.Zero && SetBoolParameter_2CA8F371_InName_IsValid && SetBoolParameter_2CA8F371_InBool_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetBoolParameter", SetBoolParameter_2CA8F371_IsValid);
		SetAudioBusSendPreEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioBusSendPreEffect");
		SetAudioBusSendPreEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioBusSendPreEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBusSendPreEffect_AudioBus_PropertyAddress, SetAudioBusSendPreEffect_FunctionAddress, "AudioBus");
		SetAudioBusSendPreEffect_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBusSendPreEffect_FunctionAddress, "AudioBus");
		SetAudioBusSendPreEffect_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBusSendPreEffect_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBusSendPreEffect_AudioBusSendLevel_PropertyAddress, SetAudioBusSendPreEffect_FunctionAddress, "AudioBusSendLevel");
		SetAudioBusSendPreEffect_AudioBusSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBusSendPreEffect_FunctionAddress, "AudioBusSendLevel");
		SetAudioBusSendPreEffect_AudioBusSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBusSendPreEffect_FunctionAddress, "AudioBusSendLevel", Classes.FFloatProperty);
		SetAudioBusSendPreEffect_IsValid = SetAudioBusSendPreEffect_FunctionAddress != IntPtr.Zero && SetAudioBusSendPreEffect_AudioBus_IsValid && SetAudioBusSendPreEffect_AudioBusSendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetAudioBusSendPreEffect", SetAudioBusSendPreEffect_IsValid);
		SetAudioBusSendPostEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAudioBusSendPostEffect");
		SetAudioBusSendPostEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAudioBusSendPostEffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBusSendPostEffect_AudioBus_PropertyAddress, SetAudioBusSendPostEffect_FunctionAddress, "AudioBus");
		SetAudioBusSendPostEffect_AudioBus_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBusSendPostEffect_FunctionAddress, "AudioBus");
		SetAudioBusSendPostEffect_AudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBusSendPostEffect_FunctionAddress, "AudioBus", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAudioBusSendPostEffect_AudioBusSendLevel_PropertyAddress, SetAudioBusSendPostEffect_FunctionAddress, "AudioBusSendLevel");
		SetAudioBusSendPostEffect_AudioBusSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetAudioBusSendPostEffect_FunctionAddress, "AudioBusSendLevel");
		SetAudioBusSendPostEffect_AudioBusSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAudioBusSendPostEffect_FunctionAddress, "AudioBusSendLevel", Classes.FFloatProperty);
		SetAudioBusSendPostEffect_IsValid = SetAudioBusSendPostEffect_FunctionAddress != IntPtr.Zero && SetAudioBusSendPostEffect_AudioBus_IsValid && SetAudioBusSendPostEffect_AudioBusSendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:SetAudioBusSendPostEffect", SetAudioBusSendPostEffect_IsValid);
		PlayQuantized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayQuantized");
		PlayQuantized_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayQuantized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_WorldContextObject_PropertyAddress, PlayQuantized_FunctionAddress, "WorldContextObject");
		PlayQuantized_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "WorldContextObject");
		PlayQuantized_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InClockHandle_PropertyAddress, PlayQuantized_FunctionAddress, "InClockHandle");
		PlayQuantized_InClockHandle_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InClockHandle");
		PlayQuantized_InClockHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InClockHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InQuantizationBoundary_PropertyAddress, PlayQuantized_FunctionAddress, "InQuantizationBoundary");
		PlayQuantized_InQuantizationBoundary_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InQuantizationBoundary");
		PlayQuantized_InQuantizationBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InQuantizationBoundary", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InDelegate_PropertyAddress, PlayQuantized_FunctionAddress, "InDelegate");
		PlayQuantized_InDelegate_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InDelegate");
		PlayQuantized_InDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InDelegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InStartTime_PropertyAddress, PlayQuantized_FunctionAddress, "InStartTime");
		PlayQuantized_InStartTime_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InStartTime");
		PlayQuantized_InStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InStartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InFadeInDuration_PropertyAddress, PlayQuantized_FunctionAddress, "InFadeInDuration");
		PlayQuantized_InFadeInDuration_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InFadeInDuration");
		PlayQuantized_InFadeInDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InFadeInDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InFadeVolumeLevel_PropertyAddress, PlayQuantized_FunctionAddress, "InFadeVolumeLevel");
		PlayQuantized_InFadeVolumeLevel_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InFadeVolumeLevel");
		PlayQuantized_InFadeVolumeLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InFadeVolumeLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayQuantized_InFadeCurve_PropertyAddress, PlayQuantized_FunctionAddress, "InFadeCurve");
		PlayQuantized_InFadeCurve_Offset = NativeReflectionCached.GetPropertyOffset(PlayQuantized_FunctionAddress, "InFadeCurve");
		PlayQuantized_InFadeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayQuantized_FunctionAddress, "InFadeCurve", Classes.FEnumProperty);
		PlayQuantized_IsValid = PlayQuantized_FunctionAddress != IntPtr.Zero && PlayQuantized_WorldContextObject_IsValid && PlayQuantized_InClockHandle_IsValid && PlayQuantized_InQuantizationBoundary_IsValid && PlayQuantized_InDelegate_IsValid && PlayQuantized_InStartTime_IsValid && PlayQuantized_InFadeInDuration_IsValid && PlayQuantized_InFadeVolumeLevel_IsValid && PlayQuantized_InFadeCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:PlayQuantized", PlayQuantized_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Play_StartTime_PropertyAddress, Play_FunctionAddress, "StartTime");
		Play_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(Play_FunctionAddress, "StartTime");
		Play_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Play_FunctionAddress, "StartTime", Classes.FFloatProperty);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero && Play_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:Play", Play_IsValid);
		IsVirtualized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsVirtualized");
		IsVirtualized_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVirtualized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVirtualized_ReturnValue_PropertyAddress, IsVirtualized_FunctionAddress, "ReturnValue");
		IsVirtualized_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVirtualized_FunctionAddress, "ReturnValue");
		IsVirtualized_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVirtualized_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVirtualized_IsValid = IsVirtualized_FunctionAddress != IntPtr.Zero && IsVirtualized_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:IsVirtualized", IsVirtualized_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:IsPlaying", IsPlaying_IsValid);
		HasCookedFFTData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasCookedFFTData");
		HasCookedFFTData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCookedFFTData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCookedFFTData_ReturnValue_PropertyAddress, HasCookedFFTData_FunctionAddress, "ReturnValue");
		HasCookedFFTData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCookedFFTData_FunctionAddress, "ReturnValue");
		HasCookedFFTData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCookedFFTData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCookedFFTData_IsValid = HasCookedFFTData_FunctionAddress != IntPtr.Zero && HasCookedFFTData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:HasCookedFFTData", HasCookedFFTData_IsValid);
		HasCookedAmplitudeEnvelopeData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasCookedAmplitudeEnvelopeData");
		HasCookedAmplitudeEnvelopeData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasCookedAmplitudeEnvelopeData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasCookedAmplitudeEnvelopeData_ReturnValue_PropertyAddress, HasCookedAmplitudeEnvelopeData_FunctionAddress, "ReturnValue");
		HasCookedAmplitudeEnvelopeData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasCookedAmplitudeEnvelopeData_FunctionAddress, "ReturnValue");
		HasCookedAmplitudeEnvelopeData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasCookedAmplitudeEnvelopeData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasCookedAmplitudeEnvelopeData_IsValid = HasCookedAmplitudeEnvelopeData_FunctionAddress != IntPtr.Zero && HasCookedAmplitudeEnvelopeData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:HasCookedAmplitudeEnvelopeData", HasCookedAmplitudeEnvelopeData_IsValid);
		GetPlayState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayState");
		GetPlayState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayState_ReturnValue_PropertyAddress, GetPlayState_FunctionAddress, "ReturnValue");
		GetPlayState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayState_FunctionAddress, "ReturnValue");
		GetPlayState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPlayState_IsValid = GetPlayState_FunctionAddress != IntPtr.Zero && GetPlayState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:GetPlayState", GetPlayState_IsValid);
		GetCookedFFTDataForAllPlayingSounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCookedFFTDataForAllPlayingSounds");
		GetCookedFFTDataForAllPlayingSounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCookedFFTDataForAllPlayingSounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_PropertyAddress, GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "OutSoundWaveSpectralData");
		GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "OutSoundWaveSpectralData");
		GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "OutSoundWaveSpectralData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookedFFTDataForAllPlayingSounds_ReturnValue_PropertyAddress, GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "ReturnValue");
		GetCookedFFTDataForAllPlayingSounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "ReturnValue");
		GetCookedFFTDataForAllPlayingSounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedFFTDataForAllPlayingSounds_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCookedFFTDataForAllPlayingSounds_IsValid = GetCookedFFTDataForAllPlayingSounds_FunctionAddress != IntPtr.Zero && GetCookedFFTDataForAllPlayingSounds_OutSoundWaveSpectralData_IsValid && GetCookedFFTDataForAllPlayingSounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:GetCookedFFTDataForAllPlayingSounds", GetCookedFFTDataForAllPlayingSounds_IsValid);
		GetCookedFFTData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCookedFFTData");
		GetCookedFFTData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCookedFFTData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCookedFFTData_FrequenciesToGet_PropertyAddress, GetCookedFFTData_FunctionAddress, "FrequenciesToGet");
		GetCookedFFTData_FrequenciesToGet_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedFFTData_FunctionAddress, "FrequenciesToGet");
		GetCookedFFTData_FrequenciesToGet_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedFFTData_FunctionAddress, "FrequenciesToGet", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookedFFTData_OutSoundWaveSpectralData_PropertyAddress, GetCookedFFTData_FunctionAddress, "OutSoundWaveSpectralData");
		GetCookedFFTData_OutSoundWaveSpectralData_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedFFTData_FunctionAddress, "OutSoundWaveSpectralData");
		GetCookedFFTData_OutSoundWaveSpectralData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedFFTData_FunctionAddress, "OutSoundWaveSpectralData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookedFFTData_ReturnValue_PropertyAddress, GetCookedFFTData_FunctionAddress, "ReturnValue");
		GetCookedFFTData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedFFTData_FunctionAddress, "ReturnValue");
		GetCookedFFTData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedFFTData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCookedFFTData_IsValid = GetCookedFFTData_FunctionAddress != IntPtr.Zero && GetCookedFFTData_FrequenciesToGet_IsValid && GetCookedFFTData_OutSoundWaveSpectralData_IsValid && GetCookedFFTData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:GetCookedFFTData", GetCookedFFTData_IsValid);
		GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCookedEnvelopeDataForAllPlayingSounds");
		GetCookedEnvelopeDataForAllPlayingSounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_PropertyAddress, GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "OutEnvelopeData");
		GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "OutEnvelopeData");
		GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "OutEnvelopeData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_PropertyAddress, GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "ReturnValue");
		GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "ReturnValue");
		GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCookedEnvelopeDataForAllPlayingSounds_IsValid = GetCookedEnvelopeDataForAllPlayingSounds_FunctionAddress != IntPtr.Zero && GetCookedEnvelopeDataForAllPlayingSounds_OutEnvelopeData_IsValid && GetCookedEnvelopeDataForAllPlayingSounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:GetCookedEnvelopeDataForAllPlayingSounds", GetCookedEnvelopeDataForAllPlayingSounds_IsValid);
		GetCookedEnvelopeData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCookedEnvelopeData");
		GetCookedEnvelopeData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCookedEnvelopeData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCookedEnvelopeData_OutEnvelopeData_PropertyAddress, GetCookedEnvelopeData_FunctionAddress, "OutEnvelopeData");
		GetCookedEnvelopeData_OutEnvelopeData_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedEnvelopeData_FunctionAddress, "OutEnvelopeData");
		GetCookedEnvelopeData_OutEnvelopeData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedEnvelopeData_FunctionAddress, "OutEnvelopeData", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCookedEnvelopeData_ReturnValue_PropertyAddress, GetCookedEnvelopeData_FunctionAddress, "ReturnValue");
		GetCookedEnvelopeData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCookedEnvelopeData_FunctionAddress, "ReturnValue");
		GetCookedEnvelopeData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCookedEnvelopeData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCookedEnvelopeData_IsValid = GetCookedEnvelopeData_FunctionAddress != IntPtr.Zero && GetCookedEnvelopeData_OutEnvelopeData_IsValid && GetCookedEnvelopeData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:GetCookedEnvelopeData", GetCookedEnvelopeData_IsValid);
		FadeOut_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FadeOut");
		FadeOut_ParamsSize = NativeReflection.GetFunctionParamsSize(FadeOut_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FadeOut_FadeOutDuration_PropertyAddress, FadeOut_FunctionAddress, "FadeOutDuration");
		FadeOut_FadeOutDuration_Offset = NativeReflectionCached.GetPropertyOffset(FadeOut_FunctionAddress, "FadeOutDuration");
		FadeOut_FadeOutDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeOut_FunctionAddress, "FadeOutDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FadeOut_FadeVolumeLevel_PropertyAddress, FadeOut_FunctionAddress, "FadeVolumeLevel");
		FadeOut_FadeVolumeLevel_Offset = NativeReflectionCached.GetPropertyOffset(FadeOut_FunctionAddress, "FadeVolumeLevel");
		FadeOut_FadeVolumeLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeOut_FunctionAddress, "FadeVolumeLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FadeOut_FadeCurve_PropertyAddress, FadeOut_FunctionAddress, "FadeCurve");
		FadeOut_FadeCurve_Offset = NativeReflectionCached.GetPropertyOffset(FadeOut_FunctionAddress, "FadeCurve");
		FadeOut_FadeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeOut_FunctionAddress, "FadeCurve", Classes.FEnumProperty);
		FadeOut_IsValid = FadeOut_FunctionAddress != IntPtr.Zero && FadeOut_FadeOutDuration_IsValid && FadeOut_FadeVolumeLevel_IsValid && FadeOut_FadeCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:FadeOut", FadeOut_IsValid);
		FadeIn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FadeIn");
		FadeIn_ParamsSize = NativeReflection.GetFunctionParamsSize(FadeIn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FadeIn_FadeInDuration_PropertyAddress, FadeIn_FunctionAddress, "FadeInDuration");
		FadeIn_FadeInDuration_Offset = NativeReflectionCached.GetPropertyOffset(FadeIn_FunctionAddress, "FadeInDuration");
		FadeIn_FadeInDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeIn_FunctionAddress, "FadeInDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FadeIn_FadeVolumeLevel_PropertyAddress, FadeIn_FunctionAddress, "FadeVolumeLevel");
		FadeIn_FadeVolumeLevel_Offset = NativeReflectionCached.GetPropertyOffset(FadeIn_FunctionAddress, "FadeVolumeLevel");
		FadeIn_FadeVolumeLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeIn_FunctionAddress, "FadeVolumeLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FadeIn_StartTime_PropertyAddress, FadeIn_FunctionAddress, "StartTime");
		FadeIn_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(FadeIn_FunctionAddress, "StartTime");
		FadeIn_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeIn_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FadeIn_FadeCurve_PropertyAddress, FadeIn_FunctionAddress, "FadeCurve");
		FadeIn_FadeCurve_Offset = NativeReflectionCached.GetPropertyOffset(FadeIn_FunctionAddress, "FadeCurve");
		FadeIn_FadeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(FadeIn_FunctionAddress, "FadeCurve", Classes.FEnumProperty);
		FadeIn_IsValid = FadeIn_FunctionAddress != IntPtr.Zero && FadeIn_FadeInDuration_IsValid && FadeIn_FadeVolumeLevel_IsValid && FadeIn_StartTime_IsValid && FadeIn_FadeCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:FadeIn", FadeIn_IsValid);
		GetAttenuationSettingsToApply_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetAttenuationSettingsToApply");
		GetAttenuationSettingsToApply_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttenuationSettingsToApply_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_OutAttenuationSettings_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings");
		GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "OutAttenuationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAttenuationSettingsToApply_ReturnValue_PropertyAddress, GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue");
		GetAttenuationSettingsToApply_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAttenuationSettingsToApply_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAttenuationSettingsToApply_IsValid = GetAttenuationSettingsToApply_FunctionAddress != IntPtr.Zero && GetAttenuationSettingsToApply_OutAttenuationSettings_IsValid && GetAttenuationSettingsToApply_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:BP_GetAttenuationSettingsToApply", GetAttenuationSettingsToApply_IsValid);
		AdjustVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AdjustVolume");
		AdjustVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(AdjustVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdjustVolume_AdjustVolumeDuration_PropertyAddress, AdjustVolume_FunctionAddress, "AdjustVolumeDuration");
		AdjustVolume_AdjustVolumeDuration_Offset = NativeReflectionCached.GetPropertyOffset(AdjustVolume_FunctionAddress, "AdjustVolumeDuration");
		AdjustVolume_AdjustVolumeDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustVolume_FunctionAddress, "AdjustVolumeDuration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdjustVolume_AdjustVolumeLevel_PropertyAddress, AdjustVolume_FunctionAddress, "AdjustVolumeLevel");
		AdjustVolume_AdjustVolumeLevel_Offset = NativeReflectionCached.GetPropertyOffset(AdjustVolume_FunctionAddress, "AdjustVolumeLevel");
		AdjustVolume_AdjustVolumeLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustVolume_FunctionAddress, "AdjustVolumeLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AdjustVolume_FadeCurve_PropertyAddress, AdjustVolume_FunctionAddress, "FadeCurve");
		AdjustVolume_FadeCurve_Offset = NativeReflectionCached.GetPropertyOffset(AdjustVolume_FunctionAddress, "FadeCurve");
		AdjustVolume_FadeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustVolume_FunctionAddress, "FadeCurve", Classes.FEnumProperty);
		AdjustVolume_IsValid = AdjustVolume_FunctionAddress != IntPtr.Zero && AdjustVolume_AdjustVolumeDuration_IsValid && AdjustVolume_AdjustVolumeLevel_IsValid && AdjustVolume_FadeCurve_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:AdjustVolume", AdjustVolume_IsValid);
		AdjustAttenuation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AdjustAttenuation");
		AdjustAttenuation_ParamsSize = NativeReflection.GetFunctionParamsSize(AdjustAttenuation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AdjustAttenuation_InAttenuationSettings_PropertyAddress, AdjustAttenuation_FunctionAddress, "InAttenuationSettings");
		AdjustAttenuation_InAttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(AdjustAttenuation_FunctionAddress, "InAttenuationSettings");
		AdjustAttenuation_InAttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AdjustAttenuation_FunctionAddress, "InAttenuationSettings", Classes.FStructProperty);
		AdjustAttenuation_IsValid = AdjustAttenuation_FunctionAddress != IntPtr.Zero && AdjustAttenuation_InAttenuationSettings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.AudioComponent:AdjustAttenuation", AdjustAttenuation_IsValid);
	}
}
