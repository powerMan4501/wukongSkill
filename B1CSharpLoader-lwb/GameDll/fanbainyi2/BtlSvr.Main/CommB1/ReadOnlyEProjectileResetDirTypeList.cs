using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileResetDirTypeList : ReadOnlyPrimitiveList<EProjectileResetDirType>
{
	public ReadOnlyEProjectileResetDirTypeList(RepeatedField<EProjectileResetDirType> pbData)
		: base(pbData)
	{
	}
}
