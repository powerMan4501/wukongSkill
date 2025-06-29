using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyMantraTypeList : ReadOnlyPrimitiveList<MantraType>
{
	public ReadOnlyMantraTypeList(RepeatedField<MantraType> pbData)
		: base(pbData)
	{
	}
}
