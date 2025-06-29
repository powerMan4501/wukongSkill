using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkipTypeList : ReadOnlyPrimitiveList<ESkipType>
{
	public ReadOnlyESkipTypeList(RepeatedField<ESkipType> pbData)
		: base(pbData)
	{
	}
}
