using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGuideGroupFinishTypeList : ReadOnlyPrimitiveList<EGuideGroupFinishType>
{
	public ReadOnlyEGuideGroupFinishTypeList(RepeatedField<EGuideGroupFinishType> pbData)
		: base(pbData)
	{
	}
}
