using b1.Prediction;
using BtlShare;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAToggleCloudMove : BUInputActionTemplate
{
	public BUIAToggleCloudMove()
	{
		InputActionType = EInputActionType.ToggleCloudMove;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		if (B1Global.GIsBossRushMode)
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		if (bGUCharacterCS.GetResID() != 10)
		{
			return false;
		}
		BUC_CloudMoveData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_CloudMoveData>(bGUCharacterCS);
		if (unPersistentReadOnlyData == null)
		{
			return false;
		}
		if (unPersistentReadOnlyData.CloudMoveItemId > 0)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(bGUCharacterCS.GetController());
			if (readOnlyData == null || readOnlyData.RoleData == null)
			{
				return false;
			}
			if (!RoleDataHelper.HasItem(readOnlyData, unPersistentReadOnlyData.CloudMoveItemId))
			{
				return false;
			}
		}
		bool flag = BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(bGUCharacterCS, InputActionType);
		if (!unPersistentReadOnlyData.IsCloudMoveEnabled && (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(bGUCharacterCS) || !flag))
		{
			if (!flag)
			{
				BGW_UIEventCollection.Get(bGUCharacterCS)?.Evt_UI_CloudMoveInBattle();
			}
			return false;
		}
		BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ToggleCloudMove.Invoke();
		return true;
	}
}
