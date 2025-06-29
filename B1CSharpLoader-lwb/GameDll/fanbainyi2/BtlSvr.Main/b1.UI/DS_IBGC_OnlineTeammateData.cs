using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_OnlineTeammateData : GSBattleDataDStore
{
	private IBGC_OnlineTeammateData ReadData;

	private BGC_OnlineTeammateData Data;

	public Dictionary<int, TeamPlayerInfo> PlayerInfoDict
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.PlayerInfoDict;
		}
	}

	public DS_IBGC_OnlineTeammateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineTeammateData, BGC_OnlineTeammateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineTeammateData>(actor);
		}
	}

	public List<PlayerMapTransformInfo> GetPlayerTranstion()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetPlayerTranstion();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_OnlineTeammateData, BGC_OnlineTeammateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_OnlineTeammateData>(actor);
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
