using UnrealEngine.Engine;

namespace b1;

public class BUS_NameTriggerComp : BUS_TriggerBaseComp
{
	private b1.BUC_NameTriggerConfigData NameTriggerConfigData;

	public override void OnAttach()
	{
		base.OnAttach();
		NameTriggerConfigData = RequireWritableData<b1.BUC_NameTriggerConfigData>();
	}

	public override void OnEnter_TriggeredEvent()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
		if (!(firstLocalPlayerController == null))
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (!(controlledPawn == null))
			{
				_ = BUS_EventCollectionCS.Get(controlledPawn) == null;
			}
		}
	}

	public override void OnEnter_UnTriggeredEvent()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(GetOwner());
		if (!(firstLocalPlayerController == null))
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (!(controlledPawn == null))
			{
				_ = BUS_EventCollectionCS.Get(controlledPawn) == null;
			}
		}
	}

	public override bool CanReTrigger()
	{
		return true;
	}
}
