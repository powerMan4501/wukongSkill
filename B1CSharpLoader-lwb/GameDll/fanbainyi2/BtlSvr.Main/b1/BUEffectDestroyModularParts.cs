using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "模块化部件销毁" })]
[AffectCaster]
public class BUEffectDestroyModularParts : BUEffectTemplate
{
	public BUEffectDestroyModularParts()
	{
		EffectType = EBuffAndSkillEffectType.DestroyModularParts;
	}

	[ParamInfoS(0, "父骨骼名")]
	[ParamInfoS(1, "需要关闭碰撞等的ComponentTag")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			string boneName = ((skillEffectDesc.EffectParamsStr.Count > 0) ? skillEffectDesc.EffectParamsStr[0] : "");
			string componentTag = ((skillEffectDesc.EffectParamsStr.Count > 1) ? skillEffectDesc.EffectParamsStr[1] : "");
			BUS_EventCollectionCS.Get(Caster).Evt_DestroyModularParts.Invoke(boneName, componentTag);
		}
	}
}
