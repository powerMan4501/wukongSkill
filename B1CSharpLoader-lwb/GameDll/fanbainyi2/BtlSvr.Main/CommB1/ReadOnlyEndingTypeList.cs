using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEndingTypeList : ReadOnlyPrimitiveList<EndingType>
{
	public ReadOnlyEndingTypeList(RepeatedField<EndingType> pbData)
		: base(pbData)
	{
	}
}
