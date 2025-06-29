using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectDestroyProjectileByID : BUEffectTemplate
{
	public BUEffectDestroyProjectileByID()
	{
		EffectType = EBuffAndSkillEffectType.DestroyProjectileById;
	}

	[ParamInfoI(2, "同上，int参数是子弹ID数组")]
	[AffectTarget]
	[ParamInfoI(1, "子弹ID")]
	[TemplateFunNote("通过技能效果触发销毁子弹群")]
	[ParamInfoI(0, "子弹ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Target);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsInt.Count >= 1)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				List<int> projectileID = skillEffectDesc.EffectParamsInt.ToList();
				bUS_GSEventCollection.Evt_DestroyProjectileByID.Invoke(projectileID);
			}
		}
	}

	[ParamInfoI(2, "同上，int参数是子弹ID数组")]
	[TemplateFunNote("通过Buff触发销毁子弹群")]
	[ParamInfoI(0, "子弹ID")]
	[ParamInfoI(1, "子弹ID")]
	[AffectTarget]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 1)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (bUS_GSEventCollection != null)
			{
				List<int> intEffectParamList = buffDescRuntime.GetIntEffectParamList(EffectIdx);
				bUS_GSEventCollection.Evt_DestroyProjectileByID.Invoke(intEffectParamList);
			}
		}
	}
}
