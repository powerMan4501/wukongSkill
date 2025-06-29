using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "目前来看，这个已经没有逻辑了" })]
[AffectTarget]
public class BUEffectDropAttrItem : BUEffectTemplate
{
	public BUEffectDropAttrItem()
	{
		EffectType = EBuffAndSkillEffectType.DropAttrItem;
	}

	[ParamInfoI(3, "1：通知UI")]
	[ParamInfoI(1, "属性ID")]
	[ParamInfoI(2, "属性值")]
	[ParamInfoI(0, "属性类型 0:IntAttr 1:FloatAttr 2:TeamAttr")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		int num = skillEffectDesc.EffectParamsInt[0];
		_ = skillEffectDesc.EffectParamsInt[1];
		int num2 = skillEffectDesc.EffectParamsInt[2];
		bool flag = skillEffectDesc.EffectParamsInt[3] == 1;
		switch (num)
		{
		case 2:
			if (flag)
			{
				BUS_EventCollectionCS.Get(Target).Evt_TriggerCurveFlyAnim.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster), num2);
			}
			break;
		case 0:
		case 1:
			break;
		}
	}
}
