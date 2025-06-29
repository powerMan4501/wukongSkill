using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEDefeatUIShowTypeList : ReadOnlyPrimitiveList<EDefeatUIShowType>
{
	public ReadOnlyEDefeatUIShowTypeList(RepeatedField<EDefeatUIShowType> pbData)
		: base(pbData)
	{
	}
}
