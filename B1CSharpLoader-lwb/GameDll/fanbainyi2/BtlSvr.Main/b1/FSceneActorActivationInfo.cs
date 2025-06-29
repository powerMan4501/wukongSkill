using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class FSceneActorActivationInfo
{
	private List<UActorComponent> ActivateComps;

	public EGSSceneActorActivationType SceneActorActivationType { get; private set; }

	public float ActivateDistance { get; private set; }

	public bool bIsEnabled { get; private set; }

	public FSceneActorActivationInfo(AActor Actor, FGSSceneActorActivationInfo SceneActorActivationInfo, List<UPrimitiveComponent> CheckComps = null)
	{
		SceneActorActivationType = SceneActorActivationInfo.SceneActorActivationType;
		ActivateDistance = SceneActorActivationInfo.ActivateDistance;
		ActivateComps = new List<UActorComponent>();
		switch (SceneActorActivationInfo.SceneActorActivationType)
		{
		case EGSSceneActorActivationType.EmitterActivation:
			if (SceneActorActivationInfo.Tag == FName.None)
			{
				ActivateComps = Actor.GetComponentsByClass(UClass.GetClass<UPrimitiveComponent>());
			}
			else
			{
				ActivateComps = Actor.GetComponentsByTag(UClass.GetClass<UPrimitiveComponent>(), SceneActorActivationInfo.Tag);
			}
			break;
		case EGSSceneActorActivationType.TickEnable:
		{
			if (SceneActorActivationInfo.Tag == FName.None)
			{
				ActivateComps = Actor.GetComponentsByClass(UClass.GetClass<UActorComponent>());
				for (int num = ActivateComps.Count - 1; num >= 0; num--)
				{
					if (ActivateComps[num].IsA<UNiagaraComponent>())
					{
						ActivateComps.RemoveAt(num);
					}
				}
				break;
			}
			ActivateComps = Actor.GetComponentsByTag(UClass.GetClass<UActorComponent>(), SceneActorActivationInfo.Tag);
			for (int num2 = ActivateComps.Count - 1; num2 >= 0; num2--)
			{
				if (ActivateComps[num2].IsA<UNiagaraComponent>())
				{
					ActivateComps.RemoveAt(num2);
				}
			}
			break;
		}
		}
		if (CheckComps != null)
		{
			foreach (UPrimitiveComponent CheckComp in CheckComps)
			{
				ActivateComps.Remove(CheckComp);
			}
		}
		ActivateComps.RemoveAll((UActorComponent r) => r is BUS_SceneInactiveActorComp);
		bIsEnabled = true;
	}

	public void ActivateComponents(AActor Actor, bool ForceUpdate = false)
	{
		if (Actor == null || (bIsEnabled && !ForceUpdate && Actor.IsActorTickEnabled()))
		{
			return;
		}
		bIsEnabled = true;
		switch (SceneActorActivationType)
		{
		case EGSSceneActorActivationType.EmitterActivation:
		{
			foreach (UActorComponent activateComp in ActivateComps)
			{
				UNiagaraComponent uNiagaraComponent = activateComp as UNiagaraComponent;
				if (!uNiagaraComponent.IsNullOrDestroyed())
				{
					activateComp?.Activate(bReset: true);
					uNiagaraComponent?.SetPaused(bInPaused: false);
				}
			}
			break;
		}
		case EGSSceneActorActivationType.TickEnable:
			foreach (UActorComponent activateComp2 in ActivateComps)
			{
				UNiagaraComponent uNiagaraComponent2 = activateComp2 as UNiagaraComponent;
				if (!uNiagaraComponent2.IsNullOrDestroyed())
				{
					activateComp2?.Activate(bReset: true);
					uNiagaraComponent2?.SetPaused(bInPaused: false);
				}
			}
			Actor.SetActorTickEnabled(bEnabled: true);
			{
				foreach (UActorComponent activateComp3 in ActivateComps)
				{
					if (!activateComp3.IsNullOrDestroyed())
					{
						activateComp3?.SetComponentTickEnabled(bEnabled: true);
					}
				}
				break;
			}
		case EGSSceneActorActivationType.BGUActorActivation:
			BUS_EventCollectionCS.Get(Actor)?.Evt_SetBGUActorActive.Invoke(P1: true);
			break;
		case EGSSceneActorActivationType.HiddenInGame:
			Actor.SetActorHiddenInGame(bNewHidden: false);
			break;
		case EGSSceneActorActivationType.ActorCollision:
			Actor.SetActorEnableCollision(bNewActorEnableCollision: true);
			break;
		}
	}

	public void DeactivateComponents(AActor Actor, bool ForceUpdate = false)
	{
		if (!bIsEnabled && !ForceUpdate && !Actor.IsActorTickEnabled())
		{
			return;
		}
		bIsEnabled = false;
		switch (SceneActorActivationType)
		{
		case EGSSceneActorActivationType.EmitterActivation:
		{
			foreach (UActorComponent activateComp in ActivateComps)
			{
				UNiagaraComponent uNiagaraComponent = activateComp as UNiagaraComponent;
				if (uNiagaraComponent != null)
				{
					uNiagaraComponent.Deactivate();
				}
				uNiagaraComponent?.SetPaused(bInPaused: true);
			}
			break;
		}
		case EGSSceneActorActivationType.TickEnable:
			foreach (UActorComponent activateComp2 in ActivateComps)
			{
				UNiagaraComponent uNiagaraComponent2 = activateComp2 as UNiagaraComponent;
				if (uNiagaraComponent2 != null)
				{
					uNiagaraComponent2.Deactivate();
				}
				uNiagaraComponent2?.SetPaused(bInPaused: true);
			}
			if (Actor != null)
			{
				Actor.SetActorTickEnabled(bEnabled: false);
			}
			{
				foreach (UActorComponent activateComp3 in ActivateComps)
				{
					if (activateComp3 != null)
					{
						activateComp3.SetComponentTickEnabled(bEnabled: false);
						USkeletalMeshComponent uSkeletalMeshComponent = activateComp3 as USkeletalMeshComponent;
						if (uSkeletalMeshComponent != null)
						{
							UGSE_SkeletalMeshFuncLib.GS_SetEndPhysicsTickEnabled(uSkeletalMeshComponent, bVal: false);
						}
					}
				}
				break;
			}
		case EGSSceneActorActivationType.BGUActorActivation:
			BUS_EventCollectionCS.Get(Actor)?.Evt_SetBGUActorActive.Invoke(P1: false);
			break;
		case EGSSceneActorActivationType.HiddenInGame:
			Actor.SetActorHiddenInGame(bNewHidden: true);
			break;
		case EGSSceneActorActivationType.ActorCollision:
			Actor.SetActorEnableCollision(bNewActorEnableCollision: false);
			break;
		}
	}
}
