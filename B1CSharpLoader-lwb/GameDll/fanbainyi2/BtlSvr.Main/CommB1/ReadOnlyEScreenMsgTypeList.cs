using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEScreenMsgTypeList : ReadOnlyPrimitiveList<EScreenMsgType>
{
	public ReadOnlyEScreenMsgTypeList(RepeatedField<EScreenMsgType> pbData)
		: base(pbData)
	{
	}
}
