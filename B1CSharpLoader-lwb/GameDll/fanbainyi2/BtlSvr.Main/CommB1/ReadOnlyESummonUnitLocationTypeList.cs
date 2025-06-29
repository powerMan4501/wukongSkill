using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESummonUnitLocationTypeList : ReadOnlyPrimitiveList<ESummonUnitLocationType>
{
	public ReadOnlyESummonUnitLocationTypeList(RepeatedField<ESummonUnitLocationType> pbData)
		: base(pbData)
	{
	}
}
