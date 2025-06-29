using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMoveSpeedTypeList : ReadOnlyPrimitiveList<EMoveSpeedType>
{
	public ReadOnlyEMoveSpeedTypeList(RepeatedField<EMoveSpeedType> pbData)
		: base(pbData)
	{
	}
}
