using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESkillSelectOpTypeList : ReadOnlyPrimitiveList<ESkillSelectOpType>
{
	public ReadOnlyESkillSelectOpTypeList(RepeatedField<ESkillSelectOpType> pbData)
		: base(pbData)
	{
	}
}
