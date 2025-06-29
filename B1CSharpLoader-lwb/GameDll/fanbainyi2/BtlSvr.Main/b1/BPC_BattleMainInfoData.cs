using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_BattleMainInfoData : IBPC_BattleMainInfoData, IPersistentECSData
{
	public int ExtendIDForDefeatedUI;

	public EDefeatUITriggerType DefeatUITriggerType;

	public GSBindDictionary<int, BuffInstData> BattleMainBuffInstDic = new BindDictInt_BuffInstData();

	public IBUC_BattleStateData BattleStateData;

	public IBUC_SimpleStateData SimpleStateData;

	public IBUC_UnitStateData UnitStateData;

	public IBUC_MagicSpellInfoData MagicSpellInfoData;

	public IBUC_CloudMoveData CloudMoveData;

	public IBUC_EquipFaBaoData EquipFaBaoData;

	public IBUC_SealingSpellData SealingSpellData;

	public IBPC_PlayerPerformData PlayerPerformData;

	private TStrongObjectPtr<BGUCharacterCS> mOwnerCharacter = new TStrongObjectPtr<BGUCharacterCS>();

	public GSBindList<UnitBarInfo> BossBarInfo { get; set; } = new GSBindList<UnitBarInfo>();

	public GSBindList<UnitBarInfo> EliteBarInfo { get; set; } = new GSBindList<UnitBarInfo>();

	public GSBindProp<bool> CanOpenEquipPage { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> ForceCloseEquipPage { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> CanOpenMapPage { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> ForceCloseMapPage { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> CanOpenTakePhotoPage { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> KillSlowDownState { get; set; } = new GSBindProp<bool>();

	public List<int> BuffIconList { get; set; } = new List<int>();

	public GSBindDictionary<int, List<BuffInstData>> BuffIconInfo { get; set; } = new GSBindDictionary<int, List<BuffInstData>>();

	public bool bShouldUpdateBuffTime { get; set; } = true;

	public List<BGUSpellState> SpellStateList { get; set; } = new List<BGUSpellState>();

	public float VigorSkillCDPercent { get; set; }

	public float PlayerDeathUIDelayTime { get; set; } = 3f;

	public Dictionary<int, TransStateInfo> TransStateMappingBuffConfig { get; set; } = new Dictionary<int, TransStateInfo>();

	public GSBindProp<bool> State1 { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> State2 { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> State3 { get; set; } = new GSBindProp<bool>();

	public Del_Void Del_TickforState { get; set; }

	public Del_Void Del_UpdateOpenTakePhotoPageInfo { get; set; }

	public BGUCharacterCS OwnerCharacter
	{
		get
		{
			return mOwnerCharacter.Get();
		}
		set
		{
			mOwnerCharacter.Set(value);
		}
	}

	public float GetIconDuration(int IconID)
	{
		if (BuffIconInfo.ContainsKey(IconID))
		{
			return BuffIconInfo[IconID].Max((BuffInstData Data) => Data.LeftTime);
		}
		return -1f;
	}

	public EDefeatUITriggerType GetDefeatUITriggerType()
	{
		return DefeatUITriggerType;
	}

	public bool GetMagicSpellCost(int SpellID, out BGUSpellState SpellState)
	{
		BGUSpellState bGUSpellState = SpellStateList.Find((BGUSpellState State) => State.SpellID == SpellID);
		SpellState = new BGUSpellState();
		if (bGUSpellState != null && bGUSpellState.SpellID != 0)
		{
			SpellState = BGU_DeepCopyUtil.Copy(bGUSpellState);
			return true;
		}
		return false;
	}

	public int GetIconNum(int IconID)
	{
		if (BuffIconInfo.ContainsKey(IconID))
		{
			return BuffIconInfo[IconID].Count;
		}
		return 0;
	}

	public bool GetCanOpenEquipPage()
	{
		Del_TickforState();
		return CanOpenEquipPage.Value;
	}

	public bool GetForceCloseEquipPage()
	{
		Del_TickforState();
		return ForceCloseEquipPage.Value;
	}

	public bool GetCanOpenTakePhotoPage()
	{
		Del_UpdateOpenTakePhotoPageInfo();
		return CanOpenTakePhotoPage.Value;
	}

	public bool IsInBossBattle()
	{
		return BossBarInfo.Count != 0;
	}

	public bool GetCanOpenMapPage()
	{
		Del_TickforState();
		return CanOpenMapPage.Value;
	}

	public int GetExtendIDForDefeatedUI()
	{
		return ExtendIDForDefeatedUI;
	}

	private bool GetCommonDisabledState(out bool IsDisabled)
	{
		IsDisabled = false;
		if (UnitStateData == null || SimpleStateData == null)
		{
			return false;
		}
		IsDisabled = UnitStateData.HasState(EBGUUnitState.Dead) || UnitStateData.HasState(EBGUUnitState.GlideMoving) || UnitStateData.HasState(EBGUUnitState.JumpMoving) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || PlayerPerformData.IsInPerformState();
		return true;
	}

	public bool GetMagicSpellInfo(int SpellID, out FUIMagicSpellInfo MagicSpellInfo)
	{
		MagicSpellInfo = default(FUIMagicSpellInfo);
		if (SimpleStateData == null || MagicSpellInfoData == null || SealingSpellData == null)
		{
			return false;
		}
		if (!MagicSpellInfoData.GetMagicSpellInfo(SpellID, out MagicSpellInfo.IsLocked, out MagicSpellInfo.IsDisabled, out MagicSpellInfo.CDTimePercent))
		{
			return false;
		}
		SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(SpellID);
		if (spellDesc == null)
		{
			return false;
		}
		if (spellDesc.IsPassive == YesNoType.No)
		{
			MagicSpellInfo.IsForbid = SealingSpellData.IsInSealingSpellState;
			if (spellDesc.Type == SpellType.BianShen)
			{
				MagicSpellInfo.IsForbid |= SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreUnitTransSkill);
			}
		}
		return true;
	}

	public bool GetCloudMoveInfo(out FUICloudMoveInfo CloudMoveInfo)
	{
		CloudMoveInfo = default(FUICloudMoveInfo);
		if (!GetCommonDisabledState(out var IsDisabled) || BattleStateData == null || CloudMoveData == null)
		{
			return false;
		}
		CloudMoveInfo.IsDisabled = IsDisabled || BattleStateData.IsUnitInBattle() || (CloudMoveData.IsCloudMoveEnabled ? CloudMoveData.ForbidDisableCloudMove : CloudMoveData.ForbidEnableCloudMove);
		return true;
	}

	public bool GetSoulSkillInfo(out FUISoulSkillInfo SoulSkillInfo)
	{
		SoulSkillInfo = default(FUISoulSkillInfo);
		if (!GetCommonDisabledState(out var IsDisabled) || SimpleStateData == null)
		{
			return false;
		}
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreVigorSkill);
		SoulSkillInfo.IsDisabled = flag || IsDisabled || SimpleStateData.HasSimpleState(EBGUSimpleState.CantInVigorSkill);
		SoulSkillInfo.IsForbid = flag;
		SoulSkillInfo.CDTimePercent = VigorSkillCDPercent;
		return true;
	}

	public bool GetFaBaoInfo(out FUIFaBaoInfo FaBaoInfo)
	{
		FaBaoInfo = default(FUIFaBaoInfo);
		bool IsDisabled = false;
		if (!GetCommonDisabledState(out IsDisabled) || EquipFaBaoData == null || SimpleStateData == null)
		{
			return false;
		}
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.CantCastFaBao);
		FaBaoInfo.IsDisabled = flag || IsDisabled;
		FaBaoInfo.IsLocked = !EquipFaBaoData.GetCanCastFaBaoSkill();
		FaBaoInfo.IsForbid = flag;
		return true;
	}

	public bool GetUseItemInfo(out FUIUseItemInfo UseItemInfo)
	{
		UseItemInfo = default(FUIUseItemInfo);
		bool commonDisabledState = GetCommonDisabledState(out UseItemInfo.IsDisabled);
		UseItemInfo.IsDisabled |= CloudMoveData.IsCloudMoveEnabled | SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreUseItem);
		if (!OwnerCharacter.IsNullOrDestroyed() && OwnerCharacter.CharacterMovement != null)
		{
			UseItemInfo.IsDisabled |= OwnerCharacter.CharacterMovement.IsFalling();
		}
		return commonDisabledState;
	}
}
