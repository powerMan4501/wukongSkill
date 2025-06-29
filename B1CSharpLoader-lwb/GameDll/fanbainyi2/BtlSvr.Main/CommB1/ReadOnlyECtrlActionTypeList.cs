using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECtrlActionTypeList : ReadOnlyPrimitiveList<ECtrlActionType>
{
	public ReadOnlyECtrlActionTypeList(RepeatedField<ECtrlActionType> pbData)
		: base(pbData)
	{
	}
}
