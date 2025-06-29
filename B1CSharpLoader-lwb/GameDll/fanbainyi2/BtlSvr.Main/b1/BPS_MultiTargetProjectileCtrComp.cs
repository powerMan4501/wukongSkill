using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPS_MultiTargetProjectileCtrComp : PlayerControllerSystemBase
{
	private BPC_MultiTargetProjectileCtrData MultiTargetProjectileCtrData;

	private IBUC_TargetInfoData TargetInfoData;

	private static List<AActor> Ingnores = new List<AActor>();

	private BUS_GSEventCollection Player_BE;

	private BGUCharacterCS PlayerActor;

	private BGWDataAsset_BulletSmartSelectTargetConfig BulletSmartSelectTargetConfig { get; set; }

	public override void OnAttach()
	{
		MultiTargetProjectileCtrData = RequireWritableData<BPC_MultiTargetProjectileCtrData>();
		base.BGSEventCollection.Evt_BGS_OnUnitTransited += new Del_BGS_OnUnitTransited(OnPossessed);
	}

	public override void OnBeginPlay()
	{
		BulletSmartSelectTargetConfig = BGW_PreloadAssetMgr.Get(Owner).BulletSmartSelectTargetConfig;
		BGUCharacterCS bGUCharacterCS = (Owner as BGP_PlayerControllerB1)?.GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			UpdateData(bGUCharacterCS);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BulletSmartSelectTargetConfig = null;
		base.BGSEventCollection.Evt_BGS_OnUnitTransited -= new Del_BGS_OnUnitTransited(OnPossessed);
	}

	private void OnPossessed(AActor OldActor, AActor CurActor)
	{
		if (CurActor != null && CurActor as BGUCharacterCS != null)
		{
			UpdateData((BGUCharacterCS)CurActor);
		}
	}

	private void UpdateData(BGUCharacterCS Chr)
	{
		TargetInfoData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Chr);
		PlayerActor = Chr;
		Player_BE = BUS_EventCollectionCS.Get(Chr);
		if (Player_BE != null)
		{
			Player_BE.Evt_NotifyMasterProjectileSpawned += new Del_Actor(OnNotifyMasterProjectileSpawned);
			Player_BE.Evt_NotifyMasterProjectileSwitchFinished += new Del_Void_ActorInt(OnNotifyMasterProjectileSwitchFinished);
			Player_BE.Evt_NotifyMasterProjectileHitted += new Del_NotfiyProjectileHitInfo(OnNotifyMasterProjectileHitted);
			Player_BE.Evt_BulletMissTarget += new Del_Actor(OnBulletMissTarget);
		}
		if (MultiTargetProjectileCtrData.Projectile != null && MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.FollowMaster)
		{
			ChangeToFollowMaster();
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(MultiTargetProjectileCtrData.Projectile == null))
		{
			if (MultiTargetProjectileCtrData.LifeTime >= 0f)
			{
				MultiTargetProjectileCtrData.LifeTime -= DeltaTime;
				SearchTargetTick(DeltaTime);
			}
			else
			{
				ChangeToBackNest();
			}
		}
	}

	private void SearchTargetTick(float DeltaTime)
	{
		MultiTargetProjectileCtrData.SearchTimer += DeltaTime;
		if (!(MultiTargetProjectileCtrData.SearchTimer > BulletSmartSelectTargetConfig.SearchTargetDelayTime))
		{
			return;
		}
		MultiTargetProjectileCtrData.SearchTimer = 0f;
		if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.FollowMaster)
		{
			AActor bestTarget = GetBestTarget(NeedUpdateCacheMultiTarget: true);
			if (bestTarget != null && MultiTargetProjectileCtrData.ObjActorMovementData.InertialState == EInertialState.Stay)
			{
				ChangeToTraceTarget(bestTarget);
			}
		}
	}

	private void OnNotifyMasterProjectileSpawned(AActor Projectile)
	{
		InitProjectileInfo(Projectile);
	}

	private void OnNotifyMasterProjectileSwitchFinished(AActor Projectile, int LastProjectileID)
	{
		if (LastProjectileID != BulletSmartSelectTargetConfig.PerformanceProjectileID)
		{
			InitProjectileInfo(Projectile);
		}
	}

	private void OnNotifyMasterProjectileHitted(AActor Projectile, AActor HitActor, EBGUBulletTriggerEffectReason Reason)
	{
		if (Projectile != MultiTargetProjectileCtrData.Projectile)
		{
			return;
		}
		switch (Reason)
		{
		case EBGUBulletTriggerEffectReason.HitCharacter:
		{
			if (MultiTargetProjectileCtrData.ProjectileState != EMultiTargetProjectileState.TraceTarget)
			{
				break;
			}
			Entity keyItem = ECSExtension.ToEntity(HitActor);
			if (MultiTargetProjectileCtrData.MultiTargetDic.ContainsKey(keyItem))
			{
				MultiTargetProjectileCtrData.MultiTargetDic[keyItem]++;
				MultiTargetProjectileCtrData.HitCount++;
				MultiTargetProjectileCtrData.LastHitUnit = ECSExtension.ToEntity(HitActor);
				if (MultiTargetProjectileCtrData.HitCount >= MultiTargetProjectileCtrData.OriginalTargetCount)
				{
					ChangeToFollowMaster();
				}
				else
				{
					ChangeToWait();
				}
			}
			break;
		}
		case EBGUBulletTriggerEffectReason.HitProjectile:
		{
			if (MultiTargetProjectileCtrData.ProjectileState != EMultiTargetProjectileState.TraceTarget)
			{
				break;
			}
			Entity keyItem2 = ECSExtension.ToEntity(HitActor);
			if (MultiTargetProjectileCtrData.MultiTargetDic.ContainsKey(keyItem2))
			{
				MultiTargetProjectileCtrData.MultiTargetDic[keyItem2]++;
				MultiTargetProjectileCtrData.HitCount++;
				MultiTargetProjectileCtrData.LastHitUnit = ECSExtension.ToEntity(HitActor);
				if (MultiTargetProjectileCtrData.HitCount >= MultiTargetProjectileCtrData.OriginalTargetCount)
				{
					ChangeToFollowMaster();
				}
				else
				{
					ChangeToWait();
				}
			}
			break;
		}
		case EBGUBulletTriggerEffectReason.HitItem:
			if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.Wait)
			{
				AActor bestTarget2 = GetBestTarget();
				if (bestTarget2 != null)
				{
					ChangeToTraceTarget(bestTarget2);
				}
				else
				{
					ChangeToFollowMaster();
				}
			}
			break;
		case EBGUBulletTriggerEffectReason.FlyOver:
			if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.Wait)
			{
				AActor bestTarget3 = GetBestTarget();
				if (bestTarget3 != null)
				{
					ChangeToTraceTarget(bestTarget3);
				}
				else
				{
					ChangeToFollowMaster();
				}
			}
			break;
		case EBGUBulletTriggerEffectReason.LifeOver:
			if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.Wait)
			{
				AActor bestTarget = GetBestTarget();
				if (bestTarget != null)
				{
					ChangeToTraceTarget(bestTarget);
				}
				else
				{
					ChangeToFollowMaster();
				}
			}
			break;
		}
	}

	private void OnBulletMissTarget(AActor Projectile)
	{
		if (Projectile != MultiTargetProjectileCtrData.Projectile)
		{
			return;
		}
		Entity entity = ECSExtension.ToEntity(BGU_DataUtil.GetReadOnlyData<IBUC_ObjActorMovementData, BUC_ObjActorMovementData>(MultiTargetProjectileCtrData.Projectile).TargetActor);
		if (entity != Entity.Null && MultiTargetProjectileCtrData.MultiTargetDic.ContainsKey(entity))
		{
			MultiTargetProjectileCtrData.MultiTargetDic.Remove(entity);
		}
		if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.TraceTarget)
		{
			MultiTargetProjectileCtrData.HitCount++;
			if (MultiTargetProjectileCtrData.HitCount >= MultiTargetProjectileCtrData.OriginalTargetCount)
			{
				ChangeToFollowMaster();
			}
			else
			{
				ChangeToWait();
			}
		}
		else if (MultiTargetProjectileCtrData.ProjectileState == EMultiTargetProjectileState.Wait)
		{
			AActor bestTarget = GetBestTarget();
			if (bestTarget != null)
			{
				ChangeToTraceTarget(bestTarget);
			}
			else
			{
				ChangeToFollowMaster();
			}
		}
		else
		{
			_ = MultiTargetProjectileCtrData.ProjectileState;
		}
	}

	private void ClearCache()
	{
		MultiTargetProjectileCtrData.ResetInfo(null, 0f, null, null);
	}

	private void ChangeToBackNest()
	{
		if (!(MultiTargetProjectileCtrData.Projectile == null))
		{
			Player_BE?.Evt_OnSwitchOneProjectile.Invoke(MultiTargetProjectileCtrData.Projectile, BulletSmartSelectTargetConfig.BackNestProjectileID);
			MultiTargetProjectileCtrData.ProjectileState = EMultiTargetProjectileState.BackNest;
			ClearCache();
		}
	}

	private void ChangeToTraceTarget(AActor BestTargetActor)
	{
		if (MultiTargetProjectileCtrData.LifeTime < 0f)
		{
			ChangeToBackNest();
			return;
		}
		if (MultiTargetProjectileCtrData.ProjectileBasicData.ProjectileID != MultiTargetProjectileCtrData.CacheOriginalProjectileID)
		{
			Player_BE?.Evt_OnSwitchOneProjectile.Invoke(MultiTargetProjectileCtrData.Projectile, MultiTargetProjectileCtrData.CacheOriginalProjectileID);
		}
		Player_BE?.Evt_SwitchBulletTarget.Invoke(MultiTargetProjectileCtrData.Projectile, BestTargetActor, "");
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(MultiTargetProjectileCtrData.Projectile);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SetObjMoveMode.Invoke(EBulletOrMagicFieldMoveModeType.TraceMode);
			MultiTargetProjectileCtrData.ProjectileState = EMultiTargetProjectileState.TraceTarget;
		}
	}

	private void ChangeToFollowMaster()
	{
		if (MultiTargetProjectileCtrData.LifeTime < 0f)
		{
			ChangeToBackNest();
			return;
		}
		if (MultiTargetProjectileCtrData.ProjectileBasicData.ProjectileID != MultiTargetProjectileCtrData.CacheOriginalProjectileID)
		{
			Player_BE?.Evt_OnSwitchOneProjectile.Invoke(MultiTargetProjectileCtrData.Projectile, MultiTargetProjectileCtrData.CacheOriginalProjectileID);
		}
		Player_BE?.Evt_SwitchBulletTarget.Invoke(MultiTargetProjectileCtrData.Projectile, PlayerActor, MultiTargetProjectileCtrData.CachedSocketName);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(MultiTargetProjectileCtrData.Projectile);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SetObjMoveMode.Invoke(EBulletOrMagicFieldMoveModeType.InertialSimulatingMoveMode);
			MultiTargetProjectileCtrData.ProjectileState = EMultiTargetProjectileState.FollowMaster;
			MultiTargetProjectileCtrData.ResetBattleInfo();
		}
	}

	private void ChangeToWait()
	{
		if (MultiTargetProjectileCtrData.LifeTime < 0f)
		{
			ChangeToBackNest();
			return;
		}
		if (MultiTargetProjectileCtrData.ProjectileBasicData.ProjectileID != BulletSmartSelectTargetConfig.PerformanceProjectileID)
		{
			Player_BE?.Evt_OnSwitchOneProjectile.Invoke(MultiTargetProjectileCtrData.Projectile, BulletSmartSelectTargetConfig.PerformanceProjectileID);
		}
		MultiTargetProjectileCtrData.ProjectileState = EMultiTargetProjectileState.Wait;
	}

	private void InitProjectileInfo(AActor NewProjectile)
	{
		IBUC_ProjectileBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ProjectileBasicData, BUC_ProjectileBasicData>(NewProjectile);
		if (readOnlyData == null || readOnlyData.ProjectileType != EBGUBulletType.MultiTarget)
		{
			return;
		}
		if (MultiTargetProjectileCtrData.Projectile != null)
		{
			if (!(NewProjectile != MultiTargetProjectileCtrData.Projectile))
			{
				return;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(MultiTargetProjectileCtrData.Projectile);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.EffectDestroy);
			}
			ClearCache();
		}
		IBUC_ObjActorMovementData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_ObjActorMovementData, BUC_ObjActorMovementData>(NewProjectile);
		FUStProjectileMoveDesc projectileMoveDesc = BGW_GameDB.GetProjectileMoveDesc(readOnlyData.ProjectileID);
		if (projectileMoveDesc.ProjectileMoveModeStrParam.Count > 2)
		{
			BulletSmartSelectTargetConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BGWDataAsset_BulletSmartSelectTargetConfig>(projectileMoveDesc.ProjectileMoveModeStrParam[2], ELoadResourceType.SyncLoadAndCache);
		}
		if (readOnlyData2 != null && BulletSmartSelectTargetConfig != null)
		{
			MultiTargetProjectileCtrData.ResetInfo(NewProjectile as BGUProjectileBaseActor, BulletSmartSelectTargetConfig.LifeTime, readOnlyData, readOnlyData2);
			AActor bestTarget = GetBestTarget(NeedUpdateCacheMultiTarget: true);
			if (bestTarget != null)
			{
				ChangeToTraceTarget(bestTarget);
			}
			else
			{
				ChangeToFollowMaster();
			}
		}
	}

	private bool CheckTargetValid(AActor Target)
	{
		Ingnores.Clear();
		Ingnores.Add(PlayerActor);
		Ingnores.Add(Target);
		if (Target is BGUCharacterCS owner)
		{
			if (BGUFunctionLibraryCS.BGUHasUnitState(Target, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(Target, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return false;
			}
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(Target));
			BUC_BattleStateData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_BattleStateData>(Target);
			if ((int)unitBattleInfoExtendDesc.QualityType > 5 && !unPersistentReadOnlyData.IsUnitInBattle())
			{
				return false;
			}
			FVector startTrace = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor);
			USceneComponent SocketOwnerComp;
			FVector location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, B1GlobalFNames.pelvis, out SocketOwnerComp).GetLocation();
			UBGUSelectUtil.LineTraceSimple(Owner, startTrace, location, ETraceTypeQuery.TraceTypeQuery7, bDebug: false, out var HitResult, Ingnores);
			if (HitResult.HitActor == null)
			{
				FVector location2 = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, B1GlobalFNames.root, out SocketOwnerComp).GetLocation();
				UBGUSelectUtil.LineTraceSimple(Owner, startTrace, location2, ETraceTypeQuery.TraceTypeQuery7, bDebug: false, out HitResult, Ingnores);
				if (HitResult.HitActor == null)
				{
					FVector location3 = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket: true, owner, B1GlobalFNames.head, out SocketOwnerComp).GetLocation();
					UBGUSelectUtil.LineTraceSimple(Owner, startTrace, location3, ETraceTypeQuery.TraceTypeQuery7, bDebug: false, out HitResult, Ingnores);
					if (HitResult.HitActor == null)
					{
						return true;
					}
				}
			}
		}
		else if (Target is BGUProjectileBaseActor)
		{
			UBGUSelectUtil.LineTraceSimple(Owner, BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(Target), ETraceTypeQuery.TraceTypeQuery7, bDebug: true, out var HitResult2, Ingnores);
			if (HitResult2.HitActor == null)
			{
				return true;
			}
		}
		return false;
	}

	private AActor GetBestTarget(bool NeedUpdateCacheMultiTarget = false)
	{
		if (BulletSmartSelectTargetConfig == null)
		{
			return null;
		}
		if (NeedUpdateCacheMultiTarget)
		{
			MultiTargetProjectileCtrData.MultiTargetDic.Clear();
			if (Player_BE != null)
			{
				Player_BE?.Evt_DoFreshMultiTarget.Invoke(BulletSmartSelectTargetConfig.SearchRadius, BulletSmartSelectTargetConfig.TargetTeamFilter, BulletSmartSelectTargetConfig.TargetTypeFilter, BulletSmartSelectTargetConfig.MultiTargetConditionTyp, BulletSmartSelectTargetConfig.Param1, BulletSmartSelectTargetConfig.Param2);
				foreach (UnitLockTargetInfo multiTargetInfo in TargetInfoData.GetMultiTargetInfoList())
				{
					AActor lockTargetActor = multiTargetInfo.LockTargetActor;
					if (lockTargetActor != null && CheckTargetValid(lockTargetActor))
					{
						MultiTargetProjectileCtrData.MultiTargetDic.Add(multiTargetInfo.LockTargetEntity, 0);
					}
				}
				MultiTargetProjectileCtrData.OriginalTargetCount = MultiTargetProjectileCtrData.MultiTargetDic.Count + BulletSmartSelectTargetConfig.HitCountAddition;
			}
		}
		float num = float.MinValue;
		AActor result = null;
		AActor aActor = ECSExtension.ToActor(MultiTargetProjectileCtrData.LastHitUnit);
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(MultiTargetProjectileCtrData.Projectile);
		FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor);
		foreach (KeyValuePair<Entity, int> item in MultiTargetProjectileCtrData.MultiTargetDic)
		{
			AActor aActor2 = ECSExtension.ToActor(item.Key);
			if (aActor2.IsNullOrDestroyed() || !BGUFunctionLibraryCS.BGUIsEnemyTeam(PlayerActor, aActor2))
			{
				continue;
			}
			if (aActor2 is BGUCharacterCS actor)
			{
				IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(actor);
				if (readOnlyData != null && !readOnlyData.IsUnitInBattle())
				{
					continue;
				}
				IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(actor);
				if (readOnlyData2 != null && readOnlyData2.HasSimpleState(EBGUSimpleState.Imperceptible))
				{
					continue;
				}
			}
			FVector location = BGUFuncLibActorTransformCS.BGUGetActorTransform(aActor2).GetLocation();
			float num2 = FVector.Dist(location, v);
			float num3 = FVector.Dist(location, v2);
			float num4 = 0f;
			if (aActor != null)
			{
				num4 = FVector.DotProduct(aActor.GetActorForwardVector(), aActor2.GetActorForwardVector());
			}
			int value = item.Value;
			float num5 = (0f - BulletSmartSelectTargetConfig.BeAttackedDecreaseValue) * (float)value + (0f - BulletSmartSelectTargetConfig.BulletDistanceDecreaseValue) * (float)(int)num2 / 100f + (0f - BulletSmartSelectTargetConfig.MasterDistanceDecreaseValue) * (float)(int)num3 / 100f + (0f - num4) * BulletSmartSelectTargetConfig.LastTargetDotDecreaseValue;
			if (num < num5)
			{
				num = num5;
				result = aActor2;
			}
		}
		return result;
	}
}
