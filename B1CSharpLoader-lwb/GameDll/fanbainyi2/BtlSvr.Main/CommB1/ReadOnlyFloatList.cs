using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyFloatList : ReadOnlyPrimitiveList<float>
{
	public ReadOnlyFloatList(RepeatedField<float> pbData)
		: base(pbData)
	{
	}
}
