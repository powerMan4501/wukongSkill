using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_BattleStateData : IBUC_BattleStateData, IPersistentECSData
{
	public bool IsPlayerUnit;

	public bool HasTarget_ForMonster;

	public bool HasHatred_ForMonster;

	public AActor PlayerAsTarget_ForMonster;

	public List<AActor> PlayerInHatredList_ForMonster = new List<AActor>();

	public List<Entity> AlreadySetOwnerAsTargetUnitList { get; set; } = new List<Entity>();

	public List<Entity> CanSetOwnerAsTargetUnitList { get; set; } = new List<Entity>();

	public BUC_BattleStateData()
	{
		IsPlayerUnit = true;
		HasTarget_ForMonster = false;
		HasHatred_ForMonster = false;
		PlayerAsTarget_ForMonster = null;
	}

	public bool IsUnitInBattle()
	{
		if (!IsPlayerUnit)
		{
			if (!HasTarget_ForMonster)
			{
				return HasHatred_ForMonster;
			}
			return true;
		}
		if (AlreadySetOwnerAsTargetUnitList.Count <= 0)
		{
			return CanSetOwnerAsTargetUnitList.Count > 0;
		}
		return true;
	}

	public bool IsUnitInBattleAssignPlayer(AActor PlayerActor)
	{
		bool result = false;
		if (!IsPlayerUnit && (HasTarget_ForMonster || HasHatred_ForMonster) && PlayerActor != null)
		{
			if (PlayerActor == PlayerAsTarget_ForMonster)
			{
				result = true;
			}
			else if (PlayerInHatredList_ForMonster != null && PlayerInHatredList_ForMonster.Count > 0)
			{
				foreach (AActor item in PlayerInHatredList_ForMonster)
				{
					if (item == PlayerActor)
					{
						result = true;
						break;
					}
				}
			}
		}
		return result;
	}

	public bool PlayerHasBeTarget()
	{
		if (IsPlayerUnit)
		{
			return AlreadySetOwnerAsTargetUnitList.Count > 0;
		}
		return false;
	}

	public void CollectCatchTargetInfo(AActor InvokerActor)
	{
		Entity item = ECSUtil.ToEntity(InvokerActor);
		if (!AlreadySetOwnerAsTargetUnitList.Contains(item))
		{
			AlreadySetOwnerAsTargetUnitList.Add(item);
		}
	}

	public void ClearCollectedTargetInfo(AActor InvokerActor)
	{
		Entity item = ECSUtil.ToEntity(InvokerActor);
		if (AlreadySetOwnerAsTargetUnitList.Contains(item))
		{
			AlreadySetOwnerAsTargetUnitList.Remove(item);
		}
	}

	public void CollectAddHatredInfo(AActor InvokerActor)
	{
		Entity item = ECSUtil.ToEntity(InvokerActor);
		if (!CanSetOwnerAsTargetUnitList.Contains(item))
		{
			CanSetOwnerAsTargetUnitList.Add(item);
		}
	}

	public void ClearCollectedHatredInfo(AActor InvokerActor)
	{
		Entity item = ECSUtil.ToEntity(InvokerActor);
		if (CanSetOwnerAsTargetUnitList.Contains(item))
		{
			CanSetOwnerAsTargetUnitList.Remove(item);
		}
	}

	public void TickForValidUnit()
	{
		for (int num = AlreadySetOwnerAsTargetUnitList.Count - 1; num >= 0; num--)
		{
			if (ECSUtil.ToActor(AlreadySetOwnerAsTargetUnitList[num]) == null)
			{
				AlreadySetOwnerAsTargetUnitList.RemoveAt(num);
			}
		}
		for (int num2 = CanSetOwnerAsTargetUnitList.Count - 1; num2 >= 0; num2--)
		{
			if (ECSUtil.ToActor(CanSetOwnerAsTargetUnitList[num2]) == null)
			{
				CanSetOwnerAsTargetUnitList.RemoveAt(num2);
			}
		}
	}
}
