using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "Buff添加时改变缩放", "Buff移除时缩放改为1" })]
[AffectTarget]
public class BUEffectScalingBulletSpd : BUEffectTemplate
{
	public BUEffectScalingBulletSpd()
	{
		EffectType = EBuffAndSkillEffectType.ScalingBulletSpd;
	}

	[ParamInfoF(0, "缩放的大小")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
				bUS_GSEventCollection.Evt_OnSetBulletSpdScale.Invoke(buffDescRuntime.GetFloatEffectParam(EffectIdx, 0));
			}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnSetBulletSpdScale.Invoke(1f);
			}
		}
	}
}
