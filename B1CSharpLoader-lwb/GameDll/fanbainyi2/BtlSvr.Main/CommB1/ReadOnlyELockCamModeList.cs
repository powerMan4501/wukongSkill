using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyELockCamModeList : ReadOnlyPrimitiveList<ELockCamMode>
{
	public ReadOnlyELockCamModeList(RepeatedField<ELockCamMode> pbData)
		: base(pbData)
	{
	}
}
