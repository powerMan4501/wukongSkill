using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LevelSequenceEditor;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/LevelSequenceEditor.MovieSceneScriptingParams", "LevelSequenceEditor", UnrealModuleType.EnginePlugin)]
public struct FMovieSceneScriptingParams
{
	private static bool FMovieSceneScriptingParams_IsValid;

	private static int FMovieSceneScriptingParams_StructSize;

	public FMovieSceneScriptingParams Copy()
	{
		return this;
	}

	public static FMovieSceneScriptingParams FromNative(IntPtr nativeBuffer)
	{
		return new FMovieSceneScriptingParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovieSceneScriptingParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovieSceneScriptingParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovieSceneScriptingParams(nativeBuffer + arrayIndex * FMovieSceneScriptingParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovieSceneScriptingParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovieSceneScriptingParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovieSceneScriptingParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequenceEditor.MovieSceneScriptingParams");
		}
	}

	public FMovieSceneScriptingParams(IntPtr nativeStruct)
	{
		if (!FMovieSceneScriptingParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequenceEditor.MovieSceneScriptingParams");
		}
	}

	static FMovieSceneScriptingParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovieSceneScriptingParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovieSceneScriptingParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LevelSequenceEditor.MovieSceneScriptingParams");
		FMovieSceneScriptingParams_StructSize = NativeReflection.GetStructSize(intPtr);
		FMovieSceneScriptingParams_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/LevelSequenceEditor.MovieSceneScriptingParams", FMovieSceneScriptingParams_IsValid);
	}
}
