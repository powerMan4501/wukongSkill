using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUBloodBarShowTypeList : ReadOnlyPrimitiveList<EBGUBloodBarShowType>
{
	public ReadOnlyEBGUBloodBarShowTypeList(RepeatedField<EBGUBloodBarShowType> pbData)
		: base(pbData)
	{
	}
}
