using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLobbyAdvertiseTypeList : ReadOnlyPrimitiveList<LobbyAdvertiseType>
{
	public ReadOnlyLobbyAdvertiseTypeList(RepeatedField<LobbyAdvertiseType> pbData)
		: base(pbData)
	{
	}
}
