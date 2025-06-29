using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileBeAttackedComp : UActorCompBaseCS
{
	private b1.IBUC_BulletSweepReactionData BulletSweepReactionData;

	private IBUC_ProjectileBasicData ProjectileBasicData;

	private IBUC_MasterData MasterData;

	public override void OnAttach()
	{
		BulletSweepReactionData = RequireReadOnlyData<b1.IBUC_BulletSweepReactionData, BUC_BulletSweepReactionData>();
		ProjectileBasicData = RequireReadOnlyData<IBUC_ProjectileBasicData, BUC_ProjectileBasicData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		base.BUSEventCollection.Evt_OnProjectileBeHitted += new Del_OnProjectileBeHitted(OnProjectileBeHitted);
		base.BUSEventCollection.Evt_HandleReactionWhenBeHitted_ByEffect += new Del_HandleReactionWhenBeHitted_ByEffect(HandleReactionWhenBeHitted_ByEffect);
	}

	private void OnProjectileBeHitted(AActor AttackerActor, List<int> HitEffectID)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor.IsNullOrDestroyed() || bGUProjectileBaseActor.IsDead())
		{
			return;
		}
		AActor caster = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUProjectileBaseActor)?.GetMasterActor();
		int projectileID = bGUProjectileBaseActor.GetProjectileID();
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(projectileID, caster);
		if (projectileCommDesc == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUProjectileBaseActor);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		bool flag = false;
		BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(AttackerActor);
		if (projectileCommDesc.BeHitedTriggerEffectIDs.Count > 0)
		{
			FEffectInstReq effectInstReq = new FEffectInstReq(Owner);
			effectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			effectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			foreach (int beHitedTriggerEffectID in projectileCommDesc.BeHitedTriggerEffectIDs)
			{
				bUS_GSEventCollection2.Evt_TriggerSkillEffect.Invoke(beHitedTriggerEffectID, effectInstReq, Owner, bWithRPCEvent: false);
			}
			flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
		}
		if (!(flag | HandleReactionWhenBeHitted(bUS_GSEventCollection2, HitEffectID)))
		{
			return;
		}
		FEffectInstReq fEffectInstReq = new FEffectInstReq(GetOwner());
		fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUProjectileBaseActor);
		fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(bGUProjectileBaseActor);
		FEffectInstReq effectInstReq2 = fEffectInstReq;
		bUS_GSEventCollection.Evt_SpawnBulletFXByReason.Invoke(EBGUBulletDispReason.BeHit, effectInstReq2);
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(projectileID);
		if (projectileDispDesc != null)
		{
			string beHitedProjectilePostAKPath = projectileDispDesc.BeHitedProjectilePostAKPath;
			if (!string.IsNullOrEmpty(beHitedProjectilePostAKPath))
			{
				UAkAudioEvent uAkAudioEvent = BGW_PreloadAssetMgr.Get(bGUProjectileBaseActor).TryGetCachedResourceObj<UAkAudioEvent>(beHitedProjectilePostAKPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
				if (uAkAudioEvent != null)
				{
					bUS_GSEventCollection.Evt_PostAkEvent_AtLocation.Invoke(Owner.GetActorLocation(), Owner.GetActorRotation(), uAkAudioEvent);
				}
			}
		}
		HandleAttackerSelfTrigerEffect_WhenHitEffective(AttackerActor, bUS_GSEventCollection2);
	}

	private void HandleReactionWhenBeHitted_ByEffect(AActor Attacker, int EffectID)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Attacker);
		if (bUS_GSEventCollection != null)
		{
			List<int> list = new List<int>();
			list.Add(EffectID);
			HandleReactionWhenBeHitted(bUS_GSEventCollection, list);
		}
	}

	private bool HandleReactionWhenBeHitted(BUS_GSEventCollection BE_Attacker, List<int> HitEffectID)
	{
		bool flag = false;
		Dictionary<int, FBulletSweepReactionInfo> beHitedTriggerEffectIDs = BulletSweepReactionData.GetBeHitedTriggerEffectIDs();
		if (beHitedTriggerEffectIDs.Count > 0)
		{
			FEffectInstReq effectInstReq = new FEffectInstReq(Owner);
			effectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			effectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			if (HitEffectID != null)
			{
				foreach (int item in HitEffectID)
				{
					if (!beHitedTriggerEffectIDs.TryGetValue(item, out var value))
					{
						continue;
					}
					foreach (int item2 in value.TriggerEffectID)
					{
						base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(item2, effectInstReq, Owner, bWithRPCEvent: false);
						flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
					}
					foreach (int item3 in value.AttackerTriggerEffectID)
					{
						BE_Attacker.Evt_TriggerSkillEffect.Invoke(item3, effectInstReq, Owner, bWithRPCEvent: false);
						flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
					}
				}
			}
			if (beHitedTriggerEffectIDs.TryGetValue(0, out var value2))
			{
				foreach (int item4 in value2.TriggerEffectID)
				{
					base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(item4, effectInstReq, Owner, bWithRPCEvent: false);
					flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
				}
				foreach (int item5 in value2.AttackerTriggerEffectID)
				{
					BE_Attacker.Evt_TriggerSkillEffect.Invoke(item5, effectInstReq, Owner, bWithRPCEvent: false);
					flag = (byte)((flag ? 1u : 0u) | 1u) != 0;
				}
			}
		}
		return flag;
	}

	private bool HandleAttackerSelfTrigerEffect_WhenHitEffective(AActor Attacker, BUS_GSEventCollection BE_Attacker)
	{
		FUStEffectiveHitProjectileEffectDesc effectiveHitProjectileEffectDesc = BGW_GameDB.GetEffectiveHitProjectileEffectDesc(BGU_DataUtil.GetActorResID(Attacker), Attacker);
		if (effectiveHitProjectileEffectDesc == null)
		{
			return false;
		}
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(ProjectileBasicData.ProjectileID);
		if (bulletExpandDesc == null)
		{
			return false;
		}
		AActor masterActor = MasterData.GetMasterActor();
		if (masterActor.IsNullOrDestroyed())
		{
			return false;
		}
		bool flag = false;
		float num = 0f;
		float num2 = 0f;
		foreach (int item in bulletExpandDesc.HitEffectsforChr)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(item, masterActor);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				flag = true;
				if (skillEffectDesc.EffectParamsFloat.Count < 3)
				{
					return false;
				}
				num = skillEffectDesc.EffectParamsFloat[1];
				num2 = skillEffectDesc.EffectParamsFloat[2] / 10000f;
				break;
			}
		}
		if (flag)
		{
			IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(masterActor);
			IBUC_AttrContainer readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Attacker);
			if (readOnlyData == null)
			{
				return false;
			}
			float num3 = readOnlyData.GetFloatValue(EBGUAttrFloat.Atk) * num2 + num;
			float floatValue = readOnlyData2.GetFloatValue(EBGUAttrFloat.HpMax);
			FProjectileBeHittedCostAttr costAttr = effectiveHitProjectileEffectDesc.CostAttr;
			EProjectileBeHittedCostAttrType costAttrType = costAttr.CostAttrType;
			EBGUAttrFloat eBGUAttrFloat = EBGUAttrFloat.None;
			if (costAttrType == EProjectileBeHittedCostAttrType.None || costAttrType != EProjectileBeHittedCostAttrType.Stamina)
			{
				return false;
			}
			eBGUAttrFloat = EBGUAttrFloat.Stamina;
			float floatValMax = readOnlyData2.GetFloatValMax(eBGUAttrFloat);
			float num4 = num3 / floatValue * floatValMax * costAttr.SwitchRatio;
			BE_Attacker?.Evt_IncreaseAttrFloat.Invoke(eBGUAttrFloat, 0f - num4);
			float increaseValue = FMath.Loge(num3) * effectiveHitProjectileEffectDesc.PEValueSwitchRatio + effectiveHitProjectileEffectDesc.IncreaseBaseValue;
			BE_Attacker?.Evt_IncreasePEValue.Invoke(increaseValue, EPotentialEnergyIncreaseReason.Normal);
		}
		return true;
	}
}
