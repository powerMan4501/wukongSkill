using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLogicRelationTypeList : ReadOnlyPrimitiveList<LogicRelationType>
{
	public ReadOnlyLogicRelationTypeList(RepeatedField<LogicRelationType> pbData)
		: base(pbData)
	{
	}
}
