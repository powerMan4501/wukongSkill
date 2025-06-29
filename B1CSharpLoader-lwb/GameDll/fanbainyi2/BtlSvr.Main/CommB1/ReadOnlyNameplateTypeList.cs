using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyNameplateTypeList : ReadOnlyPrimitiveList<NameplateType>
{
	public ReadOnlyNameplateTypeList(RepeatedField<NameplateType> pbData)
		: base(pbData)
	{
	}
}
