namespace UnrealEngine.Runtime;

public class WaitForExactFrame : ComparableYieldInstruction<WaitForExactFrame>
{
	private bool isRelative;

	private ulong relativeFrame;

	private ulong startFrame;

	private ulong targetFrame;

	public ulong TargetFrame
	{
		get
		{
			return targetFrame;
		}
		set
		{
			if (targetFrame != value)
			{
				targetFrame = value;
				ComparableValueChanged();
			}
		}
	}

	public override bool KeepWaiting => TargetFrame > EngineLoop.WorldFrameNumber;

	public WaitForExactFrame(ulong frame)
		: this(frame, relative: false)
	{
	}

	internal WaitForExactFrame(ulong frame, bool relative)
	{
		isRelative = relative;
		if (relative)
		{
			relativeFrame = frame;
		}
		else
		{
			TargetFrame = frame;
		}
	}

	public override void OnBegin()
	{
		if (isRelative)
		{
			startFrame = EngineLoop.WorldFrameNumber;
			UpdateRelativeFrame();
		}
	}

	protected void UpdateRelativeFrame(ulong frame)
	{
		relativeFrame = frame;
		UpdateRelativeFrame();
	}

	private void UpdateRelativeFrame()
	{
		if (isRelative)
		{
			TargetFrame = startFrame + relativeFrame;
		}
	}

	public override int CompareTo(WaitForExactFrame other)
	{
		return TargetFrame.CompareTo(other.TargetFrame);
	}

	internal WaitForExactFrame PoolNew(ulong frame, bool relative)
	{
		isRelative = relative;
		if (relative)
		{
			relativeFrame = frame;
		}
		else
		{
			TargetFrame = frame;
		}
		return this;
	}
}
