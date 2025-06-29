using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySettingpbTagList : ReadOnlyPrimitiveList<SettingpbTag>
{
	public ReadOnlySettingpbTagList(RepeatedField<SettingpbTag> pbData)
		: base(pbData)
	{
	}
}
