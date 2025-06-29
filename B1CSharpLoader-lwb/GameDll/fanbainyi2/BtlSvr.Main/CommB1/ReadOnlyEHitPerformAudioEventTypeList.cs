using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPerformAudioEventTypeList : ReadOnlyPrimitiveList<EHitPerformAudioEventType>
{
	public ReadOnlyEHitPerformAudioEventTypeList(RepeatedField<EHitPerformAudioEventType> pbData)
		: base(pbData)
	{
	}
}
