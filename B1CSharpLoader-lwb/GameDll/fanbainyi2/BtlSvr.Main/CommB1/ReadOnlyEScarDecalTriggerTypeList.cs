using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEScarDecalTriggerTypeList : ReadOnlyPrimitiveList<EScarDecalTriggerType>
{
	public ReadOnlyEScarDecalTriggerTypeList(RepeatedField<EScarDecalTriggerType> pbData)
		: base(pbData)
	{
	}
}
