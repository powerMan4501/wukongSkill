using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUBulletRecoveryModeList : ReadOnlyPrimitiveList<EBGUBulletRecoveryMode>
{
	public ReadOnlyEBGUBulletRecoveryModeList(RepeatedField<EBGUBulletRecoveryMode> pbData)
		: base(pbData)
	{
	}
}
