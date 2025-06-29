using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAInteract : BUInputActionTemplate
{
	public BUIAInteract()
	{
		InputActionType = EInputActionType.Interact;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (bUS_GSEventCollection == null)
		{
			return false;
		}
		if (TriggerEvent == ETriggerEvent.Started)
		{
			bUS_GSEventCollection.Evt_InputInteract.Invoke();
		}
		if (TriggerEvent == ETriggerEvent.Completed)
		{
			bUS_GSEventCollection.Evt_ReleaseInteractInput.Invoke();
		}
		return true;
	}
}
