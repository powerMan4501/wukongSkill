using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_GroupAIData
{
	bool IsForceDisableGroupAI { get; }

	bool IsBossUnit { get; }

	EGroupAITROCullType GroupAITROCullType { get; }

	bool GetIsCtrlByGroupAI();

	bool GetIsInAction();

	bool GetIsInPriorityAction();

	bool CanReceiveAttackAction();

	void GetCanCastSkillInfoNum(out int MeleeAtkSkillNum, out int RangeAtkSkillNum);

	bool GetGroupAIHotZonePointPos(out FVector2D HotZonePointPos);

	bool GetGroupAIHotZonePointInfo(out HotZonePointInfo HPI);
}
