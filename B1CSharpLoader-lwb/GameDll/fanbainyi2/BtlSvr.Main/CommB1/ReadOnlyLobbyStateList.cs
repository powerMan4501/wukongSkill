using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobbyStateList : ReadOnlyPrimitiveList<LobbyState>
{
	public ReadOnlyLobbyStateList(RepeatedField<LobbyState> pbData)
		: base(pbData)
	{
	}
}
