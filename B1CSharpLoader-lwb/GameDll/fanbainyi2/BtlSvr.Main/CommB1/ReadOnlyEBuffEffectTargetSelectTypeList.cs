using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffEffectTargetSelectTypeList : ReadOnlyPrimitiveList<EBuffEffectTargetSelectType>
{
	public ReadOnlyEBuffEffectTargetSelectTypeList(RepeatedField<EBuffEffectTargetSelectType> pbData)
		: base(pbData)
	{
	}
}
