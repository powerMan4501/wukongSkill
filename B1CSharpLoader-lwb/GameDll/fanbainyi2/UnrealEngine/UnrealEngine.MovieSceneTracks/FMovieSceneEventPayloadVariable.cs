using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable", "MovieSceneTracks", UnrealModuleType.Engine)]
public struct FMovieSceneEventPayloadVariable
{
	private static bool FMovieSceneEventPayloadVariable_IsValid;

	private static int FMovieSceneEventPayloadVariable_StructSize;

	public FMovieSceneEventPayloadVariable Copy()
	{
		return this;
	}

	public static FMovieSceneEventPayloadVariable FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneEventPayloadVariable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneEventPayloadVariable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneEventPayloadVariable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneEventPayloadVariable(nativeBuffer + arrayIndex * FMovieSceneEventPayloadVariable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneEventPayloadVariable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneEventPayloadVariable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventPayloadVariable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable");
		}
	}

	public FMovieSceneEventPayloadVariable(IntPtr nativeStruct)
	{
		if (!FMovieSceneEventPayloadVariable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable");
		}
	}

	static FMovieSceneEventPayloadVariable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneEventPayloadVariable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneEventPayloadVariable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable");
		FMovieSceneEventPayloadVariable_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneEventPayloadVariable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieSceneTracks.MovieSceneEventPayloadVariable", FMovieSceneEventPayloadVariable_IsValid);
	}
}
