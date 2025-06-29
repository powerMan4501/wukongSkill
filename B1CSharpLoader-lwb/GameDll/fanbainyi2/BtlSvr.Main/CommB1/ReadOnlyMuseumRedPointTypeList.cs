using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMuseumRedPointTypeList : ReadOnlyPrimitiveList<MuseumRedPointType>
{
	public ReadOnlyMuseumRedPointTypeList(RepeatedField<MuseumRedPointType> pbData)
		: base(pbData)
	{
	}
}
