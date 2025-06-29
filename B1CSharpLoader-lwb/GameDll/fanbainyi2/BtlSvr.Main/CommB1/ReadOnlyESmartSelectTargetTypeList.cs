using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESmartSelectTargetTypeList : ReadOnlyPrimitiveList<ESmartSelectTargetType>
{
	public ReadOnlyESmartSelectTargetTypeList(RepeatedField<ESmartSelectTargetType> pbData)
		: base(pbData)
	{
	}
}
