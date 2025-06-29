using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnActionResult", "AIModule", UnrealModuleType.Engine)]
public enum EPawnActionResult
{
	NotStarted,
	InProgress,
	Success,
	Failed,
	Aborted
}
