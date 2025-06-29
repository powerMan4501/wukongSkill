namespace UnrealEngine.Runtime;

public class WaitUntil : YieldInstruction
{
	public WaitUntilCallback Callback { get; set; }

	public override bool KeepWaiting
	{
		get
		{
			if (Callback != null)
			{
				return !Callback();
			}
			return false;
		}
	}

	public WaitUntil(WaitUntilCallback callback)
	{
		Callback = callback;
	}

	internal WaitUntil PoolNew(WaitUntilCallback callback)
	{
		Callback = callback;
		return this;
	}
}
