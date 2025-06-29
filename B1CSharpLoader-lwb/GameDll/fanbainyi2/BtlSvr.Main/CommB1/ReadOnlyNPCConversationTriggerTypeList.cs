using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyNPCConversationTriggerTypeList : ReadOnlyPrimitiveList<NPCConversationTriggerType>
{
	public ReadOnlyNPCConversationTriggerTypeList(RepeatedField<NPCConversationTriggerType> pbData)
		: base(pbData)
	{
	}
}
