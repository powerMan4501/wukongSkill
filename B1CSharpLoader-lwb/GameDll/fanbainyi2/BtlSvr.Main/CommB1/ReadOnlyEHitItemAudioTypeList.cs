using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitItemAudioTypeList : ReadOnlyPrimitiveList<EHitItemAudioType>
{
	public ReadOnlyEHitItemAudioTypeList(RepeatedField<EHitItemAudioType> pbData)
		: base(pbData)
	{
	}
}
