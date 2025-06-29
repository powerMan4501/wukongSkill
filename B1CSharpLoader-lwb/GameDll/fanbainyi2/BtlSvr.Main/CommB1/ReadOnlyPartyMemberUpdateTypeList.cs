using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyMemberUpdateTypeList : ReadOnlyPrimitiveList<PartyMemberUpdateType>
{
	public ReadOnlyPartyMemberUpdateTypeList(RepeatedField<PartyMemberUpdateType> pbData)
		: base(pbData)
	{
	}
}
