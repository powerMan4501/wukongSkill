using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAITaskActionTypeList : ReadOnlyPrimitiveList<EAITaskActionType>
{
	public ReadOnlyEAITaskActionTypeList(RepeatedField<EAITaskActionType> pbData)
		: base(pbData)
	{
	}
}
