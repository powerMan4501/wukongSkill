using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAbnormalDispModifyTypeList : ReadOnlyPrimitiveList<EAbnormalDispModifyType>
{
	public ReadOnlyEAbnormalDispModifyTypeList(RepeatedField<EAbnormalDispModifyType> pbData)
		: base(pbData)
	{
	}
}
