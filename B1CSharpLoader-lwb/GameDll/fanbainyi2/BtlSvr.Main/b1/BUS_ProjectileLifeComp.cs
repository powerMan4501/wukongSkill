using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ProjectileLifeComp : UActorCompBaseCS
{
	private BUC_ProjectileLifeData ProjectileLifeData;

	private BUC_ProjectileBasicData ProjectileBasicData;

	private IBUC_MasterData MasterData;

	public override void OnAttach()
	{
		ProjectileLifeData = RequireWritableData<BUC_ProjectileLifeData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>();
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
		base.BUSEventCollection.Evt_ProjectileAttachToTarget += new Del_ProjectileAttachToTarget(HitAttachToActor);
		base.BUSEventCollection.Evt_ProjectileFinishAttach += new Del_Void(FinishAttach);
		base.BUSEventCollection.Evt_ProjectileFinishAttachAndDestroyImmediatly += new Del_Void(FinishAttachAndDestroyImmediatly);
		ProjectileBasicData.OnProjectileIDChg += delegate(int OldVal, int NewVal)
		{
			FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(NewVal, MasterData.GetMasterActor());
			if (projectileCommDesc != null)
			{
				ProjectileLifeData.ProjectileisFresh = projectileCommDesc.ProjectileIsFresh == EGSYesNo.Yes;
				ProjectileLifeData.ProjectileLifeTimer = projectileCommDesc.ProjectileLifeTime;
				ProjectileLifeData.ProjectileLifeLowestSpeed = projectileCommDesc.ProjectileLifeSpeed;
				ProjectileLifeData.ProjectileDestroyTimer = projectileCommDesc.ProjectileDelayDestroyTime;
			}
		};
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DeadAttachParentVaildCheck();
		ProjectileLifeData.DeadAttachTimerTick(DeltaTime);
		if (!InProjectileDeadDestroyTick(DeltaTime))
		{
			ProjectileLifeTick(DeltaTime);
		}
	}

	private bool InProjectileDeadDestroyTick(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return true;
		}
		if (ProjectileLifeData.ProjectileIsDead)
		{
			if (!ProjectileLifeData.bInDeadAttach())
			{
				if (ProjectileLifeData.ProjectileDestroyTimer >= 0f)
				{
					ProjectileLifeData.ProjectileDestroyTimer -= DeltaTime;
				}
				if (ProjectileLifeData.ProjectileDestroyTimer < 0f)
				{
					BGU_UnrealWorldUtil.DestroyActor(owner);
				}
			}
			return true;
		}
		return false;
	}

	private void ProjectileLifeTick(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		if (ProjectileLifeData.ProjectileLifeTimer != -1f && ProjectileLifeData.ProjectileLifeTimer >= 0f)
		{
			ProjectileLifeData.ProjectileLifeTimer -= DeltaTime;
			if (ProjectileLifeData.ProjectileLifeTimer < 0f)
			{
				ProjectileLifeData.ProjectileLifeTimer = -1f;
				BUC_ActorBasicData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(owner);
				if (readOnlyData == null)
				{
					BGU_UnrealWorldUtil.DestroyActor(owner);
					return;
				}
				if (readOnlyData.ActorType == BGU_ActorType.MagicField)
				{
					if (base.BUSEventCollection != null)
					{
						base.BUSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.TimeOutDestroy);
						return;
					}
				}
				else if (readOnlyData.ActorType == BGU_ActorType.Bullet && base.BUSEventCollection != null)
				{
					FEffectInstReq EffectInstReq = new FEffectInstReq
					{
						HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)
					};
					base.BUSEventCollection.Evt_BulletTriggerEffectsByReson.Invoke(EBGUBulletTriggerEffectReason.LifeOver, ref EffectInstReq);
					return;
				}
			}
		}
		if (ProjectileLifeData.ProjectileLifeLowestSpeed != -1f && BGUFuncLibActorTransformCS.BGUGetVelocity(owner).Size() < ProjectileLifeData.ProjectileLifeLowestSpeed)
		{
			OnProjectileDead(EBGUBulletDestroyReason.SpeedLowDestroy);
		}
	}

	private void OnFarthestDistOutCheckTick(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (!owner.IsNullOrDestroyed() && MasterData != null)
		{
			AActor masterActor = MasterData.GetMasterActor();
			if (!masterActor.IsNullOrDestroyed() && FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(masterActor), BGUFuncLibActorTransformCS.BGUGetActorLocation(owner)) > 200000f)
			{
				OnProjectileDead(EBGUBulletDestroyReason.FarthestDistOutDestroy);
			}
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		if (ProjectileLifeData.ProjectileIsDead)
		{
			return;
		}
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor != null && !bGUProjectileBaseActor.IsPendingKill)
		{
			ProjectileLifeData.ProjectileIsDead = true;
		}
		base.BUSEventCollection.Evt_BuffAllRemove.Invoke(EBuffEffectTriggerType.None);
		AActor masterActor = MasterData.GetMasterActor();
		if (masterActor != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(masterActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveCtrableBulletFromPack.Invoke(bGUProjectileBaseActor);
			}
		}
		if (RequireWritableData<BUC_ProjectileBasicData>().ProjectileType == EBGUBulletType.ModularActor)
		{
			bGUProjectileBaseActor.GetAttachedActors(out var OutActors);
			foreach (AActor item in OutActors)
			{
				item.DetachFromActor();
				(item.RootComponent as UPrimitiveComponent).SetSimulatePhysics(bSimulate: true);
			}
		}
		bGUProjectileBaseActor.OnDead();
	}

	private void HitAttachToActor(AActor AttachTarget, float TimeToDead, float AttachOffset, in FEffectInstReq EffectInst)
	{
		if (ProjectileLifeData.bInDeadAttach() || AttachTarget == null || TimeToDead <= 0f || BGU_DataUtil.GetActorType(AttachTarget) == BGU_ActorType.Bullet)
		{
			return;
		}
		FVector hitLocation = EffectInst.HitLocation;
		FVector fVector = EffectInst.HitPointNormalDir.Conv_RotatorToVector();
		FName hitBoneName = EffectInst.HitBoneName;
		UPrimitiveComponent hitComp = EffectInst.HitComp;
		BGUCharacterCS bGUCharacterCS = AttachTarget as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null)
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(bGUCharacterCS);
			IBUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(bGUCharacterCS);
			if (readOnlyData == null || readOnlyData2 == null || readOnlyData.HasSimpleState(EBGUSimpleState.InTTTB) || readOnlyData.HasSimpleState(EBGUSimpleState.PhantomRush) || readOnlyData2.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || readOnlyData2.HasState(EBGUUnitState.LifeSavingHair_Rebirth))
			{
				return;
			}
			if (hitComp as USkeletalMeshComponent != null)
			{
				float num = UBGUFunctionLibraryForCS.BGUGetBodyRadius(bGUCharacterCS.Mesh, hitBoneName, bGetWelded: true);
				float num2 = 0.5f;
				num2 = ((num < 50f) ? 0.5f : ((!(num < 150f)) ? 0.2f : 0.3f));
				hitLocation -= fVector * num * num2;
			}
			BGUProjectileBaseActor obj = Owner as BGUProjectileBaseActor;
			FVector translation = obj.GetWorldTransform_HitAttachPoint().Translation;
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(obj) - translation;
			FVector newLocation = hitLocation + fVector2 + BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner) * AttachOffset;
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, newLocation, bSweep: false, bTeleport: true);
			BGUFuncLibActorTransformCS.BGUAttachToComp(Owner, hitComp, hitBoneName, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld);
			(Owner as BGUBulletBaseCS).AttachBoneName = hitBoneName.ToString();
		}
		else
		{
			BGUProjectileBaseActor obj2 = Owner as BGUProjectileBaseActor;
			FVector translation2 = obj2.GetWorldTransform_HitAttachPoint().Translation;
			FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(obj2) - translation2;
			FVector newLocation2 = hitLocation + fVector3 + BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner) * AttachOffset;
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, newLocation2, bSweep: false, bTeleport: true);
			BGUFuncLibActorTransformCS.BGUAttachToComp(Owner, hitComp, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld);
		}
		ProjectileLifeData.DeadAttachTimer = TimeToDead;
		base.BGSEventCollection.Evt_OnProjectileBeginAttach.Invoke(Owner);
	}

	private void DeadAttachParentVaildCheck()
	{
		if (ProjectileLifeData.bInDeadAttach() && BGUFuncLibActorTransformCS.BGUGetAttachParentActor(Owner).IsNullOrDestroyed())
		{
			if (ProjectileLifeData.ProjectileIsDead)
			{
				BGU_UnrealWorldUtil.DestroyActor(Owner);
			}
			else
			{
				base.BUSEventCollection.Evt_OnProjectileDead.Invoke(EBGUBulletDestroyReason.AttachedParentNotValid);
			}
		}
	}

	private void FinishAttach()
	{
		ProjectileLifeData.DeadAttachTimer = -1f;
	}

	private void FinishAttachAndDestroyImmediatly()
	{
		ProjectileLifeData.DeadAttachTimer = -1f;
		ProjectileLifeData.ProjectileDestroyTimer = -1f;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (EndPlayReason == EEndPlayReason.Destroyed)
		{
			base.BGSEventCollection.Evt_OnProjectileDestroyed.Invoke(Owner);
		}
	}
}
