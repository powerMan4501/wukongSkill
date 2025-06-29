using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPartRecoverAttrTypeList : ReadOnlyPrimitiveList<EHitPartRecoverAttrType>
{
	public ReadOnlyEHitPartRecoverAttrTypeList(RepeatedField<EHitPartRecoverAttrType> pbData)
		: base(pbData)
	{
	}
}
