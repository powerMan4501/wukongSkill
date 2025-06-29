using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyConsumeEffectTypeList : ReadOnlyPrimitiveList<ConsumeEffectType>
{
	public ReadOnlyConsumeEffectTypeList(RepeatedField<ConsumeEffectType> pbData)
		: base(pbData)
	{
	}
}
