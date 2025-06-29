using System.Collections.Generic;
using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "切换子弹并且智能选取目标", "如果caster是子,会根据DA中配置的搜索范围智能搜寻目标" })]
public class BUEffectSwitchBulletAndSmartSelectTarget : BUEffectTemplate
{
	public BUEffectSwitchBulletAndSmartSelectTarget()
	{
		EffectType = EBuffAndSkillEffectType.SwitchBulletAndSmartSelectTarget;
	}

	[ParamInfoI(2, "筛选模式")]
	[ParamInfoI(0, "切换子弹ID")]
	[ParamInfoI(1, "控制数量")]
	[TemplateFunNote("切换子弹并且智能选取目标")]
	[ParamInfoI(3, "筛选子弹ID，只对模式FilterID有用")]
	[ParamInfoF(1, "存活筛选时间，存活超出这个时间则不需要切换")]
	[ParamInfoF(0, "切换的延迟时间")]
	[ParamInfoS(0, "DAPath")]
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
		string path = skillEffectDesc.EffectParamsStr[0];
		BGWDataAsset_BulletSmartSelectTargetConfig bGWDataAsset_BulletSmartSelectTargetConfig = BGW_PreloadAssetMgr.Get(Caster).TryGetCachedResourceObj<BGWDataAsset_BulletSmartSelectTargetConfig>(path, ELoadResourceType.SyncLoadAndCache);
		if (BGW_GameDB.GetBulletSwitchDesc(num) == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		BGUProjectileBaseActor bGUProjectileBaseActor = Caster as BGUProjectileBaseActor;
		AActor aActor = null;
		if (bGUProjectileBaseActor != null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor);
			if (readOnlyData != null)
			{
				aActor = readOnlyData.GetMasterActor();
				if (aActor != null)
				{
					bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
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
		if (Caster as BGUProjectileBaseActor == null)
		{
			bUS_GSEventCollection.Evt_CastControllBullet.Invoke(ctr_number, num, switchInterval, destroyTimeFilter, eSwitchFilterMode, filterBulletID, bSwitchImmediate: true);
			return;
		}
		List<int> list = new List<int>();
		list.Add(bGWDataAsset_BulletSmartSelectTargetConfig.SearchRadius);
		new List<int>();
		FVector bulletLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster);
		FVector masterLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		AActor aActor2 = null;
		Dictionary<BGUCharacterCS, int> unitHittedCountDic = BUS_EventCollectionCS.Get(Caster).Evt_UnitBeHittedCountDic.Invoke();
		List<AActor> OutActors = new List<AActor>();
		List<AActor> OutActors2 = new List<AActor>();
		BGUFuncLibSelectTargetsCS.SelectUnitsInCircle(Caster, out OutActors, aActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), 2, list);
		foreach (AActor item in OutActors)
		{
			BGUProjectileBaseActor bGUProjectileBaseActor2 = item as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor2 != null)
			{
				OutActors2.Add(bGUProjectileBaseActor2);
			}
		}
		if (OutActors2.Count == 0)
		{
			BGUFuncLibSelectTargetsCS.SelectUnitsInCircle(Caster, out OutActors2, aActor, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), 1, list);
		}
		AActor lastHitUnit = BGU_DataUtil.GetReadOnlyData<BUC_BulletHitInfoData>(Caster).GetLastHitUnit();
		aActor2 = DoSelectTargetLogic(bulletLocation, masterLocation, Caster, aActor, lastHitUnit, OutActors2, unitHittedCountDic, bGWDataAsset_BulletSmartSelectTargetConfig);
		bUS_GSEventCollection.Evt_CastBulletAuto.Invoke(ctr_number, num, switchInterval, destroyTimeFilter, eSwitchFilterMode, filterBulletID, aActor2);
	}

	private AActor DoSelectTargetLogic(FVector BulletLocation, FVector MasterLocation, AActor Bullet, AActor MasterActor, AActor LastHitUnit, List<AActor> Actors, Dictionary<BGUCharacterCS, int> UnitHittedCountDic, BGWDataAsset_BulletSmartSelectTargetConfig SelectConfig)
	{
		float num = float.MinValue;
		AActor result = null;
		foreach (AActor Actor in Actors)
		{
			if (BGUFunctionLibraryCS.BGUIsEnemyTeam(MasterActor, Actor))
			{
				FVector location = BGUFuncLibActorTransformCS.BGUGetActorTransform(Actor).GetLocation();
				float num2 = FVector.Dist(location, BulletLocation);
				float num3 = FVector.Dist(location, MasterLocation);
				float num4 = 0f;
				if (LastHitUnit != null)
				{
					num4 = FVector.DotProduct(LastHitUnit.GetActorForwardVector(), Actor.GetActorForwardVector());
				}
				int num5 = 0;
				if (UnitHittedCountDic.ContainsKey(Actor as BGUCharacterCS))
				{
					num5 = UnitHittedCountDic[Actor as BGUCharacterCS];
				}
				float num6 = (0f - SelectConfig.BeAttackedDecreaseValue) * (float)num5 + (0f - SelectConfig.BulletDistanceDecreaseValue) * (float)(int)num2 / 100f + (0f - SelectConfig.MasterDistanceDecreaseValue) * (float)(int)num3 / 100f + (0f - num4) * SelectConfig.LastTargetDotDecreaseValue;
				if (num < num6)
				{
					num = num6;
					result = Actor;
				}
			}
		}
		return result;
	}
}
