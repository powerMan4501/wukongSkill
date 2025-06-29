using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal class BUSkillSelectTargetByQuality : BUSkillSelectTargetTemplate
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
		TargetInfo = BGU_SelectTargetUtil.SelectAutoLockTargetInRange(Owner, BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner), EBSelectTargetRangeType.None, playerSkillCtrlDesc.AttackRange, playerSkillCtrlDesc.SelectShapeParam3, playerSkillCtrlDesc.DistScoreRating, playerSkillCtrlDesc.HeightScoreRating, playerSkillCtrlDesc.AngleScoreRating, 0f, 0f, playerSkillCtrlDesc.SmartSelectTargetType == ESmartSelectTargetType.SstElite, playerSkillCtrlDesc.PelvisExtraScore, playerSkillCtrlDesc.AutoLockPreferPelvis == EGSYesNo.Yes);
		if (TargetInfo.LockTargetActor != null)
		{
			result = TargetInfo.LockTargetActor;
		}
		return result;
	}
}
