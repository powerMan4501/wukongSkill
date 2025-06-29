using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEMagicSkillOperationModeList : ReadOnlyPrimitiveList<EMagicSkillOperationMode>
{
	public ReadOnlyEMagicSkillOperationModeList(RepeatedField<EMagicSkillOperationMode> pbData)
		: base(pbData)
	{
	}
}
