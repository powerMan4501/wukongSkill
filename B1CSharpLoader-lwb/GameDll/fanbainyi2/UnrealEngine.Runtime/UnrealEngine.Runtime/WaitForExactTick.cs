namespace UnrealEngine.Runtime;

public class WaitForExactTick : ComparableYieldInstruction<WaitForExactTick>
{
	private bool isRelative;

	private ulong relativeTick;

	private ulong startTick;

	private ulong targetTick;

	public ulong TargetTick
	{
		get
		{
			return targetTick;
		}
		set
		{
			if (targetTick != value)
			{
				targetTick = value;
				ComparableValueChanged();
			}
		}
	}

	public override bool KeepWaiting => TargetTick > EngineLoop.WorldTickCounter;

	public WaitForExactTick(ulong tick)
		: this(tick, relative: false)
	{
	}

	internal WaitForExactTick(ulong tick, bool relative)
	{
		isRelative = relative;
		if (isRelative)
		{
			relativeTick = tick;
		}
		else
		{
			TargetTick = tick;
		}
	}

	public override void OnBegin()
	{
		if (isRelative)
		{
			startTick = EngineLoop.WorldTickCounter;
			UpdateRelativeTick();
		}
	}

	protected void UpdateRelativeTick(ulong tick)
	{
		relativeTick = tick;
		UpdateRelativeTick();
	}

	private void UpdateRelativeTick()
	{
		if (isRelative)
		{
			TargetTick = startTick + relativeTick;
		}
	}

	public override int CompareTo(WaitForExactTick other)
	{
		return TargetTick.CompareTo(other.TargetTick);
	}

	internal WaitForExactTick PoolNew(ulong tick, bool relative)
	{
		isRelative = relative;
		if (relative)
		{
			relativeTick = tick;
		}
		else
		{
			TargetTick = tick;
		}
		return this;
	}
}
