using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSBuffLayerCounterTypeList : ReadOnlyPrimitiveList<EGSBuffLayerCounterType>
{
	public ReadOnlyEGSBuffLayerCounterTypeList(RepeatedField<EGSBuffLayerCounterType> pbData)
		: base(pbData)
	{
	}
}
