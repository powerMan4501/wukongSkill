using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPBGUCharacterData
{
	bool IsDead { get; }

	bool IsAttacking { get; }

	bool IsStandRotate { get; }

	float TurnInplaceRemainAngle { get; }

	FRotator TurnInplaceTargetRotation { get; }

	bool bOrientRotationToMovement { get; }

	bool bSideWalking { get; }

	float BSStartMode { get; }

	int BSEndMode { get; }

	float InputMoveForward { get; }

	float InputMoveSideways { get; }

	float SprintSpeed { get; }

	float RunSpeed { get; }

	float JogBaseSpeed { get; }
}
