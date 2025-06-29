using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyECommonErrorTypeList : ReadOnlyPrimitiveList<ECommonErrorType>
{
	public ReadOnlyECommonErrorTypeList(RepeatedField<ECommonErrorType> pbData)
		: base(pbData)
	{
	}
}
