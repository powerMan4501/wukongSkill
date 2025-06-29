using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_FallingData : IBUC_FallingData, IPersistentECSData
{
	public float FallingSafeTime;

	public float CostDMG_StartHeight;

	public float OverHeight_DmgAdditive_INV10000;

	public float FallDmg_DmgMax_INV10000;

	public float BaseDmg_INV10000;

	public bool bPauseSafeFallingCheck;

	public FLandCamShake LandCamShakeConfig;

	public float FallingTimer { get; set; }

	public float FallingAttackProtectTime { get; set; }

	public float FallingAttackProtectTimer { get; set; }

	public bool EnableDodge_InFalling { get; set; }

	public float CanDodge_Distance { get; set; }

	public float Dodge_DmgMul { get; set; }

	public float FloorDistance { get; set; }

	public bool DodgeSuccess_InFalling { get; set; }

	public bool bInSafeLandVolume { get; set; }

	public Dictionary<int, int> SkillInAirRecordList { get; set; }

	public bool bActive_StopMontageWhenLand { get; set; }

	public bool EnableFloorDistanceCheck { get; set; }

	public BUC_FallingData()
	{
		FallingTimer = -1f;
		bPauseSafeFallingCheck = false;
		FallingAttackProtectTime = -1f;
		FallingAttackProtectTimer = -1f;
		SkillInAirRecordList = new Dictionary<int, int>();
		bActive_StopMontageWhenLand = false;
	}

	public bool CanFallingAttack()
	{
		return FallingAttackProtectTimer <= 0f;
	}
}
