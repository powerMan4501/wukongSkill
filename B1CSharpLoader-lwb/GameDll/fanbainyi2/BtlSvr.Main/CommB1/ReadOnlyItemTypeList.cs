using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyItemTypeList : ReadOnlyPrimitiveList<ItemType>
{
	public ReadOnlyItemTypeList(RepeatedField<ItemType> pbData)
		: base(pbData)
	{
	}
}
