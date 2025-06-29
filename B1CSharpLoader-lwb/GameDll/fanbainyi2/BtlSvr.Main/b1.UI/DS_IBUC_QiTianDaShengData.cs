using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_QiTianDaShengData : GSBattleDataDStore
{
	private IBUC_QiTianDaShengData ReadData;

	private BUC_QiTianDaShengData Data;

	public EDaShengStage DaShengStage
	{
		get
		{
			if (ReadData == null)
			{
				return EDaShengStage.LittleMonkey;
			}
			return ReadData.DaShengStage;
		}
	}

	public bool bIsBanTrans2DaSheng
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.bIsBanTrans2DaSheng;
		}
	}

	public float DaShengDurationTimer
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.DaShengDurationTimer;
		}
	}

	public float DaShengDurationTotalTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.DaShengDurationTotalTime;
		}
	}

	public DS_IBUC_QiTianDaShengData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_QiTianDaShengData>(actor);
		}
	}

	public int BindDaShengStageChange(Action<EDaShengStage, EDaShengStage> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnDaShengStageChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnDaShengStageChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnDaShengStageChg -= ChangeHandler;
		}
	}

	public void UnBindDaShengStageChange(int BindIdx, Action<EDaShengStage, EDaShengStage> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnDaShengStageChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_QiTianDaShengData, BUC_QiTianDaShengData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_QiTianDaShengData>(actor);
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
