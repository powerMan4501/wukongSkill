using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyGMTeleportTypeList : ReadOnlyPrimitiveList<GMTeleportType>
{
	public ReadOnlyGMTeleportTypeList(RepeatedField<GMTeleportType> pbData)
		: base(pbData)
	{
	}
}
