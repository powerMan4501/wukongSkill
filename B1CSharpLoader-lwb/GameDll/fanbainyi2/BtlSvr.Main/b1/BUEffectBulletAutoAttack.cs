using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[CanUseByBulletEffect]
[EffectTemplateTips(new string[] { "子弹自动攻击" })]
[AffectTarget]
public class BUEffectBulletAutoAttack : BUEffectTemplate
{
	public BUEffectBulletAutoAttack()
	{
		EffectType = EBuffAndSkillEffectType.BulletAutoAttack;
	}

	[ParamInfoF(0, "切换时间间隔")]
	[ParamInfoI(3, "筛选子弹ID")]
	[ParamInfoI(2, "筛选模式，0为最近，1为在巢中，2为新鲜的，3为过滤ID，其他为最近")]
	[ParamInfoF(1, "过滤剩余生命时间短于该值的子弹")]
	[ParamInfoI(0, "子弹SwitchID")]
	[TemplateFunNote("通过技能效果进行子弹自动攻击, int参数至少为3个， float参数至少为2个")]
	[ParamInfoI(1, "子弹数量")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 3 || skillEffectDesc.EffectParamsFloat.Count < 2)
		{
			return;
		}
		int num = skillEffectDesc.EffectParamsInt[0];
		int ctr_number = skillEffectDesc.EffectParamsInt[1];
		int num2 = skillEffectDesc.EffectParamsInt[2];
		float switchInterval = skillEffectDesc.EffectParamsFloat[0];
		float destroyTimeFilter = skillEffectDesc.EffectParamsFloat[1];
		if (BGW_GameDB.GetBulletSwitchDesc(num) == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		ESwitchFilterMode eSwitchFilterMode = num2 switch
		{
			0 => ESwitchFilterMode.Nearest, 
			1 => ESwitchFilterMode.InNest, 
			2 => ESwitchFilterMode.IsFresh, 
			3 => ESwitchFilterMode.FilterID, 
			_ => ESwitchFilterMode.Nearest, 
		};
		int filterBulletID = 0;
		if (eSwitchFilterMode == ESwitchFilterMode.FilterID)
		{
			if (skillEffectDesc.EffectParamsInt.Count < 4)
			{
				return;
			}
			filterBulletID = skillEffectDesc.EffectParamsInt[3];
		}
		bUS_GSEventCollection.Evt_CastBulletAuto.Invoke(ctr_number, num, switchInterval, destroyTimeFilter, eSwitchFilterMode, filterBulletID, Target);
	}
}
