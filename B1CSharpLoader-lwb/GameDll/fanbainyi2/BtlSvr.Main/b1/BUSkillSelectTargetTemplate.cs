using UnrealEngine.Engine;

namespace b1;

public class BUSkillSelectTargetTemplate
{
	public virtual AActor GetBestTarget(AActor Owner, int SkillID, out UnitLockTargetInfo TargetInfo)
	{
		TargetInfo = null;
		return null;
	}
}
