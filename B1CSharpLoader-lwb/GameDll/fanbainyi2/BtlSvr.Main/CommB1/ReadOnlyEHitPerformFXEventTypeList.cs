using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPerformFXEventTypeList : ReadOnlyPrimitiveList<EHitPerformFXEventType>
{
	public ReadOnlyEHitPerformFXEventTypeList(RepeatedField<EHitPerformFXEventType> pbData)
		: base(pbData)
	{
	}
}
