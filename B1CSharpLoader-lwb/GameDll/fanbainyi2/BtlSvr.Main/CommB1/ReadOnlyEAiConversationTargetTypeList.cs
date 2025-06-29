using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAiConversationTargetTypeList : ReadOnlyPrimitiveList<EAiConversationTargetType>
{
	public ReadOnlyEAiConversationTargetTypeList(RepeatedField<EAiConversationTargetType> pbData)
		: base(pbData)
	{
	}
}
