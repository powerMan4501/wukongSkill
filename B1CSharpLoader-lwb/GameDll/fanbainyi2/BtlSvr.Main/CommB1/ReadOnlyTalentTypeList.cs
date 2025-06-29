using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyTalentTypeList : ReadOnlyPrimitiveList<TalentType>
{
	public ReadOnlyTalentTypeList(RepeatedField<TalentType> pbData)
		: base(pbData)
	{
	}
}
