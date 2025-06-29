using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEEffectRangeCenterTypeList : ReadOnlyPrimitiveList<EEffectRangeCenterType>
{
	public ReadOnlyEEffectRangeCenterTypeList(RepeatedField<EEffectRangeCenterType> pbData)
		: base(pbData)
	{
	}
}
