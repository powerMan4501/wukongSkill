using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAITaskConditionList : ReadOnlyPrimitiveList<EAITaskCondition>
{
	public ReadOnlyEAITaskConditionList(RepeatedField<EAITaskCondition> pbData)
		: base(pbData)
	{
	}
}
