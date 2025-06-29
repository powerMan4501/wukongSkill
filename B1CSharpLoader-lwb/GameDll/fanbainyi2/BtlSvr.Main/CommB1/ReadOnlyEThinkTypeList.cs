using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEThinkTypeList : ReadOnlyPrimitiveList<EThinkType>
{
	public ReadOnlyEThinkTypeList(RepeatedField<EThinkType> pbData)
		: base(pbData)
	{
	}
}
