using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGuideGroupTriggerTypeList : ReadOnlyPrimitiveList<EGuideGroupTriggerType>
{
	public ReadOnlyEGuideGroupTriggerTypeList(RepeatedField<EGuideGroupTriggerType> pbData)
		: base(pbData)
	{
	}
}
