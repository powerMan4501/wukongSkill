using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySpellEffectTypeList : ReadOnlyPrimitiveList<SpellEffectType>
{
	public ReadOnlySpellEffectTypeList(RepeatedField<SpellEffectType> pbData)
		: base(pbData)
	{
	}
}
