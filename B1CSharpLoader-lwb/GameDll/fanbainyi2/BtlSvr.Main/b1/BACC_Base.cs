using UnrealEngine.Engine;

namespace b1;

public class BACC_Base
{
	public virtual bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		return false;
	}
}
