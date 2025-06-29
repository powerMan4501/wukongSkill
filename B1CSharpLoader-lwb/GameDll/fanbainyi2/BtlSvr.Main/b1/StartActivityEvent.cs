using UnrealEngine.Runtime;

namespace b1;

public class StartActivityEvent : ActivityEvent
{
	public static ActivityEvent CreateStartActivityEvent(int ActivityOrTaskId, UObject Context)
	{
		ActivityEvent activityEvent = ActivityEvent.CreateActivityEvent(ActivityOrTaskId);
		activityEvent.RegisterAction(delegate
		{
			BGW_OnlineActivity.Get(Context).StartActivity(ActivityOrTaskId.ToString(), delegate(bool bSuccessful)
			{
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
				BGW_OnlineActivity.Get(Context).SetCurActivityId(ActivityOrTaskId, $"StartActivity {ActivityOrTaskId} {bSuccessful}");
			});
		});
		return activityEvent;
	}
}
