using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyItemPackageTypeList : ReadOnlyPrimitiveList<ItemPackageType>
{
	public ReadOnlyItemPackageTypeList(RepeatedField<ItemPackageType> pbData)
		: base(pbData)
	{
	}
}
