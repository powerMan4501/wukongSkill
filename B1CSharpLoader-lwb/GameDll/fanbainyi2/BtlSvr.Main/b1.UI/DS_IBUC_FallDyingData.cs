using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_FallDyingData : GSBattleDataDStore
{
	private IBUC_FallDyingData ReadData;

	private BUC_FallDyingData Data;

	public DS_IBUC_FallDyingData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FallDyingData>(actor);
		}
	}

	public int BindUnitFallDyingStateChange(Action<EFallDyingState, EFallDyingState> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnUnitFallDyingStateChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnUnitFallDyingStateChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnUnitFallDyingStateChg -= ChangeHandler;
		}
	}

	public void UnBindUnitFallDyingStateChange(int BindIdx, Action<EFallDyingState, EFallDyingState> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnUnitFallDyingStateChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindInteractStateValueChange(Action<EInteractUIState, EInteractUIState> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnInteractStateValueChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnInteractStateValueChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnInteractStateValueChg -= ChangeHandler;
		}
	}

	public void UnBindInteractStateValueChange(int BindIdx, Action<EInteractUIState, EInteractUIState> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnInteractStateValueChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public float GetFallDyingTime()
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetFallDyingTime();
	}

	public float GetSaveSelfWaitTime()
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetSaveSelfWaitTime();
	}

	public bool GetCanSaveSelf()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanSaveSelf();
	}

	public bool GetCanBeSaveByTarget()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanBeSaveByTarget();
	}

	public EFallDyingState GetFallDyingState()
	{
		if (ReadData == null)
		{
			return EFallDyingState.Min;
		}
		return ReadData.GetFallDyingState();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_FallDyingData>(actor);
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
