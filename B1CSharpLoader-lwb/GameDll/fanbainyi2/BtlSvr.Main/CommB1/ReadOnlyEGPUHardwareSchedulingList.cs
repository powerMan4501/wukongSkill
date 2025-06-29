using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEGPUHardwareSchedulingList : ReadOnlyPrimitiveList<EGPUHardwareScheduling>
{
	public ReadOnlyEGPUHardwareSchedulingList(RepeatedField<EGPUHardwareScheduling> pbData)
		: base(pbData)
	{
	}
}
