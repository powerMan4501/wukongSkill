using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyAutoExecTypeList : ReadOnlyPrimitiveList<AutoExecType>
{
	public ReadOnlyAutoExecTypeList(RepeatedField<AutoExecType> pbData)
		: base(pbData)
	{
	}
}
