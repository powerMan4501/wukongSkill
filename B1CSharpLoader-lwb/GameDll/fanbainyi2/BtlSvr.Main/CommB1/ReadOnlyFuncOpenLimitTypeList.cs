using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyFuncOpenLimitTypeList : ReadOnlyPrimitiveList<FuncOpenLimitType>
{
	public ReadOnlyFuncOpenLimitTypeList(RepeatedField<FuncOpenLimitType> pbData)
		: base(pbData)
	{
	}
}
