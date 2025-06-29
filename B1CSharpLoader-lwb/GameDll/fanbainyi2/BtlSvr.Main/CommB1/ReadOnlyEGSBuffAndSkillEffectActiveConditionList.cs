using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEGSBuffAndSkillEffectActiveConditionList : ReadOnlyPrimitiveList<EGSBuffAndSkillEffectActiveCondition>
{
	public ReadOnlyEGSBuffAndSkillEffectActiveConditionList(RepeatedField<EGSBuffAndSkillEffectActiveCondition> pbData)
		: base(pbData)
	{
	}
}
