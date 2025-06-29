using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyESequenceTypeList : ReadOnlyPrimitiveList<ESequenceType>
{
	public ReadOnlyESequenceTypeList(RepeatedField<ESequenceType> pbData)
		: base(pbData)
	{
	}
}
