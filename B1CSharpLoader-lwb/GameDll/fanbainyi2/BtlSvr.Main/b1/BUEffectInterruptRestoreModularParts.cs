using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "打断模块化部件恢复" })]
public class BUEffectInterruptRestoreModularParts : BUEffectTemplate
{
	public BUEffectInterruptRestoreModularParts()
	{
		EffectType = EBuffAndSkillEffectType.InterruptRestoreModularParts;
	}

	[TemplateFunNote("技能打断模块化部件恢复")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Owner, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Owner))
		{
			BUS_EventCollectionCS.Get(Owner).Evt_TryToInterruptRestoreModularParts.Invoke();
		}
	}
}
