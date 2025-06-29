using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEConditionRelationTypeList : ReadOnlyPrimitiveList<EConditionRelationType>
{
	public ReadOnlyEConditionRelationTypeList(RepeatedField<EConditionRelationType> pbData)
		: base(pbData)
	{
	}
}
