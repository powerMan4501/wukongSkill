using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyTaskStateList : ReadOnlyPrimitiveList<PartyTaskState>
{
	public ReadOnlyPartyTaskStateList(RepeatedField<PartyTaskState> pbData)
		: base(pbData)
	{
	}
}
