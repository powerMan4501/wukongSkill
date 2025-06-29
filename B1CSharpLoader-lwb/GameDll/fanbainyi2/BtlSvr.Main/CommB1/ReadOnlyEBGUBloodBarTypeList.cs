using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUBloodBarTypeList : ReadOnlyPrimitiveList<EBGUBloodBarType>
{
	public ReadOnlyEBGUBloodBarTypeList(RepeatedField<EBGUBloodBarType> pbData)
		: base(pbData)
	{
	}
}
