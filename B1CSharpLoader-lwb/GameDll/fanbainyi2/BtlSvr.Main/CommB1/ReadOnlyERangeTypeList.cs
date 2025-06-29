using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyERangeTypeList : ReadOnlyPrimitiveList<ERangeType>
{
	public ReadOnlyERangeTypeList(RepeatedField<ERangeType> pbData)
		: base(pbData)
	{
	}
}
