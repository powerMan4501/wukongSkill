using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGuideGroupTypeList : ReadOnlyPrimitiveList<EGuideGroupType>
{
	public ReadOnlyEGuideGroupTypeList(RepeatedField<EGuideGroupType> pbData)
		: base(pbData)
	{
	}
}
