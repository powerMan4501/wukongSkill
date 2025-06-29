using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_BulletHitInfoComp : UActorCompBaseCS
{
	private BUC_BulletHitInfoData BulletHitInfoData;

	public override void OnAttach()
	{
		BulletHitInfoData = RequireWritableData<BUC_BulletHitInfoData>();
		base.BUSEventCollection.Evt_UnitBeHittedCountDic += new Del_BulletHitInfo(UnitBeHittedCountDic);
		base.BUSEventCollection.Evt_UpdateHittedInfo += new Del_Actor(UpdateHittedInfo);
	}

	public override void OnBeginPlay()
	{
		BulletHitInfoData.UnitBeHittedCountDic = new Dictionary<BGUCharacterCS, int>();
	}

	private void UpdateHittedInfo(AActor BeHittedActor)
	{
		BGUCharacterCS bGUCharacterCS = BeHittedActor as BGUCharacterCS;
		BulletHitInfoData.LastHitUnit = bGUCharacterCS;
		if (BulletHitInfoData.UnitBeHittedCountDic.ContainsKey(bGUCharacterCS))
		{
			BulletHitInfoData.UnitBeHittedCountDic[bGUCharacterCS]++;
		}
		else
		{
			BulletHitInfoData.UnitBeHittedCountDic.Add(bGUCharacterCS, 1);
		}
	}

	private Dictionary<BGUCharacterCS, int> UnitBeHittedCountDic()
	{
		foreach (KeyValuePair<BGUCharacterCS, int> item in BulletHitInfoData.UnitBeHittedCountDic)
		{
			BGUCharacterCS key = item.Key;
			if (key == null || key.IsDestroyed || BGUFunctionLibraryCS.BGUHasUnitState(key, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitState(key, EBGUUnitState.LifeSavingHair_FakeDead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(key, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				BulletHitInfoData.UnitBeHittedCountDic.Remove(item.Key);
			}
		}
		return BulletHitInfoData.UnitBeHittedCountDic;
	}
}
