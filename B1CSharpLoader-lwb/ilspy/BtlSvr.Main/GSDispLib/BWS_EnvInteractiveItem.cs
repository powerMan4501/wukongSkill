using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_EnvInteractiveItem
{
	public int Id;

	public FVector Position;

	public FVector Size;

	public int InteractiveType;

	public float Intensity = 1f;

	public float Duration = 0.5f;

	public virtual bool OnTick()
	{
		return true;
	}
}
