using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEItemQualityColorList : ReadOnlyPrimitiveList<EItemQualityColor>
{
	public ReadOnlyEItemQualityColorList(RepeatedField<EItemQualityColor> pbData)
		: base(pbData)
	{
	}
}
