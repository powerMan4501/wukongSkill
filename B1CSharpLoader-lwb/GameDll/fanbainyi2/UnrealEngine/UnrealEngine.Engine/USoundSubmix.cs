using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioExtensions;
using UnrealEngine.AudioLinkCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundSubmix", "Engine", UnrealModuleType.Engine)]
public class USoundSubmix : USoundSubmixWithParentBase
{
	private static bool MuteWhenBackgrounded_IsValid;

	private static FFieldAddress MuteWhenBackgrounded_PropertyAddress;

	private static int MuteWhenBackgrounded_Offset;

	private static bool SubmixEffectChain_IsValid;

	private static FFieldAddress SubmixEffectChain_PropertyAddress;

	private static int SubmixEffectChain_Offset;

	private TArrayReadOnlyMarshaler<USoundEffectSubmixPreset> SubmixEffectChain_MarshalerCached;

	private static bool AmbisonicsPluginSettings_IsValid;

	private static int AmbisonicsPluginSettings_Offset;

	private static bool EnvelopeFollowerAttackTime_IsValid;

	private static int EnvelopeFollowerAttackTime_Offset;

	private static bool EnvelopeFollowerReleaseTime_IsValid;

	private static int EnvelopeFollowerReleaseTime_Offset;

	private static bool OutputVolumeModulation_IsValid;

	private static int OutputVolumeModulation_Offset;

	private static bool WetLevelModulation_IsValid;

	private static int WetLevelModulation_Offset;

	private static bool DryLevelModulation_IsValid;

	private static int DryLevelModulation_Offset;

	private static bool AudioLinkSettings_IsValid;

	private static int AudioLinkSettings_Offset;

	private static bool OnSubmixRecordedFileDone_IsValid;

	private static int OnSubmixRecordedFileDone_Offset;

	private FOnSubmixRecordedFileDone OnSubmixRecordedFileDone_DelegateCached;

	private static bool StopSpectralAnalysis_IsValid;

	private static IntPtr StopSpectralAnalysis_FunctionAddress;

	private static int StopSpectralAnalysis_ParamsSize;

	private static bool StopSpectralAnalysis_WorldContextObject_IsValid;

	private static FFieldAddress StopSpectralAnalysis_WorldContextObject_PropertyAddress;

	private static int StopSpectralAnalysis_WorldContextObject_Offset;

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

	private static bool StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid;

	private static FFieldAddress StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress;

	private static int StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset;

	private static bool StopEnvelopeFollowing_IsValid;

	private static IntPtr StopEnvelopeFollowing_FunctionAddress;

	private static int StopEnvelopeFollowing_ParamsSize;

	private static bool StopEnvelopeFollowing_WorldContextObject_IsValid;

	private static FFieldAddress StopEnvelopeFollowing_WorldContextObject_PropertyAddress;

	private static int StopEnvelopeFollowing_WorldContextObject_Offset;

	private static bool StartSpectralAnalysis_IsValid;

	private static IntPtr StartSpectralAnalysis_FunctionAddress;

	private static int StartSpectralAnalysis_ParamsSize;

	private static bool StartSpectralAnalysis_WorldContextObject_IsValid;

	private static FFieldAddress StartSpectralAnalysis_WorldContextObject_PropertyAddress;

	private static int StartSpectralAnalysis_WorldContextObject_Offset;

	private static bool StartSpectralAnalysis_FFTSize_IsValid;

	private static FFieldAddress StartSpectralAnalysis_FFTSize_PropertyAddress;

	private static int StartSpectralAnalysis_FFTSize_Offset;

	private static bool StartSpectralAnalysis_InterpolationMethod_IsValid;

	private static FFieldAddress StartSpectralAnalysis_InterpolationMethod_PropertyAddress;

	private static int StartSpectralAnalysis_InterpolationMethod_Offset;

	private static bool StartSpectralAnalysis_WindowType_IsValid;

	private static FFieldAddress StartSpectralAnalysis_WindowType_PropertyAddress;

	private static int StartSpectralAnalysis_WindowType_Offset;

	private static bool StartSpectralAnalysis_HopSize_IsValid;

	private static FFieldAddress StartSpectralAnalysis_HopSize_PropertyAddress;

	private static int StartSpectralAnalysis_HopSize_Offset;

	private static bool StartSpectralAnalysis_SpectrumType_IsValid;

	private static FFieldAddress StartSpectralAnalysis_SpectrumType_PropertyAddress;

	private static int StartSpectralAnalysis_SpectrumType_Offset;

	private static bool StartRecordingOutput_IsValid;

	private static IntPtr StartRecordingOutput_FunctionAddress;

	private static int StartRecordingOutput_ParamsSize;

	private static bool StartRecordingOutput_WorldContextObject_IsValid;

	private static FFieldAddress StartRecordingOutput_WorldContextObject_PropertyAddress;

	private static int StartRecordingOutput_WorldContextObject_Offset;

	private static bool StartRecordingOutput_ExpectedDuration_IsValid;

	private static FFieldAddress StartRecordingOutput_ExpectedDuration_PropertyAddress;

	private static int StartRecordingOutput_ExpectedDuration_Offset;

	private static bool StartEnvelopeFollowing_IsValid;

	private static IntPtr StartEnvelopeFollowing_FunctionAddress;

	private static int StartEnvelopeFollowing_ParamsSize;

