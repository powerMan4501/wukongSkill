using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPartReduceAttrTypeList : ReadOnlyPrimitiveList<EHitPartReduceAttrType>
{
	public ReadOnlyEHitPartReduceAttrTypeList(RepeatedField<EHitPartReduceAttrType> pbData)
		: base(pbData)
	{
	}
}
