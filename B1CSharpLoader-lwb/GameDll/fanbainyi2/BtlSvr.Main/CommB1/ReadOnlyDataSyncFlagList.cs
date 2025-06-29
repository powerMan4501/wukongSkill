using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyDataSyncFlagList : ReadOnlyPrimitiveList<DataSyncFlag>
{
	public ReadOnlyDataSyncFlagList(RepeatedField<DataSyncFlag> pbData)
		: base(pbData)
	{
	}
}