	private static bool StartEnvelopeFollowing_WorldContextObject_IsValid;

	private static FFieldAddress StartEnvelopeFollowing_WorldContextObject_PropertyAddress;

	private static int StartEnvelopeFollowing_WorldContextObject_Offset;

	private static bool SetSubmixWetLevel_IsValid;

	private static IntPtr SetSubmixWetLevel_FunctionAddress;

	private static int SetSubmixWetLevel_ParamsSize;

	private static bool SetSubmixWetLevel_WorldContextObject_IsValid;

	private static FFieldAddress SetSubmixWetLevel_WorldContextObject_PropertyAddress;

	private static int SetSubmixWetLevel_WorldContextObject_Offset;

	private static bool SetSubmixWetLevel_InWetLevel_IsValid;

	private static FFieldAddress SetSubmixWetLevel_InWetLevel_PropertyAddress;

	private static int SetSubmixWetLevel_InWetLevel_Offset;

	private static bool SetSubmixOutputVolume_IsValid;

	private static IntPtr SetSubmixOutputVolume_FunctionAddress;

	private static int SetSubmixOutputVolume_ParamsSize;

	private static bool SetSubmixOutputVolume_WorldContextObject_IsValid;

	private static FFieldAddress SetSubmixOutputVolume_WorldContextObject_PropertyAddress;

	private static int SetSubmixOutputVolume_WorldContextObject_Offset;

	private static bool SetSubmixOutputVolume_InOutputVolume_IsValid;

	private static FFieldAddress SetSubmixOutputVolume_InOutputVolume_PropertyAddress;

	private static int SetSubmixOutputVolume_InOutputVolume_Offset;

	private static bool SetSubmixDryLevel_IsValid;

	private static IntPtr SetSubmixDryLevel_FunctionAddress;

	private static int SetSubmixDryLevel_ParamsSize;

	private static bool SetSubmixDryLevel_WorldContextObject_IsValid;

	private static FFieldAddress SetSubmixDryLevel_WorldContextObject_PropertyAddress;

	private static int SetSubmixDryLevel_WorldContextObject_Offset;

	private static bool SetSubmixDryLevel_InDryLevel_IsValid;

	private static FFieldAddress SetSubmixDryLevel_InDryLevel_PropertyAddress;

	private static int SetSubmixDryLevel_InDryLevel_Offset;

	private static bool RemoveSpectralAnalysisDelegate_IsValid;

	private static IntPtr RemoveSpectralAnalysisDelegate_FunctionAddress;

	private static int RemoveSpectralAnalysisDelegate_ParamsSize;

	private static bool RemoveSpectralAnalysisDelegate_WorldContextObject_IsValid;

	private static FFieldAddress RemoveSpectralAnalysisDelegate_WorldContextObject_PropertyAddress;

	private static int RemoveSpectralAnalysisDelegate_WorldContextObject_Offset;

	private static bool RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid;

	private static FFieldAddress RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress;

	private static int RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset;

	private static bool AddSpectralAnalysisDelegate_IsValid;

	private static IntPtr AddSpectralAnalysisDelegate_FunctionAddress;

	private static int AddSpectralAnalysisDelegate_ParamsSize;

	private static bool AddSpectralAnalysisDelegate_WorldContextObject_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_WorldContextObject_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_WorldContextObject_Offset;

	private static bool AddSpectralAnalysisDelegate_InBandSettings_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_InBandSettings_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_InBandSettings_Offset;

	private static bool AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset;

	private static bool AddSpectralAnalysisDelegate_UpdateRate_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_UpdateRate_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_UpdateRate_Offset;

	private static bool AddSpectralAnalysisDelegate_DecibelNoiseFloor_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_DecibelNoiseFloor_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_DecibelNoiseFloor_Offset;

	private static bool AddSpectralAnalysisDelegate_bDoNormalize_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_bDoNormalize_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_bDoNormalize_Offset;

	private static bool AddSpectralAnalysisDelegate_bDoAutoRange_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_bDoAutoRange_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_bDoAutoRange_Offset;

	private static bool AddSpectralAnalysisDelegate_AutoRangeAttackTime_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_AutoRangeAttackTime_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_AutoRangeAttackTime_Offset;

	private static bool AddSpectralAnalysisDelegate_AutoRangeReleaseTime_IsValid;

	private static FFieldAddress AddSpectralAnalysisDelegate_AutoRangeReleaseTime_PropertyAddress;

	private static int AddSpectralAnalysisDelegate_AutoRangeReleaseTime_Offset;

	private static bool AddEnvelopeFollowerDelegate_IsValid;

	private static IntPtr AddEnvelopeFollowerDelegate_FunctionAddress;

	private static int AddEnvelopeFollowerDelegate_ParamsSize;

	private static bool AddEnvelopeFollowerDelegate_WorldContextObject_IsValid;

	private static FFieldAddress AddEnvelopeFollowerDelegate_WorldContextObject_PropertyAddress;

	private static int AddEnvelopeFollowerDelegate_WorldContextObject_Offset;

	private static bool AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_IsValid;

	private static FFieldAddress AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_PropertyAddress;

