using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGuideNodeFinishTypeList : ReadOnlyPrimitiveList<EGuideNodeFinishType>
{
	public ReadOnlyEGuideNodeFinishTypeList(RepeatedField<EGuideNodeFinishType> pbData)
		: base(pbData)
	{
	}
}
