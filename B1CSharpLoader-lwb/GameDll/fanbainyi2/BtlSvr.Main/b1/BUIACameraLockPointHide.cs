using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIACameraLockPointHide : BUInputActionTemplate
{
	public BUIACameraLockPointHide()
	{
		InputActionType = EInputActionType.CameraLockPointHide;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(GetOwner());
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_Camera_SwitchHideUILockPoint.Invoke();
		}
		return true;
	}
}
