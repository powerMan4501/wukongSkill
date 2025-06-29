using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBulletAreaTypeList : ReadOnlyPrimitiveList<EBulletAreaType>
{
	public ReadOnlyEBulletAreaTypeList(RepeatedField<EBulletAreaType> pbData)
		: base(pbData)
	{
	}
}
