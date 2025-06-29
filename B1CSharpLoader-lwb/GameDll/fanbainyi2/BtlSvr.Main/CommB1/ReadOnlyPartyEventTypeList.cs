using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyEventTypeList : ReadOnlyPrimitiveList<PartyEventType>
{
	public ReadOnlyPartyEventTypeList(RepeatedField<PartyEventType> pbData)
		: base(pbData)
	{
	}
}
