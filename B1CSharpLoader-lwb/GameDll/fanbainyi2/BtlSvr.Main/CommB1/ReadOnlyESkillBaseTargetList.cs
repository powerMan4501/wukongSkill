using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillBaseTargetList : ReadOnlyPrimitiveList<ESkillBaseTarget>
{
	public ReadOnlyESkillBaseTargetList(RepeatedField<ESkillBaseTarget> pbData)
		: base(pbData)
	{
	}
}
