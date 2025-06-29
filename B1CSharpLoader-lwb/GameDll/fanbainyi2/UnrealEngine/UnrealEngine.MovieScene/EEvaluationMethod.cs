using UnrealEngine.Runtime;

namespace UnrealEngine.MovieScene;

[UEnum]
[UMetaPath("/Script/MovieScene.EEvaluationMethod", "MovieScene", UnrealModuleType.Engine)]
public enum EEvaluationMethod
{
	Static,
	Swept
}
