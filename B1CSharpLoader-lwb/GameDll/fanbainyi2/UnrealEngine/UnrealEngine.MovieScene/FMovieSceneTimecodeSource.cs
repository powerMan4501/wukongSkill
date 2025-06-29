using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneTimecodeSource", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneTimecodeSource
{
	private static bool Timecode_IsValid;

	private static int Timecode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneTimecodeSource:Timecode")]
	public FTimecode Timecode;

	private static bool FMovieSceneTimecodeSource_IsValid;

	private static int FMovieSceneTimecodeSource_StructSize;

	public FMovieSceneTimecodeSource Copy()
	{
		return this;
	}

	public static FMovieSceneTimecodeSource FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneTimecodeSource(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneTimecodeSource value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneTimecodeSource FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneTimecodeSource(nativeBuffer + arrayIndex * FMovieSceneTimecodeSource_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneTimecodeSource value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneTimecodeSource_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneTimecodeSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneTimecodeSource");
		}
		else
		{
			FTimecode.ToNative(IntPtr.Add(nativeStruct, Timecode_Offset), Timecode);
		}
	}

	public FMovieSceneTimecodeSource(IntPtr nativeStruct)
	{
		if (!FMovieSceneTimecodeSource_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneTimecodeSource");
			Timecode = default(FTimecode);
		}
		else
		{
			Timecode = FTimecode.FromNative(IntPtr.Add(nativeStruct, Timecode_Offset));
		}
	}

	static FMovieSceneTimecodeSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneTimecodeSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneTimecodeSource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneTimecodeSource");
		FMovieSceneTimecodeSource_StructSize = NativeReflection.GetStructSize(intPtr);
		Timecode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Timecode");
		Timecode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Timecode", Classes.FStructProperty);
		FMovieSceneTimecodeSource_IsValid = intPtr != IntPtr.Zero && Timecode_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneTimecodeSource", FMovieSceneTimecodeSource_IsValid);
	}
}
