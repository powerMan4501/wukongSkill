using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillDamageTypeList : ReadOnlyPrimitiveList<ESkillDamageType>
{
	public ReadOnlyESkillDamageTypeList(RepeatedField<ESkillDamageType> pbData)
		: base(pbData)
	{
	}
}
