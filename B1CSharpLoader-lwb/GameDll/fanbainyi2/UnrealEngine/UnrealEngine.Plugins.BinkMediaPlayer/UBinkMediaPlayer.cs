using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.BinkMediaPlayer;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer", "BinkMediaPlayer", UnrealModuleType.EnginePlugin)]
public class UBinkMediaPlayer : UObject
{
	private static bool OnMediaClosed_IsValid;

	private static int OnMediaClosed_Offset;

	private FOnBinkMediaPlayerMediaClosed OnMediaClosed_DelegateCached;

	private static bool OnMediaOpened_IsValid;

	private static int OnMediaOpened_Offset;

	private FOnBinkMediaPlayerMediaOpened OnMediaOpened_DelegateCached;

	private static bool OnMediaReachedEnd_IsValid;

	private static int OnMediaReachedEnd_Offset;

	private FOnBinkMediaPlayerMediaReachedEnd OnMediaReachedEnd_DelegateCached;

	private static bool OnPlaybackSuspended_IsValid;

	private static int OnPlaybackSuspended_Offset;

	private FOnBinkMediaPlayerMediaEvent OnPlaybackSuspended_DelegateCached;

	private static bool BinkBufferMode_IsValid;

	private static FFieldAddress BinkBufferMode_PropertyAddress;

	private static int BinkBufferMode_Offset;

	private static bool BinkSoundTrack_IsValid;

	private static FFieldAddress BinkSoundTrack_PropertyAddress;

	private static int BinkSoundTrack_Offset;

	private static bool BinkSoundTrackStart_IsValid;

	private static int BinkSoundTrackStart_Offset;

	private static bool BinkDrawStyle_IsValid;

	private static FFieldAddress BinkDrawStyle_PropertyAddress;

	private static int BinkDrawStyle_Offset;

	private static bool BinkLayerDepth_IsValid;

	private static int BinkLayerDepth_Offset;

	private static bool SupportsSeeking_IsValid;

	private static IntPtr SupportsSeeking_FunctionAddress;

	private static int SupportsSeeking_ParamsSize;

	private static bool SupportsSeeking_ReturnValue_IsValid;

	private static FFieldAddress SupportsSeeking_ReturnValue_PropertyAddress;

	private static int SupportsSeeking_ReturnValue_Offset;

	private static bool SupportsScrubbing_IsValid;

	private static IntPtr SupportsScrubbing_FunctionAddress;

	private static int SupportsScrubbing_ParamsSize;

	private static bool SupportsScrubbing_ReturnValue_IsValid;

	private static FFieldAddress SupportsScrubbing_ReturnValue_PropertyAddress;

	private static int SupportsScrubbing_ReturnValue_Offset;

	private static bool SupportsRate_IsValid;

	private static IntPtr SupportsRate_FunctionAddress;

	private static int SupportsRate_ParamsSize;

	private static bool SupportsRate_Rate_IsValid;

	private static FFieldAddress SupportsRate_Rate_PropertyAddress;

	private static int SupportsRate_Rate_Offset;

	private static bool SupportsRate_Unthinned_IsValid;

	private static FFieldAddress SupportsRate_Unthinned_PropertyAddress;

	private static int SupportsRate_Unthinned_Offset;

	private static bool SupportsRate_ReturnValue_IsValid;

	private static FFieldAddress SupportsRate_ReturnValue_PropertyAddress;

	private static int SupportsRate_ReturnValue_Offset;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetVolume_IsValid;

	private static IntPtr SetVolume_FunctionAddress;

	private static int SetVolume_ParamsSize;

	private static bool SetVolume_Rate_IsValid;

	private static FFieldAddress SetVolume_Rate_PropertyAddress;

	private static int SetVolume_Rate_Offset;

	private static bool SetRate_IsValid;

	private static IntPtr SetRate_FunctionAddress;

	private static int SetRate_ParamsSize;

	private static bool SetRate_Rate_IsValid;

	private static FFieldAddress SetRate_Rate_PropertyAddress;

	private static int SetRate_Rate_Offset;

	private static bool SetRate_ReturnValue_IsValid;

	private static FFieldAddress SetRate_ReturnValue_PropertyAddress;

	private static int SetRate_ReturnValue_Offset;

	private static bool SetLooping_IsValid;

	private static IntPtr SetLooping_FunctionAddress;

	private static int SetLooping_ParamsSize;

	private static bool SetLooping_InLooping_IsValid;

	private static FFieldAddress SetLooping_InLooping_PropertyAddress;

	private static int SetLooping_InLooping_Offset;

	private static bool SetLooping_ReturnValue_IsValid;

