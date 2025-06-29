using System;

namespace b1;

public class PlatformEvent
{
	private Action Action;

	private bool Completed;

	public bool IsCompleted => Completed;

	protected PlatformEvent()
	{
	}

	public void RegisterAction(Action Action)
	{
		this.Action = Action;
		Completed = false;
	}

	public void MarkCompleted()
	{
		Completed = true;
	}

	public Action GetAction()
	{
		return Action;
	}
}
