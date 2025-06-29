using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEValOpList : ReadOnlyPrimitiveList<EValOp>
{
	public ReadOnlyEValOpList(RepeatedField<EValOp> pbData)
		: base(pbData)
	{
	}
}
