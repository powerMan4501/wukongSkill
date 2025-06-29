using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyTeamStateList : ReadOnlyPrimitiveList<TeamState>
{
	public ReadOnlyTeamStateList(RepeatedField<TeamState> pbData)
		: base(pbData)
	{
	}
}
