using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FInputProcessorBase : IInputLeakHandle
{
	protected APlayerController Owner { get; set; }

	protected APlayerController PlayerController => Owner;

	public UObject GetOwner()
	{
		return Owner;
	}

	public virtual void OnShutdown()
	{
	}
}
