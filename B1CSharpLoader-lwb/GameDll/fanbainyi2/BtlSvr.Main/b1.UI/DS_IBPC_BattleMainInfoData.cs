using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DS_IBPC_BattleMainInfoData : GSBattleDataDStore
{
	private IBPC_BattleMainInfoData ReadData;

	private BPC_BattleMainInfoData Data;

	public GSBindList<UnitBarInfo> BossBarInfo
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BossBarInfo;
		}
	}

	public GSBindList<UnitBarInfo> EliteBarInfo
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.EliteBarInfo;
		}
	}

	public GSBindProp<bool> CanOpenEquipPage
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CanOpenEquipPage;
		}
	}

	public GSBindProp<bool> ForceCloseEquipPage
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ForceCloseEquipPage;
		}
	}

	public GSBindProp<bool> CanOpenMapPage
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.CanOpenMapPage;
		}
	}

	public GSBindProp<bool> ForceCloseMapPage
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.ForceCloseMapPage;
		}
	}

	public GSBindProp<bool> KillSlowDownState
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.KillSlowDownState;
		}
	}

	public List<int> BuffIconList
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.BuffIconList;
		}
	}

	public float PlayerDeathUIDelayTime
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.PlayerDeathUIDelayTime;
		}
	}

	public float VigorSkillCDPercent
	{
		get
		{
			if (ReadData == null)
			{
				return 0f;
			}
			return ReadData.VigorSkillCDPercent;
		}
	}

	public GSBindProp<bool> State1
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.State1;
		}
	}

	public GSBindProp<bool> State2
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.State2;
		}
	}

	public GSBindProp<bool> State3
	{
		get
		{
			if (ReadData == null)
			{
				return null;
			}
			return ReadData.State3;
		}
	}

	public DS_IBPC_BattleMainInfoData(AActor actor)
		: base(actor)
	{
		if (!actor.IsNullOrDestroyed())
		{
			ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_BattleMainInfoData, BPC_BattleMainInfoData>(actor);
			Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_BattleMainInfoData>(actor);
		}
	}

	public bool IsInBossBattle()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.IsInBossBattle();
	}

	public bool GetCanOpenEquipPage()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanOpenEquipPage();
	}

	public bool GetForceCloseEquipPage()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetForceCloseEquipPage();
	}

	public bool GetCanOpenTakePhotoPage()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanOpenTakePhotoPage();
	}

	public bool GetCanOpenMapPage()
	{
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCanOpenMapPage();
	}

	public float GetIconDuration(int IconID)
	{
		if (ReadData == null)
		{
			return 0f;
		}
		return ReadData.GetIconDuration(IconID);
	}

	public int GetIconNum(int IconID)
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetIconNum(IconID);
	}

	public bool GetMagicSpellCost(int SpellID, out BGUSpellState SpellState)
	{
		SpellState = null;
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetMagicSpellCost(SpellID, out SpellState);
	}

	public int GetExtendIDForDefeatedUI()
	{
		if (ReadData == null)
		{
			return 0;
		}
		return ReadData.GetExtendIDForDefeatedUI();
	}

	public EDefeatUITriggerType GetDefeatUITriggerType()
	{
		if (ReadData == null)
		{
			return EDefeatUITriggerType.None;
		}
		return ReadData.GetDefeatUITriggerType();
	}

	public bool GetMagicSpellInfo(int SpellID, out FUIMagicSpellInfo MagicSpellInfo)
	{
		MagicSpellInfo = default(FUIMagicSpellInfo);
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetMagicSpellInfo(SpellID, out MagicSpellInfo);
	}

	public bool GetCloudMoveInfo(out FUICloudMoveInfo CloudMoveInfo)
	{
		CloudMoveInfo = default(FUICloudMoveInfo);
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetCloudMoveInfo(out CloudMoveInfo);
	}

	public bool GetSoulSkillInfo(out FUISoulSkillInfo SoulInfo)
	{
		SoulInfo = default(FUISoulSkillInfo);
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetSoulSkillInfo(out SoulInfo);
	}

	public bool GetFaBaoInfo(out FUIFaBaoInfo FaBaoInfo)
	{
		FaBaoInfo = default(FUIFaBaoInfo);
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetFaBaoInfo(out FaBaoInfo);
	}

	public bool GetUseItemInfo(out FUIUseItemInfo UseItemInfo)
	{
		UseItemInfo = default(FUIUseItemInfo);
		if (ReadData == null)
		{
			return false;
		}
		return ReadData.GetUseItemInfo(out UseItemInfo);
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
		ReadData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBPC_BattleMainInfoData, BPC_BattleMainInfoData>(actor);
		Data = BGU_DataUtil.GetUnPersistentReadOnlyData<BPC_BattleMainInfoData>(actor);
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
