using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyNumConfigTypeList : ReadOnlyPrimitiveList<NumConfigType>
{
	public ReadOnlyNumConfigTypeList(RepeatedField<NumConfigType> pbData)
		: base(pbData)
	{
	}
}
