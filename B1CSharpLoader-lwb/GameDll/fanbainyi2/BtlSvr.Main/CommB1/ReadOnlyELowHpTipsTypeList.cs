using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyELowHpTipsTypeList : ReadOnlyPrimitiveList<ELowHpTipsType>
{
	public ReadOnlyELowHpTipsTypeList(RepeatedField<ELowHpTipsType> pbData)
		: base(pbData)
	{
	}
}
