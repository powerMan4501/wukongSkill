using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "设置聚形散气配置DA" })]
public class BUEffectSetPhantomRushConfig : BUEffectTemplate
{
	public BUEffectSetPhantomRushConfig()
	{
		EffectType = EBuffAndSkillEffectType.SetPhantomRushConfig;
	}

	[TemplateFunNote("使用技能设置聚形散气配置DA")]
	[ParamInfoI(0, "ConfigID")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
			if (skillEffectDesc != null)
			{
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				bUS_GSEventCollection.Evt_SetPhantomRushConfigID.Invoke(skillEffectDescIntEffectParam);
			}
		}
	}

	[TemplateFunNote("使用Buff设置聚形散气配置DA")]
	[ParamInfoI(0, "ConfigID")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bUS_GSEventCollection.Evt_SetPhantomRushConfigID.Invoke(intEffectParam);
			}
		}
	}
}
