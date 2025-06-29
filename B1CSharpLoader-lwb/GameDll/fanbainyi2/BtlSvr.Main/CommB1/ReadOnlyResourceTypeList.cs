using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyResourceTypeList : ReadOnlyPrimitiveList<ResourceType>
{
	public ReadOnlyResourceTypeList(RepeatedField<ResourceType> pbData)
		: base(pbData)
	{
	}
}
