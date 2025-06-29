using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyMonsterTypeList : ReadOnlyPrimitiveList<MonsterType>
{
	public ReadOnlyMonsterTypeList(RepeatedField<MonsterType> pbData)
		: base(pbData)
	{
	}
}
