using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEChallengeSuccessTypeList : ReadOnlyPrimitiveList<EChallengeSuccessType>
{
	public ReadOnlyEChallengeSuccessTypeList(RepeatedField<EChallengeSuccessType> pbData)
		: base(pbData)
	{
	}
}
