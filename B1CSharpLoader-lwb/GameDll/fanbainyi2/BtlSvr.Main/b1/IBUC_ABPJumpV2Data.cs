using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPJumpV2Data
{
	ESkillDirection StartJumpDir { get; }

	bool bIsJumpStartFast { get; }

	bool bIsLittleFall { get; }

	bool bInJump { get; }

	EJumpType JumpType { get; }

	bool bFallByJump { get; }

	float CustomJumpVelocityIncrementWhenPressed { get; }

	float CustomJumpVelocityIncrementWhenPressed_Locked { get; }

	UBlendSpace BS_jump_start_fwd { get; }

	UBlendSpace BS_jump_start_bwd { get; }

	UBlendSpace BS_jump_loop_fwd { get; }

	UBlendSpace BS_jump_loop_bwd { get; }

	UBlendSpace BS_jump_additive_lean { get; }

	UBlendSpace BS_jump_additive_rot { get; }

	UAnimSequence AnimGroundJumpStart { get; }

	UAnimSequence AnimJumpStart_N { get; }

	UAnimSequence AnimJumpStart_F { get; }

	UAnimSequence AnimJumpStart_L { get; }

	UAnimSequence AnimJumpStart_R { get; }

	UAnimSequence AnimJumpStart_B { get; }

	UAnimSequence AnimGlideJumpStart { get; }

	float LandAnimCantJumpTimer_Glide { get; }

	UAnimSequence AnimFallStart { get; }

	UAnimSequence AnimFallStart_N { get; }

	UAnimSequence AnimFallStart_F { get; }

	UAnimSequence AnimFallStart_B { get; }

	UAnimSequence AnimFallStart_L { get; }

	UAnimSequence AnimFallStart_R { get; }

	UAnimSequence AnimFallLoop { get; }

	float AnimLand_MoveTime { get; }

	float AnimLand_JumpTime { get; }

	float AnimLand_AttackTime { get; }

	UAnimSequence AnimLand_F_Low { get; }

	UAnimSequence AnimLand_F_Mid { get; }

	UAnimSequence AnimLand_F_High { get; }

	UAnimSequence AnimLand_L { get; }

	UAnimSequence AnimLand_R { get; }

	UAnimSequence AnimLand_B { get; }

	UAnimSequence AddtiveMoveAfterJump_F { get; }

	UAnimSequence AddtiveMoveAfterJump_B { get; }

	UAnimSequence AddtiveMoveAfterJump_L { get; }

	UAnimSequence AddtiveMoveAfterJump_R { get; }

	float AdditiveMoveAfterJumpFAlpha { get; }

	float AdditiveMoveAfterJumpBAlpha { get; }

	float AdditiveMoveAfterJumpLAlpha { get; }

	float AdditiveMoveAfterJumpRAlpha { get; }

	bool bIsInLandCantMoveTime { get; }

	bool bIsInLandCantJumpTime { get; }

	bool bIsInLandCantAttackTime { get; }

	bool bIsInLandCantDodgeTime { get; }

	EStartJumpSpdState StartJumpSpdState { get; }

	EFallHeightType_V2 FallHeightType { get; }

	float FallHeight { get; }

	bool bHasFallAnimAsset { get; }

	float AimOffsetForJumpEnableX { get; }

	float AimOffsetForJumpEnableY { get; }

	FVector2D LocalInput2D { get; }

	FVector2D VelocityBlend { get; }

	float VelocityDeltaAngle { get; }

	float VelocityDeltaAngleTrans { get; }

	float TriggerLandHeight { get; }

	float HeightDividingLine_Low { get; }

	float HeightDividingLine_Mid { get; }
}
