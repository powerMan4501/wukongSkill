using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAiConversationEventTypeList : ReadOnlyPrimitiveList<EAiConversationEventType>
{
	public ReadOnlyEAiConversationEventTypeList(RepeatedField<EAiConversationEventType> pbData)
		: base(pbData)
	{
	}
}
