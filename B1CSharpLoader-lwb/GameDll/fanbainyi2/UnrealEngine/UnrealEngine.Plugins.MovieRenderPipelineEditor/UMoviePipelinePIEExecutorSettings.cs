using System;
using UnrealEngine.DeveloperSettings;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineEditor;

[UClass(Flags = (ClassFlags)810549414uL, Config = "Editor")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutorSettings", "MovieRenderPipelineEditor", UnrealModuleType.EnginePlugin)]
public class UMoviePipelinePIEExecutorSettings : UDeveloperSettings
{
	private static bool InitialDelayFrameCount_IsValid;

	private static int InitialDelayFrameCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutorSettings:InitialDelayFrameCount")]
	public int InitialDelayFrameCount
	{
		get
		{
			CheckDestroyed();
			if (!InitialDelayFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutorSettings:InitialDelayFrameCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, InitialDelayFrameCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialDelayFrameCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutorSettings:InitialDelayFrameCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, InitialDelayFrameCount_Offset), value);
			}
		}
	}

	static UMoviePipelinePIEExecutorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelinePIEExecutorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelinePIEExecutorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineEditor.MoviePipelinePIEExecutorSettings");
		InitialDelayFrameCount_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InitialDelayFrameCount");
		InitialDelayFrameCount_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InitialDelayFrameCount", Classes.FIntProperty);
	}
}
