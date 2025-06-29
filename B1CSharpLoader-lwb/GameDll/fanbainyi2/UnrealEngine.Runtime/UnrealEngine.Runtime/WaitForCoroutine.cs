namespace UnrealEngine.Runtime;

public class WaitForCoroutine : YieldInstruction
{
	public Coroutine Coroutine { get; set; }

	public override bool KeepWaiting
	{
		get
		{
			if (Coroutine != null)
			{
				return !Coroutine.Complete;
			}
			return false;
		}
	}

	public WaitForCoroutine(Coroutine coroutine)
	{
		Coroutine = coroutine;
	}

	internal WaitForCoroutine PoolNew(Coroutine coroutine)
	{
		Coroutine = coroutine;
		return this;
	}
}
