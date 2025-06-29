using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "抛起死亡单位", "非死亡单位则无效" })]
public class BUEffectThrowUpDeadUnit : BUEffectTemplate
{
	public BUEffectThrowUpDeadUnit()
	{
		EffectType = EBuffAndSkillEffectType.ThrowUpDeadUnit;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ThrowUpDeadUnit.Invoke();
			}
		}
	}
}
