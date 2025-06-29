using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoomMemberStateList : ReadOnlyPrimitiveList<RoomMemberState>
{
	public ReadOnlyRoomMemberStateList(RepeatedField<RoomMemberState> pbData)
		: base(pbData)
	{
	}
}
