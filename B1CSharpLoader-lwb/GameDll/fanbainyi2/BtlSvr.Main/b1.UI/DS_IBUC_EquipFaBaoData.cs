using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_EquipFaBaoData : GSBattleDataDStore
{
	private IBUC_EquipFaBaoData ReadData;

	private BUC_EquipFaBaoData Data;

	public EFaBaoState FaBaoState
	{
		get
		{
			if (ReadData == null)
			{
				return EFaBaoState.None;
			}
			return ReadData.FaBaoState;
		}
	}

	public float FaBaoCastDuration
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.FaBaoCastDuration;
		}
	}

	public float CurrentCastDuration
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.CurrentCastDuration;
		}
	}

	public float FaBaoCoolDownPercentage
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.FaBaoCoolDownPercentage;
		}
	}

	public DS_IBUC_EquipFaBaoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_EquipFaBaoData, BUC_EquipFaBaoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipFaBaoData>(actor);
		}
	}

	public int BindFaBaoStateChange(Action<EFaBaoState, EFaBaoState> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnFaBaoStateChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnFaBaoStateChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnFaBaoStateChg -= ChangeHandler;
		}
	}

	public void UnBindFaBaoStateChange(int BindIdx, Action<EFaBaoState, EFaBaoState> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnFaBaoStateChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindbSatisfiedHasBuffConditionChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnbSatisfiedHasBuffConditionChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnbSatisfiedHasBuffConditionChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnbSatisfiedHasBuffConditionChg -= ChangeHandler;
		}
	}

	public void UnBindbSatisfiedHasBuffConditionChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnbSatisfiedHasBuffConditionChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int GetEquippedFaBaoID()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetEquippedFaBaoID();
	}

	public bool GetCanCastFaBaoSkill()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanCastFaBaoSkill();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_EquipFaBaoData, BUC_EquipFaBaoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipFaBaoData>(actor);
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
