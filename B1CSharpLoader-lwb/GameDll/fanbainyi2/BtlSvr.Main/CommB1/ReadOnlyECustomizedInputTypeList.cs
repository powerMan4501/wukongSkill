using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECustomizedInputTypeList : ReadOnlyPrimitiveList<ECustomizedInputType>
{
	public ReadOnlyECustomizedInputTypeList(RepeatedField<ECustomizedInputType> pbData)
		: base(pbData)
	{
	}
}
