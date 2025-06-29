using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_SkillSelectHelperData
{
	bool GetWillCancelSkill();

	FVector GetDesiredSkillDirection();

	FRotator GetDesiredSkillRotation();

	FVector GetDesiredSkillLocation();
}
