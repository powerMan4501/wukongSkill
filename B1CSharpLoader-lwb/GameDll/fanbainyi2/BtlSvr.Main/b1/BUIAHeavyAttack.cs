using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAHeavyAttack : BUInputActionTemplate
{
	public BUIAHeavyAttack()
	{
		InputActionType = EInputActionType.HeavyAttack;
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
		switch (TriggerEvent)
		{
		case ETriggerEvent.Started:
			if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
			{
				return false;
			}
			BUS_EventCollectionCS.Get(owner).Evt_InputCastSkill.Invoke(EInputActionType.HeavyAttack, IsRelease: false);
			break;
		case ETriggerEvent.Completed:
			BUS_EventCollectionCS.Get(owner).Evt_InputCastSkill.Invoke(EInputActionType.HeavyAttack, IsRelease: true, 0, InputActionID);
			break;
		}
		return true;
	}
}
