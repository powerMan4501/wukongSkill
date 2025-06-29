using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHudShowTypeList : ReadOnlyPrimitiveList<EHudShowType>
{
	public ReadOnlyEHudShowTypeList(RepeatedField<EHudShowType> pbData)
		: base(pbData)
	{
	}
}
