using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 528385)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequenceLoopCount", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneSequenceLoopCount
{
	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequenceLoopCount:Value")]
	public int Value;

	private static bool FMovieSceneSequenceLoopCount_IsValid;

	private static int FMovieSceneSequenceLoopCount_StructSize;

	public FMovieSceneSequenceLoopCount Copy()
	{
		return this;
	}

	public static FMovieSceneSequenceLoopCount FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSequenceLoopCount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSequenceLoopCount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSequenceLoopCount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSequenceLoopCount(nativeBuffer + arrayIndex * FMovieSceneSequenceLoopCount_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSequenceLoopCount value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSequenceLoopCount_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequenceLoopCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequenceLoopCount");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		}
	}

	public FMovieSceneSequenceLoopCount(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequenceLoopCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequenceLoopCount");
			Value = 0;
		}
		else
		{
			Value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FMovieSceneSequenceLoopCount()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSequenceLoopCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSequenceLoopCount));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneSequenceLoopCount");
		FMovieSceneSequenceLoopCount_StructSize = NativeReflection.GetStructSize(intPtr);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FIntProperty);
		FMovieSceneSequenceLoopCount_IsValid = intPtr != IntPtr.Zero && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneSequenceLoopCount", FMovieSceneSequenceLoopCount_IsValid);
	}
}
