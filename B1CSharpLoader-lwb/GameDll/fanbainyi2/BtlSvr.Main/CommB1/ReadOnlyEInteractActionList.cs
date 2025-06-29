using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEInteractActionList : ReadOnlyPrimitiveList<EInteractAction>
{
	public ReadOnlyEInteractActionList(RepeatedField<EInteractAction> pbData)
		: base(pbData)
	{
	}
}
