using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGPTagTriggerList : ReadOnlyPrimitiveList<EBGPTagTrigger>
{
	public ReadOnlyEBGPTagTriggerList(RepeatedField<EBGPTagTrigger> pbData)
		: base(pbData)
	{
	}
}
