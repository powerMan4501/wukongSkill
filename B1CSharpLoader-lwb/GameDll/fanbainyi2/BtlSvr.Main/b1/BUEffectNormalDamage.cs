using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[CanUseByBulletEffect]
[EffectTemplateTips(new string[] { "本地权威的怪被非本地控制的主角击中, 会被忽略", "会根据MappingID查找SkillDamageExpandDesc获取拓展数据" })]
public class BUEffectNormalDamage : BUEffectTemplate
{
	public BUEffectNormalDamage()
	{
		EffectType = EBuffAndSkillEffectType.SkillDamage;
	}

	[ParamInfoF(2, "技能伤害万分比")]
	[ParamInfoF(1, "技能伤害")]
	[AffectTarget]
	[ParamInfoI(6, "MappingIndex 根据该映射值查找SkillDamageExpandDesc，如果为0，则用的是Effect自身ID去查找")]
	[ParamInfoS(0, "技能霸体护甲伤害挡位")]
	[TemplateFuncTips("对于技能霸体护甲伤害，先读取【技能霸体护甲伤害挡位】，没有【技能霸体护甲伤害挡位】，再读取【技能霸体护甲伤害值】")]
	[ParamInfoS(1, "震屏DA")]
	[ParamInfoF(6, "格挡值伤害")]
	[ParamInfoI(5, "异常属性类型（0 ~ 6 : 无，冰，火，毒，雷，阴，阳）")]
	[ParamInfoF(0, "技能霸体护甲伤害值")]
	[ParamInfoI(2, "伤害特效类型（0 ~ 7 : 无特效攻击, 钝器攻击, 锐器攻击, 燃烧攻击, 燃烧攻击, 爆炸攻击, 冰冻攻击, 雷电攻击, 毒攻击）")]
	[ParamInfoI(1, "硬直EffectID")]
	[ParamInfoI(0, "攻击特效ID")]
	[TemplateFunNote("通过技能效果触发伤害")]
	[ParamInfoI(4, "属性伤害挡位")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if ((UGameplayStatics.GetGameState(Caster) != null && Caster is BGUPlayerCharacterCS bGUPlayerCharacterCS && !bGUPlayerCharacterCS.IsLocallyControlled()) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target) || b1.EffectTemplateUtil.ReturnIfUnitInLifeSavingHair(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null)
		{
			int SkillDamageExpandID;
			FUStSkillDamageExpandDesc fUStSkillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(EffectID, Caster, out SkillDamageExpandID);
			if (fUStSkillDamageExpandDesc == null)
			{
				fUStSkillDamageExpandDesc = new FUStSkillDamageExpandDesc();
			}
			BUS_EventCollectionCS.Get(Target)?.Evt_TriggerNormalDamageEffect.Invoke(Caster, new FSkillDamageConfig
			{
				DmgReason = EDamageReason.Skill,
				DmgReasonEffectID = EffectID,
				DamageCalcType = (EDamageCalcType)fUStSkillDamageExpandDesc.DamageReason,
				DamageImmueLevel = fUStSkillDamageExpandDesc.DamageImmueLevel,
				CameraShakeDA = ((skillEffectDesc.EffectParamsStr.Count > 1) ? skillEffectDesc.EffectParamsStr[1] : "")
			}, EffectInstReq, new FBattleAttrSnapShot(Caster));
		}
	}

	[ParamInfoI(7, "属性伤害挡位")]
	[ParamInfoF(0, "技能霸体护甲伤害 | 元素生命上限万分比伤害 | 血量上限万分比")]
	[ParamInfoF(1, "技能伤害")]
	[ParamInfoF(2, "技能伤害万分比")]
	[TemplateFuncTips("对于【异常属性Dot】只有整形参数4的【异常属性类型】和浮点型参数0的【元素生命上限万分比伤害】生效")]
	[TemplateFuncTips("对于【Normal[普通伤害]】浮点型参数0的意义是【技能霸体护甲伤害】")]
	[ParamInfoF(3, "是否忽略受击事件，缺省0为false，1为true")]
	[ParamInfoI(6, "伤害免疫档位")]
	[ParamInfoF(4, "暴击几率加成")]
	[ParamInfoF(5, "暴击倍率加成")]
	[ParamInfoF(6, "格挡值伤害")]
	[ParamInfoF(7, "目标当前生命伤害万分比")]
	[ParamInfoS(0, "技能霸体护甲伤害挡位")]
	[TemplateFuncTips("先区分伤害类型")]
	[ParamInfoI(5, "伤害类型（0 ~ 2 : 普通伤害, 异常属性Dot, 血量上限万分比固伤）")]
	[ParamInfoI(2, "是否触发特效（包括攻击特效和受击特效），默认是触发")]
	[ParamInfoI(3, "是否可以触发硬直反击计数，默认是触发（忽略受击事件优先度更高，假如忽略则不触发）")]
	[ParamInfoI(4, "异常属性类型（0 ~ 6 : 无，冰，火，毒，雷，阴，阳）")]
	[TemplateFuncTips("对于技能霸体护甲伤害，先读取【技能霸体护甲伤害挡位】，没有【技能霸体护甲伤害挡位】，再读取【技能霸体护甲伤害值】")]
	[TemplateFuncTips("Buff的这个Effect，不会读SkillDamageExpandDesc")]
	[TemplateFuncTips("对于【血量上限万分比固伤】只有浮点型参数0的【生命上限万分比伤害】生效")]
	[AffectTarget]
	[ParamInfoI(0, "硬直EffectID")]
	[ParamInfoI(1, "伤害特效类型（0 ~ 7 : 无特效攻击, 钝器攻击, 锐器攻击, 燃烧攻击, 燃烧攻击, 爆炸攻击, 冰冻攻击, 雷电攻击, 毒攻击）")]
	[ParamInfoS(1, "定身血量伤害万分比")]
	[TemplateFunNote("通过Buff效果触发伤害")]
	[ParamInfoS(2, "','分割字符串，字符串1：指定部位ID；字符串2：部位伤害；")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && !b1.EffectTemplateUtil.ReturnIfUnitInLifeSavingHair(Target) && !Target.IsNullOrDestroyed() && BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(Target))
		{
			AActor attacker = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
				BUS_EventCollectionCS.Get(Target)?.Evt_TriggerNormalDamageEffect.Invoke(attacker, new FSkillDamageConfig
				{
					DmgReason = EDamageReason.Buff,
					DmgReasonEffectID = BuffInst.BuffID,
					DmgReasonEffectIdx = EffectIdx,
					BuffOwner = EntitySharedRefFuncLib.Actor(BuffInst.OwnerRef),
					DamageCalcType = ((intEffectParamCount > 5) ? ((EDamageCalcType)buffDescRuntime.GetIntEffectParam(EffectIdx, 5)) : EDamageCalcType.Normal),
					DamageImmueLevel = ((intEffectParamCount > 6) ? buffDescRuntime.GetIntEffectParam(EffectIdx, 6) : 0)
				}, EffectInstReq, BuffInst.Caster_AttrMemData);
			}
		}
	}
}
