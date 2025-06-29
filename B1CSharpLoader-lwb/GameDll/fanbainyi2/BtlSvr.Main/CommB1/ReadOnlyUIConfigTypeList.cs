using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyUIConfigTypeList : ReadOnlyPrimitiveList<UIConfigType>
{
	public ReadOnlyUIConfigTypeList(RepeatedField<UIConfigType> pbData)
		: base(pbData)
	{
	}
}
