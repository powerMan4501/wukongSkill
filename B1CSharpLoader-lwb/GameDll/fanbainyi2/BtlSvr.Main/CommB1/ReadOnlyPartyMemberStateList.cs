using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyMemberStateList : ReadOnlyPrimitiveList<PartyMemberState>
{
	public ReadOnlyPartyMemberStateList(RepeatedField<PartyMemberState> pbData)
		: base(pbData)
	{
	}
}
