using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitSquadMemberTypeList : ReadOnlyPrimitiveList<EUnitSquadMemberType>
{
	public ReadOnlyEUnitSquadMemberTypeList(RepeatedField<EUnitSquadMemberType> pbData)
		: base(pbData)
	{
	}
}
