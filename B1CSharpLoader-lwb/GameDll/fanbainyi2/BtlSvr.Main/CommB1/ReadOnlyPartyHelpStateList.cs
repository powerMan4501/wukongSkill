using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyHelpStateList : ReadOnlyPrimitiveList<PartyHelpState>
{
	public ReadOnlyPartyHelpStateList(RepeatedField<PartyHelpState> pbData)
		: base(pbData)
	{
	}
}
