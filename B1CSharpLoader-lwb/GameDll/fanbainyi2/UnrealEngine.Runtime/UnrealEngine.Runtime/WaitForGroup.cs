namespace UnrealEngine.Runtime;

public class WaitForGroup : YieldInstruction
{
	private bool hasWaitForTicks;

	private bool hasWaitForFrames;

	private WaitForTicks waitForTicks;

	private WaitForFrames waitForFrames;

	public CoroutineGroup Group { get; set; }

	public override bool KeepWaiting
	{
		get
		{
			if (hasWaitForTicks && waitForTicks.KeepWaiting)
			{
				return true;
			}
			if (hasWaitForFrames && waitForFrames.KeepWaiting)
			{
				return true;
			}
			return false;
		}
	}

	public WaitForGroup(CoroutineGroup group, ulong skipTicks = 0uL, uint skipFrames = 0u)
	{
		Group = group;
		if (skipTicks != 0)
		{
			waitForTicks = new WaitForTicks(skipTicks);
			hasWaitForTicks = true;
		}
		if (skipFrames != 0)
		{
			waitForFrames = new WaitForFrames(skipFrames);
			hasWaitForFrames = true;
		}
	}

	public override void OnBegin()
	{
		base.Owner.TargetGroup = Group;
		if (hasWaitForTicks)
		{
			waitForTicks.OnBegin();
		}
		if (hasWaitForFrames)
		{
			waitForFrames.OnBegin();
		}
	}

	public override void OnEnd()
	{
		base.Owner.TargetGroup = CoroutineGroup.None;
		if (hasWaitForTicks)
		{
			waitForTicks.OnEnd();
		}
		if (hasWaitForFrames)
		{
			waitForFrames.OnEnd();
		}
	}

	public override void OnOwnerSet()
	{
		if (hasWaitForTicks)
		{
			waitForTicks.Owner = base.Owner;
		}
		if (hasWaitForFrames)
		{
			waitForFrames.Owner = base.Owner;
		}
	}

	internal WaitForGroup PoolNew(CoroutineGroup group, ulong skipTicks, uint skipFrames)
	{
		hasWaitForTicks = false;
		hasWaitForFrames = false;
		Group = group;
		if (skipTicks != 0)
		{
			if (waitForTicks == null)
			{
				waitForTicks = new WaitForTicks(skipTicks);
			}
			else
			{
				waitForTicks.Ticks = skipTicks;
			}
			hasWaitForTicks = true;
		}
		if (skipFrames != 0)
		{
			if (waitForFrames == null)
			{
				waitForFrames = new WaitForFrames(skipFrames);
			}
			else
			{
				waitForFrames.Frames = skipFrames;
			}
			hasWaitForFrames = true;
		}
		return this;
	}
}