	private static FFieldAddress SetLooping_ReturnValue_PropertyAddress;

	private static int SetLooping_ReturnValue_Offset;

	private static bool Seek_IsValid;

	private static IntPtr Seek_FunctionAddress;

	private static int Seek_ParamsSize;

	private static bool Seek_InTime_IsValid;

	private static FFieldAddress Seek_InTime_PropertyAddress;

	private static int Seek_InTime_Offset;

	private static bool Seek_ReturnValue_IsValid;

	private static FFieldAddress Seek_ReturnValue_PropertyAddress;

	private static int Seek_ReturnValue_Offset;

	private static bool Rewind_IsValid;

	private static IntPtr Rewind_FunctionAddress;

	private static int Rewind_ParamsSize;

	private static bool Rewind_ReturnValue_IsValid;

	private static FFieldAddress Rewind_ReturnValue_PropertyAddress;

	private static int Rewind_ReturnValue_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Play_ReturnValue_IsValid;

	private static FFieldAddress Play_ReturnValue_PropertyAddress;

	private static int Play_ReturnValue_Offset;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool Pause_ReturnValue_IsValid;

	private static FFieldAddress Pause_ReturnValue_PropertyAddress;

	private static int Pause_ReturnValue_Offset;

	private static bool OpenUrl_IsValid;

	private static IntPtr OpenUrl_FunctionAddress;

	private static int OpenUrl_ParamsSize;

	private static bool OpenUrl_NewUrl_IsValid;

	private static FFieldAddress OpenUrl_NewUrl_PropertyAddress;

	private static int OpenUrl_NewUrl_Offset;

	private static bool OpenUrl_ReturnValue_IsValid;

	private static FFieldAddress OpenUrl_ReturnValue_PropertyAddress;

	private static int OpenUrl_ReturnValue_Offset;

	private static bool IsStopped_IsValid;

	private static IntPtr IsStopped_FunctionAddress;

	private static int IsStopped_ParamsSize;

	private static bool IsStopped_ReturnValue_IsValid;

	private static FFieldAddress IsStopped_ReturnValue_PropertyAddress;

	private static int IsStopped_ReturnValue_Offset;

	private static bool IsPlaying_IsValid;

	private static IntPtr IsPlaying_FunctionAddress;

	private static int IsPlaying_ParamsSize;

	private static bool IsPlaying_ReturnValue_IsValid;

	private static FFieldAddress IsPlaying_ReturnValue_PropertyAddress;

	private static int IsPlaying_ReturnValue_Offset;

	private static bool IsPaused_IsValid;

	private static IntPtr IsPaused_FunctionAddress;

	private static int IsPaused_ParamsSize;

	private static bool IsPaused_ReturnValue_IsValid;

	private static FFieldAddress IsPaused_ReturnValue_PropertyAddress;

	private static int IsPaused_ReturnValue_Offset;

	private static bool IsLooping_IsValid;

	private static IntPtr IsLooping_FunctionAddress;

	private static int IsLooping_ParamsSize;

	private static bool IsLooping_ReturnValue_IsValid;

	private static FFieldAddress IsLooping_ReturnValue_PropertyAddress;

	private static int IsLooping_ReturnValue_Offset;

	private static bool IsInitialized_IsValid;

	private static IntPtr IsInitialized_FunctionAddress;

	private static int IsInitialized_ParamsSize;

	private static bool IsInitialized_ReturnValue_IsValid;

	private static FFieldAddress IsInitialized_ReturnValue_PropertyAddress;

	private static int IsInitialized_ReturnValue_Offset;

	private static bool GetUrl_IsValid;

	private static IntPtr GetUrl_FunctionAddress;

	private static int GetUrl_ParamsSize;

	private static bool GetUrl_ReturnValue_IsValid;

	private static FFieldAddress GetUrl_ReturnValue_PropertyAddress;

	private static int GetUrl_ReturnValue_Offset;

	private static bool GetTime_IsValid;

	private static IntPtr GetTime_FunctionAddress;

	private static int GetTime_ParamsSize;

	private static bool GetTime_ReturnValue_IsValid;

	private static FFieldAddress GetTime_ReturnValue_PropertyAddress;

	private static int GetTime_ReturnValue_Offset;

	private static bool GetRate_IsValid;

	private static IntPtr GetRate_FunctionAddress;

	private static int GetRate_ParamsSize;

	private static bool GetRate_ReturnValue_IsValid;

	private static FFieldAddress GetRate_ReturnValue_PropertyAddress;

	private static int GetRate_ReturnValue_Offset;

	private static bool GetDuration_IsValid;

