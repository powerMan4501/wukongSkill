using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyStringList : ReadOnlyPrimitiveList<string>
{
	public ReadOnlyStringList(RepeatedField<string> pbData)
		: base(pbData)
	{
	}
}
