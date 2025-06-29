using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSYesNoList : ReadOnlyPrimitiveList<EGSYesNo>
{
	public ReadOnlyEGSYesNoList(RepeatedField<EGSYesNo> pbData)
		: base(pbData)
	{
	}
}
