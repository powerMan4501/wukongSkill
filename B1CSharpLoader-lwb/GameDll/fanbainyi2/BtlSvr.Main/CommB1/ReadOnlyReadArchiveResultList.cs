using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyReadArchiveResultList : ReadOnlyPrimitiveList<ReadArchiveResult>
{
	public ReadOnlyReadArchiveResultList(RepeatedField<ReadArchiveResult> pbData)
		: base(pbData)
	{
	}
}
