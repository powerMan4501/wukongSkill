using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

internal class BUIAUseVigorSkill : BUInputActionTemplate
{
	public BUIAUseVigorSkill()
	{
		InputActionType = EInputActionType.UseVigorSkill;
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
		APawn aPawn = owner as APawn;
		if (aPawn != null)
		{
			IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(aPawn.GetController());
			if (readOnlyData == null || readOnlyData.RoleData == null)
			{
				return false;
			}
			int? num = readOnlyData.RoleData?.RoleCs?.Actor?.Wear?.WearSoulSkill?.SoulSkillId;
			if (num.HasValue && num > 0)
			{
				BUS_EventCollectionCS.Get(owner)?.Evt_InputCastSkill.Invoke(EInputActionType.UseVigorSkill, IsRelease: false, num.Value);
			}
		}
		return true;
	}
}
