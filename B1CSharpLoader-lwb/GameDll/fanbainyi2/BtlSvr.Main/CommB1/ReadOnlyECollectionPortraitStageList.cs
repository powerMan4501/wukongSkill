using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyECollectionPortraitStageList : ReadOnlyPrimitiveList<ECollectionPortraitStage>
{
	public ReadOnlyECollectionPortraitStageList(RepeatedField<ECollectionPortraitStage> pbData)
		: base(pbData)
	{
	}
}
