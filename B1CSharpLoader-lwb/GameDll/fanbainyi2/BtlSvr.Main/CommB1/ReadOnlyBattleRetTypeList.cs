using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBattleRetTypeList : ReadOnlyPrimitiveList<BattleRetType>
{
	public ReadOnlyBattleRetTypeList(RepeatedField<BattleRetType> pbData)
		: base(pbData)
	{
	}
}
