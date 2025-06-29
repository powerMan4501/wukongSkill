using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySpellTypeList : ReadOnlyPrimitiveList<SpellType>
{
	public ReadOnlySpellTypeList(RepeatedField<SpellType> pbData)
		: base(pbData)
	{
	}
}
