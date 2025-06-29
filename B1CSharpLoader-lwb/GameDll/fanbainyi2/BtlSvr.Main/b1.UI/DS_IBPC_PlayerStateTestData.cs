using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_PlayerStateTestData : GSBattleDataDStore
{
	private IBPC_PlayerStateTestData ReadData;

	private BPC_PlayerStateTestData Data;

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

	public DS_IBPC_PlayerStateTestData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerStateTestData, BPC_PlayerStateTestData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerStateTestData>(actor);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerStateTestData, BPC_PlayerStateTestData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerStateTestData>(actor);
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
