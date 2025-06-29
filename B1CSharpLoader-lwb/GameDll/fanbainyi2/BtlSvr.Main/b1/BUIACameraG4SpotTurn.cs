using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIACameraG4SpotTurn : BUInputActionTemplate
{
	public BUIACameraG4SpotTurn()
	{
		InputActionType = EInputActionType.CameraG4SpotTurn;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return false;
		}
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
		{
			return false;
		}
		BUC_PlayerCameraData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PlayerCameraData>(owner);
		IBUC_PlayerInputConfigData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(owner);
		if (unPersistentReadOnlyData == null || unPersistentReadOnlyData2 == null)
		{
			return false;
		}
		if (!unPersistentReadOnlyData.IsInG4Mode())
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (BGUFunctionLibraryCS.BGUGetTarget(owner) != null)
		{
			bUS_GSEventCollection.Evt_ClearCameraLock.Invoke();
		}
		FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
		fRotator.Yaw -= 0.01f;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) - fRotator.Vector() * 1000.0;
		if (bUS_GSEventCollection.Evt_G4CameraTurnToLocation.Invoke(fVector))
		{
			bUS_GSEventCollection.Evt_ActorRotateToPos.Invoke(fVector, unPersistentReadOnlyData2.GSCameraAutoLockSetting.G4SpotTurnSpeed, bForceUpdate: false);
		}
		return true;
	}
}
