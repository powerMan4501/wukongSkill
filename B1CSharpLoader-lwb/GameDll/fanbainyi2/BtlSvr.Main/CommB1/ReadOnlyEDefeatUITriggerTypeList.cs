using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEDefeatUITriggerTypeList : ReadOnlyPrimitiveList<EDefeatUITriggerType>
{
	public ReadOnlyEDefeatUITriggerTypeList(RepeatedField<EDefeatUITriggerType> pbData)
		: base(pbData)
	{
	}
}
