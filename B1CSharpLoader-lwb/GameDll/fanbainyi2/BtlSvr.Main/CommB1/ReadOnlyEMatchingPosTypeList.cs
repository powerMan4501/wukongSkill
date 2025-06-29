using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMatchingPosTypeList : ReadOnlyPrimitiveList<EMatchingPosType>
{
	public ReadOnlyEMatchingPosTypeList(RepeatedField<EMatchingPosType> pbData)
		: base(pbData)
	{
	}
}
