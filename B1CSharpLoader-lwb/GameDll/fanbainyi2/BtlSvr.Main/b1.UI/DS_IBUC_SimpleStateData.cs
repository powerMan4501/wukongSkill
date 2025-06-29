using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_SimpleStateData : GSBattleDataDStore
{
	private IBUC_SimpleStateData ReadData;

	private BUC_SimpleStateData Data;

	public DS_IBUC_SimpleStateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(actor);
		}
	}

	public bool HasSimpleState(EBGUSimpleState SimpleState)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.HasSimpleState(SimpleState);
	}

	public bool GetSimpleStateLayer(EBGUSimpleState SimpleState, out int LayerNum)
	{
		LayerNum = 0;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetSimpleStateLayer(SimpleState, out LayerNum);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SimpleStateData>(actor);
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
