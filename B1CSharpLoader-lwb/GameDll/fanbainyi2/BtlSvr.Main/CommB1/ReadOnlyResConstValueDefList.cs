using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyResConstValueDefList : ReadOnlyPrimitiveList<ResConstValueDef>
{
	public ReadOnlyResConstValueDefList(RepeatedField<ResConstValueDef> pbData)
		: base(pbData)
	{
	}
}
