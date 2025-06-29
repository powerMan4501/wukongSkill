using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBattleHostTypeList : ReadOnlyPrimitiveList<BattleHostType>
{
	public ReadOnlyBattleHostTypeList(RepeatedField<BattleHostType> pbData)
		: base(pbData)
	{
	}
}
