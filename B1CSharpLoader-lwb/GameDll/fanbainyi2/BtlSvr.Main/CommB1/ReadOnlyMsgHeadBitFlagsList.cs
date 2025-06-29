using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMsgHeadBitFlagsList : ReadOnlyPrimitiveList<MsgHeadBitFlags>
{
	public ReadOnlyMsgHeadBitFlagsList(RepeatedField<MsgHeadBitFlags> pbData)
		: base(pbData)
	{
	}
}
