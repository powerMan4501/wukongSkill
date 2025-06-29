using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSwitchBullet : BUEffectTemplate
{
	public BUEffectSwitchBullet()
	{
		EffectType = EBuffAndSkillEffectType.SwitchBullet;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
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
		BGUProjectileBaseActor bGUProjectileBaseActor = Caster as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor != null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
			if (readOnlyData != null)
			{
				AActor masterActor = readOnlyData.GetMasterActor();
				if (masterActor != null)
				{
					bUS_GSEventCollection = BUS_EventCollectionCS.Get(masterActor);
				}
			}
		}
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
			4 => ESwitchFilterMode.NearestToTarget, 
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
		bool bSelectWithOrder = true;
		if (skillEffectDesc.EffectParamsInt.Count > 4)
		{
			bSelectWithOrder = skillEffectDesc.EffectParamsInt[4] == 0;
		}
		bUS_GSEventCollection.Evt_CastControllBullet.Invoke(ctr_number, num, switchInterval, destroyTimeFilter, eSwitchFilterMode, filterBulletID, bSwitchImmediate: true, bSelectWithOrder);
	}

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
		bool bSelectWithOrder = true;
		if (intEffectParamCount > 4)
		{
			bSelectWithOrder = buffDescRuntime.GetIntEffectParam(EffectIdx, 4) == 0;
		}
		bUS_GSEventCollection.Evt_CastControllBullet.Invoke(intEffectParam2, intEffectParam, floatEffectParam, floatEffectParam2, eSwitchFilterMode, filterBulletID, bSwitchImmediate: true, bSelectWithOrder);
	}
}
