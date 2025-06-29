using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_LifeSavingData : GSBattleDataDStore
{
	private b1.IBUC_LifeSavingData ReadData;

	private BUC_LifeSavingData Data;

	public int SpellID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.SpellID;
		}
	}

	public float DefaultCD
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.DefaultCD;
		}
	}

	public float CoolDownRemainTimer
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.CoolDownRemainTimer;
		}
	}

	public DS_IBUC_LifeSavingData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_LifeSavingData, BUC_LifeSavingData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_LifeSavingData>(actor);
		}
	}

	public bool CanUseLifeSavingHair(IBUC_UnitStateData UnitStateData, IBUC_SimpleStateData SimpleStateData)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.CanUseLifeSavingHair(UnitStateData, SimpleStateData);
	}

	public float GetCDTimePercent()
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetCDTimePercent();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_LifeSavingData, BUC_LifeSavingData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_LifeSavingData>(actor);
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
