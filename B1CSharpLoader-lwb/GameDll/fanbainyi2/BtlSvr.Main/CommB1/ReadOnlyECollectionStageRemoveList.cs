using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECollectionStageRemoveList : ReadOnlyPrimitiveList<ECollectionStageRemove>
{
	public ReadOnlyECollectionStageRemoveList(RepeatedField<ECollectionStageRemove> pbData)
		: base(pbData)
	{
	}
}
