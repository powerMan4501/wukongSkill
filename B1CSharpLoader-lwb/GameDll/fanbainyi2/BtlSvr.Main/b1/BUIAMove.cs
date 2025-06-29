using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAMove : BUInputActionTemplate
{
	public BUIAMove()
	{
		InputActionType = EInputActionType.Move;
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
		float num = Value.GetAxis1D();
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			num = 0f;
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
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (enhancedInputActionDesc.InputActionParamsInt[0] == 0 && BGUFuncLibInput.BGUCanReceiveYAxisInput(GetOwner(), num))
		{
			bUS_GSEventCollection.Evt_InputMoveForward.Invoke(num);
		}
		else if (enhancedInputActionDesc.InputActionParamsInt[0] == 1 && BGUFuncLibInput.BGUCanReceiveXAxisInput(GetOwner(), num))
		{
			bUS_GSEventCollection.Evt_InputMoveRight.Invoke(num);
		}
		return true;
	}
}
