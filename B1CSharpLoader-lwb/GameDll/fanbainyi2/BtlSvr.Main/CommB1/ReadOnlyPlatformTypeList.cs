using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyPlatformTypeList : ReadOnlyPrimitiveList<PlatformType>
{
	public ReadOnlyPlatformTypeList(RepeatedField<PlatformType> pbData)
		: base(pbData)
	{
	}
}
