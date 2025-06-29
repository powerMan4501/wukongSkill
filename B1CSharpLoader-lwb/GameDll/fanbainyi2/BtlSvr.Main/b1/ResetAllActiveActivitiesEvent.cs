using UnrealEngine.Runtime;

namespace b1;

public class ResetAllActiveActivitiesEvent : ActivityEvent
{
	protected ResetAllActiveActivitiesEvent()
	{
	}

	public static ActivityEvent CreateResetAllActiveActivitiesEvent(UObject Context)
	{
		ActivityEvent activityEvent = ActivityEvent.CreateActivityEvent(-1);
		activityEvent.RegisterAction(delegate
		{
			BGW_OnlineActivity.Get(Context).ResetAllActiveActivities(delegate
			{
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
			});
		});
		return activityEvent;
	}
}
