using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyInt64List : ReadOnlyPrimitiveList<long>
{
	public ReadOnlyInt64List(RepeatedField<long> pbData)
		: base(pbData)
	{
	}
}
