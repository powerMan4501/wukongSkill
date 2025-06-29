using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillsRefWhiteListTypeList : ReadOnlyPrimitiveList<ESkillsRefWhiteListType>
{
	public ReadOnlyESkillsRefWhiteListTypeList(RepeatedField<ESkillsRefWhiteListType> pbData)
		: base(pbData)
	{
	}
}
