using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_PotentialEnergyData : GSBattleDataDStore
{
	private IBUC_PotentialEnergyData ReadData;

	private BUC_PotentialEnergyData Data;

	public int CurPELevel
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurPELevel;
		}
	}

	public float PELimit_Normal
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.PELimit_Normal;
		}
	}

	public float PELimit_ByChargeSkill
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.PELimit_ByChargeSkill;
		}
	}

	public Dictionary<int, PotentialEnergyLevelDetail> LevelMap
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.LevelMap;
		}
	}

	public BGWDataAsset_PELevelConfig Default_Config
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.Default_Config;
		}
	}

	public DS_IBUC_PotentialEnergyData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PotentialEnergyData>(actor);
		}
	}

	public int BindPELimit_NormalChange(Action<float, float> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnPELimit_NormalChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnPELimit_NormalChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnPELimit_NormalChg -= ChangeHandler;
		}
	}

	public void UnBindPELimit_NormalChange(int BindIdx, Action<float, float> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnPELimit_NormalChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int GetCurPELevel(AActor Owner)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetCurPELevel(Owner);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PotentialEnergyData>(actor);
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
