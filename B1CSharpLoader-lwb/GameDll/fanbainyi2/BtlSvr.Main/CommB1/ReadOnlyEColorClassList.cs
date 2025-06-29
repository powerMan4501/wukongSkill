using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEColorClassList : ReadOnlyPrimitiveList<EColorClass>
{
	public ReadOnlyEColorClassList(RepeatedField<EColorClass> pbData)
		: base(pbData)
	{
	}
}
