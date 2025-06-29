using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEValueClampTypeList : ReadOnlyPrimitiveList<EValueClampType>
{
	public ReadOnlyEValueClampTypeList(RepeatedField<EValueClampType> pbData)
		: base(pbData)
	{
	}
}
