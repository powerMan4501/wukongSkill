using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUBulletTypeList : ReadOnlyPrimitiveList<EBGUBulletType>
{
	public ReadOnlyEBGUBulletTypeList(RepeatedField<EBGUBulletType> pbData)
		: base(pbData)
	{
	}
}
