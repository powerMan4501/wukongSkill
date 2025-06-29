using System;
using System.Collections.Generic;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_PlayerRoleData : GSBattleDataDStore
{
	private IBPC_PlayerRoleData ReadData;

	private BPC_PlayerRoleData Data;

	public EffectAttrList AttrFloatList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.AttrFloatList;
		}
	}

	public ReadOnlyRoleData RoleData
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.RoleData;
		}
	}

	public ReadOnlyRoleDataClient RoleData_Client
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.RoleData_Client;
		}
	}

	public int BeginAreaStayTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.BeginAreaStayTime;
		}
	}

	public int LastRebirthPointTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.LastRebirthPointTime;
		}
	}

	public int MapAreaId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.MapAreaId;
		}
	}

	public int MaxMapAreaId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.MaxMapAreaId;
		}
	}

	public int MaxMapId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.MaxMapId;
		}
	}

	public int MapId
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.MapId;
		}
	}

	public int DefaultShortcutsPosition
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.DefaultShortcutsPosition;
		}
	}

	public BindDictInt_GSUnitBookData UnitBookDataDic
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.UnitBookDataDic;
		}
	}

	public DS_IBPC_PlayerRoleData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerRoleData>(actor);
		}
	}

	public int GetGameTotalTime()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetGameTotalTime();
	}

	public int GetNewGamePlusCount()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetNewGamePlusCount();
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_PlayerRoleData>(actor);
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
