using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESpellTriggerEffectTypeList : ReadOnlyPrimitiveList<ESpellTriggerEffectType>
{
	public ReadOnlyESpellTriggerEffectTypeList(RepeatedField<ESpellTriggerEffectType> pbData)
		: base(pbData)
	{
	}
}
