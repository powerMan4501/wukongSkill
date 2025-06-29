using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_GameStateTestData : GSBattleDataDStore
{
	private IBGC_GameStateTestData ReadData;

	private BGC_GameStateTestData Data;

	public int TestID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.TestID;
		}
	}

	public bool StopOptimizeTickRate
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.StopOptimizeTickRate;
		}
	}

	public DS_IBGC_GameStateTestData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_GameStateTestData, BGC_GameStateTestData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_GameStateTestData>(actor);
		}
	}

	public int BindTestIDChange(Action<int, int> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnTestIDChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnTestIDChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnTestIDChg -= ChangeHandler;
		}
	}

	public void UnBindTestIDChange(int BindIdx, Action<int, int> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnTestIDChg -= ChangeHandler;
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_GameStateTestData, BGC_GameStateTestData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_GameStateTestData>(actor);
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
