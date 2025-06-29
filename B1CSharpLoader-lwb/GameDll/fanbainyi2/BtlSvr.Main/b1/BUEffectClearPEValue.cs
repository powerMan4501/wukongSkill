using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "清空棍势值并添加棍势清空保护状态" })]
[CantUseInMultiEffect]
public class BUEffectClearPEValue : BUEffectTemplate
{
	public BUEffectClearPEValue()
	{
		EffectType = EBuffAndSkillEffectType.ClearPevalue;
	}

	[TemplateFunNote("Skill触发时清空棍势")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!b1.EffectTemplateUtil.ReturnIfUnitDead(Target) && BGW_GameDB.GetSkillEffectDesc(EffectID, Target) != null)
		{
			BUS_EventCollectionCS.Get(Target).Evt_ClearPEValue.Invoke();
		}
	}

	[TemplateFunNote("Buff触发时清空棍势")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst) != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ClearPEValue.Invoke();
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PEClearProtect);
			}
		}
	}

	[TemplateFunNote("Buff移除时清理棍势保护状态")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.PEClearProtect, IsRemove: true);
		}
	}
}
