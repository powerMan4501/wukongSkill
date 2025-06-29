using UnrealEngine.Runtime;

namespace b1;

public class SetActivityAvailabilityEvent : ActivityEvent
{
	public static ActivityEvent CreateSetActivityAvailabilityEvent(int ActivityOrTaskId, bool Available, UObject Context)
	{
		ActivityEvent activityEvent = ActivityEvent.CreateActivityEvent(ActivityOrTaskId);
		activityEvent.RegisterAction(delegate
		{
			BGW_OnlineActivity.Get(Context).SetActivityAvailability(ActivityOrTaskId.ToString(), Available, delegate
			{
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
			});
		});
		return activityEvent;
	}
}
