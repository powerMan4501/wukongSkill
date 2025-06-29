using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyUint32List : ReadOnlyPrimitiveList<uint>
{
	public ReadOnlyUint32List(RepeatedField<uint> pbData)
		: base(pbData)
	{
	}
}
