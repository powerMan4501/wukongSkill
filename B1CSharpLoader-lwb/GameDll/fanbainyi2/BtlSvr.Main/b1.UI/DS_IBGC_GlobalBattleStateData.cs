using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBGC_GlobalBattleStateData : GSBattleDataDStore
{
	private IBGC_GlobalBattleStateData ReadData;

	private BGC_GlobalBattleStateData Data;

	public Dictionary<string, BGUCharacterCS> CanForceLeaveBattleUnits
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CanForceLeaveBattleUnits;
		}
	}

	public DS_IBGC_GlobalBattleStateData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_GlobalBattleStateData>(actor);
		}
	}

	public List<Entity> GetInBattleUnitByBloodBarType(EBGUBloodBarType BloodBarType)
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetInBattleUnitByBloodBarType(BloodBarType);
	}

	public List<Entity> GetAllInBattleUnitByBloodBarType()
	{
		if (ReadData == null)
		{
			return null;
		}
		return ReadData.GetAllInBattleUnitByBloodBarType();
	}

	public bool IsBossRoomMonster(string UnitGuid)
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsBossRoomMonster(UnitGuid);
	}

	public bool IsInBossRoom()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInBossRoom();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BGC_GlobalBattleStateData>(actor);
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
