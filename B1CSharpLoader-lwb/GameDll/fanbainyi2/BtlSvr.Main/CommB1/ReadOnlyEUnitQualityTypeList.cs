using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitQualityTypeList : ReadOnlyPrimitiveList<EUnitQualityType>
{
	public ReadOnlyEUnitQualityTypeList(RepeatedField<EUnitQualityType> pbData)
		: base(pbData)
	{
	}
}
