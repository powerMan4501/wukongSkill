using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffLayerDispMixTypeList : ReadOnlyPrimitiveList<EBuffLayerDispMixType>
{
	public ReadOnlyEBuffLayerDispMixTypeList(RepeatedField<EBuffLayerDispMixType> pbData)
		: base(pbData)
	{
	}
}
