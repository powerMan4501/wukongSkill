using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEBRLimitTypeList : ReadOnlyPrimitiveList<EBRLimitType>
{
	public ReadOnlyEBRLimitTypeList(RepeatedField<EBRLimitType> pbData)
		: base(pbData)
	{
	}
}
