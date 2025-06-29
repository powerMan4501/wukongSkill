using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPAttackOffsetData
{
	float Alpha { get; }

	FQuat AttackOffset_WorldRotOffset { get; }

	EAttackOffsetType AttackOffset_AttackOffsetType { get; }
}