	private static IntPtr GetDuration_FunctionAddress;

	private static int GetDuration_ParamsSize;

	private static bool GetDuration_ReturnValue_IsValid;

	private static FFieldAddress GetDuration_ReturnValue_PropertyAddress;

	private static int GetDuration_ReturnValue_Offset;

	private static bool Draw_IsValid;

	private static IntPtr Draw_FunctionAddress;

	private static int Draw_ParamsSize;

	private static bool Draw_texture_IsValid;

	private static FFieldAddress Draw_texture_PropertyAddress;

	private static int Draw_texture_Offset;

	private static bool Draw_tonemap_IsValid;

	private static FFieldAddress Draw_tonemap_PropertyAddress;

	private static int Draw_tonemap_Offset;

	private static bool Draw_out_nits_IsValid;

	private static FFieldAddress Draw_out_nits_PropertyAddress;

	private static int Draw_out_nits_Offset;

	private static bool Draw_alpha_IsValid;

	private static FFieldAddress Draw_alpha_PropertyAddress;

	private static int Draw_alpha_Offset;

	private static bool Draw_srgb_decode_IsValid;

	private static FFieldAddress Draw_srgb_decode_PropertyAddress;

	private static int Draw_srgb_decode_Offset;

	private static bool Draw_hdr_IsValid;

	private static FFieldAddress Draw_hdr_PropertyAddress;

	private static int Draw_hdr_Offset;

	private static bool CloseUrl_IsValid;

	private static IntPtr CloseUrl_FunctionAddress;

	private static int CloseUrl_ParamsSize;

	private static bool CanPlay_IsValid;

	private static IntPtr CanPlay_FunctionAddress;

	private static int CanPlay_ParamsSize;

	private static bool CanPlay_ReturnValue_IsValid;

	private static FFieldAddress CanPlay_ReturnValue_PropertyAddress;

	private static int CanPlay_ReturnValue_Offset;

	private static bool CanPause_IsValid;

	private static IntPtr CanPause_FunctionAddress;

	private static int CanPause_ParamsSize;

	private static bool CanPause_ReturnValue_IsValid;

	private static FFieldAddress CanPause_ReturnValue_PropertyAddress;

