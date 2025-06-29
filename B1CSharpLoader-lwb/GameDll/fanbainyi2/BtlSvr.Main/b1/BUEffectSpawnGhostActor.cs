using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSpawnGhostActor : BUEffectTemplate
{
	public BUEffectSpawnGhostActor()
	{
		EffectType = EBuffAndSkillEffectType.SpawnGhostActor;
	}

	[ParamInfoS(0, "BGWDataAsset_GhostActorSetting路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SpawnGhostActor.Invoke(skillEffectDesc.EffectParamsStr[0], EffectInstReq);
			}
		}
	}

	[ParamInfoS(0, "BGWDataAsset_GhostActorSetting路径")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SpawnGhostActor.Invoke(stringEffectParam, EffectInstReq);
			}
		}
	}
}
