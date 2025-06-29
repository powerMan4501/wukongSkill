using System;
using System.Collections.Generic;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_TransGuideData : GSBattleDataDStore
{
	private IBUC_TransGuideData ReadData;

	private BUC_TransGuideData Data;

	public Dictionary<int, TransInputUITipsDesc> TransGuideDict
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.TransGuideDict;
		}
	}

	public GSBindProp<bool> CanShowUI
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CanShowUI;
		}
	}

	public DS_IBUC_TransGuideData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TransGuideData, BUC_TransGuideData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TransGuideData>(actor);
		}
	}

	public int GetResId()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetResId();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TransGuideData, BUC_TransGuideData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TransGuideData>(actor);
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
