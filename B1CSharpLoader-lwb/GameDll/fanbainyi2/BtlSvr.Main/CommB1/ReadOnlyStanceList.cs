using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyStanceList : ReadOnlyPrimitiveList<Stance>
{
	public ReadOnlyStanceList(RepeatedField<Stance> pbData)
		: base(pbData)
	{
	}
}
