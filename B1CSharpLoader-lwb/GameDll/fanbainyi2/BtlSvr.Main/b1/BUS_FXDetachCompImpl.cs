using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_FXDetachCompImpl : UActorCompBaseCS
{
	private b1.BUC_FXDetachData FXDetachData;

	public override void OnAttach()
	{
		FXDetachData = RequireWritableData<b1.BUC_FXDetachData>();
	}

	public override void PreBeginPlay()
	{
		FXDetachData.NiagaraCompList = new List<UNiagaraComponent>();
		FXDetachData.ParticleCompList = new List<UParticleSystemComponent>();
		FXDetachData.DetachedNiagaraCompList = new List<UNiagaraComponent>();
		FXDetachData.DetachedParticleCompList = new List<UParticleSystemComponent>();
	}

	public override void OnBeginPlay()
	{
		InitFXComp();
		RespawnFX();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		ReleaseFX();
	}

	private void InitFXComp()
	{
		List<UActorComponent> componentsByClass = Owner.GetComponentsByClass(UClass.GetClass<UNiagaraComponent>());
		List<UActorComponent> componentsByClass2 = Owner.GetComponentsByClass(UClass.GetClass<UParticleSystemComponent>());
		foreach (UActorComponent item in componentsByClass)
		{
			if (FXDetachData.FXComponentName.Contains(item.GetName()))
			{
				FXDetachData.NiagaraCompList.Add(item as UNiagaraComponent);
			}
		}
		foreach (UActorComponent item2 in componentsByClass2)
		{
			if (FXDetachData.FXComponentName.Contains(item2.GetName()))
			{
				FXDetachData.ParticleCompList.Add(item2 as UParticleSystemComponent);
			}
		}
	}

	private void RespawnFX()
	{
		foreach (UNiagaraComponent niagaraComp in FXDetachData.NiagaraCompList)
		{
			niagaraComp.SetActive(bNewActive: false);
			FTransform relativeTransform = niagaraComp.GetRelativeTransform();
			UNiagaraComponent uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(niagaraComp.GetFXSystemAsset() as UNiagaraSystem, niagaraComp.GetAttachParent(), niagaraComp.GetAttachSocketName(), relativeTransform.GetLocation(), relativeTransform.GetRotation().Rotator(), EAttachLocation.SnapToTargetIncludingScale, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.ManualRelease);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				FXDetachData.DetachedNiagaraCompList.Add(uNiagaraComponent);
			}
		}
		foreach (UParticleSystemComponent particleComp in FXDetachData.ParticleCompList)
		{
			particleComp.SetActive(bNewActive: false);
			FTransform relativeTransform2 = particleComp.GetRelativeTransform();
			UParticleSystemComponent uParticleSystemComponent = UGameplayStatics.SpawnEmitterAttached(particleComp.GetFXSystemAsset() as UParticleSystem, particleComp.GetAttachParent(), particleComp.GetAttachSocketName(), relativeTransform2.GetLocation(), relativeTransform2.GetRotation().Rotator(), relativeTransform2.GetScale3D(), EAttachLocation.SnapToTargetIncludingScale, bAutoDestroy: true, EPSCPoolMethod.ManualRelease, bAutoActivate: true);
			if (!uParticleSystemComponent.IsNullOrDestroyed())
			{
				FXDetachData.DetachedParticleCompList.Add(uParticleSystemComponent);
			}
		}
	}

	private void ReleaseFX()
	{
		foreach (UNiagaraComponent detachedNiagaraComp in FXDetachData.DetachedNiagaraCompList)
		{
			if (!detachedNiagaraComp.IsNullOrDestroyed())
			{
				detachedNiagaraComp.ReleaseToPool();
			}
		}
		foreach (UParticleSystemComponent detachedParticleComp in FXDetachData.DetachedParticleCompList)
		{
			if (!detachedParticleComp.IsNullOrDestroyed())
			{
				detachedParticleComp.ReleaseToPool();
			}
		}
	}
}
