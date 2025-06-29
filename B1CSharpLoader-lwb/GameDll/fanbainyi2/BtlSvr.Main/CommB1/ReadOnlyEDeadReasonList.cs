using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEDeadReasonList : ReadOnlyPrimitiveList<EDeadReason>
{
	public ReadOnlyEDeadReasonList(RepeatedField<EDeadReason> pbData)
		: base(pbData)
	{
	}
}
