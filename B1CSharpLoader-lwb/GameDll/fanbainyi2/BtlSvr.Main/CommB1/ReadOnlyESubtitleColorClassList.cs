using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESubtitleColorClassList : ReadOnlyPrimitiveList<ESubtitleColorClass>
{
	public ReadOnlyESubtitleColorClassList(RepeatedField<ESubtitleColorClass> pbData)
		: base(pbData)
	{
	}
}
