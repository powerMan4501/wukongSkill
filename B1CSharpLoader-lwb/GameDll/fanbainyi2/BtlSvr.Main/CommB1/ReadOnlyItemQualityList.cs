using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyItemQualityList : ReadOnlyPrimitiveList<ItemQuality>
{
	public ReadOnlyItemQualityList(RepeatedField<ItemQuality> pbData)
		: base(pbData)
	{
	}
}
