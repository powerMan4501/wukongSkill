using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUSkillSelectTargetByDistance : BUSkillSelectTargetTemplate
{
	public override AActor GetBestTarget(AActor Owner, int SkillID, out UnitLockTargetInfo TargetInfo)
	{
		TargetInfo = new UnitLockTargetInfo();
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
		if (playerSkillCtrlDesc == null)
		{
			return null;
		}
		AActor aActor = null;
		AActor aActor2 = null;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		BGUCharacterCS selfUnit = Owner as BGUCharacterCS;
		UBGUSelectUtil.SphereOverlapBGUCharacters(Owner, fVector, playerSkillCtrlDesc.AttackRange, out var OutArray);
		List<ABGUCharacter> list = new List<ABGUCharacter>();
		foreach (ABGUCharacter item in OutArray)
		{
			if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(item, EBGUSimpleState.CantBeBaseTarget) && BGUFunctionLibraryCS.BGUIsUnitDead(item) && !BGUFunctionLibraryCS.BGUIsEnemyTeam(selfUnit, item))
			{
				list.Add(item);
			}
		}
		foreach (ABGUCharacter item2 in list)
		{
			OutArray.Remove(item2);
		}
		TargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(Owner);
		if (TargetInfo.LockTargetActor != null)
		{
			aActor2 = TargetInfo.LockTargetActor;
		}
		BGUCharacterCS bGUCharacterCS = aActor2 as BGUCharacterCS;
		if (!aActor2.IsNullOrDestroyed() && FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor2)) <= playerSkillCtrlDesc.AttackRange && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(aActor2, EBGUSimpleState.CantBeBaseTarget) && !BGUFunctionLibraryCS.BGUIsUnitDead(aActor2) && !bGUCharacterCS.IsNullOrDestroyed() && BGUFunctionLibraryCS.BGUIsEnemyTeam(selfUnit, bGUCharacterCS))
		{
			aActor = aActor2;
		}
		else
		{
			aActor = BGU_SelectTargetUtil.FindTargetInDist(Owner as ABGUCharacter, fVector, OutArray);
			TargetInfo = new UnitLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Auto);
		}
		return aActor;
	}
}
