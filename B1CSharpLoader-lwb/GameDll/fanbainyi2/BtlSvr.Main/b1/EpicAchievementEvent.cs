using UnrealEngine.Runtime;

namespace b1;

public class EpicAchievementEvent : AchievementEvent
{
	protected EpicAchievementEvent()
	{
	}

	public static AchievementEvent CreateEpicAchievementEvent(int AchievementId, int StatValue, double Progress, UObject Context)
	{
		AchievementEvent achievementEvent = AchievementEvent.CreateAchievementEvent(AchievementId, StatValue, Progress);
		string StatName = AchievementEvent.GetStatNameByAchievementId(AchievementId);
		achievementEvent.RegisterAction(delegate
		{
			BGW_OnlineAchievement.Get(Context).UpdateStat(StatName, StatValue, delegate(bool bSuccessful)
			{
				if (bSuccessful)
				{
					BGW_OnlineAchievement.Get(Context).UpdateCachedAchievementProgress(AchievementId.ToString(), Progress);
				}
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
			});
		});
		return achievementEvent;
	}
}
