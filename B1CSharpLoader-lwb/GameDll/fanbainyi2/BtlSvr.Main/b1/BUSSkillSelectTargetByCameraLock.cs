using UnrealEngine.Engine;

namespace b1;

internal class BUSSkillSelectTargetByCameraLock : BUSkillSelectTargetTemplate
{
	public override AActor GetBestTarget(AActor Owner, int SkillID, out UnitLockTargetInfo TargetInfo)
	{
		AActor result = null;
		TargetInfo = BGUFuncLibInput.SelectCameraLockTarget(Owner);
		if (TargetInfo?.LockTargetActor != null)
		{
			result = TargetInfo.LockTargetActor;
		}
		return result;
	}
}
