using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECollectionStageList : ReadOnlyPrimitiveList<ECollectionStage>
{
	public ReadOnlyECollectionStageList(RepeatedField<ECollectionStage> pbData)
		: base(pbData)
	{
	}
}
