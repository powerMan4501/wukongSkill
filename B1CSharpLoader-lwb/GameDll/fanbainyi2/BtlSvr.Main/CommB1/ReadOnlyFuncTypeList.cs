using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyFuncTypeList : ReadOnlyPrimitiveList<FuncType>
{
	public ReadOnlyFuncTypeList(RepeatedField<FuncType> pbData)
		: base(pbData)
	{
	}
}
