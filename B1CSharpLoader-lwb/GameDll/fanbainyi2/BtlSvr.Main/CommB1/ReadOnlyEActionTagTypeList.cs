using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEActionTagTypeList : ReadOnlyPrimitiveList<EActionTagType>
{
	public ReadOnlyEActionTagTypeList(RepeatedField<EActionTagType> pbData)
		: base(pbData)
	{
	}
}
