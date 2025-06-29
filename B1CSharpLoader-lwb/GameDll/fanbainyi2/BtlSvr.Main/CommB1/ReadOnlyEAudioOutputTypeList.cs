using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEAudioOutputTypeList : ReadOnlyPrimitiveList<EAudioOutputType>
{
	public ReadOnlyEAudioOutputTypeList(RepeatedField<EAudioOutputType> pbData)
		: base(pbData)
	{
	}
}
