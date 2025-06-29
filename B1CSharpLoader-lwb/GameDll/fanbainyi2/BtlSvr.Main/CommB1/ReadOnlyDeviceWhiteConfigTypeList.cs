using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyDeviceWhiteConfigTypeList : ReadOnlyPrimitiveList<DeviceWhiteConfigType>
{
	public ReadOnlyDeviceWhiteConfigTypeList(RepeatedField<DeviceWhiteConfigType> pbData)
		: base(pbData)
	{
	}
}
