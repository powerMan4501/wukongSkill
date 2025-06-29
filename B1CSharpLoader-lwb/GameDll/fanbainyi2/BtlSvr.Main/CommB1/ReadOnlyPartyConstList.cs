using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyConstList : ReadOnlyPrimitiveList<PartyConst>
{
	public ReadOnlyPartyConstList(RepeatedField<PartyConst> pbData)
		: base(pbData)
	{
	}
}
