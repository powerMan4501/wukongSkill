using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPAttackIKData
{
	bool EnableAttackIK { get; }

	float AttackIKAlpha { get; }

	EAttackIKType AttackIKType { get; }

	FVector FishSpikeWorldLocation { get; }

	List<float> AttackIKRollList { get; }

	List<float> AttackIKPitchList { get; }

	TArrayReadWrite<FAttackIKBonePairs> AttackIKBonePairList { get; }

	FVector StartPosition { get; }

	FVector TargetPosition { get; }

	float IKDistance { get; }

	float JumpMaxDistance { get; }

	FVector CurrentPosition { get; }

	float AttackIKFishSpikeAlpha { get; }

	FishSpikeJumpType FishSpikeType { get; }

	bool FishSpikeCancel { get; }

	bool DebugFishSpikeEnable { get; }

	bool BoneScaleEnable { get; }

	FAttackIKBoneScale BoneScaleData { get; }

	FVector BonePosition { get; }

	float BoneScaleAlpha { get; }

	bool CanNotLock { get; }

	List<float> LastPitchList { get; }
}
