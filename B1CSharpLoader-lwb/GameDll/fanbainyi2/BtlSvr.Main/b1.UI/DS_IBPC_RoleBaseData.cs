using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_RoleBaseData : GSBattleDataDStore
{
	private IBPC_RoleBaseData ReadData;

	private BPC_RoleBaseData Data;

	public string RoleName
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.RoleName;
		}
	}

	public ulong RoleId
	{
		get
		{
			if (ReadData == null)
			{
				return 0uL;
			}
			return ReadData.RoleId;
		}
	}

	public int RoleLevel
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.RoleLevel;
		}
	}

	public int SoulSkillID
	{
		get
		{
			if (ReadData == null)
			{
				return 0;
			}
			return ReadData.SoulSkillID;
		}
	}

	public BindDictEquipPosition_Int EquipList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.EquipList;
		}
	}

	public BindDictInt_Int TalenList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.TalenList;
		}
	}

	public DS_IBPC_RoleBaseData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_RoleBaseData>(actor);
		}
	}

	public int BindRoleNameChange(Action<string, string> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnRoleNameChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnRoleNameChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnRoleNameChg -= ChangeHandler;
		}
	}

	public void UnBindRoleNameChange(int BindIdx, Action<string, string> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnRoleNameChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindRoleIdChange(Action<ulong, ulong> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnRoleIdChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnRoleIdChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnRoleIdChg -= ChangeHandler;
		}
	}

	public void UnBindRoleIdChange(int BindIdx, Action<ulong, ulong> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnRoleIdChg -= ChangeHandler;
			RemoveAction(BindIdx);
		}
	}

	public int BindRoleLevelChange(Action<int, int> ChangeHandler)
	{
		if (Data == null)
		{
			return -1;
		}
		Data.OnRoleLevelChg += ChangeHandler;
		BindAction(LocalAction, LocalAction2);
		return BindIdx;
		void LocalAction()
		{
			Data.OnRoleLevelChg += ChangeHandler;
		}
		void LocalAction2()
		{
			Data.OnRoleLevelChg -= ChangeHandler;
		}
	}

	public void UnBindRoleLevelChange(int BindIdx, Action<int, int> ChangeHandler)
	{
		if (Data != null)
		{
			Data.OnRoleLevelChg -= ChangeHandler;
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_RoleBaseData, BPC_RoleBaseData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_RoleBaseData>(actor);
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
