using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ModularSynthComponent", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UModularSynthComponent : USynthComponent
{
	private static bool VoiceCount_IsValid;

	private static int VoiceCount_Offset;

	private static bool SetSynthPreset_IsValid;

	private static IntPtr SetSynthPreset_FunctionAddress;

	private static int SetSynthPreset_ParamsSize;

	private static bool SetSynthPreset_SynthPreset_IsValid;

	private static FFieldAddress SetSynthPreset_SynthPreset_PropertyAddress;

	private static int SetSynthPreset_SynthPreset_Offset;

	private static bool SetSustainGain_IsValid;

	private static IntPtr SetSustainGain_FunctionAddress;

	private static int SetSustainGain_ParamsSize;

	private static bool SetSustainGain_SustainGain_IsValid;

	private static FFieldAddress SetSustainGain_SustainGain_PropertyAddress;

	private static int SetSustainGain_SustainGain_Offset;

	private static bool SetStereoDelayWetlevel_IsValid;

	private static IntPtr SetStereoDelayWetlevel_FunctionAddress;

	private static int SetStereoDelayWetlevel_ParamsSize;

	private static bool SetStereoDelayWetlevel_DelayWetlevel_IsValid;

	private static FFieldAddress SetStereoDelayWetlevel_DelayWetlevel_PropertyAddress;

	private static int SetStereoDelayWetlevel_DelayWetlevel_Offset;

	private static bool SetStereoDelayTime_IsValid;

	private static IntPtr SetStereoDelayTime_FunctionAddress;

	private static int SetStereoDelayTime_ParamsSize;

	private static bool SetStereoDelayTime_DelayTimeMsec_IsValid;

	private static FFieldAddress SetStereoDelayTime_DelayTimeMsec_PropertyAddress;

	private static int SetStereoDelayTime_DelayTimeMsec_Offset;

	private static bool SetStereoDelayRatio_IsValid;

	private static IntPtr SetStereoDelayRatio_FunctionAddress;

	private static int SetStereoDelayRatio_ParamsSize;

	private static bool SetStereoDelayRatio_DelayRatio_IsValid;

	private static FFieldAddress SetStereoDelayRatio_DelayRatio_PropertyAddress;

	private static int SetStereoDelayRatio_DelayRatio_Offset;

	private static bool SetStereoDelayMode_IsValid;

	private static IntPtr SetStereoDelayMode_FunctionAddress;

	private static int SetStereoDelayMode_ParamsSize;

	private static bool SetStereoDelayMode_StereoDelayMode_IsValid;

	private static FFieldAddress SetStereoDelayMode_StereoDelayMode_PropertyAddress;

	private static int SetStereoDelayMode_StereoDelayMode_Offset;

	private static bool SetStereoDelayIsEnabled_IsValid;

	private static IntPtr SetStereoDelayIsEnabled_FunctionAddress;

	private static int SetStereoDelayIsEnabled_ParamsSize;

	private static bool SetStereoDelayIsEnabled_StereoDelayEnabled_IsValid;

	private static FFieldAddress SetStereoDelayIsEnabled_StereoDelayEnabled_PropertyAddress;

	private static int SetStereoDelayIsEnabled_StereoDelayEnabled_Offset;

	private static bool SetStereoDelayFeedback_IsValid;

	private static IntPtr SetStereoDelayFeedback_FunctionAddress;

	private static int SetStereoDelayFeedback_ParamsSize;

	private static bool SetStereoDelayFeedback_DelayFeedback_IsValid;

	private static FFieldAddress SetStereoDelayFeedback_DelayFeedback_PropertyAddress;

	private static int SetStereoDelayFeedback_DelayFeedback_Offset;

	private static bool SetSpread_IsValid;

	private static IntPtr SetSpread_FunctionAddress;

	private static int SetSpread_ParamsSize;

	private static bool SetSpread_Spread_IsValid;

	private static FFieldAddress SetSpread_Spread_PropertyAddress;

	private static int SetSpread_Spread_Offset;

	private static bool SetReleaseTime_IsValid;

	private static IntPtr SetReleaseTime_FunctionAddress;

	private static int SetReleaseTime_ParamsSize;

	private static bool SetReleaseTime_ReleaseTimeMsec_IsValid;

	private static FFieldAddress SetReleaseTime_ReleaseTimeMsec_PropertyAddress;

	private static int SetReleaseTime_ReleaseTimeMsec_Offset;

	private static bool SetPortamento_IsValid;

	private static IntPtr SetPortamento_FunctionAddress;

	private static int SetPortamento_ParamsSize;

	private static bool SetPortamento_Portamento_IsValid;

	private static FFieldAddress SetPortamento_Portamento_PropertyAddress;

	private static int SetPortamento_Portamento_Offset;

	private static bool SetPitchBend_IsValid;

	private static IntPtr SetPitchBend_FunctionAddress;

	private static int SetPitchBend_ParamsSize;

	private static bool SetPitchBend_PitchBend_IsValid;

	private static FFieldAddress SetPitchBend_PitchBend_PropertyAddress;

	private static int SetPitchBend_PitchBend_Offset;

	private static bool SetPan_IsValid;

	private static IntPtr SetPan_FunctionAddress;

	private static int SetPan_ParamsSize;

	private static bool SetPan_Pan_IsValid;

	private static FFieldAddress SetPan_Pan_PropertyAddress;

	private static int SetPan_Pan_Offset;

	private static bool SetOscType_IsValid;

	private static IntPtr SetOscType_FunctionAddress;

	private static int SetOscType_ParamsSize;

	private static bool SetOscType_OscIndex_IsValid;

	private static FFieldAddress SetOscType_OscIndex_PropertyAddress;

	private static int SetOscType_OscIndex_Offset;

	private static bool SetOscType_OscType_IsValid;

	private static FFieldAddress SetOscType_OscType_PropertyAddress;

	private static int SetOscType_OscType_Offset;

	private static bool SetOscSync_IsValid;

	private static IntPtr SetOscSync_FunctionAddress;

	private static int SetOscSync_ParamsSize;

	private static bool SetOscSync_bIsSynced_IsValid;

	private static FFieldAddress SetOscSync_bIsSynced_PropertyAddress;

	private static int SetOscSync_bIsSynced_Offset;

	private static bool SetOscSemitones_IsValid;

	private static IntPtr SetOscSemitones_FunctionAddress;

	private static int SetOscSemitones_ParamsSize;

	private static bool SetOscSemitones_OscIndex_IsValid;

	private static FFieldAddress SetOscSemitones_OscIndex_PropertyAddress;

	private static int SetOscSemitones_OscIndex_Offset;

	private static bool SetOscSemitones_Semitones_IsValid;

	private static FFieldAddress SetOscSemitones_Semitones_PropertyAddress;

	private static int SetOscSemitones_Semitones_Offset;

	private static bool SetOscPulsewidth_IsValid;

	private static IntPtr SetOscPulsewidth_FunctionAddress;

	private static int SetOscPulsewidth_ParamsSize;

	private static bool SetOscPulsewidth_OscIndex_IsValid;

	private static FFieldAddress SetOscPulsewidth_OscIndex_PropertyAddress;

	private static int SetOscPulsewidth_OscIndex_Offset;

	private static bool SetOscPulsewidth_Pulsewidth_IsValid;

	private static FFieldAddress SetOscPulsewidth_Pulsewidth_PropertyAddress;

	private static int SetOscPulsewidth_Pulsewidth_Offset;

	private static bool SetOscOctave_IsValid;

	private static IntPtr SetOscOctave_FunctionAddress;

	private static int SetOscOctave_ParamsSize;

	private static bool SetOscOctave_OscIndex_IsValid;

	private static FFieldAddress SetOscOctave_OscIndex_PropertyAddress;

	private static int SetOscOctave_OscIndex_Offset;

	private static bool SetOscOctave_Octave_IsValid;

	private static FFieldAddress SetOscOctave_Octave_PropertyAddress;

	private static int SetOscOctave_Octave_Offset;

	private static bool SetOscGainMod_IsValid;

	private static IntPtr SetOscGainMod_FunctionAddress;

	private static int SetOscGainMod_ParamsSize;

	private static bool SetOscGainMod_OscIndex_IsValid;

	private static FFieldAddress SetOscGainMod_OscIndex_PropertyAddress;

	private static int SetOscGainMod_OscIndex_Offset;

	private static bool SetOscGainMod_OscGainMod_IsValid;

	private static FFieldAddress SetOscGainMod_OscGainMod_PropertyAddress;

	private static int SetOscGainMod_OscGainMod_Offset;

	private static bool SetOscGain_IsValid;

	private static IntPtr SetOscGain_FunctionAddress;

	private static int SetOscGain_ParamsSize;

	private static bool SetOscGain_OscIndex_IsValid;

	private static FFieldAddress SetOscGain_OscIndex_PropertyAddress;

	private static int SetOscGain_OscIndex_Offset;

	private static bool SetOscGain_OscGain_IsValid;

	private static FFieldAddress SetOscGain_OscGain_PropertyAddress;

	private static int SetOscGain_OscGain_Offset;

	private static bool SetOscFrequencyMod_IsValid;

	private static IntPtr SetOscFrequencyMod_FunctionAddress;

	private static int SetOscFrequencyMod_ParamsSize;

	private static bool SetOscFrequencyMod_OscIndex_IsValid;

	private static FFieldAddress SetOscFrequencyMod_OscIndex_PropertyAddress;

	private static int SetOscFrequencyMod_OscIndex_Offset;

	private static bool SetOscFrequencyMod_OscFreqMod_IsValid;

	private static FFieldAddress SetOscFrequencyMod_OscFreqMod_PropertyAddress;

	private static int SetOscFrequencyMod_OscFreqMod_Offset;

	private static bool SetOscCents_IsValid;

	private static IntPtr SetOscCents_FunctionAddress;

	private static int SetOscCents_ParamsSize;

	private static bool SetOscCents_OscIndex_IsValid;

	private static FFieldAddress SetOscCents_OscIndex_PropertyAddress;

	private static int SetOscCents_OscIndex_Offset;

	private static bool SetOscCents_Cents_IsValid;

	private static FFieldAddress SetOscCents_Cents_PropertyAddress;

	private static int SetOscCents_Cents_Offset;

	private static bool SetModEnvSustainGain_IsValid;

	private static IntPtr SetModEnvSustainGain_FunctionAddress;

	private static int SetModEnvSustainGain_ParamsSize;

	private static bool SetModEnvSustainGain_SustainGain_IsValid;

	private static FFieldAddress SetModEnvSustainGain_SustainGain_PropertyAddress;

	private static int SetModEnvSustainGain_SustainGain_Offset;

	private static bool SetModEnvReleaseTime_IsValid;

	private static IntPtr SetModEnvReleaseTime_FunctionAddress;

	private static int SetModEnvReleaseTime_ParamsSize;

	private static bool SetModEnvReleaseTime_Release_IsValid;

	private static FFieldAddress SetModEnvReleaseTime_Release_PropertyAddress;

	private static int SetModEnvReleaseTime_Release_Offset;

	private static bool SetModEnvPatch_IsValid;

	private static IntPtr SetModEnvPatch_FunctionAddress;

	private static int SetModEnvPatch_ParamsSize;

	private static bool SetModEnvPatch_InPatchType_IsValid;

	private static FFieldAddress SetModEnvPatch_InPatchType_PropertyAddress;

	private static int SetModEnvPatch_InPatchType_Offset;

	private static bool SetModEnvInvert_IsValid;

	private static IntPtr SetModEnvInvert_FunctionAddress;

	private static int SetModEnvInvert_ParamsSize;

	private static bool SetModEnvInvert_bInvert_IsValid;

	private static FFieldAddress SetModEnvInvert_bInvert_PropertyAddress;

	private static int SetModEnvInvert_bInvert_Offset;

	private static bool SetModEnvDepth_IsValid;

	private static IntPtr SetModEnvDepth_FunctionAddress;

	private static int SetModEnvDepth_ParamsSize;

	private static bool SetModEnvDepth_Depth_IsValid;

	private static FFieldAddress SetModEnvDepth_Depth_PropertyAddress;

	private static int SetModEnvDepth_Depth_Offset;

	private static bool SetModEnvDecayTime_IsValid;

	private static IntPtr SetModEnvDecayTime_FunctionAddress;

	private static int SetModEnvDecayTime_ParamsSize;

	private static bool SetModEnvDecayTime_DecayTimeMsec_IsValid;

	private static FFieldAddress SetModEnvDecayTime_DecayTimeMsec_PropertyAddress;

	private static int SetModEnvDecayTime_DecayTimeMsec_Offset;

	private static bool SetModEnvBiasPatch_IsValid;

	private static IntPtr SetModEnvBiasPatch_FunctionAddress;

	private static int SetModEnvBiasPatch_ParamsSize;

	private static bool SetModEnvBiasPatch_InPatchType_IsValid;

	private static FFieldAddress SetModEnvBiasPatch_InPatchType_PropertyAddress;

	private static int SetModEnvBiasPatch_InPatchType_Offset;

	private static bool SetModEnvBiasInvert_IsValid;

	private static IntPtr SetModEnvBiasInvert_FunctionAddress;

	private static int SetModEnvBiasInvert_ParamsSize;

	private static bool SetModEnvBiasInvert_bInvert_IsValid;

	private static FFieldAddress SetModEnvBiasInvert_bInvert_PropertyAddress;

	private static int SetModEnvBiasInvert_bInvert_Offset;

	private static bool SetModEnvAttackTime_IsValid;

	private static IntPtr SetModEnvAttackTime_FunctionAddress;

	private static int SetModEnvAttackTime_ParamsSize;

	private static bool SetModEnvAttackTime_AttackTimeMsec_IsValid;

	private static FFieldAddress SetModEnvAttackTime_AttackTimeMsec_PropertyAddress;

	private static int SetModEnvAttackTime_AttackTimeMsec_Offset;

	private static bool SetLFOType_IsValid;

	private static IntPtr SetLFOType_FunctionAddress;

	private static int SetLFOType_ParamsSize;

	private static bool SetLFOType_LFOIndex_IsValid;

	private static FFieldAddress SetLFOType_LFOIndex_PropertyAddress;

	private static int SetLFOType_LFOIndex_Offset;

	private static bool SetLFOType_LFOType_IsValid;

	private static FFieldAddress SetLFOType_LFOType_PropertyAddress;

	private static int SetLFOType_LFOType_Offset;

	private static bool SetLFOPatch_IsValid;

	private static IntPtr SetLFOPatch_FunctionAddress;

	private static int SetLFOPatch_ParamsSize;

	private static bool SetLFOPatch_LFOIndex_IsValid;

	private static FFieldAddress SetLFOPatch_LFOIndex_PropertyAddress;

	private static int SetLFOPatch_LFOIndex_Offset;

	private static bool SetLFOPatch_LFOPatchType_IsValid;

	private static FFieldAddress SetLFOPatch_LFOPatchType_PropertyAddress;

	private static int SetLFOPatch_LFOPatchType_Offset;

	private static bool SetLFOMode_IsValid;

	private static IntPtr SetLFOMode_FunctionAddress;

	private static int SetLFOMode_ParamsSize;

	private static bool SetLFOMode_LFOIndex_IsValid;

	private static FFieldAddress SetLFOMode_LFOIndex_PropertyAddress;

	private static int SetLFOMode_LFOIndex_Offset;

	private static bool SetLFOMode_LFOMode_IsValid;

	private static FFieldAddress SetLFOMode_LFOMode_PropertyAddress;

	private static int SetLFOMode_LFOMode_Offset;

	private static bool SetLFOGainMod_IsValid;

	private static IntPtr SetLFOGainMod_FunctionAddress;

	private static int SetLFOGainMod_ParamsSize;

	private static bool SetLFOGainMod_LFOIndex_IsValid;

	private static FFieldAddress SetLFOGainMod_LFOIndex_PropertyAddress;

	private static int SetLFOGainMod_LFOIndex_Offset;

	private static bool SetLFOGainMod_GainMod_IsValid;

	private static FFieldAddress SetLFOGainMod_GainMod_PropertyAddress;

	private static int SetLFOGainMod_GainMod_Offset;

	private static bool SetLFOGain_IsValid;

	private static IntPtr SetLFOGain_FunctionAddress;

	private static int SetLFOGain_ParamsSize;

	private static bool SetLFOGain_LFOIndex_IsValid;

	private static FFieldAddress SetLFOGain_LFOIndex_PropertyAddress;

	private static int SetLFOGain_LFOIndex_Offset;

	private static bool SetLFOGain_Gain_IsValid;

	private static FFieldAddress SetLFOGain_Gain_PropertyAddress;

	private static int SetLFOGain_Gain_Offset;

	private static bool SetLFOFrequencyMod_IsValid;

	private static IntPtr SetLFOFrequencyMod_FunctionAddress;

	private static int SetLFOFrequencyMod_ParamsSize;

	private static bool SetLFOFrequencyMod_LFOIndex_IsValid;

	private static FFieldAddress SetLFOFrequencyMod_LFOIndex_PropertyAddress;

	private static int SetLFOFrequencyMod_LFOIndex_Offset;

	private static bool SetLFOFrequencyMod_FrequencyModHz_IsValid;

	private static FFieldAddress SetLFOFrequencyMod_FrequencyModHz_PropertyAddress;

	private static int SetLFOFrequencyMod_FrequencyModHz_Offset;

	private static bool SetLFOFrequency_IsValid;

	private static IntPtr SetLFOFrequency_FunctionAddress;

	private static int SetLFOFrequency_ParamsSize;

	private static bool SetLFOFrequency_LFOIndex_IsValid;

	private static FFieldAddress SetLFOFrequency_LFOIndex_PropertyAddress;

	private static int SetLFOFrequency_LFOIndex_Offset;

	private static bool SetLFOFrequency_FrequencyHz_IsValid;

	private static FFieldAddress SetLFOFrequency_FrequencyHz_PropertyAddress;

	private static int SetLFOFrequency_FrequencyHz_Offset;

	private static bool SetGainDb_IsValid;

	private static IntPtr SetGainDb_FunctionAddress;

	private static int SetGainDb_ParamsSize;

	private static bool SetGainDb_GainDb_IsValid;

	private static FFieldAddress SetGainDb_GainDb_PropertyAddress;

	private static int SetGainDb_GainDb_Offset;

	private static bool SetFilterType_IsValid;

	private static IntPtr SetFilterType_FunctionAddress;

	private static int SetFilterType_ParamsSize;

	private static bool SetFilterType_FilterType_IsValid;

	private static FFieldAddress SetFilterType_FilterType_PropertyAddress;

	private static int SetFilterType_FilterType_Offset;

	private static bool SetFilterQMod_IsValid;

	private static IntPtr SetFilterQMod_FunctionAddress;

	private static int SetFilterQMod_ParamsSize;

	private static bool SetFilterQMod_FilterQ_IsValid;

	private static FFieldAddress SetFilterQMod_FilterQ_PropertyAddress;

	private static int SetFilterQMod_FilterQ_Offset;

	private static bool SetFilterQ_IsValid;

	private static IntPtr SetFilterQ_FunctionAddress;

	private static int SetFilterQ_ParamsSize;

	private static bool SetFilterQ_FilterQ_IsValid;

	private static FFieldAddress SetFilterQ_FilterQ_PropertyAddress;

	private static int SetFilterQ_FilterQ_Offset;

	private static bool SetFilterFrequencyMod_IsValid;

	private static IntPtr SetFilterFrequencyMod_FunctionAddress;

	private static int SetFilterFrequencyMod_ParamsSize;

	private static bool SetFilterFrequencyMod_FilterFrequencyHz_IsValid;

	private static FFieldAddress SetFilterFrequencyMod_FilterFrequencyHz_PropertyAddress;

	private static int SetFilterFrequencyMod_FilterFrequencyHz_Offset;

	private static bool SetFilterFrequency_IsValid;

	private static IntPtr SetFilterFrequency_FunctionAddress;

	private static int SetFilterFrequency_ParamsSize;

	private static bool SetFilterFrequency_FilterFrequencyHz_IsValid;

	private static FFieldAddress SetFilterFrequency_FilterFrequencyHz_PropertyAddress;

	private static int SetFilterFrequency_FilterFrequencyHz_Offset;

	private static bool SetFilterAlgorithm_IsValid;

	private static IntPtr SetFilterAlgorithm_FunctionAddress;

	private static int SetFilterAlgorithm_ParamsSize;

	private static bool SetFilterAlgorithm_FilterAlgorithm_IsValid;

	private static FFieldAddress SetFilterAlgorithm_FilterAlgorithm_PropertyAddress;

	private static int SetFilterAlgorithm_FilterAlgorithm_Offset;

	private static bool SetEnableUnison_IsValid;

	private static IntPtr SetEnableUnison_FunctionAddress;

	private static int SetEnableUnison_ParamsSize;

	private static bool SetEnableUnison_EnableUnison_IsValid;

	private static FFieldAddress SetEnableUnison_EnableUnison_PropertyAddress;

	private static int SetEnableUnison_EnableUnison_Offset;

	private static bool SetEnableRetrigger_IsValid;

	private static IntPtr SetEnableRetrigger_FunctionAddress;

	private static int SetEnableRetrigger_ParamsSize;

	private static bool SetEnableRetrigger_RetriggerEnabled_IsValid;

	private static FFieldAddress SetEnableRetrigger_RetriggerEnabled_PropertyAddress;

	private static int SetEnableRetrigger_RetriggerEnabled_Offset;

	private static bool SetEnablePolyphony_IsValid;

	private static IntPtr SetEnablePolyphony_FunctionAddress;

	private static int SetEnablePolyphony_ParamsSize;

	private static bool SetEnablePolyphony_bEnablePolyphony_IsValid;

	private static FFieldAddress SetEnablePolyphony_bEnablePolyphony_PropertyAddress;

	private static int SetEnablePolyphony_bEnablePolyphony_Offset;

	private static bool SetEnablePatch_IsValid;

	private static IntPtr SetEnablePatch_FunctionAddress;

	private static int SetEnablePatch_ParamsSize;

	private static bool SetEnablePatch_PatchId_IsValid;

	private static FFieldAddress SetEnablePatch_PatchId_PropertyAddress;

	private static int SetEnablePatch_PatchId_Offset;

	private static bool SetEnablePatch_bIsEnabled_IsValid;

	private static FFieldAddress SetEnablePatch_bIsEnabled_PropertyAddress;

	private static int SetEnablePatch_bIsEnabled_Offset;

	private static bool SetEnablePatch_ReturnValue_IsValid;

	private static FFieldAddress SetEnablePatch_ReturnValue_PropertyAddress;

	private static int SetEnablePatch_ReturnValue_Offset;

	private static bool SetEnableLegato_IsValid;

	private static IntPtr SetEnableLegato_FunctionAddress;

	private static int SetEnableLegato_ParamsSize;

	private static bool SetEnableLegato_LegatoEnabled_IsValid;

	private static FFieldAddress SetEnableLegato_LegatoEnabled_PropertyAddress;

	private static int SetEnableLegato_LegatoEnabled_Offset;

	private static bool SetDecayTime_IsValid;

	private static IntPtr SetDecayTime_FunctionAddress;

	private static int SetDecayTime_ParamsSize;

	private static bool SetDecayTime_DecayTimeMsec_IsValid;

	private static FFieldAddress SetDecayTime_DecayTimeMsec_PropertyAddress;

	private static int SetDecayTime_DecayTimeMsec_Offset;

	private static bool SetChorusFrequency_IsValid;

	private static IntPtr SetChorusFrequency_FunctionAddress;

	private static int SetChorusFrequency_ParamsSize;

	private static bool SetChorusFrequency_Frequency_IsValid;

	private static FFieldAddress SetChorusFrequency_Frequency_PropertyAddress;

	private static int SetChorusFrequency_Frequency_Offset;

	private static bool SetChorusFeedback_IsValid;

	private static IntPtr SetChorusFeedback_FunctionAddress;

	private static int SetChorusFeedback_ParamsSize;

	private static bool SetChorusFeedback_Feedback_IsValid;

	private static FFieldAddress SetChorusFeedback_Feedback_PropertyAddress;

	private static int SetChorusFeedback_Feedback_Offset;

	private static bool SetChorusEnabled_IsValid;

	private static IntPtr SetChorusEnabled_FunctionAddress;

	private static int SetChorusEnabled_ParamsSize;

	private static bool SetChorusEnabled_EnableChorus_IsValid;

	private static FFieldAddress SetChorusEnabled_EnableChorus_PropertyAddress;

	private static int SetChorusEnabled_EnableChorus_Offset;

	private static bool SetChorusDepth_IsValid;

	private static IntPtr SetChorusDepth_FunctionAddress;

	private static int SetChorusDepth_ParamsSize;

	private static bool SetChorusDepth_Depth_IsValid;

	private static FFieldAddress SetChorusDepth_Depth_PropertyAddress;

	private static int SetChorusDepth_Depth_Offset;

	private static bool SetAttackTime_IsValid;

	private static IntPtr SetAttackTime_FunctionAddress;

	private static int SetAttackTime_ParamsSize;

	private static bool SetAttackTime_AttackTimeMsec_IsValid;

	private static FFieldAddress SetAttackTime_AttackTimeMsec_PropertyAddress;

	private static int SetAttackTime_AttackTimeMsec_Offset;

	private static bool NoteOn_IsValid;

	private static IntPtr NoteOn_FunctionAddress;

	private static int NoteOn_ParamsSize;

	private static bool NoteOn_Note_IsValid;

	private static FFieldAddress NoteOn_Note_PropertyAddress;

	private static int NoteOn_Note_Offset;

	private static bool NoteOn_Velocity_IsValid;

	private static FFieldAddress NoteOn_Velocity_PropertyAddress;

	private static int NoteOn_Velocity_Offset;

	private static bool NoteOn_Duration_IsValid;

	private static FFieldAddress NoteOn_Duration_PropertyAddress;

	private static int NoteOn_Duration_Offset;

	private static bool NoteOff_IsValid;

	private static IntPtr NoteOff_FunctionAddress;

	private static int NoteOff_ParamsSize;

	private static bool NoteOff_Note_IsValid;

	private static FFieldAddress NoteOff_Note_PropertyAddress;

	private static int NoteOff_Note_Offset;

	private static bool NoteOff_bAllNotesOff_IsValid;

	private static FFieldAddress NoteOff_bAllNotesOff_PropertyAddress;

	private static int NoteOff_bAllNotesOff_Offset;

	private static bool NoteOff_bKillAllNotes_IsValid;

	private static FFieldAddress NoteOff_bKillAllNotes_PropertyAddress;

	private static int NoteOff_bKillAllNotes_Offset;

	private static bool CreatePatch_IsValid;

	private static IntPtr CreatePatch_FunctionAddress;

	private static int CreatePatch_ParamsSize;

	private static bool CreatePatch_PatchSource_IsValid;

	private static FFieldAddress CreatePatch_PatchSource_PropertyAddress;

	private static int CreatePatch_PatchSource_Offset;

	private static bool CreatePatch_PatchCables_IsValid;

	private static FFieldAddress CreatePatch_PatchCables_PropertyAddress;

	private static int CreatePatch_PatchCables_Offset;

	private static bool CreatePatch_bEnableByDefault_IsValid;

	private static FFieldAddress CreatePatch_bEnableByDefault_PropertyAddress;

	private static int CreatePatch_bEnableByDefault_Offset;

	private static bool CreatePatch_ReturnValue_IsValid;

	private static FFieldAddress CreatePatch_ReturnValue_PropertyAddress;

	private static int CreatePatch_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:VoiceCount")]
	public int VoiceCount
	{
		get
		{
			CheckDestroyed();
			if (!VoiceCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.ModularSynthComponent:VoiceCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, VoiceCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoiceCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.ModularSynthComponent:VoiceCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, VoiceCount_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetSynthPreset")]
	public unsafe void SetSynthPreset(FModularSynthPreset SynthPreset)
	{
		CheckDestroyed();
		if (!SetSynthPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetSynthPreset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSynthPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSynthPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSynthPreset_SynthPreset_PropertyAddress.Address, intPtr);
		FModularSynthPreset.ToNative(IntPtr.Add(intPtr, SetSynthPreset_SynthPreset_Offset), 0, SetSynthPreset_SynthPreset_PropertyAddress.Address, SynthPreset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSynthPreset_FunctionAddress, intPtr, SetSynthPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSynthPreset_SynthPreset_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetSustainGain")]
	public unsafe void SetSustainGain(float SustainGain)
	{
		CheckDestroyed();
		if (!SetSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetSustainGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSustainGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSustainGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSustainGain_SustainGain_Offset), 0, SetSustainGain_SustainGain_PropertyAddress.Address, SustainGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSustainGain_FunctionAddress, intPtr, SetSustainGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayWetlevel")]
	public unsafe void SetStereoDelayWetlevel(float DelayWetlevel)
	{
		CheckDestroyed();
		if (!SetStereoDelayWetlevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayWetlevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayWetlevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayWetlevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStereoDelayWetlevel_DelayWetlevel_Offset), 0, SetStereoDelayWetlevel_DelayWetlevel_PropertyAddress.Address, DelayWetlevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayWetlevel_FunctionAddress, intPtr, SetStereoDelayWetlevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayTime")]
	public unsafe void SetStereoDelayTime(float DelayTimeMsec)
	{
		CheckDestroyed();
		if (!SetStereoDelayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStereoDelayTime_DelayTimeMsec_Offset), 0, SetStereoDelayTime_DelayTimeMsec_PropertyAddress.Address, DelayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayTime_FunctionAddress, intPtr, SetStereoDelayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayRatio")]
	public unsafe void SetStereoDelayRatio(float DelayRatio)
	{
		CheckDestroyed();
		if (!SetStereoDelayRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStereoDelayRatio_DelayRatio_Offset), 0, SetStereoDelayRatio_DelayRatio_PropertyAddress.Address, DelayRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayRatio_FunctionAddress, intPtr, SetStereoDelayRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayMode")]
	public unsafe void SetStereoDelayMode(ESynthStereoDelayMode StereoDelayMode)
	{
		CheckDestroyed();
		if (!SetStereoDelayMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthStereoDelayMode>.ToNative(IntPtr.Add(intPtr, SetStereoDelayMode_StereoDelayMode_Offset), 0, SetStereoDelayMode_StereoDelayMode_PropertyAddress.Address, StereoDelayMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayMode_FunctionAddress, intPtr, SetStereoDelayMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayIsEnabled")]
	public unsafe void SetStereoDelayIsEnabled(bool StereoDelayEnabled)
	{
		CheckDestroyed();
		if (!SetStereoDelayIsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayIsEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayIsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayIsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStereoDelayIsEnabled_StereoDelayEnabled_Offset), 0, SetStereoDelayIsEnabled_StereoDelayEnabled_PropertyAddress.Address, StereoDelayEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayIsEnabled_FunctionAddress, intPtr, SetStereoDelayIsEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetStereoDelayFeedback")]
	public unsafe void SetStereoDelayFeedback(float DelayFeedback)
	{
		CheckDestroyed();
		if (!SetStereoDelayFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetStereoDelayFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStereoDelayFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStereoDelayFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStereoDelayFeedback_DelayFeedback_Offset), 0, SetStereoDelayFeedback_DelayFeedback_PropertyAddress.Address, DelayFeedback);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStereoDelayFeedback_FunctionAddress, intPtr, SetStereoDelayFeedback_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetSpread")]
	public unsafe void SetSpread(float Spread)
	{
		CheckDestroyed();
		if (!SetSpread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetSpread");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSpread_Spread_Offset), 0, SetSpread_Spread_PropertyAddress.Address, Spread);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpread_FunctionAddress, intPtr, SetSpread_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetReleaseTime")]
	public unsafe void SetReleaseTime(float ReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetReleaseTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetReleaseTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReleaseTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReleaseTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReleaseTime_ReleaseTimeMsec_Offset), 0, SetReleaseTime_ReleaseTimeMsec_PropertyAddress.Address, ReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReleaseTime_FunctionAddress, intPtr, SetReleaseTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetPortamento")]
	public unsafe void SetPortamento(float Portamento)
	{
		CheckDestroyed();
		if (!SetPortamento_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetPortamento");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPortamento_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPortamento_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPortamento_Portamento_Offset), 0, SetPortamento_Portamento_PropertyAddress.Address, Portamento);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPortamento_FunctionAddress, intPtr, SetPortamento_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetPitchBend")]
	public unsafe void SetPitchBend(float PitchBend)
	{
		CheckDestroyed();
		if (!SetPitchBend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetPitchBend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPitchBend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPitchBend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPitchBend_PitchBend_Offset), 0, SetPitchBend_PitchBend_PropertyAddress.Address, PitchBend);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPitchBend_FunctionAddress, intPtr, SetPitchBend_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetPan")]
	public unsafe void SetPan(float Pan)
	{
		CheckDestroyed();
		if (!SetPan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetPan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPan_Pan_Offset), 0, SetPan_Pan_PropertyAddress.Address, Pan);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPan_FunctionAddress, intPtr, SetPan_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscType")]
	public unsafe void SetOscType(int OscIndex, ESynth1OscType OscType)
	{
		CheckDestroyed();
		if (!SetOscType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscType_OscIndex_Offset), 0, SetOscType_OscIndex_PropertyAddress.Address, OscIndex);
		EnumMarshaler<ESynth1OscType>.ToNative(IntPtr.Add(intPtr, SetOscType_OscType_Offset), 0, SetOscType_OscType_PropertyAddress.Address, OscType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscType_FunctionAddress, intPtr, SetOscType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscSync")]
	public unsafe void SetOscSync(bool bIsSynced)
	{
		CheckDestroyed();
		if (!SetOscSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscSync");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOscSync_bIsSynced_Offset), 0, SetOscSync_bIsSynced_PropertyAddress.Address, bIsSynced);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscSync_FunctionAddress, intPtr, SetOscSync_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscSemitones")]
	public unsafe void SetOscSemitones(int OscIndex, float Semitones)
	{
		CheckDestroyed();
		if (!SetOscSemitones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscSemitones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscSemitones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscSemitones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscSemitones_OscIndex_Offset), 0, SetOscSemitones_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscSemitones_Semitones_Offset), 0, SetOscSemitones_Semitones_PropertyAddress.Address, Semitones);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscSemitones_FunctionAddress, intPtr, SetOscSemitones_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscPulsewidth")]
	public unsafe void SetOscPulsewidth(int OscIndex, float Pulsewidth)
	{
		CheckDestroyed();
		if (!SetOscPulsewidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscPulsewidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscPulsewidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscPulsewidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscPulsewidth_OscIndex_Offset), 0, SetOscPulsewidth_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscPulsewidth_Pulsewidth_Offset), 0, SetOscPulsewidth_Pulsewidth_PropertyAddress.Address, Pulsewidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscPulsewidth_FunctionAddress, intPtr, SetOscPulsewidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscOctave")]
	public unsafe void SetOscOctave(int OscIndex, float Octave)
	{
		CheckDestroyed();
		if (!SetOscOctave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscOctave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscOctave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscOctave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscOctave_OscIndex_Offset), 0, SetOscOctave_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscOctave_Octave_Offset), 0, SetOscOctave_Octave_PropertyAddress.Address, Octave);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscOctave_FunctionAddress, intPtr, SetOscOctave_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscGainMod")]
	public unsafe void SetOscGainMod(int OscIndex, float OscGainMod)
	{
		CheckDestroyed();
		if (!SetOscGainMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscGainMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscGainMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscGainMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscGainMod_OscIndex_Offset), 0, SetOscGainMod_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscGainMod_OscGainMod_Offset), 0, SetOscGainMod_OscGainMod_PropertyAddress.Address, OscGainMod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscGainMod_FunctionAddress, intPtr, SetOscGainMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscGain")]
	public unsafe void SetOscGain(int OscIndex, float OscGain)
	{
		CheckDestroyed();
		if (!SetOscGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscGain_OscIndex_Offset), 0, SetOscGain_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscGain_OscGain_Offset), 0, SetOscGain_OscGain_PropertyAddress.Address, OscGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscGain_FunctionAddress, intPtr, SetOscGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscFrequencyMod")]
	public unsafe void SetOscFrequencyMod(int OscIndex, float OscFreqMod)
	{
		CheckDestroyed();
		if (!SetOscFrequencyMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscFrequencyMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscFrequencyMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscFrequencyMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscFrequencyMod_OscIndex_Offset), 0, SetOscFrequencyMod_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscFrequencyMod_OscFreqMod_Offset), 0, SetOscFrequencyMod_OscFreqMod_PropertyAddress.Address, OscFreqMod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscFrequencyMod_FunctionAddress, intPtr, SetOscFrequencyMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetOscCents")]
	public unsafe void SetOscCents(int OscIndex, float Cents)
	{
		CheckDestroyed();
		if (!SetOscCents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetOscCents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOscCents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOscCents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetOscCents_OscIndex_Offset), 0, SetOscCents_OscIndex_PropertyAddress.Address, OscIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOscCents_Cents_Offset), 0, SetOscCents_Cents_PropertyAddress.Address, Cents);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOscCents_FunctionAddress, intPtr, SetOscCents_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvSustainGain")]
	public unsafe void SetModEnvSustainGain(float SustainGain)
	{
		CheckDestroyed();
		if (!SetModEnvSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvSustainGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvSustainGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvSustainGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetModEnvSustainGain_SustainGain_Offset), 0, SetModEnvSustainGain_SustainGain_PropertyAddress.Address, SustainGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvSustainGain_FunctionAddress, intPtr, SetModEnvSustainGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvReleaseTime")]
	public unsafe void SetModEnvReleaseTime(float Release)
	{
		CheckDestroyed();
		if (!SetModEnvReleaseTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvReleaseTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvReleaseTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvReleaseTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetModEnvReleaseTime_Release_Offset), 0, SetModEnvReleaseTime_Release_PropertyAddress.Address, Release);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvReleaseTime_FunctionAddress, intPtr, SetModEnvReleaseTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvPatch")]
	public unsafe void SetModEnvPatch(ESynthModEnvPatch InPatchType)
	{
		CheckDestroyed();
		if (!SetModEnvPatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvPatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvPatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvPatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthModEnvPatch>.ToNative(IntPtr.Add(intPtr, SetModEnvPatch_InPatchType_Offset), 0, SetModEnvPatch_InPatchType_PropertyAddress.Address, InPatchType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvPatch_FunctionAddress, intPtr, SetModEnvPatch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvInvert")]
	public unsafe void SetModEnvInvert(bool bInvert)
	{
		CheckDestroyed();
		if (!SetModEnvInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetModEnvInvert_bInvert_Offset), 0, SetModEnvInvert_bInvert_PropertyAddress.Address, bInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvInvert_FunctionAddress, intPtr, SetModEnvInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvDepth")]
	public unsafe void SetModEnvDepth(float Depth)
	{
		CheckDestroyed();
		if (!SetModEnvDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetModEnvDepth_Depth_Offset), 0, SetModEnvDepth_Depth_PropertyAddress.Address, Depth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvDepth_FunctionAddress, intPtr, SetModEnvDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvDecayTime")]
	public unsafe void SetModEnvDecayTime(float DecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetModEnvDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvDecayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvDecayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvDecayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetModEnvDecayTime_DecayTimeMsec_Offset), 0, SetModEnvDecayTime_DecayTimeMsec_PropertyAddress.Address, DecayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvDecayTime_FunctionAddress, intPtr, SetModEnvDecayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasPatch")]
	public unsafe void SetModEnvBiasPatch(ESynthModEnvBiasPatch InPatchType)
	{
		CheckDestroyed();
		if (!SetModEnvBiasPatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasPatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvBiasPatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvBiasPatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthModEnvBiasPatch>.ToNative(IntPtr.Add(intPtr, SetModEnvBiasPatch_InPatchType_Offset), 0, SetModEnvBiasPatch_InPatchType_PropertyAddress.Address, InPatchType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvBiasPatch_FunctionAddress, intPtr, SetModEnvBiasPatch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasInvert")]
	public unsafe void SetModEnvBiasInvert(bool bInvert)
	{
		CheckDestroyed();
		if (!SetModEnvBiasInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvBiasInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvBiasInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetModEnvBiasInvert_bInvert_Offset), 0, SetModEnvBiasInvert_bInvert_PropertyAddress.Address, bInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvBiasInvert_FunctionAddress, intPtr, SetModEnvBiasInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetModEnvAttackTime")]
	public unsafe void SetModEnvAttackTime(float AttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetModEnvAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetModEnvAttackTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetModEnvAttackTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetModEnvAttackTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetModEnvAttackTime_AttackTimeMsec_Offset), 0, SetModEnvAttackTime_AttackTimeMsec_PropertyAddress.Address, AttackTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetModEnvAttackTime_FunctionAddress, intPtr, SetModEnvAttackTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOType")]
	public unsafe void SetLFOType(int LFOIndex, ESynthLFOType LFOType)
	{
		CheckDestroyed();
		if (!SetLFOType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOType_LFOIndex_Offset), 0, SetLFOType_LFOIndex_PropertyAddress.Address, LFOIndex);
		EnumMarshaler<ESynthLFOType>.ToNative(IntPtr.Add(intPtr, SetLFOType_LFOType_Offset), 0, SetLFOType_LFOType_PropertyAddress.Address, LFOType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOType_FunctionAddress, intPtr, SetLFOType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOPatch")]
	public unsafe void SetLFOPatch(int LFOIndex, ESynthLFOPatchType LFOPatchType)
	{
		CheckDestroyed();
		if (!SetLFOPatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOPatch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOPatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOPatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOPatch_LFOIndex_Offset), 0, SetLFOPatch_LFOIndex_PropertyAddress.Address, LFOIndex);
		EnumMarshaler<ESynthLFOPatchType>.ToNative(IntPtr.Add(intPtr, SetLFOPatch_LFOPatchType_Offset), 0, SetLFOPatch_LFOPatchType_PropertyAddress.Address, LFOPatchType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOPatch_FunctionAddress, intPtr, SetLFOPatch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOMode")]
	public unsafe void SetLFOMode(int LFOIndex, ESynthLFOMode LFOMode)
	{
		CheckDestroyed();
		if (!SetLFOMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOMode_LFOIndex_Offset), 0, SetLFOMode_LFOIndex_PropertyAddress.Address, LFOIndex);
		EnumMarshaler<ESynthLFOMode>.ToNative(IntPtr.Add(intPtr, SetLFOMode_LFOMode_Offset), 0, SetLFOMode_LFOMode_PropertyAddress.Address, LFOMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOMode_FunctionAddress, intPtr, SetLFOMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOGainMod")]
	public unsafe void SetLFOGainMod(int LFOIndex, float GainMod)
	{
		CheckDestroyed();
		if (!SetLFOGainMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOGainMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOGainMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOGainMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOGainMod_LFOIndex_Offset), 0, SetLFOGainMod_LFOIndex_PropertyAddress.Address, LFOIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLFOGainMod_GainMod_Offset), 0, SetLFOGainMod_GainMod_PropertyAddress.Address, GainMod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOGainMod_FunctionAddress, intPtr, SetLFOGainMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOGain")]
	public unsafe void SetLFOGain(int LFOIndex, float Gain)
	{
		CheckDestroyed();
		if (!SetLFOGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOGain_LFOIndex_Offset), 0, SetLFOGain_LFOIndex_PropertyAddress.Address, LFOIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLFOGain_Gain_Offset), 0, SetLFOGain_Gain_PropertyAddress.Address, Gain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOGain_FunctionAddress, intPtr, SetLFOGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOFrequencyMod")]
	public unsafe void SetLFOFrequencyMod(int LFOIndex, float FrequencyModHz)
	{
		CheckDestroyed();
		if (!SetLFOFrequencyMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOFrequencyMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOFrequencyMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOFrequencyMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOFrequencyMod_LFOIndex_Offset), 0, SetLFOFrequencyMod_LFOIndex_PropertyAddress.Address, LFOIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLFOFrequencyMod_FrequencyModHz_Offset), 0, SetLFOFrequencyMod_FrequencyModHz_PropertyAddress.Address, FrequencyModHz);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOFrequencyMod_FunctionAddress, intPtr, SetLFOFrequencyMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetLFOFrequency")]
	public unsafe void SetLFOFrequency(int LFOIndex, float FrequencyHz)
	{
		CheckDestroyed();
		if (!SetLFOFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetLFOFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLFOFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLFOFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLFOFrequency_LFOIndex_Offset), 0, SetLFOFrequency_LFOIndex_PropertyAddress.Address, LFOIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLFOFrequency_FrequencyHz_Offset), 0, SetLFOFrequency_FrequencyHz_PropertyAddress.Address, FrequencyHz);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLFOFrequency_FunctionAddress, intPtr, SetLFOFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetGainDb")]
	public unsafe void SetGainDb(float GainDb)
	{
		CheckDestroyed();
		if (!SetGainDb_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetGainDb");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGainDb_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGainDb_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGainDb_GainDb_Offset), 0, SetGainDb_GainDb_PropertyAddress.Address, GainDb);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGainDb_FunctionAddress, intPtr, SetGainDb_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterType")]
	public unsafe void SetFilterType(ESynthFilterType FilterType)
	{
		CheckDestroyed();
		if (!SetFilterType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthFilterType>.ToNative(IntPtr.Add(intPtr, SetFilterType_FilterType_Offset), 0, SetFilterType_FilterType_PropertyAddress.Address, FilterType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterType_FunctionAddress, intPtr, SetFilterType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterQMod")]
	public unsafe void SetFilterQMod(float FilterQ)
	{
		CheckDestroyed();
		if (!SetFilterQMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterQMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterQMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterQMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterQMod_FilterQ_Offset), 0, SetFilterQMod_FilterQ_PropertyAddress.Address, FilterQ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterQMod_FunctionAddress, intPtr, SetFilterQMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterQ")]
	public unsafe void SetFilterQ(float FilterQ)
	{
		CheckDestroyed();
		if (!SetFilterQ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterQ");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterQ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterQ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterQ_FilterQ_Offset), 0, SetFilterQ_FilterQ_PropertyAddress.Address, FilterQ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterQ_FunctionAddress, intPtr, SetFilterQ_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterFrequencyMod")]
	public unsafe void SetFilterFrequencyMod(float FilterFrequencyHz)
	{
		CheckDestroyed();
		if (!SetFilterFrequencyMod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterFrequencyMod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterFrequencyMod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterFrequencyMod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterFrequencyMod_FilterFrequencyHz_Offset), 0, SetFilterFrequencyMod_FilterFrequencyHz_PropertyAddress.Address, FilterFrequencyHz);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterFrequencyMod_FunctionAddress, intPtr, SetFilterFrequencyMod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterFrequency")]
	public unsafe void SetFilterFrequency(float FilterFrequencyHz)
	{
		CheckDestroyed();
		if (!SetFilterFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterFrequency_FilterFrequencyHz_Offset), 0, SetFilterFrequency_FilterFrequencyHz_PropertyAddress.Address, FilterFrequencyHz);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterFrequency_FunctionAddress, intPtr, SetFilterFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetFilterAlgorithm")]
	public unsafe void SetFilterAlgorithm(ESynthFilterAlgorithm FilterAlgorithm)
	{
		CheckDestroyed();
		if (!SetFilterAlgorithm_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetFilterAlgorithm");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterAlgorithm_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterAlgorithm_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthFilterAlgorithm>.ToNative(IntPtr.Add(intPtr, SetFilterAlgorithm_FilterAlgorithm_Offset), 0, SetFilterAlgorithm_FilterAlgorithm_PropertyAddress.Address, FilterAlgorithm);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterAlgorithm_FunctionAddress, intPtr, SetFilterAlgorithm_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetEnableUnison")]
	public unsafe void SetEnableUnison(bool EnableUnison)
	{
		CheckDestroyed();
		if (!SetEnableUnison_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetEnableUnison");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableUnison_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableUnison_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableUnison_EnableUnison_Offset), 0, SetEnableUnison_EnableUnison_PropertyAddress.Address, EnableUnison);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableUnison_FunctionAddress, intPtr, SetEnableUnison_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetEnableRetrigger")]
	public unsafe void SetEnableRetrigger(bool RetriggerEnabled)
	{
		CheckDestroyed();
		if (!SetEnableRetrigger_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetEnableRetrigger");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableRetrigger_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableRetrigger_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableRetrigger_RetriggerEnabled_Offset), 0, SetEnableRetrigger_RetriggerEnabled_PropertyAddress.Address, RetriggerEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableRetrigger_FunctionAddress, intPtr, SetEnableRetrigger_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetEnablePolyphony")]
	public unsafe void SetEnablePolyphony(bool bEnablePolyphony)
	{
		CheckDestroyed();
		if (!SetEnablePolyphony_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetEnablePolyphony");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnablePolyphony_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnablePolyphony_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnablePolyphony_bEnablePolyphony_Offset), 0, SetEnablePolyphony_bEnablePolyphony_PropertyAddress.Address, bEnablePolyphony);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnablePolyphony_FunctionAddress, intPtr, SetEnablePolyphony_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetEnablePatch")]
	public unsafe bool SetEnablePatch(FPatchId PatchId, bool bIsEnabled)
	{
		CheckDestroyed();
		if (!SetEnablePatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetEnablePatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnablePatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnablePatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetEnablePatch_PatchId_PropertyAddress.Address, intPtr);
		FPatchId.ToNative(IntPtr.Add(intPtr, SetEnablePatch_PatchId_Offset), 0, SetEnablePatch_PatchId_PropertyAddress.Address, PatchId);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnablePatch_bIsEnabled_Offset), 0, SetEnablePatch_bIsEnabled_PropertyAddress.Address, bIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnablePatch_FunctionAddress, intPtr, SetEnablePatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetEnablePatch_ReturnValue_Offset), 0, SetEnablePatch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetEnableLegato")]
	public unsafe void SetEnableLegato(bool LegatoEnabled)
	{
		CheckDestroyed();
		if (!SetEnableLegato_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetEnableLegato");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableLegato_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableLegato_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableLegato_LegatoEnabled_Offset), 0, SetEnableLegato_LegatoEnabled_PropertyAddress.Address, LegatoEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableLegato_FunctionAddress, intPtr, SetEnableLegato_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetDecayTime")]
	public unsafe void SetDecayTime(float DecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetDecayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDecayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDecayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDecayTime_DecayTimeMsec_Offset), 0, SetDecayTime_DecayTimeMsec_PropertyAddress.Address, DecayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDecayTime_FunctionAddress, intPtr, SetDecayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetChorusFrequency")]
	public unsafe void SetChorusFrequency(float Frequency)
	{
		CheckDestroyed();
		if (!SetChorusFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetChorusFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChorusFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChorusFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetChorusFrequency_Frequency_Offset), 0, SetChorusFrequency_Frequency_PropertyAddress.Address, Frequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetChorusFrequency_FunctionAddress, intPtr, SetChorusFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetChorusFeedback")]
	public unsafe void SetChorusFeedback(float Feedback)
	{
		CheckDestroyed();
		if (!SetChorusFeedback_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetChorusFeedback");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChorusFeedback_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChorusFeedback_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetChorusFeedback_Feedback_Offset), 0, SetChorusFeedback_Feedback_PropertyAddress.Address, Feedback);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetChorusFeedback_FunctionAddress, intPtr, SetChorusFeedback_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetChorusEnabled")]
	public unsafe void SetChorusEnabled(bool EnableChorus)
	{
		CheckDestroyed();
		if (!SetChorusEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetChorusEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChorusEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChorusEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetChorusEnabled_EnableChorus_Offset), 0, SetChorusEnabled_EnableChorus_PropertyAddress.Address, EnableChorus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetChorusEnabled_FunctionAddress, intPtr, SetChorusEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetChorusDepth")]
	public unsafe void SetChorusDepth(float Depth)
	{
		CheckDestroyed();
		if (!SetChorusDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetChorusDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetChorusDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetChorusDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetChorusDepth_Depth_Offset), 0, SetChorusDepth_Depth_PropertyAddress.Address, Depth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetChorusDepth_FunctionAddress, intPtr, SetChorusDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:SetAttackTime")]
	public unsafe void SetAttackTime(float AttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:SetAttackTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAttackTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAttackTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAttackTime_AttackTimeMsec_Offset), 0, SetAttackTime_AttackTimeMsec_PropertyAddress.Address, AttackTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAttackTime_FunctionAddress, intPtr, SetAttackTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:NoteOn")]
	public unsafe void NoteOn(float Note, int Velocity, float Duration = -1f)
	{
		CheckDestroyed();
		if (!NoteOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:NoteOn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoteOn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoteOn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOn_Note_Offset), 0, NoteOn_Note_PropertyAddress.Address, Note);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NoteOn_Velocity_Offset), 0, NoteOn_Velocity_PropertyAddress.Address, Velocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOn_Duration_Offset), 0, NoteOn_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeFunctionOptimized(base.Address, NoteOn_FunctionAddress, intPtr, NoteOn_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:NoteOff")]
	public unsafe void NoteOff(float Note, bool bAllNotesOff = false, bool bKillAllNotes = false)
	{
		CheckDestroyed();
		if (!NoteOff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:NoteOff");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoteOff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoteOff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOff_Note_Offset), 0, NoteOff_Note_PropertyAddress.Address, Note);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NoteOff_bAllNotesOff_Offset), 0, NoteOff_bAllNotesOff_PropertyAddress.Address, bAllNotesOff);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NoteOff_bKillAllNotes_Offset), 0, NoteOff_bKillAllNotes_PropertyAddress.Address, bKillAllNotes);
		NativeReflection.InvokeFunctionOptimized(base.Address, NoteOff_FunctionAddress, intPtr, NoteOff_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Synthesis.ModularSynthComponent:CreatePatch")]
	public unsafe FPatchId CreatePatch(ESynth1PatchSource PatchSource, List<FSynth1PatchCable> PatchCables, bool bEnableByDefault)
	{
		CheckDestroyed();
		if (!CreatePatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.ModularSynthComponent:CreatePatch");
			return default(FPatchId);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynth1PatchSource>.ToNative(IntPtr.Add(intPtr, CreatePatch_PatchSource_Offset), 0, CreatePatch_PatchSource_PropertyAddress.Address, PatchSource);
		new TArrayCopyMarshaler<FSynth1PatchCable>(1, CreatePatch_PatchCables_PropertyAddress, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.FromNative, CachedMarshalingDelegates<FSynth1PatchCable, FSynth1PatchCable>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePatch_PatchCables_Offset), PatchCables);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreatePatch_bEnableByDefault_Offset), 0, CreatePatch_bEnableByDefault_PropertyAddress.Address, bEnableByDefault);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreatePatch_FunctionAddress, intPtr, CreatePatch_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePatch_PatchCables_PropertyAddress.Address, intPtr);
		return FPatchId.FromNative(IntPtr.Add(intPtr, CreatePatch_ReturnValue_Offset), 0, CreatePatch_ReturnValue_PropertyAddress.Address);
	}

	static UModularSynthComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UModularSynthComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UModularSynthComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.ModularSynthComponent");
		VoiceCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoiceCount");
		VoiceCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoiceCount", Classes.FIntProperty);
		SetSynthPreset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSynthPreset");
		SetSynthPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSynthPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSynthPreset_SynthPreset_PropertyAddress, SetSynthPreset_FunctionAddress, "SynthPreset");
		SetSynthPreset_SynthPreset_Offset = NativeReflectionCached.GetPropertyOffset(SetSynthPreset_FunctionAddress, "SynthPreset");
		SetSynthPreset_SynthPreset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSynthPreset_FunctionAddress, "SynthPreset", Classes.FStructProperty);
		SetSynthPreset_IsValid = SetSynthPreset_FunctionAddress != IntPtr.Zero && SetSynthPreset_SynthPreset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetSynthPreset", SetSynthPreset_IsValid);
		SetSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSustainGain");
		SetSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSustainGain_SustainGain_PropertyAddress, SetSustainGain_FunctionAddress, "SustainGain");
		SetSustainGain_SustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetSustainGain_FunctionAddress, "SustainGain");
		SetSustainGain_SustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSustainGain_FunctionAddress, "SustainGain", Classes.FFloatProperty);
		SetSustainGain_IsValid = SetSustainGain_FunctionAddress != IntPtr.Zero && SetSustainGain_SustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetSustainGain", SetSustainGain_IsValid);
		SetStereoDelayWetlevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayWetlevel");
		SetStereoDelayWetlevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayWetlevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayWetlevel_DelayWetlevel_PropertyAddress, SetStereoDelayWetlevel_FunctionAddress, "DelayWetlevel");
		SetStereoDelayWetlevel_DelayWetlevel_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayWetlevel_FunctionAddress, "DelayWetlevel");
		SetStereoDelayWetlevel_DelayWetlevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayWetlevel_FunctionAddress, "DelayWetlevel", Classes.FFloatProperty);
		SetStereoDelayWetlevel_IsValid = SetStereoDelayWetlevel_FunctionAddress != IntPtr.Zero && SetStereoDelayWetlevel_DelayWetlevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayWetlevel", SetStereoDelayWetlevel_IsValid);
		SetStereoDelayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayTime");
		SetStereoDelayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayTime_DelayTimeMsec_PropertyAddress, SetStereoDelayTime_FunctionAddress, "DelayTimeMsec");
		SetStereoDelayTime_DelayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayTime_FunctionAddress, "DelayTimeMsec");
		SetStereoDelayTime_DelayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayTime_FunctionAddress, "DelayTimeMsec", Classes.FFloatProperty);
		SetStereoDelayTime_IsValid = SetStereoDelayTime_FunctionAddress != IntPtr.Zero && SetStereoDelayTime_DelayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayTime", SetStereoDelayTime_IsValid);
		SetStereoDelayRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayRatio");
		SetStereoDelayRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayRatio_DelayRatio_PropertyAddress, SetStereoDelayRatio_FunctionAddress, "DelayRatio");
		SetStereoDelayRatio_DelayRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayRatio_FunctionAddress, "DelayRatio");
		SetStereoDelayRatio_DelayRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayRatio_FunctionAddress, "DelayRatio", Classes.FFloatProperty);
		SetStereoDelayRatio_IsValid = SetStereoDelayRatio_FunctionAddress != IntPtr.Zero && SetStereoDelayRatio_DelayRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayRatio", SetStereoDelayRatio_IsValid);
		SetStereoDelayMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayMode");
		SetStereoDelayMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayMode_StereoDelayMode_PropertyAddress, SetStereoDelayMode_FunctionAddress, "StereoDelayMode");
		SetStereoDelayMode_StereoDelayMode_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayMode_FunctionAddress, "StereoDelayMode");
		SetStereoDelayMode_StereoDelayMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayMode_FunctionAddress, "StereoDelayMode", Classes.FEnumProperty);
		SetStereoDelayMode_IsValid = SetStereoDelayMode_FunctionAddress != IntPtr.Zero && SetStereoDelayMode_StereoDelayMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayMode", SetStereoDelayMode_IsValid);
		SetStereoDelayIsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayIsEnabled");
		SetStereoDelayIsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayIsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayIsEnabled_StereoDelayEnabled_PropertyAddress, SetStereoDelayIsEnabled_FunctionAddress, "StereoDelayEnabled");
		SetStereoDelayIsEnabled_StereoDelayEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayIsEnabled_FunctionAddress, "StereoDelayEnabled");
		SetStereoDelayIsEnabled_StereoDelayEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayIsEnabled_FunctionAddress, "StereoDelayEnabled", Classes.FBoolProperty);
		SetStereoDelayIsEnabled_IsValid = SetStereoDelayIsEnabled_FunctionAddress != IntPtr.Zero && SetStereoDelayIsEnabled_StereoDelayEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayIsEnabled", SetStereoDelayIsEnabled_IsValid);
		SetStereoDelayFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStereoDelayFeedback");
		SetStereoDelayFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStereoDelayFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStereoDelayFeedback_DelayFeedback_PropertyAddress, SetStereoDelayFeedback_FunctionAddress, "DelayFeedback");
		SetStereoDelayFeedback_DelayFeedback_Offset = NativeReflectionCached.GetPropertyOffset(SetStereoDelayFeedback_FunctionAddress, "DelayFeedback");
		SetStereoDelayFeedback_DelayFeedback_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStereoDelayFeedback_FunctionAddress, "DelayFeedback", Classes.FFloatProperty);
		SetStereoDelayFeedback_IsValid = SetStereoDelayFeedback_FunctionAddress != IntPtr.Zero && SetStereoDelayFeedback_DelayFeedback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetStereoDelayFeedback", SetStereoDelayFeedback_IsValid);
		SetSpread_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpread");
		SetSpread_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpread_Spread_PropertyAddress, SetSpread_FunctionAddress, "Spread");
		SetSpread_Spread_Offset = NativeReflectionCached.GetPropertyOffset(SetSpread_FunctionAddress, "Spread");
		SetSpread_Spread_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpread_FunctionAddress, "Spread", Classes.FFloatProperty);
		SetSpread_IsValid = SetSpread_FunctionAddress != IntPtr.Zero && SetSpread_Spread_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetSpread", SetSpread_IsValid);
		SetReleaseTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetReleaseTime");
		SetReleaseTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReleaseTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReleaseTime_ReleaseTimeMsec_PropertyAddress, SetReleaseTime_FunctionAddress, "ReleaseTimeMsec");
		SetReleaseTime_ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetReleaseTime_FunctionAddress, "ReleaseTimeMsec");
		SetReleaseTime_ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReleaseTime_FunctionAddress, "ReleaseTimeMsec", Classes.FFloatProperty);
		SetReleaseTime_IsValid = SetReleaseTime_FunctionAddress != IntPtr.Zero && SetReleaseTime_ReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetReleaseTime", SetReleaseTime_IsValid);
		SetPortamento_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPortamento");
		SetPortamento_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPortamento_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPortamento_Portamento_PropertyAddress, SetPortamento_FunctionAddress, "Portamento");
		SetPortamento_Portamento_Offset = NativeReflectionCached.GetPropertyOffset(SetPortamento_FunctionAddress, "Portamento");
		SetPortamento_Portamento_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPortamento_FunctionAddress, "Portamento", Classes.FFloatProperty);
		SetPortamento_IsValid = SetPortamento_FunctionAddress != IntPtr.Zero && SetPortamento_Portamento_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetPortamento", SetPortamento_IsValid);
		SetPitchBend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPitchBend");
		SetPitchBend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPitchBend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPitchBend_PitchBend_PropertyAddress, SetPitchBend_FunctionAddress, "PitchBend");
		SetPitchBend_PitchBend_Offset = NativeReflectionCached.GetPropertyOffset(SetPitchBend_FunctionAddress, "PitchBend");
		SetPitchBend_PitchBend_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPitchBend_FunctionAddress, "PitchBend", Classes.FFloatProperty);
		SetPitchBend_IsValid = SetPitchBend_FunctionAddress != IntPtr.Zero && SetPitchBend_PitchBend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetPitchBend", SetPitchBend_IsValid);
		SetPan_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPan");
		SetPan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPan_Pan_PropertyAddress, SetPan_FunctionAddress, "Pan");
		SetPan_Pan_Offset = NativeReflectionCached.GetPropertyOffset(SetPan_FunctionAddress, "Pan");
		SetPan_Pan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPan_FunctionAddress, "Pan", Classes.FFloatProperty);
		SetPan_IsValid = SetPan_FunctionAddress != IntPtr.Zero && SetPan_Pan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetPan", SetPan_IsValid);
		SetOscType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscType");
		SetOscType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscType_OscIndex_PropertyAddress, SetOscType_FunctionAddress, "OscIndex");
		SetOscType_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscType_FunctionAddress, "OscIndex");
		SetOscType_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscType_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscType_OscType_PropertyAddress, SetOscType_FunctionAddress, "OscType");
		SetOscType_OscType_Offset = NativeReflectionCached.GetPropertyOffset(SetOscType_FunctionAddress, "OscType");
		SetOscType_OscType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscType_FunctionAddress, "OscType", Classes.FEnumProperty);
		SetOscType_IsValid = SetOscType_FunctionAddress != IntPtr.Zero && SetOscType_OscIndex_IsValid && SetOscType_OscType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscType", SetOscType_IsValid);
		SetOscSync_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscSync");
		SetOscSync_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscSync_bIsSynced_PropertyAddress, SetOscSync_FunctionAddress, "bIsSynced");
		SetOscSync_bIsSynced_Offset = NativeReflectionCached.GetPropertyOffset(SetOscSync_FunctionAddress, "bIsSynced");
		SetOscSync_bIsSynced_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscSync_FunctionAddress, "bIsSynced", Classes.FBoolProperty);
		SetOscSync_IsValid = SetOscSync_FunctionAddress != IntPtr.Zero && SetOscSync_bIsSynced_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscSync", SetOscSync_IsValid);
		SetOscSemitones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscSemitones");
		SetOscSemitones_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscSemitones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscSemitones_OscIndex_PropertyAddress, SetOscSemitones_FunctionAddress, "OscIndex");
		SetOscSemitones_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscSemitones_FunctionAddress, "OscIndex");
		SetOscSemitones_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscSemitones_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscSemitones_Semitones_PropertyAddress, SetOscSemitones_FunctionAddress, "Semitones");
		SetOscSemitones_Semitones_Offset = NativeReflectionCached.GetPropertyOffset(SetOscSemitones_FunctionAddress, "Semitones");
		SetOscSemitones_Semitones_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscSemitones_FunctionAddress, "Semitones", Classes.FFloatProperty);
		SetOscSemitones_IsValid = SetOscSemitones_FunctionAddress != IntPtr.Zero && SetOscSemitones_OscIndex_IsValid && SetOscSemitones_Semitones_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscSemitones", SetOscSemitones_IsValid);
		SetOscPulsewidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscPulsewidth");
		SetOscPulsewidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscPulsewidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscPulsewidth_OscIndex_PropertyAddress, SetOscPulsewidth_FunctionAddress, "OscIndex");
		SetOscPulsewidth_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscPulsewidth_FunctionAddress, "OscIndex");
		SetOscPulsewidth_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscPulsewidth_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscPulsewidth_Pulsewidth_PropertyAddress, SetOscPulsewidth_FunctionAddress, "Pulsewidth");
		SetOscPulsewidth_Pulsewidth_Offset = NativeReflectionCached.GetPropertyOffset(SetOscPulsewidth_FunctionAddress, "Pulsewidth");
		SetOscPulsewidth_Pulsewidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscPulsewidth_FunctionAddress, "Pulsewidth", Classes.FFloatProperty);
		SetOscPulsewidth_IsValid = SetOscPulsewidth_FunctionAddress != IntPtr.Zero && SetOscPulsewidth_OscIndex_IsValid && SetOscPulsewidth_Pulsewidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscPulsewidth", SetOscPulsewidth_IsValid);
		SetOscOctave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscOctave");
		SetOscOctave_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscOctave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscOctave_OscIndex_PropertyAddress, SetOscOctave_FunctionAddress, "OscIndex");
		SetOscOctave_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscOctave_FunctionAddress, "OscIndex");
		SetOscOctave_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscOctave_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscOctave_Octave_PropertyAddress, SetOscOctave_FunctionAddress, "Octave");
		SetOscOctave_Octave_Offset = NativeReflectionCached.GetPropertyOffset(SetOscOctave_FunctionAddress, "Octave");
		SetOscOctave_Octave_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscOctave_FunctionAddress, "Octave", Classes.FFloatProperty);
		SetOscOctave_IsValid = SetOscOctave_FunctionAddress != IntPtr.Zero && SetOscOctave_OscIndex_IsValid && SetOscOctave_Octave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscOctave", SetOscOctave_IsValid);
		SetOscGainMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscGainMod");
		SetOscGainMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscGainMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscGainMod_OscIndex_PropertyAddress, SetOscGainMod_FunctionAddress, "OscIndex");
		SetOscGainMod_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscGainMod_FunctionAddress, "OscIndex");
		SetOscGainMod_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscGainMod_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscGainMod_OscGainMod_PropertyAddress, SetOscGainMod_FunctionAddress, "OscGainMod");
		SetOscGainMod_OscGainMod_Offset = NativeReflectionCached.GetPropertyOffset(SetOscGainMod_FunctionAddress, "OscGainMod");
		SetOscGainMod_OscGainMod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscGainMod_FunctionAddress, "OscGainMod", Classes.FFloatProperty);
		SetOscGainMod_IsValid = SetOscGainMod_FunctionAddress != IntPtr.Zero && SetOscGainMod_OscIndex_IsValid && SetOscGainMod_OscGainMod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscGainMod", SetOscGainMod_IsValid);
		SetOscGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscGain");
		SetOscGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscGain_OscIndex_PropertyAddress, SetOscGain_FunctionAddress, "OscIndex");
		SetOscGain_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscGain_FunctionAddress, "OscIndex");
		SetOscGain_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscGain_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscGain_OscGain_PropertyAddress, SetOscGain_FunctionAddress, "OscGain");
		SetOscGain_OscGain_Offset = NativeReflectionCached.GetPropertyOffset(SetOscGain_FunctionAddress, "OscGain");
		SetOscGain_OscGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscGain_FunctionAddress, "OscGain", Classes.FFloatProperty);
		SetOscGain_IsValid = SetOscGain_FunctionAddress != IntPtr.Zero && SetOscGain_OscIndex_IsValid && SetOscGain_OscGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscGain", SetOscGain_IsValid);
		SetOscFrequencyMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscFrequencyMod");
		SetOscFrequencyMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscFrequencyMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscFrequencyMod_OscIndex_PropertyAddress, SetOscFrequencyMod_FunctionAddress, "OscIndex");
		SetOscFrequencyMod_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscFrequencyMod_FunctionAddress, "OscIndex");
		SetOscFrequencyMod_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscFrequencyMod_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscFrequencyMod_OscFreqMod_PropertyAddress, SetOscFrequencyMod_FunctionAddress, "OscFreqMod");
		SetOscFrequencyMod_OscFreqMod_Offset = NativeReflectionCached.GetPropertyOffset(SetOscFrequencyMod_FunctionAddress, "OscFreqMod");
		SetOscFrequencyMod_OscFreqMod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscFrequencyMod_FunctionAddress, "OscFreqMod", Classes.FFloatProperty);
		SetOscFrequencyMod_IsValid = SetOscFrequencyMod_FunctionAddress != IntPtr.Zero && SetOscFrequencyMod_OscIndex_IsValid && SetOscFrequencyMod_OscFreqMod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscFrequencyMod", SetOscFrequencyMod_IsValid);
		SetOscCents_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOscCents");
		SetOscCents_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOscCents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOscCents_OscIndex_PropertyAddress, SetOscCents_FunctionAddress, "OscIndex");
		SetOscCents_OscIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetOscCents_FunctionAddress, "OscIndex");
		SetOscCents_OscIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscCents_FunctionAddress, "OscIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOscCents_Cents_PropertyAddress, SetOscCents_FunctionAddress, "Cents");
		SetOscCents_Cents_Offset = NativeReflectionCached.GetPropertyOffset(SetOscCents_FunctionAddress, "Cents");
		SetOscCents_Cents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOscCents_FunctionAddress, "Cents", Classes.FFloatProperty);
		SetOscCents_IsValid = SetOscCents_FunctionAddress != IntPtr.Zero && SetOscCents_OscIndex_IsValid && SetOscCents_Cents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetOscCents", SetOscCents_IsValid);
		SetModEnvSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvSustainGain");
		SetModEnvSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvSustainGain_SustainGain_PropertyAddress, SetModEnvSustainGain_FunctionAddress, "SustainGain");
		SetModEnvSustainGain_SustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvSustainGain_FunctionAddress, "SustainGain");
		SetModEnvSustainGain_SustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvSustainGain_FunctionAddress, "SustainGain", Classes.FFloatProperty);
		SetModEnvSustainGain_IsValid = SetModEnvSustainGain_FunctionAddress != IntPtr.Zero && SetModEnvSustainGain_SustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvSustainGain", SetModEnvSustainGain_IsValid);
		SetModEnvReleaseTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvReleaseTime");
		SetModEnvReleaseTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvReleaseTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvReleaseTime_Release_PropertyAddress, SetModEnvReleaseTime_FunctionAddress, "Release");
		SetModEnvReleaseTime_Release_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvReleaseTime_FunctionAddress, "Release");
		SetModEnvReleaseTime_Release_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvReleaseTime_FunctionAddress, "Release", Classes.FFloatProperty);
		SetModEnvReleaseTime_IsValid = SetModEnvReleaseTime_FunctionAddress != IntPtr.Zero && SetModEnvReleaseTime_Release_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvReleaseTime", SetModEnvReleaseTime_IsValid);
		SetModEnvPatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvPatch");
		SetModEnvPatch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvPatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvPatch_InPatchType_PropertyAddress, SetModEnvPatch_FunctionAddress, "InPatchType");
		SetModEnvPatch_InPatchType_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvPatch_FunctionAddress, "InPatchType");
		SetModEnvPatch_InPatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvPatch_FunctionAddress, "InPatchType", Classes.FEnumProperty);
		SetModEnvPatch_IsValid = SetModEnvPatch_FunctionAddress != IntPtr.Zero && SetModEnvPatch_InPatchType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvPatch", SetModEnvPatch_IsValid);
		SetModEnvInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvInvert");
		SetModEnvInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvInvert_bInvert_PropertyAddress, SetModEnvInvert_FunctionAddress, "bInvert");
		SetModEnvInvert_bInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvInvert_FunctionAddress, "bInvert");
		SetModEnvInvert_bInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvInvert_FunctionAddress, "bInvert", Classes.FBoolProperty);
		SetModEnvInvert_IsValid = SetModEnvInvert_FunctionAddress != IntPtr.Zero && SetModEnvInvert_bInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvInvert", SetModEnvInvert_IsValid);
		SetModEnvDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvDepth");
		SetModEnvDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvDepth_Depth_PropertyAddress, SetModEnvDepth_FunctionAddress, "Depth");
		SetModEnvDepth_Depth_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvDepth_FunctionAddress, "Depth");
		SetModEnvDepth_Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvDepth_FunctionAddress, "Depth", Classes.FFloatProperty);
		SetModEnvDepth_IsValid = SetModEnvDepth_FunctionAddress != IntPtr.Zero && SetModEnvDepth_Depth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvDepth", SetModEnvDepth_IsValid);
		SetModEnvDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvDecayTime");
		SetModEnvDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvDecayTime_DecayTimeMsec_PropertyAddress, SetModEnvDecayTime_FunctionAddress, "DecayTimeMsec");
		SetModEnvDecayTime_DecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvDecayTime_FunctionAddress, "DecayTimeMsec");
		SetModEnvDecayTime_DecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvDecayTime_FunctionAddress, "DecayTimeMsec", Classes.FFloatProperty);
		SetModEnvDecayTime_IsValid = SetModEnvDecayTime_FunctionAddress != IntPtr.Zero && SetModEnvDecayTime_DecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvDecayTime", SetModEnvDecayTime_IsValid);
		SetModEnvBiasPatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvBiasPatch");
		SetModEnvBiasPatch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvBiasPatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvBiasPatch_InPatchType_PropertyAddress, SetModEnvBiasPatch_FunctionAddress, "InPatchType");
		SetModEnvBiasPatch_InPatchType_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvBiasPatch_FunctionAddress, "InPatchType");
		SetModEnvBiasPatch_InPatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvBiasPatch_FunctionAddress, "InPatchType", Classes.FEnumProperty);
		SetModEnvBiasPatch_IsValid = SetModEnvBiasPatch_FunctionAddress != IntPtr.Zero && SetModEnvBiasPatch_InPatchType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasPatch", SetModEnvBiasPatch_IsValid);
		SetModEnvBiasInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvBiasInvert");
		SetModEnvBiasInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvBiasInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvBiasInvert_bInvert_PropertyAddress, SetModEnvBiasInvert_FunctionAddress, "bInvert");
		SetModEnvBiasInvert_bInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvBiasInvert_FunctionAddress, "bInvert");
		SetModEnvBiasInvert_bInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvBiasInvert_FunctionAddress, "bInvert", Classes.FBoolProperty);
		SetModEnvBiasInvert_IsValid = SetModEnvBiasInvert_FunctionAddress != IntPtr.Zero && SetModEnvBiasInvert_bInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvBiasInvert", SetModEnvBiasInvert_IsValid);
		SetModEnvAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetModEnvAttackTime");
		SetModEnvAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetModEnvAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetModEnvAttackTime_AttackTimeMsec_PropertyAddress, SetModEnvAttackTime_FunctionAddress, "AttackTimeMsec");
		SetModEnvAttackTime_AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetModEnvAttackTime_FunctionAddress, "AttackTimeMsec");
		SetModEnvAttackTime_AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetModEnvAttackTime_FunctionAddress, "AttackTimeMsec", Classes.FFloatProperty);
		SetModEnvAttackTime_IsValid = SetModEnvAttackTime_FunctionAddress != IntPtr.Zero && SetModEnvAttackTime_AttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetModEnvAttackTime", SetModEnvAttackTime_IsValid);
		SetLFOType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOType");
		SetLFOType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOType_LFOIndex_PropertyAddress, SetLFOType_FunctionAddress, "LFOIndex");
		SetLFOType_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOType_FunctionAddress, "LFOIndex");
		SetLFOType_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOType_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOType_LFOType_PropertyAddress, SetLFOType_FunctionAddress, "LFOType");
		SetLFOType_LFOType_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOType_FunctionAddress, "LFOType");
		SetLFOType_LFOType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOType_FunctionAddress, "LFOType", Classes.FEnumProperty);
		SetLFOType_IsValid = SetLFOType_FunctionAddress != IntPtr.Zero && SetLFOType_LFOIndex_IsValid && SetLFOType_LFOType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOType", SetLFOType_IsValid);
		SetLFOPatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOPatch");
		SetLFOPatch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOPatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOPatch_LFOIndex_PropertyAddress, SetLFOPatch_FunctionAddress, "LFOIndex");
		SetLFOPatch_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOPatch_FunctionAddress, "LFOIndex");
		SetLFOPatch_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOPatch_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOPatch_LFOPatchType_PropertyAddress, SetLFOPatch_FunctionAddress, "LFOPatchType");
		SetLFOPatch_LFOPatchType_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOPatch_FunctionAddress, "LFOPatchType");
		SetLFOPatch_LFOPatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOPatch_FunctionAddress, "LFOPatchType", Classes.FEnumProperty);
		SetLFOPatch_IsValid = SetLFOPatch_FunctionAddress != IntPtr.Zero && SetLFOPatch_LFOIndex_IsValid && SetLFOPatch_LFOPatchType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOPatch", SetLFOPatch_IsValid);
		SetLFOMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOMode");
		SetLFOMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOMode_LFOIndex_PropertyAddress, SetLFOMode_FunctionAddress, "LFOIndex");
		SetLFOMode_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOMode_FunctionAddress, "LFOIndex");
		SetLFOMode_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOMode_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOMode_LFOMode_PropertyAddress, SetLFOMode_FunctionAddress, "LFOMode");
		SetLFOMode_LFOMode_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOMode_FunctionAddress, "LFOMode");
		SetLFOMode_LFOMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOMode_FunctionAddress, "LFOMode", Classes.FEnumProperty);
		SetLFOMode_IsValid = SetLFOMode_FunctionAddress != IntPtr.Zero && SetLFOMode_LFOIndex_IsValid && SetLFOMode_LFOMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOMode", SetLFOMode_IsValid);
		SetLFOGainMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOGainMod");
		SetLFOGainMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOGainMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOGainMod_LFOIndex_PropertyAddress, SetLFOGainMod_FunctionAddress, "LFOIndex");
		SetLFOGainMod_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOGainMod_FunctionAddress, "LFOIndex");
		SetLFOGainMod_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOGainMod_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOGainMod_GainMod_PropertyAddress, SetLFOGainMod_FunctionAddress, "GainMod");
		SetLFOGainMod_GainMod_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOGainMod_FunctionAddress, "GainMod");
		SetLFOGainMod_GainMod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOGainMod_FunctionAddress, "GainMod", Classes.FFloatProperty);
		SetLFOGainMod_IsValid = SetLFOGainMod_FunctionAddress != IntPtr.Zero && SetLFOGainMod_LFOIndex_IsValid && SetLFOGainMod_GainMod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOGainMod", SetLFOGainMod_IsValid);
		SetLFOGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOGain");
		SetLFOGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOGain_LFOIndex_PropertyAddress, SetLFOGain_FunctionAddress, "LFOIndex");
		SetLFOGain_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOGain_FunctionAddress, "LFOIndex");
		SetLFOGain_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOGain_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOGain_Gain_PropertyAddress, SetLFOGain_FunctionAddress, "Gain");
		SetLFOGain_Gain_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOGain_FunctionAddress, "Gain");
		SetLFOGain_Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOGain_FunctionAddress, "Gain", Classes.FFloatProperty);
		SetLFOGain_IsValid = SetLFOGain_FunctionAddress != IntPtr.Zero && SetLFOGain_LFOIndex_IsValid && SetLFOGain_Gain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOGain", SetLFOGain_IsValid);
		SetLFOFrequencyMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOFrequencyMod");
		SetLFOFrequencyMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOFrequencyMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOFrequencyMod_LFOIndex_PropertyAddress, SetLFOFrequencyMod_FunctionAddress, "LFOIndex");
		SetLFOFrequencyMod_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOFrequencyMod_FunctionAddress, "LFOIndex");
		SetLFOFrequencyMod_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOFrequencyMod_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOFrequencyMod_FrequencyModHz_PropertyAddress, SetLFOFrequencyMod_FunctionAddress, "FrequencyModHz");
		SetLFOFrequencyMod_FrequencyModHz_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOFrequencyMod_FunctionAddress, "FrequencyModHz");
		SetLFOFrequencyMod_FrequencyModHz_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOFrequencyMod_FunctionAddress, "FrequencyModHz", Classes.FFloatProperty);
		SetLFOFrequencyMod_IsValid = SetLFOFrequencyMod_FunctionAddress != IntPtr.Zero && SetLFOFrequencyMod_LFOIndex_IsValid && SetLFOFrequencyMod_FrequencyModHz_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOFrequencyMod", SetLFOFrequencyMod_IsValid);
		SetLFOFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLFOFrequency");
		SetLFOFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLFOFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLFOFrequency_LFOIndex_PropertyAddress, SetLFOFrequency_FunctionAddress, "LFOIndex");
		SetLFOFrequency_LFOIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOFrequency_FunctionAddress, "LFOIndex");
		SetLFOFrequency_LFOIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOFrequency_FunctionAddress, "LFOIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLFOFrequency_FrequencyHz_PropertyAddress, SetLFOFrequency_FunctionAddress, "FrequencyHz");
		SetLFOFrequency_FrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(SetLFOFrequency_FunctionAddress, "FrequencyHz");
		SetLFOFrequency_FrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLFOFrequency_FunctionAddress, "FrequencyHz", Classes.FFloatProperty);
		SetLFOFrequency_IsValid = SetLFOFrequency_FunctionAddress != IntPtr.Zero && SetLFOFrequency_LFOIndex_IsValid && SetLFOFrequency_FrequencyHz_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetLFOFrequency", SetLFOFrequency_IsValid);
		SetGainDb_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGainDb");
		SetGainDb_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGainDb_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGainDb_GainDb_PropertyAddress, SetGainDb_FunctionAddress, "GainDb");
		SetGainDb_GainDb_Offset = NativeReflectionCached.GetPropertyOffset(SetGainDb_FunctionAddress, "GainDb");
		SetGainDb_GainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGainDb_FunctionAddress, "GainDb", Classes.FFloatProperty);
		SetGainDb_IsValid = SetGainDb_FunctionAddress != IntPtr.Zero && SetGainDb_GainDb_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetGainDb", SetGainDb_IsValid);
		SetFilterType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterType");
		SetFilterType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterType_FilterType_PropertyAddress, SetFilterType_FunctionAddress, "FilterType");
		SetFilterType_FilterType_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterType_FunctionAddress, "FilterType");
		SetFilterType_FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterType_FunctionAddress, "FilterType", Classes.FEnumProperty);
		SetFilterType_IsValid = SetFilterType_FunctionAddress != IntPtr.Zero && SetFilterType_FilterType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterType", SetFilterType_IsValid);
		SetFilterQMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterQMod");
		SetFilterQMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterQMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterQMod_FilterQ_PropertyAddress, SetFilterQMod_FunctionAddress, "FilterQ");
		SetFilterQMod_FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterQMod_FunctionAddress, "FilterQ");
		SetFilterQMod_FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterQMod_FunctionAddress, "FilterQ", Classes.FFloatProperty);
		SetFilterQMod_IsValid = SetFilterQMod_FunctionAddress != IntPtr.Zero && SetFilterQMod_FilterQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterQMod", SetFilterQMod_IsValid);
		SetFilterQ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterQ");
		SetFilterQ_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterQ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterQ_FilterQ_PropertyAddress, SetFilterQ_FunctionAddress, "FilterQ");
		SetFilterQ_FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterQ_FunctionAddress, "FilterQ");
		SetFilterQ_FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterQ_FunctionAddress, "FilterQ", Classes.FFloatProperty);
		SetFilterQ_IsValid = SetFilterQ_FunctionAddress != IntPtr.Zero && SetFilterQ_FilterQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterQ", SetFilterQ_IsValid);
		SetFilterFrequencyMod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterFrequencyMod");
		SetFilterFrequencyMod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterFrequencyMod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterFrequencyMod_FilterFrequencyHz_PropertyAddress, SetFilterFrequencyMod_FunctionAddress, "FilterFrequencyHz");
		SetFilterFrequencyMod_FilterFrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterFrequencyMod_FunctionAddress, "FilterFrequencyHz");
		SetFilterFrequencyMod_FilterFrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterFrequencyMod_FunctionAddress, "FilterFrequencyHz", Classes.FFloatProperty);
		SetFilterFrequencyMod_IsValid = SetFilterFrequencyMod_FunctionAddress != IntPtr.Zero && SetFilterFrequencyMod_FilterFrequencyHz_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterFrequencyMod", SetFilterFrequencyMod_IsValid);
		SetFilterFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterFrequency");
		SetFilterFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterFrequency_FilterFrequencyHz_PropertyAddress, SetFilterFrequency_FunctionAddress, "FilterFrequencyHz");
		SetFilterFrequency_FilterFrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterFrequency_FunctionAddress, "FilterFrequencyHz");
		SetFilterFrequency_FilterFrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterFrequency_FunctionAddress, "FilterFrequencyHz", Classes.FFloatProperty);
		SetFilterFrequency_IsValid = SetFilterFrequency_FunctionAddress != IntPtr.Zero && SetFilterFrequency_FilterFrequencyHz_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterFrequency", SetFilterFrequency_IsValid);
		SetFilterAlgorithm_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterAlgorithm");
		SetFilterAlgorithm_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterAlgorithm_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterAlgorithm_FilterAlgorithm_PropertyAddress, SetFilterAlgorithm_FunctionAddress, "FilterAlgorithm");
		SetFilterAlgorithm_FilterAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterAlgorithm_FunctionAddress, "FilterAlgorithm");
		SetFilterAlgorithm_FilterAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterAlgorithm_FunctionAddress, "FilterAlgorithm", Classes.FEnumProperty);
		SetFilterAlgorithm_IsValid = SetFilterAlgorithm_FunctionAddress != IntPtr.Zero && SetFilterAlgorithm_FilterAlgorithm_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetFilterAlgorithm", SetFilterAlgorithm_IsValid);
		SetEnableUnison_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableUnison");
		SetEnableUnison_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableUnison_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableUnison_EnableUnison_PropertyAddress, SetEnableUnison_FunctionAddress, "EnableUnison");
		SetEnableUnison_EnableUnison_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableUnison_FunctionAddress, "EnableUnison");
		SetEnableUnison_EnableUnison_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableUnison_FunctionAddress, "EnableUnison", Classes.FBoolProperty);
		SetEnableUnison_IsValid = SetEnableUnison_FunctionAddress != IntPtr.Zero && SetEnableUnison_EnableUnison_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetEnableUnison", SetEnableUnison_IsValid);
		SetEnableRetrigger_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableRetrigger");
		SetEnableRetrigger_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableRetrigger_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableRetrigger_RetriggerEnabled_PropertyAddress, SetEnableRetrigger_FunctionAddress, "RetriggerEnabled");
		SetEnableRetrigger_RetriggerEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableRetrigger_FunctionAddress, "RetriggerEnabled");
		SetEnableRetrigger_RetriggerEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableRetrigger_FunctionAddress, "RetriggerEnabled", Classes.FBoolProperty);
		SetEnableRetrigger_IsValid = SetEnableRetrigger_FunctionAddress != IntPtr.Zero && SetEnableRetrigger_RetriggerEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetEnableRetrigger", SetEnableRetrigger_IsValid);
		SetEnablePolyphony_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnablePolyphony");
		SetEnablePolyphony_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnablePolyphony_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnablePolyphony_bEnablePolyphony_PropertyAddress, SetEnablePolyphony_FunctionAddress, "bEnablePolyphony");
		SetEnablePolyphony_bEnablePolyphony_Offset = NativeReflectionCached.GetPropertyOffset(SetEnablePolyphony_FunctionAddress, "bEnablePolyphony");
		SetEnablePolyphony_bEnablePolyphony_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnablePolyphony_FunctionAddress, "bEnablePolyphony", Classes.FBoolProperty);
		SetEnablePolyphony_IsValid = SetEnablePolyphony_FunctionAddress != IntPtr.Zero && SetEnablePolyphony_bEnablePolyphony_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetEnablePolyphony", SetEnablePolyphony_IsValid);
		SetEnablePatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnablePatch");
		SetEnablePatch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnablePatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnablePatch_PatchId_PropertyAddress, SetEnablePatch_FunctionAddress, "PatchId");
		SetEnablePatch_PatchId_Offset = NativeReflectionCached.GetPropertyOffset(SetEnablePatch_FunctionAddress, "PatchId");
		SetEnablePatch_PatchId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnablePatch_FunctionAddress, "PatchId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnablePatch_bIsEnabled_PropertyAddress, SetEnablePatch_FunctionAddress, "bIsEnabled");
		SetEnablePatch_bIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnablePatch_FunctionAddress, "bIsEnabled");
		SetEnablePatch_bIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnablePatch_FunctionAddress, "bIsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnablePatch_ReturnValue_PropertyAddress, SetEnablePatch_FunctionAddress, "ReturnValue");
		SetEnablePatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEnablePatch_FunctionAddress, "ReturnValue");
		SetEnablePatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnablePatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetEnablePatch_IsValid = SetEnablePatch_FunctionAddress != IntPtr.Zero && SetEnablePatch_PatchId_IsValid && SetEnablePatch_bIsEnabled_IsValid && SetEnablePatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetEnablePatch", SetEnablePatch_IsValid);
		SetEnableLegato_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableLegato");
		SetEnableLegato_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableLegato_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableLegato_LegatoEnabled_PropertyAddress, SetEnableLegato_FunctionAddress, "LegatoEnabled");
		SetEnableLegato_LegatoEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableLegato_FunctionAddress, "LegatoEnabled");
		SetEnableLegato_LegatoEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableLegato_FunctionAddress, "LegatoEnabled", Classes.FBoolProperty);
		SetEnableLegato_IsValid = SetEnableLegato_FunctionAddress != IntPtr.Zero && SetEnableLegato_LegatoEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetEnableLegato", SetEnableLegato_IsValid);
		SetDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDecayTime");
		SetDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDecayTime_DecayTimeMsec_PropertyAddress, SetDecayTime_FunctionAddress, "DecayTimeMsec");
		SetDecayTime_DecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetDecayTime_FunctionAddress, "DecayTimeMsec");
		SetDecayTime_DecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDecayTime_FunctionAddress, "DecayTimeMsec", Classes.FFloatProperty);
		SetDecayTime_IsValid = SetDecayTime_FunctionAddress != IntPtr.Zero && SetDecayTime_DecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetDecayTime", SetDecayTime_IsValid);
		SetChorusFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetChorusFrequency");
		SetChorusFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChorusFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChorusFrequency_Frequency_PropertyAddress, SetChorusFrequency_FunctionAddress, "Frequency");
		SetChorusFrequency_Frequency_Offset = NativeReflectionCached.GetPropertyOffset(SetChorusFrequency_FunctionAddress, "Frequency");
		SetChorusFrequency_Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChorusFrequency_FunctionAddress, "Frequency", Classes.FFloatProperty);
		SetChorusFrequency_IsValid = SetChorusFrequency_FunctionAddress != IntPtr.Zero && SetChorusFrequency_Frequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetChorusFrequency", SetChorusFrequency_IsValid);
		SetChorusFeedback_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetChorusFeedback");
		SetChorusFeedback_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChorusFeedback_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChorusFeedback_Feedback_PropertyAddress, SetChorusFeedback_FunctionAddress, "Feedback");
		SetChorusFeedback_Feedback_Offset = NativeReflectionCached.GetPropertyOffset(SetChorusFeedback_FunctionAddress, "Feedback");
		SetChorusFeedback_Feedback_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChorusFeedback_FunctionAddress, "Feedback", Classes.FFloatProperty);
		SetChorusFeedback_IsValid = SetChorusFeedback_FunctionAddress != IntPtr.Zero && SetChorusFeedback_Feedback_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetChorusFeedback", SetChorusFeedback_IsValid);
		SetChorusEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetChorusEnabled");
		SetChorusEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChorusEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChorusEnabled_EnableChorus_PropertyAddress, SetChorusEnabled_FunctionAddress, "EnableChorus");
		SetChorusEnabled_EnableChorus_Offset = NativeReflectionCached.GetPropertyOffset(SetChorusEnabled_FunctionAddress, "EnableChorus");
		SetChorusEnabled_EnableChorus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChorusEnabled_FunctionAddress, "EnableChorus", Classes.FBoolProperty);
		SetChorusEnabled_IsValid = SetChorusEnabled_FunctionAddress != IntPtr.Zero && SetChorusEnabled_EnableChorus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetChorusEnabled", SetChorusEnabled_IsValid);
		SetChorusDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetChorusDepth");
		SetChorusDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetChorusDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetChorusDepth_Depth_PropertyAddress, SetChorusDepth_FunctionAddress, "Depth");
		SetChorusDepth_Depth_Offset = NativeReflectionCached.GetPropertyOffset(SetChorusDepth_FunctionAddress, "Depth");
		SetChorusDepth_Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetChorusDepth_FunctionAddress, "Depth", Classes.FFloatProperty);
		SetChorusDepth_IsValid = SetChorusDepth_FunctionAddress != IntPtr.Zero && SetChorusDepth_Depth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetChorusDepth", SetChorusDepth_IsValid);
		SetAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAttackTime");
		SetAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttackTime_AttackTimeMsec_PropertyAddress, SetAttackTime_FunctionAddress, "AttackTimeMsec");
		SetAttackTime_AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetAttackTime_FunctionAddress, "AttackTimeMsec");
		SetAttackTime_AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttackTime_FunctionAddress, "AttackTimeMsec", Classes.FFloatProperty);
		SetAttackTime_IsValid = SetAttackTime_FunctionAddress != IntPtr.Zero && SetAttackTime_AttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:SetAttackTime", SetAttackTime_IsValid);
		NoteOn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NoteOn");
		NoteOn_ParamsSize = NativeReflection.GetFunctionParamsSize(NoteOn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoteOn_Note_PropertyAddress, NoteOn_FunctionAddress, "Note");
		NoteOn_Note_Offset = NativeReflectionCached.GetPropertyOffset(NoteOn_FunctionAddress, "Note");
		NoteOn_Note_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOn_FunctionAddress, "Note", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOn_Velocity_PropertyAddress, NoteOn_FunctionAddress, "Velocity");
		NoteOn_Velocity_Offset = NativeReflectionCached.GetPropertyOffset(NoteOn_FunctionAddress, "Velocity");
		NoteOn_Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOn_FunctionAddress, "Velocity", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOn_Duration_PropertyAddress, NoteOn_FunctionAddress, "Duration");
		NoteOn_Duration_Offset = NativeReflectionCached.GetPropertyOffset(NoteOn_FunctionAddress, "Duration");
		NoteOn_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOn_FunctionAddress, "Duration", Classes.FFloatProperty);
		NoteOn_IsValid = NoteOn_FunctionAddress != IntPtr.Zero && NoteOn_Note_IsValid && NoteOn_Velocity_IsValid && NoteOn_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:NoteOn", NoteOn_IsValid);
		NoteOff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NoteOff");
		NoteOff_ParamsSize = NativeReflection.GetFunctionParamsSize(NoteOff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_Note_PropertyAddress, NoteOff_FunctionAddress, "Note");
		NoteOff_Note_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "Note");
		NoteOff_Note_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "Note", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_bAllNotesOff_PropertyAddress, NoteOff_FunctionAddress, "bAllNotesOff");
		NoteOff_bAllNotesOff_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "bAllNotesOff");
		NoteOff_bAllNotesOff_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "bAllNotesOff", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_bKillAllNotes_PropertyAddress, NoteOff_FunctionAddress, "bKillAllNotes");
		NoteOff_bKillAllNotes_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "bKillAllNotes");
		NoteOff_bKillAllNotes_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "bKillAllNotes", Classes.FBoolProperty);
		NoteOff_IsValid = NoteOff_FunctionAddress != IntPtr.Zero && NoteOff_Note_IsValid && NoteOff_bAllNotesOff_IsValid && NoteOff_bKillAllNotes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:NoteOff", NoteOff_IsValid);
		CreatePatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CreatePatch");
		CreatePatch_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePatch_PatchSource_PropertyAddress, CreatePatch_FunctionAddress, "PatchSource");
		CreatePatch_PatchSource_Offset = NativeReflectionCached.GetPropertyOffset(CreatePatch_FunctionAddress, "PatchSource");
		CreatePatch_PatchSource_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePatch_FunctionAddress, "PatchSource", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePatch_PatchCables_PropertyAddress, CreatePatch_FunctionAddress, "PatchCables");
		CreatePatch_PatchCables_Offset = NativeReflectionCached.GetPropertyOffset(CreatePatch_FunctionAddress, "PatchCables");
		CreatePatch_PatchCables_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePatch_FunctionAddress, "PatchCables", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePatch_bEnableByDefault_PropertyAddress, CreatePatch_FunctionAddress, "bEnableByDefault");
		CreatePatch_bEnableByDefault_Offset = NativeReflectionCached.GetPropertyOffset(CreatePatch_FunctionAddress, "bEnableByDefault");
		CreatePatch_bEnableByDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePatch_FunctionAddress, "bEnableByDefault", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePatch_ReturnValue_PropertyAddress, CreatePatch_FunctionAddress, "ReturnValue");
		CreatePatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreatePatch_FunctionAddress, "ReturnValue");
		CreatePatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePatch_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreatePatch_IsValid = CreatePatch_FunctionAddress != IntPtr.Zero && CreatePatch_PatchSource_IsValid && CreatePatch_PatchCables_IsValid && CreatePatch_bEnableByDefault_IsValid && CreatePatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.ModularSynthComponent:CreatePatch", CreatePatch_IsValid);
	}
}
