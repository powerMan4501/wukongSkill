using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFilterTypeList : ReadOnlyPrimitiveList<EFilterType>
{
	public ReadOnlyEFilterTypeList(RepeatedField<EFilterType> pbData)
		: base(pbData)
	{
	}
}
