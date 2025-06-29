using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAViewportRotate : BUInputActionTemplate
{
	public BUIAViewportRotate()
	{
		InputActionType = EInputActionType.ViewportRotate;
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
		float value = Value.GetAxis1D();
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleMouseInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			value = 0f;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		if (enhancedInputActionDesc.InputActionParamsInt.Count != 2)
		{
			return false;
		}
		if (!DebugConfig.TopdownBattleMode)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
			if (enhancedInputActionDesc.InputActionParamsInt[0] == 0)
			{
				bUS_GSEventCollection.Evt_InputCameraLookUp.Invoke(value);
			}
			else if (enhancedInputActionDesc.InputActionParamsInt[0] == 1)
			{
				bUS_GSEventCollection.Evt_InputCameraTurnRight.Invoke(value);
			}
		}
		return true;
	}
}
