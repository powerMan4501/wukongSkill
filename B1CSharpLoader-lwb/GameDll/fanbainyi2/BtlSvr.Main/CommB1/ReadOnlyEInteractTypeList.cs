using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInteractTypeList : ReadOnlyPrimitiveList<EInteractType>
{
	public ReadOnlyEInteractTypeList(RepeatedField<EInteractType> pbData)
		: base(pbData)
	{
	}
}
