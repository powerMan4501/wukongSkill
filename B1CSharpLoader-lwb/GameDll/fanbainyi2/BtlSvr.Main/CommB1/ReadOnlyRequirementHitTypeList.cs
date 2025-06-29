using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyRequirementHitTypeList : ReadOnlyPrimitiveList<RequirementHitType>
{
	public ReadOnlyRequirementHitTypeList(RepeatedField<RequirementHitType> pbData)
		: base(pbData)
	{
	}
}
