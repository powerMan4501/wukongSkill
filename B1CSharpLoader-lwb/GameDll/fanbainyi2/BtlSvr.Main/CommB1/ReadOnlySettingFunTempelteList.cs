using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlySettingFunTempelteList : ReadOnlyPrimitiveList<SettingFunTempelte>
{
	public ReadOnlySettingFunTempelteList(RepeatedField<SettingFunTempelte> pbData)
		: base(pbData)
	{
	}
}
