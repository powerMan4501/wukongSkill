using UnrealEngine.Runtime;

namespace b1;

public class EndActivityEvent : ActivityEvent
{
	protected EndActivityEvent()
	{
	}

	public static ActivityEvent CreateEndActivityEvent(int ActivityOrTaskId, UObject Context)
	{
		ActivityEvent activityEvent = ActivityEvent.CreateActivityEvent(ActivityOrTaskId);
		activityEvent.RegisterAction(delegate
		{
			BGW_OnlineActivity.Get(Context).EndActivity(ActivityOrTaskId.ToString(), EOnlineActivityOutcomeType.Completed, delegate
			{
				BGW_PlatformEventExecMgr.Get(Context).MarkTaskCompleted();
			});
		});
		return activityEvent;
	}
}
