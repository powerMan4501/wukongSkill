using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUBulletSweepCheckTypeList : ReadOnlyPrimitiveList<EBGUBulletSweepCheckType>
{
	public ReadOnlyEBGUBulletSweepCheckTypeList(RepeatedField<EBGUBulletSweepCheckType> pbData)
		: base(pbData)
	{
	}
}
