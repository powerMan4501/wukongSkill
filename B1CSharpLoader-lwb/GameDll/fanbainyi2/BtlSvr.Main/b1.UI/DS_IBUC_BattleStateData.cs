using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_BattleStateData : GSBattleDataDStore
{
	private IBUC_BattleStateData ReadData;

	private BUC_BattleStateData Data;

	public List<Entity> AlreadySetOwnerAsTargetUnitList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.AlreadySetOwnerAsTargetUnitList;
		}
	}

	public List<Entity> CanSetOwnerAsTargetUnitList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CanSetOwnerAsTargetUnitList;
		}
	}

	public DS_IBUC_BattleStateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(actor);
		}
	}

	public bool IsUnitInBattle()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsUnitInBattle();
	}

	public bool IsUnitInBattleAssignPlayer(AActor PlayerActor)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsUnitInBattleAssignPlayer(PlayerActor);
	}

	public bool PlayerHasBeTarget()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.PlayerHasBeTarget();
	}

	public override void ResetActor(AActor actor)
	{
		base.ResetActor(actor);
		if (ReadData != null && Data != null)
		{
			foreach (List<Action> value in NeedActionDic.Values)
			{
				value[1]?.Invoke();
			}
		}
		if (actor.IsNullOrDestroyed())
		{
			ReadData = null;
			Data = null;
			return;
		}
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(actor);
		if (ReadData == null || Data == null)
		{
			return;
		}
		foreach (List<Action> value2 in NeedActionDic.Values)
		{
			value2[0]?.Invoke();
		}
	}
}
