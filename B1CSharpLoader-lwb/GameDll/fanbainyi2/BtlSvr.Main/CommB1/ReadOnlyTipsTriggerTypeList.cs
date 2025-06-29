using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTipsTriggerTypeList : ReadOnlyPrimitiveList<TipsTriggerType>
{
	public ReadOnlyTipsTriggerTypeList(RepeatedField<TipsTriggerType> pbData)
		: base(pbData)
	{
	}
}
