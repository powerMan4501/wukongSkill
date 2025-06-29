using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEquipPositionList : ReadOnlyPrimitiveList<EquipPosition>
{
	public ReadOnlyEquipPositionList(RepeatedField<EquipPosition> pbData)
		: base(pbData)
	{
	}
}
