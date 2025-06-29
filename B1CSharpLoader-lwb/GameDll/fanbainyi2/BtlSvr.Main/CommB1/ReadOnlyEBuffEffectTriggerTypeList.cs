using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffEffectTriggerTypeList : ReadOnlyPrimitiveList<EBuffEffectTriggerType>
{
	public ReadOnlyEBuffEffectTriggerTypeList(RepeatedField<EBuffEffectTriggerType> pbData)
		: base(pbData)
	{
	}
}
