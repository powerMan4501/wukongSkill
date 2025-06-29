using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESubtitleBGClassList : ReadOnlyPrimitiveList<ESubtitleBGClass>
{
	public ReadOnlyESubtitleBGClassList(RepeatedField<ESubtitleBGClass> pbData)
		: base(pbData)
	{
	}
}
