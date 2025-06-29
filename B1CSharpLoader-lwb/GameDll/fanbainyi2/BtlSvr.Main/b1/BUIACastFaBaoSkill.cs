using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIACastFaBaoSkill : BUInputActionTemplate
{
	public BUIACastFaBaoSkill()
	{
		InputActionType = EInputActionType.CastFaBaoSkill;
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
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(owner);
		if (readOnlyData == null || readOnlyData.HasState(EBGUUnitState.JumpMoving))
		{
			return false;
		}
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(owner);
		if (readOnlyData2 == null || readOnlyData2.HasSimpleState(EBGUSimpleState.CantCastFaBao))
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_UnitCastFaBaoSkill.Invoke();
		}
		return true;
	}
}
