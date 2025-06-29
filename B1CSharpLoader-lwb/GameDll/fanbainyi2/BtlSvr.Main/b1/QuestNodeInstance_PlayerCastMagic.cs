using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf;
using ResB1;

namespace b1;

public class QuestNodeInstance_PlayerCastMagic : QuestNodeInstance
{
	private QuestCustom_PlayerCastMagic CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayerCastMagic();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		CheckCastMagic();
	}

	private void CheckCastMagic()
	{
		if (CustomData.SkillCastCondition.ConditionGroups.Count == 0 || CheckCondition())
		{
			PlayerTriggerCastMagic();
		}
	}

	private bool CheckCondition()
	{
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (Player == null)
		{
			return true;
		}
		foreach (QuestCustom_PlayerCastSkillConditionGroup conditionGroup in CustomData.SkillCastCondition.ConditionGroups)
		{
			if (BGUPlayerConditionCheckHelper.CheckAndConditionGroup(Player, conditionGroup))
			{
				return true;
			}
		}
		return false;
	}

	private void PlayerTriggerCastMagic()
	{
		if (OnTriggerCastMagic())
		{
			TriggerOutput(BGW_FlowUtils.PinName.Success.ToString(), bFinish: true);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
		}
	}

	public override byte[] GetNodeCustomData()
	{
		return new byte[0];
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}

	private bool OnTriggerCastMagic()
	{
		BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player);
		if (Player == null)
		{
			return false;
		}
		IBUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>(Player);
		if (readOnlyData == null)
		{
			return false;
		}
		IBUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Player);
		if (readOnlyData2 == null)
		{
			return false;
		}
		IBUC_SkillInputAssistData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_SkillInputAssistData, BUC_SkillInputAssistData>(Player);
		if (readOnlyData3 == null)
		{
			return false;
		}
		SpellType spellType = SpellType.Min;
		switch ((EBGUAutoTestPlayerMagicType)(byte)CustomData.CastType)
		{
		case EBGUAutoTestPlayerMagicType.ShenFa:
			spellType = SpellType.ShenFa;
			break;
		case EBGUAutoTestPlayerMagicType.HaoMao:
			spellType = SpellType.HaoMao;
			break;
		case EBGUAutoTestPlayerMagicType.QiShu:
			spellType = SpellType.QiShu;
			break;
		case EBGUAutoTestPlayerMagicType.BianShen:
			spellType = SpellType.BianShen;
			break;
		default:
			return false;
		}
		int num = 0;
		SpellEffectType spellEffectType = SpellEffectType.CastSkill;
		IBPC_TransData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(Player.PlayerState);
		IBPC_PlayerTagData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(Player.PlayerState);
		BUC_PlayerSpellConfData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(Player);
		BPC_PlayerInteractData readOnlyData7 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>(Player.PlayerState);
		BUC_AttrContainer readOnlyData8 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Player);
		if (readOnlyData4 == null || readOnlyData6.MagicConfInfo == null || readOnlyData5 == null)
		{
			return false;
		}
		if (spellType == SpellType.Min)
		{
			spellType = readOnlyData4.DefaultSpellType;
		}
		foreach (FUStMagicConfInfo item in readOnlyData6.MagicConfInfo)
		{
			if (item.Type != spellType)
			{
				continue;
			}
			if (spellType == SpellType.BianShen && !readOnlyData5.HasTag(EBGPPlayerTag.Transforming))
			{
				if (readOnlyData5.HasTag(EBGPPlayerTag.DisableTransforming))
				{
					return false;
				}
				if (readOnlyData8.GetFloatValue(EBGUAttrFloat.TransEnergyMax) > readOnlyData8.GetFloatValue(EBGUAttrFloat.CurEnergy))
				{
					return false;
				}
				if (readOnlyData7 != null && readOnlyData7.IsInInteraction())
				{
					return false;
				}
			}
			SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(item.SpellID);
			if (spellDesc != null)
			{
				num = spellDesc.SkillId;
				spellEffectType = spellDesc.EffectType;
				break;
			}
		}
		BGS_EventCollectionCS.Get(Player).Evt_BGS_TriggerShortcut.Invoke(B1: true, (int)spellType);
		if (spellEffectType != SpellEffectType.PhantomRush && readOnlyData2.HasState(EBGUUnitState.JumpMoving))
		{
			return false;
		}
		if (spellEffectType == SpellEffectType.PhantomRush)
		{
			if ((readOnlyData2.HasState(EBGUUnitState.Beatback) && readOnlyData2.HasState(EBGUUnitState.InMagicWindow)) || !readOnlyData2.HasState(EBGUUnitState.Beatback))
			{
				ESkillDirection phantomRushDir = ESkillDirection.None;
				switch ((ESkillDirection)(byte)CustomData.Direction)
				{
				case ESkillDirection.None:
				case ESkillDirection.Forward:
					phantomRushDir = ESkillDirection.Forward;
					break;
				case ESkillDirection.Backward:
					phantomRushDir = ESkillDirection.Backward;
					break;
				case ESkillDirection.Left:
					phantomRushDir = ESkillDirection.Left;
					break;
				case ESkillDirection.Right:
					phantomRushDir = ESkillDirection.Right;
					break;
				}
				BUS_EventCollectionCS.Get(Player).Evt_TriggerPhantomRush.Invoke(phantomRushDir);
				return true;
			}
			return false;
		}
		if (readOnlyData3.InputSelectingSkillID == num || (readOnlyData.CurrentCastingSkillID == num && readOnlyData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK))
		{
			return true;
		}
		return false;
	}
}
