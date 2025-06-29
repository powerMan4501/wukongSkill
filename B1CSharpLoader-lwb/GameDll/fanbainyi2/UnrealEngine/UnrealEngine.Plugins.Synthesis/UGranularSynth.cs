using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.GranularSynth", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UGranularSynth : USynthComponent
{
	private static bool SetSustainGain_IsValid;

	private static IntPtr SetSustainGain_FunctionAddress;

	private static int SetSustainGain_ParamsSize;

	private static bool SetSustainGain_SustainGain_IsValid;

	private static FFieldAddress SetSustainGain_SustainGain_PropertyAddress;

	private static int SetSustainGain_SustainGain_Offset;

	private static bool SetSoundWave_IsValid;

	private static IntPtr SetSoundWave_FunctionAddress;

	private static int SetSoundWave_ParamsSize;

	private static bool SetSoundWave_InSoundWave_IsValid;

	private static FFieldAddress SetSoundWave_InSoundWave_PropertyAddress;

	private static int SetSoundWave_InSoundWave_Offset;

	private static bool SetScrubMode_IsValid;

	private static IntPtr SetScrubMode_FunctionAddress;

	private static int SetScrubMode_ParamsSize;

	private static bool SetScrubMode_bScrubMode_IsValid;

	private static FFieldAddress SetScrubMode_bScrubMode_PropertyAddress;

	private static int SetScrubMode_bScrubMode_Offset;

	private static bool SetReleaseTimeMsec_IsValid;

	private static IntPtr SetReleaseTimeMsec_FunctionAddress;

	private static int SetReleaseTimeMsec_ParamsSize;

	private static bool SetReleaseTimeMsec_ReleaseTimeMsec_IsValid;

	private static FFieldAddress SetReleaseTimeMsec_ReleaseTimeMsec_PropertyAddress;

	private static int SetReleaseTimeMsec_ReleaseTimeMsec_Offset;

	private static bool SetPlayheadTime_IsValid;

	private static IntPtr SetPlayheadTime_FunctionAddress;

	private static int SetPlayheadTime_ParamsSize;

	private static bool SetPlayheadTime_InPositionSec_IsValid;

	private static FFieldAddress SetPlayheadTime_InPositionSec_PropertyAddress;

	private static int SetPlayheadTime_InPositionSec_Offset;

	private static bool SetPlayheadTime_LerpTimeSec_IsValid;

	private static FFieldAddress SetPlayheadTime_LerpTimeSec_PropertyAddress;

	private static int SetPlayheadTime_LerpTimeSec_Offset;

	private static bool SetPlayheadTime_SeekType_IsValid;

	private static FFieldAddress SetPlayheadTime_SeekType_PropertyAddress;

	private static int SetPlayheadTime_SeekType_Offset;

	private static bool SetPlaybackSpeed_IsValid;

	private static IntPtr SetPlaybackSpeed_FunctionAddress;

	private static int SetPlaybackSpeed_ParamsSize;

	private static bool SetPlaybackSpeed_InPlayheadRate_IsValid;

	private static FFieldAddress SetPlaybackSpeed_InPlayheadRate_PropertyAddress;

	private static int SetPlaybackSpeed_InPlayheadRate_Offset;

	private static bool SetGrainVolume_IsValid;

	private static IntPtr SetGrainVolume_FunctionAddress;

	private static int SetGrainVolume_ParamsSize;

	private static bool SetGrainVolume_BaseVolume_IsValid;

	private static FFieldAddress SetGrainVolume_BaseVolume_PropertyAddress;

	private static int SetGrainVolume_BaseVolume_Offset;

	private static bool SetGrainVolume_VolumeRange_IsValid;

	private static FFieldAddress SetGrainVolume_VolumeRange_PropertyAddress;

	private static int SetGrainVolume_VolumeRange_Offset;

	private static bool SetGrainsPerSecond_IsValid;

	private static IntPtr SetGrainsPerSecond_FunctionAddress;

	private static int SetGrainsPerSecond_ParamsSize;

	private static bool SetGrainsPerSecond_InGrainsPerSecond_IsValid;

	private static FFieldAddress SetGrainsPerSecond_InGrainsPerSecond_PropertyAddress;

	private static int SetGrainsPerSecond_InGrainsPerSecond_Offset;

	private static bool SetGrainProbability_IsValid;

	private static IntPtr SetGrainProbability_FunctionAddress;

	private static int SetGrainProbability_ParamsSize;

	private static bool SetGrainProbability_InGrainProbability_IsValid;

	private static FFieldAddress SetGrainProbability_InGrainProbability_PropertyAddress;

	private static int SetGrainProbability_InGrainProbability_Offset;

	private static bool SetGrainPitch_IsValid;

	private static IntPtr SetGrainPitch_FunctionAddress;

	private static int SetGrainPitch_ParamsSize;

	private static bool SetGrainPitch_BasePitch_IsValid;

	private static FFieldAddress SetGrainPitch_BasePitch_PropertyAddress;

	private static int SetGrainPitch_BasePitch_Offset;

	private static bool SetGrainPitch_PitchRange_IsValid;

	private static FFieldAddress SetGrainPitch_PitchRange_PropertyAddress;

	private static int SetGrainPitch_PitchRange_Offset;

	private static bool SetGrainPan_IsValid;

	private static IntPtr SetGrainPan_FunctionAddress;

	private static int SetGrainPan_ParamsSize;

	private static bool SetGrainPan_BasePan_IsValid;

	private static FFieldAddress SetGrainPan_BasePan_PropertyAddress;

	private static int SetGrainPan_BasePan_Offset;

	private static bool SetGrainPan_PanRange_IsValid;

	private static FFieldAddress SetGrainPan_PanRange_PropertyAddress;

	private static int SetGrainPan_PanRange_Offset;

	private static bool SetGrainEnvelopeType_IsValid;

	private static IntPtr SetGrainEnvelopeType_FunctionAddress;

	private static int SetGrainEnvelopeType_ParamsSize;

	private static bool SetGrainEnvelopeType_EnvelopeType_IsValid;

	private static FFieldAddress SetGrainEnvelopeType_EnvelopeType_PropertyAddress;

	private static int SetGrainEnvelopeType_EnvelopeType_Offset;

	private static bool SetGrainDuration_IsValid;

	private static IntPtr SetGrainDuration_FunctionAddress;

	private static int SetGrainDuration_ParamsSize;

	private static bool SetGrainDuration_BaseDurationMsec_IsValid;

	private static FFieldAddress SetGrainDuration_BaseDurationMsec_PropertyAddress;

	private static int SetGrainDuration_BaseDurationMsec_Offset;

	private static bool SetGrainDuration_DurationRange_IsValid;

	private static FFieldAddress SetGrainDuration_DurationRange_PropertyAddress;

	private static int SetGrainDuration_DurationRange_Offset;

	private static bool SetDecayTime_IsValid;

	private static IntPtr SetDecayTime_FunctionAddress;

	private static int SetDecayTime_ParamsSize;

	private static bool SetDecayTime_DecayTimeMsec_IsValid;

	private static FFieldAddress SetDecayTime_DecayTimeMsec_PropertyAddress;

	private static int SetDecayTime_DecayTimeMsec_Offset;

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

	private static bool NoteOff_bKill_IsValid;

	private static FFieldAddress NoteOff_bKill_PropertyAddress;

	private static int NoteOff_bKill_Offset;

	private static bool IsLoaded_IsValid;

	private static IntPtr IsLoaded_FunctionAddress;

	private static int IsLoaded_ParamsSize;

	private static bool IsLoaded_ReturnValue_IsValid;

	private static FFieldAddress IsLoaded_ReturnValue_PropertyAddress;

	private static int IsLoaded_ReturnValue_Offset;

	private static bool GetSampleDuration_IsValid;

	private static IntPtr GetSampleDuration_FunctionAddress;

	private static int GetSampleDuration_ParamsSize;

	private static bool GetSampleDuration_ReturnValue_IsValid;

	private static FFieldAddress GetSampleDuration_ReturnValue_PropertyAddress;

	private static int GetSampleDuration_ReturnValue_Offset;

	private static bool GetCurrentPlayheadTime_IsValid;

	private static IntPtr GetCurrentPlayheadTime_FunctionAddress;

	private static int GetCurrentPlayheadTime_ParamsSize;

	private static bool GetCurrentPlayheadTime_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPlayheadTime_ReturnValue_PropertyAddress;

	private static int GetCurrentPlayheadTime_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetSustainGain")]
	public unsafe void SetSustainGain(float SustainGain)
	{
		CheckDestroyed();
		if (!SetSustainGain_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetSustainGain");
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
	[UMetaPath("/Script/Synthesis.GranularSynth:SetSoundWave")]
	public unsafe void SetSoundWave(USoundWave InSoundWave)
	{
		CheckDestroyed();
		if (!SetSoundWave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetSoundWave");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSoundWave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSoundWave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, SetSoundWave_InSoundWave_Offset), 0, SetSoundWave_InSoundWave_PropertyAddress.Address, InSoundWave);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSoundWave_FunctionAddress, intPtr, SetSoundWave_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetScrubMode")]
	public unsafe void SetScrubMode(bool bScrubMode)
	{
		CheckDestroyed();
		if (!SetScrubMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetScrubMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrubMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrubMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetScrubMode_bScrubMode_Offset), 0, SetScrubMode_bScrubMode_PropertyAddress.Address, bScrubMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrubMode_FunctionAddress, intPtr, SetScrubMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetReleaseTimeMsec")]
	public unsafe void SetReleaseTimeMsec(float ReleaseTimeMsec)
	{
		CheckDestroyed();
		if (!SetReleaseTimeMsec_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetReleaseTimeMsec");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetReleaseTimeMsec_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetReleaseTimeMsec_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetReleaseTimeMsec_ReleaseTimeMsec_Offset), 0, SetReleaseTimeMsec_ReleaseTimeMsec_PropertyAddress.Address, ReleaseTimeMsec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetReleaseTimeMsec_FunctionAddress, intPtr, SetReleaseTimeMsec_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetPlayheadTime")]
	public unsafe void SetPlayheadTime(float InPositionSec, float LerpTimeSec = 0f, EGranularSynthSeekType SeekType = EGranularSynthSeekType.FromBeginning)
	{
		CheckDestroyed();
		if (!SetPlayheadTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetPlayheadTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayheadTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayheadTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayheadTime_InPositionSec_Offset), 0, SetPlayheadTime_InPositionSec_PropertyAddress.Address, InPositionSec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayheadTime_LerpTimeSec_Offset), 0, SetPlayheadTime_LerpTimeSec_PropertyAddress.Address, LerpTimeSec);
		EnumMarshaler<EGranularSynthSeekType>.ToNative(IntPtr.Add(intPtr, SetPlayheadTime_SeekType_Offset), 0, SetPlayheadTime_SeekType_PropertyAddress.Address, SeekType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayheadTime_FunctionAddress, intPtr, SetPlayheadTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetPlaybackSpeed")]
	public unsafe void SetPlaybackSpeed(float InPlayheadRate)
	{
		CheckDestroyed();
		if (!SetPlaybackSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetPlaybackSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlaybackSpeed_InPlayheadRate_Offset), 0, SetPlaybackSpeed_InPlayheadRate_PropertyAddress.Address, InPlayheadRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackSpeed_FunctionAddress, intPtr, SetPlaybackSpeed_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainVolume")]
	public unsafe void SetGrainVolume(float BaseVolume, FVector2D VolumeRange)
	{
		CheckDestroyed();
		if (!SetGrainVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainVolume_BaseVolume_Offset), 0, SetGrainVolume_BaseVolume_PropertyAddress.Address, BaseVolume);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetGrainVolume_VolumeRange_Offset), 0, SetGrainVolume_VolumeRange_PropertyAddress.Address, VolumeRange);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainVolume_FunctionAddress, intPtr, SetGrainVolume_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainsPerSecond")]
	public unsafe void SetGrainsPerSecond(float InGrainsPerSecond)
	{
		CheckDestroyed();
		if (!SetGrainsPerSecond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainsPerSecond");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainsPerSecond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainsPerSecond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainsPerSecond_InGrainsPerSecond_Offset), 0, SetGrainsPerSecond_InGrainsPerSecond_PropertyAddress.Address, InGrainsPerSecond);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainsPerSecond_FunctionAddress, intPtr, SetGrainsPerSecond_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainProbability")]
	public unsafe void SetGrainProbability(float InGrainProbability)
	{
		CheckDestroyed();
		if (!SetGrainProbability_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainProbability");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainProbability_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainProbability_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainProbability_InGrainProbability_Offset), 0, SetGrainProbability_InGrainProbability_PropertyAddress.Address, InGrainProbability);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainProbability_FunctionAddress, intPtr, SetGrainProbability_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainPitch")]
	public unsafe void SetGrainPitch(float BasePitch, FVector2D PitchRange)
	{
		CheckDestroyed();
		if (!SetGrainPitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainPitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainPitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainPitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainPitch_BasePitch_Offset), 0, SetGrainPitch_BasePitch_PropertyAddress.Address, BasePitch);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetGrainPitch_PitchRange_Offset), 0, SetGrainPitch_PitchRange_PropertyAddress.Address, PitchRange);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainPitch_FunctionAddress, intPtr, SetGrainPitch_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainPan")]
	public unsafe void SetGrainPan(float BasePan, FVector2D PanRange)
	{
		CheckDestroyed();
		if (!SetGrainPan_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainPan");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainPan_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainPan_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainPan_BasePan_Offset), 0, SetGrainPan_BasePan_PropertyAddress.Address, BasePan);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetGrainPan_PanRange_Offset), 0, SetGrainPan_PanRange_PropertyAddress.Address, PanRange);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainPan_FunctionAddress, intPtr, SetGrainPan_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainEnvelopeType")]
	public unsafe void SetGrainEnvelopeType(EGranularSynthEnvelopeType EnvelopeType)
	{
		CheckDestroyed();
		if (!SetGrainEnvelopeType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainEnvelopeType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainEnvelopeType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainEnvelopeType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EGranularSynthEnvelopeType>.ToNative(IntPtr.Add(intPtr, SetGrainEnvelopeType_EnvelopeType_Offset), 0, SetGrainEnvelopeType_EnvelopeType_PropertyAddress.Address, EnvelopeType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainEnvelopeType_FunctionAddress, intPtr, SetGrainEnvelopeType_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetGrainDuration")]
	public unsafe void SetGrainDuration(float BaseDurationMsec, FVector2D DurationRange)
	{
		CheckDestroyed();
		if (!SetGrainDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetGrainDuration");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGrainDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGrainDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGrainDuration_BaseDurationMsec_Offset), 0, SetGrainDuration_BaseDurationMsec_PropertyAddress.Address, BaseDurationMsec);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetGrainDuration_DurationRange_Offset), 0, SetGrainDuration_DurationRange_PropertyAddress.Address, DurationRange);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGrainDuration_FunctionAddress, intPtr, SetGrainDuration_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:SetDecayTime")]
	public unsafe void SetDecayTime(float DecayTimeMsec)
	{
		CheckDestroyed();
		if (!SetDecayTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetDecayTime");
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
	[UMetaPath("/Script/Synthesis.GranularSynth:SetAttackTime")]
	public unsafe void SetAttackTime(float AttackTimeMsec)
	{
		CheckDestroyed();
		if (!SetAttackTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:SetAttackTime");
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
	[UMetaPath("/Script/Synthesis.GranularSynth:NoteOn")]
	public unsafe void NoteOn(float Note, int Velocity, float Duration = -1f)
	{
		CheckDestroyed();
		if (!NoteOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:NoteOn");
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
	[UMetaPath("/Script/Synthesis.GranularSynth:NoteOff")]
	public unsafe void NoteOff(float Note, bool bKill = false)
	{
		CheckDestroyed();
		if (!NoteOff_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:NoteOff");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NoteOff_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NoteOff_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, NoteOff_Note_Offset), 0, NoteOff_Note_PropertyAddress.Address, Note);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, NoteOff_bKill_Offset), 0, NoteOff_bKill_PropertyAddress.Address, bKill);
		NativeReflection.InvokeFunctionOptimized(base.Address, NoteOff_FunctionAddress, intPtr, NoteOff_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:IsLoaded")]
	public unsafe bool IsLoaded()
	{
		CheckDestroyed();
		if (!IsLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:IsLoaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLoaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLoaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLoaded_FunctionAddress, intPtr, IsLoaded_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLoaded_ReturnValue_Offset), 0, IsLoaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:GetSampleDuration")]
	public unsafe float GetSampleDuration()
	{
		CheckDestroyed();
		if (!GetSampleDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:GetSampleDuration");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSampleDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSampleDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSampleDuration_FunctionAddress, intPtr, GetSampleDuration_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetSampleDuration_ReturnValue_Offset), 0, GetSampleDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.GranularSynth:GetCurrentPlayheadTime")]
	public unsafe float GetCurrentPlayheadTime()
	{
		CheckDestroyed();
		if (!GetCurrentPlayheadTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.GranularSynth:GetCurrentPlayheadTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPlayheadTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPlayheadTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentPlayheadTime_FunctionAddress, intPtr, GetCurrentPlayheadTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentPlayheadTime_ReturnValue_Offset), 0, GetCurrentPlayheadTime_ReturnValue_PropertyAddress.Address);
	}

	static UGranularSynth()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGranularSynth)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGranularSynth));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Synthesis.GranularSynth");
		SetSustainGain_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSustainGain");
		SetSustainGain_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSustainGain_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSustainGain_SustainGain_PropertyAddress, SetSustainGain_FunctionAddress, "SustainGain");
		SetSustainGain_SustainGain_Offset = NativeReflectionCached.GetPropertyOffset(SetSustainGain_FunctionAddress, "SustainGain");
		SetSustainGain_SustainGain_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSustainGain_FunctionAddress, "SustainGain", Classes.FFloatProperty);
		SetSustainGain_IsValid = SetSustainGain_FunctionAddress != IntPtr.Zero && SetSustainGain_SustainGain_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetSustainGain", SetSustainGain_IsValid);
		SetSoundWave_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSoundWave");
		SetSoundWave_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoundWave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoundWave_InSoundWave_PropertyAddress, SetSoundWave_FunctionAddress, "InSoundWave");
		SetSoundWave_InSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundWave_FunctionAddress, "InSoundWave");
		SetSoundWave_InSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundWave_FunctionAddress, "InSoundWave", Classes.FObjectProperty);
		SetSoundWave_IsValid = SetSoundWave_FunctionAddress != IntPtr.Zero && SetSoundWave_InSoundWave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetSoundWave", SetSoundWave_IsValid);
		SetScrubMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetScrubMode");
		SetScrubMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrubMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrubMode_bScrubMode_PropertyAddress, SetScrubMode_FunctionAddress, "bScrubMode");
		SetScrubMode_bScrubMode_Offset = NativeReflectionCached.GetPropertyOffset(SetScrubMode_FunctionAddress, "bScrubMode");
		SetScrubMode_bScrubMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrubMode_FunctionAddress, "bScrubMode", Classes.FBoolProperty);
		SetScrubMode_IsValid = SetScrubMode_FunctionAddress != IntPtr.Zero && SetScrubMode_bScrubMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetScrubMode", SetScrubMode_IsValid);
		SetReleaseTimeMsec_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetReleaseTimeMsec");
		SetReleaseTimeMsec_ParamsSize = NativeReflection.GetFunctionParamsSize(SetReleaseTimeMsec_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetReleaseTimeMsec_ReleaseTimeMsec_PropertyAddress, SetReleaseTimeMsec_FunctionAddress, "ReleaseTimeMsec");
		SetReleaseTimeMsec_ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetReleaseTimeMsec_FunctionAddress, "ReleaseTimeMsec");
		SetReleaseTimeMsec_ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetReleaseTimeMsec_FunctionAddress, "ReleaseTimeMsec", Classes.FFloatProperty);
		SetReleaseTimeMsec_IsValid = SetReleaseTimeMsec_FunctionAddress != IntPtr.Zero && SetReleaseTimeMsec_ReleaseTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetReleaseTimeMsec", SetReleaseTimeMsec_IsValid);
		SetPlayheadTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlayheadTime");
		SetPlayheadTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayheadTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayheadTime_InPositionSec_PropertyAddress, SetPlayheadTime_FunctionAddress, "InPositionSec");
		SetPlayheadTime_InPositionSec_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayheadTime_FunctionAddress, "InPositionSec");
		SetPlayheadTime_InPositionSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayheadTime_FunctionAddress, "InPositionSec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayheadTime_LerpTimeSec_PropertyAddress, SetPlayheadTime_FunctionAddress, "LerpTimeSec");
		SetPlayheadTime_LerpTimeSec_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayheadTime_FunctionAddress, "LerpTimeSec");
		SetPlayheadTime_LerpTimeSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayheadTime_FunctionAddress, "LerpTimeSec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlayheadTime_SeekType_PropertyAddress, SetPlayheadTime_FunctionAddress, "SeekType");
		SetPlayheadTime_SeekType_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayheadTime_FunctionAddress, "SeekType");
		SetPlayheadTime_SeekType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayheadTime_FunctionAddress, "SeekType", Classes.FEnumProperty);
		SetPlayheadTime_IsValid = SetPlayheadTime_FunctionAddress != IntPtr.Zero && SetPlayheadTime_InPositionSec_IsValid && SetPlayheadTime_LerpTimeSec_IsValid && SetPlayheadTime_SeekType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetPlayheadTime", SetPlayheadTime_IsValid);
		SetPlaybackSpeed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPlaybackSpeed");
		SetPlaybackSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackSpeed_InPlayheadRate_PropertyAddress, SetPlaybackSpeed_FunctionAddress, "InPlayheadRate");
		SetPlaybackSpeed_InPlayheadRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackSpeed_FunctionAddress, "InPlayheadRate");
		SetPlaybackSpeed_InPlayheadRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackSpeed_FunctionAddress, "InPlayheadRate", Classes.FFloatProperty);
		SetPlaybackSpeed_IsValid = SetPlaybackSpeed_FunctionAddress != IntPtr.Zero && SetPlaybackSpeed_InPlayheadRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetPlaybackSpeed", SetPlaybackSpeed_IsValid);
		SetGrainVolume_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainVolume");
		SetGrainVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainVolume_BaseVolume_PropertyAddress, SetGrainVolume_FunctionAddress, "BaseVolume");
		SetGrainVolume_BaseVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainVolume_FunctionAddress, "BaseVolume");
		SetGrainVolume_BaseVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainVolume_FunctionAddress, "BaseVolume", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGrainVolume_VolumeRange_PropertyAddress, SetGrainVolume_FunctionAddress, "VolumeRange");
		SetGrainVolume_VolumeRange_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainVolume_FunctionAddress, "VolumeRange");
		SetGrainVolume_VolumeRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainVolume_FunctionAddress, "VolumeRange", Classes.FStructProperty);
		SetGrainVolume_IsValid = SetGrainVolume_FunctionAddress != IntPtr.Zero && SetGrainVolume_BaseVolume_IsValid && SetGrainVolume_VolumeRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainVolume", SetGrainVolume_IsValid);
		SetGrainsPerSecond_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainsPerSecond");
		SetGrainsPerSecond_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainsPerSecond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainsPerSecond_InGrainsPerSecond_PropertyAddress, SetGrainsPerSecond_FunctionAddress, "InGrainsPerSecond");
		SetGrainsPerSecond_InGrainsPerSecond_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainsPerSecond_FunctionAddress, "InGrainsPerSecond");
		SetGrainsPerSecond_InGrainsPerSecond_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainsPerSecond_FunctionAddress, "InGrainsPerSecond", Classes.FFloatProperty);
		SetGrainsPerSecond_IsValid = SetGrainsPerSecond_FunctionAddress != IntPtr.Zero && SetGrainsPerSecond_InGrainsPerSecond_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainsPerSecond", SetGrainsPerSecond_IsValid);
		SetGrainProbability_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainProbability");
		SetGrainProbability_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainProbability_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainProbability_InGrainProbability_PropertyAddress, SetGrainProbability_FunctionAddress, "InGrainProbability");
		SetGrainProbability_InGrainProbability_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainProbability_FunctionAddress, "InGrainProbability");
		SetGrainProbability_InGrainProbability_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainProbability_FunctionAddress, "InGrainProbability", Classes.FFloatProperty);
		SetGrainProbability_IsValid = SetGrainProbability_FunctionAddress != IntPtr.Zero && SetGrainProbability_InGrainProbability_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainProbability", SetGrainProbability_IsValid);
		SetGrainPitch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainPitch");
		SetGrainPitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainPitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainPitch_BasePitch_PropertyAddress, SetGrainPitch_FunctionAddress, "BasePitch");
		SetGrainPitch_BasePitch_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainPitch_FunctionAddress, "BasePitch");
		SetGrainPitch_BasePitch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainPitch_FunctionAddress, "BasePitch", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGrainPitch_PitchRange_PropertyAddress, SetGrainPitch_FunctionAddress, "PitchRange");
		SetGrainPitch_PitchRange_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainPitch_FunctionAddress, "PitchRange");
		SetGrainPitch_PitchRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainPitch_FunctionAddress, "PitchRange", Classes.FStructProperty);
		SetGrainPitch_IsValid = SetGrainPitch_FunctionAddress != IntPtr.Zero && SetGrainPitch_BasePitch_IsValid && SetGrainPitch_PitchRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainPitch", SetGrainPitch_IsValid);
		SetGrainPan_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainPan");
		SetGrainPan_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainPan_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainPan_BasePan_PropertyAddress, SetGrainPan_FunctionAddress, "BasePan");
		SetGrainPan_BasePan_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainPan_FunctionAddress, "BasePan");
		SetGrainPan_BasePan_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainPan_FunctionAddress, "BasePan", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGrainPan_PanRange_PropertyAddress, SetGrainPan_FunctionAddress, "PanRange");
		SetGrainPan_PanRange_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainPan_FunctionAddress, "PanRange");
		SetGrainPan_PanRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainPan_FunctionAddress, "PanRange", Classes.FStructProperty);
		SetGrainPan_IsValid = SetGrainPan_FunctionAddress != IntPtr.Zero && SetGrainPan_BasePan_IsValid && SetGrainPan_PanRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainPan", SetGrainPan_IsValid);
		SetGrainEnvelopeType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainEnvelopeType");
		SetGrainEnvelopeType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainEnvelopeType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainEnvelopeType_EnvelopeType_PropertyAddress, SetGrainEnvelopeType_FunctionAddress, "EnvelopeType");
		SetGrainEnvelopeType_EnvelopeType_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainEnvelopeType_FunctionAddress, "EnvelopeType");
		SetGrainEnvelopeType_EnvelopeType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainEnvelopeType_FunctionAddress, "EnvelopeType", Classes.FEnumProperty);
		SetGrainEnvelopeType_IsValid = SetGrainEnvelopeType_FunctionAddress != IntPtr.Zero && SetGrainEnvelopeType_EnvelopeType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainEnvelopeType", SetGrainEnvelopeType_IsValid);
		SetGrainDuration_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGrainDuration");
		SetGrainDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGrainDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGrainDuration_BaseDurationMsec_PropertyAddress, SetGrainDuration_FunctionAddress, "BaseDurationMsec");
		SetGrainDuration_BaseDurationMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainDuration_FunctionAddress, "BaseDurationMsec");
		SetGrainDuration_BaseDurationMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainDuration_FunctionAddress, "BaseDurationMsec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetGrainDuration_DurationRange_PropertyAddress, SetGrainDuration_FunctionAddress, "DurationRange");
		SetGrainDuration_DurationRange_Offset = NativeReflectionCached.GetPropertyOffset(SetGrainDuration_FunctionAddress, "DurationRange");
		SetGrainDuration_DurationRange_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGrainDuration_FunctionAddress, "DurationRange", Classes.FStructProperty);
		SetGrainDuration_IsValid = SetGrainDuration_FunctionAddress != IntPtr.Zero && SetGrainDuration_BaseDurationMsec_IsValid && SetGrainDuration_DurationRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetGrainDuration", SetGrainDuration_IsValid);
		SetDecayTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDecayTime");
		SetDecayTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDecayTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDecayTime_DecayTimeMsec_PropertyAddress, SetDecayTime_FunctionAddress, "DecayTimeMsec");
		SetDecayTime_DecayTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetDecayTime_FunctionAddress, "DecayTimeMsec");
		SetDecayTime_DecayTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDecayTime_FunctionAddress, "DecayTimeMsec", Classes.FFloatProperty);
		SetDecayTime_IsValid = SetDecayTime_FunctionAddress != IntPtr.Zero && SetDecayTime_DecayTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetDecayTime", SetDecayTime_IsValid);
		SetAttackTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAttackTime");
		SetAttackTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAttackTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAttackTime_AttackTimeMsec_PropertyAddress, SetAttackTime_FunctionAddress, "AttackTimeMsec");
		SetAttackTime_AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(SetAttackTime_FunctionAddress, "AttackTimeMsec");
		SetAttackTime_AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAttackTime_FunctionAddress, "AttackTimeMsec", Classes.FFloatProperty);
		SetAttackTime_IsValid = SetAttackTime_FunctionAddress != IntPtr.Zero && SetAttackTime_AttackTimeMsec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:SetAttackTime", SetAttackTime_IsValid);
		NoteOn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NoteOn");
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
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:NoteOn", NoteOn_IsValid);
		NoteOff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "NoteOff");
		NoteOff_ParamsSize = NativeReflection.GetFunctionParamsSize(NoteOff_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_Note_PropertyAddress, NoteOff_FunctionAddress, "Note");
		NoteOff_Note_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "Note");
		NoteOff_Note_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "Note", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NoteOff_bKill_PropertyAddress, NoteOff_FunctionAddress, "bKill");
		NoteOff_bKill_Offset = NativeReflectionCached.GetPropertyOffset(NoteOff_FunctionAddress, "bKill");
		NoteOff_bKill_IsValid = NativeReflectionCached.ValidatePropertyClass(NoteOff_FunctionAddress, "bKill", Classes.FBoolProperty);
		NoteOff_IsValid = NoteOff_FunctionAddress != IntPtr.Zero && NoteOff_Note_IsValid && NoteOff_bKill_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:NoteOff", NoteOff_IsValid);
		IsLoaded_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLoaded");
		IsLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoaded_ReturnValue_PropertyAddress, IsLoaded_FunctionAddress, "ReturnValue");
		IsLoaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoaded_FunctionAddress, "ReturnValue");
		IsLoaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoaded_IsValid = IsLoaded_FunctionAddress != IntPtr.Zero && IsLoaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:IsLoaded", IsLoaded_IsValid);
		GetSampleDuration_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSampleDuration");
		GetSampleDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSampleDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSampleDuration_ReturnValue_PropertyAddress, GetSampleDuration_FunctionAddress, "ReturnValue");
		GetSampleDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSampleDuration_FunctionAddress, "ReturnValue");
		GetSampleDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSampleDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSampleDuration_IsValid = GetSampleDuration_FunctionAddress != IntPtr.Zero && GetSampleDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:GetSampleDuration", GetSampleDuration_IsValid);
		GetCurrentPlayheadTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurrentPlayheadTime");
		GetCurrentPlayheadTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPlayheadTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPlayheadTime_ReturnValue_PropertyAddress, GetCurrentPlayheadTime_FunctionAddress, "ReturnValue");
		GetCurrentPlayheadTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPlayheadTime_FunctionAddress, "ReturnValue");
		GetCurrentPlayheadTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPlayheadTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentPlayheadTime_IsValid = GetCurrentPlayheadTime_FunctionAddress != IntPtr.Zero && GetCurrentPlayheadTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.GranularSynth:GetCurrentPlayheadTime", GetCurrentPlayheadTime_IsValid);
	}
}
