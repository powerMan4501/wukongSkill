using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEProjectileResetTargetTypeList : ReadOnlyPrimitiveList<EProjectileResetTargetType>
{
	public ReadOnlyEProjectileResetTargetTypeList(RepeatedField<EProjectileResetTargetType> pbData)
		: base(pbData)
	{
	}
}
