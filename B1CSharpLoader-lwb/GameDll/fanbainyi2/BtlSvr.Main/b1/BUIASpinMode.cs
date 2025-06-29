using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIASpinMode : BUInputActionTemplate
{
	public BUIASpinMode()
	{
		InputActionType = EInputActionType.SpinMode;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		switch (TriggerEvent)
		{
		case ETriggerEvent.Started:
			if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner))
			{
				return false;
			}
			BUS_EventCollectionCS.Get(GetOwner()).Evt_InputCastSkill.Invoke(EInputActionType.SpinMode, IsRelease: false);
			break;
		case ETriggerEvent.Completed:
			BUS_EventCollectionCS.Get(GetOwner()).Evt_InputCastSkill.Invoke(EInputActionType.SpinMode, IsRelease: true);
			break;
		}
		return true;
	}
}
