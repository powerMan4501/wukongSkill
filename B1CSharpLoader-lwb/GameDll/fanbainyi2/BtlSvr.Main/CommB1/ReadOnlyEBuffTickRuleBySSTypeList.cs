using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffTickRuleBySSTypeList : ReadOnlyPrimitiveList<EBuffTickRuleBySSType>
{
	public ReadOnlyEBuffTickRuleBySSTypeList(RepeatedField<EBuffTickRuleBySSType> pbData)
		: base(pbData)
	{
	}
}
