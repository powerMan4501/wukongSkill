using ArchiveB1;
using b1.Prediction;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIASwitchWeaponPoseBase : BUInputActionTemplate
{
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
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(owner);
		if (firstLocalPlayerController == null)
		{
			return false;
		}
		int stanceType = GetStanceType();
		if (CanSwitchWeaponPose(firstLocalPlayerController, (Stance)stanceType))
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_SwitchWeaponPoseByType.Invoke(stanceType);
			return true;
		}
		return false;
	}

	protected virtual int GetStanceType()
	{
		return 0;
	}

	protected bool CanSwitchWeaponPose(APlayerController Controller, Stance Stance)
	{
		if (Controller != null)
		{
			IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(Controller.PlayerState);
			if (readOnlyData == null || readOnlyData.HasTag(EBGPPlayerTag.Transforming))
			{
				return false;
			}
			IBPC_PlayerRoleData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(Controller);
			if (readOnlyData2 == null)
			{
				return false;
			}
			switch (Stance)
			{
			case Stance.Heavy:
				return true;
			case Stance.Prop:
			{
				int commLogicCfgValue2 = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PropStance);
				return RoleDataHelper.IsTalentExist(readOnlyData2.RoleData.RoleCs, commLogicCfgValue2);
			}
			case Stance.Poke:
			{
				int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PokeStance);
				return RoleDataHelper.IsTalentExist(readOnlyData2.RoleData.RoleCs, commLogicCfgValue);
			}
			}
		}
		return false;
	}
}
