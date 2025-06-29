using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_JumpData : IBUC_JumpData, IPersistentECSData
{
	public Dictionary<EJumpType, int> JumpSkillID { get; set; }

	public ESkillDirection CurrentJumpDir { get; set; }

	public EStartJumpSpdState CurStartJumpSpdState { get; set; }

	public FVector2D CurrentJumpInputVector { get; set; }

	public FVector CurrenrJumpMoveDirection { get; set; }

	public float StartFallHeight { get; set; }

	public EJumpType JumpType { get; set; }

	public bool BIsInJump { get; set; }

	public FVector LastStartJumpPoint { get; set; }

	public FVector LastJumpDir { get; set; }

	public bool Jump_with_LookatTarget { get; set; }

	public float JumpRotSpd { get; set; }

	public uint MaxAccelerationHandleID { get; set; }

	public float JumpAttackProtectTime { get; set; }

	public float JumpAttackProtectTimer { get; set; }

	public List<int> JumpBuffID { get; set; }

	public float Default_JumpZVelocity { get; set; }

	public float ObstacleHeight_StrideJump { get; set; }

	public BUC_JumpData()
	{
		JumpSkillID = new Dictionary<EJumpType, int>();
		BIsInJump = false;
		JumpRotSpd = 0f;
		JumpAttackProtectTime = -1f;
		JumpAttackProtectTimer = -1f;
		JumpBuffID = new List<int>();
	}

	public bool IsInJump()
	{
		return BIsInJump;
	}

	public bool CanJumpAttack()
	{
		return JumpAttackProtectTimer <= 0f;
	}
}
