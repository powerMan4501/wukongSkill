using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyAwardQualityList : ReadOnlyPrimitiveList<AwardQuality>
{
	public ReadOnlyAwardQualityList(RepeatedField<AwardQuality> pbData)
		: base(pbData)
	{
	}
}
