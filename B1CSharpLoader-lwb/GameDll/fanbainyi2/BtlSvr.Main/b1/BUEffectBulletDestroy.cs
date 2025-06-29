using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "销毁子弹" })]
[CanUseByBulletEffect]
[AffectTarget]
public class BUEffectBulletDestroy : BUEffectTemplate
{
	public BUEffectBulletDestroy()
	{
		EffectType = EBuffAndSkillEffectType.DestroyBullet;
	}

	[TemplateFunNote("通过技能效果销毁子弹。可在int参数列表配置一系列可销毁的子弹ID，若当前Target子弹的ID不在列表中，则无事发生")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Target as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		List<int> list = skillEffectDesc.EffectParamsInt.ToList();
		if (list.Count > 0)
		{
			int projectileID = bGUProjectileBaseActor.GetProjectileID();
			if (!list.Contains(projectileID))
			{
				return;
			}
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
		}
	}

	[TemplateFunNote("通过Buff销毁子弹。可在int参数列表配置一系列可销毁的子弹ID，若当前Target子弹的ID不在列表中，则无事发生")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Target as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null && buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 0)
		{
			int projectileID = bGUProjectileBaseActor.GetProjectileID();
			if (!buffDescRuntime.GetIntEffectParamList(EffectIdx).Contains(projectileID))
			{
				return;
			}
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
		}
	}
}
