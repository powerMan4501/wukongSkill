using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFsmStateLogicTriggerTypeList : ReadOnlyPrimitiveList<EFsmStateLogicTriggerType>
{
	public ReadOnlyEFsmStateLogicTriggerTypeList(RepeatedField<EFsmStateLogicTriggerType> pbData)
		: base(pbData)
	{
	}
}
