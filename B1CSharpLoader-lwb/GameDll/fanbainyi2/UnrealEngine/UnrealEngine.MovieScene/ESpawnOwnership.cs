using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.ESpawnOwnership", "MovieScene", UnrealModuleType.Engine)]
public enum ESpawnOwnership
{
	InnerSequence,
	MasterSequence,
	External
}
