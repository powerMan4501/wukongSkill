using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAAxisCameraLockSwitchTarget : BUInputActionTemplate
{
	public BUIAAxisCameraLockSwitchTarget()
	{
		InputActionType = EInputActionType.AxisCameraLockSwitchTarget;
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
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
		{
			return false;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		if (enhancedInputActionDesc.InputActionParamsInt.Count < 4)
		{
			return false;
		}
		float angleMax = enhancedInputActionDesc.InputActionParamsInt[0];
		float actionGap = (float)enhancedInputActionDesc.InputActionParamsInt[1] * BUInputActionTemplate.INV1000;
		float recordTime = (float)enhancedInputActionDesc.InputActionParamsInt[2] * BUInputActionTemplate.INV1000;
		float dist = enhancedInputActionDesc.InputActionParamsInt[3];
		BUS_EventCollectionCS.Get(owner).Evt_TrySwitchCameraLockTarget.Invoke(InputActionID, Value.GetAxis2D(), angleMax, actionGap, recordTime, dist);
		return true;
	}
}
