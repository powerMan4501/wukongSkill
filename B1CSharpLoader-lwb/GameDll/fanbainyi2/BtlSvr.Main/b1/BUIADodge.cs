using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIADodge : BUInputActionTemplate
{
	public BUIADodge()
	{
		InputActionType = EInputActionType.Dodge;
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
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			return false;
		}
		if (!CanDodge(owner))
		{
			return false;
		}
		if (BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_InputData, BPC_InputData>(owner.GetInstigatorController() as APlayerController) == null)
		{
			return false;
		}
		if (BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(owner) == null)
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		bUS_GSEventCollection.Evt_InputCastSkill.Invoke(EInputActionType.Dodge, IsRelease: false);
		bUS_GSEventCollection.Evt_TriggerSimpleJump.Invoke(P1: true);
		return true;
	}

	private bool CanDodge(AActor Owner)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		UBGUCharacterMovementComponent uBGUCharacterMovementComponent = bGUCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (uBGUCharacterMovementComponent == null)
		{
			return false;
		}
		IBUC_JumpData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>(Owner);
		if (readOnlyData != null && readOnlyData.IsInJump() && uBGUCharacterMovementComponent.Velocity.Z > 0f)
		{
			return false;
		}
		if (uBGUCharacterMovementComponent.IsFalling())
		{
			IBUC_FallingData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_FallingData, BUC_FallingData>(Owner);
			if (!readOnlyData2.EnableDodge_InFalling)
			{
				return false;
			}
			if (readOnlyData2.CanDodge_Distance > 0f)
			{
				if (readOnlyData2.FloorDistance < 0f)
				{
					return false;
				}
				return readOnlyData2.FloorDistance <= readOnlyData2.CanDodge_Distance;
			}
		}
		IBUC_ABPJumpV2Data unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>(Owner);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.bIsInLandCantDodgeTime)
		{
			return false;
		}
		return true;
	}
}
