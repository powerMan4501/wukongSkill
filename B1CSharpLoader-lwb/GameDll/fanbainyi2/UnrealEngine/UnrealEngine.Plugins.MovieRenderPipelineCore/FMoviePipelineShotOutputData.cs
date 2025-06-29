using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineShotOutputData
{
	private static bool Shot_IsValid;

	private static int Shot_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData:Shot")]
	public TWeakObject<UMoviePipelineExecutorShot> Shot;

	private static bool RenderPassData_IsValid;

	private static FFieldAddress RenderPassData_PropertyAddress;

	private static int RenderPassData_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData:RenderPassData")]
	public Dictionary<FMoviePipelinePassIdentifier, FMoviePipelineRenderPassOutputData> RenderPassData;

	private static bool FMoviePipelineShotOutputData_IsValid;

	private static int FMoviePipelineShotOutputData_StructSize;

	public FMoviePipelineShotOutputData Copy()
	{
		FMoviePipelineShotOutputData result = this;
		if (RenderPassData != null)
		{
			result.RenderPassData = new Dictionary<FMoviePipelinePassIdentifier, FMoviePipelineRenderPassOutputData>(RenderPassData);
		}
		return result;
	}

	public static FMoviePipelineShotOutputData FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineShotOutputData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineShotOutputData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineShotOutputData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineShotOutputData(nativeBuffer + arrayIndex * FMoviePipelineShotOutputData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineShotOutputData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineShotOutputData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineShotOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData");
			return;
		}
		TWeakObjectMarshaler<UMoviePipelineExecutorShot>.ToNative(IntPtr.Add(nativeStruct, Shot_Offset), Shot);
		new TMapCopyMarshaler<FMoviePipelinePassIdentifier, FMoviePipelineRenderPassOutputData>(1, RenderPassData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelinePassIdentifier, FMoviePipelinePassIdentifier>.FromNative, CachedMarshalingDelegates<FMoviePipelinePassIdentifier, FMoviePipelinePassIdentifier>.ToNative, CachedMarshalingDelegates<FMoviePipelineRenderPassOutputData, FMoviePipelineRenderPassOutputData>.FromNative, CachedMarshalingDelegates<FMoviePipelineRenderPassOutputData, FMoviePipelineRenderPassOutputData>.ToNative).ToNative(IntPtr.Add(nativeStruct, RenderPassData_Offset), RenderPassData);
	}

	public FMoviePipelineShotOutputData(IntPtr nativeStruct)
	{
		if (!FMoviePipelineShotOutputData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData");
			Shot = default(TWeakObject<UMoviePipelineExecutorShot>);
			RenderPassData = null;
		}
		else
		{
			Shot = TWeakObjectMarshaler<UMoviePipelineExecutorShot>.FromNative(IntPtr.Add(nativeStruct, Shot_Offset));
			RenderPassData = new TMapCopyMarshaler<FMoviePipelinePassIdentifier, FMoviePipelineRenderPassOutputData>(1, RenderPassData_PropertyAddress, CachedMarshalingDelegates<FMoviePipelinePassIdentifier, FMoviePipelinePassIdentifier>.FromNative, CachedMarshalingDelegates<FMoviePipelinePassIdentifier, FMoviePipelinePassIdentifier>.ToNative, CachedMarshalingDelegates<FMoviePipelineRenderPassOutputData, FMoviePipelineRenderPassOutputData>.FromNative, CachedMarshalingDelegates<FMoviePipelineRenderPassOutputData, FMoviePipelineRenderPassOutputData>.ToNative).FromNative(IntPtr.Add(nativeStruct, RenderPassData_Offset));
		}
	}

	static FMoviePipelineShotOutputData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineShotOutputData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineShotOutputData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData");
		FMoviePipelineShotOutputData_StructSize = NativeReflection.GetStructSize(intPtr);
		Shot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shot");
		Shot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shot", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenderPassData_PropertyAddress, intPtr, "RenderPassData");
		RenderPassData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderPassData");
		RenderPassData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderPassData", Classes.FMapProperty);
		FMoviePipelineShotOutputData_IsValid = intPtr != IntPtr.Zero && Shot_IsValid && RenderPassData_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineShotOutputData", FMoviePipelineShotOutputData_IsValid);
	}
}
