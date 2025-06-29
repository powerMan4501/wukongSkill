using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillCooldownTypeList : ReadOnlyPrimitiveList<ESkillCooldownType>
{
	public ReadOnlyESkillCooldownTypeList(RepeatedField<ESkillCooldownType> pbData)
		: base(pbData)
	{
	}
}
