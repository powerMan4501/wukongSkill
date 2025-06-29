using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInteractLockActionList : ReadOnlyPrimitiveList<EInteractLockAction>
{
	public ReadOnlyEInteractLockActionList(RepeatedField<EInteractLockAction> pbData)
		: base(pbData)
	{
	}
}
