using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitWeightGearTypeList : ReadOnlyPrimitiveList<EHitWeightGearType>
{
	public ReadOnlyEHitWeightGearTypeList(RepeatedField<EHitWeightGearType> pbData)
		: base(pbData)
	{
	}
}
