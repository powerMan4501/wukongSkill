using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_DispMgrComp")]
internal class BUS_DispMgrComp : UActorCompBaseUObj
{
	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_PropMgrData PropMgrData;

	private BUC_DispMgrData DispMgrData { get; set; }

	public override void OnAttach()
	{
		DispMgrData = RequireWritableData<BUC_DispMgrData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_EndAllVFX += new Del_Void(OnEndAllVFX);
		base.BUSEventCollection.Evt_SpawnGhostActor += new Del_SpawnGhostActor(OnSpawnGhostActor);
		base.BUSEventCollection.Evt_PlayBeamFX += new Del_PlayBeamFX(OnPlayBeamFX);
		base.BUSEventCollection.Evt_OnDestroyFXCompByTag += new Del_OnDestroyFXCompByTag(OnDestroyFXCompByTag);
		base.BUSEventCollection.Evt_HideOrShowMesh += new Del_Void_BoolString(OnHideOrShowMesh);
		base.BUSEventCollection.Evt_ResetHideOrShowMesh += new Del_Void_String(OnResetHideOrShowMesh);
	}

	private void OnEndAllVFX()
	{
		if (!(Owner != null))
		{
			return;
		}
		foreach (UActorComponent item in Owner.GetComponentsByClass(UClass.GetClass<UParticleSystemComponent>()))
		{
			if (!(item == null) && !item.IsPendingKill)
			{
				UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
				UParticleSystemComponent uParticleSystemComponent = item as UParticleSystemComponent;
				if (uParticleSystemComponent != null && !uParticleSystemComponent.IsPendingKill)
				{
					uParticleSystemComponent.EndTrails();
				}
				else if (uNiagaraComponent != null && !uNiagaraComponent.IsPendingKill)
				{
					uNiagaraComponent.DestroyComponent(Owner);
				}
			}
		}
	}

