using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_BarSockData : GSBattleDataDStore
{
	private IBUC_BarSockData ReadData;

	private BUC_BarSockData Data;

	public DS_IBUC_BarSockData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BarSockData, BUC_BarSockData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BarSockData>(actor);
		}
	}

	public int BindLockTargetActorChange(Action<Entity, Entity> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnLockTargetActorChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnLockTargetActorChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnLockTargetActorChg -= ChangeHandler;
		}
	}

	public void UnBindLockTargetActorChange(int BindIdx, Action<Entity, Entity> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnLockTargetActorChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindLockTargetSkeletonSocketChange(Action<string, string> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnLockTargetSkeletonSocketChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnLockTargetSkeletonSocketChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnLockTargetSkeletonSocketChg -= ChangeHandler;
		}
	}

	public void UnBindLockTargetSkeletonSocketChange(int BindIdx, Action<string, string> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnLockTargetSkeletonSocketChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindCantShowBarSockUIChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnCantShowBarSockUIChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnCantShowBarSockUIChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnCantShowBarSockUIChg -= ChangeHandler;
		}
	}

	public void UnBindCantShowBarSockUIChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnCantShowBarSockUIChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindIsTargetSpChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnIsTargetSpChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnIsTargetSpChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnIsTargetSpChg -= ChangeHandler;
		}
	}

	public void UnBindIsTargetSpChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnIsTargetSpChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public FVector GetLockTargetSockLocation()
	{
		if (ReadData == null)
		{
			return default(FVector);
		}
		return ReadData.GetLockTargetSockLocation();
	}

	public FVector GetInteractSockLocation()
	{
		if (ReadData == null)
		{
			return default(FVector);
		}
		return ReadData.GetInteractSockLocation();
	}

	public string GetLockTargetSkeletonSocket()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetLockTargetSkeletonSocket();
	}

	public Entity GetLockTargetActor()
	{
		if (ReadData == null)
		{
			return default(Entity);
		}
		return ReadData.GetLockTargetActor();
	}

	public float GetLastSwitchLockTime()
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetLastSwitchLockTime();
	}

	public bool GetIsTargetSp()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetIsTargetSp();
	}

	public bool IsCantShowBarSockUI()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsCantShowBarSockUI();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BarSockData, BUC_BarSockData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BarSockData>(actor);
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
