using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "修改CD" })]
public class BUEffectModifyCooldown : BUEffectTemplate
{
	public BUEffectModifyCooldown()
	{
		EffectType = EBuffAndSkillEffectType.ModifyCooldown;
	}

	[AffectTarget]
	[ParamInfoF(0, "修改值（绝对值or万分比）")]
	[ParamInfoI(1, "加or乘（>0加，<=0乘）")]
	[ParamInfoI(0, "SkillID")]
	[TemplateFunNote("通过Buff修改技能CD")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!Target.IsNullOrDestroyed())
		{
			BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
			if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 2 && buffDescRuntime.GetFloatEffectParamCount(EffectIdx) >= 1)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
				bool bAddOrMul = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) > 0;
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				BUS_EventCollectionCS.Get(Target)?.Evt_ModifyCD.Invoke(intEffectParam, bAddOrMul, floatEffectParam);
			}
		}
	}

	[TemplateFunNote("通过技能修改技能CD")]
	[ParamInfoI(0, "SkillID")]
	[ParamInfoI(1, "加or乘（>0加，<=0乘）")]
	[ParamInfoF(0, "修改值（绝对值or万分比）")]
	[AffectTarget]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count >= 1 && skillEffectDesc.EffectParamsInt.Count >= 2)
			{
				int skillID = skillEffectDesc.EffectParamsInt[0];
				bool bAddOrMul = skillEffectDesc.EffectParamsInt[1] > 0;
				float value = skillEffectDesc.EffectParamsFloat[0];
				BUS_EventCollectionCS.Get(Target)?.Evt_ModifyCD.Invoke(skillID, bAddOrMul, value);
			}
		}
	}
}
