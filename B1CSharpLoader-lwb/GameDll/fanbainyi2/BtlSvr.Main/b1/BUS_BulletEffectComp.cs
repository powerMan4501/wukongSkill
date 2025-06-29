using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_BulletEffectComp : UActorCompBaseCS
{
	private BUC_ProjectileBasicData ProjectileBasicData;

	private BUC_BulletEffectData BulletEffectData;

	private b1.IBUC_BulletSweepReactionData BulletSweepReactionData;

	private IBUC_MasterData MasterData;

	public override void OnAttach()
	{
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		BulletEffectData = RequireWritableData<BUC_BulletEffectData>();
		BulletSweepReactionData = RequireReadOnlyData<b1.IBUC_BulletSweepReactionData, BUC_BulletSweepReactionData>();
		MasterData = (MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>());
		base.BUSEventCollection.Evt_OnProjectileIDChanged += new Del_Void_Int(OnProjectileIDChanged);
		base.BUSEventCollection.Evt_BulletTriggerEffectsByReson += new Del_BulletTriggerEffectsByReson(TriggerEffectByReason);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DelayTriggerEffect(DeltaTime);
	}

	private void TriggerEffectByReason(EBGUBulletTriggerEffectReason TriggerEffectReason, ref FEffectInstReq EffectInstReq, AActor BeHitActor = null)
	{
		if (base.BUSEventCollection == null)
		{
			return;
		}
		TriggerHitBuffAndHitSimpleStateEffect(ref EffectInstReq, BeHitActor);
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(ProjectileBasicData.ProjectileID);
		if (bulletExpandDesc == null)
		{
			return;
		}
		EffectInstReq.TriggerSkillId = ProjectileBasicData.SkillID;
		List<int> list = bulletExpandDesc.HitEffectsforChr.ToList();
		List<int> list2 = bulletExpandDesc.HitEffectsforProjectile.ToList();
		List<int> list3 = bulletExpandDesc.HitDestructibleEffectsforSelf.ToList();
		List<int> list4 = bulletExpandDesc.HitItemEffectsforSelf.ToList();
		List<int> list5 = bulletExpandDesc.HitChrEffectsforSelf.ToList();
		List<int> list6 = bulletExpandDesc.LifeOverEffectID.ToList();
		switch (TriggerEffectReason)
		{
		case EBGUBulletTriggerEffectReason.HitCharacter:
		{
			BGUCharacterCS bGUCharacterCS = BeHitActor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				base.BUSEventCollection.Evt_UpdateHittedInfo.Invoke(bGUCharacterCS);
			}
			if (list != null && list.Count > 0)
			{
				bGUCharacterCS = BeHitActor as BGUCharacterCS;
				if (bGUCharacterCS != null)
				{
					foreach (int item in list)
					{
						TriggerEffect(item, EffectInstReq, BeHitActor);
					}
				}
			}
			if (list5 == null)
			{
				break;
			}
			foreach (int item2 in list5)
			{
				TriggerEffect(item2, EffectInstReq, Owner);
			}
			break;
		}
		case EBGUBulletTriggerEffectReason.HitProjectile:
		{
			if (list2 == null || list2.Count <= 0)
			{
				break;
			}
			BGUProjectileBaseActor bGUProjectileBaseActor = BeHitActor as BGUProjectileBaseActor;
			if (!(bGUProjectileBaseActor != null))
			{
				break;
			}
			BUS_EventCollectionCS.Get(bGUProjectileBaseActor)?.Evt_OnProjectileBeHitted.Invoke(Owner, list2);
			foreach (int item3 in list2)
			{
				TriggerEffect(item3, EffectInstReq, BeHitActor);
			}
			break;
		}
		case EBGUBulletTriggerEffectReason.HitItem:
			if (list4 != null)
			{
				foreach (int item4 in list4)
				{
					TriggerEffect(item4, EffectInstReq, Owner);
				}
			}
			if (!(BeHitActor is b1.BGUJJSObstacleBase actor))
			{
				break;
			}
			foreach (int item5 in list)
			{
				BUS_EventCollectionCS.Get(actor)?.Evt_HitJJSObstacle.Invoke(item5);
			}
			break;
		case EBGUBulletTriggerEffectReason.LifeOver:
			if (list6 == null)
			{
				break;
			}
			foreach (int item6 in list6)
			{
				TriggerEffect(item6, EffectInstReq);
			}
			break;
		case EBGUBulletTriggerEffectReason.HitDestructible:
		{
			if (BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(BeHitActor) == null)
			{
				break;
			}
			if (list3 != null && list3.Count > 0)
			{
				foreach (int item7 in list3)
				{
					TriggerEffect(item7, EffectInstReq, Owner);
				}
			}
			else if (list4 != null)
			{
				foreach (int item8 in list4)
				{
					TriggerEffect(item8, EffectInstReq, Owner);
				}
			}
			EGSHitDestructibleStrengthLevel hitDestructibleStrengthType = (EGSHitDestructibleStrengthLevel)bulletExpandDesc.HitDestructibleStrengthType;
			EGSHitDestructibleDirection hitDestructibleDirectionType = (EGSHitDestructibleDirection)bulletExpandDesc.HitDestructibleDirectionType;
			if (hitDestructibleStrengthType == EGSHitDestructibleStrengthLevel.None || BeHitActor.GetParentActor() == GetOwner())
			{
				return;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(BeHitActor);
			if (bUS_GSEventCollection != null)
			{
				float destructibleImpulse = BGUFunctionLibraryCS.GetDestructibleImpulse(Owner, hitDestructibleStrengthType);
				bUS_GSEventCollection.Evt_HitDestructible.Invoke(Owner, hitDestructibleStrengthType, hitDestructibleDirectionType, EffectInstReq, destructibleImpulse);
			}
			break;
		}
		}
		AActor aActor = MasterData.GetMaster() as AActor;
		if (aActor != null)
		{
			BUS_EventCollectionCS.Get(aActor).Evt_NotifyMasterProjectileHitted.Invoke(Owner, BeHitActor, TriggerEffectReason);
		}
	}

	private void TriggerHitBuffAndHitSimpleStateEffect(ref FEffectInstReq EffectInstReq, AActor BeHitActor)
	{
		if (BeHitActor == null)
		{
			return;
		}
		if (BulletSweepReactionData.GetSweepBuffTriggerEffectIDs().Count > 0)
		{
			BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(BeHitActor);
			if (readOnlyData != null)
			{
				foreach (KeyValuePair<int, FBulletSweepReactionInfo> sweepBuffTriggerEffectID in BulletSweepReactionData.GetSweepBuffTriggerEffectIDs())
				{
					if (!readOnlyData.HasBuff(sweepBuffTriggerEffectID.Key))
					{
						continue;
					}
					foreach (int item in sweepBuffTriggerEffectID.Value.TriggerEffectID)
					{
						TriggerEffect(item, EffectInstReq, BeHitActor);
					}
				}
			}
		}
		if (BulletSweepReactionData.GetSweepSimpleStateTriggerEffectIDs().Count <= 0)
		{
			return;
		}
		BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(BeHitActor);
		if (readOnlyData2 == null)
		{
			return;
		}
		foreach (KeyValuePair<EBGUSimpleState, FBulletSweepReactionInfo> sweepSimpleStateTriggerEffectID in BulletSweepReactionData.GetSweepSimpleStateTriggerEffectIDs())
		{
			if (!readOnlyData2.HasSimpleState(sweepSimpleStateTriggerEffectID.Key))
			{
				continue;
			}
			foreach (int item2 in sweepSimpleStateTriggerEffectID.Value.TriggerEffectID)
			{
				TriggerEffect(item2, EffectInstReq, BeHitActor);
			}
		}
	}

	private void DelayTriggerEffect(float DeltaTime)
	{
		if (BulletEffectData.DelayTriggerEffectList.Count <= 0)
		{
			return;
		}
		BulletEffectData.Age_ForDelayTriggerEffect += DeltaTime;
		for (int i = 0; i < BulletEffectData.DelayTriggerEffectList.Count; i++)
		{
			if (!(BulletEffectData.Age_ForDelayTriggerEffect >= BulletEffectData.DelayTriggerEffectList[i].TriggerTime))
			{
				continue;
			}
			FEffectInstReq effectInstReq = default(FEffectInstReq);
			foreach (int effectID in BulletEffectData.DelayTriggerEffectList[i].EffectIDs)
			{
				TriggerEffect(effectID, effectInstReq, Owner);
			}
			BulletEffectData.DelayTriggerEffectList.RemoveAt(i);
			i--;
		}
	}

	private void OnProjectileIDChanged(int NewProjectileID)
	{
		BulletEffectData.Age_ForDelayTriggerEffect = 0f;
		FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(NewProjectileID);
		if (bulletExpandDesc == null)
		{
			return;
		}
		foreach (FUStDelayTriggerEffects delayTriggerEffect in bulletExpandDesc.DelayTriggerEffects)
		{
			DelayTriggerEffect_Bullet item = default(DelayTriggerEffect_Bullet);
			item.TriggerTime = delayTriggerEffect.DelayTime;
			item.EffectIDs = new List<int>();
			item.EffectIDs.AddRange(delayTriggerEffect.EffectIDs.ToList());
			BulletEffectData.DelayTriggerEffectList.Add(item);
		}
	}

	private void TriggerEffect(int EffectID, FEffectInstReq EffectInstReq, AActor EffectTarget = null)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Owner);
		if (skillEffectDesc != null)
		{
			EffectInstReq.bFromBullet = true;
			EBuffAndSkillEffectType effectType = skillEffectDesc.EffectType;
			bool flag = BulletRPCEffect.BulletRPCEffectList.Contains(effectType);
			if (flag)
			{
				EffectInstReq.Attacker = MasterData.GetMasterActor();
			}
			base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, EffectInstReq, EffectTarget, flag);
		}
	}
}
