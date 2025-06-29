using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_AbnormalStateData : GSBattleDataDStore
{
	private IBUC_AbnormalStateData ReadData;

	private BUC_AbnormalStateData Data;

	public float CurrentFrozenBrokenAccHP
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.CurrentFrozenBrokenAccHP;
		}
	}

	public GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> AbnormalStateUIInfoDic
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.AbnormalStateUIInfoDic;
		}
	}

	public DS_IBUC_AbnormalStateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateData, BUC_AbnormalStateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateData>(actor);
		}
	}

	public int BindAbnormalStateUIInfoDicAdd(Action<EAbnormalStateType, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.BindAdd(Action);
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data?.AbnormalStateUIInfoDic.BindAdd(Action);
		}
		void LocalAction2()
		{
			Data?.AbnormalStateUIInfoDic.UnBindAdd(Action);
		}
	}

	public void UnBindAbnormalStateUIInfoDicAdd(int BindIdx, Action<EAbnormalStateType, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.UnBindAdd(Action);
		RemoveAction(BindIdx);
	}

	public int BindAbnormalStateUIInfoDicRemove(Action<EAbnormalStateType, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.BindRemove(Action);
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data?.AbnormalStateUIInfoDic.BindRemove(Action);
		}
		void LocalAction2()
		{
			Data?.AbnormalStateUIInfoDic.UnBindRemove(Action);
		}
	}

	public void UnBindAbnormalStateUIInfoDicRemove(int BindIdx, Action<EAbnormalStateType, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.UnBindRemove(Action);
		RemoveAction(BindIdx);
	}

	public int BindAbnormalStateUIInfoDicOneValueChange(EAbnormalStateType BindKey, Action<EAbnormalStateType, FAbnormalStateUIInfo, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.BindOneValueChange(BindKey, Action);
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data?.AbnormalStateUIInfoDic.BindOneValueChange(BindKey, Action);
		}
		void LocalAction2()
		{
			Data?.AbnormalStateUIInfoDic.UnBindOneValueChange(BindKey, Action);
		}
	}

	public void UnBindAbnormalStateUIInfoDicOneValueChange(int BindIdx, EAbnormalStateType BindKey, Action<EAbnormalStateType, FAbnormalStateUIInfo, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.UnBindOneValueChange(BindKey, Action);
		RemoveAction(BindIdx);
	}

	public int BindAbnormalStateUIInfoDicAnyOneValueChange(Action<EAbnormalStateType, FAbnormalStateUIInfo, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.BindAnyOneValueChange(Action);
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data?.AbnormalStateUIInfoDic.BindAnyOneValueChange(Action);
		}
		void LocalAction2()
		{
			Data?.AbnormalStateUIInfoDic.UnBindAnyOneValueChange(Action);
		}
	}

	public void UnBindAbnormalStateUIInfoDicAnyOneValueChange(int BindIdx, Action<EAbnormalStateType, FAbnormalStateUIInfo, FAbnormalStateUIInfo> Action)
	{
		Data?.AbnormalStateUIInfoDic.UnBindAnyOneValueChange(Action);
		RemoveAction(BindIdx);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateData, BUC_AbnormalStateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateData>(actor);
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
