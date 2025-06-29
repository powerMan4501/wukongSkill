using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTipsConditionTypeList : ReadOnlyPrimitiveList<TipsConditionType>
{
	public ReadOnlyTipsConditionTypeList(RepeatedField<TipsConditionType> pbData)
		: base(pbData)
	{
	}
}
