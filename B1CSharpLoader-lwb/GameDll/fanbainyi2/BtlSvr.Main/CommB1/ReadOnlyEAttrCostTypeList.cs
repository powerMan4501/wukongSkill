using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAttrCostTypeList : ReadOnlyPrimitiveList<EAttrCostType>
{
	public ReadOnlyEAttrCostTypeList(RepeatedField<EAttrCostType> pbData)
		: base(pbData)
	{
	}
}
