using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EANTriggerEffectTargetType")]
public enum EANTriggerEffectTargetType : byte
{
	Owner,
	Master,
	LastAttacker
}
