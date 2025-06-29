namespace UnrealEngine.Runtime;

public class WaitWhile : YieldInstruction
{
	public WaitWhileCallback Callback { get; set; }

	public override bool KeepWaiting
	{
		get
		{
			if (Callback != null)
			{
				return Callback();
			}
			return false;
		}
	}

	public WaitWhile(WaitWhileCallback callback)
	{
		Callback = callback;
	}

	internal WaitWhile PoolNew(WaitWhileCallback callback)
	{
		Callback = callback;
		return this;
	}
}