	private void OnSpawnGhostActor(string DataAssetPath, FEffectInstReq EffectInstReq = default(FEffectInstReq), UAnimMontage MontageToMapTo = null)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		BGWDataAsset_GhostActorSetting bGWDataAsset_GhostActorSetting = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<BGWDataAsset_GhostActorSetting>(DataAssetPath, ELoadResourceType.SyncLoadAndCache);
		if (!(bGWDataAsset_GhostActorSetting != null))
		{
			return;
		}
		UClass uClass = bGWDataAsset_GhostActorSetting.GhostActorClass.Value;
		if (uClass == null)
		{
			uClass = UObject.LoadClass<AActor>(null, "/Game/00Main/BPLibrary/VFX/BP_GhostBaseActor.BP_GhostBaseActor_C");
		}
		if (uClass != null)
		{
			FTransform worldTransform = aCharacter.Mesh.GetWorldTransform();
			FActorSpawnParameters fActorSpawnParameters = new FActorSpawnParameters
			{
				SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
			};
			AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(aCharacter.World, uClass, in worldTransform.Translation, worldTransform.Rotation.Rotator());
			if (aActor != null)
			{
				BUS_EventCollectionCS.Get(aActor).Evt_TriggerGhostActor.Invoke(aCharacter, bGWDataAsset_GhostActorSetting, EffectInstReq, MontageToMapTo);
			}
		}
	}

	private void OnPlayBeamFX(FGSBeamFXPlaySetting BeamFXPlaySetting)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		ACharacter aCharacter2 = aCharacter;
		if (BeamFXPlaySetting.GSBeamTargetType == EBeamFXTargetActorType.CameraLockActor)
		{
			aCharacter2 = TargetInfoData.GetTargetInfo().LockTargetActor as ABGUCharacter;
		}
		if (!(aCharacter2 == null))
		{
			UNiagaraSystem uNiagaraSystem = BeamFXPlaySetting.BeamTemplate.Value;
			if (uNiagaraSystem == null)
			{
				uNiagaraSystem = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<UNiagaraSystem>(BeamFXPlaySetting.BeamTemplate.Path, ELoadResourceType.AsyncLoadAndCache);
			}
			UNiagaraComponent uNiagaraComponent = null;
			if (BeamFXPlaySetting.IsAttach)
			{
				uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(uNiagaraSystem, aCharacter.Mesh, BeamFXPlaySetting.AttachSocketName, FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.SnapToTarget, bAutoDestroy: true);
			}
			else
			{
				FTransform socketTransform = aCharacter.Mesh.GetSocketTransform(BeamFXPlaySetting.AttachSocketName);
				FTransform fTransform = default(FTransform);
				FQuat fQuat = new FQuat(FRotator.ZeroRotator);
				fTransform.SetLocation(socketTransform.TransformPosition(FVector.ZeroVector));
				fTransform.SetRotation(socketTransform.GetRotation() * fQuat);
				fTransform.SetScale3D(BeamFXPlaySetting.Scale);
				uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(aCharacter.World, uNiagaraSystem, fTransform.GetLocation(), fTransform.Rotator(), fTransform.Scale3D, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
			}
			if (!(uNiagaraComponent == null))
			{
				FTransform socketTransform2 = aCharacter2.Mesh.GetSocketTransform(BeamFXPlaySetting.TargetSocketName);
				uNiagaraComponent.SetNiagaraVariableVec3(BeamFXPlaySetting.GSBeamTargetParamName, socketTransform2.GetLocation());
			}
		}
	}

	private void OnDestroyFXCompByTag(FName Tag, bool DestroyImmediately)
	{
		if (Owner.IsNullOrDestroyed())
		{
			return;
		}
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UFXSystemComponent>(), Tag))
		{
			UNiagaraComponent uNiagaraComponent = item as UNiagaraComponent;
			if (uNiagaraComponent != null)
			{
				if (DestroyImmediately)
				{
					uNiagaraComponent.DestroyComponent(Owner);
				}
				else
				{
					uNiagaraComponent.Deactivate();
				}
				continue;
			}
			UParticleSystemComponent uParticleSystemComponent = item as UParticleSystemComponent;
			if (uParticleSystemComponent != null)
			{
				if (DestroyImmediately)
				{
					uParticleSystemComponent.DestroyComponent(Owner);
					continue;
				}
				UBGUFunctionLibraryForCS.BGUSetParticleSysCompPoolingMethod(uParticleSystemComponent, EPSCPoolMethod.ManualRelease);
				uParticleSystemComponent.ReleaseToPool();
			}
		}
	}

	private void OnHideOrShowMesh(bool IsShow, string MeshName)
	{
		AActor owner = GetOwner();
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		List<UActorComponent> componentsByClass = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		List<UActorComponent> componentsByClass2 = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
		componentsByClass.AddRange(componentsByClass2);
		foreach (UActorComponent item in componentsByClass)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (uSceneComponent == null || !(uSceneComponent.GetName().ToString() == MeshName))
			{
				continue;
			}
			if (uSceneComponent == mesh)
			{
				if (DispMgrData.HiddenInGameHandleID == 0)
				{
					base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, !IsShow);
					DispMgrData.HiddenInGameHandleID = PropMgrData.GetLastHandleID();
				}
				else
				{
					base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_HiddenInGame, !IsShow, DispMgrData.HiddenInGameHandleID);
				}
			}
			else
			{
				if (!DispMgrData.OriMeshHiddenInGame.ContainsKey(MeshName))
				{
					DispMgrData.OriMeshHiddenInGame.Add(MeshName, uSceneComponent.HiddenInGame);
				}
				uSceneComponent.SetHiddenInGame(!IsShow);
			}
			break;
		}
	}

	private void OnResetHideOrShowMesh(string MeshName)
	{
		AActor owner = GetOwner();
		if (!(owner != null))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null))
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		List<UActorComponent> componentsByClass = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>());
		List<UActorComponent> componentsByClass2 = bGUCharacterCS.GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
		componentsByClass.AddRange(componentsByClass2);
		foreach (UActorComponent item in componentsByClass)
		{
			USceneComponent uSceneComponent = item as USceneComponent;
			if (!(uSceneComponent == null) && uSceneComponent.GetName().ToString() == MeshName)
			{
				bool value;
				if (uSceneComponent == mesh)
				{
					base.BUSEventCollection.Evt_ResetProperty.Invoke(DispMgrData.HiddenInGameHandleID);
					DispMgrData.HiddenInGameHandleID = 0u;
				}
				else if (DispMgrData.OriMeshHiddenInGame.TryGetValue(MeshName, out value))
				{
					uSceneComponent.SetHiddenInGame(value);
				}
				break;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_DispMgrComp");
	}

	static BUS_DispMgrComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_DispMgrComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_DispMgrComp));
	}
}
