using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEBossRushTypeList : ReadOnlyPrimitiveList<EBossRushType>
{
	public ReadOnlyEBossRushTypeList(RepeatedField<EBossRushType> pbData)
		: base(pbData)
	{
	}
}
