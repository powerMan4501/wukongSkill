using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMapSymbolStateList : ReadOnlyPrimitiveList<EMapSymbolState>
{
	public ReadOnlyEMapSymbolStateList(RepeatedField<EMapSymbolState> pbData)
		: base(pbData)
	{
	}
}
