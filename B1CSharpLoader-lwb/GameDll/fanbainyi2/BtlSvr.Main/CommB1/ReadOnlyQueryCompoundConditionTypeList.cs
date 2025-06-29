using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyQueryCompoundConditionTypeList : ReadOnlyPrimitiveList<QueryCompoundConditionType>
{
	public ReadOnlyQueryCompoundConditionTypeList(RepeatedField<QueryCompoundConditionType> pbData)
		: base(pbData)
	{
	}
}
