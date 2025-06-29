using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMapSymbolActiveStateList : ReadOnlyPrimitiveList<EMapSymbolActiveState>
{
	public ReadOnlyEMapSymbolActiveStateList(RepeatedField<EMapSymbolActiveState> pbData)
		: base(pbData)
	{
	}
}
