using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.State_MM")]
public enum EState_MM : byte
{
	None,
	Lock,
	Free,
	FreeWalk,
	FreeRun,
	FreeSprint,
	LockWalk,
	LockRun,
	LockSprint,
	FrozenMove,
	MuddyMove,
	WindyMove,
	SpiderSilkyMove
}
