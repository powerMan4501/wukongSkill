using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_OnlineAssistData : GSBattleDataDStore
{
	private IBGC_OnlineAssistData ReadData;

	private BGC_OnlineAssistData Data;

	public DS_IBGC_OnlineAssistData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineAssistData, BGC_OnlineAssistData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineAssistData>(actor);
		}
	}

	public bool IsInAssist()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInAssist();
	}

	public ECrusadeState GetCrusadeState(string UnitGuid)
	{
		if (ReadData == null)
		{
			return ECrusadeState.Crusaded;
		}
		return ReadData.GetCrusadeState(UnitGuid);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineAssistData, BGC_OnlineAssistData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineAssistData>(actor);
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
