using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 6657)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneEventParameters", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneEventParameters
{
	private static bool FMovieSceneEventParameters_IsValid;

	private static int FMovieSceneEventParameters_StructSize;

	public FMovieSceneEventParameters Copy()
	{
		return this;
	}

	public static FMovieSceneEventParameters FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneEventParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneEventParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneEventParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneEventParameters(nativeBuffer + arrayIndex * FMovieSceneEventParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneEventParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneEventParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventParameters");
		}
	}

	public FMovieSceneEventParameters(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventParameters");
		}
	}

	static FMovieSceneEventParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneEventParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneEventParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneEventParameters");
		FMovieSceneEventParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneEventParameters_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneEventParameters", FMovieSceneEventParameters_IsValid);
	}
}
