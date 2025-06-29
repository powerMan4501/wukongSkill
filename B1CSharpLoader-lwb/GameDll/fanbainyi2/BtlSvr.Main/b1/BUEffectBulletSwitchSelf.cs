using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "子弹切换自己" })]
[CanUseByBulletEffect]
public class BUEffectBulletSwitchSelf : BUEffectTemplate
{
	public BUEffectBulletSwitchSelf()
	{
		EffectType = EBuffAndSkillEffectType.BulletSwitchSelf;
	}

	[TemplateFunNote("通过技能效果子弹切换自己，当Caster或Target死亡时不生效")]
	[ParamInfoI(0, "子弹切换ID")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		BGUBulletBaseCS bGUBulletBaseCS = Target as BGUBulletBaseCS;
		if (bGUBulletBaseCS == null)
		{
			return;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUBulletBaseCS);
		if (readOnlyData == null)
		{
			return;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		if (!(masterActor == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(masterActor);
			if (bUS_GSEventCollection != null && skillEffectDesc.EffectParamsInt.Count > 0)
			{
				bUS_GSEventCollection.Evt_OnSwitchOneProjectile.Invoke(bGUBulletBaseCS, skillEffectDesc.EffectParamsInt[0]);
			}
		}
	}
}
