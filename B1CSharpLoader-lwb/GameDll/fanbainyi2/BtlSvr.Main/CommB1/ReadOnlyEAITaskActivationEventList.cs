using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAITaskActivationEventList : ReadOnlyPrimitiveList<EAITaskActivationEvent>
{
	public ReadOnlyEAITaskActivationEventList(RepeatedField<EAITaskActivationEvent> pbData)
		: base(pbData)
	{
	}
}
