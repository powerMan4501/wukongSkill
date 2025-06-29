using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUAttrFloatList : ReadOnlyPrimitiveList<EBGUAttrFloat>
{
	public ReadOnlyEBGUAttrFloatList(RepeatedField<EBGUAttrFloat> pbData)
		: base(pbData)
	{
	}
}
