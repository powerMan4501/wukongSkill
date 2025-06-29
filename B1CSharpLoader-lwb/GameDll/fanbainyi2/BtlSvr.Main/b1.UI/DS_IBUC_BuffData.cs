using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_BuffData : GSBattleDataDStore
{
	private IBUC_BuffData ReadData;

	private BUC_BuffData Data;

	public bool bShouldUpdateBuffTime
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bShouldUpdateBuffTime;
		}
	}

	public bool bCanAddBuff
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bCanAddBuff;
		}
	}

	public DS_IBUC_BuffData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BuffData>(actor);
		}
	}

	public List<BuffInstData> GetAllBuffInstData()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAllBuffInstData();
	}

	public bool GetBuffInstData(int BuffID, out BuffInstData BuffData)
	{
		BuffData = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetBuffInstData(BuffID, out BuffData);
	}

	public bool HasBuff(int BuffID)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.HasBuff(BuffID);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BuffData, BUC_BuffData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BuffData>(actor);
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
