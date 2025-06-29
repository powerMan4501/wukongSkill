using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyRandNameTypeList : ReadOnlyPrimitiveList<RandNameType>
{
	public ReadOnlyRandNameTypeList(RepeatedField<RandNameType> pbData)
		: base(pbData)
	{
	}
}
