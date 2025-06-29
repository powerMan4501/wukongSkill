using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_BagItemExist : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_IntValue(ConditionInstData.ConditionValue, out var IntValue))
		{
			return false;
		}
		IBPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Speaker.GetInstigatorController()));
		if (readOnlyData == null)
		{
			return false;
		}
		ReadOnlyRoleData roleData = readOnlyData.RoleData;
		if (roleData == null || roleData.RoleCs == null)
		{
			return false;
		}
		return RoleDataHelper.HasItem(roleData.RoleCs, IntValue);
	}
}
