using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyETransInputConditionList : ReadOnlyPrimitiveList<ETransInputCondition>
{
	public ReadOnlyETransInputConditionList(RepeatedField<ETransInputCondition> pbData)
		: base(pbData)
	{
	}
}
