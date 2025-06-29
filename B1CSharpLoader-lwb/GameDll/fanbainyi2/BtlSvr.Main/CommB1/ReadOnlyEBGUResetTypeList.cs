using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUResetTypeList : ReadOnlyPrimitiveList<EBGUResetType>
{
	public ReadOnlyEBGUResetTypeList(RepeatedField<EBGUResetType> pbData)
		: base(pbData)
	{
	}
}
