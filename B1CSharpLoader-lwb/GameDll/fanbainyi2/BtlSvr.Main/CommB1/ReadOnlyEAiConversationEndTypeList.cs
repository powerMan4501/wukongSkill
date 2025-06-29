using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAiConversationEndTypeList : ReadOnlyPrimitiveList<EAiConversationEndType>
{
	public ReadOnlyEAiConversationEndTypeList(RepeatedField<EAiConversationEndType> pbData)
		: base(pbData)
	{
	}
}
