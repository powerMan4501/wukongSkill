using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AttackOffsetType")]
public enum EAttackOffsetType : byte
{
	AttackOffset_None,
	AttackOffset_WorldRotOffset
}
