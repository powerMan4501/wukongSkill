using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnActionEventType", "AIModule", UnrealModuleType.Engine)]
public enum EPawnActionEventType
{
	Invalid,
	FailedToStart,
	InstantAbort,
	FinishedAborting,
	FinishedExecution,
	Push
}
