using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "控制抛射物生命周期结束" })]
[CantUseInMultiEffect]
public class BUEffectCastProjectileLifeOver : BUEffectTemplate
{
	public BUEffectCastProjectileLifeOver()
	{
		EffectType = EBuffAndSkillEffectType.CastProjectileLifeOver;
	}

	[TemplateFunNote("Skill触发时结束所选子弹生命周期")]
	[ParamInfoI(0, "子弹数量")]
	[ParamInfoI(1, "筛选模式")]
	[ParamInfoI(2, "FilterID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 2)
		{
			return;
		}
		int number = skillEffectDesc.EffectParamsInt[0];
		int num = skillEffectDesc.EffectParamsInt[1];
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		ESwitchFilterMode eSwitchFilterMode = num switch
		{
			0 => ESwitchFilterMode.Nearest, 
			1 => ESwitchFilterMode.InNest, 
			2 => ESwitchFilterMode.IsFresh, 
			3 => ESwitchFilterMode.FilterID, 
			4 => ESwitchFilterMode.NearestToTarget, 
			_ => ESwitchFilterMode.Nearest, 
		};
		int filterBulletID = 0;
		if (eSwitchFilterMode == ESwitchFilterMode.FilterID)
		{
			if (skillEffectDesc.EffectParamsInt.Count < 3)
			{
				return;
			}
			filterBulletID = skillEffectDesc.EffectParamsInt[2];
		}
		bUS_GSEventCollection.Evt_CastProjectileLifeOver.Invoke(number, eSwitchFilterMode, filterBulletID);
	}
}
