using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyQuestStageList : ReadOnlyPrimitiveList<QuestStage>
{
	public ReadOnlyQuestStageList(RepeatedField<QuestStage> pbData)
		: base(pbData)
	{
	}
}
