using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineDebugSettings : UMoviePipelineSetting
{
	private static bool WriteAllSamples_IsValid;

	private static FFieldAddress WriteAllSamples_PropertyAddress;

	private static int WriteAllSamples_Offset;

	private static bool CaptureFramesWithRenderDoc_IsValid;

	private static FFieldAddress CaptureFramesWithRenderDoc_PropertyAddress;

	private static int CaptureFramesWithRenderDoc_Offset;

	private static bool CaptureFrame_IsValid;

	private static int CaptureFrame_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bWriteAllSamples")]
	public bool WriteAllSamples
	{
		get
		{
			CheckDestroyed();
			if (!WriteAllSamples_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bWriteAllSamples");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WriteAllSamples_Offset), 0, WriteAllSamples_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WriteAllSamples_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bWriteAllSamples");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WriteAllSamples_Offset), 0, WriteAllSamples_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bCaptureFramesWithRenderDoc")]
	public bool CaptureFramesWithRenderDoc
	{
		get
		{
			CheckDestroyed();
			if (!CaptureFramesWithRenderDoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bCaptureFramesWithRenderDoc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CaptureFramesWithRenderDoc_Offset), 0, CaptureFramesWithRenderDoc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CaptureFramesWithRenderDoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:bCaptureFramesWithRenderDoc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CaptureFramesWithRenderDoc_Offset), 0, CaptureFramesWithRenderDoc_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:CaptureFrame")]
	public int CaptureFrame
	{
		get
		{
			CheckDestroyed();
			if (!CaptureFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:CaptureFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CaptureFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings:CaptureFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CaptureFrame_Offset), value);
			}
		}
	}

	static UMoviePipelineDebugSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineDebugSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineDebugSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineDebugSettings");
		NativeReflectionCached.GetPropertyRef(ref WriteAllSamples_PropertyAddress, unrealStruct, "bWriteAllSamples");
		WriteAllSamples_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWriteAllSamples");
		WriteAllSamples_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWriteAllSamples", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CaptureFramesWithRenderDoc_PropertyAddress, unrealStruct, "bCaptureFramesWithRenderDoc");
		CaptureFramesWithRenderDoc_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bCaptureFramesWithRenderDoc");
		CaptureFramesWithRenderDoc_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bCaptureFramesWithRenderDoc", Classes.FBoolProperty);
		CaptureFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CaptureFrame");
		CaptureFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CaptureFrame", Classes.FIntProperty);
	}
}
