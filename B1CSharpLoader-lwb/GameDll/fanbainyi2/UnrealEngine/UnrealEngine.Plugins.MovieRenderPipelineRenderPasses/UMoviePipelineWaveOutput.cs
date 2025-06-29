using System;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineRenderPasses;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineWaveOutput", "MovieRenderPipelineRenderPasses", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineWaveOutput : UMoviePipelineOutputBase
{
	private static bool FileNameFormatOverride_IsValid;

	private static int FileNameFormatOverride_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/MovieRenderPipelineRenderPasses.MoviePipelineWaveOutput:FileNameFormatOverride")]
	public string FileNameFormatOverride
	{
		get
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineWaveOutput:FileNameFormatOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FileNameFormatOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MovieRenderPipelineRenderPasses.MoviePipelineWaveOutput:FileNameFormatOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FileNameFormatOverride_Offset), value);
			}
		}
	}

	static UMoviePipelineWaveOutput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineWaveOutput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineWaveOutput));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MovieRenderPipelineRenderPasses.MoviePipelineWaveOutput");
		FileNameFormatOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FileNameFormatOverride");
		FileNameFormatOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FileNameFormatOverride", Classes.FStrProperty);
	}
}
