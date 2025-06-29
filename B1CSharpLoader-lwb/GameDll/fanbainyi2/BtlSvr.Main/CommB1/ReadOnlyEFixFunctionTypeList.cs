using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFixFunctionTypeList : ReadOnlyPrimitiveList<EFixFunctionType>
{
	public ReadOnlyEFixFunctionTypeList(RepeatedField<EFixFunctionType> pbData)
		: base(pbData)
	{
	}
}
