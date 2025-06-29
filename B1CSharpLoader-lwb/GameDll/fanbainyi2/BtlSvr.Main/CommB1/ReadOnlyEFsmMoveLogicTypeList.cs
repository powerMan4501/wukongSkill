using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFsmMoveLogicTypeList : ReadOnlyPrimitiveList<EFsmMoveLogicType>
{
	public ReadOnlyEFsmMoveLogicTypeList(RepeatedField<EFsmMoveLogicType> pbData)
		: base(pbData)
	{
	}
}
