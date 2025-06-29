using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMontageSubStepResult", "Engine", UnrealModuleType.Engine)]
public enum EMontageSubStepResult
{
	Moved,
	NotMoved,
	InvalidSection,
	InvalidMontage
}
