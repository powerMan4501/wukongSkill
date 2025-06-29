using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCommConstValueDefList : ReadOnlyPrimitiveList<CommConstValueDef>
{
	public ReadOnlyCommConstValueDefList(RepeatedField<CommConstValueDef> pbData)
		: base(pbData)
	{
	}
}
