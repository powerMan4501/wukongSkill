using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitDestructibleStrengthTypeList : ReadOnlyPrimitiveList<EHitDestructibleStrengthType>
{
	public ReadOnlyEHitDestructibleStrengthTypeList(RepeatedField<EHitDestructibleStrengthType> pbData)
		: base(pbData)
	{
	}
}
