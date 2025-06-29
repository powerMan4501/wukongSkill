using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECameraTypeList : ReadOnlyPrimitiveList<ECameraType>
{
	public ReadOnlyECameraTypeList(RepeatedField<ECameraType> pbData)
		: base(pbData)
	{
	}
}
