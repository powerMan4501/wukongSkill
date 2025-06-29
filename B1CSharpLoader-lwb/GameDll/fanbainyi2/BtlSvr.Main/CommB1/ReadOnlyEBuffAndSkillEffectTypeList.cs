using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffAndSkillEffectTypeList : ReadOnlyPrimitiveList<EBuffAndSkillEffectType>
{
	public ReadOnlyEBuffAndSkillEffectTypeList(RepeatedField<EBuffAndSkillEffectType> pbData)
		: base(pbData)
	{
	}
}
