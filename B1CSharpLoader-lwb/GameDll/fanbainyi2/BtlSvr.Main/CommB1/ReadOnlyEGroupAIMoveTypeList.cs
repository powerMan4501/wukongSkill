using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGroupAIMoveTypeList : ReadOnlyPrimitiveList<EGroupAIMoveType>
{
	public ReadOnlyEGroupAIMoveTypeList(RepeatedField<EGroupAIMoveType> pbData)
		: base(pbData)
	{
	}
}
