using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_MapSymbolData : GSBattleDataDStore
{
	private IBPC_MapSymbolData ReadData;

	private BPC_MapSymbolData Data;

	public DS_IBPC_MapSymbolData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_MapSymbolData, BPC_MapSymbolData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_MapSymbolData>(actor);
		}
	}

	public BindDictString_EMapSymbolState GetMapSymbolStateDict()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetMapSymbolStateDict();
	}

	public BindListString GetCoustomMapSymbolList()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetCoustomMapSymbolList();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_MapSymbolData, BPC_MapSymbolData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_MapSymbolData>(actor);
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
