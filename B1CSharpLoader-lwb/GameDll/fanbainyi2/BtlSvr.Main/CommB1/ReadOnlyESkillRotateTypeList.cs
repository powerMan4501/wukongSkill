using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillRotateTypeList : ReadOnlyPrimitiveList<ESkillRotateType>
{
	public ReadOnlyESkillRotateTypeList(RepeatedField<ESkillRotateType> pbData)
		: base(pbData)
	{
	}
}
