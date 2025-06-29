using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "增加所有召唤物持续时间" })]
[CantUseInMultiEffect]
public class BUEffectAddAllSummonLifeTime : BUEffectTemplate
{
	public BUEffectAddAllSummonLifeTime()
	{
		EffectType = EBuffAndSkillEffectType.AddAllSummonLifeTime;
	}

	[ParamInfoF(0, "增加的时常")]
	[TemplateFunNote("通过SkillEffect增加持续时间")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count > 0)
		{
			if (skillEffectDesc.EffectParamsInt.Count > 0)
			{
				bUS_GSEventCollection.Evt_AddAllSummonLifeTime.Invoke(skillEffectDesc.EffectParamsFloat[0], skillEffectDesc.EffectParamsInt.ToList());
			}
			else
			{
				bUS_GSEventCollection.Evt_AddAllSummonLifeTime.Invoke(skillEffectDesc.EffectParamsFloat[0]);
			}
		}
	}

	[TemplateFunNote("通过Buff增加持续时间")]
	[ParamInfoF(0, "增加的时常")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (buffDescRuntime.GetFloatEffectParamCount(EffectIdx) > 0)
		{
			if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 0)
			{
				bUS_GSEventCollection.Evt_AddAllSummonLifeTime.Invoke(buffDescRuntime.GetFloatEffectParam(EffectIdx, 0), buffDescRuntime.GetIntEffectParamList(EffectIdx));
			}
			else
			{
				bUS_GSEventCollection.Evt_AddAllSummonLifeTime.Invoke(buffDescRuntime.GetFloatEffectParam(EffectIdx, 0));
			}
		}
	}
}
