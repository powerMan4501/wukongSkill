using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyAchievementVersionList : ReadOnlyPrimitiveList<AchievementVersion>
{
	public ReadOnlyAchievementVersionList(RepeatedField<AchievementVersion> pbData)
		: base(pbData)
	{
	}
}
