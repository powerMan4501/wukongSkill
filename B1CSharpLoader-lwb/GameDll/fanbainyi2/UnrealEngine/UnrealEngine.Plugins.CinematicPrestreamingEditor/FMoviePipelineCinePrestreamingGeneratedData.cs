using System;
using UnrealEngine.MovieScene;
using UnrealEngine.Plugins.CinematicPrestreaming;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CinematicPrestreamingEditor;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData", "CinematicPrestreamingEditor", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineCinePrestreamingGeneratedData
{
	private static bool StreamingData_IsValid;

	private static int StreamingData_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData:StreamingData")]
	public UCinePrestreamingData StreamingData;

	private static bool MovieScene_IsValid;

	private static int MovieScene_Offset;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData:MovieScene")]
	public UMovieScene MovieScene;

	private static bool PackagePath_IsValid;

	private static int PackagePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData:PackagePath")]
	public string PackagePath;

	private static bool AssetName_IsValid;

	private static int AssetName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData:AssetName")]
	public string AssetName;

	private static bool FMoviePipelineCinePrestreamingGeneratedData_IsValid;

	private static int FMoviePipelineCinePrestreamingGeneratedData_StructSize;

	public FMoviePipelineCinePrestreamingGeneratedData Copy()
	{
		return this;
	}

	public static FMoviePipelineCinePrestreamingGeneratedData FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineCinePrestreamingGeneratedData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineCinePrestreamingGeneratedData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineCinePrestreamingGeneratedData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineCinePrestreamingGeneratedData(nativeBuffer + arrayIndex * FMoviePipelineCinePrestreamingGeneratedData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineCinePrestreamingGeneratedData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineCinePrestreamingGeneratedData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineCinePrestreamingGeneratedData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData");
			return;
		}
		UObjectMarshaler<UCinePrestreamingData>.ToNative(IntPtr.Add(nativeStruct, StreamingData_Offset), StreamingData);
		UObjectMarshaler<UMovieScene>.ToNative(IntPtr.Add(nativeStruct, MovieScene_Offset), MovieScene);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, PackagePath_Offset), PackagePath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AssetName_Offset), AssetName);
	}

	public FMoviePipelineCinePrestreamingGeneratedData(IntPtr nativeStruct)
	{
		if (!FMoviePipelineCinePrestreamingGeneratedData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData");
			StreamingData = null;
			MovieScene = null;
			PackagePath = FStringMarshaler.DefaultString;
			AssetName = FStringMarshaler.DefaultString;
		}
		else
		{
			StreamingData = UObjectMarshaler<UCinePrestreamingData>.FromNative(IntPtr.Add(nativeStruct, StreamingData_Offset));
			MovieScene = UObjectMarshaler<UMovieScene>.FromNative(IntPtr.Add(nativeStruct, MovieScene_Offset));
			PackagePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, PackagePath_Offset));
			AssetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AssetName_Offset));
		}
	}

	static FMoviePipelineCinePrestreamingGeneratedData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineCinePrestreamingGeneratedData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineCinePrestreamingGeneratedData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData");
		FMoviePipelineCinePrestreamingGeneratedData_StructSize = NativeReflection.GetStructSize(intPtr);
		StreamingData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingData");
		StreamingData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingData", Classes.FObjectProperty);
		MovieScene_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MovieScene");
		MovieScene_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MovieScene", Classes.FObjectProperty);
		PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PackagePath");
		PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PackagePath", Classes.FStrProperty);
		AssetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetName");
		AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetName", Classes.FStrProperty);
		FMoviePipelineCinePrestreamingGeneratedData_IsValid = intPtr != IntPtr.Zero && StreamingData_IsValid && MovieScene_IsValid && PackagePath_IsValid && AssetName_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicPrestreamingEditor.MoviePipelineCinePrestreamingGeneratedData", FMoviePipelineCinePrestreamingGeneratedData_IsValid);
	}
}
