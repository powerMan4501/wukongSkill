using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPlayerGameModeList : ReadOnlyPrimitiveList<PlayerGameMode>
{
	public ReadOnlyPlayerGameModeList(RepeatedField<PlayerGameMode> pbData)
		: base(pbData)
	{
	}
}
