using System;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MovieGraphPlaySettings")]
public struct FMovieGraphPlaySettings
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MovieGraphPlaySettings:PlaybackSettings")]
	public FMovieSceneSequencePlaybackSettings PlaybackSettings;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MovieGraphPlaySettings:CameraSettings")]
	public FLevelSequenceCameraSettings CameraSettings;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MovieGraphPlaySettings:bUsePlayerCamera")]
	public bool bUsePlayerCamera;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MovieGraphPlaySettings:bTriggerMonsterGoHome")]
	public bool bTriggerMonsterGoHome;

	private static int MovieGraphPlaySettings_StructSize;

	private static int MovieGraphPlaySettings_IsValid;

	private static bool PlaybackSettings_IsValid;

	private static int PlaybackSettings_Offset;

	private static bool CameraSettings_IsValid;

	private static int CameraSettings_Offset;

	private static bool bUsePlayerCamera_IsValid;

	private static int bUsePlayerCamera_Offset;

	private static FFieldAddress bUsePlayerCamera_PropertyAddress;

	private static bool bTriggerMonsterGoHome_IsValid;

	private static int bTriggerMonsterGoHome_Offset;

	private static FFieldAddress bTriggerMonsterGoHome_PropertyAddress;

	public FMovieGraphPlaySettings Copy()
	{
		return this;
	}

	public static FMovieGraphPlaySettings FromNative(IntPtr nativeBuffer)
	{
		return new FMovieGraphPlaySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieGraphPlaySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieGraphPlaySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieGraphPlaySettings(IntPtr.Add(nativeBuffer, arrayIndex * MovieGraphPlaySettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieGraphPlaySettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MovieGraphPlaySettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MovieGraphPlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieGraphPlaySettings");
			return;
		}
		FMovieSceneSequencePlaybackSettings.ToNative(IntPtr.Add(nativeStruct, PlaybackSettings_Offset), PlaybackSettings);
		FLevelSequenceCameraSettings.ToNative(IntPtr.Add(nativeStruct, CameraSettings_Offset), CameraSettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address, bUsePlayerCamera);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address, bTriggerMonsterGoHome);
	}

	public FMovieGraphPlaySettings(IntPtr nativeStruct)
	{
		if (MovieGraphPlaySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MovieGraphPlaySettings");
			PlaybackSettings = default(FMovieSceneSequencePlaybackSettings);
			CameraSettings = default(FLevelSequenceCameraSettings);
			bUsePlayerCamera = false;
			bTriggerMonsterGoHome = false;
		}
		else
		{
			PlaybackSettings = FMovieSceneSequencePlaybackSettings.FromNative(IntPtr.Add(nativeStruct, PlaybackSettings_Offset));
			CameraSettings = FLevelSequenceCameraSettings.FromNative(IntPtr.Add(nativeStruct, CameraSettings_Offset));
			bUsePlayerCamera = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address);
			bTriggerMonsterGoHome = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MovieGraphPlaySettings");
		MovieGraphPlaySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PlaybackSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlaybackSettings");
		PlaybackSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlaybackSettings", Classes.FStructProperty);
		CameraSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraSettings");
		CameraSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraSettings", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUsePlayerCamera_PropertyAddress, intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUsePlayerCamera", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bTriggerMonsterGoHome_PropertyAddress, intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerMonsterGoHome", Classes.FBoolProperty);
		MovieGraphPlaySettings_IsValid = ((intPtr != IntPtr.Zero && PlaybackSettings_IsValid && CameraSettings_IsValid && bUsePlayerCamera_IsValid && bTriggerMonsterGoHome_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MovieGraphPlaySettings", (byte)MovieGraphPlaySettings_IsValid != 0);
	}

	static FMovieGraphPlaySettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMovieGraphPlaySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieGraphPlaySettings));
	}
}
