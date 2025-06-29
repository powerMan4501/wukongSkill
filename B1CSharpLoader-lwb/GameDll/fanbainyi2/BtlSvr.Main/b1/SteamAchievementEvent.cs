using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class SteamAchievementEvent : AchievementEvent
{
	protected SteamAchievementEvent()
	{
	}

	public static AchievementEvent CreateSteamAchievementEvent(int AchievementId, int StatValue, double Progress, UObject Context)
	{
		AchievementEvent achievementEvent = AchievementEvent.CreateAchievementEvent(AchievementId, StatValue, Progress);
		achievementEvent.RegisterAction(delegate
		{
			AchievementDesc achievementDesc = GameDBRuntime.GetAchievementDesc(AchievementId);
			if (achievementDesc == null)
			{
				BGW_LogUtil.LogError($"CreateSteamAchievementEvent GetAchievementDesc Failed AchievementId:{AchievementId}");
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
			}
			else
			{
				bool num = achievementDesc.IsProgress == YesNoType.Yes;
				string writeObjKey = (num ? AchievementEvent.GetStatNameByAchievementId(AchievementId) : AchievementId.ToString());
				double writeObjValue = (num ? ((double)StatValue) : Progress);
				BGW_OnlineAchievement.Get(Context).WriteAchievement(writeObjKey, writeObjValue, delegate(bool bSuccessful)
				{
					if (bSuccessful)
					{
						BGW_OnlineAchievement.Get(Context).UpdateCachedAchievementProgress(AchievementId.ToString(), Progress);
					}
					BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
				});
			}
		});
		return achievementEvent;
	}
}
