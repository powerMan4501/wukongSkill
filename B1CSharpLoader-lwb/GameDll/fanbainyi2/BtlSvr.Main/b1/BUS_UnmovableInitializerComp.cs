using b1.EventDelDefine;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;

namespace b1;

public class BUS_UnmovableInitializerComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_CheckUnmovable += new Del_Void(OnCheckUnmovable);
	}

	public override void OnBeginPlay()
	{
		SetUnmovable();
	}

	private void OnCheckUnmovable()
	{
		SetUnmovable();
	}

	private void SetUnmovable()
	{
		if (Owner == null)
		{
			return;
		}
		UGSE_EngineFuncLib.SetActorComponentMobilityMovable(Owner, IsMovable: false);
		base.BUSEventCollection?.Evt_SetUnmovable.Invoke(P1: true);
		AController instigatorController = GetOwner().GetInstigatorController();
		if (!(instigatorController != null))
		{
			return;
		}
		AIController aIController = instigatorController as AIController;
		if (!(aIController != null))
		{
			return;
		}
		UPathFollowingComponent pathFollowingComponent = aIController.GetPathFollowingComponent();
		if (pathFollowingComponent != null)
		{
			UBGUCrowdFollowingComponent uBGUCrowdFollowingComponent = pathFollowingComponent as UBGUCrowdFollowingComponent;
			if (uBGUCrowdFollowingComponent != null)
			{
				uBGUCrowdFollowingComponent.SetCrowdFollowingEnabled(bEnabled: false, bIsObstacle: false);
			}
		}
	}
}
