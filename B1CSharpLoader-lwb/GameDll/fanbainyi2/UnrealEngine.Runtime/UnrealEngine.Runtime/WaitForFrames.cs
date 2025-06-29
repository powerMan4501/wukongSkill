namespace UnrealEngine.Runtime;

public class WaitForFrames : WaitForExactFrame
{
	private ulong frames;

	public ulong Frames
	{
		get
		{
			return frames;
		}
		set
		{
			frames = value;
			UpdateRelativeFrame(value);
		}
	}

	public WaitForFrames(ulong frames)
		: base(frames, relative: true)
	{
		this.frames = frames;
	}

	internal WaitForFrames PoolNew(ulong frames)
	{
		Frames = frames;
		return this;
	}
}
