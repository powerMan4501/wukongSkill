using BtlB1;
using UnrealEngine.Engine;

namespace b1;

public struct FAiConversationConditionInstData
{
	public EAiConversationTargetType ConditionTargetType;

	public string TargetTypeParam;

	public AActor Target;

	public EAiConversationConditionType ConditionType;

	public string ConditionValue;

	public FAiConversationConditionInstData(EAiConversationTargetType _ConditionTargetType, string _TargetTypeParam, AActor _Target, EAiConversationConditionType _ConditionType, string _ConditionValue)
	{
		ConditionTargetType = _ConditionTargetType;
		TargetTypeParam = _TargetTypeParam;
		Target = _Target;
		ConditionType = _ConditionType;
		ConditionValue = _ConditionValue;
	}
}
