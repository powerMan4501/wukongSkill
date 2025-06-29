using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyELandFXPlayTypeList : ReadOnlyPrimitiveList<ELandFXPlayType>
{
	public ReadOnlyELandFXPlayTypeList(RepeatedField<ELandFXPlayType> pbData)
		: base(pbData)
	{
	}
}
