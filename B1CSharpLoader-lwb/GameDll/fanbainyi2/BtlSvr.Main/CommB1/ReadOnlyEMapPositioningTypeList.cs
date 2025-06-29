using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEMapPositioningTypeList : ReadOnlyPrimitiveList<EMapPositioningType>
{
	public ReadOnlyEMapPositioningTypeList(RepeatedField<EMapPositioningType> pbData)
		: base(pbData)
	{
	}
}
