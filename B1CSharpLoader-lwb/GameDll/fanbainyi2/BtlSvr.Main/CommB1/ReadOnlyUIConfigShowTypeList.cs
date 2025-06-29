using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyUIConfigShowTypeList : ReadOnlyPrimitiveList<UIConfigShowType>
{
	public ReadOnlyUIConfigShowTypeList(RepeatedField<UIConfigShowType> pbData)
		: base(pbData)
	{
	}
}
