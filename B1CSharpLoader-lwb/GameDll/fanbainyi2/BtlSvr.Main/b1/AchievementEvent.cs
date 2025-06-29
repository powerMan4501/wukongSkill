namespace b1;

public class AchievementEvent : PlatformEvent
{
	public int AchievementId;

	public int StatValue;

	public double Progress;

	protected AchievementEvent()
	{
	}

	protected static string GetStatNameByAchievementId(int AchievementId)
	{
		return "Stat_" + AchievementId;
	}

	protected static AchievementEvent CreateAchievementEvent(int AchievementId, int StatValue, double Progress)
	{
		return new AchievementEvent
		{
			AchievementId = AchievementId,
			StatValue = StatValue,
			Progress = Progress
		};
	}
}
