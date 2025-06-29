using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_PlayerGuideData : GSBattleDataDStore
{
	private IBGC_PlayerGuideData ReadData;

	private BGC_PlayerGuideData Data;

	public BindListInt CheckListNodeGuideList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CheckListNodeGuideList;
		}
	}

	public BindListInt ProceedGroupGuideList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ProceedGroupGuideList;
		}
	}

	public BindListInt FinishedGroupGuideList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.FinishedGroupGuideList;
		}
	}

	public DS_IBGC_PlayerGuideData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_PlayerGuideData, BGC_PlayerGuideData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_PlayerGuideData>(actor);
		}
	}

	public bool IsGroupGuideCompleted(IList<int> InGroupGuideList)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsGroupGuideCompleted(InGroupGuideList);
	}

	public bool IsGroupGuideCompleted(int InGroupGuideId)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsGroupGuideCompleted(InGroupGuideId);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_PlayerGuideData, BGC_PlayerGuideData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_PlayerGuideData>(actor);
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
