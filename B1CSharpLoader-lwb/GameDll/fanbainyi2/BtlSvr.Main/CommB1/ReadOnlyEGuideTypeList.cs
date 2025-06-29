using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGuideTypeList : ReadOnlyPrimitiveList<EGuideType>
{
	public ReadOnlyEGuideTypeList(RepeatedField<EGuideType> pbData)
		: base(pbData)
	{
	}
}
