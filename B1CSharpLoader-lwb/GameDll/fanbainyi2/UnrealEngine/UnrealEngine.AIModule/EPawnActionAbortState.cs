using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnActionAbortState", "AIModule", UnrealModuleType.Engine)]
public enum EPawnActionAbortState
{
	NeverStarted,
	NotBeingAborted,
	MarkPendingAbort,
	LatentAbortInProgress,
	AbortDone
}
