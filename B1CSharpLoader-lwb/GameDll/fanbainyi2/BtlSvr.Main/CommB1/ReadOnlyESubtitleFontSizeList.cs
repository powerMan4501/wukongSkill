using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESubtitleFontSizeList : ReadOnlyPrimitiveList<ESubtitleFontSize>
{
	public ReadOnlyESubtitleFontSizeList(RepeatedField<ESubtitleFontSize> pbData)
		: base(pbData)
	{
	}
}
