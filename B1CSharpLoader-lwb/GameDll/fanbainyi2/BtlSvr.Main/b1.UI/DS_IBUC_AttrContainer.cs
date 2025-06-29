using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_AttrContainer : GSBattleDataDStore
{
	private IBUC_AttrContainer ReadData;

	private BUC_AttrContainer Data;

	public DS_IBUC_AttrContainer(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AttrContainer>(actor);
		}
	}

	public int BindFloatAttrsOnSetIdxValue(Action<int, float, float> Action)
	{
		Data?.FloatAttrs.BindOnSetIdxValue(Action);
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data?.FloatAttrs.BindOnSetIdxValue(Action);
		}
		void LocalAction2()
		{
			Data?.FloatAttrs.UnBindOnSetIdxValue(Action);
		}
	}

	public void UnBindFloatAttrsOnSetIdxValue(int BindIdx, Action<int, float, float> Action)
	{
		Data?.FloatAttrs.UnBindOnSetIdxValue(Action);
		RemoveAction(BindIdx);
	}

	public float GetFloatValue(EBGUAttrFloat AttrID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetFloatValue(AttrID);
	}

	public float GetFloatValMin(EBGUAttrFloat AttrID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetFloatValMin(AttrID);
	}

	public float GetFloatValMax(EBGUAttrFloat AttrID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetFloatValMax(AttrID);
	}

	public void BindOneValueChanged(Action<int, float, float> ActionChange)
	{
		if (ReadData != null)
		{
			ReadData.BindOneValueChanged(ActionChange);
		}
	}

	public bool GetAttrSnapShot(out FAttrSnapShot OutAttrSnapShot)
	{
		OutAttrSnapShot = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetAttrSnapShot(out OutAttrSnapShot);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AttrContainer>(actor);
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
