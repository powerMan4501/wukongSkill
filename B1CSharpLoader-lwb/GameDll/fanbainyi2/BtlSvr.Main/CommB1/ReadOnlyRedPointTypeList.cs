using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRedPointTypeList : ReadOnlyPrimitiveList<RedPointType>
{
	public ReadOnlyRedPointTypeList(RepeatedField<RedPointType> pbData)
		: base(pbData)
	{
	}
}