	private static int AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:bMuteWhenBackgrounded")]
	public bool MuteWhenBackgrounded
	{
		get
		{
			CheckDestroyed();
			if (!MuteWhenBackgrounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:bMuteWhenBackgrounded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MuteWhenBackgrounded_Offset), 0, MuteWhenBackgrounded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MuteWhenBackgrounded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:bMuteWhenBackgrounded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MuteWhenBackgrounded_Offset), 0, MuteWhenBackgrounded_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213653uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:SubmixEffectChain")]
	public TArrayReadOnly<USoundEffectSubmixPreset> SubmixEffectChain
	{
		get
		{
			CheckDestroyed();
			if (!SubmixEffectChain_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:SubmixEffectChain");
				return null;
			}
			if (SubmixEffectChain_MarshalerCached == null)
			{
				SubmixEffectChain_MarshalerCached = new TArrayReadOnlyMarshaler<USoundEffectSubmixPreset>(1, SubmixEffectChain_PropertyAddress, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.FromNative, CachedMarshalingDelegates<USoundEffectSubmixPreset, UObjectMarshaler<USoundEffectSubmixPreset>>.ToNative);
			}
			return SubmixEffectChain_MarshalerCached.FromNative(IntPtr.Add(base.Address, SubmixEffectChain_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:AmbisonicsPluginSettings")]
	public USoundfieldEncodingSettingsBase AmbisonicsPluginSettings
	{
		get
		{
			CheckDestroyed();
			if (!AmbisonicsPluginSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:AmbisonicsPluginSettings");
				return null;
			}
			return UObjectMarshaler<USoundfieldEncodingSettingsBase>.FromNative(IntPtr.Add(base.Address, AmbisonicsPluginSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AmbisonicsPluginSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:AmbisonicsPluginSettings");
			}
			else
			{
				UObjectMarshaler<USoundfieldEncodingSettingsBase>.ToNative(IntPtr.Add(base.Address, AmbisonicsPluginSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:EnvelopeFollowerAttackTime")]
	public int EnvelopeFollowerAttackTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:EnvelopeFollowerAttackTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:EnvelopeFollowerAttackTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:EnvelopeFollowerReleaseTime")]
	public int EnvelopeFollowerReleaseTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:EnvelopeFollowerReleaseTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:EnvelopeFollowerReleaseTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:OutputVolumeModulation")]
	public FSoundModulationDestinationSettings OutputVolumeModulation
	{
		get
		{
			CheckDestroyed();
			if (!OutputVolumeModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:OutputVolumeModulation");
				return default(FSoundModulationDestinationSettings);
			}
			return FSoundModulationDestinationSettings.FromNative(IntPtr.Add(base.Address, OutputVolumeModulation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OutputVolumeModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:OutputVolumeModulation");
			}
			else
			{
				FSoundModulationDestinationSettings.ToNative(IntPtr.Add(base.Address, OutputVolumeModulation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:WetLevelModulation")]
	public FSoundModulationDestinationSettings WetLevelModulation
	{
		get
		{
			CheckDestroyed();
			if (!WetLevelModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:WetLevelModulation");
				return default(FSoundModulationDestinationSettings);
			}
			return FSoundModulationDestinationSettings.FromNative(IntPtr.Add(base.Address, WetLevelModulation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WetLevelModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:WetLevelModulation");
			}
			else
			{
				FSoundModulationDestinationSettings.ToNative(IntPtr.Add(base.Address, WetLevelModulation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:DryLevelModulation")]
	public FSoundModulationDestinationSettings DryLevelModulation
	{
		get
		{
			CheckDestroyed();
			if (!DryLevelModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:DryLevelModulation");
				return default(FSoundModulationDestinationSettings);
			}
			return FSoundModulationDestinationSettings.FromNative(IntPtr.Add(base.Address, DryLevelModulation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DryLevelModulation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:DryLevelModulation");
			}
			else
			{
				FSoundModulationDestinationSettings.ToNative(IntPtr.Add(base.Address, DryLevelModulation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:AudioLinkSettings")]
	public UAudioLinkSettingsAbstract AudioLinkSettings
	{
		get
		{
			CheckDestroyed();
			if (!AudioLinkSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:AudioLinkSettings");
				return null;
			}
			return UObjectMarshaler<UAudioLinkSettingsAbstract>.FromNative(IntPtr.Add(base.Address, AudioLinkSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioLinkSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:AudioLinkSettings");
			}
			else
			{
				UObjectMarshaler<UAudioLinkSettingsAbstract>.ToNative(IntPtr.Add(base.Address, AudioLinkSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.SoundSubmix:OnSubmixRecordedFileDone")]
	public FOnSubmixRecordedFileDone OnSubmixRecordedFileDone
	{
		get
		{
			CheckDestroyed();
			if (!OnSubmixRecordedFileDone_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundSubmix:OnSubmixRecordedFileDone");
				return new FOnSubmixRecordedFileDone();
			}
			if (OnSubmixRecordedFileDone_DelegateCached == null)
			{
				OnSubmixRecordedFileDone_DelegateCached = new FOnSubmixRecordedFileDone();
				OnSubmixRecordedFileDone_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSubmixRecordedFileDone_Offset));
			}
			return OnSubmixRecordedFileDone_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StopSpectralAnalysis")]
	public unsafe void StopSpectralAnalysis(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!StopSpectralAnalysis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StopSpectralAnalysis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopSpectralAnalysis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopSpectralAnalysis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopSpectralAnalysis_WorldContextObject_Offset), 0, StopSpectralAnalysis_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopSpectralAnalysis_FunctionAddress, intPtr, StopSpectralAnalysis_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StopRecordingOutput")]
	public unsafe void StopRecordingOutput(UObject WorldContextObject, EAudioRecordingExportType ExportType, string Name, string Path, USoundWave ExistingSoundWaveToOverwrite)
	{
		CheckDestroyed();
		if (!StopRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StopRecordingOutput");
			return;
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
		UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset), 0, StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress.Address, ExistingSoundWaveToOverwrite);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopRecordingOutput_FunctionAddress, intPtr, StopRecordingOutput_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StopRecordingOutput_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StopRecordingOutput_Path_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StopEnvelopeFollowing")]
	public unsafe void StopEnvelopeFollowing(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!StopEnvelopeFollowing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StopEnvelopeFollowing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopEnvelopeFollowing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopEnvelopeFollowing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopEnvelopeFollowing_WorldContextObject_Offset), 0, StopEnvelopeFollowing_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopEnvelopeFollowing_FunctionAddress, intPtr, StopEnvelopeFollowing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StartSpectralAnalysis")]
	public unsafe void StartSpectralAnalysis(UObject WorldContextObject, EFFTSize FFTSize = EFFTSize.DefaultSize, EFFTPeakInterpolationMethod InterpolationMethod = EFFTPeakInterpolationMethod.Linear, EFFTWindowType WindowType = EFFTWindowType.Hann, float HopSize = 0f, EAudioSpectrumType SpectrumType = EAudioSpectrumType.MagnitudeSpectrum)
	{
		CheckDestroyed();
		if (!StartSpectralAnalysis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StartSpectralAnalysis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartSpectralAnalysis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartSpectralAnalysis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_WorldContextObject_Offset), 0, StartSpectralAnalysis_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		EnumMarshaler<EFFTSize>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_FFTSize_Offset), 0, StartSpectralAnalysis_FFTSize_PropertyAddress.Address, FFTSize);
		EnumMarshaler<EFFTPeakInterpolationMethod>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_InterpolationMethod_Offset), 0, StartSpectralAnalysis_InterpolationMethod_PropertyAddress.Address, InterpolationMethod);
		EnumMarshaler<EFFTWindowType>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_WindowType_Offset), 0, StartSpectralAnalysis_WindowType_PropertyAddress.Address, WindowType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_HopSize_Offset), 0, StartSpectralAnalysis_HopSize_PropertyAddress.Address, HopSize);
		EnumMarshaler<EAudioSpectrumType>.ToNative(IntPtr.Add(intPtr, StartSpectralAnalysis_SpectrumType_Offset), 0, StartSpectralAnalysis_SpectrumType_PropertyAddress.Address, SpectrumType);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartSpectralAnalysis_FunctionAddress, intPtr, StartSpectralAnalysis_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StartRecordingOutput")]
	public unsafe void StartRecordingOutput(UObject WorldContextObject, float ExpectedDuration)
	{
		CheckDestroyed();
		if (!StartRecordingOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StartRecordingOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartRecordingOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartRecordingOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartRecordingOutput_WorldContextObject_Offset), 0, StartRecordingOutput_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, StartRecordingOutput_ExpectedDuration_Offset), 0, StartRecordingOutput_ExpectedDuration_PropertyAddress.Address, ExpectedDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartRecordingOutput_FunctionAddress, intPtr, StartRecordingOutput_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:StartEnvelopeFollowing")]
	public unsafe void StartEnvelopeFollowing(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!StartEnvelopeFollowing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:StartEnvelopeFollowing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartEnvelopeFollowing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartEnvelopeFollowing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartEnvelopeFollowing_WorldContextObject_Offset), 0, StartEnvelopeFollowing_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartEnvelopeFollowing_FunctionAddress, intPtr, StartEnvelopeFollowing_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:SetSubmixWetLevel")]
	public unsafe void SetSubmixWetLevel(UObject WorldContextObject, float InWetLevel)
	{
		CheckDestroyed();
		if (!SetSubmixWetLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:SetSubmixWetLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixWetLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixWetLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSubmixWetLevel_WorldContextObject_Offset), 0, SetSubmixWetLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSubmixWetLevel_InWetLevel_Offset), 0, SetSubmixWetLevel_InWetLevel_PropertyAddress.Address, InWetLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixWetLevel_FunctionAddress, intPtr, SetSubmixWetLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:SetSubmixOutputVolume")]
	public unsafe void SetSubmixOutputVolume(UObject WorldContextObject, float InOutputVolume)
	{
		CheckDestroyed();
		if (!SetSubmixOutputVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:SetSubmixOutputVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixOutputVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixOutputVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSubmixOutputVolume_WorldContextObject_Offset), 0, SetSubmixOutputVolume_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSubmixOutputVolume_InOutputVolume_Offset), 0, SetSubmixOutputVolume_InOutputVolume_PropertyAddress.Address, InOutputVolume);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixOutputVolume_FunctionAddress, intPtr, SetSubmixOutputVolume_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SoundSubmix:SetSubmixDryLevel")]
	public unsafe void SetSubmixDryLevel(UObject WorldContextObject, float InDryLevel)
	{
		CheckDestroyed();
		if (!SetSubmixDryLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:SetSubmixDryLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSubmixDryLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSubmixDryLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetSubmixDryLevel_WorldContextObject_Offset), 0, SetSubmixDryLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSubmixDryLevel_InDryLevel_Offset), 0, SetSubmixDryLevel_InDryLevel_PropertyAddress.Address, InDryLevel);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSubmixDryLevel_FunctionAddress, intPtr, SetSubmixDryLevel_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SoundSubmix:RemoveSpectralAnalysisDelegate")]
	public unsafe void RemoveSpectralAnalysisDelegate(UObject WorldContextObject, FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP)
	{
		CheckDestroyed();
		if (!RemoveSpectralAnalysisDelegate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:RemoveSpectralAnalysisDelegate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSpectralAnalysisDelegate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSpectralAnalysisDelegate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveSpectralAnalysisDelegate_WorldContextObject_Offset), 0, RemoveSpectralAnalysisDelegate_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnSubmixSpectralAnalysisBP>.ToNative(IntPtr.Add(intPtr, RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset), 0, RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress.Address, OnSubmixSpectralAnalysisBP);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSpectralAnalysisDelegate_FunctionAddress, intPtr, RemoveSpectralAnalysisDelegate_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SoundSubmix:AddSpectralAnalysisDelegate")]
	public unsafe void AddSpectralAnalysisDelegate(UObject WorldContextObject, List<FSoundSubmixSpectralAnalysisBandSettings> InBandSettings, FOnSubmixSpectralAnalysisBP OnSubmixSpectralAnalysisBP, float UpdateRate = 10f, float DecibelNoiseFloor = -40f, bool bDoNormalize = true, bool bDoAutoRange = false, float AutoRangeAttackTime = 0.1f, float AutoRangeReleaseTime = 60f)
	{
		CheckDestroyed();
		if (!AddSpectralAnalysisDelegate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:AddSpectralAnalysisDelegate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSpectralAnalysisDelegate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSpectralAnalysisDelegate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_WorldContextObject_Offset), 0, AddSpectralAnalysisDelegate_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<FSoundSubmixSpectralAnalysisBandSettings>(1, AddSpectralAnalysisDelegate_InBandSettings_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.FromNative, CachedMarshalingDelegates<FSoundSubmixSpectralAnalysisBandSettings, FSoundSubmixSpectralAnalysisBandSettings>.ToNative).ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_InBandSettings_Offset), InBandSettings);
		FDelegateMarshaler<FOnSubmixSpectralAnalysisBP>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset), 0, AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress.Address, OnSubmixSpectralAnalysisBP);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_UpdateRate_Offset), 0, AddSpectralAnalysisDelegate_UpdateRate_PropertyAddress.Address, UpdateRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_DecibelNoiseFloor_Offset), 0, AddSpectralAnalysisDelegate_DecibelNoiseFloor_PropertyAddress.Address, DecibelNoiseFloor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_bDoNormalize_Offset), 0, AddSpectralAnalysisDelegate_bDoNormalize_PropertyAddress.Address, bDoNormalize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_bDoAutoRange_Offset), 0, AddSpectralAnalysisDelegate_bDoAutoRange_PropertyAddress.Address, bDoAutoRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_AutoRangeAttackTime_Offset), 0, AddSpectralAnalysisDelegate_AutoRangeAttackTime_PropertyAddress.Address, AutoRangeAttackTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddSpectralAnalysisDelegate_AutoRangeReleaseTime_Offset), 0, AddSpectralAnalysisDelegate_AutoRangeReleaseTime_PropertyAddress.Address, AutoRangeReleaseTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddSpectralAnalysisDelegate_FunctionAddress, intPtr, AddSpectralAnalysisDelegate_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddSpectralAnalysisDelegate_InBandSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.SoundSubmix:AddEnvelopeFollowerDelegate")]
	public unsafe void AddEnvelopeFollowerDelegate(UObject WorldContextObject, FOnSubmixEnvelopeBP OnSubmixEnvelopeBP)
	{
		CheckDestroyed();
		if (!AddEnvelopeFollowerDelegate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SoundSubmix:AddEnvelopeFollowerDelegate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEnvelopeFollowerDelegate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEnvelopeFollowerDelegate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddEnvelopeFollowerDelegate_WorldContextObject_Offset), 0, AddEnvelopeFollowerDelegate_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		FDelegateMarshaler<FOnSubmixEnvelopeBP>.ToNative(IntPtr.Add(intPtr, AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_Offset), 0, AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_PropertyAddress.Address, OnSubmixEnvelopeBP);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddEnvelopeFollowerDelegate_FunctionAddress, intPtr, AddEnvelopeFollowerDelegate_ParamsSize);
	}

	static USoundSubmix()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundSubmix)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundSubmix));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SoundSubmix");
		NativeReflectionCached.GetPropertyRef(ref MuteWhenBackgrounded_PropertyAddress, intPtr, "bMuteWhenBackgrounded");
		MuteWhenBackgrounded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMuteWhenBackgrounded");
		MuteWhenBackgrounded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMuteWhenBackgrounded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixEffectChain_PropertyAddress, intPtr, "SubmixEffectChain");
		SubmixEffectChain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixEffectChain");
		SubmixEffectChain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixEffectChain", Classes.FArrayProperty);
		AmbisonicsPluginSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AmbisonicsPluginSettings");
		AmbisonicsPluginSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AmbisonicsPluginSettings", Classes.FObjectProperty);
		EnvelopeFollowerAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerAttackTime");
		EnvelopeFollowerAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerAttackTime", Classes.FIntProperty);
		EnvelopeFollowerReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerReleaseTime");
		EnvelopeFollowerReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerReleaseTime", Classes.FIntProperty);
		OutputVolumeModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputVolumeModulation");
		OutputVolumeModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputVolumeModulation", Classes.FStructProperty);
		WetLevelModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevelModulation");
		WetLevelModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevelModulation", Classes.FStructProperty);
		DryLevelModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryLevelModulation");
		DryLevelModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryLevelModulation", Classes.FStructProperty);
		AudioLinkSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AudioLinkSettings");
		AudioLinkSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AudioLinkSettings", Classes.FObjectProperty);
		OnSubmixRecordedFileDone_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSubmixRecordedFileDone");
		OnSubmixRecordedFileDone_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSubmixRecordedFileDone", Classes.FMulticastDelegateProperty);
		StopSpectralAnalysis_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopSpectralAnalysis");
		StopSpectralAnalysis_ParamsSize = NativeReflection.GetFunctionParamsSize(StopSpectralAnalysis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopSpectralAnalysis_WorldContextObject_PropertyAddress, StopSpectralAnalysis_FunctionAddress, "WorldContextObject");
		StopSpectralAnalysis_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopSpectralAnalysis_FunctionAddress, "WorldContextObject");
		StopSpectralAnalysis_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopSpectralAnalysis_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StopSpectralAnalysis_IsValid = StopSpectralAnalysis_FunctionAddress != IntPtr.Zero && StopSpectralAnalysis_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StopSpectralAnalysis", StopSpectralAnalysis_IsValid);
		StopRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopRecordingOutput");
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
		NativeReflectionCached.GetPropertyRef(ref StopRecordingOutput_ExistingSoundWaveToOverwrite_PropertyAddress, StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite");
		StopRecordingOutput_ExistingSoundWaveToOverwrite_Offset = NativeReflectionCached.GetPropertyOffset(StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite");
		StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid = NativeReflectionCached.ValidatePropertyClass(StopRecordingOutput_FunctionAddress, "ExistingSoundWaveToOverwrite", Classes.FObjectProperty);
		StopRecordingOutput_IsValid = StopRecordingOutput_FunctionAddress != IntPtr.Zero && StopRecordingOutput_WorldContextObject_IsValid && StopRecordingOutput_ExportType_IsValid && StopRecordingOutput_Name_IsValid && StopRecordingOutput_Path_IsValid && StopRecordingOutput_ExistingSoundWaveToOverwrite_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StopRecordingOutput", StopRecordingOutput_IsValid);
		StopEnvelopeFollowing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopEnvelopeFollowing");
		StopEnvelopeFollowing_ParamsSize = NativeReflection.GetFunctionParamsSize(StopEnvelopeFollowing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopEnvelopeFollowing_WorldContextObject_PropertyAddress, StopEnvelopeFollowing_FunctionAddress, "WorldContextObject");
		StopEnvelopeFollowing_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopEnvelopeFollowing_FunctionAddress, "WorldContextObject");
		StopEnvelopeFollowing_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopEnvelopeFollowing_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StopEnvelopeFollowing_IsValid = StopEnvelopeFollowing_FunctionAddress != IntPtr.Zero && StopEnvelopeFollowing_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StopEnvelopeFollowing", StopEnvelopeFollowing_IsValid);
		StartSpectralAnalysis_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartSpectralAnalysis");
		StartSpectralAnalysis_ParamsSize = NativeReflection.GetFunctionParamsSize(StartSpectralAnalysis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_WorldContextObject_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "WorldContextObject");
		StartSpectralAnalysis_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "WorldContextObject");
		StartSpectralAnalysis_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_FFTSize_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "FFTSize");
		StartSpectralAnalysis_FFTSize_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "FFTSize");
		StartSpectralAnalysis_FFTSize_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "FFTSize", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_InterpolationMethod_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "InterpolationMethod");
		StartSpectralAnalysis_InterpolationMethod_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "InterpolationMethod");
		StartSpectralAnalysis_InterpolationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "InterpolationMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_WindowType_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "WindowType");
		StartSpectralAnalysis_WindowType_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "WindowType");
		StartSpectralAnalysis_WindowType_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "WindowType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_HopSize_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "HopSize");
		StartSpectralAnalysis_HopSize_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "HopSize");
		StartSpectralAnalysis_HopSize_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "HopSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StartSpectralAnalysis_SpectrumType_PropertyAddress, StartSpectralAnalysis_FunctionAddress, "SpectrumType");
		StartSpectralAnalysis_SpectrumType_Offset = NativeReflectionCached.GetPropertyOffset(StartSpectralAnalysis_FunctionAddress, "SpectrumType");
		StartSpectralAnalysis_SpectrumType_IsValid = NativeReflectionCached.ValidatePropertyClass(StartSpectralAnalysis_FunctionAddress, "SpectrumType", Classes.FEnumProperty);
		StartSpectralAnalysis_IsValid = StartSpectralAnalysis_FunctionAddress != IntPtr.Zero && StartSpectralAnalysis_WorldContextObject_IsValid && StartSpectralAnalysis_FFTSize_IsValid && StartSpectralAnalysis_InterpolationMethod_IsValid && StartSpectralAnalysis_WindowType_IsValid && StartSpectralAnalysis_HopSize_IsValid && StartSpectralAnalysis_SpectrumType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StartSpectralAnalysis", StartSpectralAnalysis_IsValid);
		StartRecordingOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartRecordingOutput");
		StartRecordingOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(StartRecordingOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingOutput_WorldContextObject_PropertyAddress, StartRecordingOutput_FunctionAddress, "WorldContextObject");
		StartRecordingOutput_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingOutput_FunctionAddress, "WorldContextObject");
		StartRecordingOutput_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingOutput_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartRecordingOutput_ExpectedDuration_PropertyAddress, StartRecordingOutput_FunctionAddress, "ExpectedDuration");
		StartRecordingOutput_ExpectedDuration_Offset = NativeReflectionCached.GetPropertyOffset(StartRecordingOutput_FunctionAddress, "ExpectedDuration");
		StartRecordingOutput_ExpectedDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(StartRecordingOutput_FunctionAddress, "ExpectedDuration", Classes.FFloatProperty);
		StartRecordingOutput_IsValid = StartRecordingOutput_FunctionAddress != IntPtr.Zero && StartRecordingOutput_WorldContextObject_IsValid && StartRecordingOutput_ExpectedDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StartRecordingOutput", StartRecordingOutput_IsValid);
		StartEnvelopeFollowing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StartEnvelopeFollowing");
		StartEnvelopeFollowing_ParamsSize = NativeReflection.GetFunctionParamsSize(StartEnvelopeFollowing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartEnvelopeFollowing_WorldContextObject_PropertyAddress, StartEnvelopeFollowing_FunctionAddress, "WorldContextObject");
		StartEnvelopeFollowing_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartEnvelopeFollowing_FunctionAddress, "WorldContextObject");
		StartEnvelopeFollowing_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartEnvelopeFollowing_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StartEnvelopeFollowing_IsValid = StartEnvelopeFollowing_FunctionAddress != IntPtr.Zero && StartEnvelopeFollowing_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:StartEnvelopeFollowing", StartEnvelopeFollowing_IsValid);
		SetSubmixWetLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixWetLevel");
		SetSubmixWetLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixWetLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixWetLevel_WorldContextObject_PropertyAddress, SetSubmixWetLevel_FunctionAddress, "WorldContextObject");
		SetSubmixWetLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixWetLevel_FunctionAddress, "WorldContextObject");
		SetSubmixWetLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixWetLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixWetLevel_InWetLevel_PropertyAddress, SetSubmixWetLevel_FunctionAddress, "InWetLevel");
		SetSubmixWetLevel_InWetLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixWetLevel_FunctionAddress, "InWetLevel");
		SetSubmixWetLevel_InWetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixWetLevel_FunctionAddress, "InWetLevel", Classes.FFloatProperty);
		SetSubmixWetLevel_IsValid = SetSubmixWetLevel_FunctionAddress != IntPtr.Zero && SetSubmixWetLevel_WorldContextObject_IsValid && SetSubmixWetLevel_InWetLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:SetSubmixWetLevel", SetSubmixWetLevel_IsValid);
		SetSubmixOutputVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixOutputVolume");
		SetSubmixOutputVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixOutputVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixOutputVolume_WorldContextObject_PropertyAddress, SetSubmixOutputVolume_FunctionAddress, "WorldContextObject");
		SetSubmixOutputVolume_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixOutputVolume_FunctionAddress, "WorldContextObject");
		SetSubmixOutputVolume_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixOutputVolume_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixOutputVolume_InOutputVolume_PropertyAddress, SetSubmixOutputVolume_FunctionAddress, "InOutputVolume");
		SetSubmixOutputVolume_InOutputVolume_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixOutputVolume_FunctionAddress, "InOutputVolume");
		SetSubmixOutputVolume_InOutputVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixOutputVolume_FunctionAddress, "InOutputVolume", Classes.FFloatProperty);
		SetSubmixOutputVolume_IsValid = SetSubmixOutputVolume_FunctionAddress != IntPtr.Zero && SetSubmixOutputVolume_WorldContextObject_IsValid && SetSubmixOutputVolume_InOutputVolume_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:SetSubmixOutputVolume", SetSubmixOutputVolume_IsValid);
		SetSubmixDryLevel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixDryLevel");
		SetSubmixDryLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixDryLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixDryLevel_WorldContextObject_PropertyAddress, SetSubmixDryLevel_FunctionAddress, "WorldContextObject");
		SetSubmixDryLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixDryLevel_FunctionAddress, "WorldContextObject");
		SetSubmixDryLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixDryLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixDryLevel_InDryLevel_PropertyAddress, SetSubmixDryLevel_FunctionAddress, "InDryLevel");
		SetSubmixDryLevel_InDryLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixDryLevel_FunctionAddress, "InDryLevel");
		SetSubmixDryLevel_InDryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixDryLevel_FunctionAddress, "InDryLevel", Classes.FFloatProperty);
		SetSubmixDryLevel_IsValid = SetSubmixDryLevel_FunctionAddress != IntPtr.Zero && SetSubmixDryLevel_WorldContextObject_IsValid && SetSubmixDryLevel_InDryLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:SetSubmixDryLevel", SetSubmixDryLevel_IsValid);
		RemoveSpectralAnalysisDelegate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveSpectralAnalysisDelegate");
		RemoveSpectralAnalysisDelegate_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSpectralAnalysisDelegate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSpectralAnalysisDelegate_WorldContextObject_PropertyAddress, RemoveSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject");
		RemoveSpectralAnalysisDelegate_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject");
		RemoveSpectralAnalysisDelegate_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress, RemoveSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP");
		RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP");
		RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP", Classes.FDelegateProperty);
		RemoveSpectralAnalysisDelegate_IsValid = RemoveSpectralAnalysisDelegate_FunctionAddress != IntPtr.Zero && RemoveSpectralAnalysisDelegate_WorldContextObject_IsValid && RemoveSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:RemoveSpectralAnalysisDelegate", RemoveSpectralAnalysisDelegate_IsValid);
		AddSpectralAnalysisDelegate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSpectralAnalysisDelegate");
		AddSpectralAnalysisDelegate_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSpectralAnalysisDelegate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_WorldContextObject_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject");
		AddSpectralAnalysisDelegate_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject");
		AddSpectralAnalysisDelegate_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_InBandSettings_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "InBandSettings");
		AddSpectralAnalysisDelegate_InBandSettings_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "InBandSettings");
		AddSpectralAnalysisDelegate_InBandSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "InBandSettings", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP");
		AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP");
		AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "OnSubmixSpectralAnalysisBP", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_UpdateRate_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "UpdateRate");
		AddSpectralAnalysisDelegate_UpdateRate_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "UpdateRate");
		AddSpectralAnalysisDelegate_UpdateRate_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "UpdateRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_DecibelNoiseFloor_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "DecibelNoiseFloor");
		AddSpectralAnalysisDelegate_DecibelNoiseFloor_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "DecibelNoiseFloor");
		AddSpectralAnalysisDelegate_DecibelNoiseFloor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "DecibelNoiseFloor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_bDoNormalize_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "bDoNormalize");
		AddSpectralAnalysisDelegate_bDoNormalize_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "bDoNormalize");
		AddSpectralAnalysisDelegate_bDoNormalize_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "bDoNormalize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_bDoAutoRange_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "bDoAutoRange");
		AddSpectralAnalysisDelegate_bDoAutoRange_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "bDoAutoRange");
		AddSpectralAnalysisDelegate_bDoAutoRange_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "bDoAutoRange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_AutoRangeAttackTime_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeAttackTime");
		AddSpectralAnalysisDelegate_AutoRangeAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeAttackTime");
		AddSpectralAnalysisDelegate_AutoRangeAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeAttackTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSpectralAnalysisDelegate_AutoRangeReleaseTime_PropertyAddress, AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeReleaseTime");
		AddSpectralAnalysisDelegate_AutoRangeReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeReleaseTime");
		AddSpectralAnalysisDelegate_AutoRangeReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSpectralAnalysisDelegate_FunctionAddress, "AutoRangeReleaseTime", Classes.FFloatProperty);
		AddSpectralAnalysisDelegate_IsValid = AddSpectralAnalysisDelegate_FunctionAddress != IntPtr.Zero && AddSpectralAnalysisDelegate_WorldContextObject_IsValid && AddSpectralAnalysisDelegate_InBandSettings_IsValid && AddSpectralAnalysisDelegate_OnSubmixSpectralAnalysisBP_IsValid && AddSpectralAnalysisDelegate_UpdateRate_IsValid && AddSpectralAnalysisDelegate_DecibelNoiseFloor_IsValid && AddSpectralAnalysisDelegate_bDoNormalize_IsValid && AddSpectralAnalysisDelegate_bDoAutoRange_IsValid && AddSpectralAnalysisDelegate_AutoRangeAttackTime_IsValid && AddSpectralAnalysisDelegate_AutoRangeReleaseTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:AddSpectralAnalysisDelegate", AddSpectralAnalysisDelegate_IsValid);
		AddEnvelopeFollowerDelegate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddEnvelopeFollowerDelegate");
		AddEnvelopeFollowerDelegate_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEnvelopeFollowerDelegate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEnvelopeFollowerDelegate_WorldContextObject_PropertyAddress, AddEnvelopeFollowerDelegate_FunctionAddress, "WorldContextObject");
		AddEnvelopeFollowerDelegate_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddEnvelopeFollowerDelegate_FunctionAddress, "WorldContextObject");
		AddEnvelopeFollowerDelegate_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnvelopeFollowerDelegate_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_PropertyAddress, AddEnvelopeFollowerDelegate_FunctionAddress, "OnSubmixEnvelopeBP");
		AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_Offset = NativeReflectionCached.GetPropertyOffset(AddEnvelopeFollowerDelegate_FunctionAddress, "OnSubmixEnvelopeBP");
		AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEnvelopeFollowerDelegate_FunctionAddress, "OnSubmixEnvelopeBP", Classes.FDelegateProperty);
		AddEnvelopeFollowerDelegate_IsValid = AddEnvelopeFollowerDelegate_FunctionAddress != IntPtr.Zero && AddEnvelopeFollowerDelegate_WorldContextObject_IsValid && AddEnvelopeFollowerDelegate_OnSubmixEnvelopeBP_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SoundSubmix:AddEnvelopeFollowerDelegate", AddEnvelopeFollowerDelegate_IsValid);
	}
}
