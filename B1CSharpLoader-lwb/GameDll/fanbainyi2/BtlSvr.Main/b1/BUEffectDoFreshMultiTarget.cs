using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "刷新多目标" })]
public class BUEffectDoFreshMultiTarget : BUEffectTemplate
{
	public BUEffectDoFreshMultiTarget()
	{
		EffectType = EBuffAndSkillEffectType.DoFreshMultiTarget;
	}

	[AffectCaster]
	[ParamInfoI(4, "选取条件参数2")]
	[ParamInfoI(3, "选取条件参数1")]
	[ParamInfoI(2, "选取条件类型：\n0\t全选\t/\t/\r\n1\t是否有Buff\tBuffID\t/\r\n2\t是否有UnitState\tUnitStateID\t/\r\n3\t是否有SimpleState\tSimpleStateID\t/\r\n4\tHP是否在范围内（万分比）\t万分比min\t万分比max\r\n")]
	[ParamInfoF(0, "搜索范围（厘米）")]
	[ParamInfoI(0, "筛选单位阵营Filter（规则相加：1 自己，2 队友，4 敌人）")]
	[TemplateFunNote("通过技能刷新多目标")]
	[TemplateFuncTips("Int类型参数里，填入多少个就会解除对应的异常属性状态")]
	[ParamInfoI(1, "筛选单位类型Filter（规则相加：1 Character，2 Bullet，4 MagicField）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count >= 1 && skillEffectDesc.EffectParamsInt.Count >= 5)
			{
				float skillEffectDescFloatEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescFloatEffectParam(skillEffectDesc, 0);
				int skillEffectDescIntEffectParam = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 0);
				int skillEffectDescIntEffectParam2 = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 1);
				EMultiTargetConditionType multiTargetConditionType = (EMultiTargetConditionType)b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 2);
				int skillEffectDescIntEffectParam3 = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 3);
				int skillEffectDescIntEffectParam4 = b1.EffectTemplateUtil.GetSkillEffectDescIntEffectParam(skillEffectDesc, 4);
				BUS_EventCollectionCS.Get(Caster).Evt_DoFreshMultiTarget.Invoke(skillEffectDescFloatEffectParam, skillEffectDescIntEffectParam, skillEffectDescIntEffectParam2, multiTargetConditionType, skillEffectDescIntEffectParam3, skillEffectDescIntEffectParam4);
			}
		}
	}
}
