using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "Buff期间，修改HitWeight为指定值；Buff结束后恢复成表里的值。" })]
public class BUEffectModifyCollisionHitWeight : BUEffectTemplate
{
	public BUEffectModifyCollisionHitWeight()
	{
		EffectType = EBuffAndSkillEffectType.ModifyCollisionHitWeight;
	}

	[TemplateFunNote("修改HitWeight")]
	[ParamInfoF(0, "新的HitWeight值")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ModifyCollisionHitWeight.Invoke(floatEffectParam);
			}
		}
	}

	[TemplateFunNote("恢复默认HitWeight")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetCollisionHitWeight.Invoke();
			}
		}
	}
}
