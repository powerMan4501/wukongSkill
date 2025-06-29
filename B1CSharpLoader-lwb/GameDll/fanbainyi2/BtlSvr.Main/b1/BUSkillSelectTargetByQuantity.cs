using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUSkillSelectTargetByQuantity : BUSkillSelectTargetTemplate
{
	public override AActor GetBestTarget(AActor Owner, int SkillID, out UnitLockTargetInfo TargetInfo)
	{
		TargetInfo = null;
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc == null)
		{
			return null;
		}
		AActor result = null;
		TargetInfo = BGU_SelectTargetUtil.FindTargetWithBestDensity(Owner, playerSkillCtrlDesc.AttackRange, playerSkillCtrlDesc.SelectShapeParam3);
		if (TargetInfo.LockTargetActor != null)
		{
			result = TargetInfo.LockTargetActor;
		}
		return result;
	}
}
