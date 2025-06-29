using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineRenderPassOutputData
{
	private static bool FilePaths_IsValid;

	private static FFieldAddress FilePaths_PropertyAddress;

	private static int FilePaths_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData:FilePaths")]
	public List<string> FilePaths;

	private static bool FMoviePipelineRenderPassOutputData_IsValid;

	private static int FMoviePipelineRenderPassOutputData_StructSize;

	public FMoviePipelineRenderPassOutputData Copy()
	{
		FMoviePipelineRenderPassOutputData result = this;
		if (FilePaths != null)
		{
			result.FilePaths = new List<string>(FilePaths);
		}
		return result;
	}

	public static FMoviePipelineRenderPassOutputData FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineRenderPassOutputData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineRenderPassOutputData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineRenderPassOutputData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineRenderPassOutputData(nativeBuffer + arrayIndex * FMoviePipelineRenderPassOutputData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineRenderPassOutputData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineRenderPassOutputData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineRenderPassOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData");
		}
		else
		{
			new TArrayCopyMarshaler<string>(1, FilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, FilePaths_Offset), FilePaths);
		}
	}

	public FMoviePipelineRenderPassOutputData(IntPtr nativeStruct)
	{
		if (!FMoviePipelineRenderPassOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData");
			FilePaths = null;
		}
		else
		{
			FilePaths = new TArrayCopyMarshaler<string>(1, FilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, FilePaths_Offset));
		}
	}

	static FMoviePipelineRenderPassOutputData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineRenderPassOutputData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineRenderPassOutputData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData");
		FMoviePipelineRenderPassOutputData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilePaths_PropertyAddress, intPtr, "FilePaths");
		FilePaths_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilePaths");
		FilePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilePaths", Classes.FArrayProperty);
		FMoviePipelineRenderPassOutputData_IsValid = intPtr != IntPtr.Zero && FilePaths_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineRenderPassOutputData", FMoviePipelineRenderPassOutputData_IsValid);
	}
}
