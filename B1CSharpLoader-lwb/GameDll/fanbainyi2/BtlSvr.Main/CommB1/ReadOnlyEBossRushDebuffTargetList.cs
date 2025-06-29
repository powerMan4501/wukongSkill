using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEBossRushDebuffTargetList : ReadOnlyPrimitiveList<EBossRushDebuffTarget>
{
	public ReadOnlyEBossRushDebuffTargetList(RepeatedField<EBossRushDebuffTarget> pbData)
		: base(pbData)
	{
	}
}
