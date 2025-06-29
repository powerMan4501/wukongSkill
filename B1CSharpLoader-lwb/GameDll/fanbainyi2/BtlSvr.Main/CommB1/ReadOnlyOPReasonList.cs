using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyOPReasonList : ReadOnlyPrimitiveList<OPReason>
{
	public ReadOnlyOPReasonList(RepeatedField<OPReason> pbData)
		: base(pbData)
	{
	}
}
