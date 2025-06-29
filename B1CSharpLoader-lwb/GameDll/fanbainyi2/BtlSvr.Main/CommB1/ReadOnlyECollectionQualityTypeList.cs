using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECollectionQualityTypeList : ReadOnlyPrimitiveList<ECollectionQualityType>
{
	public ReadOnlyECollectionQualityTypeList(RepeatedField<ECollectionQualityType> pbData)
		: base(pbData)
	{
	}
}
