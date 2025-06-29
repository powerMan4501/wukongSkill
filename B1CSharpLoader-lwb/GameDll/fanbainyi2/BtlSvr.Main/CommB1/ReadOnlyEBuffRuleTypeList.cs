using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffRuleTypeList : ReadOnlyPrimitiveList<EBuffRuleType>
{
	public ReadOnlyEBuffRuleTypeList(RepeatedField<EBuffRuleType> pbData)
		: base(pbData)
	{
	}
}
