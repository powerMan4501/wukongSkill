using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyECommonErrorLevelList : ReadOnlyPrimitiveList<ECommonErrorLevel>
{
	public ReadOnlyECommonErrorLevelList(RepeatedField<ECommonErrorLevel> pbData)
		: base(pbData)
	{
	}
}
