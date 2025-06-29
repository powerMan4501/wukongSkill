using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESummonUnitRotationTypeList : ReadOnlyPrimitiveList<ESummonUnitRotationType>
{
	public ReadOnlyESummonUnitRotationTypeList(RepeatedField<ESummonUnitRotationType> pbData)
		: base(pbData)
	{
	}
}
