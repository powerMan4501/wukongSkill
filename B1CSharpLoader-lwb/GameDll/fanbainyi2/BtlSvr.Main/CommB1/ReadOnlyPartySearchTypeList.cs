using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartySearchTypeList : ReadOnlyPrimitiveList<PartySearchType>
{
	public ReadOnlyPartySearchTypeList(RepeatedField<PartySearchType> pbData)
		: base(pbData)
	{
	}
}
