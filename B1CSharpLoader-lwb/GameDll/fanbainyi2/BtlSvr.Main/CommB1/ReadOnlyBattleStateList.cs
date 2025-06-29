using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBattleStateList : ReadOnlyPrimitiveList<BattleState>
{
	public ReadOnlyBattleStateList(RepeatedField<BattleState> pbData)
		: base(pbData)
	{
	}
}
