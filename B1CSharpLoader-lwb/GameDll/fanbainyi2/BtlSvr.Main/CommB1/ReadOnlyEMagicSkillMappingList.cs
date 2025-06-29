using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMagicSkillMappingList : ReadOnlyPrimitiveList<EMagicSkillMapping>
{
	public ReadOnlyEMagicSkillMappingList(RepeatedField<EMagicSkillMapping> pbData)
		: base(pbData)
	{
	}
}
