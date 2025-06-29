using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputData", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineOutputData
{
	private static bool Pipeline_IsValid;

	private static int Pipeline_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputData:Pipeline")]
	public UMoviePipeline Pipeline;

	private static bool Job_IsValid;

	private static int Job_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputData:Job")]
	public UMoviePipelineExecutorJob Job;

	private static bool Success_IsValid;

	private static FFieldAddress Success_PropertyAddress;

	private static int Success_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputData:bSuccess")]
	public bool Success;

	private static bool ShotData_IsValid;

	private static FFieldAddress ShotData_PropertyAddress;

	private static int ShotData_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineOutputData:ShotData")]
	public List<FMoviePipelineShotOutputData> ShotData;

	private static bool FMoviePipelineOutputData_IsValid;

	private static int FMoviePipelineOutputData_StructSize;

	public FMoviePipelineOutputData Copy()
	{
		FMoviePipelineOutputData result = this;
		if (ShotData != null)
		{
			result.ShotData = new List<FMoviePipelineShotOutputData>(ShotData);
		}
		return result;
	}

	public static FMoviePipelineOutputData FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineOutputData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineOutputData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineOutputData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineOutputData(nativeBuffer + arrayIndex * FMoviePipelineOutputData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineOutputData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineOutputData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputData");
			return;
		}
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(nativeStruct, Pipeline_Offset), Pipeline);
		UObjectMarshaler<UMoviePipelineExecutorJob>.ToNative(IntPtr.Add(nativeStruct, Job_Offset), Job);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Success_Offset), 0, Success_PropertyAddress.Address, Success);
		new TArrayCopyMarshaler<FMoviePipelineShotOutputData>(1, ShotData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelineShotOutputData, FMoviePipelineShotOutputData>.FromNative, CachedMarshalingDelegates<FMoviePipelineShotOutputData, FMoviePipelineShotOutputData>.ToNative).ToNative(IntPtr.Add(nativeStruct, ShotData_Offset), ShotData);
	}

	public FMoviePipelineOutputData(IntPtr nativeStruct)
	{
		if (!FMoviePipelineOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineOutputData");
			Pipeline = null;
			Job = null;
			Success = false;
			ShotData = null;
		}
		else
		{
			Pipeline = UObjectMarshaler<UMoviePipeline>.FromNative(IntPtr.Add(nativeStruct, Pipeline_Offset));
			Job = UObjectMarshaler<UMoviePipelineExecutorJob>.FromNative(IntPtr.Add(nativeStruct, Job_Offset));
			Success = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Success_Offset), 0, Success_PropertyAddress.Address);
			ShotData = new TArrayCopyMarshaler<FMoviePipelineShotOutputData>(1, ShotData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelineShotOutputData, FMoviePipelineShotOutputData>.FromNative, CachedMarshalingDelegates<FMoviePipelineShotOutputData, FMoviePipelineShotOutputData>.ToNative).FromNative(IntPtr.Add(nativeStruct, ShotData_Offset));
		}
	}

	static FMoviePipelineOutputData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineOutputData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineOutputData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineOutputData");
		FMoviePipelineOutputData_StructSize = NativeReflection.GetStructSize(intPtr);
		Pipeline_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pipeline");
		Pipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pipeline", Classes.FObjectProperty);
		Job_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Job");
		Job_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Job", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Success_PropertyAddress, intPtr, "bSuccess");
		Success_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSuccess");
		Success_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSuccess", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShotData_PropertyAddress, intPtr, "ShotData");
		ShotData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShotData");
		ShotData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShotData", Classes.FArrayProperty);
		FMoviePipelineOutputData_IsValid = intPtr != IntPtr.Zero && Pipeline_IsValid && Job_IsValid && Success_IsValid && ShotData_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineOutputData", FMoviePipelineOutputData_IsValid);
	}
}
