using BtlShare;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEStoryStageRemoveList : ReadOnlyPrimitiveList<EStoryStageRemove>
{
	public ReadOnlyEStoryStageRemoveList(RepeatedField<EStoryStageRemove> pbData)
		: base(pbData)
	{
	}
}
