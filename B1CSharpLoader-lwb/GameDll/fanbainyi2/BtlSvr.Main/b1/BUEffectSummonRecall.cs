using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "这个效果是作用在召唤物身上的，触发召唤物被召唤者召回" })]
public class BUEffectSummonRecall : BUEffectTemplate
{
	public BUEffectSummonRecall()
	{
		EffectType = EBuffAndSkillEffectType.SummonRecall;
	}

	[AffectTarget]
	[TemplateFunNote("通过技能触发召唤者召回召唤物")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Target);
		if (readOnlyData != null)
		{
			AActor masterActor = readOnlyData.GetMasterActor();
			if (masterActor != null)
			{
				BUS_EventCollectionCS.Get(masterActor).Evt_SummonRecall.Invoke(Target);
			}
		}
	}

	[AffectTarget]
	[TemplateFunNote("通过Buff触发召唤者召回召唤物")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Target);
		if (readOnlyData != null)
		{
			AActor masterActor = readOnlyData.GetMasterActor();
			if (masterActor != null)
			{
				BUS_EventCollectionCS.Get(masterActor).Evt_SummonRecall.Invoke(Target);
			}
		}
	}
}
