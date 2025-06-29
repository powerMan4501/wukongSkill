using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineFormatArgs
{
	private static bool FilenameArguments_IsValid;

	private static FFieldAddress FilenameArguments_PropertyAddress;

	private static int FilenameArguments_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs:FilenameArguments")]
	public Dictionary<string, string> FilenameArguments;

	private static bool FileMetadata_IsValid;

	private static FFieldAddress FileMetadata_PropertyAddress;

	private static int FileMetadata_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs:FileMetadata")]
	public Dictionary<string, string> FileMetadata;

	private static bool InJob_IsValid;

	private static int InJob_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs:InJob")]
	public UMoviePipelineExecutorJob InJob;

	private static bool FMoviePipelineFormatArgs_IsValid;

	private static int FMoviePipelineFormatArgs_StructSize;

	public FMoviePipelineFormatArgs Copy()
	{
		FMoviePipelineFormatArgs result = this;
		if (FilenameArguments != null)
		{
			result.FilenameArguments = new Dictionary<string, string>(FilenameArguments);
		}
		if (FileMetadata != null)
		{
			result.FileMetadata = new Dictionary<string, string>(FileMetadata);
		}
		return result;
	}

	public static FMoviePipelineFormatArgs FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineFormatArgs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineFormatArgs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineFormatArgs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineFormatArgs(nativeBuffer + arrayIndex * FMoviePipelineFormatArgs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineFormatArgs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineFormatArgs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineFormatArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs");
			return;
		}
		new TMapCopyMarshaler<string, string>(1, FilenameArguments_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilenameArguments_Offset), FilenameArguments);
		new TMapCopyMarshaler<string, string>(1, FileMetadata_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, FileMetadata_Offset), FileMetadata);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(nativeStruct, InJob_Offset), InJob);
	}

	public FMoviePipelineFormatArgs(IntPtr nativeStruct)
	{
		if (!FMoviePipelineFormatArgs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs");
			FilenameArguments = null;
			FileMetadata = null;
			InJob = null;
		}
		else
		{
			FilenameArguments = new TMapCopyMarshaler<string, string>(1, FilenameArguments_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilenameArguments_Offset));
			FileMetadata = new TMapCopyMarshaler<string, string>(1, FileMetadata_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, FileMetadata_Offset));
			InJob = UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(nativeStruct, InJob_Offset));
		}
	}

	static FMoviePipelineFormatArgs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineFormatArgs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineFormatArgs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs");
		FMoviePipelineFormatArgs_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilenameArguments_PropertyAddress, intPtr, "FilenameArguments");
		FilenameArguments_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilenameArguments");
		FilenameArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilenameArguments", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref FileMetadata_PropertyAddress, intPtr, "FileMetadata");
		FileMetadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FileMetadata");
		FileMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FileMetadata", Classes.FMapProperty);
		InJob_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InJob");
		InJob_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InJob", Classes.FObjectProperty);
		FMoviePipelineFormatArgs_IsValid = intPtr != IntPtr.Zero && FilenameArguments_IsValid && FileMetadata_IsValid && InJob_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineFormatArgs", FMoviePipelineFormatArgs_IsValid);
	}
}
