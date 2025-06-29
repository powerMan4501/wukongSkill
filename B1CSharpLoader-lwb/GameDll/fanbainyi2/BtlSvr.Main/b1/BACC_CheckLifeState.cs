using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_CheckLifeState : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		string empty = string.Empty;
		empty = ((ConditionInstData.ConditionTargetType != EAiConversationTargetType.ByGuid) ? BGU_DataUtil.GetActorGuid(ConditionInstData.Target) : ConditionInstData.TargetTypeParam);
		if (!string.IsNullOrEmpty(empty))
		{
			bool flag = ConditionInstData.ConditionValue == "alive";
			IBIC_GlobalActorData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(Speaker);
			if (gameInstanceReadonlyData != null)
			{
				bool actorAliveState = gameInstanceReadonlyData.GetActorAliveState(ConditionInstData.TargetTypeParam);
				return flag == actorAliveState;
			}
		}
		return false;
	}
}
