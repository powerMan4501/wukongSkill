using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSRoarWeightLevelList : ReadOnlyPrimitiveList<EGSRoarWeightLevel>
{
	public ReadOnlyEGSRoarWeightLevelList(RepeatedField<EGSRoarWeightLevel> pbData)
		: base(pbData)
	{
	}
}
