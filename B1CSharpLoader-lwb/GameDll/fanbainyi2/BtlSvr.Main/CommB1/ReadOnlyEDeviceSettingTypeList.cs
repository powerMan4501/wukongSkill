using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEDeviceSettingTypeList : ReadOnlyPrimitiveList<EDeviceSettingType>
{
	public ReadOnlyEDeviceSettingTypeList(RepeatedField<EDeviceSettingType> pbData)
		: base(pbData)
	{
	}
}
