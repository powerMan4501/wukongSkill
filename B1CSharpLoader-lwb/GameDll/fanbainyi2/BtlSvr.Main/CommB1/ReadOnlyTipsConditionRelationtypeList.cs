using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTipsConditionRelationtypeList : ReadOnlyPrimitiveList<TipsConditionRelationtype>
{
	public ReadOnlyTipsConditionRelationtypeList(RepeatedField<TipsConditionRelationtype> pbData)
		: base(pbData)
	{
	}
}
