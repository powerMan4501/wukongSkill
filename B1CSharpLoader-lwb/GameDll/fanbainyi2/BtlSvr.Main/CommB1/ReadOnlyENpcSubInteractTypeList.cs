using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyENpcSubInteractTypeList : ReadOnlyPrimitiveList<ENpcSubInteractType>
{
	public ReadOnlyENpcSubInteractTypeList(RepeatedField<ENpcSubInteractType> pbData)
		: base(pbData)
	{
	}
}
