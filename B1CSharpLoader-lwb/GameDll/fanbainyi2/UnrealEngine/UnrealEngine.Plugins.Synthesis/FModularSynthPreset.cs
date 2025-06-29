using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ModularSynthPreset", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FModularSynthPreset
{
	private static bool EnablePolyphony_IsValid;

	private static FFieldAddress EnablePolyphony_PropertyAddress;

	private static int EnablePolyphony_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bEnablePolyphony")]
	public bool EnablePolyphony;

	private static bool Osc1Type_IsValid;

	private static FFieldAddress Osc1Type_PropertyAddress;

	private static int Osc1Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1Type")]
	public ESynth1OscType Osc1Type;

	private static bool Osc1Gain_IsValid;

	private static int Osc1Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1Gain")]
	public float Osc1Gain;

	private static bool Osc1Octave_IsValid;

	private static int Osc1Octave_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1Octave")]
	public float Osc1Octave;

	private static bool Osc1Semitones_IsValid;

	private static int Osc1Semitones_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1Semitones")]
	public float Osc1Semitones;

	private static bool Osc1Cents_IsValid;

	private static int Osc1Cents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1Cents")]
	public float Osc1Cents;

	private static bool Osc1PulseWidth_IsValid;

	private static int Osc1PulseWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc1PulseWidth")]
	public float Osc1PulseWidth;

	private static bool Osc2Type_IsValid;

	private static FFieldAddress Osc2Type_PropertyAddress;

	private static int Osc2Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2Type")]
	public ESynth1OscType Osc2Type;

	private static bool Osc2Gain_IsValid;

	private static int Osc2Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2Gain")]
	public float Osc2Gain;

	private static bool Osc2Octave_IsValid;

	private static int Osc2Octave_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2Octave")]
	public float Osc2Octave;

	private static bool Osc2Semitones_IsValid;

	private static int Osc2Semitones_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2Semitones")]
	public float Osc2Semitones;

	private static bool Osc2Cents_IsValid;

	private static int Osc2Cents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2Cents")]
	public float Osc2Cents;

	private static bool Osc2PulseWidth_IsValid;

	private static int Osc2PulseWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Osc2PulseWidth")]
	public float Osc2PulseWidth;

	private static bool Portamento_IsValid;

	private static int Portamento_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Portamento")]
	public float Portamento;

	private static bool EnableUnison_IsValid;

	private static FFieldAddress EnableUnison_PropertyAddress;

	private static int EnableUnison_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bEnableUnison")]
	public bool EnableUnison;

	private static bool EnableOscillatorSync_IsValid;

	private static FFieldAddress EnableOscillatorSync_PropertyAddress;

	private static int EnableOscillatorSync_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bEnableOscillatorSync")]
	public bool EnableOscillatorSync;

	private static bool Spread_IsValid;

	private static int Spread_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Spread")]
	public float Spread;

	private static bool Pan_IsValid;

	private static int Pan_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Pan")]
	public float Pan;

	private static bool LFO1Frequency_IsValid;

	private static int LFO1Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO1Frequency")]
	public float LFO1Frequency;

	private static bool LFO1Gain_IsValid;

	private static int LFO1Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO1Gain")]
	public float LFO1Gain;

	private static bool LFO1Type_IsValid;

	private static FFieldAddress LFO1Type_PropertyAddress;

	private static int LFO1Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO1Type")]
	public ESynthLFOType LFO1Type;

	private static bool LFO1Mode_IsValid;

	private static FFieldAddress LFO1Mode_PropertyAddress;

	private static int LFO1Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO1Mode")]
	public ESynthLFOMode LFO1Mode;

	private static bool LFO1PatchType_IsValid;

	private static FFieldAddress LFO1PatchType_PropertyAddress;

	private static int LFO1PatchType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO1PatchType")]
	public ESynthLFOPatchType LFO1PatchType;

	private static bool LFO2Frequency_IsValid;

	private static int LFO2Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO2Frequency")]
	public float LFO2Frequency;

	private static bool LFO2Gain_IsValid;

	private static int LFO2Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO2Gain")]
	public float LFO2Gain;

	private static bool LFO2Type_IsValid;

	private static FFieldAddress LFO2Type_PropertyAddress;

	private static int LFO2Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO2Type")]
	public ESynthLFOType LFO2Type;

	private static bool LFO2Mode_IsValid;

	private static FFieldAddress LFO2Mode_PropertyAddress;

	private static int LFO2Mode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO2Mode")]
	public ESynthLFOMode LFO2Mode;

	private static bool LFO2PatchType_IsValid;

	private static FFieldAddress LFO2PatchType_PropertyAddress;

	private static int LFO2PatchType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:LFO2PatchType")]
	public ESynthLFOPatchType LFO2PatchType;

	private static bool GainDb_IsValid;

	private static int GainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:GainDb")]
	public float GainDb;

	private static bool AttackTime_IsValid;

	private static int AttackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:AttackTime")]
	public float AttackTime;

	private static bool DecayTime_IsValid;

	private static int DecayTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:DecayTime")]
	public float DecayTime;

	private static bool SustainGain_IsValid;

	private static int SustainGain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:SustainGain")]
	public float SustainGain;

	private static bool ReleaseTime_IsValid;

	private static int ReleaseTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ReleaseTime")]
	public float ReleaseTime;

	private static bool ModEnvPatchType_IsValid;

	private static FFieldAddress ModEnvPatchType_PropertyAddress;

	private static int ModEnvPatchType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModEnvPatchType")]
	public ESynthModEnvPatch ModEnvPatchType;

	private static bool ModEnvBiasPatchType_IsValid;

	private static FFieldAddress ModEnvBiasPatchType_PropertyAddress;

	private static int ModEnvBiasPatchType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModEnvBiasPatchType")]
	public ESynthModEnvBiasPatch ModEnvBiasPatchType;

	private static bool InvertModulationEnvelope_IsValid;

	private static FFieldAddress InvertModulationEnvelope_PropertyAddress;

	private static int InvertModulationEnvelope_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bInvertModulationEnvelope")]
	public bool InvertModulationEnvelope;

	private static bool InvertModulationEnvelopeBias_IsValid;

	private static FFieldAddress InvertModulationEnvelopeBias_PropertyAddress;

	private static int InvertModulationEnvelopeBias_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bInvertModulationEnvelopeBias")]
	public bool InvertModulationEnvelopeBias;

	private static bool ModulationEnvelopeDepth_IsValid;

	private static int ModulationEnvelopeDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModulationEnvelopeDepth")]
	public float ModulationEnvelopeDepth;

	private static bool ModulationEnvelopeAttackTime_IsValid;

	private static int ModulationEnvelopeAttackTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModulationEnvelopeAttackTime")]
	public float ModulationEnvelopeAttackTime;

	private static bool ModulationEnvelopeDecayTime_IsValid;

	private static int ModulationEnvelopeDecayTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModulationEnvelopeDecayTime")]
	public float ModulationEnvelopeDecayTime;

	private static bool ModulationEnvelopeSustainGain_IsValid;

	private static int ModulationEnvelopeSustainGain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModulationEnvelopeSustainGain")]
	public float ModulationEnvelopeSustainGain;

	private static bool ModulationEnvelopeReleaseTime_IsValid;

	private static int ModulationEnvelopeReleaseTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ModulationEnvelopeReleaseTime")]
	public float ModulationEnvelopeReleaseTime;

	private static bool Legato_IsValid;

	private static FFieldAddress Legato_PropertyAddress;

	private static int Legato_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bLegato")]
	public bool Legato;

	private static bool Retrigger_IsValid;

	private static FFieldAddress Retrigger_PropertyAddress;

	private static int Retrigger_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bRetrigger")]
	public bool Retrigger;

	private static bool FilterFrequency_IsValid;

	private static int FilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:FilterFrequency")]
	public float FilterFrequency;

	private static bool FilterQ_IsValid;

	private static int FilterQ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:FilterQ")]
	public float FilterQ;

	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:FilterType")]
	public ESynthFilterType FilterType;

	private static bool FilterAlgorithm_IsValid;

	private static FFieldAddress FilterAlgorithm_PropertyAddress;

	private static int FilterAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:FilterAlgorithm")]
	public ESynthFilterAlgorithm FilterAlgorithm;

	private static bool StereoDelayEnabled_IsValid;

	private static FFieldAddress StereoDelayEnabled_PropertyAddress;

	private static int StereoDelayEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bStereoDelayEnabled")]
	public bool StereoDelayEnabled;

	private static bool StereoDelayMode_IsValid;

	private static FFieldAddress StereoDelayMode_PropertyAddress;

	private static int StereoDelayMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:StereoDelayMode")]
	public ESynthStereoDelayMode StereoDelayMode;

	private static bool StereoDelayTime_IsValid;

	private static int StereoDelayTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:StereoDelayTime")]
	public float StereoDelayTime;

	private static bool StereoDelayFeedback_IsValid;

	private static int StereoDelayFeedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:StereoDelayFeedback")]
	public float StereoDelayFeedback;

	private static bool StereoDelayWetlevel_IsValid;

	private static int StereoDelayWetlevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:StereoDelayWetlevel")]
	public float StereoDelayWetlevel;

	private static bool StereoDelayRatio_IsValid;

	private static int StereoDelayRatio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:StereoDelayRatio")]
	public float StereoDelayRatio;

	private static bool ChorusEnabled_IsValid;

	private static FFieldAddress ChorusEnabled_PropertyAddress;

	private static int ChorusEnabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:bChorusEnabled")]
	public bool ChorusEnabled;

	private static bool ChorusDepth_IsValid;

	private static int ChorusDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ChorusDepth")]
	public float ChorusDepth;

	private static bool ChorusFeedback_IsValid;

	private static int ChorusFeedback_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ChorusFeedback")]
	public float ChorusFeedback;

	private static bool ChorusFrequency_IsValid;

	private static int ChorusFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:ChorusFrequency")]
	public float ChorusFrequency;

	private static bool Patches_IsValid;

	private static FFieldAddress Patches_PropertyAddress;

	private static int Patches_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPreset:Patches")]
	public List<FEpicSynth1Patch> Patches;

	private static bool FModularSynthPreset_IsValid;

	private static int FModularSynthPreset_StructSize;

	public FModularSynthPreset Copy()
	{
		FModularSynthPreset result = this;
		if (Patches != null)
		{
			result.Patches = new List<FEpicSynth1Patch>(Patches);
		}
		return result;
	}

	public static FModularSynthPreset FromNative(IntPtr nativeBuffer)
	{
		return new FModularSynthPreset(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FModularSynthPreset value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FModularSynthPreset FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FModularSynthPreset(nativeBuffer + arrayIndex * FModularSynthPreset_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FModularSynthPreset value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FModularSynthPreset_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FModularSynthPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.ModularSynthPreset");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnablePolyphony_Offset), 0, EnablePolyphony_PropertyAddress.Address, EnablePolyphony);
		EnumMarshaler<ESynth1OscType>.ToNative(IntPtr.Add(nativeStruct, Osc1Type_Offset), 0, Osc1Type_PropertyAddress.Address, Osc1Type);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc1Gain_Offset), Osc1Gain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc1Octave_Offset), Osc1Octave);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc1Semitones_Offset), Osc1Semitones);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc1Cents_Offset), Osc1Cents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc1PulseWidth_Offset), Osc1PulseWidth);
		EnumMarshaler<ESynth1OscType>.ToNative(IntPtr.Add(nativeStruct, Osc2Type_Offset), 0, Osc2Type_PropertyAddress.Address, Osc2Type);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc2Gain_Offset), Osc2Gain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc2Octave_Offset), Osc2Octave);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc2Semitones_Offset), Osc2Semitones);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc2Cents_Offset), Osc2Cents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Osc2PulseWidth_Offset), Osc2PulseWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Portamento_Offset), Portamento);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableUnison_Offset), 0, EnableUnison_PropertyAddress.Address, EnableUnison);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableOscillatorSync_Offset), 0, EnableOscillatorSync_PropertyAddress.Address, EnableOscillatorSync);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Spread_Offset), Spread);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Pan_Offset), Pan);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LFO1Frequency_Offset), LFO1Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LFO1Gain_Offset), LFO1Gain);
		EnumMarshaler<ESynthLFOType>.ToNative(IntPtr.Add(nativeStruct, LFO1Type_Offset), 0, LFO1Type_PropertyAddress.Address, LFO1Type);
		EnumMarshaler<ESynthLFOMode>.ToNative(IntPtr.Add(nativeStruct, LFO1Mode_Offset), 0, LFO1Mode_PropertyAddress.Address, LFO1Mode);
		EnumMarshaler<ESynthLFOPatchType>.ToNative(IntPtr.Add(nativeStruct, LFO1PatchType_Offset), 0, LFO1PatchType_PropertyAddress.Address, LFO1PatchType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LFO2Frequency_Offset), LFO2Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LFO2Gain_Offset), LFO2Gain);
		EnumMarshaler<ESynthLFOType>.ToNative(IntPtr.Add(nativeStruct, LFO2Type_Offset), 0, LFO2Type_PropertyAddress.Address, LFO2Type);
		EnumMarshaler<ESynthLFOMode>.ToNative(IntPtr.Add(nativeStruct, LFO2Mode_Offset), 0, LFO2Mode_PropertyAddress.Address, LFO2Mode);
		EnumMarshaler<ESynthLFOPatchType>.ToNative(IntPtr.Add(nativeStruct, LFO2PatchType_Offset), 0, LFO2PatchType_PropertyAddress.Address, LFO2PatchType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GainDb_Offset), GainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackTime_Offset), AttackTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecayTime_Offset), DecayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SustainGain_Offset), SustainGain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReleaseTime_Offset), ReleaseTime);
		EnumMarshaler<ESynthModEnvPatch>.ToNative(IntPtr.Add(nativeStruct, ModEnvPatchType_Offset), 0, ModEnvPatchType_PropertyAddress.Address, ModEnvPatchType);
		EnumMarshaler<ESynthModEnvBiasPatch>.ToNative(IntPtr.Add(nativeStruct, ModEnvBiasPatchType_Offset), 0, ModEnvBiasPatchType_PropertyAddress.Address, ModEnvBiasPatchType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InvertModulationEnvelope_Offset), 0, InvertModulationEnvelope_PropertyAddress.Address, InvertModulationEnvelope);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InvertModulationEnvelopeBias_Offset), 0, InvertModulationEnvelopeBias_PropertyAddress.Address, InvertModulationEnvelopeBias);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ModulationEnvelopeDepth_Offset), ModulationEnvelopeDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ModulationEnvelopeAttackTime_Offset), ModulationEnvelopeAttackTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ModulationEnvelopeDecayTime_Offset), ModulationEnvelopeDecayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ModulationEnvelopeSustainGain_Offset), ModulationEnvelopeSustainGain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ModulationEnvelopeReleaseTime_Offset), ModulationEnvelopeReleaseTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Legato_Offset), 0, Legato_PropertyAddress.Address, Legato);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Retrigger_Offset), 0, Retrigger_PropertyAddress.Address, Retrigger);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset), FilterFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterQ_Offset), FilterQ);
		EnumMarshaler<ESynthFilterType>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		EnumMarshaler<ESynthFilterAlgorithm>.ToNative(IntPtr.Add(nativeStruct, FilterAlgorithm_Offset), 0, FilterAlgorithm_PropertyAddress.Address, FilterAlgorithm);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StereoDelayEnabled_Offset), 0, StereoDelayEnabled_PropertyAddress.Address, StereoDelayEnabled);
		EnumMarshaler<ESynthStereoDelayMode>.ToNative(IntPtr.Add(nativeStruct, StereoDelayMode_Offset), 0, StereoDelayMode_PropertyAddress.Address, StereoDelayMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StereoDelayTime_Offset), StereoDelayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StereoDelayFeedback_Offset), StereoDelayFeedback);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StereoDelayWetlevel_Offset), StereoDelayWetlevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StereoDelayRatio_Offset), StereoDelayRatio);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ChorusEnabled_Offset), 0, ChorusEnabled_PropertyAddress.Address, ChorusEnabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChorusDepth_Offset), ChorusDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChorusFeedback_Offset), ChorusFeedback);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChorusFrequency_Offset), ChorusFrequency);
		new TArrayCopyMarshaler<FEpicSynth1Patch>(1, Patches_PropertyAddress, CachedMarshalingDelegates<FEpicSynth1Patch, FEpicSynth1Patch>.FromNative, CachedMarshalingDelegates<FEpicSynth1Patch, FEpicSynth1Patch>.ToNative).ToNative(IntPtr.Add(nativeStruct, Patches_Offset), Patches);
	}

	public FModularSynthPreset(IntPtr nativeStruct)
	{
		if (!FModularSynthPreset_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.ModularSynthPreset");
			EnablePolyphony = false;
			Osc1Type = ESynth1OscType.Sine;
			Osc1Gain = 0f;
			Osc1Octave = 0f;
			Osc1Semitones = 0f;
			Osc1Cents = 0f;
			Osc1PulseWidth = 0f;
			Osc2Type = ESynth1OscType.Sine;
			Osc2Gain = 0f;
			Osc2Octave = 0f;
			Osc2Semitones = 0f;
			Osc2Cents = 0f;
			Osc2PulseWidth = 0f;
			Portamento = 0f;
			EnableUnison = false;
			EnableOscillatorSync = false;
			Spread = 0f;
			Pan = 0f;
			LFO1Frequency = 0f;
			LFO1Gain = 0f;
			LFO1Type = ESynthLFOType.Sine;
			LFO1Mode = ESynthLFOMode.Sync;
			LFO1PatchType = ESynthLFOPatchType.PatchToNone;
			LFO2Frequency = 0f;
			LFO2Gain = 0f;
			LFO2Type = ESynthLFOType.Sine;
			LFO2Mode = ESynthLFOMode.Sync;
			LFO2PatchType = ESynthLFOPatchType.PatchToNone;
			GainDb = 0f;
			AttackTime = 0f;
			DecayTime = 0f;
			SustainGain = 0f;
			ReleaseTime = 0f;
			ModEnvPatchType = ESynthModEnvPatch.PatchToNone;
			ModEnvBiasPatchType = ESynthModEnvBiasPatch.PatchToNone;
			InvertModulationEnvelope = false;
			InvertModulationEnvelopeBias = false;
			ModulationEnvelopeDepth = 0f;
			ModulationEnvelopeAttackTime = 0f;
			ModulationEnvelopeDecayTime = 0f;
			ModulationEnvelopeSustainGain = 0f;
			ModulationEnvelopeReleaseTime = 0f;
			Legato = false;
			Retrigger = false;
			FilterFrequency = 0f;
			FilterQ = 0f;
			FilterType = ESynthFilterType.LowPass;
			FilterAlgorithm = ESynthFilterAlgorithm.OnePole;
			StereoDelayEnabled = false;
			StereoDelayMode = ESynthStereoDelayMode.Normal;
			StereoDelayTime = 0f;
			StereoDelayFeedback = 0f;
			StereoDelayWetlevel = 0f;
			StereoDelayRatio = 0f;
			ChorusEnabled = false;
			ChorusDepth = 0f;
			ChorusFeedback = 0f;
			ChorusFrequency = 0f;
			Patches = null;
		}
		else
		{
			EnablePolyphony = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnablePolyphony_Offset), 0, EnablePolyphony_PropertyAddress.Address);
			Osc1Type = EnumMarshaler<ESynth1OscType>.FromNative(IntPtr.Add(nativeStruct, Osc1Type_Offset), 0, Osc1Type_PropertyAddress.Address);
			Osc1Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc1Gain_Offset));
			Osc1Octave = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc1Octave_Offset));
			Osc1Semitones = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc1Semitones_Offset));
			Osc1Cents = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc1Cents_Offset));
			Osc1PulseWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc1PulseWidth_Offset));
			Osc2Type = EnumMarshaler<ESynth1OscType>.FromNative(IntPtr.Add(nativeStruct, Osc2Type_Offset), 0, Osc2Type_PropertyAddress.Address);
			Osc2Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc2Gain_Offset));
			Osc2Octave = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc2Octave_Offset));
			Osc2Semitones = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc2Semitones_Offset));
			Osc2Cents = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc2Cents_Offset));
			Osc2PulseWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Osc2PulseWidth_Offset));
			Portamento = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Portamento_Offset));
			EnableUnison = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableUnison_Offset), 0, EnableUnison_PropertyAddress.Address);
			EnableOscillatorSync = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableOscillatorSync_Offset), 0, EnableOscillatorSync_PropertyAddress.Address);
			Spread = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Spread_Offset));
			Pan = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Pan_Offset));
			LFO1Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LFO1Frequency_Offset));
			LFO1Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LFO1Gain_Offset));
			LFO1Type = EnumMarshaler<ESynthLFOType>.FromNative(IntPtr.Add(nativeStruct, LFO1Type_Offset), 0, LFO1Type_PropertyAddress.Address);
			LFO1Mode = EnumMarshaler<ESynthLFOMode>.FromNative(IntPtr.Add(nativeStruct, LFO1Mode_Offset), 0, LFO1Mode_PropertyAddress.Address);
			LFO1PatchType = EnumMarshaler<ESynthLFOPatchType>.FromNative(IntPtr.Add(nativeStruct, LFO1PatchType_Offset), 0, LFO1PatchType_PropertyAddress.Address);
			LFO2Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LFO2Frequency_Offset));
			LFO2Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LFO2Gain_Offset));
			LFO2Type = EnumMarshaler<ESynthLFOType>.FromNative(IntPtr.Add(nativeStruct, LFO2Type_Offset), 0, LFO2Type_PropertyAddress.Address);
			LFO2Mode = EnumMarshaler<ESynthLFOMode>.FromNative(IntPtr.Add(nativeStruct, LFO2Mode_Offset), 0, LFO2Mode_PropertyAddress.Address);
			LFO2PatchType = EnumMarshaler<ESynthLFOPatchType>.FromNative(IntPtr.Add(nativeStruct, LFO2PatchType_Offset), 0, LFO2PatchType_PropertyAddress.Address);
			GainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GainDb_Offset));
			AttackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackTime_Offset));
			DecayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecayTime_Offset));
			SustainGain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SustainGain_Offset));
			ReleaseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReleaseTime_Offset));
			ModEnvPatchType = EnumMarshaler<ESynthModEnvPatch>.FromNative(IntPtr.Add(nativeStruct, ModEnvPatchType_Offset), 0, ModEnvPatchType_PropertyAddress.Address);
			ModEnvBiasPatchType = EnumMarshaler<ESynthModEnvBiasPatch>.FromNative(IntPtr.Add(nativeStruct, ModEnvBiasPatchType_Offset), 0, ModEnvBiasPatchType_PropertyAddress.Address);
			InvertModulationEnvelope = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InvertModulationEnvelope_Offset), 0, InvertModulationEnvelope_PropertyAddress.Address);
			InvertModulationEnvelopeBias = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InvertModulationEnvelopeBias_Offset), 0, InvertModulationEnvelopeBias_PropertyAddress.Address);
			ModulationEnvelopeDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ModulationEnvelopeDepth_Offset));
			ModulationEnvelopeAttackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ModulationEnvelopeAttackTime_Offset));
			ModulationEnvelopeDecayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ModulationEnvelopeDecayTime_Offset));
			ModulationEnvelopeSustainGain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ModulationEnvelopeSustainGain_Offset));
			ModulationEnvelopeReleaseTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ModulationEnvelopeReleaseTime_Offset));
			Legato = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Legato_Offset), 0, Legato_PropertyAddress.Address);
			Retrigger = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Retrigger_Offset), 0, Retrigger_PropertyAddress.Address);
			FilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterFrequency_Offset));
			FilterQ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterQ_Offset));
			FilterType = EnumMarshaler<ESynthFilterType>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			FilterAlgorithm = EnumMarshaler<ESynthFilterAlgorithm>.FromNative(IntPtr.Add(nativeStruct, FilterAlgorithm_Offset), 0, FilterAlgorithm_PropertyAddress.Address);
			StereoDelayEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StereoDelayEnabled_Offset), 0, StereoDelayEnabled_PropertyAddress.Address);
			StereoDelayMode = EnumMarshaler<ESynthStereoDelayMode>.FromNative(IntPtr.Add(nativeStruct, StereoDelayMode_Offset), 0, StereoDelayMode_PropertyAddress.Address);
			StereoDelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StereoDelayTime_Offset));
			StereoDelayFeedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StereoDelayFeedback_Offset));
			StereoDelayWetlevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StereoDelayWetlevel_Offset));
			StereoDelayRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StereoDelayRatio_Offset));
			ChorusEnabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ChorusEnabled_Offset), 0, ChorusEnabled_PropertyAddress.Address);
			ChorusDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChorusDepth_Offset));
			ChorusFeedback = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChorusFeedback_Offset));
			ChorusFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChorusFrequency_Offset));
			Patches = new TArrayCopyMarshaler<FEpicSynth1Patch>(1, Patches_PropertyAddress, CachedMarshalingDelegates<FEpicSynth1Patch, FEpicSynth1Patch>.FromNative, CachedMarshalingDelegates<FEpicSynth1Patch, FEpicSynth1Patch>.ToNative).FromNative(IntPtr.Add(nativeStruct, Patches_Offset));
		}
	}

	static FModularSynthPreset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FModularSynthPreset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FModularSynthPreset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.ModularSynthPreset");
		FModularSynthPreset_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnablePolyphony_PropertyAddress, intPtr, "bEnablePolyphony");
		EnablePolyphony_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePolyphony");
		EnablePolyphony_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePolyphony", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Osc1Type_PropertyAddress, intPtr, "Osc1Type");
		Osc1Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1Type");
		Osc1Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1Type", Classes.FEnumProperty);
		Osc1Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1Gain");
		Osc1Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1Gain", Classes.FFloatProperty);
		Osc1Octave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1Octave");
		Osc1Octave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1Octave", Classes.FFloatProperty);
		Osc1Semitones_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1Semitones");
		Osc1Semitones_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1Semitones", Classes.FFloatProperty);
		Osc1Cents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1Cents");
		Osc1Cents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1Cents", Classes.FFloatProperty);
		Osc1PulseWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc1PulseWidth");
		Osc1PulseWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc1PulseWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Osc2Type_PropertyAddress, intPtr, "Osc2Type");
		Osc2Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2Type");
		Osc2Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2Type", Classes.FEnumProperty);
		Osc2Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2Gain");
		Osc2Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2Gain", Classes.FFloatProperty);
		Osc2Octave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2Octave");
		Osc2Octave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2Octave", Classes.FFloatProperty);
		Osc2Semitones_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2Semitones");
		Osc2Semitones_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2Semitones", Classes.FFloatProperty);
		Osc2Cents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2Cents");
		Osc2Cents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2Cents", Classes.FFloatProperty);
		Osc2PulseWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Osc2PulseWidth");
		Osc2PulseWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Osc2PulseWidth", Classes.FFloatProperty);
		Portamento_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Portamento");
		Portamento_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Portamento", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableUnison_PropertyAddress, intPtr, "bEnableUnison");
		EnableUnison_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableUnison");
		EnableUnison_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableUnison", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOscillatorSync_PropertyAddress, intPtr, "bEnableOscillatorSync");
		EnableOscillatorSync_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableOscillatorSync");
		EnableOscillatorSync_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableOscillatorSync", Classes.FBoolProperty);
		Spread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Spread");
		Spread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Spread", Classes.FFloatProperty);
		Pan_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pan");
		Pan_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pan", Classes.FFloatProperty);
		LFO1Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO1Frequency");
		LFO1Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO1Frequency", Classes.FFloatProperty);
		LFO1Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO1Gain");
		LFO1Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO1Gain", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO1Type_PropertyAddress, intPtr, "LFO1Type");
		LFO1Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO1Type");
		LFO1Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO1Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO1Mode_PropertyAddress, intPtr, "LFO1Mode");
		LFO1Mode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO1Mode");
		LFO1Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO1Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO1PatchType_PropertyAddress, intPtr, "LFO1PatchType");
		LFO1PatchType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO1PatchType");
		LFO1PatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO1PatchType", Classes.FEnumProperty);
		LFO2Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO2Frequency");
		LFO2Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO2Frequency", Classes.FFloatProperty);
		LFO2Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO2Gain");
		LFO2Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO2Gain", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO2Type_PropertyAddress, intPtr, "LFO2Type");
		LFO2Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO2Type");
		LFO2Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO2Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO2Mode_PropertyAddress, intPtr, "LFO2Mode");
		LFO2Mode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO2Mode");
		LFO2Mode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO2Mode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LFO2PatchType_PropertyAddress, intPtr, "LFO2PatchType");
		LFO2PatchType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFO2PatchType");
		LFO2PatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFO2PatchType", Classes.FEnumProperty);
		GainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GainDb");
		GainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GainDb", Classes.FFloatProperty);
		AttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttackTime");
		AttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttackTime", Classes.FFloatProperty);
		DecayTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecayTime");
		DecayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecayTime", Classes.FFloatProperty);
		SustainGain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SustainGain");
		SustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SustainGain", Classes.FFloatProperty);
		ReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseTime");
		ReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ModEnvPatchType_PropertyAddress, intPtr, "ModEnvPatchType");
		ModEnvPatchType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModEnvPatchType");
		ModEnvPatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModEnvPatchType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ModEnvBiasPatchType_PropertyAddress, intPtr, "ModEnvBiasPatchType");
		ModEnvBiasPatchType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModEnvBiasPatchType");
		ModEnvBiasPatchType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModEnvBiasPatchType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertModulationEnvelope_PropertyAddress, intPtr, "bInvertModulationEnvelope");
		InvertModulationEnvelope_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInvertModulationEnvelope");
		InvertModulationEnvelope_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInvertModulationEnvelope", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InvertModulationEnvelopeBias_PropertyAddress, intPtr, "bInvertModulationEnvelopeBias");
		InvertModulationEnvelopeBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInvertModulationEnvelopeBias");
		InvertModulationEnvelopeBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInvertModulationEnvelopeBias", Classes.FBoolProperty);
		ModulationEnvelopeDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationEnvelopeDepth");
		ModulationEnvelopeDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationEnvelopeDepth", Classes.FFloatProperty);
		ModulationEnvelopeAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationEnvelopeAttackTime");
		ModulationEnvelopeAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationEnvelopeAttackTime", Classes.FFloatProperty);
		ModulationEnvelopeDecayTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationEnvelopeDecayTime");
		ModulationEnvelopeDecayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationEnvelopeDecayTime", Classes.FFloatProperty);
		ModulationEnvelopeSustainGain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationEnvelopeSustainGain");
		ModulationEnvelopeSustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationEnvelopeSustainGain", Classes.FFloatProperty);
		ModulationEnvelopeReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationEnvelopeReleaseTime");
		ModulationEnvelopeReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationEnvelopeReleaseTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Legato_PropertyAddress, intPtr, "bLegato");
		Legato_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLegato");
		Legato_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLegato", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Retrigger_PropertyAddress, intPtr, "bRetrigger");
		Retrigger_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRetrigger");
		Retrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRetrigger", Classes.FBoolProperty);
		FilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterFrequency");
		FilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterFrequency", Classes.FFloatProperty);
		FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterQ");
		FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterQ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterAlgorithm_PropertyAddress, intPtr, "FilterAlgorithm");
		FilterAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterAlgorithm");
		FilterAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterAlgorithm", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StereoDelayEnabled_PropertyAddress, intPtr, "bStereoDelayEnabled");
		StereoDelayEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStereoDelayEnabled");
		StereoDelayEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStereoDelayEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StereoDelayMode_PropertyAddress, intPtr, "StereoDelayMode");
		StereoDelayMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoDelayMode");
		StereoDelayMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoDelayMode", Classes.FEnumProperty);
		StereoDelayTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoDelayTime");
		StereoDelayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoDelayTime", Classes.FFloatProperty);
		StereoDelayFeedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoDelayFeedback");
		StereoDelayFeedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoDelayFeedback", Classes.FFloatProperty);
		StereoDelayWetlevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoDelayWetlevel");
		StereoDelayWetlevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoDelayWetlevel", Classes.FFloatProperty);
		StereoDelayRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoDelayRatio");
		StereoDelayRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoDelayRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ChorusEnabled_PropertyAddress, intPtr, "bChorusEnabled");
		ChorusEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bChorusEnabled");
		ChorusEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bChorusEnabled", Classes.FBoolProperty);
		ChorusDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChorusDepth");
		ChorusDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChorusDepth", Classes.FFloatProperty);
		ChorusFeedback_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChorusFeedback");
		ChorusFeedback_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChorusFeedback", Classes.FFloatProperty);
		ChorusFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChorusFrequency");
		ChorusFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChorusFrequency", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Patches_PropertyAddress, intPtr, "Patches");
		Patches_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Patches");
		Patches_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Patches", Classes.FArrayProperty);
		FModularSynthPreset_IsValid = intPtr != IntPtr.Zero && EnablePolyphony_IsValid && Osc1Type_IsValid && Osc1Gain_IsValid && Osc1Octave_IsValid && Osc1Semitones_IsValid && Osc1Cents_IsValid && Osc1PulseWidth_IsValid && Osc2Type_IsValid && Osc2Gain_IsValid && Osc2Octave_IsValid && Osc2Semitones_IsValid && Osc2Cents_IsValid && Osc2PulseWidth_IsValid && Portamento_IsValid && EnableUnison_IsValid && EnableOscillatorSync_IsValid && Spread_IsValid && Pan_IsValid && LFO1Frequency_IsValid && LFO1Gain_IsValid && LFO1Type_IsValid && LFO1Mode_IsValid && LFO1PatchType_IsValid && LFO2Frequency_IsValid && LFO2Gain_IsValid && LFO2Type_IsValid && LFO2Mode_IsValid && LFO2PatchType_IsValid && GainDb_IsValid && AttackTime_IsValid && DecayTime_IsValid && SustainGain_IsValid && ReleaseTime_IsValid && ModEnvPatchType_IsValid && ModEnvBiasPatchType_IsValid && InvertModulationEnvelope_IsValid && InvertModulationEnvelopeBias_IsValid && ModulationEnvelopeDepth_IsValid && ModulationEnvelopeAttackTime_IsValid && ModulationEnvelopeDecayTime_IsValid && ModulationEnvelopeSustainGain_IsValid && ModulationEnvelopeReleaseTime_IsValid && Legato_IsValid && Retrigger_IsValid && FilterFrequency_IsValid && FilterQ_IsValid && FilterType_IsValid && FilterAlgorithm_IsValid && StereoDelayEnabled_IsValid && StereoDelayMode_IsValid && StereoDelayTime_IsValid && StereoDelayFeedback_IsValid && StereoDelayWetlevel_IsValid && StereoDelayRatio_IsValid && ChorusEnabled_IsValid && ChorusDepth_IsValid && ChorusFeedback_IsValid && ChorusFrequency_IsValid && Patches_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.ModularSynthPreset", FModularSynthPreset_IsValid);
	}
}
