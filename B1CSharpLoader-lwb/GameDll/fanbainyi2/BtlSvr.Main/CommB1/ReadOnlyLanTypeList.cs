using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyLanTypeList : ReadOnlyPrimitiveList<LanType>
{
	public ReadOnlyLanTypeList(RepeatedField<LanType> pbData)
		: base(pbData)
	{
	}
}
