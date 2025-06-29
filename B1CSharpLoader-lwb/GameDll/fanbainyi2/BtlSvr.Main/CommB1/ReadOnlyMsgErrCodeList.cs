using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyMsgErrCodeList : ReadOnlyPrimitiveList<MsgErrCode>
{
	public ReadOnlyMsgErrCodeList(RepeatedField<MsgErrCode> pbData)
		: base(pbData)
	{
	}
}
