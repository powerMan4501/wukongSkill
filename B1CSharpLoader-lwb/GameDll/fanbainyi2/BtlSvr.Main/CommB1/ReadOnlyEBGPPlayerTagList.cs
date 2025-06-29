using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGPPlayerTagList : ReadOnlyPrimitiveList<EBGPPlayerTag>
{
	public ReadOnlyEBGPPlayerTagList(RepeatedField<EBGPPlayerTag> pbData)
		: base(pbData)
	{
	}
}
