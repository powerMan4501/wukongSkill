using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyCardUnlockTypeList : ReadOnlyPrimitiveList<CardUnlockType>
{
	public ReadOnlyCardUnlockTypeList(RepeatedField<CardUnlockType> pbData)
		: base(pbData)
	{
	}
}
