using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FInputTrackerBase : IInputLeakHandle
{
	protected BGW_EnhancedInputMgrV2 Owner { get; set; }

	protected APlayerController LocalPlayerController => UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);

	public UObject GetOwner()
	{
		return Owner;
	}

	public virtual void OnShutdown()
	{
	}
}
