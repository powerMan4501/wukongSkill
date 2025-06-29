using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[CantUseInMultiEffect]
[EffectTemplateTips(new string[] { "目前只做了击回给发射者的逻辑" })]
public class BUEffectBulletHitBack : BUEffectTemplate
{
	public BUEffectBulletHitBack()
	{
		EffectType = EBuffAndSkillEffectType.BulletHitBack;
	}

	[ParamInfoI(0, "BulletSwitchID （一般用于定义打回的方式)")]
	[ParamInfoI(1, "HitVEffectID (用于配置命中时的顿帧）")]
	[TemplateFunNote("通过技能击回")]
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
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
		if (!(bUS_GSEventCollection == null) && !(bUS_GSEventCollection2 == null))
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
			AActor aActor = null;
			if (readOnlyData != null)
			{
				aActor = readOnlyData.GetMasterActor();
			}
			if (!aActor.IsNullOrDestroyed())
			{
				BUS_EventCollectionCS.Get(aActor)?.Evt_RemoveCtrableBulletFromPack.Invoke(bGUProjectileBaseActor);
			}
			bUS_GSEventCollection2.Evt_SetMaster.Invoke(Caster);
			bUS_GSEventCollection.Evt_AddCtrableBulletToPack.Invoke(bGUProjectileBaseActor);
			int projectileSwitchID = skillEffectDesc.EffectParamsInt[0];
			bUS_GSEventCollection.Evt_OnSwitchOneProjectile.Invoke(bGUProjectileBaseActor, projectileSwitchID, 0, aActor);
			if (((skillEffectDesc.EffectParamsInt.Count > 1) ? skillEffectDesc.EffectParamsInt[1] : (-1)) != -1)
			{
				bUS_GSEventCollection.Evt_AttackFeedback.Invoke(bGUProjectileBaseActor, EffectInstReq.TriggerSkillId, -1, -1, IsAtkRebounding: false);
			}
		}
	}
}
