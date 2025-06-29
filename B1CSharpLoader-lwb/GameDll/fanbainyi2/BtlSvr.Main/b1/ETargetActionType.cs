using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TargetActionType")]
public enum ETargetActionType : byte
{
	WakeUp,
	TriggerEffectByID,
	AddBuffByID
}
