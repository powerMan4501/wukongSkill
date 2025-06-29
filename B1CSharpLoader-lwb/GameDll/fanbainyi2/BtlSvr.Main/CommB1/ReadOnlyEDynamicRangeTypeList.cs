using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEDynamicRangeTypeList : ReadOnlyPrimitiveList<EDynamicRangeType>
{
	public ReadOnlyEDynamicRangeTypeList(RepeatedField<EDynamicRangeType> pbData)
		: base(pbData)
	{
	}
}
