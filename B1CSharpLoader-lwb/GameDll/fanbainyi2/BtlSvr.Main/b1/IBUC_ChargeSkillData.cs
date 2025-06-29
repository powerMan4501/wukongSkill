using System.Collections.Generic;
using BtlShare;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_ChargeSkillData
{
	int CurrentBeginChargeSkillID { get; }

	int CurrentBeginChargeSkillOriginSkillID { get; }

	int CurrentChargeSkillID { get; }

	float ChargeTimer { get; }

	int BeAttackedTriggerForceAttackCnt { get; }

	EChargeSkillStage ChargeSkillStage { get; }

	bool IsCastingChargeSkill { get; }

	bool NeedTriggerNextStage { get; }

	bool NeedCancel { get; }

	List<ChargeSkillBuffInfo> BuffInfoList { get; }

	ChargeSkillSuperArmorInfo SuperArmorInfo { get; }

	int CurChargeLevel { get; }
}
