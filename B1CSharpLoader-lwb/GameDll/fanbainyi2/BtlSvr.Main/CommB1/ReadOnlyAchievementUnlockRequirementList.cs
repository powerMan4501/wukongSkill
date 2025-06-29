using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyAchievementUnlockRequirementList : ReadOnlyPrimitiveList<AchievementUnlockRequirement>
{
	public ReadOnlyAchievementUnlockRequirementList(RepeatedField<AchievementUnlockRequirement> pbData)
		: base(pbData)
	{
	}
}
