using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyArtbookTypeList : ReadOnlyPrimitiveList<ArtbookType>
{
	public ReadOnlyArtbookTypeList(RepeatedField<ArtbookType> pbData)
		: base(pbData)
	{
	}
}
