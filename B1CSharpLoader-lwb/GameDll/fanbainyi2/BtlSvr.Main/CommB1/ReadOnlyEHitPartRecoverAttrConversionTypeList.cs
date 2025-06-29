using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPartRecoverAttrConversionTypeList : ReadOnlyPrimitiveList<EHitPartRecoverAttrConversionType>
{
	public ReadOnlyEHitPartRecoverAttrConversionTypeList(RepeatedField<EHitPartRecoverAttrConversionType> pbData)
		: base(pbData)
	{
	}
}
