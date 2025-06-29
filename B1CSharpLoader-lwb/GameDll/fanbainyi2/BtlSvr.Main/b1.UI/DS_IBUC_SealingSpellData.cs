using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBUC_SealingSpellData : GSBattleDataDStore
{
	private IBUC_SealingSpellData ReadData;

	private BUC_SealingSpellData Data;

	public bool IsInSealingSpellState
	{
		get
		{
			if (ReadData == null)
			{
				return false;
			}
			return ReadData.IsInSealingSpellState;
		}
	}

	public DS_IBUC_SealingSpellData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SealingSpellData, BUC_SealingSpellData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SealingSpellData>(actor);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SealingSpellData, BUC_SealingSpellData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_SealingSpellData>(actor);
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
