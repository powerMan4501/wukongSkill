using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInputActionTypeList : ReadOnlyPrimitiveList<EInputActionType>
{
	public ReadOnlyEInputActionTypeList(RepeatedField<EInputActionType> pbData)
		: base(pbData)
	{
	}
}
