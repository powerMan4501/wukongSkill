using System.Collections.Generic;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.ApexDestruction;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BUS_DestructibleComp : UActorCompBaseCS
{
	private b1.BUC_DestructibleData DestructibleData;

	private IBGC_SceneInactiveObjectMgrData SceneInactiveObjectMgrData;

	public override void OnAttach()
	{
		DestructibleData = RequireWritableData<b1.BUC_DestructibleData>();
		SceneInactiveObjectMgrData = RequireReadOnlyGameStateData<IBGC_SceneInactiveObjectMgrData, BGC_SceneInactiveObjectMgrData>();
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		if (!B1Global.GIsGameReleased)
		{
			int valueInGameThread = GSGameplayCVar.CVar_RandomDestroyDestructible.GetValueInGameThread();
			if (valueInGameThread > 0 && FMath.RandRange(0, 100) < valueInGameThread)
			{
				SetDestructibleState(EDestructibleState.Destroyed, ForceUpdate: true);
				BGU_UnrealWorldUtil.DestroyActor(Owner);
				return;
			}
		}
		CheckRegisterDestructibleActorToUnit();
		SetDestructibleState(EDestructibleState.Default, ForceUpdate: true);
		base.BUSEventCollection.Evt_HitDestructible += new Del_HitDestructible(OnHitDestructible);
		base.BUSEventCollection.Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
		base.BUSEventCollection.Evt_ModifyDestructible += new Del_ModifyDestructible(OnModifyDestructible);
		base.BUSEventCollection.Evt_ResetDestructible += new Del_Void_Bool(OnResetDestructible);
		base.BUSEventCollection.Evt_SetBGUActorActive += new Del_Void_Bool(OnSetBGUActorActive);
		base.BUSEventCollection.Evt_TriggerAtkReboundingSuccess += new Del_TriggerAtkReboundingSuccess(OnDestructibleParrySuccess);
	}

	private void RecordPhysicsCompInfoByTag(FName PhysicsCompTag)
	{
		Owner.GetAttachedActors(out var OutActors, bResetArray: true, bRecursivelyIncludeAttachedActors: true);
		OutActors.RemoveAll((AActor r) => !r.ActorHasTag(PhysicsCompTag) || DestructibleData.DestroyRelativeActors.Contains(r));
		if (OutActors.Count != 0)
		{
			foreach (AActor item in OutActors)
			{
				DestructibleData.DestroyRelativeActors.Add(item);
				foreach (UActorComponent item2 in item.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
				{
					RecordPhysicsComp(item2 as UMeshComponent);
				}
			}
		}
		foreach (UActorComponent item3 in Owner.GetComponentsByTag(UClass.GetClass<USceneComponent>(), PhysicsCompTag))
		{
			RecordPhysicsComp(item3 as UMeshComponent);
		}
	}

	private void RecordCPDCompsByTag(FName CPDCompTag)
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UMeshComponent>(), CPDCompTag))
		{
			RegisterCompsAlphaCPD(item as UMeshComponent);
		}
	}

	private void RecordPhysicsComp(UMeshComponent PhysicsComp)
	{
		if (!(PhysicsComp == null) && DestructibleData.PhysicsCompInfos.Find((b1.DestructiblePhysicsCompInfo r) => r.PhysicsComp == PhysicsComp) == null)
		{
			b1.DestructiblePhysicsCompInfo destructiblePhysicsCompInfo = new b1.DestructiblePhysicsCompInfo();
			destructiblePhysicsCompInfo.PhysicsComp = PhysicsComp;
			destructiblePhysicsCompInfo.AttachedComp = PhysicsComp.GetAttachParent();
			destructiblePhysicsCompInfo.RelativeTransform = PhysicsComp.GetRelativeTransform();
			destructiblePhysicsCompInfo.CanSimulatePhysics = (destructiblePhysicsCompInfo.DefaultSimulate = PhysicsComp.IsAnySimulatingPhysics());
			destructiblePhysicsCompInfo.DeactivateAfterDestruction = PhysicsComp.ComponentHasTag(B1GlobalFNames.DeactivateAfterDestruction);
			destructiblePhysicsCompInfo.DetachAfterDestruction = !PhysicsComp.ComponentHasTag(B1GlobalFNames.AttachAfterDestruction);
			DestructibleData.PhysicsCompInfos.Add(destructiblePhysicsCompInfo);
			PhysicsComp.SetCollisionProfileName(B1GlobalFNames.PhysicsActor);
			RegisterCompsAlphaCPD(PhysicsComp);
		}
	}

	private void RegisterCompsAlphaCPD(UMeshComponent Comp)
	{
		if (Comp != null && !DestructibleData.CPD_AlphaComps.Contains(Comp))
		{
			DestructibleData.CPD_AlphaComps.Add(Comp);
		}
	}

	public override bool AllowTRO()
	{
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DestructibleData.IsDestroyed)
		{
			DestructibleData.DissipationTimeLeft -= DeltaTime;
			if (DestructibleData.DissipationTimeLeft < DestructibleData.DebrisDissipationTime)
			{
				SetMeshCompsAlpha(DestructibleData.DissipationTimeLeft / DestructibleData.DebrisDissipationTime);
			}
			if (DestructibleData.DissipationTimeLeft < 0f)
			{
				SetDestructibleState(EDestructibleState.Destroyed);
			}
		}
		else
		{
			foreach (UDestructibleComponent key in DestructibleData.DestructibleCompInfos.Keys)
			{
				key.SetComponentTickEnabled(bEnabled: false);
			}
			SetCanTick(Val: false);
		}
		if (DestructibleData.IsApplyDamage && !DestructibleData.IsDestroyFinished)
		{
			DestroyDestructible(DestructibleData.DamageHitLocation, DestructibleData.DamageImpulseDir, DestructibleData.DamageImpulseStrength);
			(Owner as IBGUDestructibleActor)?.OnDestroyDestructible(DestructibleData.DamageHitLocation, DestructibleData.DamageImpulseDir, DestructibleData.DamageImpulseStrength, 0f);
			DestructibleData.IsApplyDamage = false;
		}
	}

	private void OnHitDestructible(AActor Attacker, EGSHitDestructibleStrengthLevel HitStrengthLevel, EGSHitDestructibleDirection HitDirectionType, FEffectInstReq EffectInstReq, float ImpulseStrength)
	{
		AActor owner = GetOwner();
		if (DestructibleData == null || owner == null || DestructibleData.IsDestroyed)
		{
			return;
		}
		if ((int)DestructibleData.StrengthLevel < (int)HitStrengthLevel)
		{
			FVector impulseDir = FVector.ZeroVector;
			if (HitDirectionType == EGSHitDestructibleDirection.DestructibleDirection)
			{
				impulseDir = owner.GetActorForwardVector();
			}
			if (HitDirectionType == EGSHitDestructibleDirection.AttackerSpeedDirection)
			{
				impulseDir = Attacker.GetVelocity().GetSafeNormal();
			}
			if (HitDirectionType == EGSHitDestructibleDirection.AttackerRelativeDirection)
			{
				impulseDir = (BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker)).GetSafeNormal();
			}
			base.BUSEventCollection.Evt_DestroyDestructible.Invoke(EffectInstReq.HitLocation, impulseDir, ImpulseStrength);
		}
		if (DestructibleData.CanParryStrengthLevel.Contains(HitStrengthLevel))
		{
			OnDestructibleParry(Attacker, EffectInstReq);
		}
	}

	private void OnDestructibleParry(AActor Attacker, FEffectInstReq EffectInstReq)
	{
		if (!(Attacker as BGUCharacterCS == null))
		{
			DestructibleData.DestructibleParryEffectInstReq = EffectInstReq;
			BUS_EventCollectionCS.Get(Attacker)?.Evt_TriggerAtkRebounding.Invoke(Owner, EffectInstReq.ObjectID, EffectInstReq.TriggerSkillId);
		}
	}

	private void OnDestructibleParrySuccess(AActor AtkReboundingActor)
	{
		UAkGameplayStatics.PostEventAtLocation(DestructibleData.DestructibleParryEvent, DestructibleData.DestructibleParryEffectInstReq.HitLocation, DestructibleData.DestructibleParryEffectInstReq.HitPointNormalDir, null, Owner);
		BUS_EventCollectionCS.Get(AtkReboundingActor)?.Evt_RequestSpawnFXByDispConfigDA.Invoke(DestructibleData.DestructibleParryDispConfig, out var _, null, NeedSetSpawnTransform: true, new FTransform(DestructibleData.DestructibleParryEffectInstReq.HitPointNormalDir, DestructibleData.DestructibleParryEffectInstReq.HitLocation));
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		if (GetOwner() != null && !DestructibleData.IsDestroyed)
		{
			SetDestructibleState(EDestructibleState.Destroying);
			DestructibleData.IsApplyDamage = true;
			DestructibleData.DamageHitLocation = HitLocation;
			DestructibleData.DamageImpulseDir = ImpulseDir;
			DestructibleData.DamageImpulseStrength = ImpulseStrength;
			DestructibleData.DissipationTimeLeft = DestructibleData.DestroyedLifeTime;
		}
	}

	private void DestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		FVector hurtOrigin = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		foreach (UDestructibleComponent key in DestructibleData.DestructibleCompInfos.Keys)
		{
			if (!(key == null))
			{
				key.SetComponentTickEnabled(bEnabled: true);
				UGSE_AnimFuncLib.ApplyRadiusDamage(key, 1000f, HitLocation, 50f, ImpulseStrength, bFullDamage: true);
				UGSE_AnimFuncLib.ApplyRadiusDamage(key, 1000f, hurtOrigin, 1000f, 0f, bFullDamage: true);
			}
		}
	}

	private void OnModifyDestructible(DestructibleMassLevel MassLevel, DestructibleStrengthLevel StrengthLevel)
	{
		float mass = 0f;
		switch (MassLevel)
		{
		case DestructibleMassLevel.Basic:
			mass = 0f;
			break;
		case DestructibleMassLevel.WalkDestroy:
			mass = 500f;
			break;
		case DestructibleMassLevel.RunDestroy:
			mass = 3000f;
			break;
		case DestructibleMassLevel.SprintDestroy:
			mass = 4000f;
			break;
		case DestructibleMassLevel.GiantDestroy:
			mass = 10000f;
			break;
		case DestructibleMassLevel.Indestructible:
			mass = 1000000f;
			break;
		}
		DestructibleData.Mass = mass;
		DestructibleData.StrengthLevel = StrengthLevel;
	}

	private void SetMeshCompsAlpha(float value)
	{
		foreach (UMeshComponent cPD_AlphaComp in DestructibleData.CPD_AlphaComps)
		{
			if (cPD_AlphaComp != null)
			{
				cPD_AlphaComp.SetCustomPrimitiveDataFloat(31, 1f - value);
			}
		}
	}

	private void OnDestructionFinished()
	{
		if (Owner is BGUFXActorBase)
		{
			DestroyRelativeActors();
			BGU_UnrealWorldUtil.DestroyActor(Owner);
		}
	}

	private void OnResetDestructible(bool IsDestroyed = false)
	{
		if (!(Owner == null))
		{
			SetCanTick(Val: false);
			if (IsDestroyed)
			{
				SetDestructibleState(EDestructibleState.Destroyed);
				(Owner as IBGUDestructibleActor)?.OnResetDestructible(IsDestroyed: true);
			}
			else
			{
				SetDestructibleState(EDestructibleState.Default);
				(Owner as IBGUDestructibleActor)?.OnResetDestructible(IsDestroyed: false);
			}
			base.BGSEventCollection.Evt_BGS_SetSceneInactiveActorForceActivateTicks.Invoke(Owner);
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		if (!(Owner == null))
		{
			CheckUnregisterDestructibleActorToUnit();
			if (DestructibleData.IsDestroyed)
			{
				SetDestructibleState(EDestructibleState.Default);
			}
			base.OnEndPlay(EndPlayReason);
		}
	}

	private void DestroyRelativeActors()
	{
		Owner.GetAllChildActors(out var ChildActors);
		foreach (AActor item in ChildActors)
		{
			BGU_UnrealWorldUtil.DestroyActor(item);
		}
		Owner.GetAttachedActors(out var OutActors, bResetArray: true, bRecursivelyIncludeAttachedActors: true);
		foreach (AActor item2 in OutActors)
		{
			BGU_UnrealWorldUtil.DestroyActor(item2);
		}
		foreach (AActor destroyRelativeActor in DestructibleData.DestroyRelativeActors)
		{
			if (destroyRelativeActor != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(destroyRelativeActor);
			}
		}
	}

	private void PhysicsCompLogicOnDestruction()
	{
		foreach (b1.DestructiblePhysicsCompInfo physicsCompInfo in DestructibleData.PhysicsCompInfos)
		{
			if (physicsCompInfo != null && physicsCompInfo.PhysicsComp != null)
			{
				physicsCompInfo.CanSimulatePhysics = !physicsCompInfo.DeactivateAfterDestruction;
				USkeletalMeshComponent uSkeletalMeshComponent = physicsCompInfo.PhysicsComp as USkeletalMeshComponent;
				if (uSkeletalMeshComponent != null && physicsCompInfo.DetachAfterDestruction && physicsCompInfo.CanSimulatePhysics)
				{
					uSkeletalMeshComponent.SetAllBodiesSimulatePhysics(bNewSimulate: true);
				}
				UpdatePhysicsCompInfoSimulate(physicsCompInfo);
			}
		}
	}

	private void PhysicsCompLogicOnReset(bool ResetToDestroyed)
	{
		foreach (b1.DestructiblePhysicsCompInfo physicsCompInfo in DestructibleData.PhysicsCompInfos)
		{
			if (physicsCompInfo != null && physicsCompInfo.PhysicsComp != null)
			{
				if (ResetToDestroyed)
				{
					physicsCompInfo.CanSimulatePhysics = false;
					physicsCompInfo.PhysicsComp.SetVisibility(bNewVisibility: false);
					physicsCompInfo.PhysicsComp.SetSimulatePhysics(bSimulate: false);
					physicsCompInfo.PhysicsComp.SetComponentTickEnabled(bEnabled: false);
					physicsCompInfo.PhysicsComp.SetCollisionProfileName(B1GlobalFNames.NoCollision);
					UpdatePhysicsCompInfoSimulate(physicsCompInfo);
					(physicsCompInfo.PhysicsComp as USkeletalMeshComponent)?.ResetAllBodiesSimulatePhysics();
					physicsCompInfo.PhysicsComp.AttachToComponent(physicsCompInfo.AttachedComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
					physicsCompInfo.PhysicsComp.SetRelativeTransform(physicsCompInfo.RelativeTransform, bSweep: false, out var _, bTeleport: true);
				}
				else
				{
					physicsCompInfo.CanSimulatePhysics = physicsCompInfo.DefaultSimulate;
					physicsCompInfo.PhysicsComp.SetVisibility(bNewVisibility: true);
					physicsCompInfo.PhysicsComp.SetSimulatePhysics(physicsCompInfo.DefaultSimulate);
					physicsCompInfo.PhysicsComp.SetCollisionProfileName(B1GlobalFNames.PhysicsActor);
					UpdatePhysicsCompInfoSimulate(physicsCompInfo);
					(physicsCompInfo.PhysicsComp as USkeletalMeshComponent)?.ResetAllBodiesSimulatePhysics();
					physicsCompInfo.PhysicsComp.AttachToComponent(physicsCompInfo.AttachedComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
					physicsCompInfo.PhysicsComp.SetRelativeTransform(physicsCompInfo.RelativeTransform, bSweep: false, out var _, bTeleport: true);
				}
			}
		}
	}

	private void UpdatePhysicsCompInfoSimulate(b1.DestructiblePhysicsCompInfo PhysicsCompInfo)
	{
		if (PhysicsCompInfo != null && PhysicsCompInfo.PhysicsComp != null)
		{
			bool flag = PhysicsCompInfo.CanSimulatePhysics && DestructibleData.IsActive;
			PhysicsCompInfo.PhysicsComp.SetSimulatePhysics(flag);
			PhysicsCompInfo.PhysicsComp.SetComponentTickEnabled(flag);
		}
	}

	private void OnSetBGUActorActive(bool IsActive)
	{
		DestructibleData.IsActive = IsActive;
		foreach (b1.DestructiblePhysicsCompInfo physicsCompInfo in DestructibleData.PhysicsCompInfos)
		{
			UpdatePhysicsCompInfoSimulate(physicsCompInfo);
		}
	}

	private void CheckRegisterDestructibleActorToUnit()
	{
		if (Owner.GetParentActor() is BGUCharacterCS actor)
		{
			BUS_DispLibEventCollection.Get(actor)?.Evt_AddChildActorMeshCompsToManager(Owner);
		}
	}

	private void CheckUnregisterDestructibleActorToUnit()
	{
		if (Owner.GetParentActor() is BGUCharacterCS actor)
		{
			BUS_DispLibEventCollection.Get(actor)?.Evt_RemoveChildActorMeshCompsFromManager(Owner);
		}
	}

	private bool CheckIsManagedCollision(FName CollisionProfile)
	{
		if (!(CollisionProfile == B1GlobalFNames.DestructibleBlock))
		{
			return CollisionProfile == B1GlobalFNames.DestructibleDetectiveMesh;
		}
		return true;
	}

	private void SetDestructibleState(EDestructibleState DestructibleState, bool ForceUpdate = false)
	{
		if (DestructibleData.DestructibleState != DestructibleState || ForceUpdate)
		{
			DestructibleData.DestructibleState = DestructibleState;
			switch (DestructibleState)
			{
			case EDestructibleState.Default:
				SetDestructibleState_Default();
				break;
			case EDestructibleState.Destroying:
				SetDestructibleState_Destroying();
				break;
			case EDestructibleState.Destroyed:
				SetDestructibleState_Destroyed();
				break;
			}
		}
	}

	private void SetDestructibleState_Default()
	{
		foreach (KeyValuePair<UPrimitiveComponent, FName> destructibleCollision in DestructibleData.DestructibleCollisions)
		{
			UPrimitiveComponent key = destructibleCollision.Key;
			if (key != null)
			{
				key.SetCollisionProfileName(destructibleCollision.Value);
				if (key is UShapeComponent collision && Owner != null && !(Owner.GetParentActor() is ACharacter) && !(Owner.GetParentActor() is BGUProjectileBaseActor))
				{
					UGSE_NavigationFuncLib.SetCollisionNavDynamicObstacle(collision, bDynamicObstacle: true);
				}
			}
		}
		bool flag = false;
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DestructibleShowMesh))
		{
			UStaticMeshComponent uStaticMeshComponent = item as UStaticMeshComponent;
			if (!(uStaticMeshComponent == null) || !(uStaticMeshComponent.StaticMesh != null))
			{
				uStaticMeshComponent.SetVisibility(bNewVisibility: true);
				flag = true;
			}
		}
		if (flag)
		{
			foreach (UActorComponent item2 in Owner.GetComponentsByClass(UClass.GetClass<UDestructibleComponent>()))
			{
				UDestructibleComponent uDestructibleComponent = item2 as UDestructibleComponent;
				if (uDestructibleComponent != null)
				{
					uDestructibleComponent.SetVisibility(bNewVisibility: false);
				}
			}
		}
		SetMeshCompsAlpha(1f);
		foreach (KeyValuePair<UDestructibleComponent, TStrongObjectPtr<UDestructibleMesh>> destructibleCompInfo in DestructibleData.DestructibleCompInfos)
		{
			UDestructibleComponent key2 = destructibleCompInfo.Key;
			if (key2 != null)
			{
				key2.SetDestructibleMesh(destructibleCompInfo.Value.Get());
				key2.SetComponentTickEnabled(bEnabled: false);
			}
		}
		PhysicsCompLogicOnReset(ResetToDestroyed: false);
		RecordPhysicsCompInfoByTag(B1GlobalFNames.PhysicsComp);
		if (SceneInactiveObjectMgrData.CheckIsBGUActorActive(Owner, EGSSceneActorActivationType.BGUActorActivation, out var IsActive))
		{
			OnSetBGUActorActive(IsActive);
		}
		SetCanTick(Val: false);
	}

	private void SetDestructibleState_Destroying()
	{
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent == null)
			{
				continue;
			}
			FName collisionProfileName = uShapeComponent.GetCollisionProfileName();
			if (CheckIsManagedCollision(collisionProfileName))
			{
				DestructibleData.DestructibleCollisions[uShapeComponent] = collisionProfileName;
				uShapeComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				if (Owner != null && !(Owner.GetParentActor() is ACharacter) && !(Owner.GetParentActor() is BGUProjectileBaseActor))
				{
					UGSE_NavigationFuncLib.SetCollisionNavDynamicObstacle(uShapeComponent, bDynamicObstacle: false);
				}
			}
		}
		foreach (UActorComponent item2 in Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DestructibleShowMesh))
		{
			UStaticMeshComponent uStaticMeshComponent = item2 as UStaticMeshComponent;
			if (!(uStaticMeshComponent == null))
			{
				uStaticMeshComponent.SetVisibility(bNewVisibility: false);
				FName collisionProfileName2 = uStaticMeshComponent.GetCollisionProfileName();
				if (CheckIsManagedCollision(collisionProfileName2))
				{
					DestructibleData.DestructibleCollisions[uStaticMeshComponent] = collisionProfileName2;
					uStaticMeshComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				}
			}
		}
		SetMeshCompsAlpha(1f);
		foreach (UActorComponent item3 in Owner.GetComponentsByClass(UClass.GetClass<UDestructibleComponent>()))
		{
			UDestructibleComponent uDestructibleComponent = item3 as UDestructibleComponent;
			if (!(uDestructibleComponent != null))
			{
				continue;
			}
			UDestructibleMesh destructibleMesh = uDestructibleComponent.GetDestructibleMesh();
			if (destructibleMesh != null)
			{
				if (!DestructibleData.DestructibleCompInfos.ContainsKey(uDestructibleComponent))
				{
					DestructibleData.DestructibleCompInfos.Add(uDestructibleComponent, new TStrongObjectPtr<UDestructibleMesh>(destructibleMesh));
				}
				RegisterCompsAlphaCPD(uDestructibleComponent);
				uDestructibleComponent.SetComponentTickEnabled(bEnabled: true);
				uDestructibleComponent.SetVisibility(bNewVisibility: true);
			}
		}
		RecordPhysicsCompInfoByTag(B1GlobalFNames.PhysicsComp);
		RecordCPDCompsByTag(B1GlobalFNames.DissipationComp);
		PhysicsCompLogicOnDestruction();
		SetCanTick(Val: true);
	}

	private void SetDestructibleState_Destroyed()
	{
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent == null)
			{
				continue;
			}
			FName collisionProfileName = uShapeComponent.GetCollisionProfileName();
			if (CheckIsManagedCollision(collisionProfileName))
			{
				DestructibleData.DestructibleCollisions[uShapeComponent] = collisionProfileName;
				uShapeComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				if (Owner != null && !(Owner.GetParentActor() is ACharacter) && !(Owner.GetParentActor() is BGUProjectileBaseActor))
				{
					UGSE_NavigationFuncLib.SetCollisionNavDynamicObstacle(uShapeComponent, bDynamicObstacle: false);
				}
			}
		}
		foreach (UActorComponent item2 in Owner.GetComponentsByTag(UClass.GetClass<UStaticMeshComponent>(), B1GlobalFNames.DestructibleShowMesh))
		{
			UStaticMeshComponent uStaticMeshComponent = item2 as UStaticMeshComponent;
			if (!(uStaticMeshComponent == null))
			{
				uStaticMeshComponent.SetVisibility(bNewVisibility: false);
				FName collisionProfileName2 = uStaticMeshComponent.GetCollisionProfileName();
				if (CheckIsManagedCollision(collisionProfileName2))
				{
					DestructibleData.DestructibleCollisions[uStaticMeshComponent] = collisionProfileName2;
					uStaticMeshComponent.SetCollisionEnabled(ECollisionEnabled.NoCollision);
				}
			}
		}
		foreach (UActorComponent item3 in Owner.GetComponentsByClass(UClass.GetClass<UDestructibleComponent>()))
		{
			UDestructibleComponent uDestructibleComponent = item3 as UDestructibleComponent;
			if (!(uDestructibleComponent != null))
			{
				continue;
			}
			UDestructibleMesh destructibleMesh = uDestructibleComponent.GetDestructibleMesh();
			if (destructibleMesh != null)
			{
				if (!DestructibleData.DestructibleCompInfos.ContainsKey(uDestructibleComponent))
				{
					DestructibleData.DestructibleCompInfos.Add(uDestructibleComponent, new TStrongObjectPtr<UDestructibleMesh>(destructibleMesh));
				}
				RegisterCompsAlphaCPD(uDestructibleComponent);
				uDestructibleComponent.SetDestructibleMesh(null);
			}
			uDestructibleComponent.SetComponentTickEnabled(bEnabled: false);
			uDestructibleComponent.SetVisibility(bNewVisibility: false);
		}
		RecordPhysicsCompInfoByTag(B1GlobalFNames.PhysicsComp);
		PhysicsCompLogicOnReset(ResetToDestroyed: true);
		if (SceneInactiveObjectMgrData.CheckIsBGUActorActive(Owner, EGSSceneActorActivationType.BGUActorActivation, out var IsActive))
		{
			OnSetBGUActorActive(IsActive);
		}
		SetCanTick(Val: false);
		OnDestructionFinished();
	}
}
