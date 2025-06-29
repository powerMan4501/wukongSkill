using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineCameraCutInfo", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public struct FMoviePipelineCameraCutInfo
{
	private static bool FMoviePipelineCameraCutInfo_IsValid;

	private static int FMoviePipelineCameraCutInfo_StructSize;

	public FMoviePipelineCameraCutInfo Copy()
	{
		return this;
	}

	public static FMoviePipelineCameraCutInfo FromNative(IntPtr nativeBuffer)
	{
		return new FMoviePipelineCameraCutInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMoviePipelineCameraCutInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMoviePipelineCameraCutInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMoviePipelineCameraCutInfo(nativeBuffer + arrayIndex * FMoviePipelineCameraCutInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMoviePipelineCameraCutInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMoviePipelineCameraCutInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMoviePipelineCameraCutInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraCutInfo");
		}
	}

	public FMoviePipelineCameraCutInfo(IntPtr nativeStruct)
	{
		if (!FMoviePipelineCameraCutInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieRenderPipelineCore.MoviePipelineCameraCutInfo");
		}
	}

	static FMoviePipelineCameraCutInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMoviePipelineCameraCutInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMoviePipelineCameraCutInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieRenderPipelineCore.MoviePipelineCameraCutInfo");
		FMoviePipelineCameraCutInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FMoviePipelineCameraCutInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/MovieRenderPipelineCore.MoviePipelineCameraCutInfo", FMoviePipelineCameraCutInfo_IsValid);
	}
}
