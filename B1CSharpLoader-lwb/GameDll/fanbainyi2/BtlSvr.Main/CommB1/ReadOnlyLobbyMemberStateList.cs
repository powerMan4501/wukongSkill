using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobbyMemberStateList : ReadOnlyPrimitiveList<LobbyMemberState>
{
	public ReadOnlyLobbyMemberStateList(RepeatedField<LobbyMemberState> pbData)
		: base(pbData)
	{
	}
}
