using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitOrientationTypeList : ReadOnlyPrimitiveList<EHitOrientationType>
{
	public ReadOnlyEHitOrientationTypeList(RepeatedField<EHitOrientationType> pbData)
		: base(pbData)
	{
	}
}
