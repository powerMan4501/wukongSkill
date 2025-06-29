using UnrealEngine.Engine;

namespace b1;

internal class BUSkillSelectTargetByMeleeAutoLock : BUSkillSelectTargetTemplate
{
	public override AActor GetBestTarget(AActor Owner, int SkillID, out UnitLockTargetInfo TargetInfo)
	{
		AActor result = null;
		FGSMeleeAutoLockSetting fGSMeleeAutoLockSetting = BGUFuncLibSkillCS.BGUGetCurrentMeleeAutoLockSetting(Owner, SkillID);
		TargetInfo = BGU_SelectTargetUtil.SelectAutoLockTargetInRange(Owner, BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), EBSelectTargetRangeType.MeeleAttack, fGSMeleeAutoLockSetting.Range, fGSMeleeAutoLockSetting.AngleMax, fGSMeleeAutoLockSetting.DistScoreRating, fGSMeleeAutoLockSetting.HeightScoreRating, fGSMeleeAutoLockSetting.AngleScoreRating, fGSMeleeAutoLockSetting.Z_Limit, fGSMeleeAutoLockSetting.PreferActorDistTolerance, PreferElite: false, fGSMeleeAutoLockSetting.PelvisExtraScore, fGSMeleeAutoLockSetting.AutoLockPreferPelvis);
		if (TargetInfo.LockTargetActor != null)
		{
			result = TargetInfo.LockTargetActor;
		}
		return result;
	}
}
