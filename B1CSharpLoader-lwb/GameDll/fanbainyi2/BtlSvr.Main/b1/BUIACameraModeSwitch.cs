using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIACameraModeSwitch : BUInputActionTemplate
{
	public BUIACameraModeSwitch()
	{
		InputActionType = EInputActionType.CameraModeSwitch;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			return false;
		}
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(GetOwner()) == null)
		{
			return false;
		}
		BUS_EventCollectionCS.Get(GetOwner()).Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.None);
		return true;
	}
}
