using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyGainPerformanceTypeList : ReadOnlyPrimitiveList<GainPerformanceType>
{
	public ReadOnlyGainPerformanceTypeList(RepeatedField<GainPerformanceType> pbData)
		: base(pbData)
	{
	}
}
