using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitItemFXTypeList : ReadOnlyPrimitiveList<EHitItemFXType>
{
	public ReadOnlyEHitItemFXTypeList(RepeatedField<EHitItemFXType> pbData)
		: base(pbData)
	{
	}
}
