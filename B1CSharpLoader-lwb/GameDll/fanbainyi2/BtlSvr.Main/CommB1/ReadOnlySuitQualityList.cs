using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySuitQualityList : ReadOnlyPrimitiveList<SuitQuality>
{
	public ReadOnlySuitQualityList(RepeatedField<SuitQuality> pbData)
		: base(pbData)
	{
	}
}
