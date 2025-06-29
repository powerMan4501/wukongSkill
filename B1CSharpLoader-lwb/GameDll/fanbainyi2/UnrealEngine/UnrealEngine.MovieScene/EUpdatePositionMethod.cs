using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MovieScene.EUpdatePositionMethod", "MovieScene", UnrealModuleType.Engine)]
public enum EUpdatePositionMethod : byte
{
	Play,
	Jump,
	Scrub
}
