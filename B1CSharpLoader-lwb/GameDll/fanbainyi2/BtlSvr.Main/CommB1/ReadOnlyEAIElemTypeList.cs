using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEAIElemTypeList : ReadOnlyPrimitiveList<EAIElemType>
{
	public ReadOnlyEAIElemTypeList(RepeatedField<EAIElemType> pbData)
		: base(pbData)
	{
	}
}
