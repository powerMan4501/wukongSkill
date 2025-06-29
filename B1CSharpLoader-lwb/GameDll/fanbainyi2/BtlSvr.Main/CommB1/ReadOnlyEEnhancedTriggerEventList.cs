using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEEnhancedTriggerEventList : ReadOnlyPrimitiveList<EEnhancedTriggerEvent>
{
	public ReadOnlyEEnhancedTriggerEventList(RepeatedField<EEnhancedTriggerEvent> pbData)
		: base(pbData)
	{
	}
}
