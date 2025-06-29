using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyActivityStatusList : ReadOnlyPrimitiveList<ActivityStatus>
{
	public ReadOnlyActivityStatusList(RepeatedField<ActivityStatus> pbData)
		: base(pbData)
	{
	}
}
