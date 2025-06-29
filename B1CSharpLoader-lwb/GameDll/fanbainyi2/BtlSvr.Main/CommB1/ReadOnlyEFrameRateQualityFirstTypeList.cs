using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEFrameRateQualityFirstTypeList : ReadOnlyPrimitiveList<EFrameRateQualityFirstType>
{
	public ReadOnlyEFrameRateQualityFirstTypeList(RepeatedField<EFrameRateQualityFirstType> pbData)
		: base(pbData)
	{
	}
}
