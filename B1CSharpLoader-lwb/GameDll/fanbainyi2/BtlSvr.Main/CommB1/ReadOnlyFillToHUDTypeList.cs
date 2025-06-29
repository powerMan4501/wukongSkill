using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyFillToHUDTypeList : ReadOnlyPrimitiveList<FillToHUDType>
{
	public ReadOnlyFillToHUDTypeList(RepeatedField<FillToHUDType> pbData)
		: base(pbData)
	{
	}
}
