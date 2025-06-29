using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "隐藏血条" })]
public class BUEffectHiddenBloodBar : BUEffectTemplate
{
	public BUEffectHiddenBloodBar()
	{
		EffectType = EBuffAndSkillEffectType.HiddenBloodBar;
	}

	[TemplateFunNote("通过技能效果隐藏血条")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) && !b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_HiddenBloodBar.Invoke();
			}
		}
	}
}
