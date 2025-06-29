using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInterActMappingConditionList : ReadOnlyPrimitiveList<EInterActMappingCondition>
{
	public ReadOnlyEInterActMappingConditionList(RepeatedField<EInterActMappingCondition> pbData)
		: base(pbData)
	{
	}
}
