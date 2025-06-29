using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySpellNameEnumList : ReadOnlyPrimitiveList<SpellNameEnum>
{
	public ReadOnlySpellNameEnumList(RepeatedField<SpellNameEnum> pbData)
		: base(pbData)
	{
	}
}
