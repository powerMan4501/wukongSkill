using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEEffectTargetBaseList : ReadOnlyPrimitiveList<EEffectTargetBase>
{
	public ReadOnlyEEffectTargetBaseList(RepeatedField<EEffectTargetBase> pbData)
		: base(pbData)
	{
	}
}
