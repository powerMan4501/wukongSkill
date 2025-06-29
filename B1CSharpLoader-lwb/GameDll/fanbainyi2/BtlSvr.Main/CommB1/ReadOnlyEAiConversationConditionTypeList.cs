using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAiConversationConditionTypeList : ReadOnlyPrimitiveList<EAiConversationConditionType>
{
	public ReadOnlyEAiConversationConditionTypeList(RepeatedField<EAiConversationConditionType> pbData)
		: base(pbData)
	{
	}
}
