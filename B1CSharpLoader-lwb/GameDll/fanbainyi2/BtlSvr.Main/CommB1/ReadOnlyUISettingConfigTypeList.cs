using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyUISettingConfigTypeList : ReadOnlyPrimitiveList<UISettingConfigType>
{
	public ReadOnlyUISettingConfigTypeList(RepeatedField<UISettingConfigType> pbData)
		: base(pbData)
	{
	}
}
