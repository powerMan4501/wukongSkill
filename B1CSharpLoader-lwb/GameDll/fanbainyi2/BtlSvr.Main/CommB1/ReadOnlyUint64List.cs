using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyUint64List : ReadOnlyPrimitiveList<ulong>
{
	public ReadOnlyUint64List(RepeatedField<ulong> pbData)
		: base(pbData)
	{
	}
}
