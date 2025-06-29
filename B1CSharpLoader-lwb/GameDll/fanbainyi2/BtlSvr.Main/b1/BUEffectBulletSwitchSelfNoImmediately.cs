using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "通知子弹的的Master切换子弹（有延迟时间）" })]
public class BUEffectBulletSwitchSelfNoImmediately : BUEffectTemplate
{
	public BUEffectBulletSwitchSelfNoImmediately()
	{
		EffectType = EBuffAndSkillEffectType.BulletSwitchSelfNoImmediately;
	}

	[ParamInfoF(1, "存活筛选时间，存活超出这个时间则不需要切换")]
	[ParamInfoF(0, "切换的延迟时间")]
	[ParamInfoI(0, "切换子弹ID")]
	[TemplateFunNote("触发SkillEffect时通知Master切换子弹，并设置延迟时间")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null || skillEffectDesc.EffectParamsInt.Count < 2 || skillEffectDesc.EffectParamsFloat.Count < 2)
		{
			return;
		}
		int num = skillEffectDesc.EffectParamsInt[0];
		int filterBulletID = skillEffectDesc.EffectParamsInt[1];
		float switchInterval = skillEffectDesc.EffectParamsFloat[0];
		float destroyTimeFilter = skillEffectDesc.EffectParamsFloat[1];
		if (BGW_GameDB.GetBulletSwitchDesc(num) == null)
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = Target as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null)
		{
			return;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
		if (readOnlyData == null)
		{
			return;
		}
		AActor masterActor = readOnlyData.GetMasterActor();
		if (!(masterActor == null))
		{
			int num2 = 0;
			int num3 = 0;
			if (skillEffectDesc.EffectParamsInt.Count >= 2)
			{
				num2 = skillEffectDesc.EffectParamsInt[1];
				num3 = (Target as BGUProjectileBaseActor).GetProjectileID();
			}
			if (num2 == num3)
			{
				BUS_EventCollectionCS.Get(masterActor).Evt_CastControllBullet.Invoke(1, num, switchInterval, destroyTimeFilter, ESwitchFilterMode.FilterID, filterBulletID, bSwitchImmediate: false);
			}
		}
	}

	[ParamInfoI(2, "筛选模式")]
	[ParamInfoF(0, "切换的延迟时间")]
	[ParamInfoF(1, "存活筛选时间，存活超出这个时间则不需要切换")]
	[ParamInfoI(0, "切换子弹ID")]
	[TemplateFunNote("添加Buff时通知Master切换子弹，并设置延迟时间")]
	[ParamInfoF(1, "控制数量")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		int floatEffectParamCount = buffDescRuntime.GetFloatEffectParamCount(EffectIdx);
		if (intEffectParamCount < 3 || floatEffectParamCount < 2)
		{
			return;
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
		int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
		int intEffectParam3 = buffDescRuntime.GetIntEffectParam(EffectIdx, 2);
		float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
		float floatEffectParam2 = buffDescRuntime.GetFloatEffectParam(EffectIdx, 1);
		if (BGW_GameDB.GetBulletSwitchDesc(intEffectParam) == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		ESwitchFilterMode eSwitchFilterMode = intEffectParam3 switch
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
			if (intEffectParamCount < 4)
			{
				return;
			}
			filterBulletID = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
		}
		bUS_GSEventCollection.Evt_CastControllBullet.Invoke(intEffectParam2, intEffectParam, floatEffectParam, floatEffectParam2, eSwitchFilterMode, filterBulletID, bSwitchImmediate: false);
	}
}
