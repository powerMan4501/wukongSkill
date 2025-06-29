using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShareMsgTypeList : ReadOnlyPrimitiveList<ShareMsgType>
{
	public ReadOnlyShareMsgTypeList(RepeatedField<ShareMsgType> pbData)
		: base(pbData)
	{
	}
}
