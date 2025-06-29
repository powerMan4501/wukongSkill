using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_JumpData
{
	ESkillDirection CurrentJumpDir { get; }

	EStartJumpSpdState CurStartJumpSpdState { get; }

	FVector2D CurrentJumpInputVector { get; }

	FVector CurrenrJumpMoveDirection { get; }

	float StartFallHeight { get; }

	EJumpType JumpType { get; set; }

	FVector LastStartJumpPoint { get; }

	FVector LastJumpDir { get; }

	bool Jump_with_LookatTarget { get; }

	float JumpRotSpd { get; }

	float ObstacleHeight_StrideJump { get; }

	bool IsInJump();

	bool CanJumpAttack();
}
