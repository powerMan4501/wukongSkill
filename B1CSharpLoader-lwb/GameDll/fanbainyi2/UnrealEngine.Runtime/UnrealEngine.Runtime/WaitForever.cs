namespace UnrealEngine.Runtime;

public class WaitForever : YieldInstruction
{
	private bool complete;

	public override bool KeepWaiting
	{
		get
		{
			if (!complete)
			{
				return base.Owner.IsPaused;
			}
			return false;
		}
	}

	public override void OnBegin()
	{
		base.Owner.IsPaused = true;
	}

	public void Continue()
	{
		complete = true;
	}

	public void Reset()
	{
		complete = false;
	}

	internal WaitForever PoolNew()
	{
		complete = false;
		return this;
	}
}
