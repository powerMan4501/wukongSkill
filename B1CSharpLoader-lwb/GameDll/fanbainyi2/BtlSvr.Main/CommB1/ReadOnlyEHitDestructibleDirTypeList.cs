using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitDestructibleDirTypeList : ReadOnlyPrimitiveList<EHitDestructibleDirType>
{
	public ReadOnlyEHitDestructibleDirTypeList(RepeatedField<EHitDestructibleDirType> pbData)
		: base(pbData)
	{
	}
}
