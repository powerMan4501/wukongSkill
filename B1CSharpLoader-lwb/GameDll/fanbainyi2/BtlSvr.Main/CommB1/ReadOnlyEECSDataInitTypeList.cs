using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEECSDataInitTypeList : ReadOnlyPrimitiveList<EECSDataInitType>
{
	public ReadOnlyEECSDataInitTypeList(RepeatedField<EECSDataInitType> pbData)
		: base(pbData)
	{
	}
}
