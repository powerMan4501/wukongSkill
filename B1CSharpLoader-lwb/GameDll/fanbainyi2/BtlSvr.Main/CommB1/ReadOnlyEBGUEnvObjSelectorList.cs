using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBGUEnvObjSelectorList : ReadOnlyPrimitiveList<EBGUEnvObjSelector>
{
	public ReadOnlyEBGUEnvObjSelectorList(RepeatedField<EBGUEnvObjSelector> pbData)
		: base(pbData)
	{
	}
}
