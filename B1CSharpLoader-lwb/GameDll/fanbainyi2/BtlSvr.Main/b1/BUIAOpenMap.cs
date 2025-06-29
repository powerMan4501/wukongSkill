using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAOpenMap : BUInputActionTemplate
{
	public BUIAOpenMap()
	{
		InputActionType = EInputActionType.OpenMap;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		if (enhancedInputActionDesc.InputActionParamsInt.Count < 1)
		{
			return false;
		}
		BGW_EventCollection.Get(bGUCharacterCS)?.Evt_OpenBattleMap();
		return true;
	}
}
