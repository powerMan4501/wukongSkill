using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPMonsterLocomotionData
{
	EMoveDirectionEight FreeMoveStartDirection { get; set; }

	EMoveDirection TargetLockMoveDirection { get; set; }

	EMoveDirectionEight CurLockMoveDirection { get; set; }

	float MoveLoopFwdBlendAlpha { get; }

	float FreeLeanAdditiveX { get; }

	float FreeLeanAdditiveY { get; }

	bool bSwitchToLock { get; }

	FVector4 VelocityBlendAlpha { get; }

	bool bTurnBack { get; }

	bool bIdleToMove { get; }

	bool bMoveToBlendStop { get; }

	bool bMoveToStandardFreeStop { get; }
}
