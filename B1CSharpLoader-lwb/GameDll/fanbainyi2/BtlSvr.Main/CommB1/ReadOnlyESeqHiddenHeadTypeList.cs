using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESeqHiddenHeadTypeList : ReadOnlyPrimitiveList<ESeqHiddenHeadType>
{
	public ReadOnlyESeqHiddenHeadTypeList(RepeatedField<ESeqHiddenHeadType> pbData)
		: base(pbData)
	{
	}
}
