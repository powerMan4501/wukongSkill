using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIACameraLock : BUInputActionTemplate
{
	public BUIACameraLock()
	{
		InputActionType = EInputActionType.CameraLock;
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
		BGUFuncLibInput.BGUInputCameraLockTarget(GetOwner());
		return true;
	}
}
