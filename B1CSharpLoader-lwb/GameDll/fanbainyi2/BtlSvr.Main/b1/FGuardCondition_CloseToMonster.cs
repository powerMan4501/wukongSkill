using System.Collections.Generic;
using System.Linq;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FGuardCondition_CloseToMonster : FGuardConditionBase
{
	private int CheckRange;

	private List<int> CheckResIdList;

	public override EGuardConditionType ConditionType => EGuardConditionType.CloseToMonster;

	protected override void Clean()
	{
		CheckResIdList = null;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		CheckRange = GuideCondition.CheckRange;
		CheckResIdList = GuideCondition.CheckResIdList.ToList();
		if (CheckResIdList == null || CheckResIdList.Count <= 0 || CheckRange <= 0)
		{
			BGW_LogUtil.LogError("FGuardCondition_CloseToMonster CheckResIdList == null || CheckResIdList.Count <= 0 || CheckRange <= 0");
			GSEUtil.Check(Condition: true, "[FGuardCondition_CloseToMonster] CheckResIdList == null || CheckResIdList.Count <= 0 || CheckRange <= 0");
			return false;
		}
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		if (FGuardConditionBase.CommonData.PlayerPawn.IsNullOrDestroyed())
		{
			return;
		}
		BGUFuncLibSelectTargetsCS.SelectUnitsInCircle(FGuardConditionBase.CommonData.PlayerPawn, out var OutActors, FGuardConditionBase.CommonData.PlayerPawn, BGUFuncLibActorTransformCS.BGUGetActorLocation(FGuardConditionBase.CommonData.PlayerPawn), 1, new List<int> { CheckRange });
		foreach (AActor item in OutActors)
		{
			BGUCharacterCS bGUCharacterCS = item as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int resID = bGUCharacterCS.GetResID();
				if (CheckResIdList.Contains(resID))
				{
					base.QueryState = EQueryState.QuerySuccess;
					break;
				}
			}
		}
	}
}
