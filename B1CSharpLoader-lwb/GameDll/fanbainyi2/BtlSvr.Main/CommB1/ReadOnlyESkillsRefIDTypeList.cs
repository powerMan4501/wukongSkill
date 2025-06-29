using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillsRefIDTypeList : ReadOnlyPrimitiveList<ESkillsRefIDType>
{
	public ReadOnlyESkillsRefIDTypeList(RepeatedField<ESkillsRefIDType> pbData)
		: base(pbData)
	{
	}
}
