using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public readonly struct FLoadingTipsPlayerDeadInfo
{
	private enum ECastDeadIdReason
	{
		None,
		Skill,
		Buff
	}

	private readonly ECastDeadIdReason _castDeadIdReason;

	private readonly int _castId;

	private readonly AActor _attacker;

	private readonly AActor _player;

	private readonly EDeadReason _deadReason;

	public FLoadingTipsPlayerDeadInfo(AActor Attacker, AActor Player, EDeadReason DeadReason, FEffectInstReq EffectInstReq, int DmgId)
	{
		this = default(FLoadingTipsPlayerDeadInfo);
		_attacker = Attacker;
		_player = Player;
		_deadReason = DeadReason;
		if (EffectInstReq.TriggerSkillId > 0)
		{
			_castId = EffectInstReq.TriggerSkillId;
			_castDeadIdReason = ECastDeadIdReason.Skill;
		}
		else if (DmgId > 0)
		{
			_castId = DmgId;
			_castDeadIdReason = ECastDeadIdReason.Buff;
		}
	}

	public void SetBattleParamData(FLoadingTipsBattleParam BattleParam)
	{
		BUC_AbnormalStateHandlers unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AbnormalStateHandlers>(_player);
		if (unPersistentReadOnlyData != null)
		{
			BattleParam.AbnormalStates.AddRange(from item in unPersistentReadOnlyData.GetInFinalStateList()
				select (int)item);
		}
		switch (_castDeadIdReason)
		{
		case ECastDeadIdReason.None:
			BattleParam.CastPlayerDeadSkillId = 0;
			BattleParam.CastPlayerDeadBuffId = 0;
			break;
		case ECastDeadIdReason.Skill:
			BattleParam.CastPlayerDeadSkillId = _castId;
			break;
		case ECastDeadIdReason.Buff:
			BattleParam.CastPlayerDeadBuffId = _castId;
			break;
		}
		BattleParam.CastPlayerDeadUnitResId = BGU_DataUtil.GetActorResID(_attacker);
		BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(_attacker);
		if (readOnlyData != null)
		{
			float floatValue = readOnlyData.GetFloatValue(EBGUAttrFloat.Hp);
			float floatValue2 = readOnlyData.GetFloatValue(EBGUAttrFloat.HpMax);
			if (floatValue2 > 0f && floatValue2 >= floatValue)
			{
				BattleParam.AttackerRemainedHp = (int)(floatValue / floatValue2 * 10000f);
			}
		}
		BUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(_player);
		if (readOnlyData2 != null)
		{
			float floatValue3 = readOnlyData2.GetFloatValue(EBGUAttrFloat.Mp);
			float floatValue4 = readOnlyData2.GetFloatValue(EBGUAttrFloat.MpMax);
			if (floatValue4 > 0f && floatValue4 >= floatValue3)
			{
				BattleParam.PlayerRemainedMp = (int)(floatValue3 / floatValue4 * 10000f);
			}
		}
		BUC_SimpleStateData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(_player);
		if (readOnlyData3 != null)
		{
			BattleParam.IsInSuperArmorState = readOnlyData3.HasSimpleState(EBGUSimpleState.SkillSuperArmor) || readOnlyData3.HasSimpleState(EBGUSimpleState.ImmueStiff);
		}
		BattleParam.IsFallOrDeadZoneDead = _deadReason == EDeadReason.DeadZone || _deadReason == EDeadReason.FallDead;
		BGUFuncLibSelectTargetsCS.SelectUnitsInCircle(_player, out var OutActors, _player, _player.GetActorLocation(), 1, new List<int> { 2000 });
		BattleParam.AttackerNumWithinRadius = OutActors.Count((AActor SelectedActor) => BGU_DataUtil.GetActorType(SelectedActor) == BGU_ActorType.CharacterAI);
		BattleParam.LoadingTipsType = ELoadingTipsType.Death;
	}
}
