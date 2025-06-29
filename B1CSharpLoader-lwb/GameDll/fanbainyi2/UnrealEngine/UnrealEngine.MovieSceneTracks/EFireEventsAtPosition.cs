using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UEnum]
[UMetaPath("/Script/MovieSceneTracks.EFireEventsAtPosition", "MovieSceneTracks", UnrealModuleType.Engine)]
public enum EFireEventsAtPosition
{
	AtStartOfEvaluation,
	AtEndOfEvaluation,
	AfterSpawn
}
