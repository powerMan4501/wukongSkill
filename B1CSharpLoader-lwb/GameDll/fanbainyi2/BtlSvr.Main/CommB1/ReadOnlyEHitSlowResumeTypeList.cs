using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEHitSlowResumeTypeList : ReadOnlyPrimitiveList<EHitSlowResumeType>
{
	public ReadOnlyEHitSlowResumeTypeList(RepeatedField<EHitSlowResumeType> pbData)
		: base(pbData)
	{
	}
}
