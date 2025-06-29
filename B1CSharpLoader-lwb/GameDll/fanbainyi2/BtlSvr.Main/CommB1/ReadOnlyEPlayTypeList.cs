using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEPlayTypeList : ReadOnlyPrimitiveList<EPlayType>
{
	public ReadOnlyEPlayTypeList(RepeatedField<EPlayType> pbData)
		: base(pbData)
	{
	}
}
