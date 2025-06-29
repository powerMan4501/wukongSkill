using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESummonTargetMethodList : ReadOnlyPrimitiveList<ESummonTargetMethod>
{
	public ReadOnlyESummonTargetMethodList(RepeatedField<ESummonTargetMethod> pbData)
		: base(pbData)
	{
	}
}
