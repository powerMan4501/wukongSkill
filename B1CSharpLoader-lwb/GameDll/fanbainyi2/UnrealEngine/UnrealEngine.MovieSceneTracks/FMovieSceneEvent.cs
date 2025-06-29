using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneEvent", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneEvent
{
	private static bool FMovieSceneEvent_IsValid;

	private static int FMovieSceneEvent_StructSize;

	public FMovieSceneEvent Copy()
	{
		return this;
	}

	public static FMovieSceneEvent FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneEvent(nativeBuffer + arrayIndex * FMovieSceneEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEvent");
		}
	}

	public FMovieSceneEvent(IntPtr nativeStruct)
	{
		if (!FMovieSceneEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEvent");
		}
	}

	static FMovieSceneEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneEvent");
		FMovieSceneEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneEvent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneEvent", FMovieSceneEvent_IsValid);
	}
}
