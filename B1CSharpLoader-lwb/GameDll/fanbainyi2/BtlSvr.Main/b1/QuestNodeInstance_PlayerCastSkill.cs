using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_PlayerCastSkill : QuestNodeInstance
{
	private QuestCustom_PlayerCastSkill CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayerCastSkill();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void Tick(float DeltaTime)
	{
		base.Tick(DeltaTime);
		CheckCastSkill();
	}

	private void CheckCastSkill()
	{
		if (CustomData.SkillCastCondition.ConditionGroups.Count == 0)
		{
			PlayerTryCastSkill();
		}
		if (CheckCondition())
		{
			PlayerTriggerCastSkill();
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

	private void PlayerCastSkillImpl(AActor Player)
	{
		int skillId = CustomData.SkillId;
		bool needCheckSkillCanCast = true;
		FCastSkillInfo cSI = new FCastSkillInfo(skillId, ECastSkillSourceType.CQG);
		cSI.NeedCheckSkillCanCast = needCheckSkillCanCast;
		BUS_EventCollectionCS.Get(Player).Evt_UnitCastSkillTry.Invoke(cSI);
	}

	private void PlayerTryCastSkill()
	{
		ACharacter Player;
		if ((byte)CustomData.ComboKey != 0)
		{
			PlayerTriggerComboKey();
		}
		else if (BGU_CommonUtil.GetCurrentPlayer(base.Owner, out Player) && Player != null && BGU_CommonUtil.CheckSkillCanCast(Player, CustomData.SkillId, CustomData.SkillId) == ECanCastSkillResult.CCSR_OK)
		{
			PlayerCastSkillImpl(Player);
			TriggerFirstOutput(bFinish: true);
		}
	}

	private void PlayerTriggerCastSkill()
	{
		ACharacter Player;
		if ((byte)CustomData.ComboKey != 0)
		{
			PlayerTriggerComboKey();
		}
		else if (BGU_CommonUtil.GetCurrentPlayer(base.Owner, out Player) && BGU_CommonUtil.CheckSkillCanCast(Player, CustomData.SkillId, CustomData.SkillId) == ECanCastSkillResult.CCSR_OK)
		{
			PlayerCastSkillImpl(Player);
			TriggerOutput(BGW_FlowUtils.PinName.Success.ToString(), bFinish: true);
		}
		else
		{
			TriggerOutput(BGW_FlowUtils.PinName.Failed.ToString(), bFinish: true);
		}
	}

	private void PlayerTriggerComboKey()
	{
		if (!BGU_CommonUtil.GetCurrentPlayer(base.Owner, out var Player))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Player);
		if (bUS_GSEventCollection != null)
		{
			switch ((EBGUAutoTestPlayerComboKey)(byte)CustomData.ComboKey)
			{
			case EBGUAutoTestPlayerComboKey.LightAttackDown:
				bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.LightAttack, IsRelease: false);
				break;
			case EBGUAutoTestPlayerComboKey.LightAttackUp:
				bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.LightAttack, IsRelease: true);
				break;
			case EBGUAutoTestPlayerComboKey.HeavyAttackDown:
				bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.HeavyAttack, IsRelease: false);
				break;
			case EBGUAutoTestPlayerComboKey.HeavyAttackUp:
				bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.HeavyAttack, IsRelease: true);
				break;
			case EBGUAutoTestPlayerComboKey.Dodge:
				bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.Dodge, IsRelease: true);
				break;
			}
		}
		TriggerFirstOutput(bFinish: true);
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
}
