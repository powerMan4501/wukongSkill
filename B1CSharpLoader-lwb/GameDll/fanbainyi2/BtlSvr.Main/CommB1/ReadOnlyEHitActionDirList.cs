using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitActionDirList : ReadOnlyPrimitiveList<EHitActionDir>
{
	public ReadOnlyEHitActionDirList(RepeatedField<EHitActionDir> pbData)
		: base(pbData)
	{
	}
}
