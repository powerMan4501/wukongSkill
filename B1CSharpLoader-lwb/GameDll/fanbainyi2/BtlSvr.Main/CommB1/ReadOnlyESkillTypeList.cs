using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillTypeList : ReadOnlyPrimitiveList<ESkillType>
{
	public ReadOnlyESkillTypeList(RepeatedField<ESkillType> pbData)
		: base(pbData)
	{
	}
}
