namespace b1;

public class ActivityEvent : PlatformEvent
{
	public int ActivityOrTaskId;

	protected ActivityEvent()
	{
	}

	protected static ActivityEvent CreateActivityEvent(int ActivityOrTaskId)
	{
		return new ActivityEvent
		{
			ActivityOrTaskId = ActivityOrTaskId
		};
	}
}
