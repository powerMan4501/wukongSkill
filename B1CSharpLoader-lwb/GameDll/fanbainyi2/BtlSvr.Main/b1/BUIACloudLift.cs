using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIACloudLift : BUInputActionTemplate
{
	public BUIACloudLift()
	{
		InputActionType = EInputActionType.CloudLift;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		switch (TriggerEvent)
		{
		case ETriggerEvent.Started:
			if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
			{
				return false;
			}
			BUS_EventCollectionCS.Get(owner).Evt_InputCloudMoveLift.Invoke(P1: true);
			break;
		case ETriggerEvent.Completed:
			BUS_EventCollectionCS.Get(owner).Evt_InputCloudMoveLift.Invoke(P1: false);
			break;
		}
		return true;
	}
}
