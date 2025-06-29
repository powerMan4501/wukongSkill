using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyAdvertiseTypeList : ReadOnlyPrimitiveList<PartyAdvertiseType>
{
	public ReadOnlyPartyAdvertiseTypeList(RepeatedField<PartyAdvertiseType> pbData)
		: base(pbData)
	{
	}
}
