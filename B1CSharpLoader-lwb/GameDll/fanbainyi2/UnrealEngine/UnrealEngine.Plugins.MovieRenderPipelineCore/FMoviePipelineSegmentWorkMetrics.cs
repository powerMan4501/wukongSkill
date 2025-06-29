using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineSegmentWorkMetrics
{
	private static bool SegmentName_IsValid;

	private static int SegmentName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:SegmentName")]
	public string SegmentName;

	private static bool OutputFrameIndex_IsValid;

	private static int OutputFrameIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:OutputFrameIndex")]
	public int OutputFrameIndex;

	private static bool TotalOutputFrameCount_IsValid;

	private static int TotalOutputFrameCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:TotalOutputFrameCount")]
	public int TotalOutputFrameCount;

	private static bool OutputSubSampleIndex_IsValid;

	private static int OutputSubSampleIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:OutputSubSampleIndex")]
	public int OutputSubSampleIndex;

	private static bool TotalSubSampleCount_IsValid;

	private static int TotalSubSampleCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:TotalSubSampleCount")]
	public int TotalSubSampleCount;

	private static bool EngineWarmUpFrameIndex_IsValid;

	private static int EngineWarmUpFrameIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:EngineWarmUpFrameIndex")]
	public int EngineWarmUpFrameIndex;

	private static bool TotalEngineWarmUpFrameCount_IsValid;

	private static int TotalEngineWarmUpFrameCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics:TotalEngineWarmUpFrameCount")]
	public int TotalEngineWarmUpFrameCount;

	private static bool FMoviePipelineSegmentWorkMetrics_IsValid;

	private static int FMoviePipelineSegmentWorkMetrics_StructSize;

	public FMoviePipelineSegmentWorkMetrics Copy()
	{
		return this;
	}

	public static FMoviePipelineSegmentWorkMetrics FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineSegmentWorkMetrics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineSegmentWorkMetrics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineSegmentWorkMetrics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineSegmentWorkMetrics(nativeBuffer + arrayIndex * FMoviePipelineSegmentWorkMetrics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineSegmentWorkMetrics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineSegmentWorkMetrics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineSegmentWorkMetrics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SegmentName_Offset), SegmentName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutputFrameIndex_Offset), OutputFrameIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalOutputFrameCount_Offset), TotalOutputFrameCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutputSubSampleIndex_Offset), OutputSubSampleIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalSubSampleCount_Offset), TotalSubSampleCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EngineWarmUpFrameIndex_Offset), EngineWarmUpFrameIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TotalEngineWarmUpFrameCount_Offset), TotalEngineWarmUpFrameCount);
	}

	public FMoviePipelineSegmentWorkMetrics(IntPtr nativeStruct)
	{
		if (!FMoviePipelineSegmentWorkMetrics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics");
			SegmentName = FStringMarshaler.DefaultString;
			OutputFrameIndex = 0;
			TotalOutputFrameCount = 0;
			OutputSubSampleIndex = 0;
			TotalSubSampleCount = 0;
			EngineWarmUpFrameIndex = 0;
			TotalEngineWarmUpFrameCount = 0;
		}
		else
		{
			SegmentName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SegmentName_Offset));
			OutputFrameIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutputFrameIndex_Offset));
			TotalOutputFrameCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalOutputFrameCount_Offset));
			OutputSubSampleIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutputSubSampleIndex_Offset));
			TotalSubSampleCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalSubSampleCount_Offset));
			EngineWarmUpFrameIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EngineWarmUpFrameIndex_Offset));
			TotalEngineWarmUpFrameCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TotalEngineWarmUpFrameCount_Offset));
		}
	}

	static FMoviePipelineSegmentWorkMetrics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineSegmentWorkMetrics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineSegmentWorkMetrics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics");
		FMoviePipelineSegmentWorkMetrics_StructSize = NativeReflection.GetStructSize(intPtr);
		SegmentName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SegmentName");
		SegmentName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SegmentName", Classes.FStrProperty);
		OutputFrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputFrameIndex");
		OutputFrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputFrameIndex", Classes.FIntProperty);
		TotalOutputFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalOutputFrameCount");
		TotalOutputFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalOutputFrameCount", Classes.FIntProperty);
		OutputSubSampleIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputSubSampleIndex");
		OutputSubSampleIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputSubSampleIndex", Classes.FIntProperty);
		TotalSubSampleCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalSubSampleCount");
		TotalSubSampleCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalSubSampleCount", Classes.FIntProperty);
		EngineWarmUpFrameIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EngineWarmUpFrameIndex");
		EngineWarmUpFrameIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EngineWarmUpFrameIndex", Classes.FIntProperty);
		TotalEngineWarmUpFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TotalEngineWarmUpFrameCount");
		TotalEngineWarmUpFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TotalEngineWarmUpFrameCount", Classes.FIntProperty);
		FMoviePipelineSegmentWorkMetrics_IsValid = intPtr != IntPtr.Zero && SegmentName_IsValid && OutputFrameIndex_IsValid && TotalOutputFrameCount_IsValid && OutputSubSampleIndex_IsValid && TotalSubSampleCount_IsValid && EngineWarmUpFrameIndex_IsValid && TotalEngineWarmUpFrameCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSegmentWorkMetrics", FMoviePipelineSegmentWorkMetrics_IsValid);
	}
}
