using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAIBasicActionTypeList : ReadOnlyPrimitiveList<EAIBasicActionType>
{
	public ReadOnlyEAIBasicActionTypeList(RepeatedField<EAIBasicActionType> pbData)
		: base(pbData)
	{
	}
}
