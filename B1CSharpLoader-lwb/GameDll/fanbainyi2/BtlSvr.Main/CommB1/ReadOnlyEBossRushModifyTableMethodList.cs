using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBossRushModifyTableMethodList : ReadOnlyPrimitiveList<EBossRushModifyTableMethod>
{
	public ReadOnlyEBossRushModifyTableMethodList(RepeatedField<EBossRushModifyTableMethod> pbData)
		: base(pbData)
	{
	}
}
