using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlySettingBanConditionTypeList : ReadOnlyPrimitiveList<SettingBanConditionType>
{
	public ReadOnlySettingBanConditionTypeList(RepeatedField<SettingBanConditionType> pbData)
		: base(pbData)
	{
	}
}
