using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

[NeedToUI]
public interface IBUC_SkillInstsData
{
	UAnimMontage CurrentSkillMontage { get; }

	int CurrentCastingSkillID { get; }

	bool IsHitUnitDuringCastingSkill { get; }

	string LastSkillKeyActionMapping { get; }

	List<int> MagicWindowSkillBlackList { get; }

	List<int> MagicWindowSkillWhiteList { get; }

	int CurSkillCostDmgCounter { get; }

	ECastSkillResult GetLastSkillCastResult();

	ECanCastSkillResult GetLastCanCastSkillResult();

	int GetTurnSkillID(TurnSkillType Type);

	int GetMoveSkillID(TurnSkillType Type);

	UAnimMontage GetSweepCheckAtkReboundingAM(int ObjectID);

	UAnimMontage GetSweepCheckLowAtkReboundingAM(int ObjectID);

	float GetLastSkillCastTime(int SkillID);

	bool GetSkillCooldownTime(int SkillID, out float RemainingCooldownTime, out float RemainingPreCooldownTime);

	bool GetSkillCanCastByCDCondition(int SkillID);
}
