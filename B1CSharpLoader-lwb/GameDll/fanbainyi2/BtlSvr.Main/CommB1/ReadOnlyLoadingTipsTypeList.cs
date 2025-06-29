using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyLoadingTipsTypeList : ReadOnlyPrimitiveList<LoadingTipsType>
{
	public ReadOnlyLoadingTipsTypeList(RepeatedField<LoadingTipsType> pbData)
		: base(pbData)
	{
	}
}
