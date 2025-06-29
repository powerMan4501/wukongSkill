using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyPS5ActivityObjectTypeList : ReadOnlyPrimitiveList<PS5ActivityObjectType>
{
	public ReadOnlyPS5ActivityObjectTypeList(RepeatedField<PS5ActivityObjectType> pbData)
		: base(pbData)
	{
	}
}
