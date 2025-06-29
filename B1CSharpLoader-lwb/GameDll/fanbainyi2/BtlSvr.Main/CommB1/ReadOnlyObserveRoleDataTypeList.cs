using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyObserveRoleDataTypeList : ReadOnlyPrimitiveList<ObserveRoleDataType>
{
	public ReadOnlyObserveRoleDataTypeList(RepeatedField<ObserveRoleDataType> pbData)
		: base(pbData)
	{
	}
}
