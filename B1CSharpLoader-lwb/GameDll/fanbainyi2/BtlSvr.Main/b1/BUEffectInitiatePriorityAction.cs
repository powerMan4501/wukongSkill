using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectCaster]
public class BUEffectInitiatePriorityAction : BUEffectTemplate
{
	public BUEffectInitiatePriorityAction()
	{
		EffectType = EBuffAndSkillEffectType.InitiatePriorityAction;
	}

	[TemplateFunNote("指挥群体AI执行指定的Action")]
	[ParamInfoI(0, "指挥命令Idx（EGroupPriorityActionType）")]
	[ParamInfoS(0, "指挥指令集路径（BGWPriorityActionQueDataAsset）")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count >= 1)
			{
				string p = skillEffectDesc.EffectParamsStr[0];
				int p2 = skillEffectDesc.EffectParamsInt[0];
				BUS_EventCollectionCS.Get(Caster).Evt_InitiatePriorityAction.Invoke(p, p2);
			}
		}
	}
}
