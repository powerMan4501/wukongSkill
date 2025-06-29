using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public class ReadOnlyAchievementGradeList : ReadOnlyPrimitiveList<AchievementGrade>
{
	public ReadOnlyAchievementGradeList(RepeatedField<AchievementGrade> pbData)
		: base(pbData)
	{
	}
}
