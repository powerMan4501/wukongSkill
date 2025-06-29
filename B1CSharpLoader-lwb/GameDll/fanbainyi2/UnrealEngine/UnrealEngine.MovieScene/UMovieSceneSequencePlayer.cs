using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer", "MovieScene", UnrealModuleType.Engine)]
public class UMovieSceneSequencePlayer : UObject
{
	private static bool OnPlay_IsValid;

	private static int OnPlay_Offset;

	private FOnMovieSceneSequencePlayerEvent OnPlay_DelegateCached;

	private static bool OnPlayReverse_IsValid;

	private static int OnPlayReverse_Offset;

	private FOnMovieSceneSequencePlayerEvent OnPlayReverse_DelegateCached;

	private static bool OnStop_IsValid;

	private static int OnStop_Offset;

	private FOnMovieSceneSequencePlayerEvent OnStop_DelegateCached;

	private static bool OnPause_IsValid;

	private static int OnPause_Offset;

	private FOnMovieSceneSequencePlayerEvent OnPause_DelegateCached;

	private static bool OnFinished_IsValid;

	private static int OnFinished_Offset;

	private FOnMovieSceneSequencePlayerEvent OnFinished_DelegateCached;

	private static bool StopAtCurrentTime_IsValid;

	private static IntPtr StopAtCurrentTime_FunctionAddress;

	private static int StopAtCurrentTime_ParamsSize;

	private static bool Stop_IsValid;

	private static IntPtr Stop_FunctionAddress;

	private static int Stop_ParamsSize;

	private static bool SetTimeRange_IsValid;

	private static IntPtr SetTimeRange_FunctionAddress;

	private static int SetTimeRange_ParamsSize;

	private static bool SetTimeRange_StartTime_IsValid;

	private static FFieldAddress SetTimeRange_StartTime_PropertyAddress;

	private static int SetTimeRange_StartTime_Offset;

	private static bool SetTimeRange_Duration_IsValid;

	private static FFieldAddress SetTimeRange_Duration_PropertyAddress;

	private static int SetTimeRange_Duration_Offset;

	private static bool SetPlayRate_IsValid;

	private static IntPtr SetPlayRate_FunctionAddress;

	private static int SetPlayRate_ParamsSize;

	private static bool SetPlayRate_PlayRate_IsValid;

	private static FFieldAddress SetPlayRate_PlayRate_PropertyAddress;

	private static int SetPlayRate_PlayRate_Offset;

	private static bool SetPlaybackPosition_IsValid;

	private static IntPtr SetPlaybackPosition_FunctionAddress;

	private static int SetPlaybackPosition_ParamsSize;

	private static bool SetPlaybackPosition_PlaybackParams_IsValid;

	private static FFieldAddress SetPlaybackPosition_PlaybackParams_PropertyAddress;

	private static int SetPlaybackPosition_PlaybackParams_Offset;

	private static bool SetFrameRate_IsValid;

	private static IntPtr SetFrameRate_FunctionAddress;

	private static int SetFrameRate_ParamsSize;

	private static bool SetFrameRate_FrameRate_IsValid;

	private static FFieldAddress SetFrameRate_FrameRate_PropertyAddress;

	private static int SetFrameRate_FrameRate_Offset;

	private static bool SetFrameRange_IsValid;

	private static IntPtr SetFrameRange_FunctionAddress;

	private static int SetFrameRange_ParamsSize;

	private static bool SetFrameRange_StartFrame_IsValid;

	private static FFieldAddress SetFrameRange_StartFrame_PropertyAddress;

	private static int SetFrameRange_StartFrame_Offset;

	private static bool SetFrameRange_Duration_IsValid;

	private static FFieldAddress SetFrameRange_Duration_PropertyAddress;

	private static int SetFrameRange_Duration_Offset;

	private static bool SetFrameRange_SubFrames_IsValid;

	private static FFieldAddress SetFrameRange_SubFrames_PropertyAddress;

	private static int SetFrameRange_SubFrames_Offset;

	private static bool SetDisableCameraCuts_IsValid;

	private static IntPtr SetDisableCameraCuts_FunctionAddress;

	private static int SetDisableCameraCuts_ParamsSize;

	private static bool SetDisableCameraCuts_bInDisableCameraCuts_IsValid;

	private static FFieldAddress SetDisableCameraCuts_bInDisableCameraCuts_PropertyAddress;

	private static int SetDisableCameraCuts_bInDisableCameraCuts_Offset;

	private static bool Scrub_IsValid;

	private static IntPtr Scrub_FunctionAddress;

	private static int Scrub_ParamsSize;

	private static bool RestoreState_IsValid;

	private static IntPtr RestoreState_FunctionAddress;

	private static int RestoreState_ParamsSize;

	private static bool PlayTo_IsValid;

	private static IntPtr PlayTo_FunctionAddress;

	private static int PlayTo_ParamsSize;

	private static bool PlayTo_PlaybackParams_IsValid;

	private static FFieldAddress PlayTo_PlaybackParams_PropertyAddress;

	private static int PlayTo_PlaybackParams_Offset;

	private static bool PlayTo_PlayToParams_IsValid;

