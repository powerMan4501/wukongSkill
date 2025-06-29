using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAMoveFinish : BUInputActionTemplate
{
	public BUIAMoveFinish()
	{
		InputActionType = EInputActionType.MoveFinish;
	}

	protected override bool OnTriggerInputActionPredict(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		return OnTriggerInputAction(InputActionID, TriggerEvent, ref Value, null);
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		if (PredictionKey != null)
		{
			return false;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		if (enhancedInputActionDesc.InputActionParamsInt.Count != 1)
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (enhancedInputActionDesc.InputActionParamsInt[0] == 0)
		{
			bUS_GSEventCollection.Evt_InputMoveForwardFinish.Invoke();
		}
		else if (enhancedInputActionDesc.InputActionParamsInt[0] == 1)
		{
			bUS_GSEventCollection.Evt_InputMoveRightFinish.Invoke();
		}
		return true;
	}
}
