using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BulletDispComp : UActorCompBaseCS
{
	private BUC_BulletDispData DispData { get; set; }

	private IBUC_ActorTransformInfoData ActorTransformInfoData { get; set; }

	public override void OnAttach()
	{
		DispData = RequireWritableData<BUC_BulletDispData>();
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		base.BUSEventCollection.Evt_SpawnBulletFXByReason += new Del_SpawnBulletFXByReason(SpawnFXByReason);
		base.BUSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnBulletDead);
		base.BUSEventCollection.Evt_OnUpdateBulletRingFX += new Del_Void_FloatFloat(OnUpdateRingFX);
		base.BUSEventCollection.Evt_ProjectileInitialization += new Del_ProjectileInitialization(OnBulletInit);
	}

	private void OnBulletInit(FGSProjectileSpawnInfo ProjectileSpawnInfo, AActor BulletOwner)
	{
		if (DispData.bUseGlobalFX && DispData.FXTag != FName.None)
		{
			DispData.bCanUpdateGlobalFX = true;
			ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
			base.BGSEventCollection.Evt_AddOrUpdateBulletPosition2GlobalFX.Invoke(DispData.FXTag, BulletOwner, OutLocation);
		}
	}

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		if (DispData.bCanUpdateGlobalFX || DispData.bNeedReleaseFX)
		{
			return 0f;
		}
		return -1f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DispData.bCanUpdateGlobalFX)
		{
			ActorTransformInfoData.GetNextUpdateLocation(out var OutLocation);
			base.BGSEventCollection.Evt_AddOrUpdateBulletPosition2GlobalFX.Invoke(DispData.FXTag, Owner, OutLocation);
		}
		if (DispData.bNeedReleaseFX)
		{
			ReleaseFX();
			DispData.bNeedReleaseFX = false;
		}
	}

	private void SpawnFXByReason(EBGUBulletDispReason BulletDispReason, FEffectInstReq EffectInstReq, AActor BeHitActor = null)
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || bGUProjectileBaseActor.IsPendingKill)
		{
			return;
		}
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(bGUProjectileBaseActor.GetProjectileID());
		if (projectileDispDesc == null)
		{
			return;
		}
		float bulletLowestSpdCanPlayPS = projectileDispDesc.BulletLowestSpdCanPlayPS;
		BUC_ObjActorMovementData bUC_ObjActorMovementData = RequireWritableData<BUC_ObjActorMovementData>();
		if (bUC_ObjActorMovementData != null && bulletLowestSpdCanPlayPS != -1f && bUC_ObjActorMovementData.CurVelocity.Size() < bulletLowestSpdCanPlayPS)
		{
			return;
		}
		string text = "";
		FTransform spawnTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(bGUProjectileBaseActor);
		spawnTransform.SetScale3D(FVector.OneVector);
		switch (BulletDispReason)
		{
		case EBGUBulletDispReason.HitChr:
			text = projectileDispDesc.BulletHitUnitPSPath;
			spawnTransform.SetLocation(EffectInstReq.HitLocation);
			spawnTransform.SetRotation(EffectInstReq.HitPointNormalDir.Quaternion());
			break;
		case EBGUBulletDispReason.HitSceneItem:
			text = projectileDispDesc.BulletHitItemPSPath;
			spawnTransform.SetLocation(EffectInstReq.HitLocation);
			spawnTransform.SetRotation(EffectInstReq.HitPointNormalDir.Quaternion());
			break;
		case EBGUBulletDispReason.BeHit:
			text = projectileDispDesc.BeHitedProjectilePlayFXPath;
			break;
		case EBGUBulletDispReason.LifeOver:
			text = projectileDispDesc.BulletLifeOverPSPath;
			break;
		}
		if (projectileDispDesc.ProjectileFXUseDBC == EGSYesNo.Yes)
		{
			BUS_GSEventCollection bUS_GSEventCollection = null;
			bUS_GSEventCollection = ((BulletDispReason != EBGUBulletDispReason.HitChr) ? BUS_EventCollectionCS.Get(this) : BUS_EventCollectionCS.Get(BeHitActor));
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(text, out var RequestID, null, NeedSetSpawnTransform: true, spawnTransform);
				bUS_GSEventCollection.Evt_NotifyBulletMarkDBCReqID.Invoke(RequestID);
			}
			return;
		}
		UObject uObject = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UObject>(text, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
		if (!(uObject != null))
		{
			return;
		}
		UParticleSystem uParticleSystem = uObject as UParticleSystem;
		if (uParticleSystem != null)
		{
			UGameplayStatics.SpawnEmitterAtLocation(GetOwner(), uParticleSystem, spawnTransform.Translation, spawnTransform.Rotation.Quat_Rotator(), spawnTransform.Scale3D, bAutoDestroy: true, EPSCPoolMethod.AutoRelease, bAutoActivateSystem: true);
			return;
		}
		UNiagaraSystem uNiagaraSystem = uObject as UNiagaraSystem;
		if (uNiagaraSystem != null)
		{
			UNiagaraFunctionLibrary.SpawnSystemAtLocation(GetOwner().World, uNiagaraSystem, spawnTransform.Translation, spawnTransform.Rotation.Quat_Rotator(), spawnTransform.Scale3D, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
		}
	}

	private void ReleaseFX()
	{
		BGUProjectileBaseActor bGUProjectileBaseActor = GetOwner() as BGUProjectileBaseActor;
		if (bGUProjectileBaseActor == null || bGUProjectileBaseActor.IsPendingKill)
		{
			return;
		}
		FUStProjectileDispDesc projectileDispDesc = BGW_GameDB.GetProjectileDispDesc(bGUProjectileBaseActor.GetProjectileID());
		if (projectileDispDesc == null)
		{
			return;
		}
		string fXDestroyImmediatelyTag = projectileDispDesc.FXDestroyImmediatelyTag;
		List<UActorComponent> componentsByClass = bGUProjectileBaseActor.GetComponentsByClass(UClass.GetClass<UParticleSystemComponent>());
		if (componentsByClass != null)
		{
			foreach (UActorComponent item in componentsByClass)
			{
				UParticleSystemComponent uParticleSystemComponent = item as UParticleSystemComponent;
				if (!(uParticleSystemComponent == null))
				{
					if (!string.IsNullOrEmpty(fXDestroyImmediatelyTag) && uParticleSystemComponent.ComponentHasTag(new FName(fXDestroyImmediatelyTag)))
					{
						uParticleSystemComponent.DestroyComponent(bGUProjectileBaseActor);
						continue;
					}
					UBGUFunctionLibraryForCS.BGUSetParticleSysCompPoolingMethod(uParticleSystemComponent, EPSCPoolMethod.ManualRelease);
					uParticleSystemComponent.ReleaseToPool();
				}
			}
		}
		List<UActorComponent> componentsByClass2 = bGUProjectileBaseActor.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		if (componentsByClass2 == null)
		{
			return;
		}
		foreach (UActorComponent item2 in componentsByClass2)
		{
			UNiagaraComponent uNiagaraComponent = item2 as UNiagaraComponent;
			if (!(uNiagaraComponent == null) && !uNiagaraComponent.ComponentHasTag(B1GlobalFNames.DBCNG))
			{
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
				if (!string.IsNullOrEmpty(fXDestroyImmediatelyTag) && uNiagaraComponent.ComponentHasTag(new FName(fXDestroyImmediatelyTag)))
				{
					uNiagaraComponent.DestroyComponent(bGUProjectileBaseActor);
				}
				else
				{
					uNiagaraComponent.Deactivate();
				}
			}
		}
	}

	private void OnBulletDead(EBGUBulletDestroyReason DestroyReason)
	{
		if (DispData.bCanUpdateGlobalFX)
		{
			base.BGSEventCollection.Evt_RemoveBulletPosition2GlobalFX.Invoke(DispData.FXTag, Owner);
			DispData.bCanUpdateGlobalFX = false;
		}
		FEffectInstReq effectInstReq = new FEffectInstReq(GetOwner());
		SpawnFXByReason(EBGUBulletDispReason.LifeOver, effectInstReq);
		SetBulletMeshHidden();
		DispData.bNeedReleaseFX = true;
	}

	private void SetBulletMeshHidden()
	{
		AActor owner = GetOwner();
		bool flag = false;
		BUC_ProjectileLifeData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ProjectileLifeData>(owner);
		if (readOnlyData != null && readOnlyData.bInDeadAttach())
		{
			flag = true;
		}
		if (flag)
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
		{
			UMeshComponent uMeshComponent = item as UMeshComponent;
			if (uMeshComponent != null)
			{
				uMeshComponent.SetVisibility(bNewVisibility: false);
			}
			USkeletalMeshComponent uSkeletalMeshComponent = uMeshComponent as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null)
			{
				uSkeletalMeshComponent.PauseAnims = true;
			}
		}
		List<UActorComponent> componentsByTag = owner.GetComponentsByTag(UClass.GetClass<UFXSystemComponent>(), FXParamName.NeedDestroyImmediatelyFXTag_Tag);
		if (componentsByTag.Count <= 0)
		{
			return;
		}
		foreach (UActorComponent item2 in componentsByTag)
		{
			UFXSystemComponent uFXSystemComponent = item2 as UFXSystemComponent;
			if (uFXSystemComponent != null)
			{
				uFXSystemComponent.SetVisibility(bNewVisibility: false);
			}
		}
	}

	private void OnUpdateRingFX(float RingInnerRadius, float RingOuterRadius)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		foreach (UActorComponent item in owner.GetComponentsByTag(UClass.GetClass<UFXSystemComponent>(), FXParamName.RingFX_Tag))
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (uNiagaraComponent != null)
			{
				uNiagaraComponent.SetNiagaraVariableFloat(FXParamName.RingFXInnerRadius_ParamName, RingInnerRadius);
				uNiagaraComponent.SetNiagaraVariableFloat(FXParamName.RingFXOuterRadius_ParamName, RingOuterRadius);
			}
		}
	}
}
