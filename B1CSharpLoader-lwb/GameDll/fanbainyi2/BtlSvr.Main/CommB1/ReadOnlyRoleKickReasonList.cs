using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleKickReasonList : ReadOnlyPrimitiveList<RoleKickReason>
{
	public ReadOnlyRoleKickReasonList(RepeatedField<RoleKickReason> pbData)
		: base(pbData)
	{
	}
}
