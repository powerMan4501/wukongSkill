using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUMagicFieldGenTypeList : ReadOnlyPrimitiveList<EBGUMagicFieldGenType>
{
	public ReadOnlyEBGUMagicFieldGenTypeList(RepeatedField<EBGUMagicFieldGenType> pbData)
		: base(pbData)
	{
	}
}
