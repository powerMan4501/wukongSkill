using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class DestructiblePhysicsCompInfo
{
	public UMeshComponent PhysicsComp;

	public USceneComponent AttachedComp;

	public FTransform RelativeTransform;

	public bool DefaultSimulate;

	public bool DeactivateAfterDestruction;

	public bool DetachAfterDestruction;

	public bool CanSimulatePhysics;

	public DestructiblePhysicsCompInfo()
	{
		CanSimulatePhysics = (DefaultSimulate = true);
		DeactivateAfterDestruction = true;
		DetachAfterDestruction = true;
	}
}
