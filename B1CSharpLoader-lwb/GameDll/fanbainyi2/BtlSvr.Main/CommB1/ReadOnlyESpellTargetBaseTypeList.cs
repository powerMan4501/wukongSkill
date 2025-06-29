using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESpellTargetBaseTypeList : ReadOnlyPrimitiveList<ESpellTargetBaseType>
{
	public ReadOnlyESpellTargetBaseTypeList(RepeatedField<ESpellTargetBaseType> pbData)
		: base(pbData)
	{
	}
}
