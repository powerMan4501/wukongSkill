using b1.Prediction;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIASwitchMoveSpeedState : BUInputActionTemplate
{
	public BUIASwitchMoveSpeedState()
	{
		InputActionType = EInputActionType.SwitchMoveSpeedState;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(GetOwner()) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(GetOwner(), InputActionType))
		{
			return false;
		}
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
		if (enhancedInputActionDesc.InputActionParamsInt.Count < 2)
		{
			return false;
		}
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(owner);
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(owner);
		IBUC_AttrContainer readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(owner);
		if (readOnlyData == null || readOnlyData2 == null || readOnlyData3 == null)
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		EBUStateTrigger triggerID = EBUStateTrigger.None;
		if (enhancedInputActionDesc.InputActionParamsInt[1] == 2)
		{
			if (enhancedInputActionDesc.InputActionParamsInt[0] == 1)
			{
				switch (TriggerEvent)
				{
				case ETriggerEvent.Started:
					triggerID = EBUStateTrigger.UnitInputWalkPressed;
					break;
				case ETriggerEvent.Completed:
					triggerID = EBUStateTrigger.UnitInputWalkRelease;
					break;
				}
			}
			else if (enhancedInputActionDesc.InputActionParamsInt[0] == 2)
			{
				switch (TriggerEvent)
				{
				case ETriggerEvent.Started:
				{
					bUS_GSEventCollection.Evt_SetPressedSprinting.Invoke(P1: true);
					if (readOnlyData2.HasSimpleState(EBGUSimpleState.StaminaDepleted))
					{
						return false;
					}
					FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(BGU_DataUtil.GetActorResID(owner));
					if (playerCommDesc != null && playerCommDesc.StaminaCostMoveFast > 0f && readOnlyData3.GetFloatValue(EBGUAttrFloat.Stamina) <= 0f)
					{
						return false;
					}
					triggerID = EBUStateTrigger.UnitInputSprintPressed;
					break;
				}
				case ETriggerEvent.Completed:
					bUS_GSEventCollection.Evt_SetPressedSprinting.Invoke(P1: false);
					triggerID = EBUStateTrigger.UnitInputSprintRelease;
					break;
				}
			}
			bUS_GSEventCollection.Evt_UnitStateTriggerCMultiCast.Invoke(triggerID, -1f);
		}
		else
		{
			if (enhancedInputActionDesc.InputActionParamsInt[0] == 1)
			{
				triggerID = ((!readOnlyData.HasState(EBGUUnitState.Walking)) ? EBUStateTrigger.UnitInputWalkPressed : EBUStateTrigger.UnitInputWalkRelease);
			}
			else if (enhancedInputActionDesc.InputActionParamsInt[0] == 2)
			{
				if (readOnlyData.HasState(EBGUUnitState.Sprinting))
				{
					triggerID = EBUStateTrigger.UnitInputSprintRelease;
				}
				else if (!readOnlyData2.HasSimpleState(EBGUSimpleState.StaminaDepleted) && readOnlyData3.GetFloatValue(EBGUAttrFloat.Stamina) > 0f)
				{
					triggerID = EBUStateTrigger.UnitInputSprintPressed;
				}
			}
			BUS_EventCollectionCS.Get(GetOwner()).Evt_UnitStateTriggerCMultiCast.Invoke(triggerID, -1f);
		}
		return true;
	}
}
