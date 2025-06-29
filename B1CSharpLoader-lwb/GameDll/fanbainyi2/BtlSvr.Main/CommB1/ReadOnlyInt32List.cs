using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyInt32List : ReadOnlyPrimitiveList<int>
{
	public ReadOnlyInt32List(RepeatedField<int> pbData)
		: base(pbData)
	{
	}
}
