namespace b1;

public interface IBUC_SkillInputAssistData
{
	UnitLockTargetInfo TargetInfoBeforeInputSkill { get; }

	int InputSelectingSkillID { get; }

	bool GetIsInSkillManualSelecting();

	bool GetHaveDelayRelease();
}
