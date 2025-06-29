using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_TransData : GSBattleDataDStore
{
	private IBPC_TransData ReadData;

	private BPC_TransData Data;

	public SpellType DefaultSpellType
	{
		get
		{
			if (ReadData == null)
			{
				return SpellType.Min;
			}
			return ReadData.DefaultSpellType;
		}
	}

	public DS_IBPC_TransData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_TransData, BPC_TransData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_TransData>(actor);
		}
	}

	public int BindIsTransChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnIsTransChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnIsTransChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnIsTransChg -= ChangeHandler;
		}
	}

	public void UnBindIsTransChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnIsTransChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int GetBirthPoint()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetBirthPoint();
	}

	public int GetLastControlUnitResID()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetLastControlUnitResID();
	}

	public bool GetIsTrans()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetIsTrans();
	}

	public EPlayerTransBeginType GetCurEnterTransReason()
	{
		if (ReadData == null)
		{
			return EPlayerTransBeginType.None;
		}
		return ReadData.GetCurEnterTransReason();
	}

	public bool IsPlotTrans()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsPlotTrans();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_TransData, BPC_TransData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_TransData>(actor);
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
