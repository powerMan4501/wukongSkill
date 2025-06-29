using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMobAttackTypeList : ReadOnlyPrimitiveList<EMobAttackType>
{
	public ReadOnlyEMobAttackTypeList(RepeatedField<EMobAttackType> pbData)
		: base(pbData)
	{
	}
}
