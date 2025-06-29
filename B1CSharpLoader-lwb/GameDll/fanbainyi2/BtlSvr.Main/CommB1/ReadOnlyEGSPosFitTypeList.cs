using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSPosFitTypeList : ReadOnlyPrimitiveList<EGSPosFitType>
{
	public ReadOnlyEGSPosFitTypeList(RepeatedField<EGSPosFitType> pbData)
		: base(pbData)
	{
	}
}
