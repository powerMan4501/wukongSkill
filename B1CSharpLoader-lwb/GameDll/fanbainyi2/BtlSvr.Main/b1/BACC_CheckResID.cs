using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_CheckResID : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target.IsNullOrDestroyed())
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_IntValue(ConditionInstData.ConditionValue, out var IntValue))
		{
			return false;
		}
		if (BGU_DataUtil.GetActorResID(ConditionInstData.Target) == IntValue)
		{
			return true;
		}
		return false;
	}
}
