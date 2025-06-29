using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESmartSelectShapeTypeList : ReadOnlyPrimitiveList<ESmartSelectShapeType>
{
	public ReadOnlyESmartSelectShapeTypeList(RepeatedField<ESmartSelectShapeType> pbData)
		: base(pbData)
	{
	}
}
