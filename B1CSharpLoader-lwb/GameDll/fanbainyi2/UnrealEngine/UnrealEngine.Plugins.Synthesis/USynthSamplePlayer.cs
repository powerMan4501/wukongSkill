using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SynthSamplePlayer", "Synthesis", UnrealModuleType.EnginePlugin)]
public class USynthSamplePlayer : USynthComponent
{
	private static bool SoundWave_IsValid;

	private static int SoundWave_Offset;

	private static bool OnSampleLoaded_IsValid;

	private static int OnSampleLoaded_Offset;

	private FOnSampleLoaded OnSampleLoaded_DelegateCached;

	private static bool OnSamplePlaybackProgress_IsValid;

	private static int OnSamplePlaybackProgress_Offset;

	private FOnSamplePlaybackProgress OnSamplePlaybackProgress_DelegateCached;

	private static bool SetSoundWave_IsValid;

	private static IntPtr SetSoundWave_FunctionAddress;

	private static int SetSoundWave_ParamsSize;

	private static bool SetSoundWave_InSoundWave_IsValid;

	private static FFieldAddress SetSoundWave_InSoundWave_PropertyAddress;

	private static int SetSoundWave_InSoundWave_Offset;

	private static bool SetScrubTimeWidth_IsValid;

	private static IntPtr SetScrubTimeWidth_FunctionAddress;

	private static int SetScrubTimeWidth_ParamsSize;

	private static bool SetScrubTimeWidth_InScrubTimeWidthSec_IsValid;

	private static FFieldAddress SetScrubTimeWidth_InScrubTimeWidthSec_PropertyAddress;

	private static int SetScrubTimeWidth_InScrubTimeWidthSec_Offset;

	private static bool SetScrubMode_IsValid;

	private static IntPtr SetScrubMode_FunctionAddress;

	private static int SetScrubMode_ParamsSize;

	private static bool SetScrubMode_bScrubMode_IsValid;

	private static FFieldAddress SetScrubMode_bScrubMode_PropertyAddress;

	private static int SetScrubMode_bScrubMode_Offset;

	private static bool SetPitch_IsValid;

	private static IntPtr SetPitch_FunctionAddress;

	private static int SetPitch_ParamsSize;

	private static bool SetPitch_InPitch_IsValid;

	private static FFieldAddress SetPitch_InPitch_PropertyAddress;

	private static int SetPitch_InPitch_Offset;

	private static bool SetPitch_TimeSec_IsValid;

	private static FFieldAddress SetPitch_TimeSec_PropertyAddress;

	private static int SetPitch_TimeSec_Offset;

	private static bool SeekToTime_IsValid;

	private static IntPtr SeekToTime_FunctionAddress;

	private static int SeekToTime_ParamsSize;

	private static bool SeekToTime_TimeSec_IsValid;

	private static FFieldAddress SeekToTime_TimeSec_PropertyAddress;

	private static int SeekToTime_TimeSec_Offset;

	private static bool SeekToTime_SeekType_IsValid;

	private static FFieldAddress SeekToTime_SeekType_PropertyAddress;

	private static int SeekToTime_SeekType_Offset;

	private static bool SeekToTime_bWrap_IsValid;

	private static FFieldAddress SeekToTime_bWrap_PropertyAddress;

	private static int SeekToTime_bWrap_Offset;

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

	private static bool GetCurrentPlaybackProgressTime_IsValid;

	private static IntPtr GetCurrentPlaybackProgressTime_FunctionAddress;

	private static int GetCurrentPlaybackProgressTime_ParamsSize;

	private static bool GetCurrentPlaybackProgressTime_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPlaybackProgressTime_ReturnValue_PropertyAddress;

	private static int GetCurrentPlaybackProgressTime_ReturnValue_Offset;

	private static bool GetCurrentPlaybackProgressPercent_IsValid;

	private static IntPtr GetCurrentPlaybackProgressPercent_FunctionAddress;

	private static int GetCurrentPlaybackProgressPercent_ParamsSize;

	private static bool GetCurrentPlaybackProgressPercent_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPlaybackProgressPercent_ReturnValue_PropertyAddress;

