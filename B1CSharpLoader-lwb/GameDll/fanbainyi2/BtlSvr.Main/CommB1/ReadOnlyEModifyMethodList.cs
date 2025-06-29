using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEModifyMethodList : ReadOnlyPrimitiveList<EModifyMethod>
{
	public ReadOnlyEModifyMethodList(RepeatedField<EModifyMethod> pbData)
		: base(pbData)
	{
	}
}
