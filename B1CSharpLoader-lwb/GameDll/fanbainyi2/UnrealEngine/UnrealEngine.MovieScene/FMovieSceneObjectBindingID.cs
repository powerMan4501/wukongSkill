using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 266241)]
[BlueprintType]
[UMetaPath("/Script/MovieScene.MovieSceneObjectBindingID", "MovieScene", UnrealModuleType.Engine)]
public struct FMovieSceneObjectBindingID
{
	private static bool FMovieSceneObjectBindingID_IsValid;

	private static int FMovieSceneObjectBindingID_StructSize;

	public FMovieSceneObjectBindingID Copy()
	{
		return this;
	}

	public static FMovieSceneObjectBindingID FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneObjectBindingID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneObjectBindingID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneObjectBindingID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneObjectBindingID(nativeBuffer + arrayIndex * FMovieSceneObjectBindingID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneObjectBindingID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneObjectBindingID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneObjectBindingID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneObjectBindingID");
		}
	}

	public FMovieSceneObjectBindingID(IntPtr nativeStruct)
	{
		if (!FMovieSceneObjectBindingID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieScene.MovieSceneObjectBindingID");
		}
	}

	static FMovieSceneObjectBindingID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneObjectBindingID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneObjectBindingID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieScene.MovieSceneObjectBindingID");
		FMovieSceneObjectBindingID_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneObjectBindingID_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieScene.MovieSceneObjectBindingID", FMovieSceneObjectBindingID_IsValid);
	}
}
