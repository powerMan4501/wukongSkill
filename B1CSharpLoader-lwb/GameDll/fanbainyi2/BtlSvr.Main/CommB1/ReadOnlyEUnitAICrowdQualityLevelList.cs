using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEUnitAICrowdQualityLevelList : ReadOnlyPrimitiveList<EUnitAICrowdQualityLevel>
{
	public ReadOnlyEUnitAICrowdQualityLevelList(RepeatedField<EUnitAICrowdQualityLevel> pbData)
		: base(pbData)
	{
	}
}
