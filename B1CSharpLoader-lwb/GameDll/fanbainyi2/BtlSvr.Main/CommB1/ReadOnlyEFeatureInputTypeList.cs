using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEFeatureInputTypeList : ReadOnlyPrimitiveList<EFeatureInputType>
{
	public ReadOnlyEFeatureInputTypeList(RepeatedField<EFeatureInputType> pbData)
		: base(pbData)
	{
	}
}
