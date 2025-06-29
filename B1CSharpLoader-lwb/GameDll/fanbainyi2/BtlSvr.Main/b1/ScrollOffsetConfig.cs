namespace b1;

public class ScrollOffsetConfig
{
	public float TargetScrollOffset;

	public bool Force;

	public bool WithAnim;

	public float ResetTime;

	public ScrollOffsetConfig(float TargetScrollOffset = 0f, bool Force = false, bool WithAnim = false, float ResetTime = 0f)
	{
		this.TargetScrollOffset = TargetScrollOffset;
		this.Force = Force;
		this.WithAnim = WithAnim;
		this.ResetTime = ResetTime;
	}
}
