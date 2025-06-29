using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShareMsgClassList : ReadOnlyPrimitiveList<ShareMsgClass>
{
	public ReadOnlyShareMsgClassList(RepeatedField<ShareMsgClass> pbData)
		: base(pbData)
	{
	}
}
