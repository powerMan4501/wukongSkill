using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlySoulSkillTypeList : ReadOnlyPrimitiveList<SoulSkillType>
{
	public ReadOnlySoulSkillTypeList(RepeatedField<SoulSkillType> pbData)
		: base(pbData)
	{
	}
}
