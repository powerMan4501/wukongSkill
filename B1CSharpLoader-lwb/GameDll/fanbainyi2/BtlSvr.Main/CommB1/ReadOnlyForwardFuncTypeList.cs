using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyForwardFuncTypeList : ReadOnlyPrimitiveList<ForwardFuncType>
{
	public ReadOnlyForwardFuncTypeList(RepeatedField<ForwardFuncType> pbData)
		: base(pbData)
	{
	}
}
