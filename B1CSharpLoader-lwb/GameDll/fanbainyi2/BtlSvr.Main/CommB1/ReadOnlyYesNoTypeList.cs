using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyYesNoTypeList : ReadOnlyPrimitiveList<YesNoType>
{
	public ReadOnlyYesNoTypeList(RepeatedField<YesNoType> pbData)
		: base(pbData)
	{
	}
}
