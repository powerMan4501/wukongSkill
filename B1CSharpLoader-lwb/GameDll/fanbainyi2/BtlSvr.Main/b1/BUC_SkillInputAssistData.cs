using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SkillInputAssistData : IBUC_SkillInputAssistData, IPersistentECSData
{
	public FVector LastFrameSkillSelectSwitchTargetVec;

	public FVector2D InputSkillSelectVec;

	public UnitLockTargetInfo TargetInfoBeforeInputSkill { get; set; }

	public bool bInputSkillManualSelect { get; set; }

	public bool bInputSkillAutoSelect { get; set; }

	public bool bSkillDragWillCancel { get; set; }

	public int InputSelectingSkillID { get; set; }

	public Entity SkillSelectSuctionTargetEntity { get; set; }

	public float UpdateSuctionTargetTimer { get; set; }

	public Entity SkillSelectSwitchTargetEntity { get; set; }

	public float ReleaseDelayTime { get; set; }

	public int ReleaseSkillId { get; set; }

	public bool GetIsInSkillManualSelecting()
	{
		return bInputSkillManualSelect;
	}

	public bool GetHaveDelayRelease()
	{
		return ReleaseSkillId != 0;
	}
}
