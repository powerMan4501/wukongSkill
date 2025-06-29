using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyEditionTypeList : ReadOnlyPrimitiveList<EditionType>
{
	public ReadOnlyEditionTypeList(RepeatedField<EditionType> pbData)
		: base(pbData)
	{
	}
}
