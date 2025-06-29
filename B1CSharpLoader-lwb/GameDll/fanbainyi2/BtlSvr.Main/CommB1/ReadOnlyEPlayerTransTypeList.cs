using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPlayerTransTypeList : ReadOnlyPrimitiveList<EPlayerTransType>
{
	public ReadOnlyEPlayerTransTypeList(RepeatedField<EPlayerTransType> pbData)
		: base(pbData)
	{
	}
}
