using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_IsInFsmState : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target != null)
		{
			return BGU_DataUtil.GetReadOnlyData<IBUC_FsmData, BUC_FsmData>(ConditionInstData.Target).IsInFsmState(GameplayTagExtension.MakeGameplayTag(ConditionInstData.ConditionValue));
		}
		return false;
	}
}
