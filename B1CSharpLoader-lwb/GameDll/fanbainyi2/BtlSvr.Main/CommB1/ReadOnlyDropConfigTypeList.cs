using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyDropConfigTypeList : ReadOnlyPrimitiveList<DropConfigType>
{
	public ReadOnlyDropConfigTypeList(RepeatedField<DropConfigType> pbData)
		: base(pbData)
	{
	}
}
