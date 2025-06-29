using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_RebirthPointData : GSBattleDataDStore
{
	private IBPC_RebirthPointData ReadData;

	private BPC_RebirthPointData Data;

	public DS_IBPC_RebirthPointData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_RebirthPointData, BPC_RebirthPointData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_RebirthPointData>(actor);
		}
	}

	public bool IsRebirthPointRegistered(int RebirthPointID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsRebirthPointRegistered(RebirthPointID);
	}

	public bool IsRebirthPointActived(int RebirthPointID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsRebirthPointActived(RebirthPointID);
	}

	public int GetActivedRebirthPoints(out List<int> ActivedRebirthPointIdList)
	{
		ActivedRebirthPointIdList = null;
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetActivedRebirthPoints(out ActivedRebirthPointIdList);
	}

	public int GetBlockedRebirthPoints(out List<int> BlockedRebirthPointIdList)
	{
		BlockedRebirthPointIdList = null;
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetBlockedRebirthPoints(out BlockedRebirthPointIdList);
	}

	public int GetCurrentRebirthPointID(UObject WorldContext)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetCurrentRebirthPointID(WorldContext);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_RebirthPointData, BPC_RebirthPointData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_RebirthPointData>(actor);
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
