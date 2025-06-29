using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyIncreaseTypeList : ReadOnlyPrimitiveList<IncreaseType>
{
	public ReadOnlyIncreaseTypeList(RepeatedField<IncreaseType> pbData)
		: base(pbData)
	{
	}
}
