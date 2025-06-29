using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyPS5ActivityCategoryList : ReadOnlyPrimitiveList<PS5ActivityCategory>
{
	public ReadOnlyPS5ActivityCategoryList(RepeatedField<PS5ActivityCategory> pbData)
		: base(pbData)
	{
	}
}
