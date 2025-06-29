using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyArchiveSourceList : ReadOnlyPrimitiveList<ArchiveSource>
{
	public ReadOnlyArchiveSourceList(RepeatedField<ArchiveSource> pbData)
		: base(pbData)
	{
	}
}
