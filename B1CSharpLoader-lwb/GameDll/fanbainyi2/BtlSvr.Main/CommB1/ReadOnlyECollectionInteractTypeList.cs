using BtlB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECollectionInteractTypeList : ReadOnlyPrimitiveList<ECollectionInteractType>
{
	public ReadOnlyECollectionInteractTypeList(RepeatedField<ECollectionInteractType> pbData)
		: base(pbData)
	{
	}
}
