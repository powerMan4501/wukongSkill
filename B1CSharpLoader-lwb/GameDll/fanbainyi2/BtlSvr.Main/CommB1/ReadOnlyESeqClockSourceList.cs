using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESeqClockSourceList : ReadOnlyPrimitiveList<ESeqClockSource>
{
	public ReadOnlyESeqClockSourceList(RepeatedField<ESeqClockSource> pbData)
		: base(pbData)
	{
	}
}
