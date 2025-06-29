using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAUnfreeze : BUInputActionTemplate
{
	public BUIAUnfreeze()
	{
		InputActionType = EInputActionType.Unfreeze;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		int p = enhancedInputActionDesc.InputActionParamsInt[0];
		BUS_EventCollectionCS.Get(owner)?.Evt_OnUnFreezeCountAcc.Invoke(p);
		return true;
	}
}
