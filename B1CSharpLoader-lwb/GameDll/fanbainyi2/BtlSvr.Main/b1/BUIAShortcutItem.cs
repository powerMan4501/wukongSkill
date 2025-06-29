using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAShortcutItem : BUInputActionTemplate
{
	public BUIAShortcutItem()
	{
		InputActionType = EInputActionType.UseShortcutItem;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		BUS_EventCollectionCS.Get(owner)?.Evt_TriggerItemSkillAction_ShortCut.Invoke(InputActionID, TriggerEvent, InputActionType);
		return true;
	}
}
