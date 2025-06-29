using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySoulSkillDropStatusList : ReadOnlyPrimitiveList<SoulSkillDropStatus>
{
	public ReadOnlySoulSkillDropStatusList(RepeatedField<SoulSkillDropStatus> pbData)
		: base(pbData)
	{
	}
}
