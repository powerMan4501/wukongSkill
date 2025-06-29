using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMapSymbolTypeList : ReadOnlyPrimitiveList<EMapSymbolType>
{
	public ReadOnlyEMapSymbolTypeList(RepeatedField<EMapSymbolType> pbData)
		: base(pbData)
	{
	}
}
