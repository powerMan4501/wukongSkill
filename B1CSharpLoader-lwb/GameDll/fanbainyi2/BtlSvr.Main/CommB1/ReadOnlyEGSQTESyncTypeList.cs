using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSQTESyncTypeList : ReadOnlyPrimitiveList<EGSQTESyncType>
{
	public ReadOnlyEGSQTESyncTypeList(RepeatedField<EGSQTESyncType> pbData)
		: base(pbData)
	{
	}
}
