using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitBodyTypeList : ReadOnlyPrimitiveList<EUnitBodyType>
{
	public ReadOnlyEUnitBodyTypeList(RepeatedField<EUnitBodyType> pbData)
		: base(pbData)
	{
	}
}
