using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitDefeatedTypeList : ReadOnlyPrimitiveList<EUnitDefeatedType>
{
	public ReadOnlyEUnitDefeatedTypeList(RepeatedField<EUnitDefeatedType> pbData)
		: base(pbData)
	{
	}
}
