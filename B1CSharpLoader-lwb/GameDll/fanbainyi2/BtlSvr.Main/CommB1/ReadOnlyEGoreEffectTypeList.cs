using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEGoreEffectTypeList : ReadOnlyPrimitiveList<EGoreEffectType>
{
	public ReadOnlyEGoreEffectTypeList(RepeatedField<EGoreEffectType> pbData)
		: base(pbData)
	{
	}
}
