using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayToParams", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneSequencePlayToParams
{
	private static bool Exclusive_IsValid;

	private static FFieldAddress Exclusive_PropertyAddress;

	private static int Exclusive_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieScene.MovieSceneSequencePlayToParams:bExclusive")]
	public bool Exclusive;

	private static bool FMovieSceneSequencePlayToParams_IsValid;

	private static int FMovieSceneSequencePlayToParams_StructSize;

	public FMovieSceneSequencePlayToParams Copy()
	{
		return this;
	}

	public static FMovieSceneSequencePlayToParams FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneSequencePlayToParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneSequencePlayToParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneSequencePlayToParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneSequencePlayToParams(nativeBuffer + arrayIndex * FMovieSceneSequencePlayToParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneSequencePlayToParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneSequencePlayToParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlayToParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlayToParams");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Exclusive_Offset), 0, Exclusive_PropertyAddress.Address, Exclusive);
		}
	}

	public FMovieSceneSequencePlayToParams(IntPtr nativeStruct)
	{
		if (!FMovieSceneSequencePlayToParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneSequencePlayToParams");
			Exclusive = false;
		}
		else
		{
			Exclusive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Exclusive_Offset), 0, Exclusive_PropertyAddress.Address);
		}
	}

	static FMovieSceneSequencePlayToParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneSequencePlayToParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneSequencePlayToParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneSequencePlayToParams");
		FMovieSceneSequencePlayToParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Exclusive_PropertyAddress, intPtr, "bExclusive");
		Exclusive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bExclusive");
		Exclusive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bExclusive", Classes.FBoolProperty);
		FMovieSceneSequencePlayToParams_IsValid = intPtr != IntPtr.Zero && Exclusive_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneSequencePlayToParams", FMovieSceneSequencePlayToParams_IsValid);
	}
}
