using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoomStateList : ReadOnlyPrimitiveList<RoomState>
{
	public ReadOnlyRoomStateList(RepeatedField<RoomState> pbData)
		: base(pbData)
	{
	}
}