	private static int CanPause_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaClosed")]
	public FOnBinkMediaPlayerMediaClosed OnMediaClosed
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaClosed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaClosed");
				return new FOnBinkMediaPlayerMediaClosed();
			}
			if (OnMediaClosed_DelegateCached == null)
			{
				OnMediaClosed_DelegateCached = new FOnBinkMediaPlayerMediaClosed();
				OnMediaClosed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaClosed_Offset));
			}
			return OnMediaClosed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaOpened")]
	public FOnBinkMediaPlayerMediaOpened OnMediaOpened
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaOpened_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaOpened");
				return new FOnBinkMediaPlayerMediaOpened();
			}
			if (OnMediaOpened_DelegateCached == null)
			{
				OnMediaOpened_DelegateCached = new FOnBinkMediaPlayerMediaOpened();
				OnMediaOpened_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaOpened_Offset));
			}
			return OnMediaOpened_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaReachedEnd")]
	public FOnBinkMediaPlayerMediaReachedEnd OnMediaReachedEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnMediaReachedEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:OnMediaReachedEnd");
				return new FOnBinkMediaPlayerMediaReachedEnd();
			}
			if (OnMediaReachedEnd_DelegateCached == null)
			{
				OnMediaReachedEnd_DelegateCached = new FOnBinkMediaPlayerMediaReachedEnd();
				OnMediaReachedEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMediaReachedEnd_Offset));
			}
			return OnMediaReachedEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:OnPlaybackSuspended")]
	public FOnBinkMediaPlayerMediaEvent OnPlaybackSuspended
	{
		get
		{
			CheckDestroyed();
			if (!OnPlaybackSuspended_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:OnPlaybackSuspended");
				return new FOnBinkMediaPlayerMediaEvent();
			}
			if (OnPlaybackSuspended_DelegateCached == null)
			{
				OnPlaybackSuspended_DelegateCached = new FOnBinkMediaPlayerMediaEvent();
				OnPlaybackSuspended_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlaybackSuspended_Offset));
			}
			return OnPlaybackSuspended_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkBufferMode")]
	public EBinkMediaPlayerBinkBufferModes BinkBufferMode
	{
		get
		{
			CheckDestroyed();
			if (!BinkBufferMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkBufferMode");
				return EBinkMediaPlayerBinkBufferModes.BMASM_Bink_Stream;
			}
			return EnumMarshaler<EBinkMediaPlayerBinkBufferModes>.FromNative(IntPtr.Add(base.Address, BinkBufferMode_Offset), 0, BinkBufferMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BinkBufferMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkBufferMode");
			}
			else
			{
				EnumMarshaler<EBinkMediaPlayerBinkBufferModes>.ToNative(IntPtr.Add(base.Address, BinkBufferMode_Offset), 0, BinkBufferMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrack")]
	public EBinkMediaPlayerBinkSoundTrack BinkSoundTrack
	{
		get
		{
			CheckDestroyed();
			if (!BinkSoundTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrack");
				return EBinkMediaPlayerBinkSoundTrack.BMASM_Bink_Sound_None;
			}
			return EnumMarshaler<EBinkMediaPlayerBinkSoundTrack>.FromNative(IntPtr.Add(base.Address, BinkSoundTrack_Offset), 0, BinkSoundTrack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BinkSoundTrack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrack");
			}
			else
			{
				EnumMarshaler<EBinkMediaPlayerBinkSoundTrack>.ToNative(IntPtr.Add(base.Address, BinkSoundTrack_Offset), 0, BinkSoundTrack_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrackStart")]
	public int BinkSoundTrackStart
	{
		get
		{
			CheckDestroyed();
			if (!BinkSoundTrackStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrackStart");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BinkSoundTrackStart_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BinkSoundTrackStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkSoundTrackStart");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BinkSoundTrackStart_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkDrawStyle")]
	public EBinkMediaPlayerBinkDrawStyle BinkDrawStyle
	{
		get
		{
			CheckDestroyed();
			if (!BinkDrawStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkDrawStyle");
				return EBinkMediaPlayerBinkDrawStyle.BMASM_Bink_DS_RenderToTexture;
			}
			return EnumMarshaler<EBinkMediaPlayerBinkDrawStyle>.FromNative(IntPtr.Add(base.Address, BinkDrawStyle_Offset), 0, BinkDrawStyle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BinkDrawStyle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkDrawStyle");
			}
			else
			{
				EnumMarshaler<EBinkMediaPlayerBinkDrawStyle>.ToNative(IntPtr.Add(base.Address, BinkDrawStyle_Offset), 0, BinkDrawStyle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkLayerDepth")]
	public int BinkLayerDepth
	{
		get
		{
			CheckDestroyed();
			if (!BinkLayerDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkLayerDepth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BinkLayerDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BinkLayerDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:BinkLayerDepth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BinkLayerDepth_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsSeeking")]
	public unsafe bool SupportsSeeking()
	{
		CheckDestroyed();
		if (!SupportsSeeking_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsSeeking");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsSeeking_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsSeeking_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsSeeking_FunctionAddress, intPtr, SupportsSeeking_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsSeeking_ReturnValue_Offset), 0, SupportsSeeking_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsScrubbing")]
	public unsafe bool SupportsScrubbing()
	{
		CheckDestroyed();
		if (!SupportsScrubbing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsScrubbing");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsScrubbing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsScrubbing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsScrubbing_FunctionAddress, intPtr, SupportsScrubbing_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsScrubbing_ReturnValue_Offset), 0, SupportsScrubbing_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsRate")]
	public unsafe bool SupportsRate(float Rate, bool Unthinned)
	{
		CheckDestroyed();
		if (!SupportsRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SupportsRate_Rate_Offset), 0, SupportsRate_Rate_PropertyAddress.Address, Rate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SupportsRate_Unthinned_Offset), 0, SupportsRate_Unthinned_PropertyAddress.Address, Unthinned);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsRate_FunctionAddress, intPtr, SupportsRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsRate_ReturnValue_Offset), 0, SupportsRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SetVolume")]
	public unsafe void SetVolume(float Rate)
	{
		CheckDestroyed();
		if (!SetVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SetVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolume_Rate_Offset), 0, SetVolume_Rate_PropertyAddress.Address, Rate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolume_FunctionAddress, intPtr, SetVolume_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SetRate")]
	public unsafe bool SetRate(float Rate)
	{
		CheckDestroyed();
		if (!SetRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SetRate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRate_Rate_Offset), 0, SetRate_Rate_PropertyAddress.Address, Rate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRate_FunctionAddress, intPtr, SetRate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetRate_ReturnValue_Offset), 0, SetRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:SetLooping")]
	public unsafe bool SetLooping(bool InLooping)
	{
		CheckDestroyed();
		if (!SetLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:SetLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLooping_InLooping_Offset), 0, SetLooping_InLooping_PropertyAddress.Address, InLooping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLooping_FunctionAddress, intPtr, SetLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetLooping_ReturnValue_Offset), 0, SetLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Seek")]
	public unsafe bool Seek(FTimespan InTime)
	{
		CheckDestroyed();
		if (!Seek_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Seek");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Seek_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Seek_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FTimespan.ToNative(IntPtr.Add(intPtr, Seek_InTime_Offset), 0, Seek_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, Seek_FunctionAddress, intPtr, Seek_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Seek_ReturnValue_Offset), 0, Seek_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Rewind")]
	public unsafe bool Rewind()
	{
		CheckDestroyed();
		if (!Rewind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Rewind");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Rewind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Rewind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Rewind_FunctionAddress, intPtr, Rewind_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Rewind_ReturnValue_Offset), 0, Rewind_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Play")]
	public unsafe bool Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Play");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Play_FunctionAddress, intPtr, Play_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Play_ReturnValue_Offset), 0, Play_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Pause")]
	public unsafe bool Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Pause");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Pause_FunctionAddress, intPtr, Pause_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Pause_ReturnValue_Offset), 0, Pause_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:OpenUrl")]
	public unsafe bool OpenUrl(string NewUrl)
	{
		CheckDestroyed();
		if (!OpenUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:OpenUrl");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenUrl_NewUrl_Offset), 0, OpenUrl_NewUrl_PropertyAddress.Address, NewUrl);
		NativeReflection.InvokeFunctionOptimized(base.Address, OpenUrl_FunctionAddress, intPtr, OpenUrl_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenUrl_NewUrl_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenUrl_ReturnValue_Offset), 0, OpenUrl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:IsStopped")]
	public unsafe bool IsStopped()
	{
		CheckDestroyed();
		if (!IsStopped_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:IsStopped");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStopped_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStopped_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStopped_FunctionAddress, intPtr, IsStopped_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStopped_ReturnValue_Offset), 0, IsStopped_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPlaying");
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
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPaused")]
	public unsafe bool IsPaused()
	{
		CheckDestroyed();
		if (!IsPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPaused");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsPaused_FunctionAddress, intPtr, IsPaused_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPaused_ReturnValue_Offset), 0, IsPaused_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:IsLooping")]
	public unsafe bool IsLooping()
	{
		CheckDestroyed();
		if (!IsLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:IsLooping");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLooping_FunctionAddress, intPtr, IsLooping_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLooping_ReturnValue_Offset), 0, IsLooping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:IsInitialized")]
	public unsafe bool IsInitialized()
	{
		CheckDestroyed();
		if (!IsInitialized_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:IsInitialized");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInitialized_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInitialized_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInitialized_FunctionAddress, intPtr, IsInitialized_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInitialized_ReturnValue_Offset), 0, IsInitialized_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:GetUrl")]
	public unsafe string GetUrl()
	{
		CheckDestroyed();
		if (!GetUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:GetUrl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUrl_FunctionAddress, intPtr, GetUrl_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUrl_ReturnValue_Offset), 0, GetUrl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUrl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:GetTime")]
	public unsafe FTimespan GetTime()
	{
		CheckDestroyed();
		if (!GetTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:GetTime");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTime_FunctionAddress, intPtr, GetTime_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetTime_ReturnValue_Offset), 0, GetTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:GetRate")]
	public unsafe float GetRate()
	{
		CheckDestroyed();
		if (!GetRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:GetRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRate_FunctionAddress, intPtr, GetRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRate_ReturnValue_Offset), 0, GetRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:GetDuration")]
	public unsafe FTimespan GetDuration()
	{
		CheckDestroyed();
		if (!GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:GetDuration");
			return default(FTimespan);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDuration_FunctionAddress, intPtr, GetDuration_ParamsSize);
		return FTimespan.FromNative(IntPtr.Add(intPtr, GetDuration_ReturnValue_Offset), 0, GetDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:Draw")]
	public unsafe void Draw(UTexture texture, bool tonemap = false, int out_nits = 10000, float alpha = 1f, bool srgb_decode = false, bool hdr = false)
	{
		CheckDestroyed();
		if (!Draw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:Draw");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Draw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Draw_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, Draw_texture_Offset), 0, Draw_texture_PropertyAddress.Address, texture);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Draw_tonemap_Offset), 0, Draw_tonemap_PropertyAddress.Address, tonemap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Draw_out_nits_Offset), 0, Draw_out_nits_PropertyAddress.Address, out_nits);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Draw_alpha_Offset), 0, Draw_alpha_PropertyAddress.Address, alpha);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Draw_srgb_decode_Offset), 0, Draw_srgb_decode_PropertyAddress.Address, srgb_decode);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Draw_hdr_Offset), 0, Draw_hdr_PropertyAddress.Address, hdr);
		NativeReflection.InvokeFunctionOptimized(base.Address, Draw_FunctionAddress, intPtr, Draw_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:CloseUrl")]
	public unsafe void CloseUrl()
	{
		CheckDestroyed();
		if (!CloseUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:CloseUrl");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseUrl_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CloseUrl_FunctionAddress, argsSize: CloseUrl_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPlay")]
	public unsafe bool CanPlay()
	{
		CheckDestroyed();
		if (!CanPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPlay");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanPlay_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanPlay_FunctionAddress, intPtr, CanPlay_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanPlay_ReturnValue_Offset), 0, CanPlay_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPause")]
	public unsafe bool CanPause()
	{
		CheckDestroyed();
		if (!CanPause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPause");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanPause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanPause_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanPause_FunctionAddress, intPtr, CanPause_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanPause_ReturnValue_Offset), 0, CanPause_ReturnValue_PropertyAddress.Address);
	}

	static UBinkMediaPlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBinkMediaPlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBinkMediaPlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/BinkMediaPlayer.BinkMediaPlayer");
		OnMediaClosed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaClosed");
		OnMediaClosed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaClosed", Classes.FMulticastDelegateProperty);
		OnMediaOpened_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaOpened");
		OnMediaOpened_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaOpened", Classes.FMulticastDelegateProperty);
		OnMediaReachedEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMediaReachedEnd");
		OnMediaReachedEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMediaReachedEnd", Classes.FMulticastDelegateProperty);
		OnPlaybackSuspended_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlaybackSuspended");
		OnPlaybackSuspended_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlaybackSuspended", Classes.FMulticastDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkBufferMode_PropertyAddress, intPtr, "BinkBufferMode");
		BinkBufferMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinkBufferMode");
		BinkBufferMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinkBufferMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkSoundTrack_PropertyAddress, intPtr, "BinkSoundTrack");
		BinkSoundTrack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinkSoundTrack");
		BinkSoundTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinkSoundTrack", Classes.FByteProperty);
		BinkSoundTrackStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinkSoundTrackStart");
		BinkSoundTrackStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinkSoundTrackStart", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BinkDrawStyle_PropertyAddress, intPtr, "BinkDrawStyle");
		BinkDrawStyle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinkDrawStyle");
		BinkDrawStyle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinkDrawStyle", Classes.FByteProperty);
		BinkLayerDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinkLayerDepth");
		BinkLayerDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinkLayerDepth", Classes.FIntProperty);
		SupportsSeeking_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsSeeking");
		SupportsSeeking_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsSeeking_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsSeeking_ReturnValue_PropertyAddress, SupportsSeeking_FunctionAddress, "ReturnValue");
		SupportsSeeking_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsSeeking_FunctionAddress, "ReturnValue");
		SupportsSeeking_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsSeeking_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsSeeking_IsValid = SupportsSeeking_FunctionAddress != IntPtr.Zero && SupportsSeeking_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsSeeking", SupportsSeeking_IsValid);
		SupportsScrubbing_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsScrubbing");
		SupportsScrubbing_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsScrubbing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsScrubbing_ReturnValue_PropertyAddress, SupportsScrubbing_FunctionAddress, "ReturnValue");
		SupportsScrubbing_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsScrubbing_FunctionAddress, "ReturnValue");
		SupportsScrubbing_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsScrubbing_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsScrubbing_IsValid = SupportsScrubbing_FunctionAddress != IntPtr.Zero && SupportsScrubbing_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsScrubbing", SupportsScrubbing_IsValid);
		SupportsRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsRate");
		SupportsRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_Rate_PropertyAddress, SupportsRate_FunctionAddress, "Rate");
		SupportsRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "Rate");
		SupportsRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_Unthinned_PropertyAddress, SupportsRate_FunctionAddress, "Unthinned");
		SupportsRate_Unthinned_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "Unthinned");
		SupportsRate_Unthinned_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "Unthinned", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsRate_ReturnValue_PropertyAddress, SupportsRate_FunctionAddress, "ReturnValue");
		SupportsRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsRate_FunctionAddress, "ReturnValue");
		SupportsRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsRate_IsValid = SupportsRate_FunctionAddress != IntPtr.Zero && SupportsRate_Rate_IsValid && SupportsRate_Unthinned_IsValid && SupportsRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SupportsRate", SupportsRate_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Stop", Stop_IsValid);
		SetVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolume");
		SetVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolume_Rate_PropertyAddress, SetVolume_FunctionAddress, "Rate");
		SetVolume_Rate_Offset = NativeReflectionCached.GetPropertyOffset(SetVolume_FunctionAddress, "Rate");
		SetVolume_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolume_FunctionAddress, "Rate", Classes.FFloatProperty);
		SetVolume_IsValid = SetVolume_FunctionAddress != IntPtr.Zero && SetVolume_Rate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SetVolume", SetVolume_IsValid);
		SetRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRate");
		SetRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRate_Rate_PropertyAddress, SetRate_FunctionAddress, "Rate");
		SetRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(SetRate_FunctionAddress, "Rate");
		SetRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRate_ReturnValue_PropertyAddress, SetRate_FunctionAddress, "ReturnValue");
		SetRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRate_FunctionAddress, "ReturnValue");
		SetRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetRate_IsValid = SetRate_FunctionAddress != IntPtr.Zero && SetRate_Rate_IsValid && SetRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SetRate", SetRate_IsValid);
		SetLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLooping");
		SetLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_InLooping_PropertyAddress, SetLooping_FunctionAddress, "InLooping");
		SetLooping_InLooping_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "InLooping");
		SetLooping_InLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "InLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLooping_ReturnValue_PropertyAddress, SetLooping_FunctionAddress, "ReturnValue");
		SetLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLooping_FunctionAddress, "ReturnValue");
		SetLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetLooping_IsValid = SetLooping_FunctionAddress != IntPtr.Zero && SetLooping_InLooping_IsValid && SetLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:SetLooping", SetLooping_IsValid);
		Seek_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Seek");
		Seek_ParamsSize = NativeReflection.GetFunctionParamsSize(Seek_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Seek_InTime_PropertyAddress, Seek_FunctionAddress, "InTime");
		Seek_InTime_Offset = NativeReflectionCached.GetPropertyOffset(Seek_FunctionAddress, "InTime");
		Seek_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(Seek_FunctionAddress, "InTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Seek_ReturnValue_PropertyAddress, Seek_FunctionAddress, "ReturnValue");
		Seek_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Seek_FunctionAddress, "ReturnValue");
		Seek_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Seek_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Seek_IsValid = Seek_FunctionAddress != IntPtr.Zero && Seek_InTime_IsValid && Seek_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Seek", Seek_IsValid);
		Rewind_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Rewind");
		Rewind_ParamsSize = NativeReflection.GetFunctionParamsSize(Rewind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Rewind_ReturnValue_PropertyAddress, Rewind_FunctionAddress, "ReturnValue");
		Rewind_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Rewind_FunctionAddress, "ReturnValue");
		Rewind_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Rewind_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Rewind_IsValid = Rewind_FunctionAddress != IntPtr.Zero && Rewind_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Rewind", Rewind_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Play_ReturnValue_PropertyAddress, Play_FunctionAddress, "ReturnValue");
		Play_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Play_FunctionAddress, "ReturnValue");
		Play_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Play_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero && Play_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Pause_ReturnValue_PropertyAddress, Pause_FunctionAddress, "ReturnValue");
		Pause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Pause_FunctionAddress, "ReturnValue");
		Pause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Pause_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero && Pause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Pause", Pause_IsValid);
		OpenUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OpenUrl");
		OpenUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenUrl_NewUrl_PropertyAddress, OpenUrl_FunctionAddress, "NewUrl");
		OpenUrl_NewUrl_Offset = NativeReflectionCached.GetPropertyOffset(OpenUrl_FunctionAddress, "NewUrl");
		OpenUrl_NewUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUrl_FunctionAddress, "NewUrl", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenUrl_ReturnValue_PropertyAddress, OpenUrl_FunctionAddress, "ReturnValue");
		OpenUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenUrl_FunctionAddress, "ReturnValue");
		OpenUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenUrl_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenUrl_IsValid = OpenUrl_FunctionAddress != IntPtr.Zero && OpenUrl_NewUrl_IsValid && OpenUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:OpenUrl", OpenUrl_IsValid);
		IsStopped_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsStopped");
		IsStopped_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStopped_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStopped_ReturnValue_PropertyAddress, IsStopped_FunctionAddress, "ReturnValue");
		IsStopped_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStopped_FunctionAddress, "ReturnValue");
		IsStopped_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStopped_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStopped_IsValid = IsStopped_FunctionAddress != IntPtr.Zero && IsStopped_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:IsStopped", IsStopped_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPlaying", IsPlaying_IsValid);
		IsPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPaused");
		IsPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPaused_ReturnValue_PropertyAddress, IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPaused_IsValid = IsPaused_FunctionAddress != IntPtr.Zero && IsPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:IsPaused", IsPaused_IsValid);
		IsLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLooping");
		IsLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLooping_ReturnValue_PropertyAddress, IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLooping_FunctionAddress, "ReturnValue");
		IsLooping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLooping_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLooping_IsValid = IsLooping_FunctionAddress != IntPtr.Zero && IsLooping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:IsLooping", IsLooping_IsValid);
		IsInitialized_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInitialized");
		IsInitialized_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInitialized_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInitialized_ReturnValue_PropertyAddress, IsInitialized_FunctionAddress, "ReturnValue");
		IsInitialized_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInitialized_FunctionAddress, "ReturnValue");
		IsInitialized_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInitialized_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInitialized_IsValid = IsInitialized_FunctionAddress != IntPtr.Zero && IsInitialized_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:IsInitialized", IsInitialized_IsValid);
		GetUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUrl");
		GetUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUrl_ReturnValue_PropertyAddress, GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUrl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUrl_IsValid = GetUrl_FunctionAddress != IntPtr.Zero && GetUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:GetUrl", GetUrl_IsValid);
		GetTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTime");
		GetTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTime_ReturnValue_PropertyAddress, GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTime_FunctionAddress, "ReturnValue");
		GetTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTime_IsValid = GetTime_FunctionAddress != IntPtr.Zero && GetTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:GetTime", GetTime_IsValid);
		GetRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRate");
		GetRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRate_ReturnValue_PropertyAddress, GetRate_FunctionAddress, "ReturnValue");
		GetRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRate_FunctionAddress, "ReturnValue");
		GetRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRate_IsValid = GetRate_FunctionAddress != IntPtr.Zero && GetRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:GetRate", GetRate_IsValid);
		GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDuration");
		GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDuration_ReturnValue_PropertyAddress, GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDuration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDuration_IsValid = GetDuration_FunctionAddress != IntPtr.Zero && GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:GetDuration", GetDuration_IsValid);
		Draw_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Draw");
		Draw_ParamsSize = NativeReflection.GetFunctionParamsSize(Draw_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Draw_texture_PropertyAddress, Draw_FunctionAddress, "texture");
		Draw_texture_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "texture");
		Draw_texture_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Draw_tonemap_PropertyAddress, Draw_FunctionAddress, "tonemap");
		Draw_tonemap_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "tonemap");
		Draw_tonemap_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "tonemap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Draw_out_nits_PropertyAddress, Draw_FunctionAddress, "out_nits");
		Draw_out_nits_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "out_nits");
		Draw_out_nits_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "out_nits", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Draw_alpha_PropertyAddress, Draw_FunctionAddress, "alpha");
		Draw_alpha_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "alpha");
		Draw_alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Draw_srgb_decode_PropertyAddress, Draw_FunctionAddress, "srgb_decode");
		Draw_srgb_decode_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "srgb_decode");
		Draw_srgb_decode_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "srgb_decode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Draw_hdr_PropertyAddress, Draw_FunctionAddress, "hdr");
		Draw_hdr_Offset = NativeReflectionCached.GetPropertyOffset(Draw_FunctionAddress, "hdr");
		Draw_hdr_IsValid = NativeReflectionCached.ValidatePropertyClass(Draw_FunctionAddress, "hdr", Classes.FBoolProperty);
		Draw_IsValid = Draw_FunctionAddress != IntPtr.Zero && Draw_texture_IsValid && Draw_tonemap_IsValid && Draw_out_nits_IsValid && Draw_alpha_IsValid && Draw_srgb_decode_IsValid && Draw_hdr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:Draw", Draw_IsValid);
		CloseUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CloseUrl");
		CloseUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseUrl_FunctionAddress);
		CloseUrl_IsValid = CloseUrl_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:CloseUrl", CloseUrl_IsValid);
		CanPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanPlay");
		CanPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(CanPlay_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanPlay_ReturnValue_PropertyAddress, CanPlay_FunctionAddress, "ReturnValue");
		CanPlay_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanPlay_FunctionAddress, "ReturnValue");
		CanPlay_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPlay_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanPlay_IsValid = CanPlay_FunctionAddress != IntPtr.Zero && CanPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPlay", CanPlay_IsValid);
		CanPause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanPause");
		CanPause_ParamsSize = NativeReflection.GetFunctionParamsSize(CanPause_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanPause_ReturnValue_PropertyAddress, CanPause_FunctionAddress, "ReturnValue");
		CanPause_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanPause_FunctionAddress, "ReturnValue");
		CanPause_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanPause_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanPause_IsValid = CanPause_FunctionAddress != IntPtr.Zero && CanPause_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/BinkMediaPlayer.BinkMediaPlayer:CanPause", CanPause_IsValid);
	}
}
