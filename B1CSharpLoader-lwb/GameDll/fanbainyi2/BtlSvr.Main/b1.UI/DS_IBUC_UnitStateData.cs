using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_UnitStateData : GSBattleDataDStore
{
	private IBUC_UnitStateData ReadData;

	private BUC_UnitStateData Data;

	public DS_IBUC_UnitStateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitStateData>(actor);
		}
	}

	public bool HasState(EBGUUnitState UnitState)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.HasState(UnitState);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitStateData>(actor);
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
