using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitAIAttackTypeList : ReadOnlyPrimitiveList<EUnitAIAttackType>
{
	public ReadOnlyEUnitAIAttackTypeList(RepeatedField<EUnitAIAttackType> pbData)
		: base(pbData)
	{
	}
}
