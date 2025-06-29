using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyMemberTypeList : ReadOnlyPrimitiveList<PartyMemberType>
{
	public ReadOnlyPartyMemberTypeList(RepeatedField<PartyMemberType> pbData)
		: base(pbData)
	{
	}
}
