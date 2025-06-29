using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobbyEventTypeList : ReadOnlyPrimitiveList<LobbyEventType>
{
	public ReadOnlyLobbyEventTypeList(RepeatedField<LobbyEventType> pbData)
		: base(pbData)
	{
	}
}
