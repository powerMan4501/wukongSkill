using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEACInterruptTypeList : ReadOnlyPrimitiveList<EACInterruptType>
{
	public ReadOnlyEACInterruptTypeList(RepeatedField<EACInterruptType> pbData)
		: base(pbData)
	{
	}
}
