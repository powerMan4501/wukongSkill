using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESettingOPTypeList : ReadOnlyPrimitiveList<ESettingOPType>
{
	public ReadOnlyESettingOPTypeList(RepeatedField<ESettingOPType> pbData)
		: base(pbData)
	{
	}
}
