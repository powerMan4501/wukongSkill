using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.FallDyingState")]
public enum EFallDyingState : byte
{
	Min,
	Alive,
	FallDyingBegin,
	FallDyingWaiting,
	FallDyingWaitSelfSave,
	FallDyingSelfSaving,
	RealDead
}
