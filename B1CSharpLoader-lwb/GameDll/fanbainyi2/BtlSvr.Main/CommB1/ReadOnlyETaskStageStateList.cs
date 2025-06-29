using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyETaskStageStateList : ReadOnlyPrimitiveList<ETaskStageState>
{
	public ReadOnlyETaskStageStateList(RepeatedField<ETaskStageState> pbData)
		: base(pbData)
	{
	}
}
