using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyRoleDataConfigItemTypeList : ReadOnlyPrimitiveList<RoleDataConfigItemType>
{
	public ReadOnlyRoleDataConfigItemTypeList(RepeatedField<RoleDataConfigItemType> pbData)
		: base(pbData)
	{
	}
}
