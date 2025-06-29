using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillMappingConditionTypeList : ReadOnlyPrimitiveList<ESkillMappingConditionType>
{
	public ReadOnlyESkillMappingConditionTypeList(RepeatedField<ESkillMappingConditionType> pbData)
		: base(pbData)
	{
	}
}
