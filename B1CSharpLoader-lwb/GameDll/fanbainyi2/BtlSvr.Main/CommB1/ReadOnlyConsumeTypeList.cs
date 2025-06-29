using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyConsumeTypeList : ReadOnlyPrimitiveList<ConsumeType>
{
	public ReadOnlyConsumeTypeList(RepeatedField<ConsumeType> pbData)
		: base(pbData)
	{
	}
}
