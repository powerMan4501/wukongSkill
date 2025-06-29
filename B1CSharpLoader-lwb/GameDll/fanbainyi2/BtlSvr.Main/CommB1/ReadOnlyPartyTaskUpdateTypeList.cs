using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyTaskUpdateTypeList : ReadOnlyPrimitiveList<PartyTaskUpdateType>
{
	public ReadOnlyPartyTaskUpdateTypeList(RepeatedField<PartyTaskUpdateType> pbData)
		: base(pbData)
	{
	}
}
