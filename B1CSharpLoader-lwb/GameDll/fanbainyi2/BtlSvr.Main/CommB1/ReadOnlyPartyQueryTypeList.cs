using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyQueryTypeList : ReadOnlyPrimitiveList<PartyQueryType>
{
	public ReadOnlyPartyQueryTypeList(RepeatedField<PartyQueryType> pbData)
		: base(pbData)
	{
	}
}
