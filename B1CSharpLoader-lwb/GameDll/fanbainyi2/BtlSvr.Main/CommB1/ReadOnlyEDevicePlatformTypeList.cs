using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEDevicePlatformTypeList : ReadOnlyPrimitiveList<EDevicePlatformType>
{
	public ReadOnlyEDevicePlatformTypeList(RepeatedField<EDevicePlatformType> pbData)
		: base(pbData)
	{
	}
}