	private static FFieldAddress PlayTo_PlayToParams_PropertyAddress;

	private static int PlayTo_PlayToParams_Offset;

	private static bool PlayReverse_IsValid;

	private static IntPtr PlayReverse_FunctionAddress;

	private static int PlayReverse_ParamsSize;

	private static bool PlayLooping_IsValid;

	private static IntPtr PlayLooping_FunctionAddress;

	private static int PlayLooping_ParamsSize;

	private static bool PlayLooping_NumLoops_IsValid;

	private static FFieldAddress PlayLooping_NumLoops_PropertyAddress;

	private static int PlayLooping_NumLoops_Offset;

	private static bool Play_IsValid;

	private static IntPtr Play_FunctionAddress;

	private static int Play_ParamsSize;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool IsReversed_IsValid;

	private static IntPtr IsReversed_FunctionAddress;

	private static int IsReversed_ParamsSize;

	private static bool IsReversed_ReturnValue_IsValid;

	private static FFieldAddress IsReversed_ReturnValue_PropertyAddress;

	private static int IsReversed_ReturnValue_Offset;

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

	private static bool GoToEndAndStop_IsValid;

	private static IntPtr GoToEndAndStop_FunctionAddress;

	private static int GoToEndAndStop_ParamsSize;

	private static bool GetStartTime_IsValid;

	private static IntPtr GetStartTime_FunctionAddress;

	private static int GetStartTime_ParamsSize;

	private static bool GetStartTime_ReturnValue_IsValid;

	private static FFieldAddress GetStartTime_ReturnValue_PropertyAddress;

	private static int GetStartTime_ReturnValue_Offset;

	private static bool GetSequenceName_IsValid;

	private static IntPtr GetSequenceName_FunctionAddress;

	private static int GetSequenceName_ParamsSize;

	private static bool GetSequenceName_bAddClientInfo_IsValid;

	private static FFieldAddress GetSequenceName_bAddClientInfo_PropertyAddress;

	private static int GetSequenceName_bAddClientInfo_Offset;

	private static bool GetSequenceName_ReturnValue_IsValid;

	private static FFieldAddress GetSequenceName_ReturnValue_PropertyAddress;

	private static int GetSequenceName_ReturnValue_Offset;

	private static bool GetSequence_IsValid;

	private static IntPtr GetSequence_FunctionAddress;

	private static int GetSequence_ParamsSize;

	private static bool GetSequence_ReturnValue_IsValid;

	private static FFieldAddress GetSequence_ReturnValue_PropertyAddress;

	private static int GetSequence_ReturnValue_Offset;

	private static bool GetPlayRate_IsValid;

	private static IntPtr GetPlayRate_FunctionAddress;

	private static int GetPlayRate_ParamsSize;

	private static bool GetPlayRate_ReturnValue_IsValid;

	private static FFieldAddress GetPlayRate_ReturnValue_PropertyAddress;

	private static int GetPlayRate_ReturnValue_Offset;

	private static bool GetObjectBindings_IsValid;

	private static IntPtr GetObjectBindings_FunctionAddress;

	private static int GetObjectBindings_ParamsSize;

	private static bool GetObjectBindings_InObject_IsValid;

	private static FFieldAddress GetObjectBindings_InObject_PropertyAddress;

	private static int GetObjectBindings_InObject_Offset;

	private static bool GetObjectBindings_ReturnValue_IsValid;

	private static FFieldAddress GetObjectBindings_ReturnValue_PropertyAddress;

	private static int GetObjectBindings_ReturnValue_Offset;

	private static bool GetFrameRate_IsValid;

	private static IntPtr GetFrameRate_FunctionAddress;

	private static int GetFrameRate_ParamsSize;

	private static bool GetFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetFrameRate_ReturnValue_PropertyAddress;

	private static int GetFrameRate_ReturnValue_Offset;

	private static bool GetFrameDuration_IsValid;

	private static IntPtr GetFrameDuration_FunctionAddress;

	private static int GetFrameDuration_ParamsSize;

	private static bool GetFrameDuration_ReturnValue_IsValid;

	private static FFieldAddress GetFrameDuration_ReturnValue_PropertyAddress;

	private static int GetFrameDuration_ReturnValue_Offset;

	private static bool GetEndTime_IsValid;

	private static IntPtr GetEndTime_FunctionAddress;

	private static int GetEndTime_ParamsSize;

	private static bool GetEndTime_ReturnValue_IsValid;

	private static FFieldAddress GetEndTime_ReturnValue_PropertyAddress;

	private static int GetEndTime_ReturnValue_Offset;

	private static bool GetDuration_IsValid;

	private static IntPtr GetDuration_FunctionAddress;

	private static int GetDuration_ParamsSize;

	private static bool GetDuration_ReturnValue_IsValid;

	private static FFieldAddress GetDuration_ReturnValue_PropertyAddress;

	private static int GetDuration_ReturnValue_Offset;

	private static bool GetDisableCameraCuts_IsValid;

	private static IntPtr GetDisableCameraCuts_FunctionAddress;

	private static int GetDisableCameraCuts_ParamsSize;

	private static bool GetDisableCameraCuts_ReturnValue_IsValid;

