using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBRLimitTargetTypeList : ReadOnlyPrimitiveList<EBRLimitTargetType>
{
	public ReadOnlyEBRLimitTargetTypeList(RepeatedField<EBRLimitTargetType> pbData)
		: base(pbData)
	{
	}
}
