using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyUISettingDetailDisplayTypeList : ReadOnlyPrimitiveList<UISettingDetailDisplayType>
{
	public ReadOnlyUISettingDetailDisplayTypeList(RepeatedField<UISettingDetailDisplayType> pbData)
		: base(pbData)
	{
	}
}
