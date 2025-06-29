using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.ESectionEvaluationFlags", "MovieScene", UnrealModuleType.Engine)]
public enum ESectionEvaluationFlags
{
	None,
	PreRoll,
	PostRoll
}
