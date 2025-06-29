using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyResUnlockTypeList : ReadOnlyPrimitiveList<ResUnlockType>
{
	public ReadOnlyResUnlockTypeList(RepeatedField<ResUnlockType> pbData)
		: base(pbData)
	{
	}
}
