using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.EMoviePipelineShutterTiming", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public enum EMoviePipelineShutterTiming : byte
{
	FrameOpen,
	FrameCenter,
	FrameClose
}
