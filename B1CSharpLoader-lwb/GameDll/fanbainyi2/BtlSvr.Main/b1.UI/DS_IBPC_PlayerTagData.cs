using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_PlayerTagData : GSBattleDataDStore
{
	private IBPC_PlayerTagData ReadData;

	private BPC_PlayerTagData Data;

	public DS_IBPC_PlayerTagData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerTagData>(actor);
		}
	}

	public bool HasTag(EBGPPlayerTag PlayerTag)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.HasTag(PlayerTag);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerTagData>(actor);
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
