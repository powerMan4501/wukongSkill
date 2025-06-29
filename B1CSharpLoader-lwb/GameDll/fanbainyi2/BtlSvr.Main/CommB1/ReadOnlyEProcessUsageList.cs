using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProcessUsageList : ReadOnlyPrimitiveList<EProcessUsage>
{
	public ReadOnlyEProcessUsageList(RepeatedField<EProcessUsage> pbData)
		: base(pbData)
	{
	}
}
