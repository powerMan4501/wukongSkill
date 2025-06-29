using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_PlayerSpellConfData : GSBattleDataDStore
{
	private IBUC_PlayerSpellConfData ReadData;

	private BUC_PlayerSpellConfData Data;

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

	public List<FUStMagicConfInfo> MagicConfInfo
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.MagicConfInfo;
		}
	}

	public int CurrentTransFormID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.CurrentTransFormID;
		}
	}

	public DS_IBUC_PlayerSpellConfData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerSpellConfData>(actor);
		}
	}

	public int BindCurrentTransFormIDChange(Action<int, int> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnCurrentTransFormIDChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnCurrentTransFormIDChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnCurrentTransFormIDChg -= ChangeHandler;
		}
	}

	public void UnBindCurrentTransFormIDChange(int BindIdx, Action<int, int> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnCurrentTransFormIDChg -= ChangeHandler;
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerSpellConfData, BUC_PlayerSpellConfData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerSpellConfData>(actor);
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
