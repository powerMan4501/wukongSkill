using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SynthComponent", "AudioMixer", UnrealModuleType.Engine)]
public class USynthComponent : USceneComponent
{
	private static bool AllowSpatialization_IsValid;

	private static FFieldAddress AllowSpatialization_PropertyAddress;

	private static int AllowSpatialization_Offset;

	private static bool OverrideAttenuation_IsValid;

	private static FFieldAddress OverrideAttenuation_PropertyAddress;

	private static int OverrideAttenuation_Offset;

	private static bool EnableBusSends_IsValid;

	private static FFieldAddress EnableBusSends_PropertyAddress;

	private static int EnableBusSends_Offset;

	private static bool AttenuationSettings_IsValid;

	private static int AttenuationSettings_Offset;

	private static bool AttenuationOverrides_IsValid;

	private static int AttenuationOverrides_Offset;

	private static bool ConcurrencySet_IsValid;

	private static FFieldAddress ConcurrencySet_PropertyAddress;

	private static int ConcurrencySet_Offset;

	private TSetReadWriteMarshaler<USoundConcurrency> ConcurrencySet_MarshalerCached;

	private static bool SoundSubmixSends_IsValid;

	private static FFieldAddress SoundSubmixSends_PropertyAddress;

	private static int SoundSubmixSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSubmixSendInfo> SoundSubmixSends_MarshalerCached;

	private static bool BusSends_IsValid;

	private static FFieldAddress BusSends_PropertyAddress;

	private static int BusSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSourceBusSendInfo> BusSends_MarshalerCached;

	private static bool PreEffectBusSends_IsValid;

	private static FFieldAddress PreEffectBusSends_PropertyAddress;

	private static int PreEffectBusSends_Offset;

	private TArrayReadWriteMarshaler<FSoundSourceBusSendInfo> PreEffectBusSends_MarshalerCached;

	private static bool IsUISound_IsValid;

	private static FFieldAddress IsUISound_PropertyAddress;

	private static int IsUISound_Offset;

	private static bool EnvelopeFollowerAttackTime_IsValid;

	private static int EnvelopeFollowerAttackTime_Offset;

	private static bool EnvelopeFollowerReleaseTime_IsValid;

	private static int EnvelopeFollowerReleaseTime_Offset;

	private static bool OnAudioEnvelopeValue_IsValid;

	private static int OnAudioEnvelopeValue_Offset;

	private FOnSynthEnvelopeValue OnAudioEnvelopeValue_DelegateCached;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool Start_IsValid;

	private static IntPtr Start_FunctionAddress;

	private static int Start_ParamsSize;

	private static bool SetVolumeMultiplier_IsValid;

	private static IntPtr SetVolumeMultiplier_FunctionAddress;

	private static int SetVolumeMultiplier_ParamsSize;

	private static bool SetVolumeMultiplier_VolumeMultiplier_IsValid;

	private static FFieldAddress SetVolumeMultiplier_VolumeMultiplier_PropertyAddress;

	private static int SetVolumeMultiplier_VolumeMultiplier_Offset;

	private static bool SetSubmixSend_IsValid;

	private static IntPtr SetSubmixSend_FunctionAddress;

	private static int SetSubmixSend_ParamsSize;

	private static bool SetSubmixSend_Submix_IsValid;

	private static FFieldAddress SetSubmixSend_Submix_PropertyAddress;

	private static int SetSubmixSend_Submix_Offset;

	private static bool SetSubmixSend_SendLevel_IsValid;

	private static FFieldAddress SetSubmixSend_SendLevel_PropertyAddress;