	private static FFieldAddress GetDisableCameraCuts_ReturnValue_PropertyAddress;

	private static int GetDisableCameraCuts_ReturnValue_Offset;

	private static bool GetCurrentTime_IsValid;

	private static IntPtr GetCurrentTime_FunctionAddress;

	private static int GetCurrentTime_ParamsSize;

	private static bool GetCurrentTime_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentTime_ReturnValue_PropertyAddress;

	private static int GetCurrentTime_ReturnValue_Offset;

	private static bool GetBoundObjects_IsValid;

	private static IntPtr GetBoundObjects_FunctionAddress;

	private static int GetBoundObjects_ParamsSize;

	private static bool GetBoundObjects_ObjectBinding_IsValid;

	private static FFieldAddress GetBoundObjects_ObjectBinding_PropertyAddress;

	private static int GetBoundObjects_ObjectBinding_Offset;

	private static bool GetBoundObjects_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObjects_ReturnValue_PropertyAddress;

	private static int GetBoundObjects_ReturnValue_Offset;

	private static bool ChangePlaybackDirection_IsValid;

	private static IntPtr ChangePlaybackDirection_FunctionAddress;

	private static int ChangePlaybackDirection_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:OnPlay")]
	public FOnMovieSceneSequencePlayerEvent OnPlay
	{
		get
		{
			CheckDestroyed();
			if (!OnPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSequencePlayer:OnPlay");
				return new FOnMovieSceneSequencePlayerEvent();
			}
			if (OnPlay_DelegateCached == null)
			{
				OnPlay_DelegateCached = new FOnMovieSceneSequencePlayerEvent();
				OnPlay_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlay_Offset));
			}
			return OnPlay_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:OnPlayReverse")]
	public FOnMovieSceneSequencePlayerEvent OnPlayReverse
	{
		get
		{
			CheckDestroyed();
			if (!OnPlayReverse_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSequencePlayer:OnPlayReverse");
				return new FOnMovieSceneSequencePlayerEvent();
			}
			if (OnPlayReverse_DelegateCached == null)
			{
				OnPlayReverse_DelegateCached = new FOnMovieSceneSequencePlayerEvent();
				OnPlayReverse_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPlayReverse_Offset));
			}
			return OnPlayReverse_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:OnStop")]
	public FOnMovieSceneSequencePlayerEvent OnStop
	{
		get
		{
			CheckDestroyed();
			if (!OnStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSequencePlayer:OnStop");
				return new FOnMovieSceneSequencePlayerEvent();
			}
			if (OnStop_DelegateCached == null)
			{
				OnStop_DelegateCached = new FOnMovieSceneSequencePlayerEvent();
				OnStop_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnStop_Offset));
			}
			return OnStop_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:OnPause")]
	public FOnMovieSceneSequencePlayerEvent OnPause
	{
		get
		{
			CheckDestroyed();
			if (!OnPause_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSequencePlayer:OnPause");
				return new FOnMovieSceneSequencePlayerEvent();
			}
			if (OnPause_DelegateCached == null)
			{
				OnPause_DelegateCached = new FOnMovieSceneSequencePlayerEvent();
				OnPause_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPause_Offset));
			}
			return OnPause_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:OnFinished")]
	public FOnMovieSceneSequencePlayerEvent OnFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieScene.MovieSceneSequencePlayer:OnFinished");
				return new FOnMovieSceneSequencePlayerEvent();
			}
			if (OnFinished_DelegateCached == null)
			{
				OnFinished_DelegateCached = new FOnMovieSceneSequencePlayerEvent();
				OnFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnFinished_Offset));
			}
			return OnFinished_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:StopAtCurrentTime")]
	public unsafe void StopAtCurrentTime()
	{
		CheckDestroyed();
		if (!StopAtCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:StopAtCurrentTime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAtCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAtCurrentTime_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopAtCurrentTime_FunctionAddress, argsSize: StopAtCurrentTime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:Stop")]
	public unsafe void Stop()
	{
		CheckDestroyed();
		if (!Stop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:Stop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Stop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Stop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Stop_FunctionAddress, argsSize: Stop_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetTimeRange")]
	public unsafe void SetTimeRange(float StartTime, float Duration)
	{
		CheckDestroyed();
		if (!SetTimeRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetTimeRange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTimeRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTimeRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTimeRange_StartTime_Offset), 0, SetTimeRange_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTimeRange_Duration_Offset), 0, SetTimeRange_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTimeRange_FunctionAddress, intPtr, SetTimeRange_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetPlayRate")]
	public unsafe void SetPlayRate(float PlayRate)
	{
		CheckDestroyed();
		if (!SetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetPlayRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPlayRate_PlayRate_Offset), 0, SetPlayRate_PlayRate_PropertyAddress.Address, PlayRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlayRate_FunctionAddress, intPtr, SetPlayRate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetPlaybackPosition")]
	public unsafe void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
	{
		CheckDestroyed();
		if (!SetPlaybackPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetPlaybackPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaybackPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaybackPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetPlaybackPosition_PlaybackParams_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackParams.ToNative(IntPtr.Add(intPtr, SetPlaybackPosition_PlaybackParams_Offset), 0, SetPlaybackPosition_PlaybackParams_PropertyAddress.Address, PlaybackParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaybackPosition_FunctionAddress, intPtr, SetPlaybackPosition_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPlaybackPosition_PlaybackParams_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRate")]
	public unsafe void SetFrameRate(FFrameRate FrameRate)
	{
		CheckDestroyed();
		if (!SetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FFrameRate>.ToNative(IntPtr.Add(intPtr, SetFrameRate_FrameRate_Offset), 0, SetFrameRate_FrameRate_PropertyAddress.Address, FrameRate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrameRate_FunctionAddress, intPtr, SetFrameRate_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRange")]
	public unsafe void SetFrameRange(int StartFrame, int Duration, float SubFrames = 0f)
	{
		CheckDestroyed();
		if (!SetFrameRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFrameRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFrameRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetFrameRange_StartFrame_Offset), 0, SetFrameRange_StartFrame_PropertyAddress.Address, StartFrame);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetFrameRange_Duration_Offset), 0, SetFrameRange_Duration_PropertyAddress.Address, Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFrameRange_SubFrames_Offset), 0, SetFrameRange_SubFrames_PropertyAddress.Address, SubFrames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFrameRange_FunctionAddress, intPtr, SetFrameRange_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:SetDisableCameraCuts")]
	public unsafe void SetDisableCameraCuts(bool bInDisableCameraCuts)
	{
		CheckDestroyed();
		if (!SetDisableCameraCuts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:SetDisableCameraCuts");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisableCameraCuts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisableCameraCuts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetDisableCameraCuts_bInDisableCameraCuts_Offset), 0, SetDisableCameraCuts_bInDisableCameraCuts_PropertyAddress.Address, bInDisableCameraCuts);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisableCameraCuts_FunctionAddress, intPtr, SetDisableCameraCuts_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:Scrub")]
	public unsafe void Scrub()
	{
		CheckDestroyed();
		if (!Scrub_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:Scrub");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Scrub_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Scrub_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Scrub_FunctionAddress, argsSize: Scrub_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:RestoreState")]
	public unsafe void RestoreState()
	{
		CheckDestroyed();
		if (!RestoreState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:RestoreState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestoreState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestoreState_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RestoreState_FunctionAddress, argsSize: RestoreState_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:PlayTo")]
	public unsafe void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams, FMovieSceneSequencePlayToParams PlayToParams)
	{
		CheckDestroyed();
		if (!PlayTo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:PlayTo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayTo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayTo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PlayTo_PlaybackParams_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlaybackParams.ToNative(IntPtr.Add(intPtr, PlayTo_PlaybackParams_Offset), 0, PlayTo_PlaybackParams_PropertyAddress.Address, PlaybackParams);
		NativeReflection.InitializeValue_InContainer(PlayTo_PlayToParams_PropertyAddress.Address, intPtr);
		FMovieSceneSequencePlayToParams.ToNative(IntPtr.Add(intPtr, PlayTo_PlayToParams_Offset), 0, PlayTo_PlayToParams_PropertyAddress.Address, PlayToParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayTo_FunctionAddress, intPtr, PlayTo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PlayTo_PlaybackParams_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:PlayReverse")]
	public unsafe void PlayReverse()
	{
		CheckDestroyed();
		if (!PlayReverse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:PlayReverse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayReverse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayReverse_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PlayReverse_FunctionAddress, argsSize: PlayReverse_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:PlayLooping")]
	public unsafe void PlayLooping(int NumLoops = -1)
	{
		CheckDestroyed();
		if (!PlayLooping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:PlayLooping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayLooping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayLooping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlayLooping_NumLoops_Offset), 0, PlayLooping_NumLoops_PropertyAddress.Address, NumLoops);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayLooping_FunctionAddress, intPtr, PlayLooping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:Play")]
	public unsafe void Play()
	{
		CheckDestroyed();
		if (!Play_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:Play");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Play_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Play_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Play_FunctionAddress, argsSize: Play_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:Pause")]
	public unsafe void Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:IsReversed")]
	public unsafe bool IsReversed()
	{
		CheckDestroyed();
		if (!IsReversed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:IsReversed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsReversed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsReversed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsReversed_FunctionAddress, intPtr, IsReversed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsReversed_ReturnValue_Offset), 0, IsReversed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:IsPlaying")]
	public unsafe bool IsPlaying()
	{
		CheckDestroyed();
		if (!IsPlaying_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:IsPlaying");
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
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:IsPaused")]
	public unsafe bool IsPaused()
	{
		CheckDestroyed();
		if (!IsPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:IsPaused");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GoToEndAndStop")]
	public unsafe void GoToEndAndStop()
	{
		CheckDestroyed();
		if (!GoToEndAndStop_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GoToEndAndStop");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GoToEndAndStop_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GoToEndAndStop_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: GoToEndAndStop_FunctionAddress, argsSize: GoToEndAndStop_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetStartTime")]
	public unsafe FQualifiedTime GetStartTime()
	{
		CheckDestroyed();
		if (!GetStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetStartTime");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartTime_FunctionAddress, intPtr, GetStartTime_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetStartTime_ReturnValue_Offset), 0, GetStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetSequenceName")]
	public unsafe string GetSequenceName(bool bAddClientInfo = false)
	{
		CheckDestroyed();
		if (!GetSequenceName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetSequenceName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequenceName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequenceName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSequenceName_bAddClientInfo_Offset), 0, GetSequenceName_bAddClientInfo_PropertyAddress.Address, bAddClientInfo);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequenceName_FunctionAddress, intPtr, GetSequenceName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetSequenceName_ReturnValue_Offset), 0, GetSequenceName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSequenceName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetSequence")]
	public unsafe UMovieSceneSequence GetSequence()
	{
		CheckDestroyed();
		if (!GetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetSequence");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequence_FunctionAddress, intPtr, GetSequence_ParamsSize);
		return UObjectMarshaler<UMovieSceneSequence>.FromNative(IntPtr.Add(intPtr, GetSequence_ReturnValue_Offset), 0, GetSequence_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetPlayRate")]
	public unsafe float GetPlayRate()
	{
		CheckDestroyed();
		if (!GetPlayRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetPlayRate");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayRate_FunctionAddress, intPtr, GetPlayRate_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetPlayRate_ReturnValue_Offset), 0, GetPlayRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetObjectBindings")]
	public unsafe List<FMovieSceneObjectBindingID> GetObjectBindings(UObject InObject)
	{
		CheckDestroyed();
		if (!GetObjectBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetObjectBindings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetObjectBindings_InObject_Offset), 0, GetObjectBindings_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetObjectBindings_FunctionAddress, intPtr, GetObjectBindings_ParamsSize);
		List<FMovieSceneObjectBindingID> result = new TArrayCopyMarshaler<FMovieSceneObjectBindingID>(1, GetObjectBindings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.FromNative, CachedMarshalingDelegates<FMovieSceneObjectBindingID, FMovieSceneObjectBindingID>.ToNative).FromNative(IntPtr.Add(intPtr, GetObjectBindings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetObjectBindings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameRate")]
	public unsafe FFrameRate GetFrameRate()
	{
		CheckDestroyed();
		if (!GetFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameRate_FunctionAddress, intPtr, GetFrameRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetFrameRate_ReturnValue_Offset), 0, GetFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameDuration")]
	public unsafe int GetFrameDuration()
	{
		CheckDestroyed();
		if (!GetFrameDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameDuration");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFrameDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFrameDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFrameDuration_FunctionAddress, intPtr, GetFrameDuration_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetFrameDuration_ReturnValue_Offset), 0, GetFrameDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetEndTime")]
	public unsafe FQualifiedTime GetEndTime()
	{
		CheckDestroyed();
		if (!GetEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetEndTime");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndTime_FunctionAddress, intPtr, GetEndTime_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetEndTime_ReturnValue_Offset), 0, GetEndTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetDuration")]
	public unsafe FQualifiedTime GetDuration()
	{
		CheckDestroyed();
		if (!GetDuration_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetDuration");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDuration_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDuration_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDuration_FunctionAddress, intPtr, GetDuration_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetDuration_ReturnValue_Offset), 0, GetDuration_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetDisableCameraCuts")]
	public unsafe bool GetDisableCameraCuts()
	{
		CheckDestroyed();
		if (!GetDisableCameraCuts_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetDisableCameraCuts");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisableCameraCuts_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisableCameraCuts_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisableCameraCuts_FunctionAddress, intPtr, GetDisableCameraCuts_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDisableCameraCuts_ReturnValue_Offset), 0, GetDisableCameraCuts_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetCurrentTime")]
	public unsafe FQualifiedTime GetCurrentTime()
	{
		CheckDestroyed();
		if (!GetCurrentTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetCurrentTime");
			return default(FQualifiedTime);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentTime_FunctionAddress, intPtr, GetCurrentTime_ParamsSize);
		return FQualifiedTime.FromNative(IntPtr.Add(intPtr, GetCurrentTime_ReturnValue_Offset), 0, GetCurrentTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:GetBoundObjects")]
	public unsafe List<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding)
	{
		CheckDestroyed();
		if (!GetBoundObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:GetBoundObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundObjects_ObjectBinding_PropertyAddress.Address, intPtr);
		FMovieSceneObjectBindingID.ToNative(IntPtr.Add(intPtr, GetBoundObjects_ObjectBinding_Offset), 0, GetBoundObjects_ObjectBinding_PropertyAddress.Address, ObjectBinding);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundObjects_FunctionAddress, intPtr, GetBoundObjects_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, GetBoundObjects_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBoundObjects_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBoundObjects_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayer:ChangePlaybackDirection")]
	public unsafe void ChangePlaybackDirection()
	{
		CheckDestroyed();
		if (!ChangePlaybackDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieScene.MovieSceneSequencePlayer:ChangePlaybackDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangePlaybackDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangePlaybackDirection_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ChangePlaybackDirection_FunctionAddress, argsSize: ChangePlaybackDirection_ParamsSize);
	}

	static UMovieSceneSequencePlayer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneSequencePlayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneSequencePlayer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MovieScene.MovieSceneSequencePlayer");
		OnPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlay");
		OnPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlay", Classes.FMulticastDelegateProperty);
		OnPlayReverse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPlayReverse");
		OnPlayReverse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPlayReverse", Classes.FMulticastDelegateProperty);
		OnStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnStop");
		OnStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnStop", Classes.FMulticastDelegateProperty);
		OnPause_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPause");
		OnPause_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPause", Classes.FMulticastDelegateProperty);
		OnFinished_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnFinished");
		OnFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnFinished", Classes.FMulticastDelegateProperty);
		StopAtCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopAtCurrentTime");
		StopAtCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAtCurrentTime_FunctionAddress);
		StopAtCurrentTime_IsValid = StopAtCurrentTime_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:StopAtCurrentTime", StopAtCurrentTime_IsValid);
		Stop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Stop");
		Stop_ParamsSize = NativeReflection.GetFunctionParamsSize(Stop_FunctionAddress);
		Stop_IsValid = Stop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:Stop", Stop_IsValid);
		SetTimeRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTimeRange");
		SetTimeRange_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTimeRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTimeRange_StartTime_PropertyAddress, SetTimeRange_FunctionAddress, "StartTime");
		SetTimeRange_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(SetTimeRange_FunctionAddress, "StartTime");
		SetTimeRange_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimeRange_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTimeRange_Duration_PropertyAddress, SetTimeRange_FunctionAddress, "Duration");
		SetTimeRange_Duration_Offset = NativeReflectionCached.GetPropertyOffset(SetTimeRange_FunctionAddress, "Duration");
		SetTimeRange_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTimeRange_FunctionAddress, "Duration", Classes.FFloatProperty);
		SetTimeRange_IsValid = SetTimeRange_FunctionAddress != IntPtr.Zero && SetTimeRange_StartTime_IsValid && SetTimeRange_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetTimeRange", SetTimeRange_IsValid);
		SetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlayRate");
		SetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlayRate_PlayRate_PropertyAddress, SetPlayRate_FunctionAddress, "PlayRate");
		SetPlayRate_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(SetPlayRate_FunctionAddress, "PlayRate");
		SetPlayRate_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlayRate_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		SetPlayRate_IsValid = SetPlayRate_FunctionAddress != IntPtr.Zero && SetPlayRate_PlayRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetPlayRate", SetPlayRate_IsValid);
		SetPlaybackPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaybackPosition");
		SetPlaybackPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaybackPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaybackPosition_PlaybackParams_PropertyAddress, SetPlaybackPosition_FunctionAddress, "PlaybackParams");
		SetPlaybackPosition_PlaybackParams_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaybackPosition_FunctionAddress, "PlaybackParams");
		SetPlaybackPosition_PlaybackParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaybackPosition_FunctionAddress, "PlaybackParams", Classes.FStructProperty);
		SetPlaybackPosition_IsValid = SetPlaybackPosition_FunctionAddress != IntPtr.Zero && SetPlaybackPosition_PlaybackParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetPlaybackPosition", SetPlaybackPosition_IsValid);
		SetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrameRate");
		SetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRate_FrameRate_PropertyAddress, SetFrameRate_FunctionAddress, "FrameRate");
		SetFrameRate_FrameRate_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRate_FunctionAddress, "FrameRate");
		SetFrameRate_FrameRate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRate_FunctionAddress, "FrameRate", Classes.FStructProperty);
		SetFrameRate_IsValid = SetFrameRate_FunctionAddress != IntPtr.Zero && SetFrameRate_FrameRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRate", SetFrameRate_IsValid);
		SetFrameRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFrameRange");
		SetFrameRange_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFrameRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRange_StartFrame_PropertyAddress, SetFrameRange_FunctionAddress, "StartFrame");
		SetFrameRange_StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRange_FunctionAddress, "StartFrame");
		SetFrameRange_StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRange_FunctionAddress, "StartFrame", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRange_Duration_PropertyAddress, SetFrameRange_FunctionAddress, "Duration");
		SetFrameRange_Duration_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRange_FunctionAddress, "Duration");
		SetFrameRange_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRange_FunctionAddress, "Duration", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFrameRange_SubFrames_PropertyAddress, SetFrameRange_FunctionAddress, "SubFrames");
		SetFrameRange_SubFrames_Offset = NativeReflectionCached.GetPropertyOffset(SetFrameRange_FunctionAddress, "SubFrames");
		SetFrameRange_SubFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFrameRange_FunctionAddress, "SubFrames", Classes.FFloatProperty);
		SetFrameRange_IsValid = SetFrameRange_FunctionAddress != IntPtr.Zero && SetFrameRange_StartFrame_IsValid && SetFrameRange_Duration_IsValid && SetFrameRange_SubFrames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetFrameRange", SetFrameRange_IsValid);
		SetDisableCameraCuts_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDisableCameraCuts");
		SetDisableCameraCuts_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisableCameraCuts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisableCameraCuts_bInDisableCameraCuts_PropertyAddress, SetDisableCameraCuts_FunctionAddress, "bInDisableCameraCuts");
		SetDisableCameraCuts_bInDisableCameraCuts_Offset = NativeReflectionCached.GetPropertyOffset(SetDisableCameraCuts_FunctionAddress, "bInDisableCameraCuts");
		SetDisableCameraCuts_bInDisableCameraCuts_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisableCameraCuts_FunctionAddress, "bInDisableCameraCuts", Classes.FBoolProperty);
		SetDisableCameraCuts_IsValid = SetDisableCameraCuts_FunctionAddress != IntPtr.Zero && SetDisableCameraCuts_bInDisableCameraCuts_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:SetDisableCameraCuts", SetDisableCameraCuts_IsValid);
		Scrub_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Scrub");
		Scrub_ParamsSize = NativeReflection.GetFunctionParamsSize(Scrub_FunctionAddress);
		Scrub_IsValid = Scrub_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:Scrub", Scrub_IsValid);
		RestoreState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestoreState");
		RestoreState_ParamsSize = NativeReflection.GetFunctionParamsSize(RestoreState_FunctionAddress);
		RestoreState_IsValid = RestoreState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:RestoreState", RestoreState_IsValid);
		PlayTo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayTo");
		PlayTo_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayTo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayTo_PlaybackParams_PropertyAddress, PlayTo_FunctionAddress, "PlaybackParams");
		PlayTo_PlaybackParams_Offset = NativeReflectionCached.GetPropertyOffset(PlayTo_FunctionAddress, "PlaybackParams");
		PlayTo_PlaybackParams_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayTo_FunctionAddress, "PlaybackParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayTo_PlayToParams_PropertyAddress, PlayTo_FunctionAddress, "PlayToParams");
		PlayTo_PlayToParams_Offset = NativeReflectionCached.GetPropertyOffset(PlayTo_FunctionAddress, "PlayToParams");
		PlayTo_PlayToParams_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayTo_FunctionAddress, "PlayToParams", Classes.FStructProperty);
		PlayTo_IsValid = PlayTo_FunctionAddress != IntPtr.Zero && PlayTo_PlaybackParams_IsValid && PlayTo_PlayToParams_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:PlayTo", PlayTo_IsValid);
		PlayReverse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayReverse");
		PlayReverse_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayReverse_FunctionAddress);
		PlayReverse_IsValid = PlayReverse_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:PlayReverse", PlayReverse_IsValid);
		PlayLooping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayLooping");
		PlayLooping_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayLooping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayLooping_NumLoops_PropertyAddress, PlayLooping_FunctionAddress, "NumLoops");
		PlayLooping_NumLoops_Offset = NativeReflectionCached.GetPropertyOffset(PlayLooping_FunctionAddress, "NumLoops");
		PlayLooping_NumLoops_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayLooping_FunctionAddress, "NumLoops", Classes.FIntProperty);
		PlayLooping_IsValid = PlayLooping_FunctionAddress != IntPtr.Zero && PlayLooping_NumLoops_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:PlayLooping", PlayLooping_IsValid);
		Play_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Play");
		Play_ParamsSize = NativeReflection.GetFunctionParamsSize(Play_FunctionAddress);
		Play_IsValid = Play_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:Play", Play_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:Pause", Pause_IsValid);
		IsReversed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsReversed");
		IsReversed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsReversed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsReversed_ReturnValue_PropertyAddress, IsReversed_FunctionAddress, "ReturnValue");
		IsReversed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsReversed_FunctionAddress, "ReturnValue");
		IsReversed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsReversed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsReversed_IsValid = IsReversed_FunctionAddress != IntPtr.Zero && IsReversed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:IsReversed", IsReversed_IsValid);
		IsPlaying_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPlaying");
		IsPlaying_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlaying_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlaying_ReturnValue_PropertyAddress, IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlaying_FunctionAddress, "ReturnValue");
		IsPlaying_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlaying_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlaying_IsValid = IsPlaying_FunctionAddress != IntPtr.Zero && IsPlaying_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:IsPlaying", IsPlaying_IsValid);
		IsPaused_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsPaused");
		IsPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPaused_ReturnValue_PropertyAddress, IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPaused_FunctionAddress, "ReturnValue");
		IsPaused_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPaused_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPaused_IsValid = IsPaused_FunctionAddress != IntPtr.Zero && IsPaused_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:IsPaused", IsPaused_IsValid);
		GoToEndAndStop_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GoToEndAndStop");
		GoToEndAndStop_ParamsSize = NativeReflection.GetFunctionParamsSize(GoToEndAndStop_FunctionAddress);
		GoToEndAndStop_IsValid = GoToEndAndStop_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GoToEndAndStop", GoToEndAndStop_IsValid);
		GetStartTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartTime");
		GetStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartTime_ReturnValue_PropertyAddress, GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartTime_IsValid = GetStartTime_FunctionAddress != IntPtr.Zero && GetStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetStartTime", GetStartTime_IsValid);
		GetSequenceName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequenceName");
		GetSequenceName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequenceName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceName_bAddClientInfo_PropertyAddress, GetSequenceName_FunctionAddress, "bAddClientInfo");
		GetSequenceName_bAddClientInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceName_FunctionAddress, "bAddClientInfo");
		GetSequenceName_bAddClientInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceName_FunctionAddress, "bAddClientInfo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceName_ReturnValue_PropertyAddress, GetSequenceName_FunctionAddress, "ReturnValue");
		GetSequenceName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceName_FunctionAddress, "ReturnValue");
		GetSequenceName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetSequenceName_IsValid = GetSequenceName_FunctionAddress != IntPtr.Zero && GetSequenceName_bAddClientInfo_IsValid && GetSequenceName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetSequenceName", GetSequenceName_IsValid);
		GetSequence_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSequence");
		GetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequence_ReturnValue_PropertyAddress, GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequence_FunctionAddress, "ReturnValue");
		GetSequence_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequence_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSequence_IsValid = GetSequence_FunctionAddress != IntPtr.Zero && GetSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetSequence", GetSequence_IsValid);
		GetPlayRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlayRate");
		GetPlayRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayRate_ReturnValue_PropertyAddress, GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayRate_FunctionAddress, "ReturnValue");
		GetPlayRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetPlayRate_IsValid = GetPlayRate_FunctionAddress != IntPtr.Zero && GetPlayRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetPlayRate", GetPlayRate_IsValid);
		GetObjectBindings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetObjectBindings");
		GetObjectBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_InObject_PropertyAddress, GetObjectBindings_FunctionAddress, "InObject");
		GetObjectBindings_InObject_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "InObject");
		GetObjectBindings_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectBindings_ReturnValue_PropertyAddress, GetObjectBindings_FunctionAddress, "ReturnValue");
		GetObjectBindings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectBindings_FunctionAddress, "ReturnValue");
		GetObjectBindings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectBindings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetObjectBindings_IsValid = GetObjectBindings_FunctionAddress != IntPtr.Zero && GetObjectBindings_InObject_IsValid && GetObjectBindings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetObjectBindings", GetObjectBindings_IsValid);
		GetFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFrameRate");
		GetFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameRate_ReturnValue_PropertyAddress, GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameRate_FunctionAddress, "ReturnValue");
		GetFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFrameRate_IsValid = GetFrameRate_FunctionAddress != IntPtr.Zero && GetFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameRate", GetFrameRate_IsValid);
		GetFrameDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFrameDuration");
		GetFrameDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFrameDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFrameDuration_ReturnValue_PropertyAddress, GetFrameDuration_FunctionAddress, "ReturnValue");
		GetFrameDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFrameDuration_FunctionAddress, "ReturnValue");
		GetFrameDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFrameDuration_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetFrameDuration_IsValid = GetFrameDuration_FunctionAddress != IntPtr.Zero && GetFrameDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetFrameDuration", GetFrameDuration_IsValid);
		GetEndTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEndTime");
		GetEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndTime_ReturnValue_PropertyAddress, GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEndTime_IsValid = GetEndTime_FunctionAddress != IntPtr.Zero && GetEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetEndTime", GetEndTime_IsValid);
		GetDuration_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDuration");
		GetDuration_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDuration_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDuration_ReturnValue_PropertyAddress, GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDuration_FunctionAddress, "ReturnValue");
		GetDuration_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDuration_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDuration_IsValid = GetDuration_FunctionAddress != IntPtr.Zero && GetDuration_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetDuration", GetDuration_IsValid);
		GetDisableCameraCuts_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDisableCameraCuts");
		GetDisableCameraCuts_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisableCameraCuts_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisableCameraCuts_ReturnValue_PropertyAddress, GetDisableCameraCuts_FunctionAddress, "ReturnValue");
		GetDisableCameraCuts_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisableCameraCuts_FunctionAddress, "ReturnValue");
		GetDisableCameraCuts_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisableCameraCuts_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDisableCameraCuts_IsValid = GetDisableCameraCuts_FunctionAddress != IntPtr.Zero && GetDisableCameraCuts_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetDisableCameraCuts", GetDisableCameraCuts_IsValid);
		GetCurrentTime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentTime");
		GetCurrentTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentTime_ReturnValue_PropertyAddress, GetCurrentTime_FunctionAddress, "ReturnValue");
		GetCurrentTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentTime_FunctionAddress, "ReturnValue");
		GetCurrentTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentTime_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCurrentTime_IsValid = GetCurrentTime_FunctionAddress != IntPtr.Zero && GetCurrentTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetCurrentTime", GetCurrentTime_IsValid);
		GetBoundObjects_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBoundObjects");
		GetBoundObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ObjectBinding_PropertyAddress, GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ObjectBinding");
		GetBoundObjects_ObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjects_ReturnValue_PropertyAddress, GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjects_FunctionAddress, "ReturnValue");
		GetBoundObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjects_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBoundObjects_IsValid = GetBoundObjects_FunctionAddress != IntPtr.Zero && GetBoundObjects_ObjectBinding_IsValid && GetBoundObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:GetBoundObjects", GetBoundObjects_IsValid);
		ChangePlaybackDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ChangePlaybackDirection");
		ChangePlaybackDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangePlaybackDirection_FunctionAddress);
		ChangePlaybackDirection_IsValid = ChangePlaybackDirection_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieScene.MovieSceneSequencePlayer:ChangePlaybackDirection", ChangePlaybackDirection_IsValid);
	}
}
