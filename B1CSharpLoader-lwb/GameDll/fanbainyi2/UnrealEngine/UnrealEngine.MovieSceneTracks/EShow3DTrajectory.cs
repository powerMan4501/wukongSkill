using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UEnum]
[UMetaPath("/Script/MovieSceneTracks.EShow3DTrajectory", "MovieSceneTracks", UnrealModuleType.Engine)]
public enum EShow3DTrajectory
{
	EST_OnlyWhenSelected,
	EST_Always,
	EST_Never
}
