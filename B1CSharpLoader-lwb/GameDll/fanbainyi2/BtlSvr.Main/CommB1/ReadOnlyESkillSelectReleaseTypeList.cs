using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillSelectReleaseTypeList : ReadOnlyPrimitiveList<ESkillSelectReleaseType>
{
	public ReadOnlyESkillSelectReleaseTypeList(RepeatedField<ESkillSelectReleaseType> pbData)
		: base(pbData)
	{
	}
}
