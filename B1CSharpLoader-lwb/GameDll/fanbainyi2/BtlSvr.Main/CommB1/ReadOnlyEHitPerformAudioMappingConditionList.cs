using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPerformAudioMappingConditionList : ReadOnlyPrimitiveList<EHitPerformAudioMappingCondition>
{
	public ReadOnlyEHitPerformAudioMappingConditionList(RepeatedField<EHitPerformAudioMappingCondition> pbData)
		: base(pbData)
	{
	}
}
