using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUInteractUnitStateList : ReadOnlyPrimitiveList<EBGUInteractUnitState>
{
	public ReadOnlyEBGUInteractUnitStateList(RepeatedField<EBGUInteractUnitState> pbData)
		: base(pbData)
	{
	}
}
