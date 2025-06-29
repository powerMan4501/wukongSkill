using UnrealEngine.Runtime;

namespace b1;

public class PS5AchievementEvent : AchievementEvent
{
	protected PS5AchievementEvent()
	{
	}

	public static AchievementEvent CreatePS5AchievementEvent(int AchievementId, int StatValue, double Progress, UObject Context)
	{
		AchievementEvent achievementEvent = AchievementEvent.CreateAchievementEvent(AchievementId, StatValue, Progress);
		achievementEvent.RegisterAction(delegate
		{
			BGW_OnlineAchievement.Get(Context).WriteAchievement(AchievementId.ToString(), StatValue, delegate(bool bSuccessful)
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
