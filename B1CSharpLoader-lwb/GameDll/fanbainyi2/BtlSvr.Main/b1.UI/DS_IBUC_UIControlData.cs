using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_UIControlData : GSBattleDataDStore
{
	private IBUC_UIControlData ReadData;

	private BUC_UIControlData Data;

	public DS_IBUC_UIControlData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UIControlData, BUC_UIControlData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UIControlData>(actor);
		}
	}

	public int BindActiveDeathUIChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnActiveDeathUIChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnActiveDeathUIChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnActiveDeathUIChg -= ChangeHandler;
		}
	}

	public void UnBindActiveDeathUIChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnActiveDeathUIChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public bool GetOnlyShowByPlayer()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetOnlyShowByPlayer();
	}

	public bool GetActiveDeathUI()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetActiveDeathUI();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UIControlData, BUC_UIControlData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UIControlData>(actor);
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