	private static int GetCurrentPlaybackProgressPercent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SoundWave")]
	public USoundWave SoundWave
	{
		get
		{
			CheckDestroyed();
			if (!SoundWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthSamplePlayer:SoundWave");
				return null;
			}
			return UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(base.Address, SoundWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SoundWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthSamplePlayer:SoundWave");
			}
			else
			{
				UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(base.Address, SoundWave_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:OnSampleLoaded")]
	public FOnSampleLoaded OnSampleLoaded
	{
		get
		{
			CheckDestroyed();
			if (!OnSampleLoaded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthSamplePlayer:OnSampleLoaded");
				return new FOnSampleLoaded();
			}
			if (OnSampleLoaded_DelegateCached == null)
			{
				OnSampleLoaded_DelegateCached = new FOnSampleLoaded();
				OnSampleLoaded_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSampleLoaded_Offset));
			}
			return OnSampleLoaded_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:OnSamplePlaybackProgress")]
	public FOnSamplePlaybackProgress OnSamplePlaybackProgress
	{
		get
		{
			CheckDestroyed();
			if (!OnSamplePlaybackProgress_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.SynthSamplePlayer:OnSamplePlaybackProgress");
				return new FOnSamplePlaybackProgress();
			}
			if (OnSamplePlaybackProgress_DelegateCached == null)
			{
				OnSamplePlaybackProgress_DelegateCached = new FOnSamplePlaybackProgress();
				OnSamplePlaybackProgress_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSamplePlaybackProgress_Offset));
			}
			return OnSamplePlaybackProgress_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SetSoundWave")]
	public unsafe void SetSoundWave(USoundWave InSoundWave)
	{
		CheckDestroyed();
		if (!SetSoundWave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:SetSoundWave");
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
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SetScrubTimeWidth")]
	public unsafe void SetScrubTimeWidth(float InScrubTimeWidthSec)
	{
		CheckDestroyed();
		if (!SetScrubTimeWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:SetScrubTimeWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetScrubTimeWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetScrubTimeWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetScrubTimeWidth_InScrubTimeWidthSec_Offset), 0, SetScrubTimeWidth_InScrubTimeWidthSec_PropertyAddress.Address, InScrubTimeWidthSec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetScrubTimeWidth_FunctionAddress, intPtr, SetScrubTimeWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SetScrubMode")]
	public unsafe void SetScrubMode(bool bScrubMode)
	{
		CheckDestroyed();
		if (!SetScrubMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:SetScrubMode");
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
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SetPitch")]
	public unsafe void SetPitch(float InPitch, float TimeSec)
	{
		CheckDestroyed();
		if (!SetPitch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:SetPitch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPitch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPitch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPitch_InPitch_Offset), 0, SetPitch_InPitch_PropertyAddress.Address, InPitch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPitch_TimeSec_Offset), 0, SetPitch_TimeSec_PropertyAddress.Address, TimeSec);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPitch_FunctionAddress, intPtr, SetPitch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:SeekToTime")]
	public unsafe void SeekToTime(float TimeSec, ESamplePlayerSeekType SeekType, bool bWrap = true)
	{
		CheckDestroyed();
		if (!SeekToTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:SeekToTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SeekToTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SeekToTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SeekToTime_TimeSec_Offset), 0, SeekToTime_TimeSec_PropertyAddress.Address, TimeSec);
		EnumMarshaler<ESamplePlayerSeekType>.ToNative(IntPtr.Add(intPtr, SeekToTime_SeekType_Offset), 0, SeekToTime_SeekType_PropertyAddress.Address, SeekType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SeekToTime_bWrap_Offset), 0, SeekToTime_bWrap_PropertyAddress.Address, bWrap);
		NativeReflection.InvokeFunctionOptimized(base.Address, SeekToTime_FunctionAddress, intPtr, SeekToTime_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:IsLoaded")]
	public unsafe bool IsLoaded()
	{
		CheckDestroyed();
		if (!IsLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:IsLoaded");
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
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:GetSampleDuration")]
	public unsafe float GetSampleDuration()
	{
		CheckDestroyed();
		if (!GetSampleDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:GetSampleDuration");
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
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressTime")]
	public unsafe float GetCurrentPlaybackProgressTime()
	{
		CheckDestroyed();
		if (!GetCurrentPlaybackProgressTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPlaybackProgressTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPlaybackProgressTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentPlaybackProgressTime_FunctionAddress, intPtr, GetCurrentPlaybackProgressTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentPlaybackProgressTime_ReturnValue_Offset), 0, GetCurrentPlaybackProgressTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressPercent")]
	public unsafe float GetCurrentPlaybackProgressPercent()
	{
		CheckDestroyed();
		if (!GetCurrentPlaybackProgressPercent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressPercent");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPlaybackProgressPercent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPlaybackProgressPercent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentPlaybackProgressPercent_FunctionAddress, intPtr, GetCurrentPlaybackProgressPercent_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurrentPlaybackProgressPercent_ReturnValue_Offset), 0, GetCurrentPlaybackProgressPercent_ReturnValue_PropertyAddress.Address);
	}

	static USynthSamplePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USynthSamplePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USynthSamplePlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Synthesis.SynthSamplePlayer");
		SoundWave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundWave");
		SoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundWave", Classes.FObjectProperty);
		OnSampleLoaded_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSampleLoaded");
		OnSampleLoaded_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSampleLoaded", Classes.FMulticastDelegateProperty);
		OnSamplePlaybackProgress_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnSamplePlaybackProgress");
		OnSamplePlaybackProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnSamplePlaybackProgress", Classes.FMulticastDelegateProperty);
		SetSoundWave_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSoundWave");
		SetSoundWave_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSoundWave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSoundWave_InSoundWave_PropertyAddress, SetSoundWave_FunctionAddress, "InSoundWave");
		SetSoundWave_InSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(SetSoundWave_FunctionAddress, "InSoundWave");
		SetSoundWave_InSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSoundWave_FunctionAddress, "InSoundWave", Classes.FObjectProperty);
		SetSoundWave_IsValid = SetSoundWave_FunctionAddress != IntPtr.Zero && SetSoundWave_InSoundWave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:SetSoundWave", SetSoundWave_IsValid);
		SetScrubTimeWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrubTimeWidth");
		SetScrubTimeWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrubTimeWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrubTimeWidth_InScrubTimeWidthSec_PropertyAddress, SetScrubTimeWidth_FunctionAddress, "InScrubTimeWidthSec");
		SetScrubTimeWidth_InScrubTimeWidthSec_Offset = NativeReflectionCached.GetPropertyOffset(SetScrubTimeWidth_FunctionAddress, "InScrubTimeWidthSec");
		SetScrubTimeWidth_InScrubTimeWidthSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrubTimeWidth_FunctionAddress, "InScrubTimeWidthSec", Classes.FFloatProperty);
		SetScrubTimeWidth_IsValid = SetScrubTimeWidth_FunctionAddress != IntPtr.Zero && SetScrubTimeWidth_InScrubTimeWidthSec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:SetScrubTimeWidth", SetScrubTimeWidth_IsValid);
		SetScrubMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetScrubMode");
		SetScrubMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetScrubMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetScrubMode_bScrubMode_PropertyAddress, SetScrubMode_FunctionAddress, "bScrubMode");
		SetScrubMode_bScrubMode_Offset = NativeReflectionCached.GetPropertyOffset(SetScrubMode_FunctionAddress, "bScrubMode");
		SetScrubMode_bScrubMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetScrubMode_FunctionAddress, "bScrubMode", Classes.FBoolProperty);
		SetScrubMode_IsValid = SetScrubMode_FunctionAddress != IntPtr.Zero && SetScrubMode_bScrubMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:SetScrubMode", SetScrubMode_IsValid);
		SetPitch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPitch");
		SetPitch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPitch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPitch_InPitch_PropertyAddress, SetPitch_FunctionAddress, "InPitch");
		SetPitch_InPitch_Offset = NativeReflectionCached.GetPropertyOffset(SetPitch_FunctionAddress, "InPitch");
		SetPitch_InPitch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPitch_FunctionAddress, "InPitch", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPitch_TimeSec_PropertyAddress, SetPitch_FunctionAddress, "TimeSec");
		SetPitch_TimeSec_Offset = NativeReflectionCached.GetPropertyOffset(SetPitch_FunctionAddress, "TimeSec");
		SetPitch_TimeSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPitch_FunctionAddress, "TimeSec", Classes.FFloatProperty);
		SetPitch_IsValid = SetPitch_FunctionAddress != IntPtr.Zero && SetPitch_InPitch_IsValid && SetPitch_TimeSec_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:SetPitch", SetPitch_IsValid);
		SeekToTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SeekToTime");
		SeekToTime_ParamsSize = NativeReflection.GetFunctionParamsSize(SeekToTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SeekToTime_TimeSec_PropertyAddress, SeekToTime_FunctionAddress, "TimeSec");
		SeekToTime_TimeSec_Offset = NativeReflectionCached.GetPropertyOffset(SeekToTime_FunctionAddress, "TimeSec");
		SeekToTime_TimeSec_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekToTime_FunctionAddress, "TimeSec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekToTime_SeekType_PropertyAddress, SeekToTime_FunctionAddress, "SeekType");
		SeekToTime_SeekType_Offset = NativeReflectionCached.GetPropertyOffset(SeekToTime_FunctionAddress, "SeekType");
		SeekToTime_SeekType_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekToTime_FunctionAddress, "SeekType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SeekToTime_bWrap_PropertyAddress, SeekToTime_FunctionAddress, "bWrap");
		SeekToTime_bWrap_Offset = NativeReflectionCached.GetPropertyOffset(SeekToTime_FunctionAddress, "bWrap");
		SeekToTime_bWrap_IsValid = NativeReflectionCached.ValidatePropertyClass(SeekToTime_FunctionAddress, "bWrap", Classes.FBoolProperty);
		SeekToTime_IsValid = SeekToTime_FunctionAddress != IntPtr.Zero && SeekToTime_TimeSec_IsValid && SeekToTime_SeekType_IsValid && SeekToTime_bWrap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:SeekToTime", SeekToTime_IsValid);
		IsLoaded_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLoaded");
		IsLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoaded_ReturnValue_PropertyAddress, IsLoaded_FunctionAddress, "ReturnValue");
		IsLoaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoaded_FunctionAddress, "ReturnValue");
		IsLoaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoaded_IsValid = IsLoaded_FunctionAddress != IntPtr.Zero && IsLoaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:IsLoaded", IsLoaded_IsValid);
		GetSampleDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSampleDuration");
		GetSampleDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSampleDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSampleDuration_ReturnValue_PropertyAddress, GetSampleDuration_FunctionAddress, "ReturnValue");
		GetSampleDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSampleDuration_FunctionAddress, "ReturnValue");
		GetSampleDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSampleDuration_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetSampleDuration_IsValid = GetSampleDuration_FunctionAddress != IntPtr.Zero && GetSampleDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:GetSampleDuration", GetSampleDuration_IsValid);
		GetCurrentPlaybackProgressTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentPlaybackProgressTime");
		GetCurrentPlaybackProgressTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPlaybackProgressTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPlaybackProgressTime_ReturnValue_PropertyAddress, GetCurrentPlaybackProgressTime_FunctionAddress, "ReturnValue");
		GetCurrentPlaybackProgressTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPlaybackProgressTime_FunctionAddress, "ReturnValue");
		GetCurrentPlaybackProgressTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPlaybackProgressTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentPlaybackProgressTime_IsValid = GetCurrentPlaybackProgressTime_FunctionAddress != IntPtr.Zero && GetCurrentPlaybackProgressTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressTime", GetCurrentPlaybackProgressTime_IsValid);
		GetCurrentPlaybackProgressPercent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentPlaybackProgressPercent");
		GetCurrentPlaybackProgressPercent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPlaybackProgressPercent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPlaybackProgressPercent_ReturnValue_PropertyAddress, GetCurrentPlaybackProgressPercent_FunctionAddress, "ReturnValue");
		GetCurrentPlaybackProgressPercent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPlaybackProgressPercent_FunctionAddress, "ReturnValue");
		GetCurrentPlaybackProgressPercent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPlaybackProgressPercent_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCurrentPlaybackProgressPercent_IsValid = GetCurrentPlaybackProgressPercent_FunctionAddress != IntPtr.Zero && GetCurrentPlaybackProgressPercent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.SynthSamplePlayer:GetCurrentPlaybackProgressPercent", GetCurrentPlaybackProgressPercent_IsValid);
	}
}
