using b1.BGU.BUAnim;
using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAJump : BUInputActionTemplate
{
	public BUIAJump()
	{
		InputActionType = EInputActionType.Jump;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
		{
			return false;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (aCharacter != null && aCharacter.Mesh != null && aCharacter.Mesh.GetAnimInstance() is BUAnimQuadruped)
		{
			if (TriggerEvent == ETriggerEvent.Started)
			{
				BUS_EventCollectionCS.Get(owner).Evt_TriggerRootMotionJump.Invoke();
			}
			return false;
		}
		switch (TriggerEvent)
		{
		case ETriggerEvent.Started:
		{
			IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(owner);
			if (readOnlyData == null || readOnlyData.HasState(EBGUUnitState.JumpMoving) || (readOnlyData.HasState(EBGUUnitState.Attacking) && !readOnlyData.HasState(EBGUUnitState.JumpWindow)))
			{
				return false;
			}
			IBPC_InputData playerControlReadonlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_InputData, BPC_InputData>(owner.GetInstigatorController() as APlayerController);
			if (playerControlReadonlyData == null)
			{
				return false;
			}
			IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(owner);
			if (unPersistentReadOnlyData == null)
			{
				return false;
			}
			IBUC_PlayerInputActionData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputActionData, BUC_PlayerInputActionData>(owner);
			if (unPersistentReadOnlyData2 == null)
			{
				return false;
			}
			ESkillDirection startJumpDir = ESkillDirection.None;
			float inputValue = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveSideways);
			float inputValue2 = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveForward);
			FVector2D currentInput = new FVector2D(inputValue, inputValue2);
			if (FMath.Sqrt(inputValue * inputValue + inputValue2 * inputValue2) > 0.1f)
			{
				startJumpDir = ((!readOnlyData.HasState(EBGUUnitState.SideWalking)) ? ESkillDirection.Forward : BGUFuncLibInput.CalcInputDir(inputValue, inputValue2, unPersistentReadOnlyData.DodgeInputFixLine));
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			bUS_GSEventCollection.Evt_TriggerJumpSkill.Invoke(startJumpDir, currentInput);
			bUS_GSEventCollection.Evt_TriggerSimpleJump.Invoke(P1: true);
			if (readOnlyData.HasState(EBGUUnitState.Sprinting) && !unPersistentReadOnlyData2.bPressedSprinting)
			{
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintRelease, -1f);
			}
			return true;
		}
		case ETriggerEvent.Completed:
			BUS_EventCollectionCS.Get(owner).Evt_Jump_OnReleased.Invoke();
			return true;
		default:
			return false;
		}
	}
}
