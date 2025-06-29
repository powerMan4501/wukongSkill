using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_DestructibleGateComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.OnAttach();
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UChildActorComponent>()))
		{
			UChildActorComponent uChildActorComponent = item as UChildActorComponent;
			if (uChildActorComponent != null)
			{
				BGUFXActorBase bGUFXActorBase = uChildActorComponent.ChildActor as BGUFXActorBase;
				if (bGUFXActorBase != null && bGUFXActorBase.ActorHasTag(B1GlobalFNames.Destructible))
				{
					BUS_EventCollectionCS.Get(bGUFXActorBase).Evt_DestroyDestructible += new Del_DestroyDestructible(OnDestroyDestructible);
				}
			}
		}
		base.BUSEventCollection.Evt_GateStateMachineOpen += new Del_Void(OnGateStateMachineOpen);
		base.BUSEventCollection.Evt_GateStateMachineClose += new Del_Void(OnGateStateMachineClose);
		base.BUSEventCollection.Evt_GateStateMachineResetToOpen += new Del_Void(OnGateStateMachineResetToOpen);
		base.BUSEventCollection.Evt_GateStateMachineResetToClose += new Del_Void(OnGateStateMachineResetToClose);
	}

	private void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength)
	{
		base.BUSEventCollection.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.DynamicObstacleTag.Event_EnabledToDisable);
	}

	private void OnGateStateMachineOpen()
	{
	}

	private void OnGateStateMachineClose()
	{
	}

	private void OnGateStateMachineResetToOpen()
	{
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(UClass.GetClass<UChildActorComponent>()))
		{
			UChildActorComponent uChildActorComponent = item as UChildActorComponent;
			if (uChildActorComponent != null && BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(uChildActorComponent.ChildActor) != null)
			{
				uChildActorComponent.ChildActor.DestroyActor();
			}
		}
	}

	private void OnGateStateMachineResetToClose()
	{
	}
}
