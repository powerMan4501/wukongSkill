using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_UnitBarInfoData : GSBattleDataDStore
{
	private IBUC_UnitBarInfoData ReadData;

	private BUC_UnitBarInfoData Data;

	public GSBindProp<bool> BossBarAcived
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BossBarAcived;
		}
	}

	public GSBindProp<bool> EliteBarActived
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.EliteBarActived;
		}
	}

	public bool BloodBarActived
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.BloodBarActived;
		}
	}

	public float BloodBarPercent
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.BloodBarPercent;
		}
	}

	public bool ShieldBarActived
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.ShieldBarActived;
		}
	}

	public bool BossShieldBarActived
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.BossShieldBarActived;
		}
	}

	public float ShieldBarPercent
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.ShieldBarPercent;
		}
	}

	public List<string> ObserveBoss
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ObserveBoss;
		}
	}

	public List<int> BuffIconList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BuffIconList;
		}
	}

	public bool IsLocked
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.IsLocked;
		}
	}

	public DS_IBUC_UnitBarInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitBarInfoData, BUC_UnitBarInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitBarInfoData>(actor);
		}
	}

	public int BindShieldBarActivedChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnShieldBarActivedChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnShieldBarActivedChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnShieldBarActivedChg -= ChangeHandler;
		}
	}

	public void UnBindShieldBarActivedChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnShieldBarActivedChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindBossShieldBarActivedChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnBossShieldBarActivedChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnBossShieldBarActivedChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnBossShieldBarActivedChg -= ChangeHandler;
		}
	}

	public void UnBindBossShieldBarActivedChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnBossShieldBarActivedChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindShieldBarPercentChange(Action<float, float> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnShieldBarPercentChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnShieldBarPercentChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnShieldBarPercentChg -= ChangeHandler;
		}
	}

	public void UnBindShieldBarPercentChange(int BindIdx, Action<float, float> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnShieldBarPercentChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindBloodBarActivedChange(Action<bool, bool> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnBloodBarActivedChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnBloodBarActivedChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnBloodBarActivedChg -= ChangeHandler;
		}
	}

	public void UnBindBloodBarActivedChange(int BindIdx, Action<bool, bool> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnBloodBarActivedChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindBloodBarPercentChange(Action<float, float> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnBloodBarPercentChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnBloodBarPercentChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnBloodBarPercentChg -= ChangeHandler;
		}
	}

	public void UnBindBloodBarPercentChange(int BindIdx, Action<float, float> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnBloodBarPercentChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public float GetIconDuration(int IconID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetIconDuration(IconID);
	}

	public int GetIconNum(int IconID)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetIconNum(IconID);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitBarInfoData, BUC_UnitBarInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_UnitBarInfoData>(actor);
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
