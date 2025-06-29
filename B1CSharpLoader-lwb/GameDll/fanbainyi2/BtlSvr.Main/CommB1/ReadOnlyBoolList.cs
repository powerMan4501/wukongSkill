using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBoolList : ReadOnlyPrimitiveList<bool>
{
	public ReadOnlyBoolList(RepeatedField<bool> pbData)
		: base(pbData)
	{
	}
}
