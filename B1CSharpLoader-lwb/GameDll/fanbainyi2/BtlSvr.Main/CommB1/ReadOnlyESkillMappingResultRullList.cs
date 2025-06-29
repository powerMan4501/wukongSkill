using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillMappingResultRullList : ReadOnlyPrimitiveList<ESkillMappingResultRull>
{
	public ReadOnlyESkillMappingResultRullList(RepeatedField<ESkillMappingResultRull> pbData)
		: base(pbData)
	{
	}
}
