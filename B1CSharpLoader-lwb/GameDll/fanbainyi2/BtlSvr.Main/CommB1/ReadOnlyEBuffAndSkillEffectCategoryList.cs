using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBuffAndSkillEffectCategoryList : ReadOnlyPrimitiveList<EBuffAndSkillEffectCategory>
{
	public ReadOnlyEBuffAndSkillEffectCategoryList(RepeatedField<EBuffAndSkillEffectCategory> pbData)
		: base(pbData)
	{
	}
}
