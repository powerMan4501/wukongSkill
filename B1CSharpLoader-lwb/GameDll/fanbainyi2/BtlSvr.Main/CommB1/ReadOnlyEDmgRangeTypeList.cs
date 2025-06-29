using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEDmgRangeTypeList : ReadOnlyPrimitiveList<EDmgRangeType>
{
	public ReadOnlyEDmgRangeTypeList(RepeatedField<EDmgRangeType> pbData)
		: base(pbData)
	{
	}
}
