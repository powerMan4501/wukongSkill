using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffRangeTargetBaseList : ReadOnlyPrimitiveList<EBuffRangeTargetBase>
{
	public ReadOnlyEBuffRangeTargetBaseList(RepeatedField<EBuffRangeTargetBase> pbData)
		: base(pbData)
	{
	}
}
