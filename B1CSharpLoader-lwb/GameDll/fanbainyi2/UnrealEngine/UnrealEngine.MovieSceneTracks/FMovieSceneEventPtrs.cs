using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneEventPtrs", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneEventPtrs
{
	private static bool FMovieSceneEventPtrs_IsValid;

	private static int FMovieSceneEventPtrs_StructSize;

	public FMovieSceneEventPtrs Copy()
	{
		return this;
	}

	public static FMovieSceneEventPtrs FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneEventPtrs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneEventPtrs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneEventPtrs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneEventPtrs(nativeBuffer + arrayIndex * FMovieSceneEventPtrs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneEventPtrs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneEventPtrs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventPtrs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventPtrs");
		}
	}

	public FMovieSceneEventPtrs(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventPtrs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventPtrs");
		}
	}

	static FMovieSceneEventPtrs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneEventPtrs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneEventPtrs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneEventPtrs");
		FMovieSceneEventPtrs_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneEventPtrs_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneEventPtrs", FMovieSceneEventPtrs_IsValid);
	}
}
