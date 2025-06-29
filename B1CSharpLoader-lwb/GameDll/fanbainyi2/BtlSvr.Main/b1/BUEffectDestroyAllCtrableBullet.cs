using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "用于销毁所有可控制的子弹" })]
[CanUseByBulletEffect]
[AffectTarget]
public class BUEffectDestroyAllCtrableBullet : BUEffectTemplate
{
	public BUEffectDestroyAllCtrableBullet()
	{
		EffectType = EBuffAndSkillEffectType.CleanBulletCtrable;
	}

	[TemplateFunNote("通过技能销毁所有可控制的子弹")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DestroyAllCtrableBullet.Invoke();
			}
		}
	}

	[TemplateFunNote("添加Buff时销毁所有可控制的子弹")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_DestroyAllCtrableBullet.Invoke();
			}
		}
	}
}
