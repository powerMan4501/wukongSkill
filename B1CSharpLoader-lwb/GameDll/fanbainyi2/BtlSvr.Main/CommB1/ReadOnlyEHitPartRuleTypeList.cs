using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitPartRuleTypeList : ReadOnlyPrimitiveList<EHitPartRuleType>
{
	public ReadOnlyEHitPartRuleTypeList(RepeatedField<EHitPartRuleType> pbData)
		: base(pbData)
	{
	}
}
