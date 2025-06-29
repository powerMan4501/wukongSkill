using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBulletOrMagicFieldMoveModeTypeList : ReadOnlyPrimitiveList<EBulletOrMagicFieldMoveModeType>
{
	public ReadOnlyEBulletOrMagicFieldMoveModeTypeList(RepeatedField<EBulletOrMagicFieldMoveModeType> pbData)
		: base(pbData)
	{
	}
}
