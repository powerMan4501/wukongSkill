using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileBeHittedCostAttrTypeList : ReadOnlyPrimitiveList<EProjectileBeHittedCostAttrType>
{
	public ReadOnlyEProjectileBeHittedCostAttrTypeList(RepeatedField<EProjectileBeHittedCostAttrType> pbData)
		: base(pbData)
	{
	}
}