	private static int SetSubmixSend_SendLevel_Offset;

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

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:bAllowSpatialization")]
	public bool AllowSpatialization
	{
		get
		{
			CheckDestroyed();
			if (!AllowSpatialization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bAllowSpatialization");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AllowSpatialization_Offset), 0, AllowSpatialization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AllowSpatialization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bAllowSpatialization");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AllowSpatialization_Offset), 0, AllowSpatialization_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:bOverrideAttenuation")]
	public bool OverrideAttenuation
	{
		get
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bOverrideAttenuation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideAttenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bOverrideAttenuation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OverrideAttenuation_Offset), 0, OverrideAttenuation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:bEnableBusSends")]
	public bool EnableBusSends
	{
		get
		{
			CheckDestroyed();
			if (!EnableBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bEnableBusSends");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableBusSends_Offset), 0, EnableBusSends_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bEnableBusSends");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableBusSends_Offset), 0, EnableBusSends_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:AttenuationSettings")]
	public USoundAttenuation AttenuationSettings
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:AttenuationSettings");
				return null;
			}
			return UObjectMarshaler<USoundAttenuation>.FromNative(IntPtr.Add(base.Address, AttenuationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:AttenuationSettings");
			}
			else
			{
				UObjectMarshaler<USoundAttenuation>.ToNative(IntPtr.Add(base.Address, AttenuationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:AttenuationOverrides")]
	public FSoundAttenuationSettings AttenuationOverrides
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:AttenuationOverrides");
				return default(FSoundAttenuationSettings);
			}
			return FSoundAttenuationSettings.FromNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationOverrides_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:AttenuationOverrides");
			}
			else
			{
				FSoundAttenuationSettings.ToNative(IntPtr.Add(base.Address, AttenuationOverrides_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)5629499534213125uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:ConcurrencySet")]
	public TSetReadWrite<USoundConcurrency> ConcurrencySet
	{
		get
		{
			CheckDestroyed();
			if (!ConcurrencySet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:ConcurrencySet");
				return null;
			}
			if (ConcurrencySet_MarshalerCached == null)
			{
				ConcurrencySet_MarshalerCached = new TSetReadWriteMarshaler<USoundConcurrency>(1, ConcurrencySet_PropertyAddress, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.FromNative, CachedMarshalingDelegates<USoundConcurrency, UObjectMarshaler<USoundConcurrency>>.ToNative);
			}
			return ConcurrencySet_MarshalerCached.FromNative(IntPtr.Add(base.Address, ConcurrencySet_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:SoundSubmixSends")]
	public TArrayReadWrite<FSoundSubmixSendInfo> SoundSubmixSends
	{
		get
		{
			CheckDestroyed();
			if (!SoundSubmixSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:SoundSubmixSends");
				return null;
			}
			if (SoundSubmixSends_MarshalerCached == null)
			{
				SoundSubmixSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSubmixSendInfo>(1, SoundSubmixSends_PropertyAddress, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSubmixSendInfo, FSoundSubmixSendInfo>.ToNative);
			}
			return SoundSubmixSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, SoundSubmixSends_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:BusSends")]
	public TArrayReadWrite<FSoundSourceBusSendInfo> BusSends
	{
		get
		{
			CheckDestroyed();
			if (!BusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:BusSends");
				return null;
			}
			if (BusSends_MarshalerCached == null)
			{
				BusSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSourceBusSendInfo>(1, BusSends_PropertyAddress, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.ToNative);
			}
			return BusSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, BusSends_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:PreEffectBusSends")]
	public TArrayReadWrite<FSoundSourceBusSendInfo> PreEffectBusSends
	{
		get
		{
			CheckDestroyed();
			if (!PreEffectBusSends_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:PreEffectBusSends");
				return null;
			}
			if (PreEffectBusSends_MarshalerCached == null)
			{
				PreEffectBusSends_MarshalerCached = new TArrayReadWriteMarshaler<FSoundSourceBusSendInfo>(1, PreEffectBusSends_PropertyAddress, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.FromNative, CachedMarshalingDelegates<FSoundSourceBusSendInfo, FSoundSourceBusSendInfo>.ToNative);
			}
			return PreEffectBusSends_MarshalerCached.FromNative(IntPtr.Add(base.Address, PreEffectBusSends_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:bIsUISound")]
	public bool IsUISound
	{
		get
		{
			CheckDestroyed();
			if (!IsUISound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bIsUISound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUISound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:bIsUISound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:EnvelopeFollowerAttackTime")]
	public int EnvelopeFollowerAttackTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:EnvelopeFollowerAttackTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerAttackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:EnvelopeFollowerAttackTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerAttackTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:EnvelopeFollowerReleaseTime")]
	public int EnvelopeFollowerReleaseTime
	{
		get
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:EnvelopeFollowerReleaseTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvelopeFollowerReleaseTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:EnvelopeFollowerReleaseTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EnvelopeFollowerReleaseTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:OnAudioEnvelopeValue")]
	public FOnSynthEnvelopeValue OnAudioEnvelopeValue
	{
		get
		{
			CheckDestroyed();
			if (!OnAudioEnvelopeValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioMixer.SynthComponent:OnAudioEnvelopeValue");
				return new FOnSynthEnvelopeValue();
			}
			if (OnAudioEnvelopeValue_DelegateCached == null)
			{
				OnAudioEnvelopeValue_DelegateCached = new FOnSynthEnvelopeValue();
				OnAudioEnvelopeValue_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnAudioEnvelopeValue_Offset));
			}
			return OnAudioEnvelopeValue_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:Start")]
	public unsafe void Start()
	{
		CheckDestroyed();
		if (!Start_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:Start");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Start_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Start_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Start_FunctionAddress, argsSize: Start_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:SetVolumeMultiplier")]
	public unsafe void SetVolumeMultiplier(float VolumeMultiplier)
	{
		CheckDestroyed();
		if (!SetVolumeMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:SetVolumeMultiplier");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumeMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumeMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumeMultiplier_VolumeMultiplier_Offset), 0, SetVolumeMultiplier_VolumeMultiplier_PropertyAddress.Address, VolumeMultiplier);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumeMultiplier_FunctionAddress, intPtr, SetVolumeMultiplier_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:SetSubmixSend")]
	public unsafe void SetSubmixSend(USoundSubmixBase Submix, float SendLevel)
	{
		CheckDestroyed();
		if (!SetSubmixSend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:SetSubmixSend");
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
	[UMetaPath("/Script/AudioMixer.SynthComponent:SetOutputToBusOnly")]
	public unsafe void SetOutputToBusOnly(bool bInOutputToBusOnly)
	{
		CheckDestroyed();
		if (!SetOutputToBusOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:SetOutputToBusOnly");
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

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:SetLowPassFilterFrequency")]
	public unsafe void SetLowPassFilterFrequency(float InLowPassFilterFrequency)
	{
		CheckDestroyed();
		if (!SetLowPassFilterFrequency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:SetLowPassFilterFrequency");
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
	[UMetaPath("/Script/AudioMixer.SynthComponent:SetLowPassFilterEnabled")]
	public unsafe void SetLowPassFilterEnabled(bool InLowPassFilterEnabled)
	{
		CheckDestroyed();
		if (!SetLowPassFilterEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:SetLowPassFilterEnabled");
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

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/AudioMixer.SynthComponent:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.SynthComponent:IsPlaying");
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

	static USynthComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AudioMixer.SynthComponent");
		NativeReflectionCached.GetPropertyRef(ref AllowSpatialization_PropertyAddress, intPtr, "bAllowSpatialization");
		AllowSpatialization_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSpatialization");
		AllowSpatialization_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSpatialization", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideAttenuation_PropertyAddress, intPtr, "bOverrideAttenuation");
		OverrideAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverrideAttenuation");
		OverrideAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverrideAttenuation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableBusSends_PropertyAddress, intPtr, "bEnableBusSends");
		EnableBusSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableBusSends");
		EnableBusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableBusSends", Classes.FBoolProperty);
		AttenuationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationSettings");
		AttenuationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationSettings", Classes.FObjectProperty);
		AttenuationOverrides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationOverrides");
		AttenuationOverrides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationOverrides", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConcurrencySet_PropertyAddress, intPtr, "ConcurrencySet");
		ConcurrencySet_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConcurrencySet");
		ConcurrencySet_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConcurrencySet", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref SoundSubmixSends_PropertyAddress, intPtr, "SoundSubmixSends");
		SoundSubmixSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundSubmixSends");
		SoundSubmixSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundSubmixSends", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BusSends_PropertyAddress, intPtr, "BusSends");
		BusSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BusSends");
		BusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BusSends", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PreEffectBusSends_PropertyAddress, intPtr, "PreEffectBusSends");
		PreEffectBusSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreEffectBusSends");
		PreEffectBusSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreEffectBusSends", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUISound_PropertyAddress, intPtr, "bIsUISound");
		IsUISound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsUISound");
		IsUISound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsUISound", Classes.FBoolProperty);
		EnvelopeFollowerAttackTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerAttackTime");
		EnvelopeFollowerAttackTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerAttackTime", Classes.FIntProperty);
		EnvelopeFollowerReleaseTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvelopeFollowerReleaseTime");
		EnvelopeFollowerReleaseTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvelopeFollowerReleaseTime", Classes.FIntProperty);
		OnAudioEnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnAudioEnvelopeValue");
		OnAudioEnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnAudioEnvelopeValue", Classes.FMulticastDelegateProperty);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:Stop", Stop_IsValid);
		Start_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Start");
		Start_ParamsSize = NativeReflection.GetFunctionParamsSize(Start_FunctionAddress);
		Start_IsValid = Start_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:Start", Start_IsValid);
		SetVolumeMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumeMultiplier");
		SetVolumeMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumeMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumeMultiplier_VolumeMultiplier_PropertyAddress, SetVolumeMultiplier_FunctionAddress, "VolumeMultiplier");
		SetVolumeMultiplier_VolumeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumeMultiplier_FunctionAddress, "VolumeMultiplier");
		SetVolumeMultiplier_VolumeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumeMultiplier_FunctionAddress, "VolumeMultiplier", Classes.FFloatProperty);
		SetVolumeMultiplier_IsValid = SetVolumeMultiplier_FunctionAddress != IntPtr.Zero && SetVolumeMultiplier_VolumeMultiplier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:SetVolumeMultiplier", SetVolumeMultiplier_IsValid);
		SetSubmixSend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSubmixSend");
		SetSubmixSend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSubmixSend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixSend_Submix_PropertyAddress, SetSubmixSend_FunctionAddress, "Submix");
		SetSubmixSend_Submix_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixSend_FunctionAddress, "Submix");
		SetSubmixSend_Submix_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixSend_FunctionAddress, "Submix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSubmixSend_SendLevel_PropertyAddress, SetSubmixSend_FunctionAddress, "SendLevel");
		SetSubmixSend_SendLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetSubmixSend_FunctionAddress, "SendLevel");
		SetSubmixSend_SendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSubmixSend_FunctionAddress, "SendLevel", Classes.FFloatProperty);
		SetSubmixSend_IsValid = SetSubmixSend_FunctionAddress != IntPtr.Zero && SetSubmixSend_Submix_IsValid && SetSubmixSend_SendLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:SetSubmixSend", SetSubmixSend_IsValid);
		SetOutputToBusOnly_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOutputToBusOnly");
		SetOutputToBusOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOutputToBusOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOutputToBusOnly_bInOutputToBusOnly_PropertyAddress, SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly");
		SetOutputToBusOnly_bInOutputToBusOnly_Offset = NativeReflectionCached.GetPropertyOffset(SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly");
		SetOutputToBusOnly_bInOutputToBusOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOutputToBusOnly_FunctionAddress, "bInOutputToBusOnly", Classes.FBoolProperty);
		SetOutputToBusOnly_IsValid = SetOutputToBusOnly_FunctionAddress != IntPtr.Zero && SetOutputToBusOnly_bInOutputToBusOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:SetOutputToBusOnly", SetOutputToBusOnly_IsValid);
		SetLowPassFilterFrequency_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowPassFilterFrequency");
		SetLowPassFilterFrequency_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowPassFilterFrequency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowPassFilterFrequency_InLowPassFilterFrequency_PropertyAddress, SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency");
		SetLowPassFilterFrequency_InLowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency");
		SetLowPassFilterFrequency_InLowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowPassFilterFrequency_FunctionAddress, "InLowPassFilterFrequency", Classes.FFloatProperty);
		SetLowPassFilterFrequency_IsValid = SetLowPassFilterFrequency_FunctionAddress != IntPtr.Zero && SetLowPassFilterFrequency_InLowPassFilterFrequency_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:SetLowPassFilterFrequency", SetLowPassFilterFrequency_IsValid);
		SetLowPassFilterEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLowPassFilterEnabled");
		SetLowPassFilterEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLowPassFilterEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLowPassFilterEnabled_InLowPassFilterEnabled_PropertyAddress, SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled");
		SetLowPassFilterEnabled_InLowPassFilterEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled");
		SetLowPassFilterEnabled_InLowPassFilterEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLowPassFilterEnabled_FunctionAddress, "InLowPassFilterEnabled", Classes.FBoolProperty);
		SetLowPassFilterEnabled_IsValid = SetLowPassFilterEnabled_FunctionAddress != IntPtr.Zero && SetLowPassFilterEnabled_InLowPassFilterEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:SetLowPassFilterEnabled", SetLowPassFilterEnabled_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.SynthComponent:IsPlaying", IsPlaying_IsValid);
	}
}
