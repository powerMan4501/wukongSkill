using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobbyMemberUpdateTypeList : ReadOnlyPrimitiveList<LobbyMemberUpdateType>
{
	public ReadOnlyLobbyMemberUpdateTypeList(RepeatedField<LobbyMemberUpdateType> pbData)
		: base(pbData)
	{
	}
}
