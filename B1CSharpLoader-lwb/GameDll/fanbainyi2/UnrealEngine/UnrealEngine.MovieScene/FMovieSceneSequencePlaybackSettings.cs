using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 528385)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneSequencePlaybackSettings
{
	private static bool AutoPlay_IsValid;

	private static FFieldAddress AutoPlay_PropertyAddress;

	private static int AutoPlay_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bAutoPlay")]
	public bool AutoPlay;

	private static bool LoopCount_IsValid;

	private static int LoopCount_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:LoopCount")]
	public FMovieSceneSequenceLoopCount LoopCount;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:PlayRate")]
	public float PlayRate;

	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:StartTime")]
	public float StartTime;

	private static bool RandomStartTime_IsValid;

	private static FFieldAddress RandomStartTime_PropertyAddress;

	private static int RandomStartTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bRandomStartTime")]
	public bool RandomStartTime;

	private static bool RestoreState_IsValid;

	private static FFieldAddress RestoreState_PropertyAddress;

	private static int RestoreState_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bRestoreState")]
	public bool RestoreState;

	private static bool DisableMovementInput_IsValid;

	private static FFieldAddress DisableMovementInput_PropertyAddress;

	private static int DisableMovementInput_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableMovementInput")]
	public bool DisableMovementInput;

	private static bool DisableLookAtInput_IsValid;

	private static FFieldAddress DisableLookAtInput_PropertyAddress;

	private static int DisableLookAtInput_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableLookAtInput")]
	public bool DisableLookAtInput;

	private static bool HidePlayer_IsValid;

	private static FFieldAddress HidePlayer_PropertyAddress;

	private static int HidePlayer_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bHidePlayer")]
	public bool HidePlayer;

	private static bool HideHud_IsValid;

	private static FFieldAddress HideHud_PropertyAddress;

	private static int HideHud_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bHideHud")]
	public bool HideHud;

	private static bool DisableCameraCuts_IsValid;

	private static FFieldAddress DisableCameraCuts_PropertyAddress;

	private static int DisableCameraCuts_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bDisableCameraCuts")]
	public bool DisableCameraCuts;

	private static bool PauseAtEnd_IsValid;

	private static FFieldAddress PauseAtEnd_PropertyAddress;

	private static int PauseAtEnd_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlaybackSettings:bPauseAtEnd")]
	public bool PauseAtEnd;

	private static bool FMovieSceneSequencePlaybackSettings_IsValid;

	private static int FMovieSceneSequencePlaybackSettings_StructSize;

	public FMovieSceneSequencePlaybackSettings Copy()
	{
		return this;
	}

	public static FMovieSceneSequencePlaybackSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSequencePlaybackSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSequencePlaybackSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSequencePlaybackSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSequencePlaybackSettings(nativeBuffer + arrayIndex * FMovieSceneSequencePlaybackSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSequencePlaybackSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSequencePlaybackSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlaybackSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlaybackSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AutoPlay_Offset), 0, AutoPlay_PropertyAddress.Address, AutoPlay);
		FMovieSceneSequenceLoopCount.ToNative(IntPtr.Add(nativeStruct, LoopCount_Offset), LoopCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayRate_Offset), PlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartTime_Offset), StartTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RandomStartTime_Offset), 0, RandomStartTime_PropertyAddress.Address, RandomStartTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RestoreState_Offset), 0, RestoreState_PropertyAddress.Address, RestoreState);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableMovementInput_Offset), 0, DisableMovementInput_PropertyAddress.Address, DisableMovementInput);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableLookAtInput_Offset), 0, DisableLookAtInput_PropertyAddress.Address, DisableLookAtInput);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HidePlayer_Offset), 0, HidePlayer_PropertyAddress.Address, HidePlayer);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HideHud_Offset), 0, HideHud_PropertyAddress.Address, HideHud);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableCameraCuts_Offset), 0, DisableCameraCuts_PropertyAddress.Address, DisableCameraCuts);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PauseAtEnd_Offset), 0, PauseAtEnd_PropertyAddress.Address, PauseAtEnd);
	}

	public FMovieSceneSequencePlaybackSettings(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlaybackSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlaybackSettings");
			AutoPlay = false;
			LoopCount = default(FMovieSceneSequenceLoopCount);
			PlayRate = 0f;
			StartTime = 0f;
			RandomStartTime = false;
			RestoreState = false;
			DisableMovementInput = false;
			DisableLookAtInput = false;
			HidePlayer = false;
			HideHud = false;
			DisableCameraCuts = false;
			PauseAtEnd = false;
		}
		else
		{
			AutoPlay = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AutoPlay_Offset), 0, AutoPlay_PropertyAddress.Address);
			LoopCount = FMovieSceneSequenceLoopCount.FromNative(IntPtr.Add(nativeStruct, LoopCount_Offset));
			PlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayRate_Offset));
			StartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartTime_Offset));
			RandomStartTime = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RandomStartTime_Offset), 0, RandomStartTime_PropertyAddress.Address);
			RestoreState = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RestoreState_Offset), 0, RestoreState_PropertyAddress.Address);
			DisableMovementInput = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableMovementInput_Offset), 0, DisableMovementInput_PropertyAddress.Address);
			DisableLookAtInput = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableLookAtInput_Offset), 0, DisableLookAtInput_PropertyAddress.Address);
			HidePlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HidePlayer_Offset), 0, HidePlayer_PropertyAddress.Address);
			HideHud = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HideHud_Offset), 0, HideHud_PropertyAddress.Address);
			DisableCameraCuts = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableCameraCuts_Offset), 0, DisableCameraCuts_PropertyAddress.Address);
			PauseAtEnd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PauseAtEnd_Offset), 0, PauseAtEnd_PropertyAddress.Address);
		}
	}

	static FMovieSceneSequencePlaybackSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSequencePlaybackSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSequencePlaybackSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneSequencePlaybackSettings");
		FMovieSceneSequencePlaybackSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref AutoPlay_PropertyAddress, intPtr, "bAutoPlay");
		AutoPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoPlay");
		AutoPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoPlay", Classes.FBoolProperty);
		LoopCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoopCount");
		LoopCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoopCount", Classes.FStructProperty);
		PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		StartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomStartTime_PropertyAddress, intPtr, "bRandomStartTime");
		RandomStartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRandomStartTime");
		RandomStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRandomStartTime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RestoreState_PropertyAddress, intPtr, "bRestoreState");
		RestoreState_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRestoreState");
		RestoreState_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRestoreState", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableMovementInput_PropertyAddress, intPtr, "bDisableMovementInput");
		DisableMovementInput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableMovementInput");
		DisableMovementInput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableMovementInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableLookAtInput_PropertyAddress, intPtr, "bDisableLookAtInput");
		DisableLookAtInput_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableLookAtInput");
		DisableLookAtInput_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableLookAtInput", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HidePlayer_PropertyAddress, intPtr, "bHidePlayer");
		HidePlayer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHidePlayer");
		HidePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHidePlayer", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HideHud_PropertyAddress, intPtr, "bHideHud");
		HideHud_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHideHud");
		HideHud_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHideHud", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableCameraCuts_PropertyAddress, intPtr, "bDisableCameraCuts");
		DisableCameraCuts_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableCameraCuts");
		DisableCameraCuts_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableCameraCuts", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PauseAtEnd_PropertyAddress, intPtr, "bPauseAtEnd");
		PauseAtEnd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPauseAtEnd");
		PauseAtEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPauseAtEnd", Classes.FBoolProperty);
		FMovieSceneSequencePlaybackSettings_IsValid = intPtr != IntPtr.Zero && AutoPlay_IsValid && LoopCount_IsValid && PlayRate_IsValid && StartTime_IsValid && RandomStartTime_IsValid && RestoreState_IsValid && DisableMovementInput_IsValid && DisableLookAtInput_IsValid && HidePlayer_IsValid && HideHud_IsValid && DisableCameraCuts_IsValid && PauseAtEnd_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneSequencePlaybackSettings", FMovieSceneSequencePlaybackSettings_IsValid);
	}
}
