using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPerformLockTypeList : ReadOnlyPrimitiveList<EPerformLockType>
{
	public ReadOnlyEPerformLockTypeList(RepeatedField<EPerformLockType> pbData)
		: base(pbData)
	{
	}
}
