using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTimeTypeList : ReadOnlyPrimitiveList<TimeType>
{
	public ReadOnlyTimeTypeList(RepeatedField<TimeType> pbData)
		: base(pbData)
	{
	}
}
