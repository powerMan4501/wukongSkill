using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyFixed64List : ReadOnlyPrimitiveList<ulong>
{
	public ReadOnlyFixed64List(RepeatedField<ulong> pbData)
		: base(pbData)
	{
	}
}
