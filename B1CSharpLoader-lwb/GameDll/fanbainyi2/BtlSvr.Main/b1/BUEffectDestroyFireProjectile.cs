using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectTarget]
[CanUseByBulletEffect]
[EffectTemplateTips(new string[] { "销毁火焰类型抛射物" })]
public class BUEffectDestroyFireProjectile : BUEffectTemplate
{
	public BUEffectDestroyFireProjectile()
	{
		EffectType = EBuffAndSkillEffectType.DestroyFireProjectile;
	}

	[TemplateFunNote("通过技能效果销毁火焰类型抛射物，如何定义火焰类型抛射物：配置于抛射物蓝图中ConfigInfoComp的SpecificFlags")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = Target as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || BGW_GameDB.GetSkillEffectDesc(EffectID, Caster) == null)
		{
			return;
		}
		BUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileBasicData>(bGUProjectileBaseActor);
		if ((2 & readOnlyData.ProjectileSpecificFlags) != 0)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
			}
		}
	}
}
