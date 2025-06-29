using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyDropRollTypeList : ReadOnlyPrimitiveList<DropRollType>
{
	public ReadOnlyDropRollTypeList(RepeatedField<DropRollType> pbData)
		: base(pbData)
	{
	}
}
