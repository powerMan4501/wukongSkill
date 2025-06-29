using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynthComponentMonoWaveTable : USynthComponent
{
	private static bool OnTableAltered_IsValid;

	private static int OnTableAltered_Offset;

	private FOnTableAltered OnTableAltered_DelegateCached;

	private static bool OnNumTablesChanged_IsValid;

	private static int OnNumTablesChanged_Offset;

	private FNumTablesChanged OnNumTablesChanged_DelegateCached;

	private static bool SetWaveTablePosition_IsValid;

	private static IntPtr SetWaveTablePosition_FunctionAddress;

	private static int SetWaveTablePosition_ParamsSize;

	private static bool SetWaveTablePosition_InPosition_IsValid;

	private static FFieldAddress SetWaveTablePosition_InPosition_PropertyAddress;

	private static int SetWaveTablePosition_InPosition_Offset;

	private static bool SetSustainPedalState_IsValid;

	private static IntPtr SetSustainPedalState_FunctionAddress;

	private static int SetSustainPedalState_ParamsSize;

	private static bool SetSustainPedalState_InSustainPedalState_IsValid;

	private static FFieldAddress SetSustainPedalState_InSustainPedalState_PropertyAddress;

	private static int SetSustainPedalState_InSustainPedalState_Offset;

	private static bool SetPosLfoType_IsValid;

	private static IntPtr SetPosLfoType_FunctionAddress;

	private static int SetPosLfoType_ParamsSize;

	private static bool SetPosLfoType_InLfoType_IsValid;

	private static FFieldAddress SetPosLfoType_InLfoType_PropertyAddress;

	private static int SetPosLfoType_InLfoType_Offset;

	private static bool SetPosLfoFrequency_IsValid;

	private static IntPtr SetPosLfoFrequency_FunctionAddress;

	private static int SetPosLfoFrequency_ParamsSize;

	private static bool SetPosLfoFrequency_InLfoFrequency_IsValid;

	private static FFieldAddress SetPosLfoFrequency_InLfoFrequency_PropertyAddress;

	private static int SetPosLfoFrequency_InLfoFrequency_Offset;

	private static bool SetPosLfoDepth_IsValid;

	private static IntPtr SetPosLfoDepth_FunctionAddress;

	private static int SetPosLfoDepth_ParamsSize;

	private static bool SetPosLfoDepth_InLfoDepth_IsValid;

	private static FFieldAddress SetPosLfoDepth_InLfoDepth_PropertyAddress;

	private static int SetPosLfoDepth_InLfoDepth_Offset;

	private static bool SetPositionEnvelopeSustainGain_IsValid;

	private static IntPtr SetPositionEnvelopeSustainGain_FunctionAddress;

	private static int SetPositionEnvelopeSustainGain_ParamsSize;

	private static bool SetPositionEnvelopeSustainGain_InSustainGain_IsValid;

	private static FFieldAddress SetPositionEnvelopeSustainGain_InSustainGain_PropertyAddress;

	private static int SetPositionEnvelopeSustainGain_InSustainGain_Offset;

	private static bool SetPositionEnvelopeReleaseTime_IsValid;

	private static IntPtr SetPositionEnvelopeReleaseTime_FunctionAddress;

	private static int SetPositionEnvelopeReleaseTime_ParamsSize;

	private static bool SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;

	private static FFieldAddress SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress;

	private static int SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_Offset;

	private static bool SetPositionEnvelopeInvert_IsValid;

	private static IntPtr SetPositionEnvelopeInvert_FunctionAddress;

	private static int SetPositionEnvelopeInvert_ParamsSize;

	private static bool SetPositionEnvelopeInvert_bInInvert_IsValid;

	private static FFieldAddress SetPositionEnvelopeInvert_bInInvert_PropertyAddress;

	private static int SetPositionEnvelopeInvert_bInInvert_Offset;

	private static bool SetPositionEnvelopeDepth_IsValid;

	private static IntPtr SetPositionEnvelopeDepth_FunctionAddress;

	private static int SetPositionEnvelopeDepth_ParamsSize;

	private static bool SetPositionEnvelopeDepth_InDepth_IsValid;

	private static FFieldAddress SetPositionEnvelopeDepth_InDepth_PropertyAddress;

	private static int SetPositionEnvelopeDepth_InDepth_Offset;

	private static bool SetPositionEnvelopeDecayTime_IsValid;

	private static IntPtr SetPositionEnvelopeDecayTime_FunctionAddress;

	private static int SetPositionEnvelopeDecayTime_ParamsSize;

	private static bool SetPositionEnvelopeDecayTime_InDecayTimeMsec_IsValid;

	private static FFieldAddress SetPositionEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress;

	private static int SetPositionEnvelopeDecayTime_InDecayTimeMsec_Offset;

	private static bool SetPositionEnvelopeBiasInvert_IsValid;

	private static IntPtr SetPositionEnvelopeBiasInvert_FunctionAddress;

	private static int SetPositionEnvelopeBiasInvert_ParamsSize;

	private static bool SetPositionEnvelopeBiasInvert_bInBiasInvert_IsValid;

	private static FFieldAddress SetPositionEnvelopeBiasInvert_bInBiasInvert_PropertyAddress;

	private static int SetPositionEnvelopeBiasInvert_bInBiasInvert_Offset;

	private static bool SetPositionEnvelopeBiasDepth_IsValid;

	private static IntPtr SetPositionEnvelopeBiasDepth_FunctionAddress;

	private static int SetPositionEnvelopeBiasDepth_ParamsSize;

	private static bool SetPositionEnvelopeBiasDepth_InDepth_IsValid;

	private static FFieldAddress SetPositionEnvelopeBiasDepth_InDepth_PropertyAddress;

	private static int SetPositionEnvelopeBiasDepth_InDepth_Offset;

	private static bool SetPositionEnvelopeAttackTime_IsValid;

	private static IntPtr SetPositionEnvelopeAttackTime_FunctionAddress;

	private static int SetPositionEnvelopeAttackTime_ParamsSize;

	private static bool SetPositionEnvelopeAttackTime_InAttackTimeMsec_IsValid;

	private static FFieldAddress SetPositionEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress;

	private static int SetPositionEnvelopeAttackTime_InAttackTimeMsec_Offset;

	private static bool SetLowPassFilterResonance_IsValid;

	private static IntPtr SetLowPassFilterResonance_FunctionAddress;

	private static int SetLowPassFilterResonance_ParamsSize;

	private static bool SetLowPassFilterResonance_InNewQ_IsValid;

	private static FFieldAddress SetLowPassFilterResonance_InNewQ_PropertyAddress;

	private static int SetLowPassFilterResonance_InNewQ_Offset;

	private static bool SetFrequencyWithMidiNote_IsValid;

	private static IntPtr SetFrequencyWithMidiNote_FunctionAddress;

	private static int SetFrequencyWithMidiNote_ParamsSize;

	private static bool SetFrequencyWithMidiNote_InMidiNote_IsValid;

	private static FFieldAddress SetFrequencyWithMidiNote_InMidiNote_PropertyAddress;

	private static int SetFrequencyWithMidiNote_InMidiNote_Offset;

	private static bool SetFrequencyPitchBend_IsValid;

	private static IntPtr SetFrequencyPitchBend_FunctionAddress;

	private static int SetFrequencyPitchBend_ParamsSize;

	private static bool SetFrequencyPitchBend_FrequencyOffsetCents_IsValid;

	private static FFieldAddress SetFrequencyPitchBend_FrequencyOffsetCents_PropertyAddress;

	private static int SetFrequencyPitchBend_FrequencyOffsetCents_Offset;

	private static bool SetFrequency_IsValid;

	private static IntPtr SetFrequency_FunctionAddress;

	private static int SetFrequency_ParamsSize;

	private static bool SetFrequency_FrequencyHz_IsValid;

	private static FFieldAddress SetFrequency_FrequencyHz_PropertyAddress;

	private static int SetFrequency_FrequencyHz_Offset;

	private static bool SetFilterEnvelopeSustainGain_IsValid;

	private static IntPtr SetFilterEnvelopeSustainGain_FunctionAddress;

	private static int SetFilterEnvelopeSustainGain_ParamsSize;

	private static bool SetFilterEnvelopeSustainGain_InSustainGain_IsValid;

	private static FFieldAddress SetFilterEnvelopeSustainGain_InSustainGain_PropertyAddress;

	private static int SetFilterEnvelopeSustainGain_InSustainGain_Offset;

	private static bool SetFilterEnvelopeReleaseTime_IsValid;

	private static IntPtr SetFilterEnvelopeReleaseTime_FunctionAddress;

	private static int SetFilterEnvelopeReleaseTime_ParamsSize;

	private static bool SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;

	private static FFieldAddress SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress;

	private static int SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_Offset;

	private static bool SetFilterEnvelopenDecayTime_IsValid;

	private static IntPtr SetFilterEnvelopenDecayTime_FunctionAddress;

	private static int SetFilterEnvelopenDecayTime_ParamsSize;

	private static bool SetFilterEnvelopenDecayTime_InDecayTimeMsec_IsValid;

	private static FFieldAddress SetFilterEnvelopenDecayTime_InDecayTimeMsec_PropertyAddress;

	private static int SetFilterEnvelopenDecayTime_InDecayTimeMsec_Offset;

	private static bool SetFilterEnvelopeInvert_IsValid;

	private static IntPtr SetFilterEnvelopeInvert_FunctionAddress;

	private static int SetFilterEnvelopeInvert_ParamsSize;

	private static bool SetFilterEnvelopeInvert_bInInvert_IsValid;

	private static FFieldAddress SetFilterEnvelopeInvert_bInInvert_PropertyAddress;

	private static int SetFilterEnvelopeInvert_bInInvert_Offset;

	private static bool SetFilterEnvelopeDepth_IsValid;

	private static IntPtr SetFilterEnvelopeDepth_FunctionAddress;

	private static int SetFilterEnvelopeDepth_ParamsSize;

	private static bool SetFilterEnvelopeDepth_InDepth_IsValid;

	private static FFieldAddress SetFilterEnvelopeDepth_InDepth_PropertyAddress;

	private static int SetFilterEnvelopeDepth_InDepth_Offset;

	private static bool SetFilterEnvelopeBiasInvert_IsValid;

	private static IntPtr SetFilterEnvelopeBiasInvert_FunctionAddress;

	private static int SetFilterEnvelopeBiasInvert_ParamsSize;

	private static bool SetFilterEnvelopeBiasInvert_bInBiasInvert_IsValid;

	private static FFieldAddress SetFilterEnvelopeBiasInvert_bInBiasInvert_PropertyAddress;

	private static int SetFilterEnvelopeBiasInvert_bInBiasInvert_Offset;

	private static bool SetFilterEnvelopeBiasDepth_IsValid;

	private static IntPtr SetFilterEnvelopeBiasDepth_FunctionAddress;

	private static int SetFilterEnvelopeBiasDepth_ParamsSize;

	private static bool SetFilterEnvelopeBiasDepth_InDepth_IsValid;

	private static FFieldAddress SetFilterEnvelopeBiasDepth_InDepth_PropertyAddress;

	private static int SetFilterEnvelopeBiasDepth_InDepth_Offset;

	private static bool SetFilterEnvelopeAttackTime_IsValid;

	private static IntPtr SetFilterEnvelopeAttackTime_FunctionAddress;

	private static int SetFilterEnvelopeAttackTime_ParamsSize;

	private static bool SetFilterEnvelopeAttackTime_InAttackTimeMsec_IsValid;

	private static FFieldAddress SetFilterEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress;

	private static int SetFilterEnvelopeAttackTime_InAttackTimeMsec_Offset;

	private static bool SetCurveValue_IsValid;

	private static IntPtr SetCurveValue_FunctionAddress;

	private static int SetCurveValue_ParamsSize;

	private static bool SetCurveValue_TableIndex_IsValid;

	private static FFieldAddress SetCurveValue_TableIndex_PropertyAddress;

	private static int SetCurveValue_TableIndex_Offset;

	private static bool SetCurveValue_KeyframeIndex_IsValid;

	private static FFieldAddress SetCurveValue_KeyframeIndex_PropertyAddress;

	private static int SetCurveValue_KeyframeIndex_Offset;

	private static bool SetCurveValue_NewValue_IsValid;

	private static FFieldAddress SetCurveValue_NewValue_PropertyAddress;

	private static int SetCurveValue_NewValue_Offset;

	private static bool SetCurveValue_ReturnValue_IsValid;

	private static FFieldAddress SetCurveValue_ReturnValue_PropertyAddress;

	private static int SetCurveValue_ReturnValue_Offset;

	private static bool SetCurveTangent_IsValid;

	private static IntPtr SetCurveTangent_FunctionAddress;

	private static int SetCurveTangent_ParamsSize;

	private static bool SetCurveTangent_TableIndex_IsValid;

	private static FFieldAddress SetCurveTangent_TableIndex_PropertyAddress;

	private static int SetCurveTangent_TableIndex_Offset;

	private static bool SetCurveTangent_InNewTangent_IsValid;

	private static FFieldAddress SetCurveTangent_InNewTangent_PropertyAddress;

	private static int SetCurveTangent_InNewTangent_Offset;

	private static bool SetCurveTangent_ReturnValue_IsValid;

	private static FFieldAddress SetCurveTangent_ReturnValue_PropertyAddress;

	private static int SetCurveTangent_ReturnValue_Offset;

	private static bool SetCurveInterpolationType_IsValid;

	private static IntPtr SetCurveInterpolationType_FunctionAddress;

	private static int SetCurveInterpolationType_ParamsSize;

	private static bool SetCurveInterpolationType_InterpolationType_IsValid;

	private static FFieldAddress SetCurveInterpolationType_InterpolationType_PropertyAddress;

	private static int SetCurveInterpolationType_InterpolationType_Offset;

	private static bool SetCurveInterpolationType_TableIndex_IsValid;

	private static FFieldAddress SetCurveInterpolationType_TableIndex_PropertyAddress;

	private static int SetCurveInterpolationType_TableIndex_Offset;

	private static bool SetCurveInterpolationType_ReturnValue_IsValid;

	private static FFieldAddress SetCurveInterpolationType_ReturnValue_PropertyAddress;

	private static int SetCurveInterpolationType_ReturnValue_Offset;

	private static bool SetAmpEnvelopeSustainGain_IsValid;

	private static IntPtr SetAmpEnvelopeSustainGain_FunctionAddress;

	private static int SetAmpEnvelopeSustainGain_ParamsSize;

	private static bool SetAmpEnvelopeSustainGain_InSustainGain_IsValid;

	private static FFieldAddress SetAmpEnvelopeSustainGain_InSustainGain_PropertyAddress;

	private static int SetAmpEnvelopeSustainGain_InSustainGain_Offset;

	private static bool SetAmpEnvelopeReleaseTime_IsValid;

	private static IntPtr SetAmpEnvelopeReleaseTime_FunctionAddress;

	private static int SetAmpEnvelopeReleaseTime_ParamsSize;

	private static bool SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;

	private static FFieldAddress SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress;

	private static int SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_Offset;

	private static bool SetAmpEnvelopeInvert_IsValid;

	private static IntPtr SetAmpEnvelopeInvert_FunctionAddress;

	private static int SetAmpEnvelopeInvert_ParamsSize;

	private static bool SetAmpEnvelopeInvert_bInInvert_IsValid;

	private static FFieldAddress SetAmpEnvelopeInvert_bInInvert_PropertyAddress;

	private static int SetAmpEnvelopeInvert_bInInvert_Offset;

	private static bool SetAmpEnvelopeDepth_IsValid;

	private static IntPtr SetAmpEnvelopeDepth_FunctionAddress;

	private static int SetAmpEnvelopeDepth_ParamsSize;

	private static bool SetAmpEnvelopeDepth_InDepth_IsValid;

	private static FFieldAddress SetAmpEnvelopeDepth_InDepth_PropertyAddress;

	private static int SetAmpEnvelopeDepth_InDepth_Offset;

	private static bool SetAmpEnvelopeDecayTime_IsValid;

	private static IntPtr SetAmpEnvelopeDecayTime_FunctionAddress;

	private static int SetAmpEnvelopeDecayTime_ParamsSize;

	private static bool SetAmpEnvelopeDecayTime_InDecayTimeMsec_IsValid;

	private static FFieldAddress SetAmpEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress;

	private static int SetAmpEnvelopeDecayTime_InDecayTimeMsec_Offset;

	private static bool SetAmpEnvelopeBiasInvert_IsValid;

	private static IntPtr SetAmpEnvelopeBiasInvert_FunctionAddress;

	private static int SetAmpEnvelopeBiasInvert_ParamsSize;

	private static bool SetAmpEnvelopeBiasInvert_bInBiasInvert_IsValid;

	private static FFieldAddress SetAmpEnvelopeBiasInvert_bInBiasInvert_PropertyAddress;

	private static int SetAmpEnvelopeBiasInvert_bInBiasInvert_Offset;

	private static bool SetAmpEnvelopeBiasDepth_IsValid;

	private static IntPtr SetAmpEnvelopeBiasDepth_FunctionAddress;

	private static int SetAmpEnvelopeBiasDepth_ParamsSize;

	private static bool SetAmpEnvelopeBiasDepth_InDepth_IsValid;

	private static FFieldAddress SetAmpEnvelopeBiasDepth_InDepth_PropertyAddress;

	private static int SetAmpEnvelopeBiasDepth_InDepth_Offset;

	private static bool SetAmpEnvelopeAttackTime_IsValid;

	private static IntPtr SetAmpEnvelopeAttackTime_FunctionAddress;

	private static int SetAmpEnvelopeAttackTime_ParamsSize;

	private static bool SetAmpEnvelopeAttackTime_InAttackTimeMsec_IsValid;

	private static FFieldAddress SetAmpEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress;

	private static int SetAmpEnvelopeAttackTime_InAttackTimeMsec_Offset;

	private static bool RefreshWaveTable_IsValid;

	private static IntPtr RefreshWaveTable_FunctionAddress;

	private static int RefreshWaveTable_ParamsSize;

	private static bool RefreshWaveTable_Index_IsValid;

	private static FFieldAddress RefreshWaveTable_Index_PropertyAddress;

	private static int RefreshWaveTable_Index_Offset;

	private static bool RefreshAllWaveTables_IsValid;

	private static IntPtr RefreshAllWaveTables_FunctionAddress;

	private static int RefreshAllWaveTables_ParamsSize;

	private static bool NoteOn_IsValid;

	private static IntPtr NoteOn_FunctionAddress;

	private static int NoteOn_ParamsSize;

	private static bool NoteOn_InMidiNote_IsValid;

	private static FFieldAddress NoteOn_InMidiNote_PropertyAddress;

	private static int NoteOn_InMidiNote_Offset;

	private static bool NoteOn_InVelocity_IsValid;

	private static FFieldAddress NoteOn_InVelocity_PropertyAddress;

	private static int NoteOn_InVelocity_Offset;

	private static bool NoteOff_IsValid;

	private static IntPtr NoteOff_FunctionAddress;

	private static int NoteOff_ParamsSize;

	private static bool NoteOff_InMidiNote_IsValid;

	private static FFieldAddress NoteOff_InMidiNote_PropertyAddress;

	private static int NoteOff_InMidiNote_Offset;

	private static bool GetNumTableEntries_IsValid;

	private static IntPtr GetNumTableEntries_FunctionAddress;

	private static int GetNumTableEntries_ParamsSize;

	private static bool GetNumTableEntries_ReturnValue_IsValid;

	private static FFieldAddress GetNumTableEntries_ReturnValue_PropertyAddress;

	private static int GetNumTableEntries_ReturnValue_Offset;

	private static bool GetMaxTableIndex_IsValid;

	private static IntPtr GetMaxTableIndex_FunctionAddress;

	private static int GetMaxTableIndex_ParamsSize;

	private static bool GetMaxTableIndex_ReturnValue_IsValid;

	private static FFieldAddress GetMaxTableIndex_ReturnValue_PropertyAddress;

	private static int GetMaxTableIndex_ReturnValue_Offset;

	private static bool GetKeyFrameValuesForTable_IsValid;

	private static IntPtr GetKeyFrameValuesForTable_FunctionAddress;

	private static int GetKeyFrameValuesForTable_ParamsSize;

	private static bool GetKeyFrameValuesForTable_TableIndex_IsValid;

	private static FFieldAddress GetKeyFrameValuesForTable_TableIndex_PropertyAddress;

	private static int GetKeyFrameValuesForTable_TableIndex_Offset;

	private static bool GetKeyFrameValuesForTable_ReturnValue_IsValid;

	private static FFieldAddress GetKeyFrameValuesForTable_ReturnValue_PropertyAddress;

	private static int GetKeyFrameValuesForTable_ReturnValue_Offset;

	private static bool GetCurveTangent_IsValid;

	private static IntPtr GetCurveTangent_FunctionAddress;

	private static int GetCurveTangent_ParamsSize;

	private static bool GetCurveTangent_TableIndex_IsValid;

	private static FFieldAddress GetCurveTangent_TableIndex_PropertyAddress;

	private static int GetCurveTangent_TableIndex_Offset;

	private static bool GetCurveTangent_ReturnValue_IsValid;

	private static FFieldAddress GetCurveTangent_ReturnValue_PropertyAddress;

	private static int GetCurveTangent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:OnTableAltered")]
	public FOnTableAltered OnTableAltered
	{
		get
		{
			CheckDestroyed();
			if (!OnTableAltered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:OnTableAltered");
				return new FOnTableAltered();
			}
			if (OnTableAltered_DelegateCached == null)
			{
				OnTableAltered_DelegateCached = new FOnTableAltered();
				OnTableAltered_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTableAltered_Offset));
			}
			return OnTableAltered_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:OnNumTablesChanged")]
	public FNumTablesChanged OnNumTablesChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnNumTablesChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:OnNumTablesChanged");
				return new FNumTablesChanged();
			}
			if (OnNumTablesChanged_DelegateCached == null)
			{
				OnNumTablesChanged_DelegateCached = new FNumTablesChanged();
				OnNumTablesChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnNumTablesChanged_Offset));
			}
			return OnNumTablesChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetWaveTablePosition")]
	public unsafe void SetWaveTablePosition(float InPosition)
	{
		CheckDestroyed();
		if (!SetWaveTablePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetWaveTablePosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaveTablePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaveTablePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaveTablePosition_InPosition_Offset), 0, SetWaveTablePosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaveTablePosition_FunctionAddress, intPtr, SetWaveTablePosition_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetSustainPedalState")]
	public unsafe void SetSustainPedalState(bool InSustainPedalState)
	{
		CheckDestroyed();
		if (!SetSustainPedalState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetSustainPedalState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSustainPedalState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSustainPedalState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSustainPedalState_InSustainPedalState_Offset), 0, SetSustainPedalState_InSustainPedalState_PropertyAddress.Address, InSustainPedalState);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSustainPedalState_FunctionAddress, intPtr, SetSustainPedalState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoType")]
	public unsafe void SetPosLfoType(ESynthLFOType InLfoType)
	{
		CheckDestroyed();
		if (!SetPosLfoType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosLfoType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosLfoType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESynthLFOType>.ToNative(IntPtr.Add(intPtr, SetPosLfoType_InLfoType_Offset), 0, SetPosLfoType_InLfoType_PropertyAddress.Address, InLfoType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosLfoType_FunctionAddress, intPtr, SetPosLfoType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoFrequency")]
	public unsafe void SetPosLfoFrequency(float InLfoFrequency)
	{
		CheckDestroyed();
		if (!SetPosLfoFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosLfoFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosLfoFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPosLfoFrequency_InLfoFrequency_Offset), 0, SetPosLfoFrequency_InLfoFrequency_PropertyAddress.Address, InLfoFrequency);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosLfoFrequency_FunctionAddress, intPtr, SetPosLfoFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoDepth")]
	public unsafe void SetPosLfoDepth(float InLfoDepth)
	{
		CheckDestroyed();
		if (!SetPosLfoDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPosLfoDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPosLfoDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPosLfoDepth_InLfoDepth_Offset), 0, SetPosLfoDepth_InLfoDepth_PropertyAddress.Address, InLfoDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPosLfoDepth_FunctionAddress, intPtr, SetPosLfoDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeSustainGain")]
	public unsafe void SetPositionEnvelopeSustainGain(float InSustainGain)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeSustainGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeSustainGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeSustainGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeSustainGain_InSustainGain_Offset), 0, SetPositionEnvelopeSustainGain_InSustainGain_PropertyAddress.Address, InSustainGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeSustainGain_FunctionAddress, intPtr, SetPositionEnvelopeSustainGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeReleaseTime")]
	public unsafe void SetPositionEnvelopeReleaseTime(float InReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeReleaseTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeReleaseTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeReleaseTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeReleaseTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_Offset), 0, SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeReleaseTime_FunctionAddress, intPtr, SetPositionEnvelopeReleaseTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeInvert")]
	public unsafe void SetPositionEnvelopeInvert(bool bInInvert)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeInvert_bInInvert_Offset), 0, SetPositionEnvelopeInvert_bInInvert_PropertyAddress.Address, bInInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeInvert_FunctionAddress, intPtr, SetPositionEnvelopeInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDepth")]
	public unsafe void SetPositionEnvelopeDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeDepth_InDepth_Offset), 0, SetPositionEnvelopeDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeDepth_FunctionAddress, intPtr, SetPositionEnvelopeDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDecayTime")]
	public unsafe void SetPositionEnvelopeDecayTime(float InDecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDecayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeDecayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeDecayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeDecayTime_InDecayTimeMsec_Offset), 0, SetPositionEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress.Address, InDecayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeDecayTime_FunctionAddress, intPtr, SetPositionEnvelopeDecayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasInvert")]
	public unsafe void SetPositionEnvelopeBiasInvert(bool bInBiasInvert)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeBiasInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeBiasInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeBiasInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeBiasInvert_bInBiasInvert_Offset), 0, SetPositionEnvelopeBiasInvert_bInBiasInvert_PropertyAddress.Address, bInBiasInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeBiasInvert_FunctionAddress, intPtr, SetPositionEnvelopeBiasInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasDepth")]
	public unsafe void SetPositionEnvelopeBiasDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeBiasDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeBiasDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeBiasDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeBiasDepth_InDepth_Offset), 0, SetPositionEnvelopeBiasDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeBiasDepth_FunctionAddress, intPtr, SetPositionEnvelopeBiasDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeAttackTime")]
	public unsafe void SetPositionEnvelopeAttackTime(float InAttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetPositionEnvelopeAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeAttackTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPositionEnvelopeAttackTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPositionEnvelopeAttackTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPositionEnvelopeAttackTime_InAttackTimeMsec_Offset), 0, SetPositionEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPositionEnvelopeAttackTime_FunctionAddress, intPtr, SetPositionEnvelopeAttackTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetLowPassFilterResonance")]
	public unsafe void SetLowPassFilterResonance(float InNewQ)
	{
		CheckDestroyed();
		if (!SetLowPassFilterResonance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetLowPassFilterResonance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLowPassFilterResonance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLowPassFilterResonance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLowPassFilterResonance_InNewQ_Offset), 0, SetLowPassFilterResonance_InNewQ_PropertyAddress.Address, InNewQ);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLowPassFilterResonance_FunctionAddress, intPtr, SetLowPassFilterResonance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyWithMidiNote")]
	public unsafe void SetFrequencyWithMidiNote(float InMidiNote)
	{
		CheckDestroyed();
		if (!SetFrequencyWithMidiNote_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyWithMidiNote");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequencyWithMidiNote_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequencyWithMidiNote_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrequencyWithMidiNote_InMidiNote_Offset), 0, SetFrequencyWithMidiNote_InMidiNote_PropertyAddress.Address, InMidiNote);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequencyWithMidiNote_FunctionAddress, intPtr, SetFrequencyWithMidiNote_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyPitchBend")]
	public unsafe void SetFrequencyPitchBend(float FrequencyOffsetCents)
	{
		CheckDestroyed();
		if (!SetFrequencyPitchBend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyPitchBend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequencyPitchBend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequencyPitchBend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrequencyPitchBend_FrequencyOffsetCents_Offset), 0, SetFrequencyPitchBend_FrequencyOffsetCents_PropertyAddress.Address, FrequencyOffsetCents);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequencyPitchBend_FunctionAddress, intPtr, SetFrequencyPitchBend_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequency")]
	public unsafe void SetFrequency(float FrequencyHz)
	{
		CheckDestroyed();
		if (!SetFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequency");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrequency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrequency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrequency_FrequencyHz_Offset), 0, SetFrequency_FrequencyHz_PropertyAddress.Address, FrequencyHz);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrequency_FunctionAddress, intPtr, SetFrequency_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeSustainGain")]
	public unsafe void SetFilterEnvelopeSustainGain(float InSustainGain)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeSustainGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeSustainGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeSustainGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeSustainGain_InSustainGain_Offset), 0, SetFilterEnvelopeSustainGain_InSustainGain_PropertyAddress.Address, InSustainGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeSustainGain_FunctionAddress, intPtr, SetFilterEnvelopeSustainGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeReleaseTime")]
	public unsafe void SetFilterEnvelopeReleaseTime(float InReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeReleaseTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeReleaseTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeReleaseTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeReleaseTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_Offset), 0, SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeReleaseTime_FunctionAddress, intPtr, SetFilterEnvelopeReleaseTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopenDecayTime")]
	public unsafe void SetFilterEnvelopenDecayTime(float InDecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopenDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopenDecayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopenDecayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopenDecayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopenDecayTime_InDecayTimeMsec_Offset), 0, SetFilterEnvelopenDecayTime_InDecayTimeMsec_PropertyAddress.Address, InDecayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopenDecayTime_FunctionAddress, intPtr, SetFilterEnvelopenDecayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeInvert")]
	public unsafe void SetFilterEnvelopeInvert(bool bInInvert)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeInvert_bInInvert_Offset), 0, SetFilterEnvelopeInvert_bInInvert_PropertyAddress.Address, bInInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeInvert_FunctionAddress, intPtr, SetFilterEnvelopeInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeDepth")]
	public unsafe void SetFilterEnvelopeDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeDepth_InDepth_Offset), 0, SetFilterEnvelopeDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeDepth_FunctionAddress, intPtr, SetFilterEnvelopeDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasInvert")]
	public unsafe void SetFilterEnvelopeBiasInvert(bool bInBiasInvert)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeBiasInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeBiasInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeBiasInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeBiasInvert_bInBiasInvert_Offset), 0, SetFilterEnvelopeBiasInvert_bInBiasInvert_PropertyAddress.Address, bInBiasInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeBiasInvert_FunctionAddress, intPtr, SetFilterEnvelopeBiasInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasDepth")]
	public unsafe void SetFilterEnvelopeBiasDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeBiasDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeBiasDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeBiasDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeBiasDepth_InDepth_Offset), 0, SetFilterEnvelopeBiasDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeBiasDepth_FunctionAddress, intPtr, SetFilterEnvelopeBiasDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeAttackTime")]
	public unsafe void SetFilterEnvelopeAttackTime(float InAttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetFilterEnvelopeAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeAttackTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilterEnvelopeAttackTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilterEnvelopeAttackTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFilterEnvelopeAttackTime_InAttackTimeMsec_Offset), 0, SetFilterEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilterEnvelopeAttackTime_FunctionAddress, intPtr, SetFilterEnvelopeAttackTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveValue")]
	public unsafe bool SetCurveValue(int TableIndex, int KeyframeIndex, float NewValue)
	{
		CheckDestroyed();
		if (!SetCurveValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveValue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveValue_TableIndex_Offset), 0, SetCurveValue_TableIndex_PropertyAddress.Address, TableIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveValue_KeyframeIndex_Offset), 0, SetCurveValue_KeyframeIndex_PropertyAddress.Address, KeyframeIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurveValue_NewValue_Offset), 0, SetCurveValue_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveValue_FunctionAddress, intPtr, SetCurveValue_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveValue_ReturnValue_Offset), 0, SetCurveValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveTangent")]
	public unsafe bool SetCurveTangent(int TableIndex, float InNewTangent)
	{
		CheckDestroyed();
		if (!SetCurveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveTangent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveTangent_TableIndex_Offset), 0, SetCurveTangent_TableIndex_PropertyAddress.Address, TableIndex);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCurveTangent_InNewTangent_Offset), 0, SetCurveTangent_InNewTangent_PropertyAddress.Address, InNewTangent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveTangent_FunctionAddress, intPtr, SetCurveTangent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveTangent_ReturnValue_Offset), 0, SetCurveTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveInterpolationType")]
	public unsafe bool SetCurveInterpolationType(ECurveInterpolationType InterpolationType, int TableIndex)
	{
		CheckDestroyed();
		if (!SetCurveInterpolationType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveInterpolationType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurveInterpolationType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurveInterpolationType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECurveInterpolationType>.ToNative(IntPtr.Add(intPtr, SetCurveInterpolationType_InterpolationType_Offset), 0, SetCurveInterpolationType_InterpolationType_PropertyAddress.Address, InterpolationType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCurveInterpolationType_TableIndex_Offset), 0, SetCurveInterpolationType_TableIndex_PropertyAddress.Address, TableIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCurveInterpolationType_FunctionAddress, intPtr, SetCurveInterpolationType_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCurveInterpolationType_ReturnValue_Offset), 0, SetCurveInterpolationType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeSustainGain")]
	public unsafe void SetAmpEnvelopeSustainGain(float InSustainGain)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeSustainGain");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeSustainGain_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeSustainGain_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeSustainGain_InSustainGain_Offset), 0, SetAmpEnvelopeSustainGain_InSustainGain_PropertyAddress.Address, InSustainGain);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeSustainGain_FunctionAddress, intPtr, SetAmpEnvelopeSustainGain_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeReleaseTime")]
	public unsafe void SetAmpEnvelopeReleaseTime(float InReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeReleaseTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeReleaseTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeReleaseTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeReleaseTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_Offset), 0, SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress.Address, InReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeReleaseTime_FunctionAddress, intPtr, SetAmpEnvelopeReleaseTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeInvert")]
	public unsafe void SetAmpEnvelopeInvert(bool bInInvert)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeInvert_bInInvert_Offset), 0, SetAmpEnvelopeInvert_bInInvert_PropertyAddress.Address, bInInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeInvert_FunctionAddress, intPtr, SetAmpEnvelopeInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDepth")]
	public unsafe void SetAmpEnvelopeDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeDepth_InDepth_Offset), 0, SetAmpEnvelopeDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeDepth_FunctionAddress, intPtr, SetAmpEnvelopeDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDecayTime")]
	public unsafe void SetAmpEnvelopeDecayTime(float InDecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDecayTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeDecayTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeDecayTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeDecayTime_InDecayTimeMsec_Offset), 0, SetAmpEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress.Address, InDecayTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeDecayTime_FunctionAddress, intPtr, SetAmpEnvelopeDecayTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasInvert")]
	public unsafe void SetAmpEnvelopeBiasInvert(bool bInBiasInvert)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeBiasInvert_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasInvert");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeBiasInvert_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeBiasInvert_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeBiasInvert_bInBiasInvert_Offset), 0, SetAmpEnvelopeBiasInvert_bInBiasInvert_PropertyAddress.Address, bInBiasInvert);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeBiasInvert_FunctionAddress, intPtr, SetAmpEnvelopeBiasInvert_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasDepth")]
	public unsafe void SetAmpEnvelopeBiasDepth(float InDepth)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeBiasDepth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasDepth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeBiasDepth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeBiasDepth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeBiasDepth_InDepth_Offset), 0, SetAmpEnvelopeBiasDepth_InDepth_PropertyAddress.Address, InDepth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeBiasDepth_FunctionAddress, intPtr, SetAmpEnvelopeBiasDepth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeAttackTime")]
	public unsafe void SetAmpEnvelopeAttackTime(float InAttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetAmpEnvelopeAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeAttackTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAmpEnvelopeAttackTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAmpEnvelopeAttackTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAmpEnvelopeAttackTime_InAttackTimeMsec_Offset), 0, SetAmpEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress.Address, InAttackTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAmpEnvelopeAttackTime_FunctionAddress, intPtr, SetAmpEnvelopeAttackTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshWaveTable")]
	public unsafe void RefreshWaveTable(int Index)
	{
		CheckDestroyed();
		if (!RefreshWaveTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshWaveTable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshWaveTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshWaveTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RefreshWaveTable_Index_Offset), 0, RefreshWaveTable_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, RefreshWaveTable_FunctionAddress, intPtr, RefreshWaveTable_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshAllWaveTables")]
	public unsafe void RefreshAllWaveTables()
	{
		CheckDestroyed();
		if (!RefreshAllWaveTables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshAllWaveTables");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshAllWaveTables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshAllWaveTables_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshAllWaveTables_FunctionAddress, argsSize: RefreshAllWaveTables_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOn")]
	public unsafe void NoteOn(float InMidiNote, float InVelocity)
	{
		CheckDestroyed();
		if (!NoteOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoteOn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoteOn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOn_InMidiNote_Offset), 0, NoteOn_InMidiNote_PropertyAddress.Address, InMidiNote);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOn_InVelocity_Offset), 0, NoteOn_InVelocity_PropertyAddress.Address, InVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, NoteOn_FunctionAddress, intPtr, NoteOn_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOff")]
	public unsafe void NoteOff(float InMidiNote)
	{
		CheckDestroyed();
		if (!NoteOff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOff");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoteOff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoteOff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOff_InMidiNote_Offset), 0, NoteOff_InMidiNote_PropertyAddress.Address, InMidiNote);
		NativeReflection.InvokeFunctionOptimized(base.Address, NoteOff_FunctionAddress, intPtr, NoteOff_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:GetNumTableEntries")]
	public unsafe int GetNumTableEntries()
	{
		CheckDestroyed();
		if (!GetNumTableEntries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:GetNumTableEntries");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumTableEntries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumTableEntries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumTableEntries_FunctionAddress, intPtr, GetNumTableEntries_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumTableEntries_ReturnValue_Offset), 0, GetNumTableEntries_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:GetMaxTableIndex")]
	public unsafe int GetMaxTableIndex()
	{
		CheckDestroyed();
		if (!GetMaxTableIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:GetMaxTableIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxTableIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxTableIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxTableIndex_FunctionAddress, intPtr, GetMaxTableIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetMaxTableIndex_ReturnValue_Offset), 0, GetMaxTableIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:GetKeyFrameValuesForTable")]
	public unsafe List<float> GetKeyFrameValuesForTable(float TableIndex)
	{
		CheckDestroyed();
		if (!GetKeyFrameValuesForTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:GetKeyFrameValuesForTable");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyFrameValuesForTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyFrameValuesForTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetKeyFrameValuesForTable_TableIndex_Offset), 0, GetKeyFrameValuesForTable_TableIndex_PropertyAddress.Address, TableIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetKeyFrameValuesForTable_FunctionAddress, intPtr, GetKeyFrameValuesForTable_ParamsSize);
		List<float> result = new TArrayCopyMarshaler<float>(1, GetKeyFrameValuesForTable_ReturnValue_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetKeyFrameValuesForTable_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetKeyFrameValuesForTable_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthComponentMonoWaveTable:GetCurveTangent")]
	public unsafe float GetCurveTangent(int TableIndex)
	{
		CheckDestroyed();
		if (!GetCurveTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthComponentMonoWaveTable:GetCurveTangent");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurveTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurveTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetCurveTangent_TableIndex_Offset), 0, GetCurveTangent_TableIndex_PropertyAddress.Address, TableIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurveTangent_FunctionAddress, intPtr, GetCurveTangent_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurveTangent_ReturnValue_Offset), 0, GetCurveTangent_ReturnValue_PropertyAddress.Address);
	}

	static USynthComponentMonoWaveTable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthComponentMonoWaveTable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthComponentMonoWaveTable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SynthComponentMonoWaveTable");
		OnTableAltered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTableAltered");
		OnTableAltered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTableAltered", Classes.FMulticastDelegateProperty);
		OnNumTablesChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnNumTablesChanged");
		OnNumTablesChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnNumTablesChanged", Classes.FMulticastDelegateProperty);
		SetWaveTablePosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaveTablePosition");
		SetWaveTablePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaveTablePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaveTablePosition_InPosition_PropertyAddress, SetWaveTablePosition_FunctionAddress, "InPosition");
		SetWaveTablePosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(SetWaveTablePosition_FunctionAddress, "InPosition");
		SetWaveTablePosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaveTablePosition_FunctionAddress, "InPosition", Classes.FFloatProperty);
		SetWaveTablePosition_IsValid = SetWaveTablePosition_FunctionAddress != IntPtr.Zero && SetWaveTablePosition_InPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetWaveTablePosition", SetWaveTablePosition_IsValid);
		SetSustainPedalState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSustainPedalState");
		SetSustainPedalState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSustainPedalState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSustainPedalState_InSustainPedalState_PropertyAddress, SetSustainPedalState_FunctionAddress, "InSustainPedalState");
		SetSustainPedalState_InSustainPedalState_Offset = NativeReflectionCached.GetPropertyOffset(SetSustainPedalState_FunctionAddress, "InSustainPedalState");
		SetSustainPedalState_InSustainPedalState_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSustainPedalState_FunctionAddress, "InSustainPedalState", Classes.FBoolProperty);
		SetSustainPedalState_IsValid = SetSustainPedalState_FunctionAddress != IntPtr.Zero && SetSustainPedalState_InSustainPedalState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetSustainPedalState", SetSustainPedalState_IsValid);
		SetPosLfoType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPosLfoType");
		SetPosLfoType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosLfoType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosLfoType_InLfoType_PropertyAddress, SetPosLfoType_FunctionAddress, "InLfoType");
		SetPosLfoType_InLfoType_Offset = NativeReflectionCached.GetPropertyOffset(SetPosLfoType_FunctionAddress, "InLfoType");
		SetPosLfoType_InLfoType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosLfoType_FunctionAddress, "InLfoType", Classes.FEnumProperty);
		SetPosLfoType_IsValid = SetPosLfoType_FunctionAddress != IntPtr.Zero && SetPosLfoType_InLfoType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoType", SetPosLfoType_IsValid);
		SetPosLfoFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPosLfoFrequency");
		SetPosLfoFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosLfoFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosLfoFrequency_InLfoFrequency_PropertyAddress, SetPosLfoFrequency_FunctionAddress, "InLfoFrequency");
		SetPosLfoFrequency_InLfoFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetPosLfoFrequency_FunctionAddress, "InLfoFrequency");
		SetPosLfoFrequency_InLfoFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosLfoFrequency_FunctionAddress, "InLfoFrequency", Classes.FFloatProperty);
		SetPosLfoFrequency_IsValid = SetPosLfoFrequency_FunctionAddress != IntPtr.Zero && SetPosLfoFrequency_InLfoFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoFrequency", SetPosLfoFrequency_IsValid);
		SetPosLfoDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPosLfoDepth");
		SetPosLfoDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPosLfoDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPosLfoDepth_InLfoDepth_PropertyAddress, SetPosLfoDepth_FunctionAddress, "InLfoDepth");
		SetPosLfoDepth_InLfoDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetPosLfoDepth_FunctionAddress, "InLfoDepth");
		SetPosLfoDepth_InLfoDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPosLfoDepth_FunctionAddress, "InLfoDepth", Classes.FFloatProperty);
		SetPosLfoDepth_IsValid = SetPosLfoDepth_FunctionAddress != IntPtr.Zero && SetPosLfoDepth_InLfoDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPosLfoDepth", SetPosLfoDepth_IsValid);
		SetPositionEnvelopeSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeSustainGain");
		SetPositionEnvelopeSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeSustainGain_InSustainGain_PropertyAddress, SetPositionEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetPositionEnvelopeSustainGain_InSustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetPositionEnvelopeSustainGain_InSustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeSustainGain_FunctionAddress, "InSustainGain", Classes.FFloatProperty);
		SetPositionEnvelopeSustainGain_IsValid = SetPositionEnvelopeSustainGain_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeSustainGain_InSustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeSustainGain", SetPositionEnvelopeSustainGain_IsValid);
		SetPositionEnvelopeReleaseTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeReleaseTime");
		SetPositionEnvelopeReleaseTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeReleaseTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress, SetPositionEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec", Classes.FFloatProperty);
		SetPositionEnvelopeReleaseTime_IsValid = SetPositionEnvelopeReleaseTime_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeReleaseTime", SetPositionEnvelopeReleaseTime_IsValid);
		SetPositionEnvelopeInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeInvert");
		SetPositionEnvelopeInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeInvert_bInInvert_PropertyAddress, SetPositionEnvelopeInvert_FunctionAddress, "bInInvert");
		SetPositionEnvelopeInvert_bInInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeInvert_FunctionAddress, "bInInvert");
		SetPositionEnvelopeInvert_bInInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeInvert_FunctionAddress, "bInInvert", Classes.FBoolProperty);
		SetPositionEnvelopeInvert_IsValid = SetPositionEnvelopeInvert_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeInvert_bInInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeInvert", SetPositionEnvelopeInvert_IsValid);
		SetPositionEnvelopeDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeDepth");
		SetPositionEnvelopeDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeDepth_InDepth_PropertyAddress, SetPositionEnvelopeDepth_FunctionAddress, "InDepth");
		SetPositionEnvelopeDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeDepth_FunctionAddress, "InDepth");
		SetPositionEnvelopeDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetPositionEnvelopeDepth_IsValid = SetPositionEnvelopeDepth_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDepth", SetPositionEnvelopeDepth_IsValid);
		SetPositionEnvelopeDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeDecayTime");
		SetPositionEnvelopeDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress, SetPositionEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetPositionEnvelopeDecayTime_InDecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetPositionEnvelopeDecayTime_InDecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec", Classes.FFloatProperty);
		SetPositionEnvelopeDecayTime_IsValid = SetPositionEnvelopeDecayTime_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeDecayTime_InDecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeDecayTime", SetPositionEnvelopeDecayTime_IsValid);
		SetPositionEnvelopeBiasInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeBiasInvert");
		SetPositionEnvelopeBiasInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeBiasInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeBiasInvert_bInBiasInvert_PropertyAddress, SetPositionEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetPositionEnvelopeBiasInvert_bInBiasInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetPositionEnvelopeBiasInvert_bInBiasInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert", Classes.FBoolProperty);
		SetPositionEnvelopeBiasInvert_IsValid = SetPositionEnvelopeBiasInvert_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeBiasInvert_bInBiasInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasInvert", SetPositionEnvelopeBiasInvert_IsValid);
		SetPositionEnvelopeBiasDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeBiasDepth");
		SetPositionEnvelopeBiasDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeBiasDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeBiasDepth_InDepth_PropertyAddress, SetPositionEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetPositionEnvelopeBiasDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetPositionEnvelopeBiasDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeBiasDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetPositionEnvelopeBiasDepth_IsValid = SetPositionEnvelopeBiasDepth_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeBiasDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeBiasDepth", SetPositionEnvelopeBiasDepth_IsValid);
		SetPositionEnvelopeAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPositionEnvelopeAttackTime");
		SetPositionEnvelopeAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPositionEnvelopeAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPositionEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress, SetPositionEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetPositionEnvelopeAttackTime_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetPositionEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetPositionEnvelopeAttackTime_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPositionEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec", Classes.FFloatProperty);
		SetPositionEnvelopeAttackTime_IsValid = SetPositionEnvelopeAttackTime_FunctionAddress != IntPtr.Zero && SetPositionEnvelopeAttackTime_InAttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetPositionEnvelopeAttackTime", SetPositionEnvelopeAttackTime_IsValid);
		SetLowPassFilterResonance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowPassFilterResonance");
		SetLowPassFilterResonance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowPassFilterResonance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowPassFilterResonance_InNewQ_PropertyAddress, SetLowPassFilterResonance_FunctionAddress, "InNewQ");
		SetLowPassFilterResonance_InNewQ_Offset = NativeReflectionCached.GetPropertyOffset(SetLowPassFilterResonance_FunctionAddress, "InNewQ");
		SetLowPassFilterResonance_InNewQ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowPassFilterResonance_FunctionAddress, "InNewQ", Classes.FFloatProperty);
		SetLowPassFilterResonance_IsValid = SetLowPassFilterResonance_FunctionAddress != IntPtr.Zero && SetLowPassFilterResonance_InNewQ_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetLowPassFilterResonance", SetLowPassFilterResonance_IsValid);
		SetFrequencyWithMidiNote_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequencyWithMidiNote");
		SetFrequencyWithMidiNote_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequencyWithMidiNote_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequencyWithMidiNote_InMidiNote_PropertyAddress, SetFrequencyWithMidiNote_FunctionAddress, "InMidiNote");
		SetFrequencyWithMidiNote_InMidiNote_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequencyWithMidiNote_FunctionAddress, "InMidiNote");
		SetFrequencyWithMidiNote_InMidiNote_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequencyWithMidiNote_FunctionAddress, "InMidiNote", Classes.FFloatProperty);
		SetFrequencyWithMidiNote_IsValid = SetFrequencyWithMidiNote_FunctionAddress != IntPtr.Zero && SetFrequencyWithMidiNote_InMidiNote_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyWithMidiNote", SetFrequencyWithMidiNote_IsValid);
		SetFrequencyPitchBend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequencyPitchBend");
		SetFrequencyPitchBend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequencyPitchBend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequencyPitchBend_FrequencyOffsetCents_PropertyAddress, SetFrequencyPitchBend_FunctionAddress, "FrequencyOffsetCents");
		SetFrequencyPitchBend_FrequencyOffsetCents_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequencyPitchBend_FunctionAddress, "FrequencyOffsetCents");
		SetFrequencyPitchBend_FrequencyOffsetCents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequencyPitchBend_FunctionAddress, "FrequencyOffsetCents", Classes.FFloatProperty);
		SetFrequencyPitchBend_IsValid = SetFrequencyPitchBend_FunctionAddress != IntPtr.Zero && SetFrequencyPitchBend_FrequencyOffsetCents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequencyPitchBend", SetFrequencyPitchBend_IsValid);
		SetFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrequency");
		SetFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrequency_FrequencyHz_PropertyAddress, SetFrequency_FunctionAddress, "FrequencyHz");
		SetFrequency_FrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(SetFrequency_FunctionAddress, "FrequencyHz");
		SetFrequency_FrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrequency_FunctionAddress, "FrequencyHz", Classes.FFloatProperty);
		SetFrequency_IsValid = SetFrequency_FunctionAddress != IntPtr.Zero && SetFrequency_FrequencyHz_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFrequency", SetFrequency_IsValid);
		SetFilterEnvelopeSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeSustainGain");
		SetFilterEnvelopeSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeSustainGain_InSustainGain_PropertyAddress, SetFilterEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetFilterEnvelopeSustainGain_InSustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetFilterEnvelopeSustainGain_InSustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeSustainGain_FunctionAddress, "InSustainGain", Classes.FFloatProperty);
		SetFilterEnvelopeSustainGain_IsValid = SetFilterEnvelopeSustainGain_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeSustainGain_InSustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeSustainGain", SetFilterEnvelopeSustainGain_IsValid);
		SetFilterEnvelopeReleaseTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeReleaseTime");
		SetFilterEnvelopeReleaseTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeReleaseTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress, SetFilterEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec", Classes.FFloatProperty);
		SetFilterEnvelopeReleaseTime_IsValid = SetFilterEnvelopeReleaseTime_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeReleaseTime", SetFilterEnvelopeReleaseTime_IsValid);
		SetFilterEnvelopenDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopenDecayTime");
		SetFilterEnvelopenDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopenDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopenDecayTime_InDecayTimeMsec_PropertyAddress, SetFilterEnvelopenDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetFilterEnvelopenDecayTime_InDecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopenDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetFilterEnvelopenDecayTime_InDecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopenDecayTime_FunctionAddress, "InDecayTimeMsec", Classes.FFloatProperty);
		SetFilterEnvelopenDecayTime_IsValid = SetFilterEnvelopenDecayTime_FunctionAddress != IntPtr.Zero && SetFilterEnvelopenDecayTime_InDecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopenDecayTime", SetFilterEnvelopenDecayTime_IsValid);
		SetFilterEnvelopeInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeInvert");
		SetFilterEnvelopeInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeInvert_bInInvert_PropertyAddress, SetFilterEnvelopeInvert_FunctionAddress, "bInInvert");
		SetFilterEnvelopeInvert_bInInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeInvert_FunctionAddress, "bInInvert");
		SetFilterEnvelopeInvert_bInInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeInvert_FunctionAddress, "bInInvert", Classes.FBoolProperty);
		SetFilterEnvelopeInvert_IsValid = SetFilterEnvelopeInvert_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeInvert_bInInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeInvert", SetFilterEnvelopeInvert_IsValid);
		SetFilterEnvelopeDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeDepth");
		SetFilterEnvelopeDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeDepth_InDepth_PropertyAddress, SetFilterEnvelopeDepth_FunctionAddress, "InDepth");
		SetFilterEnvelopeDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeDepth_FunctionAddress, "InDepth");
		SetFilterEnvelopeDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetFilterEnvelopeDepth_IsValid = SetFilterEnvelopeDepth_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeDepth", SetFilterEnvelopeDepth_IsValid);
		SetFilterEnvelopeBiasInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeBiasInvert");
		SetFilterEnvelopeBiasInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeBiasInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeBiasInvert_bInBiasInvert_PropertyAddress, SetFilterEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetFilterEnvelopeBiasInvert_bInBiasInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetFilterEnvelopeBiasInvert_bInBiasInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert", Classes.FBoolProperty);
		SetFilterEnvelopeBiasInvert_IsValid = SetFilterEnvelopeBiasInvert_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeBiasInvert_bInBiasInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasInvert", SetFilterEnvelopeBiasInvert_IsValid);
		SetFilterEnvelopeBiasDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeBiasDepth");
		SetFilterEnvelopeBiasDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeBiasDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeBiasDepth_InDepth_PropertyAddress, SetFilterEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetFilterEnvelopeBiasDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetFilterEnvelopeBiasDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeBiasDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetFilterEnvelopeBiasDepth_IsValid = SetFilterEnvelopeBiasDepth_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeBiasDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeBiasDepth", SetFilterEnvelopeBiasDepth_IsValid);
		SetFilterEnvelopeAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilterEnvelopeAttackTime");
		SetFilterEnvelopeAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilterEnvelopeAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilterEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress, SetFilterEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetFilterEnvelopeAttackTime_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetFilterEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetFilterEnvelopeAttackTime_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilterEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec", Classes.FFloatProperty);
		SetFilterEnvelopeAttackTime_IsValid = SetFilterEnvelopeAttackTime_FunctionAddress != IntPtr.Zero && SetFilterEnvelopeAttackTime_InAttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetFilterEnvelopeAttackTime", SetFilterEnvelopeAttackTime_IsValid);
		SetCurveValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCurveValue");
		SetCurveValue_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_TableIndex_PropertyAddress, SetCurveValue_FunctionAddress, "TableIndex");
		SetCurveValue_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "TableIndex");
		SetCurveValue_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "TableIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_KeyframeIndex_PropertyAddress, SetCurveValue_FunctionAddress, "KeyframeIndex");
		SetCurveValue_KeyframeIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "KeyframeIndex");
		SetCurveValue_KeyframeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "KeyframeIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_NewValue_PropertyAddress, SetCurveValue_FunctionAddress, "NewValue");
		SetCurveValue_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "NewValue");
		SetCurveValue_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "NewValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveValue_ReturnValue_PropertyAddress, SetCurveValue_FunctionAddress, "ReturnValue");
		SetCurveValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveValue_FunctionAddress, "ReturnValue");
		SetCurveValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveValue_IsValid = SetCurveValue_FunctionAddress != IntPtr.Zero && SetCurveValue_TableIndex_IsValid && SetCurveValue_KeyframeIndex_IsValid && SetCurveValue_NewValue_IsValid && SetCurveValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveValue", SetCurveValue_IsValid);
		SetCurveTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCurveTangent");
		SetCurveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveTangent_TableIndex_PropertyAddress, SetCurveTangent_FunctionAddress, "TableIndex");
		SetCurveTangent_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveTangent_FunctionAddress, "TableIndex");
		SetCurveTangent_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveTangent_FunctionAddress, "TableIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveTangent_InNewTangent_PropertyAddress, SetCurveTangent_FunctionAddress, "InNewTangent");
		SetCurveTangent_InNewTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveTangent_FunctionAddress, "InNewTangent");
		SetCurveTangent_InNewTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveTangent_FunctionAddress, "InNewTangent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveTangent_ReturnValue_PropertyAddress, SetCurveTangent_FunctionAddress, "ReturnValue");
		SetCurveTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveTangent_FunctionAddress, "ReturnValue");
		SetCurveTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveTangent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveTangent_IsValid = SetCurveTangent_FunctionAddress != IntPtr.Zero && SetCurveTangent_TableIndex_IsValid && SetCurveTangent_InNewTangent_IsValid && SetCurveTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveTangent", SetCurveTangent_IsValid);
		SetCurveInterpolationType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCurveInterpolationType");
		SetCurveInterpolationType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurveInterpolationType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurveInterpolationType_InterpolationType_PropertyAddress, SetCurveInterpolationType_FunctionAddress, "InterpolationType");
		SetCurveInterpolationType_InterpolationType_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveInterpolationType_FunctionAddress, "InterpolationType");
		SetCurveInterpolationType_InterpolationType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveInterpolationType_FunctionAddress, "InterpolationType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveInterpolationType_TableIndex_PropertyAddress, SetCurveInterpolationType_FunctionAddress, "TableIndex");
		SetCurveInterpolationType_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveInterpolationType_FunctionAddress, "TableIndex");
		SetCurveInterpolationType_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveInterpolationType_FunctionAddress, "TableIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurveInterpolationType_ReturnValue_PropertyAddress, SetCurveInterpolationType_FunctionAddress, "ReturnValue");
		SetCurveInterpolationType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCurveInterpolationType_FunctionAddress, "ReturnValue");
		SetCurveInterpolationType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurveInterpolationType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCurveInterpolationType_IsValid = SetCurveInterpolationType_FunctionAddress != IntPtr.Zero && SetCurveInterpolationType_InterpolationType_IsValid && SetCurveInterpolationType_TableIndex_IsValid && SetCurveInterpolationType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetCurveInterpolationType", SetCurveInterpolationType_IsValid);
		SetAmpEnvelopeSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeSustainGain");
		SetAmpEnvelopeSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeSustainGain_InSustainGain_PropertyAddress, SetAmpEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetAmpEnvelopeSustainGain_InSustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeSustainGain_FunctionAddress, "InSustainGain");
		SetAmpEnvelopeSustainGain_InSustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeSustainGain_FunctionAddress, "InSustainGain", Classes.FFloatProperty);
		SetAmpEnvelopeSustainGain_IsValid = SetAmpEnvelopeSustainGain_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeSustainGain_InSustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeSustainGain", SetAmpEnvelopeSustainGain_IsValid);
		SetAmpEnvelopeReleaseTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeReleaseTime");
		SetAmpEnvelopeReleaseTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeReleaseTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_PropertyAddress, SetAmpEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec");
		SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeReleaseTime_FunctionAddress, "InReleaseTimeMsec", Classes.FFloatProperty);
		SetAmpEnvelopeReleaseTime_IsValid = SetAmpEnvelopeReleaseTime_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeReleaseTime_InReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeReleaseTime", SetAmpEnvelopeReleaseTime_IsValid);
		SetAmpEnvelopeInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeInvert");
		SetAmpEnvelopeInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeInvert_bInInvert_PropertyAddress, SetAmpEnvelopeInvert_FunctionAddress, "bInInvert");
		SetAmpEnvelopeInvert_bInInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeInvert_FunctionAddress, "bInInvert");
		SetAmpEnvelopeInvert_bInInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeInvert_FunctionAddress, "bInInvert", Classes.FBoolProperty);
		SetAmpEnvelopeInvert_IsValid = SetAmpEnvelopeInvert_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeInvert_bInInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeInvert", SetAmpEnvelopeInvert_IsValid);
		SetAmpEnvelopeDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeDepth");
		SetAmpEnvelopeDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeDepth_InDepth_PropertyAddress, SetAmpEnvelopeDepth_FunctionAddress, "InDepth");
		SetAmpEnvelopeDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeDepth_FunctionAddress, "InDepth");
		SetAmpEnvelopeDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetAmpEnvelopeDepth_IsValid = SetAmpEnvelopeDepth_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDepth", SetAmpEnvelopeDepth_IsValid);
		SetAmpEnvelopeDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeDecayTime");
		SetAmpEnvelopeDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeDecayTime_InDecayTimeMsec_PropertyAddress, SetAmpEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetAmpEnvelopeDecayTime_InDecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec");
		SetAmpEnvelopeDecayTime_InDecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeDecayTime_FunctionAddress, "InDecayTimeMsec", Classes.FFloatProperty);
		SetAmpEnvelopeDecayTime_IsValid = SetAmpEnvelopeDecayTime_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeDecayTime_InDecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeDecayTime", SetAmpEnvelopeDecayTime_IsValid);
		SetAmpEnvelopeBiasInvert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeBiasInvert");
		SetAmpEnvelopeBiasInvert_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeBiasInvert_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeBiasInvert_bInBiasInvert_PropertyAddress, SetAmpEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetAmpEnvelopeBiasInvert_bInBiasInvert_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert");
		SetAmpEnvelopeBiasInvert_bInBiasInvert_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeBiasInvert_FunctionAddress, "bInBiasInvert", Classes.FBoolProperty);
		SetAmpEnvelopeBiasInvert_IsValid = SetAmpEnvelopeBiasInvert_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeBiasInvert_bInBiasInvert_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasInvert", SetAmpEnvelopeBiasInvert_IsValid);
		SetAmpEnvelopeBiasDepth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeBiasDepth");
		SetAmpEnvelopeBiasDepth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeBiasDepth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeBiasDepth_InDepth_PropertyAddress, SetAmpEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetAmpEnvelopeBiasDepth_InDepth_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeBiasDepth_FunctionAddress, "InDepth");
		SetAmpEnvelopeBiasDepth_InDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeBiasDepth_FunctionAddress, "InDepth", Classes.FFloatProperty);
		SetAmpEnvelopeBiasDepth_IsValid = SetAmpEnvelopeBiasDepth_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeBiasDepth_InDepth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeBiasDepth", SetAmpEnvelopeBiasDepth_IsValid);
		SetAmpEnvelopeAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAmpEnvelopeAttackTime");
		SetAmpEnvelopeAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAmpEnvelopeAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAmpEnvelopeAttackTime_InAttackTimeMsec_PropertyAddress, SetAmpEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetAmpEnvelopeAttackTime_InAttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetAmpEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec");
		SetAmpEnvelopeAttackTime_InAttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAmpEnvelopeAttackTime_FunctionAddress, "InAttackTimeMsec", Classes.FFloatProperty);
		SetAmpEnvelopeAttackTime_IsValid = SetAmpEnvelopeAttackTime_FunctionAddress != IntPtr.Zero && SetAmpEnvelopeAttackTime_InAttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:SetAmpEnvelopeAttackTime", SetAmpEnvelopeAttackTime_IsValid);
		RefreshWaveTable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshWaveTable");
		RefreshWaveTable_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshWaveTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshWaveTable_Index_PropertyAddress, RefreshWaveTable_FunctionAddress, "Index");
		RefreshWaveTable_Index_Offset = NativeReflectionCached.GetPropertyOffset(RefreshWaveTable_FunctionAddress, "Index");
		RefreshWaveTable_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshWaveTable_FunctionAddress, "Index", Classes.FIntProperty);
		RefreshWaveTable_IsValid = RefreshWaveTable_FunctionAddress != IntPtr.Zero && RefreshWaveTable_Index_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshWaveTable", RefreshWaveTable_IsValid);
		RefreshAllWaveTables_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshAllWaveTables");
		RefreshAllWaveTables_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshAllWaveTables_FunctionAddress);
		RefreshAllWaveTables_IsValid = RefreshAllWaveTables_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:RefreshAllWaveTables", RefreshAllWaveTables_IsValid);
		NoteOn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NoteOn");
		NoteOn_ParamsSize = NativeReflection.GetFunctionParamsSize(NoteOn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoteOn_InMidiNote_PropertyAddress, NoteOn_FunctionAddress, "InMidiNote");
		NoteOn_InMidiNote_Offset = NativeReflectionCached.GetPropertyOffset(NoteOn_FunctionAddress, "InMidiNote");
		NoteOn_InMidiNote_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOn_FunctionAddress, "InMidiNote", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOn_InVelocity_PropertyAddress, NoteOn_FunctionAddress, "InVelocity");
		NoteOn_InVelocity_Offset = NativeReflectionCached.GetPropertyOffset(NoteOn_FunctionAddress, "InVelocity");
		NoteOn_InVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOn_FunctionAddress, "InVelocity", Classes.FFloatProperty);
		NoteOn_IsValid = NoteOn_FunctionAddress != IntPtr.Zero && NoteOn_InMidiNote_IsValid && NoteOn_InVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOn", NoteOn_IsValid);
		NoteOff_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NoteOff");
		NoteOff_ParamsSize = NativeReflection.GetFunctionParamsSize(NoteOff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_InMidiNote_PropertyAddress, NoteOff_FunctionAddress, "InMidiNote");
		NoteOff_InMidiNote_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "InMidiNote");
		NoteOff_InMidiNote_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "InMidiNote", Classes.FFloatProperty);
		NoteOff_IsValid = NoteOff_FunctionAddress != IntPtr.Zero && NoteOff_InMidiNote_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:NoteOff", NoteOff_IsValid);
		GetNumTableEntries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNumTableEntries");
		GetNumTableEntries_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumTableEntries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumTableEntries_ReturnValue_PropertyAddress, GetNumTableEntries_FunctionAddress, "ReturnValue");
		GetNumTableEntries_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumTableEntries_FunctionAddress, "ReturnValue");
		GetNumTableEntries_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumTableEntries_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumTableEntries_IsValid = GetNumTableEntries_FunctionAddress != IntPtr.Zero && GetNumTableEntries_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:GetNumTableEntries", GetNumTableEntries_IsValid);
		GetMaxTableIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxTableIndex");
		GetMaxTableIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxTableIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxTableIndex_ReturnValue_PropertyAddress, GetMaxTableIndex_FunctionAddress, "ReturnValue");
		GetMaxTableIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxTableIndex_FunctionAddress, "ReturnValue");
		GetMaxTableIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxTableIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetMaxTableIndex_IsValid = GetMaxTableIndex_FunctionAddress != IntPtr.Zero && GetMaxTableIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:GetMaxTableIndex", GetMaxTableIndex_IsValid);
		GetKeyFrameValuesForTable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetKeyFrameValuesForTable");
		GetKeyFrameValuesForTable_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyFrameValuesForTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyFrameValuesForTable_TableIndex_PropertyAddress, GetKeyFrameValuesForTable_FunctionAddress, "TableIndex");
		GetKeyFrameValuesForTable_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyFrameValuesForTable_FunctionAddress, "TableIndex");
		GetKeyFrameValuesForTable_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyFrameValuesForTable_FunctionAddress, "TableIndex", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyFrameValuesForTable_ReturnValue_PropertyAddress, GetKeyFrameValuesForTable_FunctionAddress, "ReturnValue");
		GetKeyFrameValuesForTable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyFrameValuesForTable_FunctionAddress, "ReturnValue");
		GetKeyFrameValuesForTable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyFrameValuesForTable_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetKeyFrameValuesForTable_IsValid = GetKeyFrameValuesForTable_FunctionAddress != IntPtr.Zero && GetKeyFrameValuesForTable_TableIndex_IsValid && GetKeyFrameValuesForTable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:GetKeyFrameValuesForTable", GetKeyFrameValuesForTable_IsValid);
		GetCurveTangent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurveTangent");
		GetCurveTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurveTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurveTangent_TableIndex_PropertyAddress, GetCurveTangent_FunctionAddress, "TableIndex");
		GetCurveTangent_TableIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveTangent_FunctionAddress, "TableIndex");
		GetCurveTangent_TableIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveTangent_FunctionAddress, "TableIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurveTangent_ReturnValue_PropertyAddress, GetCurveTangent_FunctionAddress, "ReturnValue");
		GetCurveTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurveTangent_FunctionAddress, "ReturnValue");
		GetCurveTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurveTangent_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurveTangent_IsValid = GetCurveTangent_FunctionAddress != IntPtr.Zero && GetCurveTangent_TableIndex_IsValid && GetCurveTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthComponentMonoWaveTable:GetCurveTangent", GetCurveTangent_IsValid);
	}
}
