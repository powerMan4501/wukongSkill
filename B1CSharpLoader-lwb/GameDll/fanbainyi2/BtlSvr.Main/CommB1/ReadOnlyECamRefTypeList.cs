using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECamRefTypeList : ReadOnlyPrimitiveList<ECamRefType>
{
	public ReadOnlyECamRefTypeList(RepeatedField<ECamRefType> pbData)
		: base(pbData)
	{
	}
}
