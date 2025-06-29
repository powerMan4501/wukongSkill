using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEBossUnlockConditionList : ReadOnlyPrimitiveList<EBossUnlockCondition>
{
	public ReadOnlyEBossUnlockConditionList(RepeatedField<EBossUnlockCondition> pbData)
		: base(pbData)
	{
	}
}
