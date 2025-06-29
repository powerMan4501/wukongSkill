using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyProtocolTagList : ReadOnlyPrimitiveList<ProtocolTag>
{
	public ReadOnlyProtocolTagList(RepeatedField<ProtocolTag> pbData)
		: base(pbData)
	{
	}
}
